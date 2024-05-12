using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;


namespace PhaseMonitor
{
	public partial class Form1 : Form
	{
		int rxCnt = 0;
		double freq_sum = 0;
		string rcv_data = "";
		string[] arr = { "1", "2", "3", "4", "5", "6"};
		int ph1 = 0;
		int ph2 = 0;
		int ph3 = 0;
		int ph4 = 0;
		int ph5 = 0;

		bool isCOM_Open = false;


		List<int> m_DataList1 = new List<int>();
		List<int> m_DataList2 = new List<int>();
		List<int> m_DataList3 = new List<int>();
		List<int> m_DataList4 = new List<int>();

		public Form1()
		{
			InitializeComponent();
			scanCOMPorts();
			
			// チャート初期化
			//chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

			//　データ初期化
			int temp = 0;
			for (int i = 0; i < 100; i++) {
				m_DataList1.Add(temp);
				m_DataList2.Add(temp);
				m_DataList3.Add(temp);
				m_DataList4.Add(temp);
			}
		}


		private void scanCOMPorts()
		{
			comboBox_COM_Port.Items.Clear();
			string[] ports = SerialPort.GetPortNames();
			foreach (string p in ports)
			{
				comboBox_COM_Port.Items.Add(p);
			}
		}



		//Button1のClickイベントハンドラ
		//データ受信の待機を開始する
		private void Button1_Click(object sender, EventArgs e)
		{
			if (isCOM_Open == false)
			{
				try
				{
					serialPort1.BaudRate = 115200;
					serialPort1.Parity = Parity.None;
					serialPort1.DataBits = 8;
					serialPort1.StopBits = StopBits.One;
					serialPort1.Handshake = Handshake.None;
					serialPort1.PortName = comboBox_COM_Port.Text;
					serialPort1.Open();

					button1.Text = "Close";
					comboBox_COM_Port.Enabled = false;
				}
				catch
				{
					button1.Text = "Open";
					comboBox_COM_Port.Enabled = true;
					try
					{
						serialPort1.DiscardInBuffer();  // 入力バッファを破棄
						serialPort1.DiscardOutBuffer(); // 出力バッファを破棄
						serialPort1.Close();             // COMポートを閉じる
					}
					catch { };
				}
			}
			else
			{
				button1.Text = "Open";
				comboBox_COM_Port.Enabled = true;
				try
				{
					serialPort1.DiscardInBuffer();  // 入力バッファを破棄
					serialPort1.DiscardOutBuffer(); // 出力バッファを破棄
					serialPort1.Close();             // COMポートを閉じる
				}
				catch { };
			}
		}


		//RichTextBox1にメッセージを表示する
		private void ShowReceivedString(string str)
		{
			textBox_RxData.Text = str;
		}


		private void ShowSwState(string str)
		{
			textBox_Cnt.Text = rxCnt.ToString();
			textBox_NowFreq.Text = str;

			double ave_freq = freq_sum / rxCnt;
			textBox_AveFreq.Text = ave_freq.ToString("0,####.000000");
			double error_ppb = 1000000000 * (ave_freq - 10000000)/10000000;
			textBox_freqerror.Text = error_ppb.ToString("0.000000");
		}


		private void chart_add1(int num)
		{
			chart1.Series[0].Points.Add(num);
			chart1.Series[0].BorderWidth = 3;
			textBox_ch1.Text = num.ToString();
		}

		private void chart_add2(int num)
		{
			chart1.Series[1].Points.Add(num);
			chart1.Series[1].BorderWidth = 3;
			textBox_ch2.Text = num.ToString();
		}

		private void chart_add3(int num)
		{
			chart1.Series[2].Points.Add(num);
			chart1.Series[2].BorderWidth = 3;
			textBox_ch3.Text = num.ToString();
		}

		private void chart_add4(int num)
		{
			chart1.Series[3].Points.Add(num);
			chart1.Series[3].BorderWidth = 3;
			textBox_ch4.Text = num.ToString();
		}

		private void Add_log(string txt)
		{
			richTextBox_log.AppendText(txt);
		}

		// タイマ割り込み
		int oldCnt = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			int pps = rxCnt - oldCnt;
			oldCnt = rxCnt;
			label_pps.Text = pps.ToString() + "[Packets / s]";
		}


		// シリアルデータ受信
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				rcv_data = serialPort1.ReadLine();
				Console.WriteLine(rcv_data);
				rxCnt++;


				textBox_RxData.BeginInvoke(new Action<string>(ShowReceivedString), rcv_data);

				// 受信データをカンマで区切る
				arr = rcv_data.Split(',');

				// 16進→10進変換
				ph1 = int.Parse(arr[0], System.Globalization.NumberStyles.HexNumber);
				ph2 = int.Parse(arr[1], System.Globalization.NumberStyles.HexNumber);
				ph3 = int.Parse(arr[2], System.Globalization.NumberStyles.HexNumber);
				ph4 = int.Parse(arr[3], System.Globalization.NumberStyles.HexNumber);
				ph5 = int.Parse(arr[4], System.Globalization.NumberStyles.HexNumber);
				int freq10 = int.Parse(arr[5], System.Globalization.NumberStyles.HexNumber);


				// 周波数表示
				double freq_hz = freq10 / 10.0;
				freq_sum += freq_hz;
				textBox_NowFreq.BeginInvoke(new Action<string>(ShowSwState), freq_hz.ToString("0,####.0"));


				// 位相差チャート表示
				chart1.BeginInvoke(new Action<int>(chart_add1), ph1 - ph5);
				chart1.BeginInvoke(new Action<int>(chart_add2), ph2 - ph5);
				chart1.BeginInvoke(new Action<int>(chart_add3), ph3 - ph5);
				chart1.BeginInvoke(new Action<int>(chart_add4), ph4 - ph5);

				// Log
				if (checkBox_LogEn.Checked)
				{
					string log_txt = rxCnt.ToString() + ","
						+ ph1.ToString() + "," + ph2.ToString() + "," + ph3.ToString() + "," + ph4.ToString() + "," + ph5.ToString() + "," + freq10.ToString() + "\n";
					richTextBox_log.BeginInvoke(new Action<string>(Add_log), log_txt);
				}
			}
			catch
			{
				// TODO
			}
		}

		private void checkBox_ch1_grfen_CheckedChanged(object sender, EventArgs e)
		{
			chart1.Series[0].Enabled = checkBox_ch1_grfen.Checked;
		}

		private void checkBox_ch2_grfen_CheckedChanged(object sender, EventArgs e)
		{
			chart1.Series[1].Enabled = checkBox_ch2_grfen.Checked;
		}

		private void checkBox_ch3_grfen_CheckedChanged(object sender, EventArgs e)
		{
			chart1.Series[2].Enabled = checkBox_ch3_grfen.Checked;
		}

		private void checkBox_ch4_grfen_CheckedChanged(object sender, EventArgs e)
		{
			chart1.Series[3].Enabled = checkBox_ch4_grfen.Checked;
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
			chart1.Series[2].Points.Clear();
			chart1.Series[3].Points.Clear();
			rxCnt = 0;
			freq_sum = 0;
			richTextBox_log.Text = "";
		}
	}
}
