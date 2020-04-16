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
            this.components = new System.ComponentModel.Container();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckAll = new System.Windows.Forms.ToolTip(this.components);
            this.UncheckAll = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LsvUsed
            // 
            this.LsvUsed.BackColor = System.Drawing.SystemColors.Menu;
            this.LsvUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvUsed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName1});
            this.LsvUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvUsed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvUsed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvUsed.HideSelection = false;
            this.LsvUsed.Location = new System.Drawing.Point(0, 0);
            this.LsvUsed.Margin = new System.Windows.Forms.Padding(0);
            this.LsvUsed.MultiSelect = false;
            this.LsvUsed.Name = "LsvUsed";
            this.LsvUsed.Size = new System.Drawing.Size(206, 334);
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
            this.LsvUnused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsvUnused.CheckBoxes = true;
            this.LsvUnused.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName2});
            this.LsvUnused.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvUnused.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvUnused.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LsvUnused.HideSelection = false;
            this.LsvUnused.Location = new System.Drawing.Point(5, 0);
            this.LsvUnused.Name = "LsvUnused";
            this.LsvUnused.Size = new System.Drawing.Size(288, 334);
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
            this.LblTotalUnused.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalUnused.Location = new System.Drawing.Point(496, 70);
            this.LblTotalUnused.Name = "LblTotalUnused";
            this.LblTotalUnused.Size = new System.Drawing.Size(40, 19);
            this.LblTotalUnused.TabIndex = 20;
            this.LblTotalUnused.Text = "0";
            this.LblTotalUnused.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LblTotalUsed
            // 
            this.LblTotalUsed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalUsed.Location = new System.Drawing.Point(78, 70);
            this.LblTotalUsed.Name = "LblTotalUsed";
            this.LblTotalUsed.Size = new System.Drawing.Size(56, 19);
            this.LblTotalUsed.TabIndex = 19;
            this.LblTotalUsed.Text = "0";
            this.LblTotalUsed.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LblUnused
            // 
            this.LblUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUnused.AutoSize = true;
            this.LblUnused.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnused.Location = new System.Drawing.Point(442, 70);
            this.LblUnused.Name = "LblUnused";
            this.LblUnused.Size = new System.Drawing.Size(62, 19);
            this.LblUnused.TabIndex = 18;
            this.LblUnused.Text = "Unused:";
            // 
            // LblUsed
            // 
            this.LblUsed.AutoSize = true;
            this.LblUsed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsed.Location = new System.Drawing.Point(20, 70);
            this.LblUsed.Name = "LblUsed";
            this.LblUsed.Size = new System.Drawing.Size(46, 19);
            this.LblUsed.TabIndex = 17;
            this.LblUsed.Text = "Used:";
            // 
            // LblTotalItems
            // 
            this.LblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalItems.Location = new System.Drawing.Point(180, 443);
            this.LblTotalItems.Name = "LblTotalItems";
            this.LblTotalItems.Size = new System.Drawing.Size(40, 20);
            this.LblTotalItems.TabIndex = 24;
            this.LblTotalItems.Text = "0";
            this.LblTotalItems.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(20, 443);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(163, 19);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Total Dimension Styles:";
            // 
            // BtnNone
            // 
            this.BtnNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnNone.FlatAppearance.BorderSize = 0;
            this.BtnNone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNone.Image = ((System.Drawing.Image)(resources.GetObject("BtnNone.Image")));
            this.BtnNone.Location = new System.Drawing.Point(534, 138);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(50, 35);
            this.BtnNone.TabIndex = 22;
            this.UncheckAll.SetToolTip(this.BtnNone, "Uncheck All");
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAll.FlatAppearance.BorderSize = 0;
            this.BtnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnAll.Image")));
            this.BtnAll.Location = new System.Drawing.Point(534, 97);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(50, 35);
            this.BtnAll.TabIndex = 21;
            this.CheckAll.SetToolTip(this.BtnAll, "Check All");
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(434, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 60);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.Text = "Close";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.Transparent;
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(0, 0);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(150, 60);
            this.BtnOK.TabIndex = 27;
            this.BtnOK.Text = "Purge";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblItemsChecked
            // 
            this.LblItemsChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblItemsChecked.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemsChecked.Location = new System.Drawing.Point(180, 468);
            this.LblItemsChecked.Name = "LblItemsChecked";
            this.LblItemsChecked.Size = new System.Drawing.Size(40, 20);
            this.LblItemsChecked.TabIndex = 26;
            this.LblItemsChecked.Text = "0";
            this.LblItemsChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label1.Location = new System.Drawing.Point(20, 468);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(111, 19);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Items to Purge:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Location = new System.Drawing.Point(20, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 334);
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
            this.splitContainer2.Size = new System.Drawing.Size(514, 334);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.BtnOK);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 60);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 50);
            this.panel3.TabIndex = 31;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(560, 2);
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
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.MaximumSize = new System.Drawing.Size(900, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purge Dimension Styles";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip UncheckAll;
        private System.Windows.Forms.ToolTip CheckAll;
        private System.Windows.Forms.Label LblLineSeparator;
    }
}