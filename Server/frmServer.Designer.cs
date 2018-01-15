namespace Server
{
	partial class frmServer
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
			this.lstRec = new System.Windows.Forms.ListBox();
			this.txPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Connected";
			// 
			// txIP
			// 
			this.txIP.Location = new System.Drawing.Point(90, 9);
			this.txIP.Name = "txIP";
			this.txIP.Size = new System.Drawing.Size(157, 20);
			this.txIP.TabIndex = 2;
			// 
			// lstRec
			// 
			this.lstRec.FormattingEnabled = true;
			this.lstRec.Location = new System.Drawing.Point(12, 35);
			this.lstRec.Name = "lstRec";
			this.lstRec.Size = new System.Drawing.Size(429, 225);
			this.lstRec.TabIndex = 3;
			this.lstRec.SelectedIndexChanged += new System.EventHandler(this.lstRec_SelectedIndexChanged);
			// 
			// txPort
			// 
			this.txPort.Enabled = false;
			this.txPort.Location = new System.Drawing.Point(285, 9);
			this.txPort.Name = "txPort";
			this.txPort.Size = new System.Drawing.Size(73, 20);
			this.txPort.TabIndex = 5;
			this.txPort.Text = "9090";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(253, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Port";
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Location = new System.Drawing.Point(12, 272);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(53, 13);
			this.lbStatus.TabIndex = 6;
			this.lbStatus.Text = "Watting...";
			// 
			// frmServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 294);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.txPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstRec);
			this.Controls.Add(this.txIP);
			this.Controls.Add(this.label1);
			this.Name = "frmServer";
			this.Text = "Server";
			this.Load += new System.EventHandler(this.frmServer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txIP;
		private System.Windows.Forms.ListBox lstRec;
		private System.Windows.Forms.TextBox txPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbStatus;
	}
}

