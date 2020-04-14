namespace Form
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RbtFlipWalls = new System.Windows.Forms.RadioButton();
            this.RbtFlipHand = new System.Windows.Forms.RadioButton();
            this.RbtFlipFacing = new System.Windows.Forms.RadioButton();
            this.BtnOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GbxWalls = new System.Windows.Forms.GroupBox();
            this.GbxDoors = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GbxWalls.SuspendLayout();
            this.GbxDoors.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(540, 155);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(130, 50);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // RbtFlipWalls
            // 
            this.RbtFlipWalls.AutoSize = true;
            this.RbtFlipWalls.Location = new System.Drawing.Point(15, 20);
            this.RbtFlipWalls.Name = "RbtFlipWalls";
            this.RbtFlipWalls.Size = new System.Drawing.Size(134, 17);
            this.RbtFlipWalls.TabIndex = 3;
            this.RbtFlipWalls.TabStop = true;
            this.RbtFlipWalls.Text = "Flip Walls by Centerline";
            this.RbtFlipWalls.UseVisualStyleBackColor = true;
            this.RbtFlipWalls.Click += new System.EventHandler(this.RbtFlipWall_Click);
            // 
            // RbtFlipHand
            // 
            this.RbtFlipHand.AutoSize = true;
            this.RbtFlipHand.Location = new System.Drawing.Point(15, 20);
            this.RbtFlipHand.Name = "RbtFlipHand";
            this.RbtFlipHand.Size = new System.Drawing.Size(96, 17);
            this.RbtFlipHand.TabIndex = 1;
            this.RbtFlipHand.TabStop = true;
            this.RbtFlipHand.Text = "Flip Door Hand";
            this.RbtFlipHand.UseVisualStyleBackColor = true;
            this.RbtFlipHand.Click += new System.EventHandler(this.RbtFlipHand_Click);
            // 
            // RbtFlipFacing
            // 
            this.RbtFlipFacing.AutoSize = true;
            this.RbtFlipFacing.Location = new System.Drawing.Point(175, 20);
            this.RbtFlipFacing.Name = "RbtFlipFacing";
            this.RbtFlipFacing.Size = new System.Drawing.Size(102, 17);
            this.RbtFlipFacing.TabIndex = 2;
            this.RbtFlipFacing.TabStop = true;
            this.RbtFlipFacing.Text = "Flip Door Facing";
            this.RbtFlipFacing.UseVisualStyleBackColor = true;
            this.RbtFlipFacing.Click += new System.EventHandler(this.RbtFlipFacing_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(540, 90);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(130, 50);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(175, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // GbxWalls
            // 
            this.GbxWalls.Controls.Add(this.pictureBox1);
            this.GbxWalls.Controls.Add(this.RbtFlipWalls);
            this.GbxWalls.Location = new System.Drawing.Point(360, 20);
            this.GbxWalls.Name = "GbxWalls";
            this.GbxWalls.Size = new System.Drawing.Size(160, 185);
            this.GbxWalls.TabIndex = 11;
            this.GbxWalls.TabStop = false;
            this.GbxWalls.Text = "Walls";
            // 
            // GbxDoors
            // 
            this.GbxDoors.Controls.Add(this.pictureBox3);
            this.GbxDoors.Controls.Add(this.RbtFlipHand);
            this.GbxDoors.Controls.Add(this.pictureBox2);
            this.GbxDoors.Controls.Add(this.RbtFlipFacing);
            this.GbxDoors.Location = new System.Drawing.Point(20, 20);
            this.GbxDoors.Name = "GbxDoors";
            this.GbxDoors.Size = new System.Drawing.Size(320, 185);
            this.GbxDoors.TabIndex = 12;
            this.GbxDoors.TabStop = false;
            this.GbxDoors.Text = "Doors";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(689, 221);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.GbxWalls);
            this.Controls.Add(this.GbxDoors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GbxWalls.ResumeLayout(false);
            this.GbxWalls.PerformLayout();
            this.GbxDoors.ResumeLayout(false);
            this.GbxDoors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RbtFlipWalls;
        private System.Windows.Forms.RadioButton RbtFlipHand;
        private System.Windows.Forms.RadioButton RbtFlipFacing;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox GbxWalls;
        private System.Windows.Forms.GroupBox GbxDoors;
    }
}