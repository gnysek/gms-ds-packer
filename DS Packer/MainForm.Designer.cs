﻿namespace DS_Packer
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listView1 = new System.Windows.Forms.ListView();
			this.cKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelTop = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.btnOptions = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton13 = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.radioButton10 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.radioButton11 = new System.Windows.Forms.RadioButton();
			this.radioButton12 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.buttonSave = new wyDay.Controls.SplitButton();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItemTxt = new System.Windows.Forms.MenuItem();
			this.menuItemCSV = new System.Windows.Forms.MenuItem();
			this.menuItemGmlMap = new System.Windows.Forms.MenuItem();
			this.menuItemGmlList = new System.Windows.Forms.MenuItem();
			this.buttonNew = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnImportCSV = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel7 = new System.Windows.Forms.Panel();
			this.optExportREAD = new System.Windows.Forms.RadioButton();
			this.optExportADD = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			this.panel1.SuspendLayout();
			this.panelTop.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cKey,
            this.cValue});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.GridLines = true;
			this.listView1.LabelEdit = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(736, 181);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.VirtualMode = true;
			this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
			// 
			// cKey
			// 
			this.cKey.Text = "Key";
			this.cKey.Width = 100;
			// 
			// cValue
			// 
			this.cValue.Text = "Value";
			this.cValue.Width = 100;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 411);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel3,
            this.statusBarPanel2});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(736, 22);
			this.statusBar1.SizingGrip = false;
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "statusBar1";
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.statusBarPanel1.Name = "statusBarPanel1";
			this.statusBarPanel1.Text = "-";
			this.statusBarPanel1.Width = 18;
			// 
			// statusBarPanel3
			// 
			this.statusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.statusBarPanel3.Name = "statusBarPanel3";
			this.statusBarPanel3.Text = "0";
			this.statusBarPanel3.Width = 20;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel2.Name = "statusBarPanel2";
			this.statusBarPanel2.Text = "-";
			this.statusBarPanel2.Width = 698;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 230);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(736, 181);
			this.panel1.TabIndex = 2;
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.label11);
			this.panelTop.Controls.Add(this.btnOptions);
			this.panelTop.Controls.Add(this.groupBox1);
			this.panelTop.Controls.Add(this.buttonSave);
			this.panelTop.Controls.Add(this.buttonNew);
			this.panelTop.Controls.Add(this.button2);
			this.panelTop.Controls.Add(this.btnImportCSV);
			this.panelTop.Controls.Add(this.label10);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(736, 230);
			this.panelTop.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label11.Location = new System.Drawing.Point(550, 18);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(187, 22);
			this.label11.TabIndex = 17;
			this.label11.Text = "variable=ds_map_create();\r\nexportedScript(variable); ";
			// 
			// btnOptions
			// 
			this.btnOptions.Location = new System.Drawing.Point(488, 4);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(75, 23);
			this.btnOptions.TabIndex = 6;
			this.btnOptions.Text = "options";
			this.btnOptions.UseVisualStyleBackColor = true;
			this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.panel7);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.panel6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.panel4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.panel3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(5, 55);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(728, 169);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(352, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(248, 52);
			this.label9.TabIndex = 15;
			this.label9.Text = "When exporting to GML, it will save script to which \r\nwill return map ID.\r\nFor mo" +
    "re info, check ds_map_read & ds_list_read\r\nin GM:Studio documentation.";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(10, 146);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(181, 17);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Column names in first line (max 5)";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.radioButton1);
			this.panel6.Controls.Add(this.radioButton13);
			this.panel6.Location = new System.Drawing.Point(355, 49);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(139, 43);
			this.panel6.TabIndex = 10;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(3, 23);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(80, 17);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "2nd column";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton13
			// 
			this.radioButton13.AutoSize = true;
			this.radioButton13.Location = new System.Drawing.Point(3, 3);
			this.radioButton13.Name = "radioButton13";
			this.radioButton13.Size = new System.Drawing.Size(77, 17);
			this.radioButton13.TabIndex = 4;
			this.radioButton13.TabStop = true;
			this.radioButton13.Text = "1st Column";
			this.radioButton13.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(352, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "As values, export:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(352, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "DS List Export:";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.radioButton9);
			this.panel5.Controls.Add(this.radioButton10);
			this.panel5.Location = new System.Drawing.Point(205, 113);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(139, 43);
			this.panel5.TabIndex = 10;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(3, 23);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(132, 17);
			this.radioButton9.TabIndex = 5;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "Same as column name";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// radioButton10
			// 
			this.radioButton10.AutoSize = true;
			this.radioButton10.Checked = true;
			this.radioButton10.Location = new System.Drawing.Point(3, 3);
			this.radioButton10.Name = "radioButton10";
			this.radioButton10.Size = new System.Drawing.Size(118, 17);
			this.radioButton10.TabIndex = 4;
			this.radioButton10.TabStop = true;
			this.radioButton10.Text = "Incremental number";
			this.radioButton10.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(202, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Suffix:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.radioButton11);
			this.panel4.Controls.Add(this.radioButton12);
			this.panel4.Location = new System.Drawing.Point(205, 49);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(139, 43);
			this.panel4.TabIndex = 9;
			// 
			// radioButton11
			// 
			this.radioButton11.AutoSize = true;
			this.radioButton11.Location = new System.Drawing.Point(3, 23);
			this.radioButton11.Name = "radioButton11";
			this.radioButton11.Size = new System.Drawing.Size(139, 17);
			this.radioButton11.TabIndex = 5;
			this.radioButton11.TabStop = true;
			this.radioButton11.Text = "Export as files with suffix";
			this.radioButton11.UseVisualStyleBackColor = true;
			// 
			// radioButton12
			// 
			this.radioButton12.AutoSize = true;
			this.radioButton12.Checked = true;
			this.radioButton12.Location = new System.Drawing.Point(3, 3);
			this.radioButton12.Name = "radioButton12";
			this.radioButton12.Size = new System.Drawing.Size(82, 17);
			this.radioButton12.TabIndex = 4;
			this.radioButton12.TabStop = true;
			this.radioButton12.Text = "Don\'t export";
			this.radioButton12.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(202, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "DS Map Export:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(202, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Beyond 2nd column:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.radioButton8);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.radioButton5);
			this.panel3.Controls.Add(this.radioButton6);
			this.panel3.Controls.Add(this.radioButton7);
			this.panel3.Location = new System.Drawing.Point(117, 69);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(77, 70);
			this.panel3.TabIndex = 8;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(39, 23);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(27, 17);
			this.radioButton8.TabIndex = 8;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "\'";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(18, 43);
			this.textBox2.MaxLength = 1;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(31, 20);
			this.textBox2.TabIndex = 7;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(3, 46);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(14, 13);
			this.radioButton5.TabIndex = 6;
			this.radioButton5.TabStop = true;
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(3, 23);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(30, 17);
			this.radioButton6.TabIndex = 5;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "\"";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Checked = true;
			this.radioButton7.Location = new System.Drawing.Point(3, 3);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(51, 17);
			this.radioButton7.TabIndex = 4;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "None";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(114, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Records inside:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Records divided by:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton2);
			this.panel2.Location = new System.Drawing.Point(10, 69);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(54, 70);
			this.panel2.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 43);
			this.textBox1.MaxLength = 1;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(31, 20);
			this.textBox1.TabIndex = 7;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(3, 46);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(14, 13);
			this.radioButton4.TabIndex = 6;
			this.radioButton4.TabStop = true;
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(3, 23);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(28, 17);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = ";";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(3, 3);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(28, 17);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = ",";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "CSV Import/Export options";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(10, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(167, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Import more than two columns";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.AutoSize = true;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonSave.Image = global::DS_Packer.Properties.Resources.save_as;
			this.buttonSave.Location = new System.Drawing.Point(84, 5);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(96, 40);
			this.buttonSave.SplitMenu = this.contextMenu1;
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemTxt,
            this.menuItemCSV,
            this.menuItemGmlMap,
            this.menuItemGmlList});
			// 
			// menuItemTxt
			// 
			this.menuItemTxt.Index = 0;
			this.menuItemTxt.RadioCheck = true;
			this.menuItemTxt.Text = "TXT - Value per line";
			this.menuItemTxt.Click += new System.EventHandler(this.menuItemTxt_Click);
			// 
			// menuItemCSV
			// 
			this.menuItemCSV.Index = 1;
			this.menuItemCSV.RadioCheck = true;
			this.menuItemCSV.Text = "CSV - Key, Value";
			this.menuItemCSV.Click += new System.EventHandler(this.menuItemCSV_Click);
			// 
			// menuItemGmlMap
			// 
			this.menuItemGmlMap.Index = 2;
			this.menuItemGmlMap.RadioCheck = true;
			this.menuItemGmlMap.Text = "GML - ds_map_read";
			this.menuItemGmlMap.Click += new System.EventHandler(this.menuItemGmlMap_Click);
			// 
			// menuItemGmlList
			// 
			this.menuItemGmlList.Index = 3;
			this.menuItemGmlList.RadioCheck = true;
			this.menuItemGmlList.Text = "GML - ds_list_read";
			this.menuItemGmlList.Click += new System.EventHandler(this.menuItemGmlList_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonNew.Image = global::DS_Packer.Properties.Resources.page_white_database;
			this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonNew.Location = new System.Drawing.Point(5, 5);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(73, 40);
			this.buttonNew.TabIndex = 2;
			this.buttonNew.Text = "New File";
			this.buttonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Image = global::DS_Packer.Properties.Resources.folder_page;
			this.button2.Location = new System.Drawing.Point(186, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(77, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "Open GDS";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			// 
			// btnImportCSV
			// 
			this.btnImportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnImportCSV.Image = global::DS_Packer.Properties.Resources.folder_database;
			this.btnImportCSV.Location = new System.Drawing.Point(269, 5);
			this.btnImportCSV.Name = "btnImportCSV";
			this.btnImportCSV.Size = new System.Drawing.Size(82, 40);
			this.btnImportCSV.TabIndex = 0;
			this.btnImportCSV.Text = "Import CSV";
			this.btnImportCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnImportCSV.UseVisualStyleBackColor = true;
			this.btnImportCSV.Click += new System.EventHandler(this.btnImportCSV_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.Location = new System.Drawing.Point(357, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(187, 33);
			this.label10.TabIndex = 16;
			this.label10.Text = "GML usage:\r\nvariable=ds_list_create();\r\nexportedScript(variable);";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.optExportADD);
			this.panel7.Controls.Add(this.optExportREAD);
			this.panel7.Location = new System.Drawing.Point(500, 49);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(164, 43);
			this.panel7.TabIndex = 16;
			// 
			// optExportREAD
			// 
			this.optExportREAD.AutoSize = true;
			this.optExportREAD.Checked = true;
			this.optExportREAD.Location = new System.Drawing.Point(3, 3);
			this.optExportREAD.Name = "optExportREAD";
			this.optExportREAD.Size = new System.Drawing.Size(133, 17);
			this.optExportREAD.TabIndex = 6;
			this.optExportREAD.TabStop = true;
			this.optExportREAD.Text = "ds_xxx_read(arg0, \'...\');";
			this.optExportREAD.UseVisualStyleBackColor = true;
			// 
			// optExportADD
			// 
			this.optExportADD.AutoSize = true;
			this.optExportADD.Location = new System.Drawing.Point(3, 23);
			this.optExportADD.Name = "optExportADD";
			this.optExportADD.Size = new System.Drawing.Size(155, 17);
			this.optExportADD.TabIndex = 6;
			this.optExportADD.Text = "ds_xxx_add(argument0, ...);";
			this.optExportADD.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(497, 32);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(116, 13);
			this.label12.TabIndex = 17;
			this.label12.Text = "Export structure format:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 433);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.statusBar1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DS Map & List Packer - (C) 2013 Gear Studio, Piotr \'gnysek\' Gnys";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader cKey;
		private System.Windows.Forms.ColumnHeader cValue;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Button btnImportCSV;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonNew;
		private wyDay.Controls.SplitButton buttonSave;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemCSV;
		private System.Windows.Forms.MenuItem menuItemGmlMap;
		private System.Windows.Forms.MenuItem menuItemGmlList;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnOptions;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.RadioButton radioButton12;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton13;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuItem menuItemTxt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.RadioButton optExportADD;
		private System.Windows.Forms.RadioButton optExportREAD;
		private System.Windows.Forms.Label label12;


	}
}

