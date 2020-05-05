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
            this.BtnContinue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LblWarningHead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblWarningMain = new System.Windows.Forms.Label();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.LblWarningBody = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnContinue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 60);
            this.panel1.TabIndex = 20;
            // 
            // BtnContinue
            // 
            this.BtnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnContinue.FlatAppearance.BorderSize = 0;
            this.BtnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.ForeColor = System.Drawing.Color.White;
            this.BtnContinue.Location = new System.Drawing.Point(0, 0);
            this.BtnContinue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(434, 60);
            this.BtnContinue.TabIndex = 7;
            this.BtnContinue.Text = "OK, I get it";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 20);
            this.panel2.TabIndex = 23;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.LblWarningHead);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(434, 50);
            this.panelHeader.TabIndex = 26;
            // 
            // LblWarningHead
            // 
            this.LblWarningHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblWarningHead.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningHead.ForeColor = System.Drawing.Color.Red;
            this.LblWarningHead.Location = new System.Drawing.Point(100, 0);
            this.LblWarningHead.Name = "LblWarningHead";
            this.LblWarningHead.Size = new System.Drawing.Size(334, 50);
            this.LblWarningHead.TabIndex = 25;
            this.LblWarningHead.Text = "<placeholder text>";
            this.LblWarningHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // LblWarningMain
            // 
            this.LblWarningMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblWarningMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblWarningMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningMain.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblWarningMain.Location = new System.Drawing.Point(20, 100);
            this.LblWarningMain.Name = "LblWarningMain";
            this.LblWarningMain.Size = new System.Drawing.Size(394, 53);
            this.LblWarningMain.TabIndex = 27;
            this.LblWarningMain.Text = "<placeholder text> <placeholder text> <placeholder text>";
            this.LblWarningMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(394, 2);
            this.LblLineSeparator.TabIndex = 33;
            // 
            // LblWarningBody
            // 
            this.LblWarningBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblWarningBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblWarningBody.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningBody.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblWarningBody.Location = new System.Drawing.Point(20, 153);
            this.LblWarningBody.Name = "LblWarningBody";
            this.LblWarningBody.Size = new System.Drawing.Size(394, 81);
            this.LblWarningBody.TabIndex = 34;
            this.LblWarningBody.Text = "<placeholder text>";
            this.LblWarningBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.LblWarningBody);
            this.Controls.Add(this.LblLineSeparator);
            this.Controls.Add(this.LblWarningMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Warning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARP Toolkit";
            this.Load += new System.EventHandler(this.Form_Warning_Load);
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label LblWarningHead;
        private System.Windows.Forms.Label LblWarningMain;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.Label LblWarningBody;
    }
}