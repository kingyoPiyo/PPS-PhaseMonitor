namespace PhaseMonitor
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button_SerialPortOpenClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_RxData = new System.Windows.Forms.TextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.textBox_NowFreq = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label_pps = new System.Windows.Forms.Label();
			this.textBox_ch1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_ch1_name = new System.Windows.Forms.TextBox();
			this.checkBox_ch1_grfen = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.textBox_freqerror = new System.Windows.Forms.TextBox();
			this.textBox_AveFreq = new System.Windows.Forms.TextBox();
			this.textBox_Cnt = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox_ch2_name = new System.Windows.Forms.TextBox();
			this.checkBox_ch2_grfen = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_ch2 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox_ch3_name = new System.Windows.Forms.TextBox();
			this.checkBox_ch3_grfen = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_ch3 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox_ch4_name = new System.Windows.Forms.TextBox();
			this.checkBox_ch4_grfen = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_ch4 = new System.Windows.Forms.TextBox();
			this.button_clear = new System.Windows.Forms.Button();
			this.richTextBox_log = new System.Windows.Forms.RichTextBox();
			this.checkBox_LogEn = new System.Windows.Forms.CheckBox();
			this.comboBox_COM_Port = new System.Windows.Forms.ComboBox();
			this.checkBox_time_stamp = new System.Windows.Forms.CheckBox();
			this.button_re_sync = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_SerialPortOpenClose
			// 
			this.button_SerialPortOpenClose.Location = new System.Drawing.Point(112, 4);
			this.button_SerialPortOpenClose.Name = "button_SerialPortOpenClose";
			this.button_SerialPortOpenClose.Size = new System.Drawing.Size(57, 23);
			this.button_SerialPortOpenClose.TabIndex = 1;
			this.button_SerialPortOpenClose.Text = "Open";
			this.button_SerialPortOpenClose.UseVisualStyleBackColor = true;
			this.button_SerialPortOpenClose.Click += new System.EventHandler(this.Button_SerialPortOpenClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Port";
			// 
			// textBox_RxData
			// 
			this.textBox_RxData.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_RxData.Location = new System.Drawing.Point(175, 7);
			this.textBox_RxData.Name = "textBox_RxData";
			this.textBox_RxData.Size = new System.Drawing.Size(393, 19);
			this.textBox_RxData.TabIndex = 3;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// textBox_NowFreq
			// 
			this.textBox_NowFreq.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_NowFreq.Location = new System.Drawing.Point(43, 45);
			this.textBox_NowFreq.Name = "textBox_NowFreq";
			this.textBox_NowFreq.Size = new System.Drawing.Size(156, 23);
			this.textBox_NowFreq.TabIndex = 3;
			this.textBox_NowFreq.Text = "10,000,000.0";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea6.AxisX.Title = "Time [s]";
			chartArea6.AxisY.Title = "Phase Error [ns]";
			chartArea6.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea6);
			legend6.Name = "Legend1";
			this.chart1.Legends.Add(legend6);
			this.chart1.Location = new System.Drawing.Point(12, 141);
			this.chart1.Name = "chart1";
			series21.ChartArea = "ChartArea1";
			series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series21.Legend = "Legend1";
			series21.Name = "CH1";
			series22.ChartArea = "ChartArea1";
			series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series22.Legend = "Legend1";
			series22.Name = "CH2";
			series23.ChartArea = "ChartArea1";
			series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series23.Legend = "Legend1";
			series23.Name = "CH3";
			series24.ChartArea = "ChartArea1";
			series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series24.Legend = "Legend1";
			series24.Name = "CH4";
			this.chart1.Series.Add(series21);
			this.chart1.Series.Add(series22);
			this.chart1.Series.Add(series23);
			this.chart1.Series.Add(series24);
			this.chart1.Size = new System.Drawing.Size(995, 403);
			this.chart1.TabIndex = 5;
			this.chart1.Text = "chart1";
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(205, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hz";
			// 
			// label_pps
			// 
			this.label_pps.AutoSize = true;
			this.label_pps.Location = new System.Drawing.Point(579, 10);
			this.label_pps.Name = "label_pps";
			this.label_pps.Size = new System.Drawing.Size(80, 12);
			this.label_pps.TabIndex = 4;
			this.label_pps.Text = "0[Packets / s]";
			// 
			// textBox_ch1
			// 
			this.textBox_ch1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ch1.Location = new System.Drawing.Point(5, 40);
			this.textBox_ch1.Name = "textBox_ch1";
			this.textBox_ch1.Size = new System.Drawing.Size(129, 42);
			this.textBox_ch1.TabIndex = 3;
			this.textBox_ch1.Text = "1234";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox_ch1_name);
			this.groupBox1.Controls.Add(this.checkBox_ch1_grfen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox_ch1);
			this.groupBox1.Location = new System.Drawing.Point(6, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(187, 89);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CH1";
			// 
			// textBox_ch1_name
			// 
			this.textBox_ch1_name.Location = new System.Drawing.Point(5, 18);
			this.textBox_ch1_name.Name = "textBox_ch1_name";
			this.textBox_ch1_name.Size = new System.Drawing.Size(129, 19);
			this.textBox_ch1_name.TabIndex = 5;
			this.textBox_ch1_name.Text = "CH1_NAME";
			// 
			// checkBox_ch1_grfen
			// 
			this.checkBox_ch1_grfen.AutoSize = true;
			this.checkBox_ch1_grfen.Checked = true;
			this.checkBox_ch1_grfen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_ch1_grfen.Location = new System.Drawing.Point(137, 20);
			this.checkBox_ch1_grfen.Name = "checkBox_ch1_grfen";
			this.checkBox_ch1_grfen.Size = new System.Drawing.Size(40, 16);
			this.checkBox_ch1_grfen.TabIndex = 4;
			this.checkBox_ch1_grfen.Text = "GV";
			this.checkBox_ch1_grfen.UseVisualStyleBackColor = true;
			this.checkBox_ch1_grfen.CheckedChanged += new System.EventHandler(this.checkBox_ch1_grfen_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(139, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "ns";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.textBox_freqerror);
			this.groupBox5.Controls.Add(this.textBox_AveFreq);
			this.groupBox5.Controls.Add(this.textBox_Cnt);
			this.groupBox5.Controls.Add(this.textBox_NowFreq);
			this.groupBox5.Controls.Add(this.label12);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Location = new System.Drawing.Point(767, 5);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(240, 130);
			this.groupBox5.TabIndex = 7;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Ref-IN Freq (Gate = CH1)";
			// 
			// textBox_freqerror
			// 
			this.textBox_freqerror.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_freqerror.Location = new System.Drawing.Point(43, 100);
			this.textBox_freqerror.Name = "textBox_freqerror";
			this.textBox_freqerror.Size = new System.Drawing.Size(156, 23);
			this.textBox_freqerror.TabIndex = 3;
			this.textBox_freqerror.Text = "1.000000";
			// 
			// textBox_AveFreq
			// 
			this.textBox_AveFreq.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_AveFreq.Location = new System.Drawing.Point(43, 74);
			this.textBox_AveFreq.Name = "textBox_AveFreq";
			this.textBox_AveFreq.Size = new System.Drawing.Size(156, 23);
			this.textBox_AveFreq.TabIndex = 3;
			this.textBox_AveFreq.Text = "10,000,000.0";
			// 
			// textBox_Cnt
			// 
			this.textBox_Cnt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_Cnt.Location = new System.Drawing.Point(43, 18);
			this.textBox_Cnt.Name = "textBox_Cnt";
			this.textBox_Cnt.Size = new System.Drawing.Size(156, 23);
			this.textBox_Cnt.TabIndex = 3;
			this.textBox_Cnt.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label12.Location = new System.Drawing.Point(203, 103);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 16);
			this.label12.TabIndex = 2;
			this.label12.Text = "ppb";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label10.Location = new System.Drawing.Point(205, 77);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 16);
			this.label10.TabIndex = 2;
			this.label10.Text = "Hz";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 12);
			this.label9.TabIndex = 4;
			this.label9.Text = "Cnt ; ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 104);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(26, 12);
			this.label11.TabIndex = 4;
			this.label11.Text = "Err :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 81);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 12);
			this.label8.TabIndex = 4;
			this.label8.Text = "Ave ;";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 12);
			this.label7.TabIndex = 4;
			this.label7.Text = "Now ; ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox_ch2_name);
			this.groupBox2.Controls.Add(this.checkBox_ch2_grfen);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.textBox_ch2);
			this.groupBox2.Location = new System.Drawing.Point(196, 46);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(187, 89);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "CH2";
			// 
			// textBox_ch2_name
			// 
			this.textBox_ch2_name.Location = new System.Drawing.Point(5, 17);
			this.textBox_ch2_name.Name = "textBox_ch2_name";
			this.textBox_ch2_name.Size = new System.Drawing.Size(129, 19);
			this.textBox_ch2_name.TabIndex = 5;
			this.textBox_ch2_name.Text = "CH2_NAME";
			// 
			// checkBox_ch2_grfen
			// 
			this.checkBox_ch2_grfen.AutoSize = true;
			this.checkBox_ch2_grfen.Checked = true;
			this.checkBox_ch2_grfen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_ch2_grfen.Location = new System.Drawing.Point(137, 19);
			this.checkBox_ch2_grfen.Name = "checkBox_ch2_grfen";
			this.checkBox_ch2_grfen.Size = new System.Drawing.Size(40, 16);
			this.checkBox_ch2_grfen.TabIndex = 4;
			this.checkBox_ch2_grfen.Text = "GV";
			this.checkBox_ch2_grfen.UseVisualStyleBackColor = true;
			this.checkBox_ch2_grfen.CheckedChanged += new System.EventHandler(this.checkBox_ch2_grfen_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(137, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 29);
			this.label4.TabIndex = 2;
			this.label4.Text = "ns";
			// 
			// textBox_ch2
			// 
			this.textBox_ch2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ch2.Location = new System.Drawing.Point(5, 40);
			this.textBox_ch2.Name = "textBox_ch2";
			this.textBox_ch2.Size = new System.Drawing.Size(129, 42);
			this.textBox_ch2.TabIndex = 3;
			this.textBox_ch2.Text = "1234";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox_ch3_name);
			this.groupBox3.Controls.Add(this.checkBox_ch3_grfen);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.textBox_ch3);
			this.groupBox3.Location = new System.Drawing.Point(386, 46);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(187, 89);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "CH3";
			// 
			// textBox_ch3_name
			// 
			this.textBox_ch3_name.Location = new System.Drawing.Point(5, 18);
			this.textBox_ch3_name.Name = "textBox_ch3_name";
			this.textBox_ch3_name.Size = new System.Drawing.Size(129, 19);
			this.textBox_ch3_name.TabIndex = 5;
			this.textBox_ch3_name.Text = "CH3_NAME";
			// 
			// checkBox_ch3_grfen
			// 
			this.checkBox_ch3_grfen.AutoSize = true;
			this.checkBox_ch3_grfen.Checked = true;
			this.checkBox_ch3_grfen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_ch3_grfen.Location = new System.Drawing.Point(138, 20);
			this.checkBox_ch3_grfen.Name = "checkBox_ch3_grfen";
			this.checkBox_ch3_grfen.Size = new System.Drawing.Size(40, 16);
			this.checkBox_ch3_grfen.TabIndex = 4;
			this.checkBox_ch3_grfen.Text = "GV";
			this.checkBox_ch3_grfen.UseVisualStyleBackColor = true;
			this.checkBox_ch3_grfen.CheckedChanged += new System.EventHandler(this.checkBox_ch3_grfen_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(137, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 29);
			this.label5.TabIndex = 2;
			this.label5.Text = "ns";
			// 
			// textBox_ch3
			// 
			this.textBox_ch3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ch3.Location = new System.Drawing.Point(5, 40);
			this.textBox_ch3.Name = "textBox_ch3";
			this.textBox_ch3.Size = new System.Drawing.Size(129, 42);
			this.textBox_ch3.TabIndex = 3;
			this.textBox_ch3.Text = "1234";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox_ch4_name);
			this.groupBox4.Controls.Add(this.checkBox_ch4_grfen);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.textBox_ch4);
			this.groupBox4.Location = new System.Drawing.Point(576, 46);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(187, 89);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "CH4";
			// 
			// textBox_ch4_name
			// 
			this.textBox_ch4_name.Location = new System.Drawing.Point(5, 19);
			this.textBox_ch4_name.Name = "textBox_ch4_name";
			this.textBox_ch4_name.Size = new System.Drawing.Size(129, 19);
			this.textBox_ch4_name.TabIndex = 5;
			this.textBox_ch4_name.Text = "CH4_NAME";
			// 
			// checkBox_ch4_grfen
			// 
			this.checkBox_ch4_grfen.AutoSize = true;
			this.checkBox_ch4_grfen.Checked = true;
			this.checkBox_ch4_grfen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_ch4_grfen.Location = new System.Drawing.Point(137, 21);
			this.checkBox_ch4_grfen.Name = "checkBox_ch4_grfen";
			this.checkBox_ch4_grfen.Size = new System.Drawing.Size(40, 16);
			this.checkBox_ch4_grfen.TabIndex = 4;
			this.checkBox_ch4_grfen.Text = "GV";
			this.checkBox_ch4_grfen.UseVisualStyleBackColor = true;
			this.checkBox_ch4_grfen.CheckedChanged += new System.EventHandler(this.checkBox_ch4_grfen_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(137, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 29);
			this.label6.TabIndex = 2;
			this.label6.Text = "ns";
			// 
			// textBox_ch4
			// 
			this.textBox_ch4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox_ch4.Location = new System.Drawing.Point(5, 40);
			this.textBox_ch4.Name = "textBox_ch4";
			this.textBox_ch4.Size = new System.Drawing.Size(129, 42);
			this.textBox_ch4.TabIndex = 3;
			this.textBox_ch4.Text = "1234";
			// 
			// button_clear
			// 
			this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button_clear.Location = new System.Drawing.Point(664, 4);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(46, 23);
			this.button_clear.TabIndex = 1;
			this.button_clear.Text = "A.C.";
			this.button_clear.UseVisualStyleBackColor = false;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// richTextBox_log
			// 
			this.richTextBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.richTextBox_log.Location = new System.Drawing.Point(111, 550);
			this.richTextBox_log.Name = "richTextBox_log";
			this.richTextBox_log.Size = new System.Drawing.Size(896, 69);
			this.richTextBox_log.TabIndex = 8;
			this.richTextBox_log.Text = "";
			// 
			// checkBox_LogEn
			// 
			this.checkBox_LogEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox_LogEn.AutoSize = true;
			this.checkBox_LogEn.Checked = true;
			this.checkBox_LogEn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_LogEn.Location = new System.Drawing.Point(11, 552);
			this.checkBox_LogEn.Name = "checkBox_LogEn";
			this.checkBox_LogEn.Size = new System.Drawing.Size(80, 16);
			this.checkBox_LogEn.TabIndex = 9;
			this.checkBox_LogEn.Text = "Log Enable";
			this.checkBox_LogEn.UseVisualStyleBackColor = true;
			this.checkBox_LogEn.CheckedChanged += new System.EventHandler(this.checkBox_LogEn_CheckedChanged);
			// 
			// comboBox_COM_Port
			// 
			this.comboBox_COM_Port.FormattingEnabled = true;
			this.comboBox_COM_Port.Location = new System.Drawing.Point(37, 6);
			this.comboBox_COM_Port.Name = "comboBox_COM_Port";
			this.comboBox_COM_Port.Size = new System.Drawing.Size(69, 20);
			this.comboBox_COM_Port.TabIndex = 10;
			// 
			// checkBox_time_stamp
			// 
			this.checkBox_time_stamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox_time_stamp.AutoSize = true;
			this.checkBox_time_stamp.Checked = true;
			this.checkBox_time_stamp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_time_stamp.Enabled = false;
			this.checkBox_time_stamp.Location = new System.Drawing.Point(11, 574);
			this.checkBox_time_stamp.Name = "checkBox_time_stamp";
			this.checkBox_time_stamp.Size = new System.Drawing.Size(85, 16);
			this.checkBox_time_stamp.TabIndex = 9;
			this.checkBox_time_stamp.Text = "Time Stamp";
			this.checkBox_time_stamp.UseVisualStyleBackColor = true;
			// 
			// button_re_sync
			// 
			this.button_re_sync.BackColor = System.Drawing.Color.Lime;
			this.button_re_sync.Location = new System.Drawing.Point(712, 4);
			this.button_re_sync.Name = "button_re_sync";
			this.button_re_sync.Size = new System.Drawing.Size(49, 23);
			this.button_re_sync.TabIndex = 1;
			this.button_re_sync.Text = "SYNC";
			this.button_re_sync.UseVisualStyleBackColor = false;
			this.button_re_sync.Click += new System.EventHandler(this.button_re_sync_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 624);
			this.Controls.Add(this.comboBox_COM_Port);
			this.Controls.Add(this.checkBox_time_stamp);
			this.Controls.Add(this.checkBox_LogEn);
			this.Controls.Add(this.richTextBox_log);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.label_pps);
			this.Controls.Add(this.textBox_RxData);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_re_sync);
			this.Controls.Add(this.button_clear);
			this.Controls.Add(this.button_SerialPortOpenClose);
			this.Controls.Add(this.groupBox5);
			this.MinimumSize = new System.Drawing.Size(1030, 500);
			this.Name = "Form1";
			this.Text = "4CH Phase Monitor";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button button_SerialPortOpenClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_RxData;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TextBox textBox_NowFreq;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_pps;
		private System.Windows.Forms.TextBox textBox_ch1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox_ch1_grfen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox_ch2_grfen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_ch2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox_ch3_grfen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_ch3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBox_ch4_grfen;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_ch4;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_AveFreq;
		private System.Windows.Forms.TextBox textBox_Cnt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RichTextBox richTextBox_log;
		private System.Windows.Forms.CheckBox checkBox_LogEn;
		private System.Windows.Forms.TextBox textBox_freqerror;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboBox_COM_Port;
		private System.Windows.Forms.TextBox textBox_ch1_name;
		private System.Windows.Forms.TextBox textBox_ch2_name;
		private System.Windows.Forms.TextBox textBox_ch3_name;
		private System.Windows.Forms.TextBox textBox_ch4_name;
		private System.Windows.Forms.CheckBox checkBox_time_stamp;
		private System.Windows.Forms.Button button_re_sync;
	}
}

