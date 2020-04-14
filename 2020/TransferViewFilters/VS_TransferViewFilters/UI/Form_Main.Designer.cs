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
            this.TxbSearchFilters = new System.Windows.Forms.TextBox();
            this.TxbSearchTemplates = new System.Windows.Forms.TextBox();
            this.LsvTemplates = new System.Windows.Forms.ListView();
            this.Templates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvFilters = new System.Windows.Forms.ListView();
            this.ViewFilters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblSearchFilters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbSearchFilters
            // 
            this.TxbSearchFilters.Location = new System.Drawing.Point(105, 35);
            this.TxbSearchFilters.Name = "TxbSearchFilters";
            this.TxbSearchFilters.Size = new System.Drawing.Size(200, 20);
            this.TxbSearchFilters.TabIndex = 1;
            this.TxbSearchFilters.TextChanged += new System.EventHandler(this.TxbSearchFilters_TextChanged);
            // 
            // TxbSearchTemplates
            // 
            this.TxbSearchTemplates.Location = new System.Drawing.Point(115, 35);
            this.TxbSearchTemplates.Name = "TxbSearchTemplates";
            this.TxbSearchTemplates.Size = new System.Drawing.Size(190, 20);
            this.TxbSearchTemplates.TabIndex = 0;
            this.TxbSearchTemplates.TextChanged += new System.EventHandler(this.TxbSearchTemplates_TextChanged);
            // 
            // LsvTemplates
            // 
            this.LsvTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LsvTemplates.CheckBoxes = true;
            this.LsvTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Templates});
            this.LsvTemplates.FullRowSelect = true;
            this.LsvTemplates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvTemplates.Location = new System.Drawing.Point(15, 65);
            this.LsvTemplates.Name = "LsvTemplates";
            this.LsvTemplates.Size = new System.Drawing.Size(290, 384);
            this.LsvTemplates.TabIndex = 0;
            this.LsvTemplates.UseCompatibleStateImageBehavior = false;
            this.LsvTemplates.View = System.Windows.Forms.View.Details;
            // 
            // Templates
            // 
            this.Templates.Text = "View Templates";
            this.Templates.Width = 280;
            // 
            // LsvFilters
            // 
            this.LsvFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LsvFilters.CheckBoxes = true;
            this.LsvFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ViewFilters});
            this.LsvFilters.FullRowSelect = true;
            this.LsvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvFilters.Location = new System.Drawing.Point(15, 65);
            this.LsvFilters.Name = "LsvFilters";
            this.LsvFilters.Size = new System.Drawing.Size(290, 384);
            this.LsvFilters.TabIndex = 0;
            this.LsvFilters.UseCompatibleStateImageBehavior = false;
            this.LsvFilters.View = System.Windows.Forms.View.Details;
            this.LsvFilters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LsvFilters_ItemCheck);
            // 
            // ViewFilters
            // 
            this.ViewFilters.Text = "View Filters grouped by View Template";
            this.ViewFilters.Width = 280;
            // 
            // LblSearchFilters
            // 
            this.LblSearchFilters.AutoSize = true;
            this.LblSearchFilters.Location = new System.Drawing.Point(15, 40);
            this.LblSearchFilters.Name = "LblSearchFilters";
            this.LblSearchFilters.Size = new System.Drawing.Size(44, 13);
            this.LblSearchFilters.TabIndex = 2;
            this.LblSearchFilters.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTransfer.Location = new System.Drawing.Point(360, 500);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(190, 45);
            this.BtnTransfer.TabIndex = 4;
            this.BtnTransfer.Text = "Transfer Filters";
            this.BtnTransfer.UseVisualStyleBackColor = true;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(570, 500);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 45);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.LsvFilters);
            this.groupBox1.Controls.Add(this.TxbSearchFilters);
            this.groupBox1.Controls.Add(this.LblSearchFilters);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 464);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Used Filters grouped by View Template";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.LsvTemplates);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxbSearchTemplates);
            this.groupBox2.Location = new System.Drawing.Point(345, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 464);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Templates";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(674, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnTransfer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(690, 1200);
            this.MinimumSize = new System.Drawing.Size(690, 600);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer View Filters";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxbSearchFilters;
        private System.Windows.Forms.TextBox TxbSearchTemplates;
        private System.Windows.Forms.ListView LsvTemplates;
        private System.Windows.Forms.ColumnHeader Templates;
        private System.Windows.Forms.ListView LsvFilters;
        private System.Windows.Forms.ColumnHeader ViewFilters;
        private System.Windows.Forms.Label LblSearchFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTransfer;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}