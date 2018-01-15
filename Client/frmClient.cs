using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Client
{
	public partial class frmClient : Form
	{
		Socket client;
		public frmClient()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(ThreadSendData);
			thread.Name = "ThreadSendData";
			thread.Start();
		}

		private void btOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "All files (*.*)|*.*";
			open.InitialDirectory = @"D:\";
			open.CheckFileExists = true;
			open.Title = "Choose file";
			if (open.ShowDialog() == DialogResult.OK)
			{
				lbDetail.Text = open.FileName;
				string[] temp = open.FileName.Split(char.Parse(@"\"));
				Connect();
				var buffer = Encoding.ASCII.GetBytes("file|"+temp[temp.Length - 1]);
				client.Send(buffer, 0, buffer.Length, SocketFlags.None);
				client.Close();
				lbState.Text = "Watting...";
			}
		}

		void Connect()
		{
			IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(txIP.Text), int.Parse(txPort.Text));
			client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				client.Connect(ipe);
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		private void ThreadSendData()
		{
			FileStream fs = null;

			bool bSendOk = true;
			Connect();
			client.NoDelay = true;

			Application.DoEvents();

			try
			{
				FileInfo fi = new FileInfo(lbDetail.Text);
				ulong fileSize = (ulong)fi.Length;

				progressBar1.Minimum = 0;
				progressBar1.Maximum = 100;
				Application.DoEvents();

				byte[] buffer = new byte[1<<15];
				MemoryStream ms = new MemoryStream(buffer);
				BinaryWriter bw = new BinaryWriter(ms);

				bw.Write(fileSize);
				bw.Close();
				ms.Close();

				fs = File.OpenRead(lbDetail.Text);

				int ns = client.Send(buffer, sizeof(ulong), SocketFlags.None);
				ulong pos = 0;

				while (pos < fileSize)
				{
					int nr = fs.Read(buffer, 0, buffer.Length);
					if (nr <= 0)
					{
						break;
					}

					pos += (ulong)nr;
					ns = client.Send(buffer, nr, SocketFlags.None);

					Thread.Sleep(2);

					progressBar1.Value = (int)(((double)progressBar1.Maximum * (double)pos) / (double)fileSize + 0.5);
					lbCurrent.Text = (int)progressBar1.Value + " %";

					Application.DoEvents();
				}

			}
			catch (Exception e)
			{
				bSendOk = false;
				MessageBox.Show(e.Message, "File Sending Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



			if (fs != null)
			{
				try { fs.Close(); }
				catch (Exception) { }
			}

			if (bSendOk)
			{
				lbState.Text = "Completed!";
				progressBar1.Value = 100;
				lbCurrent.Text = "100 %";
			}
		}
	}
}
