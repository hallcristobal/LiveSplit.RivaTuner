namespace LiveSplit.RivaTuner.UI.Components
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chkOneLine = new System.Windows.Forms.CheckBox();
            this.chkShowGameName = new System.Windows.Forms.CheckBox();
            this.chkShowFinished = new System.Windows.Forms.CheckBox();
            this.chkShowCategoryName = new System.Windows.Forms.CheckBox();
            this.chkShowAttempt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCharacters = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTimingMethod = new System.Windows.Forms.ComboBox();
            this.cbTimerFormatValue = new System.Windows.Forms.ComboBox();
            this.cbTimerFormatFraction = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAlternateFormatValue = new System.Windows.Forms.ComboBox();
            this.cbAlternateFormatFraction = new System.Windows.Forms.ComboBox();
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
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacters)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 855);
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
            this.groupBox1.Size = new System.Drawing.Size(439, 78);
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
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudCharacters, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(433, 59);
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
            30,
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
            this.label3.Text = "Text Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 477);
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
            // groupBox5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox5, 3);
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(10, 364);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 107);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Title Settings";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.chkOneLine, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.chkShowGameName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.chkShowFinished, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.chkShowCategoryName, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.chkShowAttempt, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(433, 88);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // chkOneLine
            // 
            this.chkOneLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOneLine.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chkOneLine, 4);
            this.chkOneLine.Location = new System.Drawing.Point(3, 64);
            this.chkOneLine.Name = "chkOneLine";
            this.chkOneLine.Size = new System.Drawing.Size(427, 17);
            this.chkOneLine.TabIndex = 4;
            this.chkOneLine.Text = "Display Game and Category in Single Line";
            this.chkOneLine.UseVisualStyleBackColor = true;
            // 
            // chkShowGameName
            // 
            this.chkShowGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowGameName.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chkShowGameName, 3);
            this.chkShowGameName.Location = new System.Drawing.Point(3, 6);
            this.chkShowGameName.Name = "chkShowGameName";
            this.chkShowGameName.Size = new System.Drawing.Size(211, 17);
            this.chkShowGameName.TabIndex = 0;
            this.chkShowGameName.Text = "Show Game Name";
            this.chkShowGameName.UseVisualStyleBackColor = true;
            // 
            // chkShowFinished
            // 
            this.chkShowFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowFinished.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chkShowFinished, 3);
            this.chkShowFinished.Location = new System.Drawing.Point(3, 35);
            this.chkShowFinished.Name = "chkShowFinished";
            this.chkShowFinished.Size = new System.Drawing.Size(211, 17);
            this.chkShowFinished.TabIndex = 1;
            this.chkShowFinished.Text = "Show Finished Runs Count";
            this.chkShowFinished.UseVisualStyleBackColor = true;
            // 
            // chkShowCategoryName
            // 
            this.chkShowCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowCategoryName.AutoSize = true;
            this.chkShowCategoryName.Location = new System.Drawing.Point(220, 6);
            this.chkShowCategoryName.Name = "chkShowCategoryName";
            this.chkShowCategoryName.Size = new System.Drawing.Size(210, 17);
            this.chkShowCategoryName.TabIndex = 3;
            this.chkShowCategoryName.Text = "Show Category Name";
            this.chkShowCategoryName.UseVisualStyleBackColor = true;
            // 
            // chkShowAttempt
            // 
            this.chkShowAttempt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowAttempt.AutoSize = true;
            this.chkShowAttempt.Location = new System.Drawing.Point(220, 35);
            this.chkShowAttempt.Name = "chkShowAttempt";
            this.chkShowAttempt.Size = new System.Drawing.Size(210, 17);
            this.chkShowAttempt.TabIndex = 2;
            this.chkShowAttempt.Text = "Show Attempt Count";
            this.chkShowAttempt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Character Width:";
            // 
            // nudCharacters
            // 
            this.nudCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.nudCharacters, 2);
            this.nudCharacters.Location = new System.Drawing.Point(197, 34);
            this.nudCharacters.Minimum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudCharacters.Name = "nudCharacters";
            this.nudCharacters.Size = new System.Drawing.Size(233, 20);
            this.nudCharacters.TabIndex = 3;
            this.nudCharacters.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox6, 3);
            this.groupBox6.Controls.Add(this.tableLayoutPanel8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(10, 718);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(439, 78);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Timer Settings";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.cbTimingMethod, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.cbTimerFormatValue, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.cbTimerFormatFraction, 2, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(433, 59);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Timing Method:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Time Format:";
            // 
            // cbTimingMethod
            // 
            this.cbTimingMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.cbTimingMethod, 2);
            this.cbTimingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimingMethod.FormattingEnabled = true;
            this.cbTimingMethod.Items.AddRange(new object[] {
            "Current Timing Method",
            "Real Time",
            "Game Time"});
            this.cbTimingMethod.Location = new System.Drawing.Point(160, 4);
            this.cbTimingMethod.Name = "cbTimingMethod";
            this.cbTimingMethod.Size = new System.Drawing.Size(270, 21);
            this.cbTimingMethod.TabIndex = 2;
            this.cbTimingMethod.SelectedIndexChanged += new System.EventHandler(this.cmbTimingMethod_SelectedIndexChanged);
            // 
            // cbTimerFormatValue
            // 
            this.cbTimerFormatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimerFormatValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimerFormatValue.FormattingEnabled = true;
            this.cbTimerFormatValue.Items.AddRange(new object[] {
            "1",
            "00:01",
            "0:00:01",
            "00:00:01"});
            this.cbTimerFormatValue.Location = new System.Drawing.Point(160, 33);
            this.cbTimerFormatValue.Name = "cbTimerFormatValue";
            this.cbTimerFormatValue.Size = new System.Drawing.Size(132, 21);
            this.cbTimerFormatValue.TabIndex = 3;
            this.cbTimerFormatValue.SelectedIndexChanged += new System.EventHandler(this.cmbTimerFormat_SelectedIndexChanged);
            // 
            // cbTimerFormatFraction
            // 
            this.cbTimerFormatFraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimerFormatFraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimerFormatFraction.FormattingEnabled = true;
            this.cbTimerFormatFraction.Items.AddRange(new object[] {
            "",
            ".2",
            ".23"});
            this.cbTimerFormatFraction.Location = new System.Drawing.Point(298, 33);
            this.cbTimerFormatFraction.Name = "cbTimerFormatFraction";
            this.cbTimerFormatFraction.Size = new System.Drawing.Size(132, 21);
            this.cbTimerFormatFraction.TabIndex = 4;
            this.cbTimerFormatFraction.SelectedIndexChanged += new System.EventHandler(this.cmbAccuracy_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox7, 3);
            this.groupBox7.Controls.Add(this.tableLayoutPanel9);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(10, 802);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(439, 49);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Alternate Timing Method Settings";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.cbAlternateFormatValue, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.cbAlternateFormatFraction, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(433, 30);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Time Format:";
            // 
            // cbAlternateFormatValue
            // 
            this.cbAlternateFormatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlternateFormatValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlternateFormatValue.FormattingEnabled = true;
            this.cbAlternateFormatValue.Items.AddRange(new object[] {
            "1",
            "00:01",
            "0:00:01",
            "00:00:01"});
            this.cbAlternateFormatValue.Location = new System.Drawing.Point(160, 4);
            this.cbAlternateFormatValue.Name = "cbAlternateFormatValue";
            this.cbAlternateFormatValue.Size = new System.Drawing.Size(132, 21);
            this.cbAlternateFormatValue.TabIndex = 1;
            this.cbAlternateFormatValue.SelectedIndexChanged += new System.EventHandler(this.cbAlternateFormatValue_SelectedIndexChanged);
            // 
            // cbAlternateFormatFraction
            // 
            this.cbAlternateFormatFraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlternateFormatFraction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlternateFormatFraction.FormattingEnabled = true;
            this.cbAlternateFormatFraction.Items.AddRange(new object[] {
            "",
            ".2",
            ".23"});
            this.cbAlternateFormatFraction.Location = new System.Drawing.Point(298, 4);
            this.cbAlternateFormatFraction.Name = "cbAlternateFormatFraction";
            this.cbAlternateFormatFraction.Size = new System.Drawing.Size(132, 21);
            this.cbAlternateFormatFraction.TabIndex = 2;
            this.cbAlternateFormatFraction.SelectedIndexChanged += new System.EventHandler(this.cbAlternateFormatFraction_SelectedIndexChanged);
            // 
            // RivaTunerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RivaTunerSettings";
            this.Size = new System.Drawing.Size(459, 855);
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
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharacters)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox chkOneLine;
        private System.Windows.Forms.CheckBox chkShowGameName;
        private System.Windows.Forms.CheckBox chkShowFinished;
        private System.Windows.Forms.CheckBox chkShowCategoryName;
        private System.Windows.Forms.CheckBox chkShowAttempt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCharacters;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTimingMethod;
        private System.Windows.Forms.ComboBox cbTimerFormatValue;
        private System.Windows.Forms.ComboBox cbTimerFormatFraction;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAlternateFormatValue;
        private System.Windows.Forms.ComboBox cbAlternateFormatFraction;
    }
}
