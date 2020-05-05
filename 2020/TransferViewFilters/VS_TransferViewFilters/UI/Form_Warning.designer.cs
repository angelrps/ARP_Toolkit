namespace UI.Info
{
    partial class Form_Warning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Warning));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LblResultsHead = new System.Windows.Forms.Label();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.TbxResultMessage = new System.Windows.Forms.TextBox();
            this.LblResultsMain = new System.Windows.Forms.Label();
            this.LblResultsFoot = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 411);
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
            this.LblResultsHead.ForeColor = System.Drawing.Color.Red;
            this.LblResultsHead.Location = new System.Drawing.Point(100, 0);
            this.LblResultsHead.Name = "LblResultsHead";
            this.LblResultsHead.Size = new System.Drawing.Size(394, 50);
            this.LblResultsHead.TabIndex = 25;
            this.LblResultsHead.Text = "<placeholder text>";
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
            // TbxResultMessage
            // 
            this.TbxResultMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxResultMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbxResultMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxResultMessage.Location = new System.Drawing.Point(20, 160);
            this.TbxResultMessage.Multiline = true;
            this.TbxResultMessage.Name = "TbxResultMessage";
            this.TbxResultMessage.ReadOnly = true;
            this.TbxResultMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxResultMessage.Size = new System.Drawing.Size(450, 190);
            this.TbxResultMessage.TabIndex = 34;
            this.TbxResultMessage.Text = "(placeholder text)";
            this.TbxResultMessage.WordWrap = false;
            // 
            // LblResultsMain
            // 
            this.LblResultsMain.BackColor = System.Drawing.Color.Transparent;
            this.LblResultsMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsMain.Location = new System.Drawing.Point(20, 100);
            this.LblResultsMain.Name = "LblResultsMain";
            this.LblResultsMain.Size = new System.Drawing.Size(440, 50);
            this.LblResultsMain.TabIndex = 35;
            this.LblResultsMain.Text = "label1";
            // 
            // LblResultsFoot
            // 
            this.LblResultsFoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblResultsFoot.AutoSize = true;
            this.LblResultsFoot.BackColor = System.Drawing.Color.Transparent;
            this.LblResultsFoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultsFoot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsFoot.Location = new System.Drawing.Point(20, 365);
            this.LblResultsFoot.Name = "LblResultsFoot";
            this.LblResultsFoot.Size = new System.Drawing.Size(157, 21);
            this.LblResultsFoot.TabIndex = 36;
            this.LblResultsFoot.Text = "<placeholder text>";
            // 
            // Form_Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.LblResultsFoot);
            this.Controls.Add(this.LblResultsMain);
            this.Controls.Add(this.TbxResultMessage);
            this.Controls.Add(this.LblLineSeparator);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 1500);
            this.MinimumSize = new System.Drawing.Size(510, 510);
            this.Name = "Form_Warning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer View Filters";
            this.Load += new System.EventHandler(this.Form_DupResults_Load);
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
        private System.Windows.Forms.TextBox TbxResultMessage;
        private System.Windows.Forms.Label LblResultsMain;
        private System.Windows.Forms.Label LblResultsFoot;
    }
}