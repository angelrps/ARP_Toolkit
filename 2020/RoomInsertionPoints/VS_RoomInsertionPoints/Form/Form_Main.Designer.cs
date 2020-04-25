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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.BtnOK = new System.Windows.Forms.Button();
            this.CbxRoomCentroid = new System.Windows.Forms.CheckBox();
            this.CbxRoomTag = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbxLinkedRoomTag = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblScope = new System.Windows.Forms.Label();
            this.RbtProject = new System.Windows.Forms.RadioButton();
            this.RbtActiveView = new System.Windows.Forms.RadioButton();
            this.LblAction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.Transparent;
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(0, 0);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(175, 60);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.TabStop = false;
            this.BtnOK.Text = "Ok";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // CbxRoomCentroid
            // 
            this.CbxRoomCentroid.AutoSize = true;
            this.CbxRoomCentroid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxRoomCentroid.Location = new System.Drawing.Point(23, 50);
            this.CbxRoomCentroid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxRoomCentroid.Name = "CbxRoomCentroid";
            this.CbxRoomCentroid.Size = new System.Drawing.Size(313, 23);
            this.CbxRoomCentroid.TabIndex = 3;
            this.CbxRoomCentroid.Text = "Move Room Insertion Point to Room Centroid.";
            this.CbxRoomCentroid.UseVisualStyleBackColor = true;
            // 
            // CbxRoomTag
            // 
            this.CbxRoomTag.AutoSize = true;
            this.CbxRoomTag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxRoomTag.Location = new System.Drawing.Point(23, 80);
            this.CbxRoomTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxRoomTag.Name = "CbxRoomTag";
            this.CbxRoomTag.Size = new System.Drawing.Size(280, 23);
            this.CbxRoomTag.TabIndex = 4;
            this.CbxRoomTag.Text = "Move Room Tag to Room Insertion Point.";
            this.CbxRoomTag.UseVisualStyleBackColor = true;
            this.CbxRoomTag.CheckedChanged += new System.EventHandler(this.CbxRoomTag_CheckedChanged);
            this.CbxRoomTag.MouseCaptureChanged += new System.EventHandler(this.CbxRoomTag_CheckedChanged);
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
            this.BtnCancel.Location = new System.Drawing.Point(379, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(175, 60);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbxLinkedRoomTag
            // 
            this.CbxLinkedRoomTag.AutoSize = true;
            this.CbxLinkedRoomTag.Enabled = false;
            this.CbxLinkedRoomTag.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxLinkedRoomTag.Location = new System.Drawing.Point(58, 110);
            this.CbxLinkedRoomTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxLinkedRoomTag.Name = "CbxLinkedRoomTag";
            this.CbxLinkedRoomTag.Size = new System.Drawing.Size(208, 23);
            this.CbxLinkedRoomTag.TabIndex = 7;
            this.CbxLinkedRoomTag.Text = "Include Tags of Linked Rooms";
            this.CbxLinkedRoomTag.UseVisualStyleBackColor = true;
            this.CbxLinkedRoomTag.CheckedChanged += new System.EventHandler(this.CbxRoomTag_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 43);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "(Note: current model & Linked model coordinates must match)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 60);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 50);
            this.panel3.TabIndex = 32;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(530, 2);
            this.LblLineSeparator.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 25);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LblScope
            // 
            this.LblScope.AutoSize = true;
            this.LblScope.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScope.Location = new System.Drawing.Point(20, 20);
            this.LblScope.Name = "LblScope";
            this.LblScope.Size = new System.Drawing.Size(54, 19);
            this.LblScope.TabIndex = 33;
            this.LblScope.Text = "Scope:";
            // 
            // RbtProject
            // 
            this.RbtProject.AutoSize = true;
            this.RbtProject.Location = new System.Drawing.Point(20, 50);
            this.RbtProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtProject.Name = "RbtProject";
            this.RbtProject.Size = new System.Drawing.Size(108, 23);
            this.RbtProject.TabIndex = 10;
            this.RbtProject.TabStop = true;
            this.RbtProject.Text = "Entire Project";
            this.RbtProject.UseVisualStyleBackColor = true;
            this.RbtProject.CheckedChanged += new System.EventHandler(this.RbtProject_CheckedChanged);
            // 
            // RbtActiveView
            // 
            this.RbtActiveView.AutoSize = true;
            this.RbtActiveView.Checked = true;
            this.RbtActiveView.Location = new System.Drawing.Point(140, 50);
            this.RbtActiveView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtActiveView.Name = "RbtActiveView";
            this.RbtActiveView.Size = new System.Drawing.Size(362, 23);
            this.RbtActiveView.TabIndex = 11;
            this.RbtActiveView.TabStop = true;
            this.RbtActiveView.Text = "Active View (does not allow tags tagging linked rooms)";
            this.RbtActiveView.UseVisualStyleBackColor = true;
            this.RbtActiveView.CheckedChanged += new System.EventHandler(this.RbtActiveView_CheckedChanged);
            // 
            // LblAction
            // 
            this.LblAction.AutoSize = true;
            this.LblAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAction.Location = new System.Drawing.Point(20, 20);
            this.LblAction.Name = "LblAction";
            this.LblAction.Size = new System.Drawing.Size(109, 19);
            this.LblAction.TabIndex = 34;
            this.LblAction.Text = "Choose Action:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblAction);
            this.panel2.Controls.Add(this.CbxRoomCentroid);
            this.panel2.Controls.Add(this.CbxRoomTag);
            this.panel2.Controls.Add(this.CbxLinkedRoomTag);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(20, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 180);
            this.panel2.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.LblScope);
            this.panel4.Controls.Add(this.RbtProject);
            this.panel4.Controls.Add(this.RbtActiveView);
            this.panel4.Location = new System.Drawing.Point(20, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(510, 100);
            this.panel4.TabIndex = 36;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(554, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Centroid, Tag to Room";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.CheckBox CbxRoomCentroid;
        private System.Windows.Forms.CheckBox CbxRoomTag;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CbxLinkedRoomTag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblScope;
        private System.Windows.Forms.RadioButton RbtProject;
        private System.Windows.Forms.RadioButton RbtActiveView;
        private System.Windows.Forms.Label LblAction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}