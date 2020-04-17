namespace UI
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddParameters = new System.Windows.Forms.Button();
            this.LblSharedParameterFile = new System.Windows.Forms.Label();
            this.BtnExpandAll = new System.Windows.Forms.Button();
            this.BtnCollapseAll = new System.Windows.Forms.Button();
            this.RbtByType = new System.Windows.Forms.RadioButton();
            this.RbtByGroup = new System.Windows.Forms.RadioButton();
            this.BtnNoneParam = new System.Windows.Forms.Button();
            this.BtnAllParam = new System.Windows.Forms.Button();
            this.TreeViewParameters = new System.Windows.Forms.TreeView();
            this.TxbFilterParam = new System.Windows.Forms.TextBox();
            this.LblFilterParam = new System.Windows.Forms.Label();
            this.RbtInstance = new System.Windows.Forms.RadioButton();
            this.RbtType = new System.Windows.Forms.RadioButton();
            this.CbxGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNoneCat = new System.Windows.Forms.Button();
            this.BtnAllCat = new System.Windows.Forms.Button();
            this.TreeViewCategories = new System.Windows.Forms.TreeView();
            this.TxbFilterCat = new System.Windows.Forms.TextBox();
            this.LblFilterCat = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panSharedFile = new System.Windows.Forms.Panel();
            this.PanCategories = new System.Windows.Forms.Panel();
            this.panParamData = new System.Windows.Forms.Panel();
            this.LblSharedParamFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panSharedFile.SuspendLayout();
            this.PanCategories.SuspendLayout();
            this.panParamData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.FlatAppearance.BorderSize = 0;
            this.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("BtnBrowse.Image")));
            this.BtnBrowse.Location = new System.Drawing.Point(20, 50);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(35, 35);
            this.BtnBrowse.TabIndex = 0;
            this.Tooltip.SetToolTip(this.BtnBrowse, "Browse");
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(634, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 78);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddParameters
            // 
            this.BtnAddParameters.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddParameters.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddParameters.FlatAppearance.BorderSize = 0;
            this.BtnAddParameters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnAddParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddParameters.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddParameters.ForeColor = System.Drawing.Color.White;
            this.BtnAddParameters.Location = new System.Drawing.Point(0, 0);
            this.BtnAddParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddParameters.Name = "BtnAddParameters";
            this.BtnAddParameters.Size = new System.Drawing.Size(200, 78);
            this.BtnAddParameters.TabIndex = 2;
            this.BtnAddParameters.Text = "Add Parameters";
            this.BtnAddParameters.UseVisualStyleBackColor = false;
            this.BtnAddParameters.Click += new System.EventHandler(this.BtnAddParameters_Click);
            // 
            // LblSharedParameterFile
            // 
            this.LblSharedParameterFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSharedParameterFile.Location = new System.Drawing.Point(70, 50);
            this.LblSharedParameterFile.Name = "LblSharedParameterFile";
            this.LblSharedParameterFile.Size = new System.Drawing.Size(647, 35);
            this.LblSharedParameterFile.TabIndex = 3;
            this.LblSharedParameterFile.Text = "<Browse to Select a Shared Parameter File>";
            // 
            // BtnExpandAll
            // 
            this.BtnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExpandAll.FlatAppearance.BorderSize = 0;
            this.BtnExpandAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnExpandAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnExpandAll.Image")));
            this.BtnExpandAll.Location = new System.Drawing.Point(360, 100);
            this.BtnExpandAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExpandAll.Name = "BtnExpandAll";
            this.BtnExpandAll.Size = new System.Drawing.Size(48, 35);
            this.BtnExpandAll.TabIndex = 27;
            this.Tooltip.SetToolTip(this.BtnExpandAll, "Expand All");
            this.BtnExpandAll.UseVisualStyleBackColor = true;
            this.BtnExpandAll.Click += new System.EventHandler(this.BtnExpandAll_Click);
            // 
            // BtnCollapseAll
            // 
            this.BtnCollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCollapseAll.FlatAppearance.BorderSize = 0;
            this.BtnCollapseAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnCollapseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCollapseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnCollapseAll.Image")));
            this.BtnCollapseAll.Location = new System.Drawing.Point(360, 135);
            this.BtnCollapseAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCollapseAll.Name = "BtnCollapseAll";
            this.BtnCollapseAll.Size = new System.Drawing.Size(48, 35);
            this.BtnCollapseAll.TabIndex = 26;
            this.Tooltip.SetToolTip(this.BtnCollapseAll, "Collapse All");
            this.BtnCollapseAll.UseVisualStyleBackColor = true;
            this.BtnCollapseAll.Click += new System.EventHandler(this.BtnCollapseAll_Click);
            // 
            // RbtByType
            // 
            this.RbtByType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtByType.AutoSize = true;
            this.RbtByType.Location = new System.Drawing.Point(20, 425);
            this.RbtByType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtByType.Name = "RbtByType";
            this.RbtByType.Size = new System.Drawing.Size(141, 23);
            this.RbtByType.TabIndex = 25;
            this.RbtByType.TabStop = true;
            this.RbtByType.Text = "By Parameter Type";
            this.RbtByType.UseVisualStyleBackColor = true;
            // 
            // RbtByGroup
            // 
            this.RbtByGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtByGroup.AutoSize = true;
            this.RbtByGroup.Checked = true;
            this.RbtByGroup.Location = new System.Drawing.Point(20, 395);
            this.RbtByGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtByGroup.Name = "RbtByGroup";
            this.RbtByGroup.Size = new System.Drawing.Size(152, 23);
            this.RbtByGroup.TabIndex = 13;
            this.RbtByGroup.TabStop = true;
            this.RbtByGroup.Text = "By Parameter Group";
            this.RbtByGroup.UseVisualStyleBackColor = true;
            this.RbtByGroup.CheckedChanged += new System.EventHandler(this.RbtByGroup_CheckedChanged);
            // 
            // BtnNoneParam
            // 
            this.BtnNoneParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNoneParam.FlatAppearance.BorderSize = 0;
            this.BtnNoneParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNoneParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoneParam.Image = ((System.Drawing.Image)(resources.GetObject("BtnNoneParam.Image")));
            this.BtnNoneParam.Location = new System.Drawing.Point(360, 220);
            this.BtnNoneParam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNoneParam.Name = "BtnNoneParam";
            this.BtnNoneParam.Size = new System.Drawing.Size(48, 35);
            this.BtnNoneParam.TabIndex = 24;
            this.Tooltip.SetToolTip(this.BtnNoneParam, "Uncheck All");
            this.BtnNoneParam.UseVisualStyleBackColor = true;
            this.BtnNoneParam.Click += new System.EventHandler(this.BtnNoneParam_Click);
            // 
            // BtnAllParam
            // 
            this.BtnAllParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllParam.FlatAppearance.BorderSize = 0;
            this.BtnAllParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnAllParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllParam.Image = ((System.Drawing.Image)(resources.GetObject("BtnAllParam.Image")));
            this.BtnAllParam.Location = new System.Drawing.Point(360, 185);
            this.BtnAllParam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAllParam.Name = "BtnAllParam";
            this.BtnAllParam.Size = new System.Drawing.Size(48, 35);
            this.BtnAllParam.TabIndex = 23;
            this.Tooltip.SetToolTip(this.BtnAllParam, "Check All");
            this.BtnAllParam.UseVisualStyleBackColor = true;
            this.BtnAllParam.Click += new System.EventHandler(this.BtnAllParam_Click);
            // 
            // TreeViewParameters
            // 
            this.TreeViewParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewParameters.CheckBoxes = true;
            this.TreeViewParameters.Location = new System.Drawing.Point(20, 100);
            this.TreeViewParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TreeViewParameters.Name = "TreeViewParameters";
            this.TreeViewParameters.Size = new System.Drawing.Size(340, 280);
            this.TreeViewParameters.TabIndex = 8;
            this.TreeViewParameters.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewParameters_AfterCheck);
            // 
            // TxbFilterParam
            // 
            this.TxbFilterParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbFilterParam.Location = new System.Drawing.Point(70, 55);
            this.TxbFilterParam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbFilterParam.Name = "TxbFilterParam";
            this.TxbFilterParam.Size = new System.Drawing.Size(290, 25);
            this.TxbFilterParam.TabIndex = 7;
            this.TxbFilterParam.TextChanged += new System.EventHandler(this.TxbFilterParam_TextChanged);
            // 
            // LblFilterParam
            // 
            this.LblFilterParam.AutoSize = true;
            this.LblFilterParam.Location = new System.Drawing.Point(20, 60);
            this.LblFilterParam.Name = "LblFilterParam";
            this.LblFilterParam.Size = new System.Drawing.Size(42, 19);
            this.LblFilterParam.TabIndex = 6;
            this.LblFilterParam.Text = "Filter:";
            // 
            // RbtInstance
            // 
            this.RbtInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtInstance.AutoSize = true;
            this.RbtInstance.Location = new System.Drawing.Point(320, 80);
            this.RbtInstance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtInstance.Name = "RbtInstance";
            this.RbtInstance.Size = new System.Drawing.Size(78, 23);
            this.RbtInstance.TabIndex = 12;
            this.RbtInstance.TabStop = true;
            this.RbtInstance.Text = "Instance";
            this.RbtInstance.UseVisualStyleBackColor = true;
            // 
            // RbtType
            // 
            this.RbtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbtType.AutoSize = true;
            this.RbtType.Checked = true;
            this.RbtType.Location = new System.Drawing.Point(320, 50);
            this.RbtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtType.Name = "RbtType";
            this.RbtType.Size = new System.Drawing.Size(55, 23);
            this.RbtType.TabIndex = 11;
            this.RbtType.TabStop = true;
            this.RbtType.Text = "Type";
            this.RbtType.UseVisualStyleBackColor = true;
            // 
            // CbxGroup
            // 
            this.CbxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxGroup.FormattingEnabled = true;
            this.CbxGroup.Location = new System.Drawing.Point(20, 80);
            this.CbxGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxGroup.Name = "CbxGroup";
            this.CbxGroup.Size = new System.Drawing.Size(270, 25);
            this.CbxGroup.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Group parameter under:";
            // 
            // BtnNoneCat
            // 
            this.BtnNoneCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNoneCat.BackColor = System.Drawing.Color.White;
            this.BtnNoneCat.FlatAppearance.BorderSize = 0;
            this.BtnNoneCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNoneCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoneCat.Image = ((System.Drawing.Image)(resources.GetObject("BtnNoneCat.Image")));
            this.BtnNoneCat.Location = new System.Drawing.Point(260, 135);
            this.BtnNoneCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNoneCat.Name = "BtnNoneCat";
            this.BtnNoneCat.Size = new System.Drawing.Size(48, 35);
            this.BtnNoneCat.TabIndex = 26;
            this.Tooltip.SetToolTip(this.BtnNoneCat, "Uncheck All");
            this.BtnNoneCat.UseVisualStyleBackColor = false;
            this.BtnNoneCat.Click += new System.EventHandler(this.BtnNoneCat_Click);
            // 
            // BtnAllCat
            // 
            this.BtnAllCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllCat.BackColor = System.Drawing.Color.White;
            this.BtnAllCat.FlatAppearance.BorderSize = 0;
            this.BtnAllCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnAllCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllCat.Image = ((System.Drawing.Image)(resources.GetObject("BtnAllCat.Image")));
            this.BtnAllCat.Location = new System.Drawing.Point(260, 100);
            this.BtnAllCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAllCat.Name = "BtnAllCat";
            this.BtnAllCat.Size = new System.Drawing.Size(48, 35);
            this.BtnAllCat.TabIndex = 25;
            this.Tooltip.SetToolTip(this.BtnAllCat, "Check All");
            this.BtnAllCat.UseVisualStyleBackColor = false;
            this.BtnAllCat.Click += new System.EventHandler(this.BtnAllCat_Click);
            // 
            // TreeViewCategories
            // 
            this.TreeViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeViewCategories.CheckBoxes = true;
            this.TreeViewCategories.Location = new System.Drawing.Point(20, 100);
            this.TreeViewCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TreeViewCategories.Name = "TreeViewCategories";
            this.TreeViewCategories.Size = new System.Drawing.Size(240, 270);
            this.TreeViewCategories.TabIndex = 25;
            // 
            // TxbFilterCat
            // 
            this.TxbFilterCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbFilterCat.Location = new System.Drawing.Point(70, 55);
            this.TxbFilterCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbFilterCat.Name = "TxbFilterCat";
            this.TxbFilterCat.Size = new System.Drawing.Size(190, 25);
            this.TxbFilterCat.TabIndex = 8;
            this.TxbFilterCat.TextChanged += new System.EventHandler(this.TxbFilterCat_TextChanged);
            // 
            // LblFilterCat
            // 
            this.LblFilterCat.AutoSize = true;
            this.LblFilterCat.Location = new System.Drawing.Point(20, 60);
            this.LblFilterCat.Name = "LblFilterCat";
            this.LblFilterCat.Size = new System.Drawing.Size(42, 19);
            this.LblFilterCat.TabIndex = 7;
            this.LblFilterCat.Text = "Filter:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnAddParameters);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 823);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 78);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 50);
            this.panel3.TabIndex = 32;
            // 
            // LblLineSeparator
            // 
            this.LblLineSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLineSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLineSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblLineSeparator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLineSeparator.Location = new System.Drawing.Point(10, 40);
            this.LblLineSeparator.Name = "LblLineSeparator";
            this.LblLineSeparator.Size = new System.Drawing.Size(760, 2);
            this.LblLineSeparator.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panSharedFile
            // 
            this.panSharedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSharedFile.BackColor = System.Drawing.Color.White;
            this.panSharedFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSharedFile.Controls.Add(this.LblSharedParamFile);
            this.panSharedFile.Controls.Add(this.BtnBrowse);
            this.panSharedFile.Controls.Add(this.LblSharedParameterFile);
            this.panSharedFile.Location = new System.Drawing.Point(20, 70);
            this.panSharedFile.Name = "panSharedFile";
            this.panSharedFile.Size = new System.Drawing.Size(739, 100);
            this.panSharedFile.TabIndex = 33;
            // 
            // PanCategories
            // 
            this.PanCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanCategories.BackColor = System.Drawing.Color.White;
            this.PanCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanCategories.Controls.Add(this.BtnNoneCat);
            this.PanCategories.Controls.Add(this.label3);
            this.PanCategories.Controls.Add(this.TxbFilterCat);
            this.PanCategories.Controls.Add(this.BtnAllCat);
            this.PanCategories.Controls.Add(this.TreeViewCategories);
            this.PanCategories.Controls.Add(this.LblFilterCat);
            this.PanCategories.Location = new System.Drawing.Point(450, 190);
            this.PanCategories.Name = "PanCategories";
            this.PanCategories.Size = new System.Drawing.Size(310, 470);
            this.PanCategories.TabIndex = 34;
            // 
            // panParamData
            // 
            this.panParamData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panParamData.BackColor = System.Drawing.Color.White;
            this.panParamData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panParamData.Controls.Add(this.label2);
            this.panParamData.Controls.Add(this.RbtInstance);
            this.panParamData.Controls.Add(this.RbtType);
            this.panParamData.Controls.Add(this.label1);
            this.panParamData.Controls.Add(this.CbxGroup);
            this.panParamData.Location = new System.Drawing.Point(20, 680);
            this.panParamData.Name = "panParamData";
            this.panParamData.Size = new System.Drawing.Size(410, 120);
            this.panParamData.TabIndex = 35;
            // 
            // LblSharedParamFile
            // 
            this.LblSharedParamFile.AutoSize = true;
            this.LblSharedParamFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSharedParamFile.Location = new System.Drawing.Point(20, 20);
            this.LblSharedParamFile.Name = "LblSharedParamFile";
            this.LblSharedParamFile.Size = new System.Drawing.Size(162, 19);
            this.LblSharedParamFile.TabIndex = 4;
            this.LblSharedParamFile.Text = "Shared Parameter File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parameter Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categories:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RbtByType);
            this.panel2.Controls.Add(this.BtnExpandAll);
            this.panel2.Controls.Add(this.RbtByGroup);
            this.panel2.Controls.Add(this.BtnCollapseAll);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxbFilterParam);
            this.panel2.Controls.Add(this.LblFilterParam);
            this.panel2.Controls.Add(this.TreeViewParameters);
            this.panel2.Controls.Add(this.BtnNoneParam);
            this.panel2.Controls.Add(this.BtnAllParam);
            this.panel2.Location = new System.Drawing.Point(20, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 470);
            this.panel2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Shared Parameters:";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(784, 901);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panParamData);
            this.Controls.Add(this.PanCategories);
            this.Controls.Add(this.panSharedFile);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 940);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameter Loader";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panSharedFile.ResumeLayout(false);
            this.panSharedFile.PerformLayout();
            this.PanCategories.ResumeLayout(false);
            this.PanCategories.PerformLayout();
            this.panParamData.ResumeLayout(false);
            this.panParamData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddParameters;
        private System.Windows.Forms.Label LblSharedParameterFile;
        private System.Windows.Forms.TextBox TxbFilterParam;
        private System.Windows.Forms.Label LblFilterParam;
        private System.Windows.Forms.Label LblFilterCat;
        private System.Windows.Forms.TextBox TxbFilterCat;
        private System.Windows.Forms.RadioButton RbtInstance;
        private System.Windows.Forms.RadioButton RbtType;
        private System.Windows.Forms.ComboBox CbxGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNoneParam;
        private System.Windows.Forms.Button BtnAllParam;
        private System.Windows.Forms.TreeView TreeViewParameters;
        private System.Windows.Forms.TreeView TreeViewCategories;
        private System.Windows.Forms.RadioButton RbtByType;
        private System.Windows.Forms.RadioButton RbtByGroup;
        private System.Windows.Forms.Button BtnNoneCat;
        private System.Windows.Forms.Button BtnAllCat;
        private System.Windows.Forms.Button BtnExpandAll;
        private System.Windows.Forms.Button BtnCollapseAll;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panSharedFile;
        private System.Windows.Forms.Label LblSharedParamFile;
        private System.Windows.Forms.Panel PanCategories;
        private System.Windows.Forms.Panel panParamData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}