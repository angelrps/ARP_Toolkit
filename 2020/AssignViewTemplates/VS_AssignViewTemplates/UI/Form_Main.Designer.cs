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
            this.TreeView = new System.Windows.Forms.TreeView();
            this.TxbSearch = new System.Windows.Forms.TextBox();
            this.LblViewName = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCollapse = new System.Windows.Forms.Button();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.AllowDrop = true;
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.Location = new System.Drawing.Point(3, 16);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(409, 516);
            this.TreeView.TabIndex = 0;
            this.TreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeView_DragDrop);
            this.TreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeView_DragEnter);
            this.TreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeView_DragOver);
            // 
            // TxbSearch
            // 
            this.TxbSearch.Location = new System.Drawing.Point(110, 15);
            this.TxbSearch.Name = "TxbSearch";
            this.TxbSearch.Size = new System.Drawing.Size(317, 20);
            this.TxbSearch.TabIndex = 1;
            this.TxbSearch.TextChanged += new System.EventHandler(this.TxbSearch_TextChanged);
            // 
            // LblViewName
            // 
            this.LblViewName.AutoSize = true;
            this.LblViewName.Location = new System.Drawing.Point(15, 20);
            this.LblViewName.Name = "LblViewName";
            this.LblViewName.Size = new System.Drawing.Size(89, 13);
            this.LblViewName.TabIndex = 2;
            this.LblViewName.Text = "Filter View Name:";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(310, 595);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(120, 50);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TreeView);
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 535);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drag View into Template Name to Assign the Template";
            // 
            // BtnCollapse
            // 
            this.BtnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCollapse.Location = new System.Drawing.Point(110, 595);
            this.BtnCollapse.Name = "BtnCollapse";
            this.BtnCollapse.Size = new System.Drawing.Size(80, 30);
            this.BtnCollapse.TabIndex = 5;
            this.BtnCollapse.Text = "Collapse All";
            this.BtnCollapse.UseVisualStyleBackColor = true;
            this.BtnCollapse.Click += new System.EventHandler(this.BtnCollapse_Click);
            // 
            // BtnExpand
            // 
            this.BtnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExpand.Location = new System.Drawing.Point(16, 595);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(80, 30);
            this.BtnExpand.TabIndex = 6;
            this.BtnExpand.Text = "Expand All";
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(444, 661);
            this.Controls.Add(this.BtnExpand);
            this.Controls.Add(this.BtnCollapse);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblViewName);
            this.Controls.Add(this.TxbSearch);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(460, 415);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign View Templates";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxbSearch;
        private System.Windows.Forms.Label LblViewName;
        private System.Windows.Forms.Button BtnClose;
        internal System.Windows.Forms.TreeView TreeView;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCollapse;
        private System.Windows.Forms.Button BtnExpand;
    }
}