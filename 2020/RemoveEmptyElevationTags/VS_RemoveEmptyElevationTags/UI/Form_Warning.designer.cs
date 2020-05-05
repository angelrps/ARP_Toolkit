namespace UI.Warning
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblWarningMessage = new System.Windows.Forms.Label();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnContinue);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 60);
            this.panel1.TabIndex = 20;
            // 
            // BtnContinue
            // 
            this.BtnContinue.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnContinue.FlatAppearance.BorderSize = 0;
            this.BtnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.ForeColor = System.Drawing.Color.White;
            this.BtnContinue.Location = new System.Drawing.Point(0, 0);
            this.BtnContinue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(238, 60);
            this.BtnContinue.TabIndex = 7;
            this.BtnContinue.Text = "Yes";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
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
            this.BtnCancel.Location = new System.Drawing.Point(262, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(238, 60);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "No";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 20);
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
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 50);
            this.panelHeader.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 25;
            this.label1.Text = "Are you sure?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblWarningMessage
            // 
            this.LblWarningMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblWarningMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblWarningMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarningMessage.Location = new System.Drawing.Point(0, 70);
            this.LblWarningMessage.Name = "LblWarningMessage";
            this.LblWarningMessage.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.LblWarningMessage.Size = new System.Drawing.Size(500, 190);
            this.LblWarningMessage.TabIndex = 27;
            this.LblWarningMessage.Text = "This application will remove all Empty Elevation Tags from the Project.\r\n\r\nDo you" +
    " want to continue?";
            this.LblWarningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(460, 2);
            this.LblLineSeparator.TabIndex = 33;
            // 
            // Form_Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.LblLineSeparator);
            this.Controls.Add(this.LblWarningMessage);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Warning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Empty Elevation Tags";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWarningMessage;
        private System.Windows.Forms.Label LblLineSeparator;
    }
}