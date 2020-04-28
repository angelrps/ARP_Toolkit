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
            this.TreeView = new System.Windows.Forms.TreeView();
            this.TxbSearch = new System.Windows.Forms.TextBox();
            this.LblViewName = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCollapse = new System.Windows.Forms.Button();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.AllowDrop = true;
            this.TreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeView.Location = new System.Drawing.Point(20, 140);
            this.TreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(385, 410);
            this.TreeView.TabIndex = 0;
            this.TreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.TreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            this.TreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_DragOver);
            // 
            // TxbSearch
            // 
            this.TxbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSearch.Location = new System.Drawing.Point(140, 70);
            this.TxbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(265, 25);
            this.TxbSearch.TabIndex = 1;
            this.TxbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            // 
            // LblViewName
            // 
            this.LblViewName.AutoSize = true;
            this.LblViewName.Location = new System.Drawing.Point(20, 75);
            this.LblViewName.Name = "LblViewName";
            this.LblViewName.Size = new System.Drawing.Size(115, 19);
            this.LblViewName.TabIndex = 2;
            this.LblViewName.Text = "Filter View Name:";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(304, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 60);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCollapse
            // 
            this.BtnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCollapse.FlatAppearance.BorderSize = 0;
            this.BtnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCollapse.Image = ((System.Drawing.Image)(resources.GetObject("BtnCollapse.Image")));
            this.BtnCollapse.Location = new System.Drawing.Point(405, 174);
            this.BtnCollapse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCollapse.Name = "BtnCollapse";
            this.BtnCollapse.Size = new System.Drawing.Size(50, 35);
            this.BtnCollapse.TabIndex = 5;
            this.Tooltip.SetToolTip(this.BtnCollapse, "Collapse All");
            this.BtnCollapse.UseVisualStyleBackColor = true;
            this.BtnCollapse.Click += new System.EventHandler(this.BtnCollapse_Click);
            // 
            // BtnExpand
            // 
            this.BtnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExpand.FlatAppearance.BorderSize = 0;
            this.BtnExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpand.Image = ((System.Drawing.Image)(resources.GetObject("BtnExpand.Image")));
            this.BtnExpand.Location = new System.Drawing.Point(405, 140);
            this.BtnExpand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(50, 35);
            this.BtnExpand.TabIndex = 6;
            this.Tooltip.SetToolTip(this.BtnExpand, "Expand All");
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 591);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 60);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drag View into Template Name to Assign the Template:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 50);
            this.panel3.TabIndex = 35;
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
            this.LblLineSeparator.Size = new System.Drawing.Size(430, 2);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(454, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnExpand);
            this.Controls.Add(this.BtnCollapse);
            this.Controls.Add(this.LblViewName);
            this.Controls.Add(this.TxbSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1000, 1500);
            this.MinimumSize = new System.Drawing.Size(470, 690);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign View Templates";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxbSearch;
        private System.Windows.Forms.Label LblViewName;
        private System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Button BtnCollapse;
        private System.Windows.Forms.Button BtnExpand;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip Tooltip;
    }
}