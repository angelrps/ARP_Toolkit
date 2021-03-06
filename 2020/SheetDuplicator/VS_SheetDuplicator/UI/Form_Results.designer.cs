﻿namespace UI.Info
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
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LblResultsMain = new System.Windows.Forms.Label();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.LblResults = new System.Windows.Forms.Label();
            this.LblResults3 = new System.Windows.Forms.Label();
            this.LblResultBody = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnNo);
            this.panel1.Controls.Add(this.BtnYes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 60);
            this.panel1.TabIndex = 20;
            // 
            // BtnNo
            // 
            this.BtnNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNo.FlatAppearance.BorderSize = 0;
            this.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(344, 0);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(150, 60);
            this.BtnNo.TabIndex = 8;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnYes.FlatAppearance.BorderSize = 0;
            this.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.Location = new System.Drawing.Point(0, 0);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(150, 60);
            this.BtnYes.TabIndex = 7;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
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
            this.panelHeader.Controls.Add(this.LblResultsMain);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(494, 50);
            this.panelHeader.TabIndex = 26;
            // 
            // LblResultsMain
            // 
            this.LblResultsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResultsMain.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultsMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.LblResultsMain.Location = new System.Drawing.Point(100, 0);
            this.LblResultsMain.Name = "LblResultsMain";
            this.LblResultsMain.Size = new System.Drawing.Size(394, 50);
            this.LblResultsMain.TabIndex = 25;
            this.LblResultsMain.Text = "<placeholder text>";
            this.LblResultsMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // LblResults
            // 
            this.LblResults.BackColor = System.Drawing.Color.Transparent;
            this.LblResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResults.Location = new System.Drawing.Point(20, 100);
            this.LblResults.Name = "LblResults";
            this.LblResults.Size = new System.Drawing.Size(450, 80);
            this.LblResults.TabIndex = 35;
            this.LblResults.Text = "label1";
            // 
            // LblResults3
            // 
            this.LblResults3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblResults3.AutoSize = true;
            this.LblResults3.BackColor = System.Drawing.Color.Transparent;
            this.LblResults3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResults3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResults3.Location = new System.Drawing.Point(20, 255);
            this.LblResults3.Name = "LblResults3";
            this.LblResults3.Size = new System.Drawing.Size(318, 21);
            this.LblResults3.TabIndex = 36;
            this.LblResults3.Text = "Do you want to duplicate another sheet?";
            // 
            // LblResultBody
            // 
            this.LblResultBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblResultBody.BackColor = System.Drawing.Color.Transparent;
            this.LblResultBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResultBody.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultBody.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblResultBody.Location = new System.Drawing.Point(20, 190);
            this.LblResultBody.Name = "LblResultBody";
            this.LblResultBody.Size = new System.Drawing.Size(440, 40);
            this.LblResultBody.TabIndex = 37;
            this.LblResultBody.Text = "<placeholder text>";
            this.LblResultBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.LblResultBody);
            this.Controls.Add(this.LblResults3);
            this.Controls.Add(this.LblResults);
            this.Controls.Add(this.LblLineSeparator);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 1500);
            this.Name = "Form_Results";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheet Duplicator";
            this.Load += new System.EventHandler(this.Form_Results_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label LblResultsMain;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.Label LblResults;
        private System.Windows.Forms.Label LblResults3;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Label LblResultBody;
    }
}