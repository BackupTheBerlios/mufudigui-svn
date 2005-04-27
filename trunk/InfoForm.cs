using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using JH.CommBase;

public class InfoForm : System.Windows.Forms.Form
{
	private System.Timers.Timer timer;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.TextBox textBoxTxS;
	private System.Windows.Forms.TextBox textBoxTxQ;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.TextBox textBoxTxI;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label labelTxS;
	private System.Windows.Forms.Label labelCongested;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.TextBox textBoxRxS;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox textBoxRxQ;
	private System.Windows.Forms.Label label5;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.Container components = null;

	public InfoForm()
	{
		//
		// Required for Windows Form Designer support
		//
		InitializeComponent();

		this.Text = "BaseTerm Q Status: " + BaseTerm.settings.port;

		Update();
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	protected override void Dispose( bool disposing )
	{
		if( disposing )
		{
			if(components != null)
			{
				components.Dispose();
			}
		}
		base.Dispose( disposing );
	}

	#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.timer = new System.Timers.Timer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTxS = new System.Windows.Forms.TextBox();
			this.textBoxTxQ = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxTxI = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.labelTxS = new System.Windows.Forms.Label();
			this.labelCongested = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBoxRxS = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxRxQ = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.SynchronizingObject = this;
			this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelCongested);
			this.groupBox1.Controls.Add(this.labelTxS);
			this.groupBox1.Controls.Add(this.textBoxTxI);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxTxQ);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxTxS);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transmission Queue";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Size:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxTxS
			// 
			this.textBoxTxS.Location = new System.Drawing.Point(72, 16);
			this.textBoxTxS.Name = "textBoxTxS";
			this.textBoxTxS.ReadOnly = true;
			this.textBoxTxS.Size = new System.Drawing.Size(88, 20);
			this.textBoxTxS.TabIndex = 1;
			this.textBoxTxS.Text = "";
			// 
			// textBoxTxQ
			// 
			this.textBoxTxQ.Location = new System.Drawing.Point(72, 40);
			this.textBoxTxQ.Name = "textBoxTxQ";
			this.textBoxTxQ.ReadOnly = true;
			this.textBoxTxQ.Size = new System.Drawing.Size(88, 20);
			this.textBoxTxQ.TabIndex = 3;
			this.textBoxTxQ.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Queued:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxTxI
			// 
			this.textBoxTxI.Location = new System.Drawing.Point(128, 64);
			this.textBoxTxI.Name = "textBoxTxI";
			this.textBoxTxI.ReadOnly = true;
			this.textBoxTxI.Size = new System.Drawing.Size(32, 20);
			this.textBoxTxI.TabIndex = 5;
			this.textBoxTxI.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Immediate Buffer:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTxS
			// 
			this.labelTxS.Location = new System.Drawing.Point(8, 88);
			this.labelTxS.Name = "labelTxS";
			this.labelTxS.Size = new System.Drawing.Size(160, 16);
			this.labelTxS.TabIndex = 6;
			this.labelTxS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCongested
			// 
			this.labelCongested.Location = new System.Drawing.Point(8, 104);
			this.labelCongested.Name = "labelCongested";
			this.labelCongested.Size = new System.Drawing.Size(160, 16);
			this.labelCongested.TabIndex = 7;
			this.labelCongested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBoxRxQ);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxRxS);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 128);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 72);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Reception Queue";
			// 
			// textBoxRxS
			// 
			this.textBoxRxS.Location = new System.Drawing.Point(76, 16);
			this.textBoxRxS.Name = "textBoxRxS";
			this.textBoxRxS.ReadOnly = true;
			this.textBoxRxS.Size = new System.Drawing.Size(88, 20);
			this.textBoxRxS.TabIndex = 3;
			this.textBoxRxS.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Size:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxRxQ
			// 
			this.textBoxRxQ.Location = new System.Drawing.Point(76, 40);
			this.textBoxRxQ.Name = "textBoxRxQ";
			this.textBoxRxQ.ReadOnly = true;
			this.textBoxRxQ.Size = new System.Drawing.Size(88, 20);
			this.textBoxRxQ.TabIndex = 5;
			this.textBoxRxQ.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Queued:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InfoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(194, 208);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "InfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CommBase Queue Status";
			this.TopMost = true;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.InfoForm_Closing);
			((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
	{
		Update();
	}

	private new void Update()
	{
		long v; string s;
		CommBase.QueueStatus q = BaseTerm.term.GetQueueStatus();
		v = q.OutQueueSize;
		textBoxTxS.Text = (v > 0)? v.ToString() : "Unknown";
		textBoxTxQ.Text = q.OutQueue.ToString();
		textBoxTxI.Text = q.immediateWaiting? "1" : "0";
		s = "";
		if (q.ctsHold) s = s + "CTS ";
		if (q.dsrHold) s = s + "DSR ";
		if (q.rlsdHold) s = s + "RLSD ";
		if (q.ctsHold) s = s + "RxXoff ";
		if (q.ctsHold) s = s + "TxXoff ";

		if (s == "")
			labelTxS.Text = "Transmitting";
		else
			labelTxS.Text = "Blocked: " + s;

		if (BaseTerm.term.IsCongested())
			labelCongested.Text = "Congested";
		else
			labelCongested.Text = "Not Congested";
		v = q.InQueueSize;
		textBoxRxS.Text = (v > 0)? v.ToString() : "Unknown";
		textBoxRxQ.Text = q.InQueue.ToString();
	}

	private void InfoForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
	{
		timer.Enabled = false;
	}
}
