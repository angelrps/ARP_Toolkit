namespace DeleteUnusedTextNoteTypes
{
    partial class TextNotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextNotesForm));
            this.clbUnused = new System.Windows.Forms.CheckedListBox();
            this.lbxUsedTypes = new System.Windows.Forms.ListBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemsChecked = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUsed = new System.Windows.Forms.Label();
            this.lblUnused = new System.Windows.Forms.Label();
            this.lblTotalUsed = new System.Windows.Forms.Label();
            this.lblTotalUnused = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbUnused
            // 
            this.clbUnused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbUnused.CheckOnClick = true;
            this.clbUnused.FormattingEnabled = true;
            this.clbUnused.HorizontalScrollbar = true;
            this.clbUnused.IntegralHeight = false;
            this.clbUnused.Location = new System.Drawing.Point(295, 100);
            this.clbUnused.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbUnused.Name = "clbUnused";
            this.clbUnused.Size = new System.Drawing.Size(255, 325);
            this.clbUnused.TabIndex = 0;
            this.clbUnused.SelectedIndexChanged += new System.EventHandler(this.clbUnused_SelectedIndexChanged);
            // 
            // lbxUsedTypes
            // 
            this.lbxUsedTypes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxUsedTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxUsedTypes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbxUsedTypes.FormattingEnabled = true;
            this.lbxUsedTypes.ItemHeight = 17;
            this.lbxUsedTypes.Location = new System.Drawing.Point(20, 100);
            this.lbxUsedTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxUsedTypes.Name = "lbxUsedTypes";
            this.lbxUsedTypes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxUsedTypes.Size = new System.Drawing.Size(255, 325);
            this.lbxUsedTypes.Sorted = true;
            this.lbxUsedTypes.TabIndex = 4;
            this.lbxUsedTypes.SelectedIndexChanged += new System.EventHandler(this.lbxUsedTypes_SelectedIndexChanged);
            // 
            // btnAll
            // 
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.Location = new System.Drawing.Point(550, 100);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(50, 35);
            this.btnAll.TabIndex = 5;
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnNone
            // 
            this.btnNone.FlatAppearance.BorderSize = 0;
            this.btnNone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNone.Image = ((System.Drawing.Image)(resources.GetObject("btnNone.Image")));
            this.btnNone.Location = new System.Drawing.Point(550, 143);
            this.btnNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(50, 35);
            this.btnNone.TabIndex = 6;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(20, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Items to Purge:";
            // 
            // lblItemsChecked
            // 
            this.lblItemsChecked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsChecked.Location = new System.Drawing.Point(180, 468);
            this.lblItemsChecked.Name = "lblItemsChecked";
            this.lblItemsChecked.Size = new System.Drawing.Size(40, 20);
            this.lblItemsChecked.TabIndex = 8;
            this.lblItemsChecked.Text = "0";
            this.lblItemsChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Text Note Types:";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Location = new System.Drawing.Point(180, 443);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(40, 20);
            this.lblTotalItems.TabIndex = 10;
            this.lblTotalItems.Text = "0";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(0, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(162, 60);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Purge";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(440, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 60);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsed.Location = new System.Drawing.Point(20, 70);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(46, 19);
            this.lblUsed.TabIndex = 13;
            this.lblUsed.Text = "Used:";
            // 
            // lblUnused
            // 
            this.lblUnused.AutoSize = true;
            this.lblUnused.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnused.Location = new System.Drawing.Point(291, 70);
            this.lblUnused.Name = "lblUnused";
            this.lblUnused.Size = new System.Drawing.Size(62, 19);
            this.lblUnused.TabIndex = 14;
            this.lblUnused.Text = "Unused:";
            // 
            // lblTotalUsed
            // 
            this.lblTotalUsed.Location = new System.Drawing.Point(78, 70);
            this.lblTotalUsed.Name = "lblTotalUsed";
            this.lblTotalUsed.Size = new System.Drawing.Size(65, 18);
            this.lblTotalUsed.TabIndex = 15;
            this.lblTotalUsed.Text = "0";
            this.lblTotalUsed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTotalUnused
            // 
            this.lblTotalUnused.Location = new System.Drawing.Point(352, 70);
            this.lblTotalUnused.Name = "lblTotalUnused";
            this.lblTotalUnused.Size = new System.Drawing.Size(68, 18);
            this.lblTotalUnused.TabIndex = 16;
            this.lblTotalUnused.Text = "0";
            this.lblTotalUnused.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 60);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 50);
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
            this.LblLineSeparator.Size = new System.Drawing.Size(578, 2);
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
            // TextNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(602, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalUnused);
            this.Controls.Add(this.lblTotalUsed);
            this.Controls.Add(this.lblUnused);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblItemsChecked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbxUsedTypes);
            this.Controls.Add(this.clbUnused);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TextNotesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purge Text Note Types";
            this.Load += new System.EventHandler(this.TextNotesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbUnused;
        private System.Windows.Forms.ListBox lbxUsedTypes;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemsChecked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.Label lblUnused;
        private System.Windows.Forms.Label lblTotalUsed;
        private System.Windows.Forms.Label lblTotalUnused;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}