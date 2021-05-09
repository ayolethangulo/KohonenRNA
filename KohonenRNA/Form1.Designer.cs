
namespace KohonenRNA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.tablaDatosEntrada = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoeficienteVecindad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumNeuronasMapa = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblNumPatrones = new System.Windows.Forms.Label();
            this.lblNumEntradas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfigurarRed = new System.Windows.Forms.Button();
            this.lblRataAprendizaje = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumIteraciones = new System.Windows.Forms.TextBox();
            this.btnInicializarPesos = new System.Windows.Forms.Button();
            this.tablaPesosSinapticos = new System.Windows.Forms.DataGridView();
            this.btnEntrenamiento = new System.Windows.Forms.Button();
            this.chartPesosSipnaticos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ofdCargarDatos = new System.Windows.Forms.OpenFileDialog();
            this.tablaVectorDistanciaE = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNumVecinas = new System.Windows.Forms.Label();
            this.lblCantVecinas = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblNumDT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDM = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbliteracionMomento = new System.Windows.Forms.Label();
            this.chartDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tagEntrenamiento = new System.Windows.Forms.TabPage();
            this.tagSimulacion = new System.Windows.Forms.TabPage();
            this.lblResultadoNeuronaV = new System.Windows.Forms.Label();
            this.lblNeuronaVencedoraS = new System.Windows.Forms.Label();
            this.tablaNeuronaVencedora = new System.Windows.Forms.DataGridView();
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.txtCargarPatron = new System.Windows.Forms.TextBox();
            this.btnPatronOptimos = new System.Windows.Forms.Button();
            this.btnCargarPesosOptimos = new System.Windows.Forms.Button();
            this.tablaPesosOptimos = new System.Windows.Forms.DataGridView();
            this.btnReiniciarRed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosEntrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPesosSinapticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPesosSipnaticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVectorDistanciaE)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDM)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tagEntrenamiento.SuspendLayout();
            this.tagSimulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNeuronaVencedora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPesosOptimos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(136, 12);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(115, 24);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // tablaDatosEntrada
            // 
            this.tablaDatosEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatosEntrada.Location = new System.Drawing.Point(12, 43);
            this.tablaDatosEntrada.Name = "tablaDatosEntrada";
            this.tablaDatosEntrada.Size = new System.Drawing.Size(395, 180);
            this.tablaDatosEntrada.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCoeficienteVecindad);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumNeuronasMapa);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lblNumPatrones);
            this.groupBox1.Controls.Add(this.lblNumEntradas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Coeficiente de vecindad:";
            // 
            // txtCoeficienteVecindad
            // 
            this.txtCoeficienteVecindad.Location = new System.Drawing.Point(198, 114);
            this.txtCoeficienteVecindad.Name = "txtCoeficienteVecindad";
            this.txtCoeficienteVecindad.Size = new System.Drawing.Size(100, 20);
            this.txtCoeficienteVecindad.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blanda",
            "Dura"});
            this.comboBox1.Location = new System.Drawing.Point(12, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione el tipo de competencia:";
            // 
            // txtNumNeuronasMapa
            // 
            this.txtNumNeuronasMapa.Location = new System.Drawing.Point(195, 42);
            this.txtNumNeuronasMapa.Name = "txtNumNeuronasMapa";
            this.txtNumNeuronasMapa.Size = new System.Drawing.Size(101, 20);
            this.txtNumNeuronasMapa.TabIndex = 5;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(192, 16);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(200, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Digite la cantidad de neuronas del mapa:";
            // 
            // lblNumPatrones
            // 
            this.lblNumPatrones.AutoSize = true;
            this.lblNumPatrones.Location = new System.Drawing.Point(121, 49);
            this.lblNumPatrones.Name = "lblNumPatrones";
            this.lblNumPatrones.Size = new System.Drawing.Size(13, 13);
            this.lblNumPatrones.TabIndex = 3;
            this.lblNumPatrones.Text = "0";
            // 
            // lblNumEntradas
            // 
            this.lblNumEntradas.AutoSize = true;
            this.lblNumEntradas.Location = new System.Drawing.Point(121, 26);
            this.lblNumEntradas.Name = "lblNumEntradas";
            this.lblNumEntradas.Size = new System.Drawing.Size(13, 13);
            this.lblNumEntradas.TabIndex = 2;
            this.lblNumEntradas.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de patrones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de entradas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número de iteraciones:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfigurarRed);
            this.groupBox2.Controls.Add(this.lblRataAprendizaje);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNumIteraciones);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 107);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros de entrenamiento";
            // 
            // btnConfigurarRed
            // 
            this.btnConfigurarRed.Location = new System.Drawing.Point(208, 78);
            this.btnConfigurarRed.Name = "btnConfigurarRed";
            this.btnConfigurarRed.Size = new System.Drawing.Size(172, 23);
            this.btnConfigurarRed.TabIndex = 10;
            this.btnConfigurarRed.Text = "Configuración de la red";
            this.btnConfigurarRed.UseVisualStyleBackColor = true;
            this.btnConfigurarRed.Click += new System.EventHandler(this.btnConfigurarRed_Click);
            // 
            // lblRataAprendizaje
            // 
            this.lblRataAprendizaje.AutoSize = true;
            this.lblRataAprendizaje.Location = new System.Drawing.Point(128, 62);
            this.lblRataAprendizaje.Name = "lblRataAprendizaje";
            this.lblRataAprendizaje.Size = new System.Drawing.Size(0, 13);
            this.lblRataAprendizaje.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rata de aprendizaje:";
            // 
            // txtNumIteraciones
            // 
            this.txtNumIteraciones.Location = new System.Drawing.Point(131, 30);
            this.txtNumIteraciones.Name = "txtNumIteraciones";
            this.txtNumIteraciones.Size = new System.Drawing.Size(67, 20);
            this.txtNumIteraciones.TabIndex = 11;
            // 
            // btnInicializarPesos
            // 
            this.btnInicializarPesos.Location = new System.Drawing.Point(538, 12);
            this.btnInicializarPesos.Name = "btnInicializarPesos";
            this.btnInicializarPesos.Size = new System.Drawing.Size(143, 23);
            this.btnInicializarPesos.TabIndex = 12;
            this.btnInicializarPesos.Text = "Inicializar pesos";
            this.btnInicializarPesos.UseVisualStyleBackColor = true;
            this.btnInicializarPesos.Click += new System.EventHandler(this.btnInicializarPesos_Click);
            // 
            // tablaPesosSinapticos
            // 
            this.tablaPesosSinapticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPesosSinapticos.Location = new System.Drawing.Point(438, 43);
            this.tablaPesosSinapticos.Name = "tablaPesosSinapticos";
            this.tablaPesosSinapticos.Size = new System.Drawing.Size(407, 180);
            this.tablaPesosSinapticos.TabIndex = 13;
            // 
            // btnEntrenamiento
            // 
            this.btnEntrenamiento.Location = new System.Drawing.Point(438, 243);
            this.btnEntrenamiento.Name = "btnEntrenamiento";
            this.btnEntrenamiento.Size = new System.Drawing.Size(153, 25);
            this.btnEntrenamiento.TabIndex = 14;
            this.btnEntrenamiento.Text = "Entrenamiento de la red";
            this.btnEntrenamiento.UseVisualStyleBackColor = true;
            this.btnEntrenamiento.Click += new System.EventHandler(this.btnEntrenamiento_Click);
            // 
            // chartPesosSipnaticos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPesosSipnaticos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPesosSipnaticos.Legends.Add(legend1);
            this.chartPesosSipnaticos.Location = new System.Drawing.Point(17, 10);
            this.chartPesosSipnaticos.Name = "chartPesosSipnaticos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Pesos";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartPesosSipnaticos.Series.Add(series1);
            this.chartPesosSipnaticos.Size = new System.Drawing.Size(461, 189);
            this.chartPesosSipnaticos.TabIndex = 15;
            this.chartPesosSipnaticos.Text = "Comportamiento pesos";
            // 
            // ofdCargarDatos
            // 
            this.ofdCargarDatos.FileName = "openFileDialog1";
            // 
            // tablaVectorDistanciaE
            // 
            this.tablaVectorDistanciaE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVectorDistanciaE.Location = new System.Drawing.Point(6, 19);
            this.tablaVectorDistanciaE.Name = "tablaVectorDistanciaE";
            this.tablaVectorDistanciaE.Size = new System.Drawing.Size(416, 97);
            this.tablaVectorDistanciaE.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tablaVectorDistanciaE);
            this.groupBox3.Location = new System.Drawing.Point(423, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 131);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distancia de la neurona";
            // 
            // lblNumVecinas
            // 
            this.lblNumVecinas.AutoSize = true;
            this.lblNumVecinas.Location = new System.Drawing.Point(429, 437);
            this.lblNumVecinas.Name = "lblNumVecinas";
            this.lblNumVecinas.Size = new System.Drawing.Size(102, 13);
            this.lblNumVecinas.TabIndex = 18;
            this.lblNumVecinas.Text = "Número de vecinas:";
            // 
            // lblCantVecinas
            // 
            this.lblCantVecinas.AutoSize = true;
            this.lblCantVecinas.Location = new System.Drawing.Point(538, 436);
            this.lblCantVecinas.Name = "lblCantVecinas";
            this.lblCantVecinas.Size = new System.Drawing.Size(0, 13);
            this.lblCantVecinas.TabIndex = 19;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(429, 458);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(25, 13);
            this.lblDT.TabIndex = 20;
            this.lblDT.Text = "DT:";
            // 
            // lblNumDT
            // 
            this.lblNumDT.AutoSize = true;
            this.lblNumDT.Location = new System.Drawing.Point(460, 458);
            this.lblNumDT.Name = "lblNumDT";
            this.lblNumDT.Size = new System.Drawing.Size(0, 13);
            this.lblNumDT.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "DM:";
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Location = new System.Drawing.Point(679, 435);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(0, 13);
            this.lblDM.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Iteración: ";
            // 
            // lbliteracionMomento
            // 
            this.lbliteracionMomento.AutoSize = true;
            this.lbliteracionMomento.Location = new System.Drawing.Point(689, 462);
            this.lbliteracionMomento.Name = "lbliteracionMomento";
            this.lbliteracionMomento.Size = new System.Drawing.Size(13, 13);
            this.lbliteracionMomento.TabIndex = 25;
            this.lbliteracionMomento.Text = "0";
            // 
            // chartDM
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDM.Legends.Add(legend2);
            this.chartDM.Location = new System.Drawing.Point(17, 238);
            this.chartDM.Name = "chartDM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "DM";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartDM.Series.Add(series2);
            this.chartDM.Size = new System.Drawing.Size(461, 190);
            this.chartDM.TabIndex = 26;
            this.chartDM.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tagEntrenamiento);
            this.tabControl1.Controls.Add(this.tagSimulacion);
            this.tabControl1.Location = new System.Drawing.Point(857, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 471);
            this.tabControl1.TabIndex = 26;
            // 
            // tagEntrenamiento
            // 
            this.tagEntrenamiento.Controls.Add(this.chartDM);
            this.tagEntrenamiento.Controls.Add(this.chartPesosSipnaticos);
            this.tagEntrenamiento.Location = new System.Drawing.Point(4, 22);
            this.tagEntrenamiento.Name = "tagEntrenamiento";
            this.tagEntrenamiento.Padding = new System.Windows.Forms.Padding(3);
            this.tagEntrenamiento.Size = new System.Drawing.Size(494, 445);
            this.tagEntrenamiento.TabIndex = 0;
            this.tagEntrenamiento.Text = "Entrenamiento";
            this.tagEntrenamiento.UseVisualStyleBackColor = true;
            // 
            // tagSimulacion
            // 
            this.tagSimulacion.Controls.Add(this.lblResultadoNeuronaV);
            this.tagSimulacion.Controls.Add(this.lblNeuronaVencedoraS);
            this.tagSimulacion.Controls.Add(this.tablaNeuronaVencedora);
            this.tagSimulacion.Controls.Add(this.btnSimulacion);
            this.tagSimulacion.Controls.Add(this.txtCargarPatron);
            this.tagSimulacion.Controls.Add(this.btnPatronOptimos);
            this.tagSimulacion.Controls.Add(this.btnCargarPesosOptimos);
            this.tagSimulacion.Controls.Add(this.tablaPesosOptimos);
            this.tagSimulacion.Location = new System.Drawing.Point(4, 22);
            this.tagSimulacion.Name = "tagSimulacion";
            this.tagSimulacion.Padding = new System.Windows.Forms.Padding(3);
            this.tagSimulacion.Size = new System.Drawing.Size(494, 445);
            this.tagSimulacion.TabIndex = 1;
            this.tagSimulacion.Text = "Simulación";
            this.tagSimulacion.UseVisualStyleBackColor = true;
            // 
            // lblResultadoNeuronaV
            // 
            this.lblResultadoNeuronaV.AutoSize = true;
            this.lblResultadoNeuronaV.Location = new System.Drawing.Point(28, 317);
            this.lblResultadoNeuronaV.Name = "lblResultadoNeuronaV";
            this.lblResultadoNeuronaV.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoNeuronaV.TabIndex = 27;
            // 
            // lblNeuronaVencedoraS
            // 
            this.lblNeuronaVencedoraS.AutoSize = true;
            this.lblNeuronaVencedoraS.Location = new System.Drawing.Point(28, 292);
            this.lblNeuronaVencedoraS.Name = "lblNeuronaVencedoraS";
            this.lblNeuronaVencedoraS.Size = new System.Drawing.Size(106, 13);
            this.lblNeuronaVencedoraS.TabIndex = 6;
            this.lblNeuronaVencedoraS.Text = "Neurona Vencedora:";
            // 
            // tablaNeuronaVencedora
            // 
            this.tablaNeuronaVencedora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaNeuronaVencedora.Location = new System.Drawing.Point(302, 288);
            this.tablaNeuronaVencedora.Name = "tablaNeuronaVencedora";
            this.tablaNeuronaVencedora.Size = new System.Drawing.Size(173, 150);
            this.tablaNeuronaVencedora.TabIndex = 5;
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(216, 251);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(75, 23);
            this.btnSimulacion.TabIndex = 4;
            this.btnSimulacion.Text = "Simulación";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCargarPatron
            // 
            this.txtCargarPatron.Location = new System.Drawing.Point(7, 225);
            this.txtCargarPatron.Name = "txtCargarPatron";
            this.txtCargarPatron.Size = new System.Drawing.Size(446, 20);
            this.txtCargarPatron.TabIndex = 3;
            this.txtCargarPatron.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPatronOptimos
            // 
            this.btnPatronOptimos.Location = new System.Drawing.Point(178, 196);
            this.btnPatronOptimos.Name = "btnPatronOptimos";
            this.btnPatronOptimos.Size = new System.Drawing.Size(142, 23);
            this.btnPatronOptimos.TabIndex = 2;
            this.btnPatronOptimos.Text = "Cargar Patron";
            this.btnPatronOptimos.UseVisualStyleBackColor = true;
            this.btnPatronOptimos.Click += new System.EventHandler(this.btnPatronOptimos_Click);
            // 
            // btnCargarPesosOptimos
            // 
            this.btnCargarPesosOptimos.Location = new System.Drawing.Point(167, 11);
            this.btnCargarPesosOptimos.Name = "btnCargarPesosOptimos";
            this.btnCargarPesosOptimos.Size = new System.Drawing.Size(153, 23);
            this.btnCargarPesosOptimos.TabIndex = 1;
            this.btnCargarPesosOptimos.Text = "Cargar pesos";
            this.btnCargarPesosOptimos.UseVisualStyleBackColor = true;
            this.btnCargarPesosOptimos.Click += new System.EventHandler(this.btnCargarPesosOptimos_Click);
            // 
            // tablaPesosOptimos
            // 
            this.tablaPesosOptimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPesosOptimos.Location = new System.Drawing.Point(7, 40);
            this.tablaPesosOptimos.Name = "tablaPesosOptimos";
            this.tablaPesosOptimos.Size = new System.Drawing.Size(481, 150);
            this.tablaPesosOptimos.TabIndex = 0;
            // 
            // btnReiniciarRed
            // 
            this.btnReiniciarRed.Location = new System.Drawing.Point(597, 243);
            this.btnReiniciarRed.Name = "btnReiniciarRed";
            this.btnReiniciarRed.Size = new System.Drawing.Size(148, 23);
            this.btnReiniciarRed.TabIndex = 27;
            this.btnReiniciarRed.Text = "Reinicializar red";
            this.btnReiniciarRed.UseVisualStyleBackColor = true;
            this.btnReiniciarRed.Click += new System.EventHandler(this.btnReiniciarRed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 495);
            this.Controls.Add(this.btnReiniciarRed);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbliteracionMomento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNumDT);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblCantVecinas);
            this.Controls.Add(this.lblNumVecinas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEntrenamiento);
            this.Controls.Add(this.tablaPesosSinapticos);
            this.Controls.Add(this.btnInicializarPesos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tablaDatosEntrada);
            this.Controls.Add(this.btnCargarDatos);
            this.Name = "Form1";
            this.Text = "RNA KOHONEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatosEntrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPesosSinapticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPesosSipnaticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVectorDistanciaE)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDM)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tagEntrenamiento.ResumeLayout(false);
            this.tagSimulacion.ResumeLayout(false);
            this.tagSimulacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNeuronaVencedora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPesosOptimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.DataGridView tablaDatosEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumNeuronasMapa;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblNumPatrones;
        private System.Windows.Forms.Label lblNumEntradas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoeficienteVecindad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRataAprendizaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumIteraciones;
        private System.Windows.Forms.Button btnInicializarPesos;
        private System.Windows.Forms.DataGridView tablaPesosSinapticos;
        private System.Windows.Forms.Button btnEntrenamiento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPesosSipnaticos;
        private System.Windows.Forms.OpenFileDialog ofdCargarDatos;
        private System.Windows.Forms.Button btnConfigurarRed;
        private System.Windows.Forms.DataGridView tablaVectorDistanciaE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNumVecinas;
        private System.Windows.Forms.Label lblCantVecinas;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblNumDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbliteracionMomento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tagEntrenamiento;
        private System.Windows.Forms.TabPage tagSimulacion;
        private System.Windows.Forms.TextBox txtCargarPatron;
        private System.Windows.Forms.Button btnPatronOptimos;
        private System.Windows.Forms.Button btnCargarPesosOptimos;
        private System.Windows.Forms.DataGridView tablaPesosOptimos;
        private System.Windows.Forms.Label lblNeuronaVencedoraS;
        private System.Windows.Forms.DataGridView tablaNeuronaVencedora;
        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.Label lblResultadoNeuronaV;
        private System.Windows.Forms.Button btnReiniciarRed;
    }
}

