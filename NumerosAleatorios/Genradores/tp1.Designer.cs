namespace Genradores
{
    partial class Tp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_PuntoA = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_semillaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_PuntoB = new System.Windows.Forms.Button();
            this.txt_Cant_nroB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IntB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_PuntoC = new System.Windows.Forms.Button();
            this.txt_cant_nroC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_IntC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_aC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_semillaC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.histogramaGenerado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_compro = new System.Windows.Forms.Button();
            this.txt_chicierto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbl_chi_cu = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblFrecuenciaEsperada = new System.Windows.Forms.Label();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FERelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiCuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.numero});
            this.dataGridView1.Location = new System.Drawing.Point(798, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(262, 320);
            this.dataGridView1.TabIndex = 4;
            // 
            // posicion
            // 
            this.posicion.HeaderText = "Posicion";
            this.posicion.Name = "posicion";
            // 
            // numero
            // 
            this.numero.HeaderText = "Numeros";
            this.numero.Name = "numero";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_siguiente);
            this.groupBox4.Controls.Add(this.btn_PuntoA);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(361, 320);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Punto A: ";
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_siguiente.Location = new System.Drawing.Point(193, 274);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(68, 36);
            this.btn_siguiente.TabIndex = 7;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click_1);
            // 
            // btn_PuntoA
            // 
            this.btn_PuntoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PuntoA.Location = new System.Drawing.Point(105, 274);
            this.btn_PuntoA.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PuntoA.Name = "btn_PuntoA";
            this.btn_PuntoA.Size = new System.Drawing.Size(68, 36);
            this.btn_PuntoA.TabIndex = 6;
            this.btn_PuntoA.Text = "Generar ";
            this.btn_PuntoA.UseVisualStyleBackColor = true;
            this.btn_PuntoA.Click += new System.EventHandler(this.btn_PuntoA_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_mA);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_aA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_semillaA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(195, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // txt_cA
            // 
            this.txt_cA.Location = new System.Drawing.Point(116, 86);
            this.txt_cA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cA.Name = "txt_cA";
            this.txt_cA.Size = new System.Drawing.Size(60, 19);
            this.txt_cA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sumatorio C:";
            // 
            // txt_mA
            // 
            this.txt_mA.Location = new System.Drawing.Point(116, 120);
            this.txt_mA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mA.Name = "txt_mA";
            this.txt_mA.Size = new System.Drawing.Size(60, 19);
            this.txt_mA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Divisor M:";
            // 
            // txt_aA
            // 
            this.txt_aA.Location = new System.Drawing.Point(116, 54);
            this.txt_aA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_aA.Name = "txt_aA";
            this.txt_aA.Size = new System.Drawing.Size(60, 19);
            this.txt_aA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Multiplicativo A:";
            // 
            // txt_semillaA
            // 
            this.txt_semillaA.Location = new System.Drawing.Point(116, 21);
            this.txt_semillaA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_semillaA.Name = "txt_semillaA";
            this.txt_semillaA.Size = new System.Drawing.Size(60, 19);
            this.txt_semillaA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semilla:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(337, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generadores";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 50);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(321, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Congruencial Multiplicativo - Xn = (A * Xn-1 ) Mod M";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(299, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Congruencial Mixto - Xn = (A * Xn-1 + C ) Mod M";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_PuntoB);
            this.groupBox5.Controls.Add(this.txt_Cant_nroB);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_IntB);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(398, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(164, 147);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Punto B: ";
            // 
            // btn_PuntoB
            // 
            this.btn_PuntoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PuntoB.Location = new System.Drawing.Point(11, 102);
            this.btn_PuntoB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PuntoB.Name = "btn_PuntoB";
            this.btn_PuntoB.Size = new System.Drawing.Size(68, 36);
            this.btn_PuntoB.TabIndex = 7;
            this.btn_PuntoB.Text = "Generar ";
            this.btn_PuntoB.UseVisualStyleBackColor = true;
            this.btn_PuntoB.Click += new System.EventHandler(this.btn_PuntoB_Click);
            // 
            // txt_Cant_nroB
            // 
            this.txt_Cant_nroB.Location = new System.Drawing.Point(83, 25);
            this.txt_Cant_nroB.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cant_nroB.Name = "txt_Cant_nroB";
            this.txt_Cant_nroB.Size = new System.Drawing.Size(59, 19);
            this.txt_Cant_nroB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cant. Nro:";
            // 
            // txt_IntB
            // 
            this.txt_IntB.Location = new System.Drawing.Point(83, 59);
            this.txt_IntB.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IntB.Name = "txt_IntB";
            this.txt_IntB.Size = new System.Drawing.Size(59, 19);
            this.txt_IntB.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Intervalos";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_PuntoC);
            this.groupBox6.Controls.Add(this.txt_cant_nroC);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txt_IntC);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txt_cC);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_mC);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txt_aC);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txt_semillaC);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(586, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(195, 276);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Punto C: ";
            // 
            // btn_PuntoC
            // 
            this.btn_PuntoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PuntoC.Location = new System.Drawing.Point(27, 227);
            this.btn_PuntoC.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PuntoC.Name = "btn_PuntoC";
            this.btn_PuntoC.Size = new System.Drawing.Size(68, 36);
            this.btn_PuntoC.TabIndex = 7;
            this.btn_PuntoC.Text = "Generar ";
            this.btn_PuntoC.UseVisualStyleBackColor = true;
            this.btn_PuntoC.Click += new System.EventHandler(this.btn_PuntoC_Click);
            // 
            // txt_cant_nroC
            // 
            this.txt_cant_nroC.Location = new System.Drawing.Point(121, 25);
            this.txt_cant_nroC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cant_nroC.Name = "txt_cant_nroC";
            this.txt_cant_nroC.Size = new System.Drawing.Size(59, 19);
            this.txt_cant_nroC.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Cant. Nro:";
            // 
            // txt_IntC
            // 
            this.txt_IntC.Location = new System.Drawing.Point(121, 58);
            this.txt_IntC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IntC.Name = "txt_IntC";
            this.txt_IntC.Size = new System.Drawing.Size(59, 19);
            this.txt_IntC.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Intervalos";
            // 
            // txt_cC
            // 
            this.txt_cC.Location = new System.Drawing.Point(121, 157);
            this.txt_cC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cC.Name = "txt_cC";
            this.txt_cC.Size = new System.Drawing.Size(60, 19);
            this.txt_cC.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sumatorio C:";
            // 
            // txt_mC
            // 
            this.txt_mC.Location = new System.Drawing.Point(121, 190);
            this.txt_mC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mC.Name = "txt_mC";
            this.txt_mC.Size = new System.Drawing.Size(60, 19);
            this.txt_mC.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Divisor M:";
            // 
            // txt_aC
            // 
            this.txt_aC.Location = new System.Drawing.Point(121, 124);
            this.txt_aC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_aC.Name = "txt_aC";
            this.txt_aC.Size = new System.Drawing.Size(60, 19);
            this.txt_aC.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Multiplicativo A:";
            // 
            // txt_semillaC
            // 
            this.txt_semillaC.Location = new System.Drawing.Point(121, 91);
            this.txt_semillaC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_semillaC.Name = "txt_semillaC";
            this.txt_semillaC.Size = new System.Drawing.Size(60, 19);
            this.txt_semillaC.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Semilla:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.frecuencia,
            this.frecuenciaEsp,
            this.FORelativa,
            this.FERelativa,
            this.ChiCuadrado});
            this.dataGridView2.Location = new System.Drawing.Point(729, 29);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(597, 207);
            this.dataGridView2.TabIndex = 37;
            // 
            // histogramaGenerado
            // 
            chartArea10.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea10.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea10.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea10.AxisX.Title = "Intervalos";
            chartArea10.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea10.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea10.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea10.AxisY.Maximum = 100D;
            chartArea10.AxisY.Minimum = 0D;
            chartArea10.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.Title = "Frecuencia";
            chartArea10.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea10.Name = "ChartArea1";
            this.histogramaGenerado.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.histogramaGenerado.Legends.Add(legend10);
            this.histogramaGenerado.Location = new System.Drawing.Point(14, 29);
            this.histogramaGenerado.Name = "histogramaGenerado";
            this.histogramaGenerado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series10.IsValueShownAsLabel = true;
            series10.IsXValueIndexed = true;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.histogramaGenerado.Series.Add(series10);
            this.histogramaGenerado.Size = new System.Drawing.Size(692, 311);
            this.histogramaGenerado.TabIndex = 36;
            this.histogramaGenerado.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.histogramaGenerado);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 358);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1330, 361);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grafico";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_compro);
            this.groupBox7.Controls.Add(this.txt_chicierto);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(1053, 254);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(158, 91);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hipótesis";
            // 
            // btn_compro
            // 
            this.btn_compro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compro.Location = new System.Drawing.Point(7, 56);
            this.btn_compro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compro.Name = "btn_compro";
            this.btn_compro.Size = new System.Drawing.Size(80, 30);
            this.btn_compro.TabIndex = 35;
            this.btn_compro.Text = "Comprobar";
            this.btn_compro.UseVisualStyleBackColor = true;
            this.btn_compro.Click += new System.EventHandler(this.btn_compro_Click);
            // 
            // txt_chicierto
            // 
            this.txt_chicierto.Location = new System.Drawing.Point(86, 28);
            this.txt_chicierto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_chicierto.Name = "txt_chicierto";
            this.txt_chicierto.Size = new System.Drawing.Size(60, 19);
            this.txt_chicierto.TabIndex = 35;
            this.txt_chicierto.Text = "0.05";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ingrese Alfa";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbl_chi_cu);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(891, 254);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(158, 54);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chi Cuadrado Observado";
            // 
            // lbl_chi_cu
            // 
            this.lbl_chi_cu.AutoSize = true;
            this.lbl_chi_cu.Location = new System.Drawing.Point(11, 33);
            this.lbl_chi_cu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_chi_cu.Name = "lbl_chi_cu";
            this.lbl_chi_cu.Size = new System.Drawing.Size(0, 13);
            this.lbl_chi_cu.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblFrecuenciaEsperada);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(729, 254);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(158, 54);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Chi Cuadrado Esperado";
            // 
            // lblFrecuenciaEsperada
            // 
            this.lblFrecuenciaEsperada.AutoSize = true;
            this.lblFrecuenciaEsperada.Location = new System.Drawing.Point(23, 32);
            this.lblFrecuenciaEsperada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrecuenciaEsperada.Name = "lblFrecuenciaEsperada";
            this.lblFrecuenciaEsperada.Size = new System.Drawing.Size(0, 13);
            this.lblFrecuenciaEsperada.TabIndex = 0;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            // 
            // frecuencia
            // 
            this.frecuencia.HeaderText = "Frecuencia Observada";
            this.frecuencia.Name = "frecuencia";
            // 
            // frecuenciaEsp
            // 
            this.frecuenciaEsp.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsp.Name = "frecuenciaEsp";
            // 
            // FORelativa
            // 
            this.FORelativa.HeaderText = "Frec Obs Relativa";
            this.FORelativa.Name = "FORelativa";
            // 
            // FERelativa
            // 
            this.FERelativa.HeaderText = "Frec Esp Relativa";
            this.FERelativa.Name = "FERelativa";
            // 
            // ChiCuadrado
            // 
            this.ChiCuadrado.HeaderText = "Prueba Chi Cuadrado";
            this.ChiCuadrado.Name = "ChiCuadrado";
            // 
            // Tp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 730);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tp1";
            this.Text = "Practico N°1 - De Franceschi Andrea 62127 - García Majorel Álvaro 61856 - García " +
    "Reyna Facundo 63583 - Oliveda Claudio 49594 - Varela Sofía 65126";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_PuntoA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_semillaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_PuntoB;
        private System.Windows.Forms.TextBox txt_Cant_nroB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IntB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_PuntoC;
        private System.Windows.Forms.TextBox txt_cant_nroC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_IntC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_aC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_semillaC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaGenerado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_compro;
        private System.Windows.Forms.TextBox txt_chicierto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lbl_chi_cu;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblFrecuenciaEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FERelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiCuadrado;
    }
}

