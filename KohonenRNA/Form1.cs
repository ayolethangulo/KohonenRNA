using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KohonenRNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCoeficienteVecindad.Enabled = false;
            btnInicializarPesos.Enabled = false;
            btnEntrenamiento.Enabled = false;
            lblNumVecinas.Enabled = false;
            lblCantVecinas.Enabled = false;
            lblDT.Enabled = false;
            lblNumDT.Enabled = false;
        }

        //Declaración de variables globales
        double coeficienteV = 0, DT = 0, DM = 0;
        double rataAprendizaje =0, canIteracionesXP;
        int banderaCanVecinas = 0, banderapesost = 0;
        double numPatrones, numNeuronasMapa, numEntradas, numIteraciones;
        double numFilaPO, numColmPO; 
        List<string> listPatrones = new List<string>();
        List<string> listPatronOptimo;
        List<string> listPatronesOptimos = new List<string>();
        string tipoCompetencia = "";
        double[,] matrizPesos;
        double[,] matrizPesosOptimos;
        string[] obtenerPatrones;
        string[] obtenerPesosO;
        string[] obtenerPatronesOp;
        double[] distanciaE;
        double[] distanciasEvXPatron;
        double[] posicionesVecinas;

        //abrir cuadro de dialogo para cargar datos de entrada
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // abrir cuadro de dialogo
                this.ofdCargarDatos.InitialDirectory = @"C:\";
                this.ofdCargarDatos.Title = "Datos";
                this.ofdCargarDatos.CheckFileExists = true;
                this.ofdCargarDatos.CheckPathExists = true;
                this.ofdCargarDatos.DefaultExt = ".txt";
                this.ofdCargarDatos.Filter = "Archivos (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";
                this.ofdCargarDatos.RestoreDirectory = true;
                this.ofdCargarDatos.FilterIndex = 2;
                this.ofdCargarDatos.ShowReadOnly = true;
                this.ofdCargarDatos.ReadOnlyChecked = true;
                if (this.ofdCargarDatos.ShowDialog() == DialogResult.OK)
                {
                    //llenar la tabla
                    this.tablaDatosEntrada.AutoGenerateColumns = true;
                    this.tablaDatosEntrada.DataSource = this.CargarDatosTabla(this.ofdCargarDatos.FileName);
                    this.CargarListaPatrones(this.ofdCargarDatos.FileName);
                    
                    lblNumEntradas.Text = numEntradas.ToString().Trim();
                    lblNumPatrones.Text = numPatrones.ToString().Trim();
                }
            }
            catch (Exception ex)
            {

                string m = ex.Message;
            }

        }

        //cargar  datos de entrada en el datagrid
        private DataTable CargarDatosTabla(string fileName)
        {
            DataTable datos = new DataTable();
            int countRow = 0;
            int countColumn = 0;
            numEntradas = 0;
            numPatrones = 0;

            try
            {
                //leer el archivo
                FileInfo fileInfo = new FileInfo(fileName);
                StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
                using (reader = fileInfo.OpenText())
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (countRow == 0)
                        {
                            //Mostrar columnas
                            var getColumns = line.Split(';');
                            countColumn = getColumns.Length;
                            numEntradas = countColumn; //para obtener la cantidad de entradas

                            foreach (string item in getColumns)
                            {
                                datos.Columns.Add(item.Split('\r')[0].Trim());
                            }
                            countRow++;

                        }
                        else
                        {
                            //Mostrar filas
                            var getRow = line.Split(';');
                            if (string.IsNullOrEmpty(getRow[0].Split('\r')[0].Trim()))
                            {
                                continue;
                            }

                            DataRow drRow = datos.NewRow();
                            int colsCount = 0;
                            foreach (var item in getRow)
                            {
                                if (colsCount < countColumn)
                                {
                                    drRow[colsCount] = item.Split('\r')[0].Trim();
                                }
                                colsCount++;
                            }
                            numPatrones++; //obtener cantidad de patrones
                            datos.Rows.Add(drRow);
                        }
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message, ex);
            }
        }

        //cargar datos de entrada x patrones en una lista
        private void CargarListaPatrones(string fileName)
        {
            int bandera = 0;
            listPatrones.Clear();
            TextReader reader = new StreamReader(File.OpenRead(fileName));
            string fila;
            while ((fila = reader.ReadLine()) != null)
            {
                if (bandera == 0)
                {
                    bandera = 1;
                }
                else
                {
                    listPatrones.Add(fila);
                }
            }
            reader.Close();
        }

        //configurar la red
        private void btnConfigurarRed_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            numNeuronasMapa = 0; numIteraciones = 0;
            //Validación de numero de neuronas del mapa 
            if (txtNumNeuronasMapa.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Debe digitar el numero de neuronas que va tener el mapa " + 
                    "No debe ser número primo y debe ser el doble de la cantidad de neuronas de entrada");
                bandera = 1;
            }
            else
            {
                numNeuronasMapa = double.Parse(txtNumNeuronasMapa.Text.ToString().Trim());

                if (EsPrimo(numNeuronasMapa))
                {
                    MessageBox.Show("Digite la cantidad de neuronas del mapa que no sea número primo");
                    numNeuronasMapa = 0;
                    bandera = 1;
                }
            }
            //Validación del numero de iteraciones
            if (txtNumIteraciones.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Digite el número de iteraciones que desea realizar");
                bandera = 1;
            }
            else
            {
                numIteraciones = double.Parse(txtNumIteraciones.Text.ToString().Trim());
                if (numIteraciones <= 0)
                {
                    MessageBox.Show("Digite el número de iteraciones... ¡número positivo mayor que 0!");
                    bandera = 1;
                }
            }
            //Validación del tipo de competencia y del coeficiente de vecindad
            if (tipoCompetencia.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un tipo de competencia");
                bandera = 1;
            }
            else
            {
                if (tipoCompetencia.Equals("Blanda"))
                {
                    lblCantVecinas.Enabled = true;
                    lblNumVecinas.Enabled = true;
                    lblDT.Enabled = true;
                    lblNumDT.Enabled = true;
                    if (txtCoeficienteVecindad.Text.ToString().Trim().Equals(""))
                    {
                        MessageBox.Show("Si la competencia es blanda debe digitar el número del coeficiente de vecindad");
                        bandera = 1;
                    }
                    else
                    {
                        coeficienteV = double.Parse(txtCoeficienteVecindad.Text.ToString().Trim());
                        if ((coeficienteV <= 0) || (coeficienteV > 1))
                        {
                            MessageBox.Show("El coeficiente de vecindad debe estar en un rango entre 0 y 1 sin tomar el 0 Gracias.");
                            coeficienteV = 0;
                            bandera = 1;
                        }
                    }
                }
            }

            //habilitar inicializar Pesos
            if (bandera == 0)
            {
                btnInicializarPesos.Enabled = true;
            }
        }

        //Función para validar si un numero es primo
        private bool EsPrimo(double numero)
        {

            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo
                    return false;
                }
            }
            // Es primo
            return true;
        }

        //Evento click del boton para entrenar la red
        private void btnEntrenamiento_Click(object sender, EventArgs e)
        {
            //hilo para ir pausando el entrenamiento
            Thread thread = new Thread(new ThreadStart(EntrenarRed));
             CheckForIllegalCrossThreadCalls = false;
             thread.Start();
           
        }
        
        //funcion entrenar red
        private void EntrenarRed()
        {
            canIteracionesXP = 0;
            double resultadorata = 0;
            //ciclo para recorrer por numero de iteracciones
            do
            {
                canIteracionesXP++;
                resultadorata = 1 / canIteracionesXP;
                rataAprendizaje = Math.Round(resultadorata, 2);
                lblRataAprendizaje.Text = rataAprendizaje.ToString();
                distanciasEvXPatron = new double[(int)numPatrones];

                //ciclo para recorrer los patrones
                //m = 0;
                double sumaDm = 0;
                for (int a = 0; a < numPatrones; a++)
                {
                    //presento el patron
                    //m++;
                    //vector que tiene cada entrada por patron
                    obtenerPatrones = new string[(int)numEntradas];
                    obtenerPatrones = listPatrones[a].Split(';');
                    int posicionVencedora = CalcularDistanciaEuclidiana();
                    ActivarCompetencia(posicionVencedora);
                    //MessageBox.Show("Patrón # " + i + 1);
                    distanciasEvXPatron[a] = Math.Round(distanciaE[posicionVencedora],2);
                }

                for (int l = 0; l < numPatrones; l++)
                {
                    //MessageBox.Show("Distanciaxpatron"+distanciasEvXPatron[l].ToString());
                    sumaDm = sumaDm + distanciasEvXPatron[l];
                    //MessageBox.Show("Suma DM "+sumaDm.ToString());

                }
                DM = sumaDm / numPatrones;
                //MessageBox.Show("DM "+sumaDm.ToString());
                if (Double.IsInfinity(DM))
                {
                    MessageBox.Show("El valor de DM tiende a infinito. reinicialice la red.");
                    canIteracionesXP = numIteraciones;
                    matrizPesos = new double[(int)numEntradas, (int)numNeuronasMapa];
                    continue;
                }
                //GuardarPesos();
                if ((DM >= 0) && (DM < 1))
                {
                    GuardarPesos();
                }
                lblDM.Text = DM.ToString();
                lbliteracionMomento.Text = canIteracionesXP.ToString();
               // MessageBox.Show("iteracion" + canIteracionesXP);
                chartDM.Series["DM"].Points.AddXY(canIteracionesXP, DM);
               Thread.Sleep(200);
            } while ((DM != 0) && (canIteracionesXP < numIteraciones));
        }

        private void GuardarPesos()
        {
            List<string> listPesos = new List<string>();
            
             for (int i = 0; i < numEntradas; i++)
             {
                string variable = "";
                for (int j = 0; j < numNeuronasMapa; j++)
                 {
                     variable = variable + matrizPesos[i, j].ToString()+";";
                 }
                listPesos.Add(variable);
             }
             
             string ruta = @"D:\upc\fisica-calculos-SO-etc\inteligencia artificial\Banco de datos\Kohonen\PesosOptimos.txt";
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(listPesos[0]);
            writer.Close();
            fileStream.Close();

            int b = 0;
            foreach (var item in listPesos)
            {
                if (b==0)
                {
                    b = 1;
                }
                else
                {
                    FileStream fileS = new FileStream(ruta, FileMode.Append);
                    StreamWriter writerr = new StreamWriter(fileS);
                    writerr.WriteLine(item.Trim());
                    writerr.Close();
                    fileS.Close();
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActivarCompetencia(int posicionVencedora)
        {
            DT = 0;
            int totalNeuronasA = 0;
            if (tipoCompetencia.Equals("Blanda"))
            {
                CalcularNeuronasVecinas(posicionVencedora);
                totalNeuronasA = posicionesVecinas.Length;
            }
            AlgoritmoDeEntrenamiento(totalNeuronasA, posicionVencedora);
        }

        //Actualiza pesos que se relacionan con la DV si es blanda sino solo los pesos de la DV
        private void AlgoritmoDeEntrenamiento(int totalNeuronasA, int posicionVencedora)
        {
            int neuronaMomento = 0;
            double numero = 0;
            //Actualiza los pesos de la neurona vencedora
            for (int j = 0; j < numEntradas; j++)
            {
                numero = matrizPesos[j, posicionVencedora] + rataAprendizaje * distanciaE[posicionVencedora];
                matrizPesos[j, posicionVencedora] = Math.Round(numero, 2);
            }
            //si es blanda actualiza los pesos de las vecinas
            if (tipoCompetencia.Equals("Blanda"))
            {
                numero = 0;
                if (banderaCanVecinas == 0)
                {
                    for (int i = 0; i < totalNeuronasA; i++)
                    {
                        neuronaMomento = (int)posicionesVecinas[i];
                        for (int j = 0; j < numEntradas; j++)
                        {
                            numero = matrizPesos[j, neuronaMomento] + rataAprendizaje * distanciaE[posicionVencedora];
                            matrizPesos[j, neuronaMomento] = Math.Round(numero, 2);
                        }
                    }
                } 
            }
            LlenarTablaPesos();
        }

        //Calcula las neuronas vecinas del tipo de competencia blanda
        private void CalcularNeuronasVecinas(int posicionVencedora)
        {
            //conseguir neuronas vecinas
            int canVecinas = 0; banderaCanVecinas = 0;
            DT = distanciaE[posicionVencedora] + coeficienteV;
            lblNumDT.Text = DT.ToString();

            for (int i = 0; i < distanciaE.Length; i++)
            {
                if (i != posicionVencedora)
                {
                    if (distanciaE[i] < DT)
                    {
                        canVecinas++;
                    }
                }
            }
            lblCantVecinas.Text = canVecinas.ToString();
            posicionesVecinas = new double[canVecinas];
            if (canVecinas > 0)
            {
                int pos = 0;
                for (int k = 0; k < distanciaE.Length; k++)
                {
                    if (k != posicionVencedora)
                    {
                        if (distanciaE[k] < DT)
                        {
                            posicionesVecinas[pos] = k;
                            pos++;
                        }
                    }
                }
            }
            else
            {
                banderaCanVecinas = 1;
            }
        }


        //distancia entre el vector de entrada y las neuronas
        private int CalcularDistanciaEuclidiana()
        {
            distanciaE = new double[(int)numNeuronasMapa];
           double sumaInterna, X, sumaTotal;
            double potencia;
            for (int i = 0; i < numNeuronasMapa; i++)
            {
                sumaInterna = 0; sumaTotal = 0; potencia = 0; X = 0;
                for (int j = 0; j < numEntradas; j++)
                {
                    X = double.Parse(obtenerPatrones[j].ToString().Trim());
                    sumaInterna = X - matrizPesos[j, i];
                    potencia = Math.Pow(sumaInterna, 2);
                    sumaTotal = sumaTotal + potencia;
                    X = 0; sumaInterna = 0; potencia = 0;
                }
                double raiz = Math.Sqrt(sumaTotal);
                distanciaE[i] = Math.Round(raiz,2);
                
            }
            
            int posicionNVencedora = CalcularMenorDistancia();

            //mostrar resultados en una tabla
            tablaVectorDistanciaE.ColumnCount = (int)numNeuronasMapa;
            tablaVectorDistanciaE.RowCount = 1;
            

            for (int filas = 0; filas < 1; filas++)
            {
                for (int col = 0; col < numNeuronasMapa; col++)
                {  
                    /*if (posicionNVencedora.Equals(col))
                    {
                        tablaVectorDistanciaE.Rows[filas].Cells[col].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        tablaVectorDistanciaE.Rows[filas].Cells[col].Style.BackColor = Color.White;
                    }*/
                    tablaVectorDistanciaE.Rows[filas].Cells[col].Value = distanciaE[col].ToString();
                }
            }
            return posicionNVencedora;
        }

        //Buscar la menor distancia 
        private int CalcularMenorDistancia()
        {
            double pibote = distanciaE[0];
            int posicion = 0;

            for (int i = 0; i < numNeuronasMapa; i++)
            {
                if (distanciaE[i] < pibote)
                {                    
                    pibote = distanciaE[i];
                    posicion = i;
                }
            }
            return posicion;
        }

        //Evento para inicializar pesos aleatorios
        private void btnInicializarPesos_Click(object sender, EventArgs e)
        {
            //generar numeros aleatorios
             Random generador = new Random();
             matrizPesos = new double[(int)numEntradas, (int)numNeuronasMapa];
       
             for (int filas = 0; filas < numEntradas; filas++)
             {
                 for (int col = 0; col < numNeuronasMapa; col++)
                 {
                     matrizPesos[filas,col] = (double)generador.Next(-1,10)/10;
                 }
             }

            LlenarTablaPesos();
            btnEntrenamiento.Enabled = true;
        }

        private void LlenarTablaPesos()
        {
                //chartPesosSipnaticos.Series["Pesos"].Points.Clear();
                tablaPesosSinapticos.ColumnCount = (int)numNeuronasMapa;
                tablaPesosSinapticos.RowCount = (int)numEntradas;
                int k = 0;
                for (int filas = 0; filas < numEntradas; filas++)
                {
                    for (int col = 0; col < numNeuronasMapa; col++)
                    {
                        tablaPesosSinapticos.Rows[filas].Cells[col].Value = matrizPesos[filas, col].ToString().Trim();
                        if (banderapesost == 0)
                        {
                            chartPesosSipnaticos.Series["Pesos"].Points.AddXY(k, Math.Round(matrizPesos[filas, col], 2));
                            k++;
                        } 
                    }
                }
            banderapesost = 1;
        }


        //Evento para seleccionar el tipo de competencia
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Blanda"))
            {
                tipoCompetencia = "Blanda";
                txtCoeficienteVecindad.Enabled = true;
            }
            else
            {
                tipoCompetencia = "Dura";
                txtCoeficienteVecindad.Enabled = false;
                txtCoeficienteVecindad.Text = "";
                coeficienteV = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //simulación cargar pesos
        private void btnCargarPesosOptimos_Click(object sender, EventArgs e)
        {
            try
            {
                // abrir cuadro de dialogo
                this.ofdCargarDatos.InitialDirectory = @"C:\";
                this.ofdCargarDatos.Title = "Datos";
                this.ofdCargarDatos.CheckFileExists = true;
                this.ofdCargarDatos.CheckPathExists = true;
                this.ofdCargarDatos.DefaultExt = ".txt";
                this.ofdCargarDatos.Filter = "Archivos (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";
                this.ofdCargarDatos.RestoreDirectory = true;
                this.ofdCargarDatos.FilterIndex = 2;
                this.ofdCargarDatos.ShowReadOnly = true;
                this.ofdCargarDatos.ReadOnlyChecked = true;
                if (this.ofdCargarDatos.ShowDialog() == DialogResult.OK)
                {
                    //llenar la tabla
                    this.tablaPesosOptimos.AutoGenerateColumns = true;
                    this.tablaPesosOptimos.DataSource = this.CargarPesosOptimosT(this.ofdCargarDatos.FileName);
                    this.LlenarMatrizPesosOptimos();
                }
            }
            catch (Exception ex)
            {

                string m = ex.Message; ;
            }
        }

        private void btnReiniciarRed_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //mostrar pesos en el datagrid
        private object CargarPesosOptimosT(string fileName)
        {
            DataTable datos = new DataTable();
            int countRow = 0;
            int countColumn = 0;
            numColmPO = 0;
            numFilaPO = 0;
            try
            {
                //leer el archivo
                FileInfo fileInfo = new FileInfo(fileName);
                StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
                using (reader = fileInfo.OpenText())
                {
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        numFilaPO++;
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (countRow == 0)
                        {
                            //Mostrar columnas
                            var getColumns = line.Split(';');
                            countColumn = getColumns.Length;
                            numColmPO = countColumn;
                            //MessageBox.Show(numColmPO.ToString());
                            int i = 0;
                            foreach (string item in getColumns)
                            {
                                datos.Columns.Add("W"+i);
                                i++;
                            }
                            countRow++;

                        }
                            //Mostrar filas
                            var getRow = line.Split(';');
                        listPatronesOptimos.Add(line);
                            if (string.IsNullOrEmpty(getRow[0].Split('\r')[0].Trim()))
                            {
                                continue;
                            }

                            DataRow drRow = datos.NewRow();
                            int colsCount = 0;
                            foreach (var item in getRow)
                            {
                                if (colsCount < countColumn)
                                {
                                    drRow[colsCount] = item.Split('\r')[0].Trim();
                                }
                                colsCount++;
                            }
                        datos.Rows.Add(drRow);
                        
                    }
                }
                return datos;
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message, ex);
            }
        }

        //llenar matriz

        private void LlenarMatrizPesosOptimos()
        {
            matrizPesosOptimos = new double[(int)numFilaPO, (int)numColmPO];
            obtenerPesosO = new string[(int)numColmPO];
            for (int filas = 0; filas < numFilaPO; filas++)
            {
                obtenerPesosO = listPatronesOptimos[filas].Split(';');
                for (int col = 0; col < numColmPO; col++)
                {
                    matrizPesosOptimos[filas, col] = double.Parse(obtenerPesosO[col]);
                }
            }
            for (int filas = 0; filas < numFilaPO; filas++)
            {
                for (int col = 0; col < numColmPO; col++)
                {
                    Console.WriteLine(matrizPesosOptimos[filas, col]);
                }
            }
        }

        private void btnPatronOptimos_Click(object sender, EventArgs e)
        {
            try
            {
                // abrir cuadro de dialogo
                this.ofdCargarDatos.InitialDirectory = @"C:\";
                this.ofdCargarDatos.Title = "Datos";
                this.ofdCargarDatos.CheckFileExists = true;
                this.ofdCargarDatos.CheckPathExists = true;
                this.ofdCargarDatos.DefaultExt = ".txt";
                this.ofdCargarDatos.Filter = "Archivos (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";
                this.ofdCargarDatos.RestoreDirectory = true;
                this.ofdCargarDatos.FilterIndex = 2;
                this.ofdCargarDatos.ShowReadOnly = true;
                this.ofdCargarDatos.ReadOnlyChecked = true;
                if (this.ofdCargarDatos.ShowDialog() == DialogResult.OK)
                {
                    listPatronOptimo = new List<string>();
                    FileStream fileStream = new FileStream(this.ofdCargarDatos.FileName,FileMode.OpenOrCreate, FileAccess.Read); ;
                    StreamReader read = new StreamReader(fileStream);
                    string line = string.Empty;

                    txtCargarPatron.Text = line = read.ReadLine();
                    listPatronOptimo.Add(txtCargarPatron.Text);
                }
            }
            catch (Exception ex)
            {

                string m = ex.Message; ;
            }
        }

        //iniciar simmulacion
        private void button1_Click(object sender, EventArgs e)
        {
            int neuronaVencedora = CalcularDistanciaEuclidianaS();
            lblResultadoNeuronaV.Text = neuronaVencedora.ToString();
            LlenarTablaGanadora(neuronaVencedora);
        }
        //simulacion
        private int CalcularDistanciaEuclidianaS()
        {
            distanciaE = new double[(int)numColmPO];
            double sumaInterna, X, sumaTotal;
            double potencia;
            var num = listPatronOptimo[0].Split(';').Length;
            obtenerPatronesOp = new string[num];
            obtenerPatronesOp = listPatronOptimo[0].Split(';');
            for (int i = 0; i < numColmPO; i++)
            {
                sumaInterna = 0; sumaTotal = 0; potencia = 0; X = 0;
                for (int j = 0; j < numFilaPO; j++)
                {
                    X = double.Parse(obtenerPatronesOp[j].ToString().Trim());
                    sumaInterna = X - matrizPesosOptimos[j, i];
                    potencia = Math.Pow(sumaInterna, 2);
                    sumaTotal = sumaTotal + potencia;
                    X = 0; sumaInterna = 0; potencia = 0;
                }
                double raiz = Math.Sqrt(sumaTotal);
                distanciaE[i] = raiz;
            }

            int posicionVencedora = CalcularMenorDistanciaS();
            //mostrar resultados en una tabla

            tablaVectorDistanciaE.ColumnCount = (int)numColmPO;
            tablaVectorDistanciaE.RowCount = 1;


            for (int filas = 0; filas < 1; filas++)
            {
                for (int col = 0; col < numColmPO; col++)
                {

                    if (posicionVencedora.Equals(col))
                    {
                        tablaVectorDistanciaE.Rows[filas].Cells[col].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        tablaVectorDistanciaE.Rows[filas].Cells[col].Style.BackColor = Color.White;
                    }
                    tablaVectorDistanciaE.Rows[filas].Cells[col].Value = distanciaE[col].ToString();
                }
            }
            return posicionVencedora;
        }
        
        private int CalcularMenorDistanciaS()
        {
            double pibote = distanciaE[0];
            int posicion = 0;

            for (int i = 0; i < numColmPO; i++)
            {
                if (distanciaE[i] < pibote)
                {
                    pibote = distanciaE[i];
                    posicion = i;
                }
            }
            return posicion;
        }

        private void LlenarTablaGanadora(int pos)
        {
            tablaNeuronaVencedora.ColumnCount = 1;
            tablaNeuronaVencedora.RowCount = (int)numFilaPO;
            for (int filas = 0; filas < numFilaPO; filas++)
            {
                for (int col = 0; col < 1; col++)
                {
                    tablaNeuronaVencedora.Rows[filas].Cells[col].Value = matrizPesosOptimos[filas, pos].ToString();
                }
            }
        }
    }
}
