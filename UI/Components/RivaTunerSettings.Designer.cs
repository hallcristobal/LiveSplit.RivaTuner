﻿namespace LiveSplit.RivaTuner.UI.Components
{
    partial class RivaTunerSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbComponents = new System.Windows.Forms.ListBox();
            this.lbAddedComponents = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTotalSegments = new System.Windows.Forms.NumericUpDown();
            this.nudUpcomingSegments = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rbSplitAccuracySeconds = new System.Windows.Forms.RadioButton();
            this.rbSplitAccuracyTenths = new System.Windows.Forms.RadioButton();
            this.rbSplitAccuracyHundreths = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.rbDeltaAccuracySeconds = new System.Windows.Forms.RadioButton();
            this.chkDeltaDropDecimals = new System.Windows.Forms.CheckBox();
            this.rbDeltaAccuracyTenths = new System.Windows.Forms.RadioButton();
            this.rbDeltaAccuracyHundreths = new System.Windows.Forms.RadioButton();
            this.chkLockLastSplit = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpcomingSegments)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbComponents
            // 
            this.lbComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbComponents.FormattingEnabled = true;
            this.lbComponents.Location = new System.Drawing.Point(10, 30);
            this.lbComponents.Name = "lbComponents";
            this.lbComponents.Size = new System.Drawing.Size(180, 244);
            this.lbComponents.TabIndex = 0;
            // 
            // lbAddedComponents
            // 
            this.lbAddedComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddedComponents.FormattingEnabled = true;
            this.lbAddedComponents.Location = new System.Drawing.Point(269, 30);
            this.lbAddedComponents.Name = "lbAddedComponents";
            this.lbAddedComponents.Size = new System.Drawing.Size(180, 244);
            this.lbAddedComponents.TabIndex = 1;
            this.lbAddedComponents.SelectedIndexChanged += new System.EventHandler(this.lbAddedComponents_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbComponents, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbAddedComponents, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 702);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Components";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(269, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Added Components";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnInsert, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnMoveUp, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnMoveDown, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(196, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(67, 244);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(3, 65);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(61, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsert.Location = new System.Drawing.Point(3, 105);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(61, 34);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(3, 145);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(61, 34);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(3, 185);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(61, 34);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RivaTuner Settings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel3.Controls.Add(this.nudFontSize, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(433, 30);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // nudFontSize
            // 
            this.nudFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.nudFontSize, 2);
            this.nudFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFontSize.Location = new System.Drawing.Point(197, 4);
            this.nudFontSize.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(233, 20);
            this.nudFontSize.TabIndex = 0;
            this.nudFontSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Text Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 235);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Splits Settings";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.nudTotalSegments, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.nudUpcomingSegments, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.chkLockLastSplit, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(433, 216);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Splits:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Upcoming Splits:";
            // 
            // nudTotalSegments
            // 
            this.nudTotalSegments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.nudTotalSegments, 2);
            this.nudTotalSegments.Location = new System.Drawing.Point(197, 4);
            this.nudTotalSegments.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTotalSegments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalSegments.Name = "nudTotalSegments";
            this.nudTotalSegments.Size = new System.Drawing.Size(233, 20);
            this.nudTotalSegments.TabIndex = 2;
            this.nudTotalSegments.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudUpcomingSegments
            // 
            this.nudUpcomingSegments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.nudUpcomingSegments, 2);
            this.nudUpcomingSegments.Location = new System.Drawing.Point(197, 33);
            this.nudUpcomingSegments.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUpcomingSegments.Name = "nudUpcomingSegments";
            this.nudUpcomingSegments.Size = new System.Drawing.Size(233, 20);
            this.nudUpcomingSegments.TabIndex = 3;
            this.nudUpcomingSegments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox3, 3);
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split Time Accuracy";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.rbSplitAccuracySeconds, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbSplitAccuracyTenths, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbSplitAccuracyHundreths, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(421, 24);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // rbSplitAccuracySeconds
            // 
            this.rbSplitAccuracySeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSplitAccuracySeconds.AutoSize = true;
            this.rbSplitAccuracySeconds.Location = new System.Drawing.Point(3, 3);
            this.rbSplitAccuracySeconds.Name = "rbSplitAccuracySeconds";
            this.rbSplitAccuracySeconds.Size = new System.Drawing.Size(134, 17);
            this.rbSplitAccuracySeconds.TabIndex = 0;
            this.rbSplitAccuracySeconds.TabStop = true;
            this.rbSplitAccuracySeconds.Text = "Seconds";
            this.rbSplitAccuracySeconds.UseVisualStyleBackColor = true;
            this.rbSplitAccuracySeconds.CheckedChanged += new System.EventHandler(this.SplitAccuracy_CheckedChanged);
            // 
            // rbSplitAccuracyTenths
            // 
            this.rbSplitAccuracyTenths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSplitAccuracyTenths.AutoSize = true;
            this.rbSplitAccuracyTenths.Location = new System.Drawing.Point(143, 3);
            this.rbSplitAccuracyTenths.Name = "rbSplitAccuracyTenths";
            this.rbSplitAccuracyTenths.Size = new System.Drawing.Size(134, 17);
            this.rbSplitAccuracyTenths.TabIndex = 1;
            this.rbSplitAccuracyTenths.TabStop = true;
            this.rbSplitAccuracyTenths.Text = "Tenths";
            this.rbSplitAccuracyTenths.UseVisualStyleBackColor = true;
            this.rbSplitAccuracyTenths.CheckedChanged += new System.EventHandler(this.SplitAccuracy_CheckedChanged);
            // 
            // rbSplitAccuracyHundreths
            // 
            this.rbSplitAccuracyHundreths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSplitAccuracyHundreths.AutoSize = true;
            this.rbSplitAccuracyHundreths.Location = new System.Drawing.Point(283, 3);
            this.rbSplitAccuracyHundreths.Name = "rbSplitAccuracyHundreths";
            this.rbSplitAccuracyHundreths.Size = new System.Drawing.Size(135, 17);
            this.rbSplitAccuracyHundreths.TabIndex = 2;
            this.rbSplitAccuracyHundreths.TabStop = true;
            this.rbSplitAccuracyHundreths.Text = "Hundreths";
            this.rbSplitAccuracyHundreths.UseVisualStyleBackColor = true;
            this.rbSplitAccuracyHundreths.CheckedChanged += new System.EventHandler(this.SplitAccuracy_CheckedChanged);
            // 
            // groupBox4
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox4, 3);
            this.groupBox4.Controls.Add(this.tableLayoutPanel7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 73);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delta Time Accuracy";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.Controls.Add(this.rbDeltaAccuracySeconds, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.chkDeltaDropDecimals, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.rbDeltaAccuracyTenths, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.rbDeltaAccuracyHundreths, 2, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(421, 54);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // rbDeltaAccuracySeconds
            // 
            this.rbDeltaAccuracySeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDeltaAccuracySeconds.AutoSize = true;
            this.rbDeltaAccuracySeconds.Location = new System.Drawing.Point(3, 33);
            this.rbDeltaAccuracySeconds.Name = "rbDeltaAccuracySeconds";
            this.rbDeltaAccuracySeconds.Size = new System.Drawing.Size(134, 17);
            this.rbDeltaAccuracySeconds.TabIndex = 0;
            this.rbDeltaAccuracySeconds.TabStop = true;
            this.rbDeltaAccuracySeconds.Text = "Seconds";
            this.rbDeltaAccuracySeconds.UseVisualStyleBackColor = true;
            this.rbDeltaAccuracySeconds.CheckedChanged += new System.EventHandler(this.DeltaAccuracy_CheckedChanged);
            // 
            // chkDeltaDropDecimals
            // 
            this.chkDeltaDropDecimals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDeltaDropDecimals.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.chkDeltaDropDecimals, 2);
            this.chkDeltaDropDecimals.Location = new System.Drawing.Point(3, 6);
            this.chkDeltaDropDecimals.Name = "chkDeltaDropDecimals";
            this.chkDeltaDropDecimals.Size = new System.Drawing.Size(274, 17);
            this.chkDeltaDropDecimals.TabIndex = 0;
            this.chkDeltaDropDecimals.Text = "Drop Decimals When Over 1 Minute";
            this.chkDeltaDropDecimals.UseVisualStyleBackColor = true;
            // 
            // rbDeltaAccuracyTenths
            // 
            this.rbDeltaAccuracyTenths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDeltaAccuracyTenths.AutoSize = true;
            this.rbDeltaAccuracyTenths.Location = new System.Drawing.Point(143, 33);
            this.rbDeltaAccuracyTenths.Name = "rbDeltaAccuracyTenths";
            this.rbDeltaAccuracyTenths.Size = new System.Drawing.Size(134, 17);
            this.rbDeltaAccuracyTenths.TabIndex = 1;
            this.rbDeltaAccuracyTenths.TabStop = true;
            this.rbDeltaAccuracyTenths.Text = "Tenths";
            this.rbDeltaAccuracyTenths.UseVisualStyleBackColor = true;
            this.rbDeltaAccuracyTenths.CheckedChanged += new System.EventHandler(this.DeltaAccuracy_CheckedChanged);
            // 
            // rbDeltaAccuracyHundreths
            // 
            this.rbDeltaAccuracyHundreths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDeltaAccuracyHundreths.AutoSize = true;
            this.rbDeltaAccuracyHundreths.Location = new System.Drawing.Point(283, 33);
            this.rbDeltaAccuracyHundreths.Name = "rbDeltaAccuracyHundreths";
            this.rbDeltaAccuracyHundreths.Size = new System.Drawing.Size(135, 17);
            this.rbDeltaAccuracyHundreths.TabIndex = 2;
            this.rbDeltaAccuracyHundreths.TabStop = true;
            this.rbDeltaAccuracyHundreths.Text = "Hundreths";
            this.rbDeltaAccuracyHundreths.UseVisualStyleBackColor = true;
            this.rbDeltaAccuracyHundreths.CheckedChanged += new System.EventHandler(this.DeltaAccuracy_CheckedChanged);
            // 
            // chkLockLastSplit
            // 
            this.chkLockLastSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLockLastSplit.AutoSize = true;
            this.chkLockLastSplit.Location = new System.Drawing.Point(3, 64);
            this.chkLockLastSplit.Name = "chkLockLastSplit";
            this.chkLockLastSplit.Size = new System.Drawing.Size(188, 17);
            this.chkLockLastSplit.TabIndex = 6;
            this.chkLockLastSplit.Text = "Always Show Last Split";
            this.chkLockLastSplit.UseVisualStyleBackColor = true;
            // 
            // RivaTunerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RivaTunerSettings";
            this.Size = new System.Drawing.Size(459, 702);
            this.Load += new System.EventHandler(this.RivaTunerSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpcomingSegments)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbComponents;
        private System.Windows.Forms.ListBox lbAddedComponents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTotalSegments;
        private System.Windows.Forms.NumericUpDown nudUpcomingSegments;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkLockLastSplit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RadioButton rbDeltaAccuracySeconds;
        private System.Windows.Forms.CheckBox chkDeltaDropDecimals;
        private System.Windows.Forms.RadioButton rbDeltaAccuracyTenths;
        private System.Windows.Forms.RadioButton rbDeltaAccuracyHundreths;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rbSplitAccuracySeconds;
        private System.Windows.Forms.RadioButton rbSplitAccuracyTenths;
        private System.Windows.Forms.RadioButton rbSplitAccuracyHundreths;
    }
}
