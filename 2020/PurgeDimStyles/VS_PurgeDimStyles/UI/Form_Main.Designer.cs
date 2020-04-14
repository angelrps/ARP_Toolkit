namespace UI
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
            this.LsvUsed = new System.Windows.Forms.ListView();
            this.columnHeaderName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LsvUnused = new System.Windows.Forms.ListView();
            this.columnHeaderName2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblTotalUnused = new System.Windows.Forms.Label();
            this.LblTotalUsed = new System.Windows.Forms.Label();
            this.LblUnused = new System.Windows.Forms.Label();
            this.LblUsed = new System.Windows.Forms.Label();
            this.LblTotalItems = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnNone = new System.Windows.Forms.Button();
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblItemsChecked = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsvUsed
            // 
            this.LsvUsed.BackColor = System.Drawing.SystemColors.Menu;
            this.LsvUsed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName1});
            this.LsvUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvUsed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvUsed.Location = new System.Drawing.Point(0, 0);
            this.LsvUsed.Margin = new System.Windows.Forms.Padding(0);
            this.LsvUsed.MultiSelect = false;
            this.LsvUsed.Name = "LsvUsed";
            this.LsvUsed.Size = new System.Drawing.Size(223, 310);
            this.LsvUsed.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LsvUsed.TabIndex = 0;
            this.LsvUsed.UseCompatibleStateImageBehavior = false;
            this.LsvUsed.View = System.Windows.Forms.View.Details;
            this.LsvUsed.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvUsed_ItemSelectionChanged);
            // 
            // columnHeaderName1
            // 
            this.columnHeaderName1.Text = "Name";
            this.columnHeaderName1.Width = 300;
            // 
            // LsvUnused
            // 
            this.LsvUnused.AllowColumnReorder = true;
            this.LsvUnused.CheckBoxes = true;
            this.LsvUnused.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName2});
            this.LsvUnused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvUnused.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvUnused.Location = new System.Drawing.Point(5, 0);
            this.LsvUnused.Name = "LsvUnused";
            this.LsvUnused.Size = new System.Drawing.Size(247, 310);
            this.LsvUnused.TabIndex = 0;
            this.LsvUnused.UseCompatibleStateImageBehavior = false;
            this.LsvUnused.View = System.Windows.Forms.View.Details;
            this.LsvUnused.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LsvUnused_ItemChecked);
            // 
            // columnHeaderName2
            // 
            this.columnHeaderName2.Text = "Name";
            this.columnHeaderName2.Width = 300;
            // 
            // LblTotalUnused
            // 
            this.LblTotalUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalUnused.Location = new System.Drawing.Point(474, 15);
            this.LblTotalUnused.Name = "LblTotalUnused";
            this.LblTotalUnused.Size = new System.Drawing.Size(31, 14);
            this.LblTotalUnused.TabIndex = 20;
            this.LblTotalUnused.Text = "0";
            this.LblTotalUnused.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LblTotalUsed
            // 
            this.LblTotalUsed.Location = new System.Drawing.Point(60, 15);
            this.LblTotalUsed.Name = "LblTotalUsed";
            this.LblTotalUsed.Size = new System.Drawing.Size(56, 14);
            this.LblTotalUsed.TabIndex = 19;
            this.LblTotalUsed.Text = "0";
            this.LblTotalUsed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LblUnused
            // 
            this.LblUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUnused.AutoSize = true;
            this.LblUnused.Location = new System.Drawing.Point(430, 15);
            this.LblUnused.Name = "LblUnused";
            this.LblUnused.Size = new System.Drawing.Size(47, 13);
            this.LblUnused.TabIndex = 18;
            this.LblUnused.Text = "Unused:";
            // 
            // LblUsed
            // 
            this.LblUsed.AutoSize = true;
            this.LblUsed.Location = new System.Drawing.Point(15, 15);
            this.LblUsed.Name = "LblUsed";
            this.LblUsed.Size = new System.Drawing.Size(35, 13);
            this.LblUsed.TabIndex = 17;
            this.LblUsed.Text = "Used:";
            // 
            // LblTotalItems
            // 
            this.LblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalItems.Location = new System.Drawing.Point(632, 15);
            this.LblTotalItems.Name = "LblTotalItems";
            this.LblTotalItems.Size = new System.Drawing.Size(38, 20);
            this.LblTotalItems.TabIndex = 24;
            this.LblTotalItems.Text = "0";
            this.LblTotalItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(520, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Total Dimension Styles:";
            // 
            // BtnNone
            // 
            this.BtnNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNone.Location = new System.Drawing.Point(520, 70);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(90, 25);
            this.BtnNone.TabIndex = 22;
            this.BtnNone.Text = "Check None";
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAll.Location = new System.Drawing.Point(520, 35);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(90, 25);
            this.BtnAll.TabIndex = 21;
            this.BtnAll.Text = "Check All";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(520, 300);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 45);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.Location = new System.Drawing.Point(520, 240);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(150, 45);
            this.BtnOK.TabIndex = 27;
            this.BtnOK.Text = "Purge";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblItemsChecked
            // 
            this.LblItemsChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblItemsChecked.Location = new System.Drawing.Point(635, 212);
            this.LblItemsChecked.Name = "LblItemsChecked";
            this.LblItemsChecked.Size = new System.Drawing.Size(35, 20);
            this.LblItemsChecked.TabIndex = 26;
            this.LblItemsChecked.Text = "0";
            this.LblItemsChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label1.Location = new System.Drawing.Point(520, 215);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Items Checked:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Location = new System.Drawing.Point(15, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 310);
            this.panel1.TabIndex = 29;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.LsvUsed);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LsvUnused);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.splitContainer2.Size = new System.Drawing.Size(490, 310);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblItemsChecked);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LblTotalItems);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnNone);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.LblTotalUnused);
            this.Controls.Add(this.LblTotalUsed);
            this.Controls.Add(this.LblUnused);
            this.Controls.Add(this.LblUsed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 1000);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purge Dimension Styles";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LsvUsed;
        private System.Windows.Forms.ListView LsvUnused;
        private System.Windows.Forms.ColumnHeader columnHeaderName1;
        private System.Windows.Forms.ColumnHeader columnHeaderName2;
        private System.Windows.Forms.Label LblTotalUnused;
        private System.Windows.Forms.Label LblTotalUsed;
        private System.Windows.Forms.Label LblUnused;
        private System.Windows.Forms.Label LblUsed;
        private System.Windows.Forms.Label LblTotalItems;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button BtnNone;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblItemsChecked;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}