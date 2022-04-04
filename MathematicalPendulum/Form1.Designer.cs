namespace MathematicalPendulum
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBoxPendulumMove = new System.Windows.Forms.PictureBox();
            this.groupBoxInitialConditions = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxViscousFrictionCoefficient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDryFrictionCoefficient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStartSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.groupBoxPendulumControl = new System.Windows.Forms.GroupBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxImpactOfForce = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxEndAngle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxStartAngle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPendulumMove)).BeginInit();
            this.groupBoxInitialConditions.SuspendLayout();
            this.groupBoxPendulumControl.SuspendLayout();
            this.groupBoxImpactOfForce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPendulumMove
            // 
            this.pictureBoxPendulumMove.Location = new System.Drawing.Point(291, 16);
            this.pictureBoxPendulumMove.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPendulumMove.Name = "pictureBoxPendulumMove";
            this.pictureBoxPendulumMove.Size = new System.Drawing.Size(1139, 367);
            this.pictureBoxPendulumMove.TabIndex = 0;
            this.pictureBoxPendulumMove.TabStop = false;
            // 
            // groupBoxInitialConditions
            // 
            this.groupBoxInitialConditions.Controls.Add(this.label23);
            this.groupBoxInitialConditions.Controls.Add(this.label22);
            this.groupBoxInitialConditions.Controls.Add(this.label21);
            this.groupBoxInitialConditions.Controls.Add(this.label20);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxDT);
            this.groupBoxInitialConditions.Controls.Add(this.label19);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxNumber);
            this.groupBoxInitialConditions.Controls.Add(this.label13);
            this.groupBoxInitialConditions.Controls.Add(this.label14);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxViscousFrictionCoefficient);
            this.groupBoxInitialConditions.Controls.Add(this.label11);
            this.groupBoxInitialConditions.Controls.Add(this.label12);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxDryFrictionCoefficient);
            this.groupBoxInitialConditions.Controls.Add(this.label8);
            this.groupBoxInitialConditions.Controls.Add(this.label7);
            this.groupBoxInitialConditions.Controls.Add(this.label6);
            this.groupBoxInitialConditions.Controls.Add(this.label5);
            this.groupBoxInitialConditions.Controls.Add(this.label4);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxWeight);
            this.groupBoxInitialConditions.Controls.Add(this.label3);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxStartSpeed);
            this.groupBoxInitialConditions.Controls.Add(this.label2);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxAngle);
            this.groupBoxInitialConditions.Controls.Add(this.label1);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxLength);
            this.groupBoxInitialConditions.Location = new System.Drawing.Point(16, 16);
            this.groupBoxInitialConditions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInitialConditions.Name = "groupBoxInitialConditions";
            this.groupBoxInitialConditions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInitialConditions.Size = new System.Drawing.Size(267, 350);
            this.groupBoxInitialConditions.TabIndex = 1;
            this.groupBoxInitialConditions.TabStop = false;
            this.groupBoxInitialConditions.Text = "Начальные условия";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 251);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 19);
            this.label19.TabIndex = 19;
            this.label19.Text = "Кол-во фаз.траект.";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(169, 248);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(51, 25);
            this.textBoxNumber.TabIndex = 18;
            this.textBoxNumber.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 214);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "   ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 214);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "Коэф. вязк. трения";
            // 
            // textBoxViscousFrictionCoefficient
            // 
            this.textBoxViscousFrictionCoefficient.Location = new System.Drawing.Point(169, 211);
            this.textBoxViscousFrictionCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViscousFrictionCoefficient.Name = "textBoxViscousFrictionCoefficient";
            this.textBoxViscousFrictionCoefficient.Size = new System.Drawing.Size(51, 25);
            this.textBoxViscousFrictionCoefficient.TabIndex = 15;
            this.textBoxViscousFrictionCoefficient.Text = "0,01";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "   ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Коэф. сухого трения";
            // 
            // textBoxDryFrictionCoefficient
            // 
            this.textBoxDryFrictionCoefficient.Location = new System.Drawing.Point(169, 174);
            this.textBoxDryFrictionCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDryFrictionCoefficient.Name = "textBoxDryFrictionCoefficient";
            this.textBoxDryFrictionCoefficient.Size = new System.Drawing.Size(51, 25);
            this.textBoxDryFrictionCoefficient.TabIndex = 12;
            this.textBoxDryFrictionCoefficient.Text = "0,01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "кг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "м/с";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "м";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Масса";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(169, 137);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(51, 25);
            this.textBoxWeight.TabIndex = 6;
            this.textBoxWeight.Text = "0,2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нач. угл. скорость";
            // 
            // textBoxStartSpeed
            // 
            this.textBoxStartSpeed.Location = new System.Drawing.Point(169, 101);
            this.textBoxStartSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartSpeed.Name = "textBoxStartSpeed";
            this.textBoxStartSpeed.Size = new System.Drawing.Size(51, 25);
            this.textBoxStartSpeed.TabIndex = 4;
            this.textBoxStartSpeed.Text = "0,1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Угол";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(169, 64);
            this.textBoxAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(51, 25);
            this.textBoxAngle.TabIndex = 2;
            this.textBoxAngle.Text = "90";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(169, 27);
            this.textBoxLength.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(51, 25);
            this.textBoxLength.TabIndex = 0;
            this.textBoxLength.Text = "0,3";
            // 
            // groupBoxPendulumControl
            // 
            this.groupBoxPendulumControl.Controls.Add(this.buttonPause);
            this.groupBoxPendulumControl.Controls.Add(this.buttonStart);
            this.groupBoxPendulumControl.Location = new System.Drawing.Point(16, 513);
            this.groupBoxPendulumControl.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPendulumControl.Name = "groupBoxPendulumControl";
            this.groupBoxPendulumControl.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPendulumControl.Size = new System.Drawing.Size(267, 71);
            this.groupBoxPendulumControl.TabIndex = 2;
            this.groupBoxPendulumControl.TabStop = false;
            this.groupBoxPendulumControl.Text = "Управление маятником";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(143, 27);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(105, 30);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(11, 27);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(108, 30);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxImpactOfForce
            // 
            this.groupBoxImpactOfForce.Controls.Add(this.label17);
            this.groupBoxImpactOfForce.Controls.Add(this.label18);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxEndAngle);
            this.groupBoxImpactOfForce.Controls.Add(this.label15);
            this.groupBoxImpactOfForce.Controls.Add(this.label16);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxStartAngle);
            this.groupBoxImpactOfForce.Controls.Add(this.label9);
            this.groupBoxImpactOfForce.Controls.Add(this.label10);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxPower);
            this.groupBoxImpactOfForce.Location = new System.Drawing.Point(16, 374);
            this.groupBoxImpactOfForce.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxImpactOfForce.Name = "groupBoxImpactOfForce";
            this.groupBoxImpactOfForce.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxImpactOfForce.Size = new System.Drawing.Size(267, 131);
            this.groupBoxImpactOfForce.TabIndex = 3;
            this.groupBoxImpactOfForce.TabStop = false;
            this.groupBoxImpactOfForce.Text = "Воздействие силы";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(229, 98);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 19);
            this.label17.TabIndex = 18;
            this.label17.Text = "°";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 98);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 19);
            this.label18.TabIndex = 17;
            this.label18.Text = "φ min";
            // 
            // textBoxEndAngle
            // 
            this.textBoxEndAngle.Location = new System.Drawing.Point(169, 94);
            this.textBoxEndAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEndAngle.Name = "textBoxEndAngle";
            this.textBoxEndAngle.Size = new System.Drawing.Size(51, 25);
            this.textBoxEndAngle.TabIndex = 16;
            this.textBoxEndAngle.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 64);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 19);
            this.label15.TabIndex = 15;
            this.label15.Text = "°";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 64);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 14;
            this.label16.Text = "φ max";
            // 
            // textBoxStartAngle
            // 
            this.textBoxStartAngle.Location = new System.Drawing.Point(169, 60);
            this.textBoxStartAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartAngle.Name = "textBoxStartAngle";
            this.textBoxStartAngle.Size = new System.Drawing.Size(51, 25);
            this.textBoxStartAngle.TabIndex = 13;
            this.textBoxStartAngle.Text = "15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Н";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Сила";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(169, 27);
            this.textBoxPower.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(51, 25);
            this.textBoxPower.TabIndex = 9;
            this.textBoxPower.Text = "240";
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(963, 391);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.LegendText = "\\n";
            series13.LegendToolTip = "Фазовый портрет";
            series13.Name = "Series1";
            series13.YValuesPerPoint = 2;
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(467, 458);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(291, 391);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.LegendText = "\\n";
            series14.LegendToolTip = "Фазовая траектория";
            series14.Name = "Series1";
            series14.YValuesPerPoint = 2;
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(664, 458);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 290);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 19);
            this.label20.TabIndex = 21;
            this.label20.Text = "Параметр dt";
            // 
            // textBoxDT
            // 
            this.textBoxDT.Location = new System.Drawing.Point(170, 287);
            this.textBoxDT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(51, 25);
            this.textBoxDT.TabIndex = 20;
            this.textBoxDT.Text = "0,01";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(229, 290);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 19);
            this.label21.TabIndex = 22;
            this.label21.Text = "c";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 321);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 19);
            this.label22.TabIndex = 23;
            this.label22.Text = ".";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(45, 321);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 19);
            this.label23.TabIndex = 24;
            this.label23.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 864);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBoxImpactOfForce);
            this.Controls.Add(this.groupBoxPendulumControl);
            this.Controls.Add(this.groupBoxInitialConditions);
            this.Controls.Add(this.pictureBoxPendulumMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Математический маятник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPendulumMove)).EndInit();
            this.groupBoxInitialConditions.ResumeLayout(false);
            this.groupBoxInitialConditions.PerformLayout();
            this.groupBoxPendulumControl.ResumeLayout(false);
            this.groupBoxImpactOfForce.ResumeLayout(false);
            this.groupBoxImpactOfForce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPendulumMove;
        private System.Windows.Forms.GroupBox groupBoxInitialConditions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.GroupBox groupBoxPendulumControl;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxImpactOfForce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxViscousFrictionCoefficient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDryFrictionCoefficient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxEndAngle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxStartAngle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

