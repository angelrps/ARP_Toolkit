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
            this.SuspendLayout();
            // 
            // clbUnused
            // 
            this.clbUnused.CheckOnClick = true;
            this.clbUnused.FormattingEnabled = true;
            this.clbUnused.HorizontalScrollbar = true;
            this.clbUnused.Location = new System.Drawing.Point(247, 29);
            this.clbUnused.Name = "clbUnused";
            this.clbUnused.Size = new System.Drawing.Size(220, 184);
            this.clbUnused.TabIndex = 0;
            this.clbUnused.SelectedIndexChanged += new System.EventHandler(this.clbUnused_SelectedIndexChanged);
            // 
            // lbxUsedTypes
            // 
            this.lbxUsedTypes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxUsedTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxUsedTypes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbxUsedTypes.FormattingEnabled = true;
            this.lbxUsedTypes.Location = new System.Drawing.Point(12, 29);
            this.lbxUsedTypes.Name = "lbxUsedTypes";
            this.lbxUsedTypes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxUsedTypes.Size = new System.Drawing.Size(220, 184);
            this.lbxUsedTypes.Sorted = true;
            this.lbxUsedTypes.TabIndex = 4;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(479, 33);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Check All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(479, 60);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(75, 23);
            this.btnNone.TabIndex = 6;
            this.btnNone.Text = "Check None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(478, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Items Checked:";
            // 
            // lblItemsChecked
            // 
            this.lblItemsChecked.Location = new System.Drawing.Point(583, 115);
            this.lblItemsChecked.Name = "lblItemsChecked";
            this.lblItemsChecked.Size = new System.Drawing.Size(33, 18);
            this.lblItemsChecked.TabIndex = 8;
            this.lblItemsChecked.Text = "0";
            this.lblItemsChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Text Note Types:";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Location = new System.Drawing.Point(596, 12);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(20, 26);
            this.lblTotalItems.TabIndex = 10;
            this.lblTotalItems.Text = "0";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(479, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(139, 30);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Purge";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(479, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Location = new System.Drawing.Point(9, 12);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(35, 13);
            this.lblUsed.TabIndex = 13;
            this.lblUsed.Text = "Used:";
            // 
            // lblUnused
            // 
            this.lblUnused.AutoSize = true;
            this.lblUnused.Location = new System.Drawing.Point(244, 12);
            this.lblUnused.Name = "lblUnused";
            this.lblUnused.Size = new System.Drawing.Size(47, 13);
            this.lblUnused.TabIndex = 14;
            this.lblUnused.Text = "Unused:";
            // 
            // lblTotalUsed
            // 
            this.lblTotalUsed.Location = new System.Drawing.Point(50, 12);
            this.lblTotalUsed.Name = "lblTotalUsed";
            this.lblTotalUsed.Size = new System.Drawing.Size(56, 14);
            this.lblTotalUsed.TabIndex = 15;
            this.lblTotalUsed.Text = "0";
            this.lblTotalUsed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTotalUnused
            // 
            this.lblTotalUnused.Location = new System.Drawing.Point(297, 12);
            this.lblTotalUnused.Name = "lblTotalUnused";
            this.lblTotalUnused.Size = new System.Drawing.Size(58, 14);
            this.lblTotalUnused.TabIndex = 16;
            this.lblTotalUnused.Text = "0";
            this.lblTotalUnused.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TextNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(630, 227);
            this.Controls.Add(this.lblTotalUnused);
            this.Controls.Add(this.lblTotalUsed);
            this.Controls.Add(this.lblUnused);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblItemsChecked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbxUsedTypes);
            this.Controls.Add(this.clbUnused);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purge Text Note Types";
            this.Load += new System.EventHandler(this.TextNotesForm_Load);
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
    }
}