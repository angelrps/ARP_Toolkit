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
            this.GbxSharedParameters = new System.Windows.Forms.GroupBox();
            this.BtnExpandAll = new System.Windows.Forms.Button();
            this.BtnCollapseAll = new System.Windows.Forms.Button();
            this.RbtByType = new System.Windows.Forms.RadioButton();
            this.RbtByGroup = new System.Windows.Forms.RadioButton();
            this.BtnNoneParam = new System.Windows.Forms.Button();
            this.BtnAllParam = new System.Windows.Forms.Button();
            this.TreeViewParameters = new System.Windows.Forms.TreeView();
            this.TxbFilterParam = new System.Windows.Forms.TextBox();
            this.LblFilterParam = new System.Windows.Forms.Label();
            this.GbxParameterData = new System.Windows.Forms.GroupBox();
            this.RbtInstance = new System.Windows.Forms.RadioButton();
            this.RbtType = new System.Windows.Forms.RadioButton();
            this.CbxGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbxCategories = new System.Windows.Forms.GroupBox();
            this.BtnNoneCat = new System.Windows.Forms.Button();
            this.BtnAllCat = new System.Windows.Forms.Button();
            this.TreeViewCategories = new System.Windows.Forms.TreeView();
            this.TxbFilterCat = new System.Windows.Forms.TextBox();
            this.LblFilterCat = new System.Windows.Forms.Label();
            this.TooltipExpandAll = new System.Windows.Forms.ToolTip(this.components);
            this.TooltipCollapseAll = new System.Windows.Forms.ToolTip(this.components);
            this.GbxSharedParameters.SuspendLayout();
            this.GbxParameterData.SuspendLayout();
            this.GbxCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(12, 12);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 25);
            this.BtnBrowse.TabIndex = 0;
            this.BtnBrowse.Text = "Browse...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(530, 535);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(90, 45);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddParameters
            // 
            this.BtnAddParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddParameters.Location = new System.Drawing.Point(370, 535);
            this.BtnAddParameters.Name = "BtnAddParameters";
            this.BtnAddParameters.Size = new System.Drawing.Size(150, 45);
            this.BtnAddParameters.TabIndex = 2;
            this.BtnAddParameters.Text = "Add Parameters";
            this.BtnAddParameters.UseVisualStyleBackColor = true;
            this.BtnAddParameters.Click += new System.EventHandler(this.BtnAddParameters_Click);
            // 
            // LblSharedParameterFile
            // 
            this.LblSharedParameterFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSharedParameterFile.Location = new System.Drawing.Point(94, 12);
            this.LblSharedParameterFile.Name = "LblSharedParameterFile";
            this.LblSharedParameterFile.Size = new System.Drawing.Size(528, 32);
            this.LblSharedParameterFile.TabIndex = 3;
            this.LblSharedParameterFile.Text = "<Shared Parameter File>";
            // 
            // GbxSharedParameters
            // 
            this.GbxSharedParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxSharedParameters.Controls.Add(this.BtnExpandAll);
            this.GbxSharedParameters.Controls.Add(this.BtnCollapseAll);
            this.GbxSharedParameters.Controls.Add(this.RbtByType);
            this.GbxSharedParameters.Controls.Add(this.RbtByGroup);
            this.GbxSharedParameters.Controls.Add(this.BtnNoneParam);
            this.GbxSharedParameters.Controls.Add(this.BtnAllParam);
            this.GbxSharedParameters.Controls.Add(this.TreeViewParameters);
            this.GbxSharedParameters.Controls.Add(this.TxbFilterParam);
            this.GbxSharedParameters.Controls.Add(this.LblFilterParam);
            this.GbxSharedParameters.Location = new System.Drawing.Point(10, 50);
            this.GbxSharedParameters.Name = "GbxSharedParameters";
            this.GbxSharedParameters.Size = new System.Drawing.Size(350, 445);
            this.GbxSharedParameters.TabIndex = 4;
            this.GbxSharedParameters.TabStop = false;
            this.GbxSharedParameters.Text = "Shared Parameters";
            // 
            // BtnExpandAll
            // 
            this.BtnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExpandAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnExpandAll.Location = new System.Drawing.Point(284, 22);
            this.BtnExpandAll.Name = "BtnExpandAll";
            this.BtnExpandAll.Size = new System.Drawing.Size(25, 25);
            this.BtnExpandAll.TabIndex = 27;
            this.BtnExpandAll.Text = "+";
            this.TooltipExpandAll.SetToolTip(this.BtnExpandAll, "Expand All");
            this.BtnExpandAll.UseVisualStyleBackColor = true;
            this.BtnExpandAll.Click += new System.EventHandler(this.BtnExpandAll_Click);
            // 
            // BtnCollapseAll
            // 
            this.BtnCollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCollapseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BtnCollapseAll.Location = new System.Drawing.Point(315, 22);
            this.BtnCollapseAll.Name = "BtnCollapseAll";
            this.BtnCollapseAll.Size = new System.Drawing.Size(25, 25);
            this.BtnCollapseAll.TabIndex = 26;
            this.BtnCollapseAll.Text = "-";
            this.TooltipCollapseAll.SetToolTip(this.BtnCollapseAll, "Collapse All");
            this.BtnCollapseAll.UseVisualStyleBackColor = true;
            this.BtnCollapseAll.Click += new System.EventHandler(this.BtnCollapseAll_Click);
            // 
            // RbtByType
            // 
            this.RbtByType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtByType.AutoSize = true;
            this.RbtByType.Location = new System.Drawing.Point(10, 410);
            this.RbtByType.Name = "RbtByType";
            this.RbtByType.Size = new System.Drawing.Size(115, 17);
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
            this.RbtByGroup.Location = new System.Drawing.Point(10, 385);
            this.RbtByGroup.Name = "RbtByGroup";
            this.RbtByGroup.Size = new System.Drawing.Size(120, 17);
            this.RbtByGroup.TabIndex = 13;
            this.RbtByGroup.TabStop = true;
            this.RbtByGroup.Text = "By Parameter Group";
            this.RbtByGroup.UseVisualStyleBackColor = true;
            this.RbtByGroup.CheckedChanged += new System.EventHandler(this.RbtByGroup_CheckedChanged);
            // 
            // BtnNoneParam
            // 
            this.BtnNoneParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNoneParam.Location = new System.Drawing.Point(250, 410);
            this.BtnNoneParam.Name = "BtnNoneParam";
            this.BtnNoneParam.Size = new System.Drawing.Size(90, 25);
            this.BtnNoneParam.TabIndex = 24;
            this.BtnNoneParam.Text = "Check None";
            this.BtnNoneParam.UseVisualStyleBackColor = true;
            this.BtnNoneParam.Click += new System.EventHandler(this.BtnNoneParam_Click);
            // 
            // BtnAllParam
            // 
            this.BtnAllParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllParam.Location = new System.Drawing.Point(250, 380);
            this.BtnAllParam.Name = "BtnAllParam";
            this.BtnAllParam.Size = new System.Drawing.Size(90, 25);
            this.BtnAllParam.TabIndex = 23;
            this.BtnAllParam.Text = "Check All";
            this.BtnAllParam.UseVisualStyleBackColor = true;
            this.BtnAllParam.Click += new System.EventHandler(this.BtnAllParam_Click);
            // 
            // TreeViewParameters
            // 
            this.TreeViewParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewParameters.CheckBoxes = true;
            this.TreeViewParameters.Location = new System.Drawing.Point(10, 55);
            this.TreeViewParameters.Name = "TreeViewParameters";
            this.TreeViewParameters.Size = new System.Drawing.Size(330, 315);
            this.TreeViewParameters.TabIndex = 8;
            this.TreeViewParameters.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewParameters_AfterCheck);
            // 
            // TxbFilterParam
            // 
            this.TxbFilterParam.Location = new System.Drawing.Point(45, 25);
            this.TxbFilterParam.Name = "TxbFilterParam";
            this.TxbFilterParam.Size = new System.Drawing.Size(195, 20);
            this.TxbFilterParam.TabIndex = 7;
            this.TxbFilterParam.TextChanged += new System.EventHandler(this.TxbFilterParam_TextChanged);
            // 
            // LblFilterParam
            // 
            this.LblFilterParam.AutoSize = true;
            this.LblFilterParam.Location = new System.Drawing.Point(5, 30);
            this.LblFilterParam.Name = "LblFilterParam";
            this.LblFilterParam.Size = new System.Drawing.Size(32, 13);
            this.LblFilterParam.TabIndex = 6;
            this.LblFilterParam.Text = "Filter:";
            // 
            // GbxParameterData
            // 
            this.GbxParameterData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GbxParameterData.Controls.Add(this.RbtInstance);
            this.GbxParameterData.Controls.Add(this.RbtType);
            this.GbxParameterData.Controls.Add(this.CbxGroup);
            this.GbxParameterData.Controls.Add(this.label1);
            this.GbxParameterData.Location = new System.Drawing.Point(10, 500);
            this.GbxParameterData.Name = "GbxParameterData";
            this.GbxParameterData.Size = new System.Drawing.Size(350, 81);
            this.GbxParameterData.TabIndex = 5;
            this.GbxParameterData.TabStop = false;
            this.GbxParameterData.Text = "Parameter Data";
            // 
            // RbtInstance
            // 
            this.RbtInstance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtInstance.AutoSize = true;
            this.RbtInstance.Location = new System.Drawing.Point(275, 45);
            this.RbtInstance.Name = "RbtInstance";
            this.RbtInstance.Size = new System.Drawing.Size(66, 17);
            this.RbtInstance.TabIndex = 12;
            this.RbtInstance.TabStop = true;
            this.RbtInstance.Text = "Instance";
            this.RbtInstance.UseVisualStyleBackColor = true;
            // 
            // RbtType
            // 
            this.RbtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RbtType.AutoSize = true;
            this.RbtType.Checked = true;
            this.RbtType.Location = new System.Drawing.Point(275, 20);
            this.RbtType.Name = "RbtType";
            this.RbtType.Size = new System.Drawing.Size(49, 17);
            this.RbtType.TabIndex = 11;
            this.RbtType.TabStop = true;
            this.RbtType.Text = "Type";
            this.RbtType.UseVisualStyleBackColor = true;
            // 
            // CbxGroup
            // 
            this.CbxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGroup.FormattingEnabled = true;
            this.CbxGroup.Location = new System.Drawing.Point(10, 45);
            this.CbxGroup.Name = "CbxGroup";
            this.CbxGroup.Size = new System.Drawing.Size(245, 21);
            this.CbxGroup.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Group parameter under:";
            // 
            // GbxCategories
            // 
            this.GbxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCategories.Controls.Add(this.BtnNoneCat);
            this.GbxCategories.Controls.Add(this.BtnAllCat);
            this.GbxCategories.Controls.Add(this.TreeViewCategories);
            this.GbxCategories.Controls.Add(this.TxbFilterCat);
            this.GbxCategories.Controls.Add(this.LblFilterCat);
            this.GbxCategories.Location = new System.Drawing.Point(370, 50);
            this.GbxCategories.Name = "GbxCategories";
            this.GbxCategories.Size = new System.Drawing.Size(250, 445);
            this.GbxCategories.TabIndex = 5;
            this.GbxCategories.TabStop = false;
            this.GbxCategories.Text = "Categories";
            // 
            // BtnNoneCat
            // 
            this.BtnNoneCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNoneCat.Location = new System.Drawing.Point(150, 410);
            this.BtnNoneCat.Name = "BtnNoneCat";
            this.BtnNoneCat.Size = new System.Drawing.Size(90, 25);
            this.BtnNoneCat.TabIndex = 26;
            this.BtnNoneCat.Text = "Check None";
            this.BtnNoneCat.UseVisualStyleBackColor = true;
            this.BtnNoneCat.Click += new System.EventHandler(this.BtnNoneCat_Click);
            // 
            // BtnAllCat
            // 
            this.BtnAllCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAllCat.Location = new System.Drawing.Point(150, 380);
            this.BtnAllCat.Name = "BtnAllCat";
            this.BtnAllCat.Size = new System.Drawing.Size(90, 25);
            this.BtnAllCat.TabIndex = 25;
            this.BtnAllCat.Text = "Check All";
            this.BtnAllCat.UseVisualStyleBackColor = true;
            this.BtnAllCat.Click += new System.EventHandler(this.BtnAllCat_Click);
            // 
            // TreeViewCategories
            // 
            this.TreeViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewCategories.CheckBoxes = true;
            this.TreeViewCategories.Location = new System.Drawing.Point(10, 55);
            this.TreeViewCategories.Name = "TreeViewCategories";
            this.TreeViewCategories.Size = new System.Drawing.Size(230, 315);
            this.TreeViewCategories.TabIndex = 25;
            // 
            // TxbFilterCat
            // 
            this.TxbFilterCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbFilterCat.Location = new System.Drawing.Point(45, 25);
            this.TxbFilterCat.Name = "TxbFilterCat";
            this.TxbFilterCat.Size = new System.Drawing.Size(195, 20);
            this.TxbFilterCat.TabIndex = 8;
            this.TxbFilterCat.TextChanged += new System.EventHandler(this.TxbFilterCat_TextChanged);
            // 
            // LblFilterCat
            // 
            this.LblFilterCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFilterCat.AutoSize = true;
            this.LblFilterCat.Location = new System.Drawing.Point(5, 30);
            this.LblFilterCat.Name = "LblFilterCat";
            this.LblFilterCat.Size = new System.Drawing.Size(32, 13);
            this.LblFilterCat.TabIndex = 7;
            this.LblFilterCat.Text = "Filter:";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(634, 591);
            this.Controls.Add(this.GbxParameterData);
            this.Controls.Add(this.GbxCategories);
            this.Controls.Add(this.GbxSharedParameters);
            this.Controls.Add(this.LblSharedParameterFile);
            this.Controls.Add(this.BtnAddParameters);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(650, 630);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameter Loader";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.GbxSharedParameters.ResumeLayout(false);
            this.GbxSharedParameters.PerformLayout();
            this.GbxParameterData.ResumeLayout(false);
            this.GbxParameterData.PerformLayout();
            this.GbxCategories.ResumeLayout(false);
            this.GbxCategories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddParameters;
        private System.Windows.Forms.Label LblSharedParameterFile;
        private System.Windows.Forms.GroupBox GbxSharedParameters;
        private System.Windows.Forms.GroupBox GbxParameterData;
        private System.Windows.Forms.GroupBox GbxCategories;
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
        private System.Windows.Forms.ToolTip TooltipExpandAll;
        private System.Windows.Forms.ToolTip TooltipCollapseAll;
    }
}