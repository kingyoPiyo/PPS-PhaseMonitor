using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;


namespace PhaseMonitor
{
	public partial class Form1 : Form
	{
		int rxCnt = 0;
		UInt64 freq_sum_10 = 0;
		string rcv_data = "";
		string[] arr = { "1", "2", "3", "4", "5", "6"};
		Int64 ph1 = 0;
		Int64 ph2 = 0;
		Int64 ph3 = 0;
		Int64 ph4 = 0;
		Int64 ph5 = 0;

		const int CHRT_MAX_NUM = 4;
		const int MAX_PHASE_ERR_NS = 100000000;	// +- 100ms

		bool isCOM_Open = false;


		public Form1()
		{
			InitializeComponent();


			// 設定読み出し
			//DataMod dt = new DataMod();
			//dt.LogSave();
			//dt.LogLoad();

			scanCOMPorts();

			// チャート初期化
			for (int i = 0; i < CHRT_MAX_NUM; i++)
			{
				chart1.Series[i].BorderWidth = 3;
				chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
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

			if (ports.Length > 0) {
				comboBox_COM_Port.SelectedIndex = 0;
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
					isCOM_Open = true;
				}
				catch
				{
					button1.Text = "Open";
					comboBox_COM_Port.Enabled = true;
					try
					{
						serialPort1.DiscardInBuffer();  // 入力バッファを破棄
						serialPort1.DiscardOutBuffer(); // 出力バッファを破棄
						serialPort1.Close();            // COMポートを閉じる
						isCOM_Open = false;
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
					serialPort1.Close();            // COMポートを閉じる
					isCOM_Open = false;
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

			double ave_freq = (double)freq_sum_10 / 10.0 / rxCnt;
			textBox_AveFreq.Text = ave_freq.ToString("0,####.000000");
			double error_ppb = 1000000000 * (ave_freq - 10000000)/10000000;
			textBox_freqerror.Text = error_ppb.ToString("0.000000");
		}


		private void chart_add1(Int64 num)
		{
			chart1.Series[0].Points.Add(num);
			textBox_ch1.Text = num.ToString();
		}

		private void chart_add2(Int64 num)
		{
			chart1.Series[1].Points.Add(num);
			textBox_ch2.Text = num.ToString();
		}

		private void chart_add3(Int64 num)
		{
			chart1.Series[2].Points.Add(num);

			textBox_ch3.Text = num.ToString();
		}

		private void chart_add4(Int64 num)
		{
			chart1.Series[3].Points.Add(num);
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


		// 位相差計算
		private Int64 calc_pd(Int64 t, Int64 r)
		{
			Int64 max = 1073741820;
			Int64 ret = 0;

#if False

			if (r < t)
			{
				if (t - max - r < (max/2))
				{
					ret = t - max - r;
				} else
				{
					ret = t - r;
				}
			} else
			{
				if (t - r < (max / 2))
				{
					ret = t - r;
				} else
				{
					ret = max + t - r;
				}
			}
#else
			ret = t - r;
#endif

			// Clip
			if (ret > MAX_PHASE_ERR_NS) ret = MAX_PHASE_ERR_NS;
			if (ret < (-1 * MAX_PHASE_ERR_NS)) ret = (-1 * MAX_PHASE_ERR_NS);

			return ret;
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
				freq_sum_10 += (UInt64)freq10;
				textBox_NowFreq.BeginInvoke(new Action<string>(ShowSwState), freq_hz.ToString("0,####.0"));


				// 位相差計算 & チャート表示
				chart1.BeginInvoke(new Action<Int64>(chart_add1), calc_pd(ph1, ph5));
				chart1.BeginInvoke(new Action<Int64>(chart_add2), calc_pd(ph2, ph5));
				chart1.BeginInvoke(new Action<Int64>(chart_add3), calc_pd(ph3, ph5));
				chart1.BeginInvoke(new Action<Int64>(chart_add4), calc_pd(ph4, ph5));

				// Log
				if (checkBox_LogEn.Checked)
				{
					string log_txt = "";
					if (checkBox_time_stamp.Checked)
					{
						DateTime dt = DateTime.Now;

						log_txt = rxCnt.ToString() + "," + dt.ToString("yyyy/MM/dd HH:mm:ss") + ","
						+ ph1.ToString() + "," + ph2.ToString() + "," + ph3.ToString() + "," + ph4.ToString() + "," + ph5.ToString() + "," + freq10.ToString() + "\n";
					} else
					{
						log_txt = rxCnt.ToString() + ","
						+ ph1.ToString() + "," + ph2.ToString() + "," + ph3.ToString() + "," + ph4.ToString() + "," + ph5.ToString() + "," + freq10.ToString() + "\n";
					}
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
			for (int i = 0; i < CHRT_MAX_NUM; i++)
			{
				bool tmp = chart1.Series[i].Enabled;
				chart1.Series[i].Enabled = false;
				chart1.Series[i].Points.Clear();
				chart1.Series[i].Enabled = tmp;
			}
			rxCnt = 0;
			freq_sum_10 = 0;
			richTextBox_log.Clear();
			richTextBox_log.Update();
		}

		private void checkBox_LogEn_CheckedChanged(object sender, EventArgs e)
		{
			checkBox_time_stamp.Enabled = !checkBox_LogEn.Checked;
		}


		private void button_re_sync_Click(object sender, EventArgs e)
		{
			if (serialPort1.IsOpen)
			{
				serialPort1.Write("sc\n");
			}
		}
	}
}
