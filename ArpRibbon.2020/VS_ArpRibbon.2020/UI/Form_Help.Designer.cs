namespace ArpRibbon.UI
{
    partial class Form_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Help));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUserGuide = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARP Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Support:";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(132, 19);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(56, 13);
            this.LblVersion.TabIndex = 3;
            this.LblVersion.Text = "<X.X.X.X>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documentation:";
            // 
            // BtnUserGuide
            // 
            this.BtnUserGuide.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUserGuide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUserGuide.BackgroundImage")));
            this.BtnUserGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUserGuide.FlatAppearance.BorderSize = 0;
            this.BtnUserGuide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnUserGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnUserGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserGuide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnUserGuide.Location = new System.Drawing.Point(103, 165);
            this.BtnUserGuide.Name = "BtnUserGuide";
            this.BtnUserGuide.Size = new System.Drawing.Size(217, 133);
            this.BtnUserGuide.TabIndex = 7;
            this.BtnUserGuide.UseVisualStyleBackColor = false;
            this.BtnUserGuide.Click += new System.EventHandler(this.BtnUserGuide_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnOk.Location = new System.Drawing.Point(280, 324);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(40, 25);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(100, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Click on the button below to open up the ARP Tools User Guide.";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(100, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "If you have encountered a bug or unexpected error, please contact me via:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "angelruizpeinado@gmail.com";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::ArpRibbon.Properties.Resources.logo_gris;
            this.pictureBox3.Location = new System.Drawing.Point(12, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnOk;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnUserGuide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUserGuide;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}