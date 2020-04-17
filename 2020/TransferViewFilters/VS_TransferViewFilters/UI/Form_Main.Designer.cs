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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbSearchFilters
            // 
            this.TxbSearchFilters.BackColor = System.Drawing.Color.White;
            this.TxbSearchFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSearchFilters.Location = new System.Drawing.Point(80, 55);
            this.TxbSearchFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbSearchFilters.Name = "TxbSearchFilters";
            this.TxbSearchFilters.Size = new System.Drawing.Size(280, 25);
            this.TxbSearchFilters.TabIndex = 1;
            this.TxbSearchFilters.TextChanged += new System.EventHandler(this.TxbSearchFilters_TextChanged);
            // 
            // TxbSearchTemplates
            // 
            this.TxbSearchTemplates.BackColor = System.Drawing.Color.White;
            this.TxbSearchTemplates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSearchTemplates.Location = new System.Drawing.Point(80, 55);
            this.TxbSearchTemplates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbSearchTemplates.Name = "TxbSearchTemplates";
            this.TxbSearchTemplates.Size = new System.Drawing.Size(280, 25);
            this.TxbSearchTemplates.TabIndex = 0;
            this.TxbSearchTemplates.TextChanged += new System.EventHandler(this.TxbSearchTemplates_TextChanged);
            // 
            // LsvTemplates
            // 
            this.LsvTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LsvTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvTemplates.CheckBoxes = true;
            this.LsvTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Templates});
            this.LsvTemplates.FullRowSelect = true;
            this.LsvTemplates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvTemplates.HideSelection = false;
            this.LsvTemplates.Location = new System.Drawing.Point(20, 100);
            this.LsvTemplates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LsvTemplates.Name = "LsvTemplates";
            this.LsvTemplates.Size = new System.Drawing.Size(340, 380);
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
            this.LsvFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsvFilters.CheckBoxes = true;
            this.LsvFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ViewFilters});
            this.LsvFilters.FullRowSelect = true;
            this.LsvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvFilters.HideSelection = false;
            this.LsvFilters.Location = new System.Drawing.Point(20, 100);
            this.LsvFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LsvFilters.Name = "LsvFilters";
            this.LsvFilters.Size = new System.Drawing.Size(340, 385);
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
            this.LblSearchFilters.Location = new System.Drawing.Point(20, 60);
            this.LblSearchFilters.Name = "LblSearchFilters";
            this.LblSearchFilters.Size = new System.Drawing.Size(52, 19);
            this.LblSearchFilters.TabIndex = 2;
            this.LblSearchFilters.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.BtnTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnTransfer.FlatAppearance.BorderSize = 0;
            this.BtnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransfer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransfer.ForeColor = System.Drawing.Color.White;
            this.BtnTransfer.Location = new System.Drawing.Point(0, 0);
            this.BtnTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(250, 60);
            this.BtnTransfer.TabIndex = 4;
            this.BtnTransfer.Text = "Transfer Filters";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(711, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 60);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnTransfer);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 60);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LblSearchFilters);
            this.panel2.Controls.Add(this.TxbSearchFilters);
            this.panel2.Controls.Add(this.LsvFilters);
            this.panel2.Location = new System.Drawing.Point(20, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 505);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Used Filters grouped by View Template";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(861, 50);
            this.panel3.TabIndex = 35;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(837, 2);
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
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.LsvTemplates);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TxbSearchTemplates);
            this.panel4.Location = new System.Drawing.Point(460, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 505);
            this.panel4.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Templates";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(861, 658);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(877, 1500);
            this.MinimumSize = new System.Drawing.Size(877, 697);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer View Filters";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}