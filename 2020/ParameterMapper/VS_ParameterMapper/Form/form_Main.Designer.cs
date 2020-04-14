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
            this.CbxSourceParameters = new System.Windows.Forms.ComboBox();
            this.CbxTargetParameters = new System.Windows.Forms.ComboBox();
            this.LblTargetParam = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.RbtAsNumber = new System.Windows.Forms.RadioButton();
            this.RbtAsText = new System.Windows.Forms.RadioButton();
            this.LblTypeParameter = new System.Windows.Forms.Label();
            this.LblParamTypeSource = new System.Windows.Forms.Label();
            this.LblParamTypeTarget = new System.Windows.Forms.Label();
            this.RbtSourceParam = new System.Windows.Forms.RadioButton();
            this.RbtElementId = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(20, 354);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(175, 45);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(235, 354);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(175, 45);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbxCategories
            // 
            this.CbxCategories.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxCategories.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.Location = new System.Drawing.Point(10, 42);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(240, 21);
            this.CbxCategories.TabIndex = 0;
            this.CbxCategories.SelectionChangeCommitted += new System.EventHandler(this.CbxCategories_SelectionChangeCommitted);
            // 
            // CbxSourceParameters
            // 
            this.CbxSourceParameters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxSourceParameters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxSourceParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSourceParameters.FormattingEnabled = true;
            this.CbxSourceParameters.Location = new System.Drawing.Point(10, 40);
            this.CbxSourceParameters.Name = "CbxSourceParameters";
            this.CbxSourceParameters.Size = new System.Drawing.Size(240, 21);
            this.CbxSourceParameters.TabIndex = 4;
            this.CbxSourceParameters.SelectionChangeCommitted += new System.EventHandler(this.CbxSourceParameters_SelectionChangeCommitted);
            // 
            // CbxTargetParameters
            // 
            this.CbxTargetParameters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxTargetParameters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxTargetParameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTargetParameters.FormattingEnabled = true;
            this.CbxTargetParameters.Location = new System.Drawing.Point(30, 285);
            this.CbxTargetParameters.Name = "CbxTargetParameters";
            this.CbxTargetParameters.Size = new System.Drawing.Size(240, 21);
            this.CbxTargetParameters.TabIndex = 5;
            // 
            // LblTargetParam
            // 
            this.LblTargetParam.AutoSize = true;
            this.LblTargetParam.Location = new System.Drawing.Point(10, 15);
            this.LblTargetParam.Name = "LblTargetParam";
            this.LblTargetParam.Size = new System.Drawing.Size(125, 13);
            this.LblTargetParam.TabIndex = 3;
            this.LblTargetParam.Text = "Select Target Parameter:";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(30, 70);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(85, 13);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.Text = "Select Category:";
            // 
            // RbtAsNumber
            // 
            this.RbtAsNumber.AutoSize = true;
            this.RbtAsNumber.Checked = true;
            this.RbtAsNumber.Location = new System.Drawing.Point(281, 15);
            this.RbtAsNumber.Name = "RbtAsNumber";
            this.RbtAsNumber.Size = new System.Drawing.Size(117, 17);
            this.RbtAsNumber.TabIndex = 6;
            this.RbtAsNumber.TabStop = true;
            this.RbtAsNumber.Text = "Number As Number";
            this.RbtAsNumber.UseVisualStyleBackColor = true;
            // 
            // RbtAsText
            // 
            this.RbtAsText.AutoSize = true;
            this.RbtAsText.Location = new System.Drawing.Point(281, 35);
            this.RbtAsText.Name = "RbtAsText";
            this.RbtAsText.Size = new System.Drawing.Size(101, 17);
            this.RbtAsText.TabIndex = 7;
            this.RbtAsText.Text = "Number As Text";
            this.RbtAsText.UseVisualStyleBackColor = true;
            this.RbtAsText.CheckedChanged += new System.EventHandler(this.RbtAsText_CheckedChanged);
            // 
            // LblTypeParameter
            // 
            this.LblTypeParameter.AutoSize = true;
            this.LblTypeParameter.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblTypeParameter.Location = new System.Drawing.Point(10, 70);
            this.LblTypeParameter.Name = "LblTypeParameter";
            this.LblTypeParameter.Size = new System.Drawing.Size(97, 13);
            this.LblTypeParameter.TabIndex = 9;
            this.LblTypeParameter.Text = "Type of Parameter:";
            // 
            // LblParamTypeSource
            // 
            this.LblParamTypeSource.AutoSize = true;
            this.LblParamTypeSource.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblParamTypeSource.Location = new System.Drawing.Point(110, 70);
            this.LblParamTypeSource.Name = "LblParamTypeSource";
            this.LblParamTypeSource.Size = new System.Drawing.Size(100, 13);
            this.LblParamTypeSource.TabIndex = 10;
            this.LblParamTypeSource.Text = "(param type source)";
            // 
            // LblParamTypeTarget
            // 
            this.LblParamTypeTarget.AutoSize = true;
            this.LblParamTypeTarget.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblParamTypeTarget.Location = new System.Drawing.Point(130, 315);
            this.LblParamTypeTarget.Name = "LblParamTypeTarget";
            this.LblParamTypeTarget.Size = new System.Drawing.Size(95, 13);
            this.LblParamTypeTarget.TabIndex = 11;
            this.LblParamTypeTarget.Text = "(param type target)";
            // 
            // RbtSourceParam
            // 
            this.RbtSourceParam.AutoSize = true;
            this.RbtSourceParam.Checked = true;
            this.RbtSourceParam.Location = new System.Drawing.Point(10, 15);
            this.RbtSourceParam.Name = "RbtSourceParam";
            this.RbtSourceParam.Size = new System.Drawing.Size(143, 17);
            this.RbtSourceParam.TabIndex = 12;
            this.RbtSourceParam.TabStop = true;
            this.RbtSourceParam.Text = "Select Source Parameter";
            this.RbtSourceParam.UseVisualStyleBackColor = true;
            this.RbtSourceParam.CheckedChanged += new System.EventHandler(this.RbtSourceParam_CheckedChanged);
            // 
            // RbtElementId
            // 
            this.RbtElementId.AutoSize = true;
            this.RbtElementId.Location = new System.Drawing.Point(265, 15);
            this.RbtElementId.Name = "RbtElementId";
            this.RbtElementId.Size = new System.Drawing.Size(87, 17);
            this.RbtElementId.TabIndex = 13;
            this.RbtElementId.TabStop = true;
            this.RbtElementId.Text = "or Element Id";
            this.RbtElementId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(30, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type of Parameter:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxSourceParameters);
            this.groupBox1.Controls.Add(this.LblTypeParameter);
            this.groupBox1.Controls.Add(this.RbtSourceParam);
            this.groupBox1.Controls.Add(this.LblParamTypeSource);
            this.groupBox1.Controls.Add(this.RbtElementId);
            this.groupBox1.Location = new System.Drawing.Point(20, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 90);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblTargetParam);
            this.groupBox2.Location = new System.Drawing.Point(20, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 90);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CbxCategories);
            this.groupBox3.Location = new System.Drawing.Point(20, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 80);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Transfer parameter data to selected parameter:";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(429, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblParamTypeTarget);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.CbxTargetParameters);
            this.Controls.Add(this.RbtAsNumber);
            this.Controls.Add(this.RbtAsText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameter Mapper";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbxCategories;
        private System.Windows.Forms.ComboBox CbxSourceParameters;
        private System.Windows.Forms.ComboBox CbxTargetParameters;
        private System.Windows.Forms.Label LblTargetParam;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.RadioButton RbtAsNumber;
        private System.Windows.Forms.RadioButton RbtAsText;
        private System.Windows.Forms.Label LblTypeParameter;
        private System.Windows.Forms.Label LblParamTypeSource;
        private System.Windows.Forms.Label LblParamTypeTarget;
        private System.Windows.Forms.RadioButton RbtSourceParam;
        private System.Windows.Forms.RadioButton RbtElementId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}