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
            this.LsvSheets = new System.Windows.Forms.ListView();
            this.SheetNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SheetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CbxDependent = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCopies)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbSearch
            // 
            this.TxbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSearch.Location = new System.Drawing.Point(74, 93);
            this.TxbSearch.Multiline = true;
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(468, 25);
            this.TxbSearch.TabIndex = 1;
            this.TxbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.Transparent;
            this.LblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.Location = new System.Drawing.Point(16, 99);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(52, 19);
            this.LblSearch.TabIndex = 2;
            this.LblSearch.Text = "Search:";
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.BackColor = System.Drawing.Color.Transparent;
            this.BtnDuplicate.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDuplicate.FlatAppearance.BorderSize = 0;
            this.BtnDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDuplicate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuplicate.ForeColor = System.Drawing.Color.White;
            this.BtnDuplicate.Location = new System.Drawing.Point(0, 0);
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(150, 60);
            this.BtnDuplicate.TabIndex = 3;
            this.BtnDuplicate.Text = "Duplicate";
            this.BtnDuplicate.UseVisualStyleBackColor = false;
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.BackColor = System.Drawing.Color.Transparent;
            this.LblNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LblNum.Location = new System.Drawing.Point(17, 48);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(119, 17);
            this.LblNum.TabIndex = 4;
            this.LblNum.Text = "Number of Copies:";
            // 
            // NumOfCopies
            // 
            this.NumOfCopies.AllowDrop = true;
            this.NumOfCopies.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumOfCopies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumOfCopies.Location = new System.Drawing.Point(142, 49);
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
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(414, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 60);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LsvSheets
            // 
            this.LsvSheets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvSheets.BackColor = System.Drawing.Color.White;
            this.LsvSheets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvSheets.CheckBoxes = true;
            this.LsvSheets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SheetNumber,
            this.SheetName});
            this.LsvSheets.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvSheets.FullRowSelect = true;
            this.LsvSheets.GridLines = true;
            this.LsvSheets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LsvSheets.HideSelection = false;
            this.LsvSheets.Location = new System.Drawing.Point(20, 135);
            this.LsvSheets.MultiSelect = false;
            this.LsvSheets.Name = "LsvSheets";
            this.LsvSheets.Size = new System.Drawing.Size(524, 396);
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
            this.SheetName.Width = 399;
            // 
            // CbxDependent
            // 
            this.CbxDependent.AutoSize = true;
            this.CbxDependent.BackColor = System.Drawing.Color.Transparent;
            this.CbxDependent.Checked = true;
            this.CbxDependent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxDependent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxDependent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CbxDependent.Location = new System.Drawing.Point(254, 49);
            this.CbxDependent.Name = "CbxDependent";
            this.CbxDependent.Size = new System.Drawing.Size(288, 21);
            this.CbxDependent.TabIndex = 8;
            this.CbxDependent.Text = "Duplicate Dependent Views as a Dependent?";
            this.CbxDependent.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnDuplicate);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 60);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.LblLineSeparator);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 50);
            this.panel2.TabIndex = 10;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.CbxDependent);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.NumOfCopies);
            this.panel3.Controls.Add(this.LblNum);
            this.panel3.Controls.Add(this.LblSearch);
            this.panel3.Controls.Add(this.TxbSearch);
            this.panel3.Controls.Add(this.LsvSheets);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 551);
            this.panel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Sheet";
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
            this.LblLineSeparator.Size = new System.Drawing.Size(540, 2);
            this.LblLineSeparator.TabIndex = 33;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(564, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 1200);
            this.MinimumSize = new System.Drawing.Size(580, 700);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheet Duplicator";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCopies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxbSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Button BtnDuplicate;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.NumericUpDown NumOfCopies;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListView LsvSheets;
        private System.Windows.Forms.ColumnHeader SheetNumber;
        private System.Windows.Forms.ColumnHeader SheetName;
        private System.Windows.Forms.CheckBox CbxDependent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblLineSeparator;
    }
}