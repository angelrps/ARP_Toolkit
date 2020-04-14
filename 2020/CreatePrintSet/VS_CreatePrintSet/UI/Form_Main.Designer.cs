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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.TxbSearch = new System.Windows.Forms.TextBox();
            this.LsvSheets = new System.Windows.Forms.ListView();
            this.SheetNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SheetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxbSetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnNone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(20, 420);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(250, 45);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Sheet Set";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(460, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxbSearch
            // 
            this.TxbSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxbSearch.Location = new System.Drawing.Point(120, 77);
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(251, 20);
            this.TxbSearch.TabIndex = 3;
            this.TxbSearch.Text = "Type to filter...";
            this.TxbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            this.TxbSearch.Enter += new System.EventHandler(this.TxbSearch_Enter);
            this.TxbSearch.Leave += new System.EventHandler(this.TxbSearch_Leave);
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
            this.LsvSheets.Location = new System.Drawing.Point(20, 110);
            this.LsvSheets.Name = "LsvSheets";
            this.LsvSheets.Size = new System.Drawing.Size(600, 290);
            this.LsvSheets.TabIndex = 4;
            this.LsvSheets.UseCompatibleStateImageBehavior = false;
            this.LsvSheets.View = System.Windows.Forms.View.Details;
            // 
            // SheetNumber
            // 
            this.SheetNumber.Text = "Sheet Number";
            this.SheetNumber.Width = 190;
            // 
            // SheetName
            // 
            this.SheetName.Text = "Sheet Name";
            this.SheetName.Width = 500;
            // 
            // TxbSetName
            // 
            this.TxbSetName.Location = new System.Drawing.Point(120, 15);
            this.TxbSetName.Name = "TxbSetName";
            this.TxbSetName.Size = new System.Drawing.Size(251, 20);
            this.TxbSetName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sheet Set Name:";
            // 
            // BtnAll
            // 
            this.BtnAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAll.Location = new System.Drawing.Point(415, 30);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(90, 25);
            this.BtnAll.TabIndex = 7;
            this.BtnAll.Text = "Check All";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnNone
            // 
            this.BtnNone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNone.Location = new System.Drawing.Point(520, 30);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(90, 25);
            this.BtnNone.TabIndex = 8;
            this.BtnNone.Text = "Check None";
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter Sheet Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnNone);
            this.groupBox1.Controls.Add(this.BtnAll);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(10, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 433);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(639, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbSetName);
            this.Controls.Add(this.LsvSheets);
            this.Controls.Add(this.TxbSearch);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 530);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Print Set From Selected Sheets";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox TxbSearch;
        private System.Windows.Forms.ListView LsvSheets;
        private System.Windows.Forms.ColumnHeader SheetNumber;
        private System.Windows.Forms.ColumnHeader SheetName;
        private System.Windows.Forms.TextBox TxbSetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnNone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}