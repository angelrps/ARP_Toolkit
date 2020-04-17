namespace Form
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.CbxOpenDocs = new System.Windows.Forms.ComboBox();
            this.ClbTemplates = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnNone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(257, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(152, 60);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(0, 0);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(152, 60);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // CbxOpenDocs
            // 
            this.CbxOpenDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxOpenDocs.BackColor = System.Drawing.Color.White;
            this.CbxOpenDocs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxOpenDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxOpenDocs.FormattingEnabled = true;
            this.CbxOpenDocs.Location = new System.Drawing.Point(100, 70);
            this.CbxOpenDocs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxOpenDocs.Name = "CbxOpenDocs";
            this.CbxOpenDocs.Size = new System.Drawing.Size(260, 25);
            this.CbxOpenDocs.TabIndex = 2;
            this.CbxOpenDocs.SelectedIndexChanged += new System.EventHandler(this.CbxOpenDocs_SelectedIndexChanged);
            // 
            // ClbTemplates
            // 
            this.ClbTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClbTemplates.CheckOnClick = true;
            this.ClbTemplates.FormattingEnabled = true;
            this.ClbTemplates.HorizontalScrollbar = true;
            this.ClbTemplates.Location = new System.Drawing.Point(20, 115);
            this.ClbTemplates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClbTemplates.Name = "ClbTemplates";
            this.ClbTemplates.Size = new System.Drawing.Size(340, 304);
            this.ClbTemplates.TabIndex = 3;
            this.ClbTemplates.SelectedIndexChanged += new System.EventHandler(this.ClbTemplates_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copy from:";
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAll.FlatAppearance.BorderSize = 0;
            this.BtnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnAll.Image")));
            this.BtnAll.Location = new System.Drawing.Point(360, 115);
            this.BtnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(50, 35);
            this.BtnAll.TabIndex = 6;
            this.Tooltip.SetToolTip(this.BtnAll, "Check All");
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnNone
            // 
            this.BtnNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNone.FlatAppearance.BorderSize = 0;
            this.BtnNone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNone.Image = ((System.Drawing.Image)(resources.GetObject("BtnNone.Image")));
            this.BtnNone.Location = new System.Drawing.Point(360, 156);
            this.BtnNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(50, 35);
            this.BtnNone.TabIndex = 7;
            this.Tooltip.SetToolTip(this.BtnNone, "Uncheck All");
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Items Selected:";
            // 
            // LblCount
            // 
            this.LblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(130, 440);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(40, 17);
            this.LblCount.TabIndex = 9;
            this.LblCount.Text = "0";
            this.LblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 60);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 50);
            this.panel3.TabIndex = 34;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(385, 2);
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
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(409, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNone);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClbTemplates);
            this.Controls.Add(this.CbxOpenDocs);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1164, 1296);
            this.MinimumSize = new System.Drawing.Size(425, 580);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer View Templates";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ComboBox CbxOpenDocs;
        private System.Windows.Forms.CheckedListBox ClbTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnNone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip Tooltip;
    }
}