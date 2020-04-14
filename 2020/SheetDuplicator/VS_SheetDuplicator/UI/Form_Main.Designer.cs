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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.TxbSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.BtnDuplicate = new System.Windows.Forms.Button();
            this.LblNum = new System.Windows.Forms.Label();
            this.NumOfCopies = new System.Windows.Forms.NumericUpDown();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LsvSheets = new System.Windows.Forms.ListView();
            this.SheetNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SheetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbxDependent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCopies)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbSearch
            // 
            this.TxbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSearch.Location = new System.Drawing.Point(65, 28);
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(350, 20);
            this.TxbSearch.TabIndex = 1;
            this.TxbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(10, 30);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(44, 13);
            this.LblSearch.TabIndex = 2;
            this.LblSearch.Text = "Search:";
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDuplicate.Location = new System.Drawing.Point(20, 450);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(150, 45);
            this.BtnDuplicate.TabIndex = 3;
            this.BtnDuplicate.Text = "Duplicate";
            this.BtnDuplicate.UseVisualStyleBackColor = true;
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Location = new System.Drawing.Point(17, 25);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(94, 13);
            this.LblNum.TabIndex = 4;
            this.LblNum.Text = "Number of Copies:";
            // 
            // NumOfCopies
            // 
            this.NumOfCopies.AllowDrop = true;
            this.NumOfCopies.Location = new System.Drawing.Point(117, 22);
            this.NumOfCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfCopies.Name = "NumOfCopies";
            this.NumOfCopies.Size = new System.Drawing.Size(40, 20);
            this.NumOfCopies.TabIndex = 5;
            this.NumOfCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(335, 450);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(90, 45);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LsvSheets);
            this.groupBox1.Controls.Add(this.TxbSearch);
            this.groupBox1.Controls.Add(this.LblSearch);
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 370);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Sheet";
            // 
            // LsvSheets
            // 
            this.LsvSheets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvSheets.CheckBoxes = true;
            this.LsvSheets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SheetNumber,
            this.SheetName});
            this.LsvSheets.FullRowSelect = true;
            this.LsvSheets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvSheets.Location = new System.Drawing.Point(10, 75);
            this.LsvSheets.MultiSelect = false;
            this.LsvSheets.Name = "LsvSheets";
            this.LsvSheets.Size = new System.Drawing.Size(405, 285);
            this.LsvSheets.TabIndex = 6;
            this.LsvSheets.UseCompatibleStateImageBehavior = false;
            this.LsvSheets.View = System.Windows.Forms.View.Details;
            this.LsvSheets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LsvSheets_ItemCheck);
            this.LsvSheets.SelectedIndexChanged += new System.EventHandler(this.LsvSheets_SelectedIndexChanged);
            // 
            // SheetNumber
            // 
            this.SheetNumber.Text = "Sheet Number";
            this.SheetNumber.Width = 120;
            // 
            // SheetName
            // 
            this.SheetName.Text = "Sheet Name";
            this.SheetName.Width = 500;
            // 
            // CbxDependent
            // 
            this.CbxDependent.AutoSize = true;
            this.CbxDependent.Checked = true;
            this.CbxDependent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxDependent.Location = new System.Drawing.Point(190, 25);
            this.CbxDependent.Name = "CbxDependent";
            this.CbxDependent.Size = new System.Drawing.Size(243, 17);
            this.CbxDependent.TabIndex = 8;
            this.CbxDependent.Text = "Duplicate Dependent Views as a Dependent?";
            this.CbxDependent.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(444, 511);
            this.Controls.Add(this.CbxDependent);
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.NumOfCopies);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnDuplicate);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 1200);
            this.MinimumSize = new System.Drawing.Size(460, 550);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheet Duplicator";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCopies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxbSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Button BtnDuplicate;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.NumericUpDown NumOfCopies;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView LsvSheets;
        private System.Windows.Forms.ColumnHeader SheetNumber;
        private System.Windows.Forms.ColumnHeader SheetName;
        private System.Windows.Forms.CheckBox CbxDependent;
    }
}