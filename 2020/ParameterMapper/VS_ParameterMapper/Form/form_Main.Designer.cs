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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CbxCategories = new System.Windows.Forms.ComboBox();
            this.CbxTargetParameters = new System.Windows.Forms.ComboBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.RbtAsNumber = new System.Windows.Forms.RadioButton();
            this.RbtAsText = new System.Windows.Forms.RadioButton();
            this.LblParamTypeTarget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblLineSeparator = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RbtElementId = new System.Windows.Forms.RadioButton();
            this.LblParamTypeSource = new System.Windows.Forms.Label();
            this.RbtSourceParam = new System.Windows.Forms.RadioButton();
            this.LblTypeParameter = new System.Windows.Forms.Label();
            this.CbxSourceParameters = new System.Windows.Forms.ComboBox();
            this.LblTargetParam = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(0, 0);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(204, 60);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(290, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(204, 60);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Close";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbxCategories
            // 
            this.CbxCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.Location = new System.Drawing.Point(20, 60);
            this.CbxCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(279, 25);
            this.CbxCategories.TabIndex = 0;
            this.CbxCategories.SelectionChangeCommitted += new System.EventHandler(this.CbxCategories_SelectionChangeCommitted);
            // 
            // CbxTargetParameters
            // 
            this.CbxTargetParameters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxTargetParameters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxTargetParameters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbxTargetParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTargetParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxTargetParameters.FormattingEnabled = true;
            this.CbxTargetParameters.Location = new System.Drawing.Point(20, 60);
            this.CbxTargetParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxTargetParameters.Name = "CbxTargetParameters";
            this.CbxTargetParameters.Size = new System.Drawing.Size(279, 25);
            this.CbxTargetParameters.TabIndex = 5;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(20, 20);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(116, 19);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.Text = "Select Category";
            // 
            // RbtAsNumber
            // 
            this.RbtAsNumber.AutoSize = true;
            this.RbtAsNumber.Checked = true;
            this.RbtAsNumber.Location = new System.Drawing.Point(330, 70);
            this.RbtAsNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtAsNumber.Name = "RbtAsNumber";
            this.RbtAsNumber.Size = new System.Drawing.Size(150, 23);
            this.RbtAsNumber.TabIndex = 6;
            this.RbtAsNumber.TabStop = true;
            this.RbtAsNumber.Text = "Number As Number";
            this.RbtAsNumber.UseVisualStyleBackColor = true;
            // 
            // RbtAsText
            // 
            this.RbtAsText.AutoSize = true;
            this.RbtAsText.Location = new System.Drawing.Point(330, 100);
            this.RbtAsText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtAsText.Name = "RbtAsText";
            this.RbtAsText.Size = new System.Drawing.Size(124, 23);
            this.RbtAsText.TabIndex = 7;
            this.RbtAsText.Text = "Number As Text";
            this.RbtAsText.UseVisualStyleBackColor = true;
            this.RbtAsText.CheckedChanged += new System.EventHandler(this.RbtAsText_CheckedChanged);
            // 
            // LblParamTypeTarget
            // 
            this.LblParamTypeTarget.AutoSize = true;
            this.LblParamTypeTarget.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblParamTypeTarget.Location = new System.Drawing.Point(140, 100);
            this.LblParamTypeTarget.Name = "LblParamTypeTarget";
            this.LblParamTypeTarget.Size = new System.Drawing.Size(128, 19);
            this.LblParamTypeTarget.TabIndex = 11;
            this.LblParamTypeTarget.Text = "(param type target)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type of Parameter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Transfer parameter data to selected parameter:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 60);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.LblLineSeparator);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 50);
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
            this.LblLineSeparator.Size = new System.Drawing.Size(470, 2);
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
            // RbtElementId
            // 
            this.RbtElementId.AutoSize = true;
            this.RbtElementId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtElementId.Location = new System.Drawing.Point(310, 20);
            this.RbtElementId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtElementId.Name = "RbtElementId";
            this.RbtElementId.Size = new System.Drawing.Size(116, 23);
            this.RbtElementId.TabIndex = 13;
            this.RbtElementId.TabStop = true;
            this.RbtElementId.Text = "or Element Id";
            this.RbtElementId.UseVisualStyleBackColor = true;
            // 
            // LblParamTypeSource
            // 
            this.LblParamTypeSource.AutoSize = true;
            this.LblParamTypeSource.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblParamTypeSource.Location = new System.Drawing.Point(140, 100);
            this.LblParamTypeSource.Name = "LblParamTypeSource";
            this.LblParamTypeSource.Size = new System.Drawing.Size(131, 19);
            this.LblParamTypeSource.TabIndex = 10;
            this.LblParamTypeSource.Text = "(param type source)";
            // 
            // RbtSourceParam
            // 
            this.RbtSourceParam.AutoSize = true;
            this.RbtSourceParam.Checked = true;
            this.RbtSourceParam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtSourceParam.Location = new System.Drawing.Point(20, 20);
            this.RbtSourceParam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbtSourceParam.Name = "RbtSourceParam";
            this.RbtSourceParam.Size = new System.Drawing.Size(192, 23);
            this.RbtSourceParam.TabIndex = 12;
            this.RbtSourceParam.TabStop = true;
            this.RbtSourceParam.Text = "Select Source Parameter";
            this.RbtSourceParam.UseVisualStyleBackColor = true;
            this.RbtSourceParam.CheckedChanged += new System.EventHandler(this.RbtSourceParam_CheckedChanged);
            // 
            // LblTypeParameter
            // 
            this.LblTypeParameter.AutoSize = true;
            this.LblTypeParameter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblTypeParameter.Location = new System.Drawing.Point(20, 100);
            this.LblTypeParameter.Name = "LblTypeParameter";
            this.LblTypeParameter.Size = new System.Drawing.Size(123, 19);
            this.LblTypeParameter.TabIndex = 9;
            this.LblTypeParameter.Text = "Type of Parameter:";
            // 
            // CbxSourceParameters
            // 
            this.CbxSourceParameters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxSourceParameters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxSourceParameters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbxSourceParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSourceParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxSourceParameters.FormattingEnabled = true;
            this.CbxSourceParameters.Location = new System.Drawing.Point(20, 60);
            this.CbxSourceParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxSourceParameters.Name = "CbxSourceParameters";
            this.CbxSourceParameters.Size = new System.Drawing.Size(279, 25);
            this.CbxSourceParameters.TabIndex = 4;
            this.CbxSourceParameters.SelectionChangeCommitted += new System.EventHandler(this.CbxSourceParameters_SelectionChangeCommitted);
            // 
            // LblTargetParam
            // 
            this.LblTargetParam.AutoSize = true;
            this.LblTargetParam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTargetParam.Location = new System.Drawing.Point(20, 20);
            this.LblTargetParam.Name = "LblTargetParam";
            this.LblTargetParam.Size = new System.Drawing.Size(171, 19);
            this.LblTargetParam.TabIndex = 3;
            this.LblTargetParam.Text = "Select Target Parameter";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblTargetParam);
            this.panel2.Controls.Add(this.CbxTargetParameters);
            this.panel2.Controls.Add(this.LblParamTypeTarget);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 140);
            this.panel2.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CbxSourceParameters);
            this.panel4.Controls.Add(this.RbtSourceParam);
            this.panel4.Controls.Add(this.LblTypeParameter);
            this.panel4.Controls.Add(this.RbtElementId);
            this.panel4.Controls.Add(this.LblParamTypeSource);
            this.panel4.Location = new System.Drawing.Point(20, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 140);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.CbxCategories);
            this.panel5.Controls.Add(this.LblCategory);
            this.panel5.Location = new System.Drawing.Point(20, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 110);
            this.panel5.TabIndex = 35;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(494, 664);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RbtAsNumber);
            this.Controls.Add(this.RbtAsText);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameter Mapper";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbxCategories;
        private System.Windows.Forms.ComboBox CbxTargetParameters;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.RadioButton RbtAsNumber;
        private System.Windows.Forms.RadioButton RbtAsText;
        private System.Windows.Forms.Label LblParamTypeTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblLineSeparator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbtElementId;
        private System.Windows.Forms.Label LblParamTypeSource;
        private System.Windows.Forms.RadioButton RbtSourceParam;
        private System.Windows.Forms.Label LblTypeParameter;
        private System.Windows.Forms.ComboBox CbxSourceParameters;
        private System.Windows.Forms.Label LblTargetParam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}