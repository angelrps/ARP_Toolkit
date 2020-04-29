namespace UI.Info
{
    partial class Form_Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Results));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LblResultsHead = new System.Windows.Forms.Label();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.TbxResultMsg1 = new System.Windows.Forms.TextBox();
            this.LblResultsMain1 = new System.Windows.Forms.Label();
            this.LblResultsMain2 = new System.Windows.Forms.Label();
            this.TbxResultMsg2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 701);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 60);
            this.panel1.TabIndex = 20;
            // 
            // BtnOk
            // 
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(0, 0);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(494, 60);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 20);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.LblResultsHead);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(494, 50);
            this.panelHeader.TabIndex = 26;
            // 
            // LblResultsHead
            // 
            this.LblResultsHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResultsHead.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.LblResultsHead.Location = new System.Drawing.Point(100, 0);
            this.LblResultsHead.Name = "LblResultsHead";
            this.LblResultsHead.Size = new System.Drawing.Size(394, 50);
            this.LblResultsHead.TabIndex = 25;
            this.LblResultsHead.Text = "Results";
            this.LblResultsHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLineSeparator
            // 
            this.LblLineSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLineSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLineSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblLineSeparator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLineSeparator.Location = new System.Drawing.Point(20, 80);
            this.LblLineSeparator.Name = "LblLineSeparator";
            this.LblLineSeparator.Size = new System.Drawing.Size(454, 2);
            this.LblLineSeparator.TabIndex = 33;
            // 
            // TbxResultMsg1
            // 
            this.TbxResultMsg1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxResultMsg1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxResultMsg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxResultMsg1.Location = new System.Drawing.Point(20, 140);
            this.TbxResultMsg1.Multiline = true;
            this.TbxResultMsg1.Name = "TbxResultMsg1";
            this.TbxResultMsg1.ReadOnly = true;
            this.TbxResultMsg1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxResultMsg1.Size = new System.Drawing.Size(450, 245);
            this.TbxResultMsg1.TabIndex = 34;
            this.TbxResultMsg1.Text = "<TbxResultMsg1>";
            this.TbxResultMsg1.WordWrap = false;
            // 
            // LblResultsMain1
            // 
            this.LblResultsMain1.AutoSize = true;
            this.LblResultsMain1.BackColor = System.Drawing.Color.Transparent;
            this.LblResultsMain1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultsMain1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsMain1.Location = new System.Drawing.Point(20, 100);
            this.LblResultsMain1.Name = "LblResultsMain1";
            this.LblResultsMain1.Size = new System.Drawing.Size(157, 21);
            this.LblResultsMain1.TabIndex = 35;
            this.LblResultsMain1.Text = "<LblResultsMain1>";
            // 
            // LblResultsMain2
            // 
            this.LblResultsMain2.AutoSize = true;
            this.LblResultsMain2.BackColor = System.Drawing.Color.Transparent;
            this.LblResultsMain2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultsMain2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsMain2.Location = new System.Drawing.Point(20, 400);
            this.LblResultsMain2.Name = "LblResultsMain2";
            this.LblResultsMain2.Size = new System.Drawing.Size(157, 21);
            this.LblResultsMain2.TabIndex = 36;
            this.LblResultsMain2.Text = "<LblResultsMain2>";
            // 
            // TbxResultMsg2
            // 
            this.TbxResultMsg2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxResultMsg2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxResultMsg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxResultMsg2.Location = new System.Drawing.Point(20, 435);
            this.TbxResultMsg2.Multiline = true;
            this.TbxResultMsg2.Name = "TbxResultMsg2";
            this.TbxResultMsg2.ReadOnly = true;
            this.TbxResultMsg2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxResultMsg2.Size = new System.Drawing.Size(450, 245);
            this.TbxResultMsg2.TabIndex = 37;
            this.TbxResultMsg2.Text = "<TbxResultMsg2>";
            this.TbxResultMsg2.WordWrap = false;
            // 
            // Form_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(494, 761);
            this.Controls.Add(this.TbxResultMsg2);
            this.Controls.Add(this.LblResultsMain2);
            this.Controls.Add(this.LblResultsMain1);
            this.Controls.Add(this.TbxResultMsg1);
            this.Controls.Add(this.LblLineSeparator);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 800);
            this.MinimumSize = new System.Drawing.Size(510, 800);
            this.Name = "Form_Results";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer View Filters";
            this.Load += new System.EventHandler(this.Form_Results_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label LblResultsHead;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.TextBox TbxResultMsg1;
        private System.Windows.Forms.Label LblResultsMain1;
        private System.Windows.Forms.Label LblResultsMain2;
        private System.Windows.Forms.TextBox TbxResultMsg2;
    }
}