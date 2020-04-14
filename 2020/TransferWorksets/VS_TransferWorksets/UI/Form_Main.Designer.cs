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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxOpenDocs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LsvWorksets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCreate.Location = new System.Drawing.Point(15, 330);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(130, 45);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create Worksets";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(190, 330);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 45);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAll.Location = new System.Drawing.Point(335, 70);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(80, 30);
            this.BtnAll.TabIndex = 5;
            this.BtnAll.Text = "Check All";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnNone
            // 
            this.BtnNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNone.Location = new System.Drawing.Point(335, 115);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(80, 30);
            this.BtnNone.TabIndex = 6;
            this.BtnNone.Text = "Check None";
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Copy from:";
            // 
            // CbxOpenDocs
            // 
            this.CbxOpenDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxOpenDocs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxOpenDocs.FormattingEnabled = true;
            this.CbxOpenDocs.Location = new System.Drawing.Point(80, 35);
            this.CbxOpenDocs.Name = "CbxOpenDocs";
            this.CbxOpenDocs.Size = new System.Drawing.Size(240, 21);
            this.CbxOpenDocs.TabIndex = 8;
            this.CbxOpenDocs.SelectedIndexChanged += new System.EventHandler(this.CbxOpenDocs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(only workshared projects are displayed)";
            // 
            // LsvWorksets
            // 
            this.LsvWorksets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvWorksets.CheckBoxes = true;
            this.LsvWorksets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LsvWorksets.FullRowSelect = true;
            this.LsvWorksets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvWorksets.Location = new System.Drawing.Point(15, 70);
            this.LsvWorksets.Name = "LsvWorksets";
            this.LsvWorksets.Size = new System.Drawing.Size(305, 244);
            this.LsvWorksets.TabIndex = 11;
            this.LsvWorksets.UseCompatibleStateImageBehavior = false;
            this.LsvWorksets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 400;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(429, 391);
            this.Controls.Add(this.LsvWorksets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxOpenDocs);
            this.Controls.Add(this.BtnNone);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 800);
            this.MinimumSize = new System.Drawing.Size(445, 430);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Worksets";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxOpenDocs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LsvWorksets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}