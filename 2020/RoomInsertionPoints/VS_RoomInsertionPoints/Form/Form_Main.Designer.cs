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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbxLinkedRoomTag = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RbtProject = new System.Windows.Forms.RadioButton();
            this.RbtActiveView = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnOK.Location = new System.Drawing.Point(14, 184);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(180, 40);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.TabStop = false;
            this.BtnOK.Text = "Ok";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // CbxRoomCentroid
            // 
            this.CbxRoomCentroid.AutoSize = true;
            this.CbxRoomCentroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CbxRoomCentroid.Location = new System.Drawing.Point(20, 76);
            this.CbxRoomCentroid.Name = "CbxRoomCentroid";
            this.CbxRoomCentroid.Size = new System.Drawing.Size(242, 17);
            this.CbxRoomCentroid.TabIndex = 3;
            this.CbxRoomCentroid.Text = "Move Room Insertion Point to Room Centroid.";
            this.CbxRoomCentroid.UseVisualStyleBackColor = true;
            // 
            // CbxRoomTag
            // 
            this.CbxRoomTag.AutoSize = true;
            this.CbxRoomTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CbxRoomTag.Location = new System.Drawing.Point(20, 99);
            this.CbxRoomTag.Name = "CbxRoomTag";
            this.CbxRoomTag.Size = new System.Drawing.Size(222, 17);
            this.CbxRoomTag.TabIndex = 4;
            this.CbxRoomTag.Text = "Move Room Tag to Room Insertion Point.";
            this.CbxRoomTag.UseVisualStyleBackColor = true;
            this.CbxRoomTag.CheckedChanged += new System.EventHandler(this.CbxRoomTag_CheckedChanged);
            this.CbxRoomTag.MouseCaptureChanged += new System.EventHandler(this.CbxRoomTag_CheckedChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCancel.Location = new System.Drawing.Point(240, 184);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(180, 40);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CbxLinkedRoomTag
            // 
            this.CbxLinkedRoomTag.AutoSize = true;
            this.CbxLinkedRoomTag.Enabled = false;
            this.CbxLinkedRoomTag.Location = new System.Drawing.Point(50, 122);
            this.CbxLinkedRoomTag.Name = "CbxLinkedRoomTag";
            this.CbxLinkedRoomTag.Size = new System.Drawing.Size(171, 17);
            this.CbxLinkedRoomTag.TabIndex = 7;
            this.CbxLinkedRoomTag.Text = "Include Tags of Linked Rooms";
            this.CbxLinkedRoomTag.UseVisualStyleBackColor = true;
            this.CbxLinkedRoomTag.CheckedChanged += new System.EventHandler(this.CbxRoomTag_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox1.Location = new System.Drawing.Point(67, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 33);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "(Current model & Linked model coordinates must match)";
            // 
            // RbtProject
            // 
            this.RbtProject.AutoSize = true;
            this.RbtProject.Location = new System.Drawing.Point(12, 20);
            this.RbtProject.Name = "RbtProject";
            this.RbtProject.Size = new System.Drawing.Size(88, 17);
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
            this.RbtActiveView.Location = new System.Drawing.Point(111, 20);
            this.RbtActiveView.Name = "RbtActiveView";
            this.RbtActiveView.Size = new System.Drawing.Size(281, 17);
            this.RbtActiveView.TabIndex = 11;
            this.RbtActiveView.TabStop = true;
            this.RbtActiveView.Text = "Active View (does not allow tags tagging linked rooms)";
            this.RbtActiveView.UseVisualStyleBackColor = true;
            this.RbtActiveView.CheckedChanged += new System.EventHandler(this.RbtActiveView_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RbtActiveView);
            this.groupBox1.Controls.Add(this.RbtProject);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scope";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(432, 242);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CbxLinkedRoomTag);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.CbxRoomTag);
            this.Controls.Add(this.CbxRoomCentroid);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Centroid, Tag to Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.CheckBox CbxRoomCentroid;
        private System.Windows.Forms.CheckBox CbxRoomTag;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CbxLinkedRoomTag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RbtProject;
        private System.Windows.Forms.RadioButton RbtActiveView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}