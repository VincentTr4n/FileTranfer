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

namespace Server
{
	public partial class frmServer : Form
	{
		Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		string local = @"D:\Documents\TempFileTranfer\";
		public frmServer()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			FormClosing += (o, e) => { Environment.Exit(0); };
		}

		private void frmServer_Load(object sender, EventArgs e)
		{
			Thread thread = new Thread(ThreadListen);
			thread.Name = "ThreadListen";
			thread.Start();
		}

		string saveFileName = "";
		bool check = false;
		private void ThreadRecvData(object obj)
		{
			Socket socket = (Socket)obj;
			socket.NoDelay = true;

			bool bTranferOk = true;
			FileStream fs = null;

			Application.DoEvents();

			try
			{
				byte[] buffer = null;
				int rec = 0;
				string[] temp = null;
				if (check)
				{
					buffer = new byte[32 * 1024];
					rec = socket.Receive(buffer, sizeof(ulong), SocketFlags.None);
				}
				else
				{
					buffer = new byte[1 << 10];
					rec = socket.Receive(buffer);
					temp = Encoding.ASCII.GetString(buffer, 0, rec).Split('|');
					lbStatus.Text = "Watting...";
					check = true;
				}
				
				if (temp != null && temp[0] == "file")  saveFileName = temp[1];
				else
				{
					//if(MessageBox.Show("Send file completed! Save it?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
					//{
					//	socket.Close();								// Trong này có thể dùng để xử lý việc check file trước khi save
					//	return;
					//}
					fs = File.Create(local+saveFileName);
					MemoryStream ms = new MemoryStream(buffer);
					BinaryReader br = new BinaryReader(ms);
					ulong fileSize = br.ReadUInt64();
					br.Close();
					ms.Close();

					Application.DoEvents();

					ulong pos = 0;
					while (pos < fileSize)
					{
						rec = socket.Receive(buffer);
						if (rec <= 0)
						{
							throw new Exception("Receive 0 byte");
						}

						pos += (ulong)rec;
						fs.Write(buffer, 0, rec);

						Application.DoEvents();
					}
					check = false;
					lstRec.Items.Add(local+saveFileName);
				}
			}
			catch (Exception e)
			{
				bTranferOk = false;
				MessageBox.Show(e.Message, "File Receiving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (fs != null)
			{
				try { fs.Close(); }
				catch (Exception) { }
			}

			socket.Close();

			if (!bTranferOk)
			{
				try { File.Delete(local+saveFileName); }
				catch (Exception) { }
			}
			else
			{
				if (!check) lbStatus.Text = "Receive complete : " + saveFileName;
			}

		}

		private void ThreadListen()
		{
			server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			server.Bind(new IPEndPoint(IPAddress.Any, 9090));
			server.Listen(5);
			while (true)
			{
				Socket socket = server.Accept();
				txIP.Text = socket.RemoteEndPoint.ToString();

				Thread thread = new Thread(ThreadRecvData);
				thread.Name = "ThreadRecvData";
				thread.Start(socket);
			}
		}

		private void lstRec_SelectedIndexChanged(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(lstRec.SelectedItem.ToString());
		}
	}
}
