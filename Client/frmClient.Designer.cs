namespace Client
{
	partial class frmClient
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txIP = new System.Windows.Forms.TextBox();
			this.txPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lbState = new System.Windows.Forms.Label();
			this.lbCurrent = new System.Windows.Forms.Label();
			this.btOpen = new System.Windows.Forms.Button();
			this.lbDetail = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "IPAddress";
			// 
			// txIP
			// 
			this.txIP.Location = new System.Drawing.Point(73, 12);
			this.txIP.Name = "txIP";
			this.txIP.Size = new System.Drawing.Size(173, 20);
			this.txIP.TabIndex = 1;
			this.txIP.Text = "127.0.0.1";
			// 
			// txPort
			// 
			this.txPort.Location = new System.Drawing.Point(313, 12);
			this.txPort.Name = "txPort";
			this.txPort.Size = new System.Drawing.Size(76, 20);
			this.txPort.TabIndex = 5;
			this.txPort.Text = "9090";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(252, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "IPAddress";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(395, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Send";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(15, 86);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(385, 23);
			this.progressBar1.TabIndex = 7;
			// 
			// lbState
			// 
			this.lbState.AutoSize = true;
			this.lbState.Location = new System.Drawing.Point(12, 70);
			this.lbState.Name = "lbState";
			this.lbState.Size = new System.Drawing.Size(53, 13);
			this.lbState.TabIndex = 8;
			this.lbState.Text = "Watting...";
			// 
			// lbCurrent
			// 
			this.lbCurrent.AutoSize = true;
			this.lbCurrent.Location = new System.Drawing.Point(406, 91);
			this.lbCurrent.Name = "lbCurrent";
			this.lbCurrent.Size = new System.Drawing.Size(24, 13);
			this.lbCurrent.TabIndex = 9;
			this.lbCurrent.Text = "0 %";
			// 
			// btOpen
			// 
			this.btOpen.Location = new System.Drawing.Point(15, 38);
			this.btOpen.Name = "btOpen";
			this.btOpen.Size = new System.Drawing.Size(52, 23);
			this.btOpen.TabIndex = 10;
			this.btOpen.Text = "Open";
			this.btOpen.UseVisualStyleBackColor = true;
			this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
			// 
			// lbDetail
			// 
			this.lbDetail.AutoSize = true;
			this.lbDetail.Location = new System.Drawing.Point(73, 43);
			this.lbDetail.Name = "lbDetail";
			this.lbDetail.Size = new System.Drawing.Size(26, 13);
			this.lbDetail.TabIndex = 11;
			this.lbDetail.Text = "File:";
			// 
			// frmClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 121);
			this.Controls.Add(this.lbDetail);
			this.Controls.Add(this.btOpen);
			this.Controls.Add(this.lbCurrent);
			this.Controls.Add(this.lbState);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txIP);
			this.Controls.Add(this.label1);
			this.Name = "frmClient";
			this.Text = "Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txIP;
		private System.Windows.Forms.TextBox txPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lbState;
		private System.Windows.Forms.Label lbCurrent;
		private System.Windows.Forms.Button btOpen;
		private System.Windows.Forms.Label lbDetail;
	}
}

