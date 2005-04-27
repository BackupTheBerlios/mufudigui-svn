using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using JH.CommBase;

/// <summary>
/// Summary description for SettingsForm.
/// </summary>
public class SettingsForm : System.Windows.Forms.Form
{
	private System.Windows.Forms.MainMenu mainMenu1;
	private System.Windows.Forms.MenuItem menuItemSaveXML;
	private System.Windows.Forms.MenuItem menuItemOpenXML;
	private System.Windows.Forms.MenuItem menuItemClose;
	private System.Windows.Forms.MenuItem menuItemHSN;
	private System.Windows.Forms.MenuItem menuItemHSX;
	private System.Windows.Forms.MenuItem menuItemHSC;
	private System.Windows.Forms.MenuItem menuItemHSD;
	private System.Windows.Forms.ComboBox comboBoxPort;
	private System.Windows.Forms.ComboBox comboBoxBaud;
	private System.ComponentModel.IContainer components;
	private System.Windows.Forms.ComboBox comboBoxParity;
	private System.Windows.Forms.ComboBox comboBoxDB;
	private System.Windows.Forms.ComboBox comboBoxSB;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.GroupBox groupBox2;
	private System.Windows.Forms.CheckBox checkBoxCTS;
	private System.Windows.Forms.CheckBox checkBoxDSR;
	private System.Windows.Forms.CheckBox checkBoxTxX;
	private System.Windows.Forms.CheckBox checkBoxXC;
	private System.Windows.Forms.Label label6;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.ComboBox comboBoxRTS;
	private System.Windows.Forms.ComboBox comboBoxDTR;
	private System.Windows.Forms.CheckBox checkBoxRxX;
	private System.Windows.Forms.CheckBox checkBoxGD;
	private System.Windows.Forms.GroupBox groupBox3;
	private System.Windows.Forms.NumericUpDown numericUpDownLW;
	private System.Windows.Forms.NumericUpDown numericUpDownHW;
	private System.Windows.Forms.NumericUpDown numericUpDownRxS;
	private System.Windows.Forms.NumericUpDown numericUpDownTxS;
	private System.Windows.Forms.GroupBox groupBox4;
	private System.Windows.Forms.NumericUpDown numericUpDownTC;
	private System.Windows.Forms.NumericUpDown numericUpDownTM;
	private System.Windows.Forms.CheckBox checkBoxAR;
	private System.Windows.Forms.GroupBox groupBox5;
	private System.Windows.Forms.NumericUpDown numericUpDownBRN;
	private System.Windows.Forms.CheckBox checkBoxHX;
	private System.Windows.Forms.ComboBox comboBoxBRK;
	private System.Windows.Forms.ComboBox comboBoxXon;
	private System.Windows.Forms.ComboBox comboBoxXoff;
	private System.Windows.Forms.MenuItem menuItemFile;
	private System.Windows.Forms.MenuItem menuItemDefault;
	private System.Windows.Forms.OpenFileDialog openFileDialog;
	private System.Windows.Forms.SaveFileDialog saveFileDialog;
	private System.Windows.Forms.CheckBox checkBoxBLC;
	private System.Windows.Forms.Label label10;
	private System.Windows.Forms.Label label18;
	private System.Windows.Forms.CheckBox checkBoxCheck;
	private System.Windows.Forms.Label label19;
	private System.Windows.Forms.Label label20;
	private System.Windows.Forms.Label label21;
	private System.Windows.Forms.Label label22;
	private System.Windows.Forms.Label label23;
	private System.Windows.Forms.Label label24;
	private System.Windows.Forms.Label label8;
	private System.Windows.Forms.Label label9;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Label label11;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.ToolTip toolTip;

	public SettingsForm(BaseTerm.CommBaseTermSettings settings)
	{
		//
		// Required for Windows Form Designer support
		//
		InitializeComponent();

		FillASCII(comboBoxXon);
		FillASCII(comboBoxXoff);
		FillASCII(comboBoxBRK);
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
			this.components = new System.ComponentModel.Container();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItemFile = new System.Windows.Forms.MenuItem();
			this.menuItemSaveXML = new System.Windows.Forms.MenuItem();
			this.menuItemOpenXML = new System.Windows.Forms.MenuItem();
			this.menuItemClose = new System.Windows.Forms.MenuItem();
			this.menuItemDefault = new System.Windows.Forms.MenuItem();
			this.menuItemHSN = new System.Windows.Forms.MenuItem();
			this.menuItemHSX = new System.Windows.Forms.MenuItem();
			this.menuItemHSC = new System.Windows.Forms.MenuItem();
			this.menuItemHSD = new System.Windows.Forms.MenuItem();
			this.comboBoxPort = new System.Windows.Forms.ComboBox();
			this.comboBoxBaud = new System.Windows.Forms.ComboBox();
			this.comboBoxParity = new System.Windows.Forms.ComboBox();
			this.comboBoxDB = new System.Windows.Forms.ComboBox();
			this.comboBoxSB = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.numericUpDownTC = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownTM = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownTxS = new System.Windows.Forms.NumericUpDown();
			this.checkBoxCheck = new System.Windows.Forms.CheckBox();
			this.checkBoxXC = new System.Windows.Forms.CheckBox();
			this.checkBoxTxX = new System.Windows.Forms.CheckBox();
			this.checkBoxDSR = new System.Windows.Forms.CheckBox();
			this.checkBoxCTS = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.numericUpDownRxS = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownHW = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownLW = new System.Windows.Forms.NumericUpDown();
			this.checkBoxGD = new System.Windows.Forms.CheckBox();
			this.checkBoxRxX = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBoxDTR = new System.Windows.Forms.ComboBox();
			this.comboBoxRTS = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxXoff = new System.Windows.Forms.ComboBox();
			this.comboBoxXon = new System.Windows.Forms.ComboBox();
			this.checkBoxAR = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.checkBoxBLC = new System.Windows.Forms.CheckBox();
			this.comboBoxBRK = new System.Windows.Forms.ComboBox();
			this.checkBoxHX = new System.Windows.Forms.CheckBox();
			this.numericUpDownBRN = new System.Windows.Forms.NumericUpDown();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTxS)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLW)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBRN)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemFile,
																					  this.menuItemDefault});
			// 
			// menuItemFile
			// 
			this.menuItemFile.Index = 0;
			this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSaveXML,
																						 this.menuItemOpenXML,
																						 this.menuItemClose});
			this.menuItemFile.Text = "&File";
			// 
			// menuItemSaveXML
			// 
			this.menuItemSaveXML.Index = 0;
			this.menuItemSaveXML.Text = "&Save as XML";
			this.menuItemSaveXML.Click += new System.EventHandler(this.menuItemSaveXML_Click);
			// 
			// menuItemOpenXML
			// 
			this.menuItemOpenXML.Index = 1;
			this.menuItemOpenXML.Text = "&Load from XML";
			this.menuItemOpenXML.Click += new System.EventHandler(this.menuItemOpenXML_Click);
			// 
			// menuItemClose
			// 
			this.menuItemClose.Index = 2;
			this.menuItemClose.Text = "&Close";
			this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
			// 
			// menuItemDefault
			// 
			this.menuItemDefault.Index = 1;
			this.menuItemDefault.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.menuItemHSN,
																							this.menuItemHSX,
																							this.menuItemHSC,
																							this.menuItemHSD});
			this.menuItemDefault.Text = "&Defaults";
			// 
			// menuItemHSN
			// 
			this.menuItemHSN.Index = 0;
			this.menuItemHSN.Text = "&No handshaking";
			this.menuItemHSN.Click += new System.EventHandler(this.menuItemHSN_Click);
			// 
			// menuItemHSX
			// 
			this.menuItemHSX.Index = 1;
			this.menuItemHSX.Text = "&Xon / Xoff";
			this.menuItemHSX.Click += new System.EventHandler(this.menuItemHSX_Click);
			// 
			// menuItemHSC
			// 
			this.menuItemHSC.Index = 2;
			this.menuItemHSC.Text = "&CTS / RTS";
			this.menuItemHSC.Click += new System.EventHandler(this.menuItemHSC_Click);
			// 
			// menuItemHSD
			// 
			this.menuItemHSD.Index = 3;
			this.menuItemHSD.Text = "&DSR / DTR";
			this.menuItemHSD.Click += new System.EventHandler(this.menuItemHSD_Click);
			// 
			// comboBoxPort
			// 
			this.comboBoxPort.Location = new System.Drawing.Point(80, 16);
			this.comboBoxPort.Name = "comboBoxPort";
			this.comboBoxPort.Size = new System.Drawing.Size(64, 21);
			this.comboBoxPort.TabIndex = 0;
			this.toolTip.SetToolTip(this.comboBoxPort, "Communications port name (\"COM1\")");
			this.comboBoxPort.DropDown += new System.EventHandler(this.comboBoxPort_DropDown);
			// 
			// comboBoxBaud
			// 
			this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBaud.Items.AddRange(new object[] {
															  "75",
															  "110",
															  "134",
															  "150",
															  "300",
															  "600",
															  "1200",
															  "1800",
															  "2400",
															  "4800",
															  "7200",
															  "9600",
															  "14400",
															  "19200",
															  "38400",
															  "57600",
															  "115200",
															  "128000"});
			this.comboBoxBaud.Location = new System.Drawing.Point(216, 16);
			this.comboBoxBaud.Name = "comboBoxBaud";
			this.comboBoxBaud.Size = new System.Drawing.Size(64, 21);
			this.comboBoxBaud.TabIndex = 2;
			this.toolTip.SetToolTip(this.comboBoxBaud, "Baud rate (unsupported rates will throw an exception)");
			// 
			// comboBoxParity
			// 
			this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxParity.Items.AddRange(new object[] {
																"none",
																"odd",
																"even",
																"mark",
																"space"});
			this.comboBoxParity.Location = new System.Drawing.Point(112, 56);
			this.comboBoxParity.Name = "comboBoxParity";
			this.comboBoxParity.Size = new System.Drawing.Size(64, 21);
			this.comboBoxParity.TabIndex = 4;
			this.toolTip.SetToolTip(this.comboBoxParity, "Parity scheme (except for [none] adds a bit to the frame)");
			// 
			// comboBoxDB
			// 
			this.comboBoxDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDB.Items.AddRange(new object[] {
															"4",
															"5",
															"6",
															"7",
															"8"});
			this.comboBoxDB.Location = new System.Drawing.Point(8, 56);
			this.comboBoxDB.Name = "comboBoxDB";
			this.comboBoxDB.Size = new System.Drawing.Size(64, 21);
			this.comboBoxDB.TabIndex = 6;
			this.toolTip.SetToolTip(this.comboBoxDB, "Number of data bits in the frame (unsupported values will throw an exception)");
			// 
			// comboBoxSB
			// 
			this.comboBoxSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSB.Items.AddRange(new object[] {
															"1",
															"1.5",
															"2"});
			this.comboBoxSB.Location = new System.Drawing.Point(216, 56);
			this.comboBoxSB.Name = "comboBoxSB";
			this.comboBoxSB.Size = new System.Drawing.Size(64, 21);
			this.comboBoxSB.TabIndex = 8;
			this.toolTip.SetToolTip(this.comboBoxSB, "Number of stop bits added to the frame");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.numericUpDownTC);
			this.groupBox1.Controls.Add(this.numericUpDownTM);
			this.groupBox1.Controls.Add(this.numericUpDownTxS);
			this.groupBox1.Controls.Add(this.checkBoxCheck);
			this.groupBox1.Controls.Add(this.checkBoxXC);
			this.groupBox1.Controls.Add(this.checkBoxTxX);
			this.groupBox1.Controls.Add(this.checkBoxDSR);
			this.groupBox1.Controls.Add(this.checkBoxCTS);
			this.groupBox1.Location = new System.Drawing.Point(4, 88);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 216);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tx Flow Control";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 161);
			this.label21.Name = "label21";
			this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label21.Size = new System.Drawing.Size(56, 16);
			this.label21.TabIndex = 29;
			this.label21.Text = "TO Mult";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label21, "Timeout multiplier (ms)");
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 137);
			this.label20.Name = "label20";
			this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label20.Size = new System.Drawing.Size(56, 16);
			this.label20.TabIndex = 28;
			this.label20.Text = "TO Const";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label20, "Timeout constant (ms)");
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 113);
			this.label19.Name = "label19";
			this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label19.Size = new System.Drawing.Size(56, 16);
			this.label19.TabIndex = 27;
			this.label19.Text = "Q Size";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label19, "Requested size of transmission buffer (0 means use operating system defaults");
			// 
			// numericUpDownTC
			// 
			this.numericUpDownTC.Increment = new System.Decimal(new int[] {
																			  500,
																			  0,
																			  0,
																			  0});
			this.numericUpDownTC.Location = new System.Drawing.Point(72, 136);
			this.numericUpDownTC.Maximum = new System.Decimal(new int[] {
																			60000,
																			0,
																			0,
																			0});
			this.numericUpDownTC.Name = "numericUpDownTC";
			this.numericUpDownTC.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownTC.TabIndex = 22;
			this.toolTip.SetToolTip(this.numericUpDownTC, "Timeout constant (ms)");
			// 
			// numericUpDownTM
			// 
			this.numericUpDownTM.Increment = new System.Decimal(new int[] {
																			  500,
																			  0,
																			  0,
																			  0});
			this.numericUpDownTM.Location = new System.Drawing.Point(72, 160);
			this.numericUpDownTM.Maximum = new System.Decimal(new int[] {
																			60000,
																			0,
																			0,
																			0});
			this.numericUpDownTM.Name = "numericUpDownTM";
			this.numericUpDownTM.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownTM.TabIndex = 20;
			this.toolTip.SetToolTip(this.numericUpDownTM, "Timeout multiplier (ms)");
			// 
			// numericUpDownTxS
			// 
			this.numericUpDownTxS.Increment = new System.Decimal(new int[] {
																			   500,
																			   0,
																			   0,
																			   0});
			this.numericUpDownTxS.Location = new System.Drawing.Point(72, 112);
			this.numericUpDownTxS.Maximum = new System.Decimal(new int[] {
																			 60000,
																			 0,
																			 0,
																			 0});
			this.numericUpDownTxS.Name = "numericUpDownTxS";
			this.numericUpDownTxS.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownTxS.TabIndex = 25;
			this.toolTip.SetToolTip(this.numericUpDownTxS, "Requested size of transmission buffer (0 means use operating system defaults");
			// 
			// checkBoxCheck
			// 
			this.checkBoxCheck.Location = new System.Drawing.Point(8, 192);
			this.checkBoxCheck.Name = "checkBoxCheck";
			this.checkBoxCheck.Size = new System.Drawing.Size(104, 16);
			this.checkBoxCheck.TabIndex = 26;
			this.checkBoxCheck.Text = "Check all sends";
			this.toolTip.SetToolTip(this.checkBoxCheck, "Check the result of all sends (slows performance)");
			// 
			// checkBoxXC
			// 
			this.checkBoxXC.Location = new System.Drawing.Point(8, 88);
			this.checkBoxXC.Name = "checkBoxXC";
			this.checkBoxXC.Size = new System.Drawing.Size(112, 16);
			this.checkBoxXC.TabIndex = 3;
			this.checkBoxXC.Text = "Tx when Rx Xoff";
			this.toolTip.SetToolTip(this.checkBoxXC, "Block transmission when Xoff has been sent (for devices which treat any character" +
				" as Xon)");
			// 
			// checkBoxTxX
			// 
			this.checkBoxTxX.Location = new System.Drawing.Point(8, 64);
			this.checkBoxTxX.Name = "checkBoxTxX";
			this.checkBoxTxX.Size = new System.Drawing.Size(112, 16);
			this.checkBoxTxX.TabIndex = 2;
			this.checkBoxTxX.Text = "Xon / Xoff";
			this.toolTip.SetToolTip(this.checkBoxTxX, "Xon and Xoff codes control transmission");
			// 
			// checkBoxDSR
			// 
			this.checkBoxDSR.Location = new System.Drawing.Point(8, 40);
			this.checkBoxDSR.Name = "checkBoxDSR";
			this.checkBoxDSR.Size = new System.Drawing.Size(112, 16);
			this.checkBoxDSR.TabIndex = 1;
			this.checkBoxDSR.Text = "DSR";
			this.toolTip.SetToolTip(this.checkBoxDSR, "DSR input controls transmission");
			// 
			// checkBoxCTS
			// 
			this.checkBoxCTS.Location = new System.Drawing.Point(8, 16);
			this.checkBoxCTS.Name = "checkBoxCTS";
			this.checkBoxCTS.Size = new System.Drawing.Size(112, 16);
			this.checkBoxCTS.TabIndex = 0;
			this.checkBoxCTS.Text = "CTS";
			this.toolTip.SetToolTip(this.checkBoxCTS, "CTS input controls transmission");
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.label23);
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.numericUpDownRxS);
			this.groupBox2.Controls.Add(this.numericUpDownHW);
			this.groupBox2.Controls.Add(this.numericUpDownLW);
			this.groupBox2.Controls.Add(this.checkBoxGD);
			this.groupBox2.Controls.Add(this.checkBoxRxX);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.comboBoxDTR);
			this.groupBox2.Controls.Add(this.comboBoxRTS);
			this.groupBox2.Location = new System.Drawing.Point(148, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(144, 186);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rx Flow Control";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(8, 161);
			this.label24.Name = "label24";
			this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label24.Size = new System.Drawing.Size(56, 16);
			this.label24.TabIndex = 30;
			this.label24.Text = "L. Water";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label24, "Number of characters remaining in buffer at which reception is re-enabled");
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(8, 137);
			this.label23.Name = "label23";
			this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label23.Size = new System.Drawing.Size(56, 16);
			this.label23.TabIndex = 29;
			this.label23.Text = "H. Water";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label23, "Number of free spaces in buffer at which reception is disabled");
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 113);
			this.label22.Name = "label22";
			this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label22.Size = new System.Drawing.Size(56, 16);
			this.label22.TabIndex = 28;
			this.label22.Text = "Q Size";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label22, "Requested size of reception buffer (0 means use operating system defaults)");
			// 
			// numericUpDownRxS
			// 
			this.numericUpDownRxS.Increment = new System.Decimal(new int[] {
																			   500,
																			   0,
																			   0,
																			   0});
			this.numericUpDownRxS.Location = new System.Drawing.Point(72, 112);
			this.numericUpDownRxS.Maximum = new System.Decimal(new int[] {
																			 60000,
																			 0,
																			 0,
																			 0});
			this.numericUpDownRxS.Name = "numericUpDownRxS";
			this.numericUpDownRxS.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownRxS.TabIndex = 20;
			this.toolTip.SetToolTip(this.numericUpDownRxS, "Requested size of reception buffer (0 means use operating system defaults)");
			// 
			// numericUpDownHW
			// 
			this.numericUpDownHW.Increment = new System.Decimal(new int[] {
																			  500,
																			  0,
																			  0,
																			  0});
			this.numericUpDownHW.Location = new System.Drawing.Point(72, 136);
			this.numericUpDownHW.Maximum = new System.Decimal(new int[] {
																			60000,
																			0,
																			0,
																			0});
			this.numericUpDownHW.Name = "numericUpDownHW";
			this.numericUpDownHW.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownHW.TabIndex = 19;
			this.toolTip.SetToolTip(this.numericUpDownHW, "Number of free spaces in buffer at which reception is disabled");
			// 
			// numericUpDownLW
			// 
			this.numericUpDownLW.Increment = new System.Decimal(new int[] {
																			  500,
																			  0,
																			  0,
																			  0});
			this.numericUpDownLW.Location = new System.Drawing.Point(72, 160);
			this.numericUpDownLW.Maximum = new System.Decimal(new int[] {
																			60000,
																			0,
																			0,
																			0});
			this.numericUpDownLW.Name = "numericUpDownLW";
			this.numericUpDownLW.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownLW.TabIndex = 18;
			this.toolTip.SetToolTip(this.numericUpDownLW, "Number of characters remaining in buffer at which reception is re-enabled");
			// 
			// checkBoxGD
			// 
			this.checkBoxGD.Location = new System.Drawing.Point(8, 88);
			this.checkBoxGD.Name = "checkBoxGD";
			this.checkBoxGD.Size = new System.Drawing.Size(112, 16);
			this.checkBoxGD.TabIndex = 10;
			this.checkBoxGD.Text = "Gate on DSR";
			this.toolTip.SetToolTip(this.checkBoxGD, "Received characters are ignored unless DSR is asserted");
			// 
			// checkBoxRxX
			// 
			this.checkBoxRxX.Location = new System.Drawing.Point(8, 64);
			this.checkBoxRxX.Name = "checkBoxRxX";
			this.checkBoxRxX.Size = new System.Drawing.Size(88, 16);
			this.checkBoxRxX.TabIndex = 9;
			this.checkBoxRxX.Text = "Xon / Xoff";
			this.toolTip.SetToolTip(this.checkBoxRxX, "Xon and Xoff are sent to control reception");
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "DTR";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label7, "The use to which the DTR output is put");
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "RTS";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label6, "The use to which the RTS output is put");
			// 
			// comboBoxDTR
			// 
			this.comboBoxDTR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDTR.Items.AddRange(new object[] {
															 "none",
															 "online",
															 "handshake",
															 "gate"});
			this.comboBoxDTR.Location = new System.Drawing.Point(56, 40);
			this.comboBoxDTR.Name = "comboBoxDTR";
			this.comboBoxDTR.Size = new System.Drawing.Size(80, 21);
			this.comboBoxDTR.TabIndex = 6;
			this.toolTip.SetToolTip(this.comboBoxDTR, "The use to which the DTR output is put");
			// 
			// comboBoxRTS
			// 
			this.comboBoxRTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRTS.Items.AddRange(new object[] {
															 "none",
															 "online",
															 "handshake",
															 "gate"});
			this.comboBoxRTS.Location = new System.Drawing.Point(56, 16);
			this.comboBoxRTS.Name = "comboBoxRTS";
			this.comboBoxRTS.Size = new System.Drawing.Size(80, 21);
			this.comboBoxRTS.TabIndex = 5;
			this.toolTip.SetToolTip(this.comboBoxRTS, "The use to which the RTS output is put");
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.comboBoxPort);
			this.groupBox3.Controls.Add(this.comboBoxBaud);
			this.groupBox3.Controls.Add(this.comboBoxDB);
			this.groupBox3.Controls.Add(this.comboBoxParity);
			this.groupBox3.Controls.Add(this.comboBoxSB);
			this.groupBox3.Location = new System.Drawing.Point(4, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 88);
			this.groupBox3.TabIndex = 20;
			this.groupBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(145, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Baud";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label2, "Baud rate (unsupported rates will throw an exception)");
			this.label2.UseMnemonic = false;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 17);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 16);
			this.label11.TabIndex = 12;
			this.label11.Text = "Port";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label11, "Communications port name (\"COM1\")");
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(216, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "StopBits";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.label5, "Number of stop bits added to the frame");
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(112, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Parity";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.label3, "Parity scheme (except for [none] adds a bit to the frame)");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "DataBits";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.label4, "Number of data bits in the frame (unsupported values will throw an exception)");
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.comboBoxXoff);
			this.groupBox4.Controls.Add(this.comboBoxXon);
			this.groupBox4.Location = new System.Drawing.Point(4, 303);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox4.Size = new System.Drawing.Size(288, 48);
			this.groupBox4.TabIndex = 21;
			this.groupBox4.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(149, 18);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 28;
			this.label9.Text = "Xoff Code";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label9, "ASCII code to use for Xoff signal");
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 18);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "Xon Code";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label8, "ASCII code to use for Xon signal");
			// 
			// comboBoxXoff
			// 
			this.comboBoxXoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxXoff.Location = new System.Drawing.Point(219, 16);
			this.comboBoxXoff.Name = "comboBoxXoff";
			this.comboBoxXoff.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBoxXoff.Size = new System.Drawing.Size(56, 21);
			this.comboBoxXoff.TabIndex = 26;
			this.toolTip.SetToolTip(this.comboBoxXoff, "ASCII code to use for Xoff signal");
			// 
			// comboBoxXon
			// 
			this.comboBoxXon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxXon.Location = new System.Drawing.Point(75, 16);
			this.comboBoxXon.Name = "comboBoxXon";
			this.comboBoxXon.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBoxXon.Size = new System.Drawing.Size(56, 21);
			this.comboBoxXon.TabIndex = 25;
			this.toolTip.SetToolTip(this.comboBoxXon, "ASCII code to use for Xon signal");
			// 
			// checkBoxAR
			// 
			this.checkBoxAR.Location = new System.Drawing.Point(156, 280);
			this.checkBoxAR.Name = "checkBoxAR";
			this.checkBoxAR.Size = new System.Drawing.Size(96, 16);
			this.checkBoxAR.TabIndex = 22;
			this.checkBoxAR.Text = "Auto re-open";
			this.toolTip.SetToolTip(this.checkBoxAR, "Automatically reopen port if it closes due to an error");
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.checkBoxBLC);
			this.groupBox5.Controls.Add(this.comboBoxBRK);
			this.groupBox5.Controls.Add(this.checkBoxHX);
			this.groupBox5.Controls.Add(this.numericUpDownBRN);
			this.groupBox5.Location = new System.Drawing.Point(4, 352);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(288, 96);
			this.groupBox5.TabIndex = 23;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Display";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(200, 64);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 16);
			this.label18.TabIndex = 27;
			this.label18.Text = "chars.";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 16);
			this.label10.TabIndex = 26;
			this.label10.Text = "Break line every";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label10, "Break line when it reaches this length (0 - do not break)");
			// 
			// checkBoxBLC
			// 
			this.checkBoxBLC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxBLC.Location = new System.Drawing.Point(13, 40);
			this.checkBoxBLC.Name = "checkBoxBLC";
			this.checkBoxBLC.Size = new System.Drawing.Size(152, 16);
			this.checkBoxBLC.TabIndex = 25;
			this.checkBoxBLC.Text = "Break line on ASCII char";
			this.checkBoxBLC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.checkBoxBLC, "Break displayed lines after specified character");
			// 
			// comboBoxBRK
			// 
			this.comboBoxBRK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBRK.Location = new System.Drawing.Point(176, 37);
			this.comboBoxBRK.Name = "comboBoxBRK";
			this.comboBoxBRK.Size = new System.Drawing.Size(56, 21);
			this.comboBoxBRK.TabIndex = 24;
			this.toolTip.SetToolTip(this.comboBoxBRK, "The character after which the line is broken");
			// 
			// checkBoxHX
			// 
			this.checkBoxHX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxHX.Location = new System.Drawing.Point(13, 16);
			this.checkBoxHX.Name = "checkBoxHX";
			this.checkBoxHX.Size = new System.Drawing.Size(152, 16);
			this.checkBoxHX.TabIndex = 23;
			this.checkBoxHX.Text = "Display in hexadecimal";
			this.checkBoxHX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.checkBoxHX, "Display received characters as two hexadecimal digits");
			// 
			// numericUpDownBRN
			// 
			this.numericUpDownBRN.Location = new System.Drawing.Point(151, 64);
			this.numericUpDownBRN.Maximum = new System.Decimal(new int[] {
																			 255,
																			 0,
																			 0,
																			 0});
			this.numericUpDownBRN.Name = "numericUpDownBRN";
			this.numericUpDownBRN.Size = new System.Drawing.Size(48, 20);
			this.numericUpDownBRN.TabIndex = 19;
			this.toolTip.SetToolTip(this.numericUpDownBRN, "Break line when it reaches this length (0 - do not break)");
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "JHC";
			this.openFileDialog.Filter = "JHBaseTerm files|*.JHC|All files|*.*";
			this.openFileDialog.Title = "Open XML Settings File";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "JHC";
			this.saveFileDialog.Filter = "JHBaseTerm files|*.JHC|All files|*.*";
			this.saveFileDialog.Title = "Save XML Settings File";
			// 
			// SettingsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(294, 451);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.checkBoxAR);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Menu = this.mainMenu1;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CommBase Settings";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.SettingsForm_Closing);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTxS)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRxS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLW)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBRN)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

	private void Import()
	{
		BaseTerm.CommBaseTermSettings s = BaseTerm.settings;

		comboBoxPort.Text = s.port;
		checkBoxAR.Checked = s.autoReopen;
		comboBoxBaud.SelectedIndex = comboBoxBaud.FindString(s.baudRate.ToString());
		comboBoxParity.SelectedIndex = (int)s.parity;
		comboBoxDB.SelectedIndex = comboBoxDB.FindString(s.dataBits.ToString());
		comboBoxSB.SelectedIndex = (int)s.stopBits;
		checkBoxCTS.Checked = s.txFlowCTS;
		checkBoxDSR.Checked = s.txFlowDSR;
		checkBoxTxX.Checked = s.txFlowX;
		checkBoxXC.Checked = s.txWhenRxXoff;
		comboBoxRTS.SelectedIndex = (int)s.useRTS;
		comboBoxDTR.SelectedIndex = (int)s.useDTR;
		checkBoxRxX.Checked = s.rxFlowX;
		checkBoxGD.Checked = s.rxGateDSR;
		comboBoxXon.SelectedIndex = (int)s.XonChar;
		comboBoxXoff.SelectedIndex = (int)s.XoffChar;
		numericUpDownTM.Value = s.sendTimeoutMultiplier;
		numericUpDownTC.Value = s.sendTimeoutConstant;
		numericUpDownLW.Value = s.rxLowWater;
		numericUpDownHW.Value = s.rxHighWater;
		numericUpDownRxS.Value = s.rxQueue;
		checkBoxCheck.Checked = s.checkAllSends;
		numericUpDownTxS.Value = s.txQueue;
		checkBoxBLC.Checked = s.breakLineOnChar;
		comboBoxBRK.SelectedIndex = (int)s.lineBreakChar;
		numericUpDownBRN.Value = s.charsInLine;
		checkBoxHX.Checked = s.showAsHex;
	}

	private void Export()
	{
		BaseTerm.CommBaseTermSettings s = BaseTerm.settings;

		s.port = comboBoxPort.Text;
		s.autoReopen = checkBoxAR.Checked;
		s.baudRate = int.Parse(comboBoxBaud.Text);
		s.parity = (CommBase.Parity)comboBoxParity.SelectedIndex;
		s.dataBits = int.Parse(comboBoxDB.Text);
		s.stopBits = (CommBase.StopBits)comboBoxSB.SelectedIndex;
		s.txFlowCTS = checkBoxCTS.Checked;
		s.txFlowDSR = checkBoxDSR.Checked;
		s.txFlowX = checkBoxTxX.Checked;
		s.txWhenRxXoff = checkBoxXC.Checked;
		s.useRTS = (CommBase.HSOutput)comboBoxRTS.SelectedIndex;
		s.useDTR = (CommBase.HSOutput)comboBoxDTR.SelectedIndex;
		s.rxFlowX = checkBoxRxX.Checked;
		s.rxGateDSR = checkBoxGD.Checked;
		s.XonChar = (CommBase.ASCII)comboBoxXon.SelectedIndex;
		s.XoffChar = (CommBase.ASCII)comboBoxXoff.SelectedIndex;
		s.sendTimeoutMultiplier = (uint)numericUpDownTM.Value;
		s.sendTimeoutConstant = (uint)numericUpDownTC.Value;
		s.rxLowWater = (int)numericUpDownLW.Value;
		s.rxHighWater = (int)numericUpDownHW.Value;
		s.rxQueue = (int)numericUpDownRxS.Value;
		s.txQueue = (int)numericUpDownTxS.Value;
		s.checkAllSends = checkBoxCheck.Checked;
		s.breakLineOnChar = checkBoxBLC.Checked;
		s.lineBreakChar = (CommBase.ASCII)comboBoxBRK.SelectedIndex;
		s.charsInLine = (int)numericUpDownBRN.Value;
		s.showAsHex = checkBoxHX.Checked;
	}

	private void FillASCII(ComboBox cb)
	{
		CommBase.ASCII asc;
		for (int i=0; (i < 256); i++)
		{
			asc = (CommBase.ASCII)i;
			if ((i < 33) || (i > 126))
				cb.Items.Add(asc.ToString());
			else
				cb.Items.Add(new string((char)i, 1));
		}
	}

	private void FillPorts(ComboBox cb)
	{
		string n;
		for (int i=0; (i < 99); i++)
		{
			n = "COM" + i.ToString();
			if (BaseTerm.term.IsPortAvailable(n) == CommBase.PortStatus.available)
			{
				cb.Items.Add(n);
			}
		}
	}

	private void SettingsForm_Load(object sender, System.EventArgs e)
	{
		Import();
	}

	private void SettingsForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
	{
		Export();
	}

	private void menuItemHSN_Click(object sender, System.EventArgs e)
	{
		BaseTerm.settings.SetStandard(comboBoxPort.Text, int.Parse(comboBoxBaud.Text), CommBase.Handshake.none);
		Import();
	}

	private void menuItemHSX_Click(object sender, System.EventArgs e)
	{
		BaseTerm.settings.SetStandard(comboBoxPort.Text, int.Parse(comboBoxBaud.Text), CommBase.Handshake.XonXoff);
		Import();
	}

	private void menuItemHSC_Click(object sender, System.EventArgs e)
	{
		BaseTerm.settings.SetStandard(comboBoxPort.Text, int.Parse(comboBoxBaud.Text), CommBase.Handshake.CtsRts);
		Import();
	}

	private void menuItemHSD_Click(object sender, System.EventArgs e)
	{
		BaseTerm.settings.SetStandard(comboBoxPort.Text, int.Parse(comboBoxBaud.Text), CommBase.Handshake.DsrDtr);
		Import();
	}

	private void menuItemClose_Click(object sender, System.EventArgs e)
	{
		this.Close();
	}

	private void menuItemSaveXML_Click(object sender, System.EventArgs e)
	{
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			Export();
			BaseTerm.settings.SaveAsXML(saveFileDialog.OpenFile());
		}
	}

	private void menuItemOpenXML_Click(object sender, System.EventArgs e)
	{
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			BaseTerm.CommBaseTermSettings ss = BaseTerm.CommBaseTermSettings.LoadFromXML(openFileDialog.OpenFile());
			if (ss != null)
			{
				BaseTerm.settings = ss;
				Import();
			}
			else
			{
				MessageBox.Show("Error opening XML settings file", "BaseTerm", MessageBoxButtons.OK);
			}
		}
	}

	private void comboBoxPort_DropDown(object sender, System.EventArgs e)
	{
		if (comboBoxPort.Items.Count < 1) FillPorts(comboBoxPort);	
	}
}
