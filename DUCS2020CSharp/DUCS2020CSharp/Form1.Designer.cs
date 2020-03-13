namespace DUCS2020CSharp
{
    partial class Form1
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
            this.BtnMultiplyTable = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnMenuBarEx = new System.Windows.Forms.Button();
            this.btnCalculateTwoNum = new System.Windows.Forms.Button();
            this.btnArrandLoops = new System.Windows.Forms.Button();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMultiplyTable
            // 
            this.BtnMultiplyTable.Location = new System.Drawing.Point(48, 40);
            this.BtnMultiplyTable.Name = "BtnMultiplyTable";
            this.BtnMultiplyTable.Size = new System.Drawing.Size(165, 45);
            this.BtnMultiplyTable.TabIndex = 0;
            this.BtnMultiplyTable.Text = "Multiply Table";
            this.BtnMultiplyTable.UseVisualStyleBackColor = true;
            this.BtnMultiplyTable.Click += new System.EventHandler(this.BtnMultiplyTable_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(48, 96);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(165, 45);
            this.btnCalculator.TabIndex = 1;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnMenuBarEx
            // 
            this.btnMenuBarEx.Location = new System.Drawing.Point(48, 152);
            this.btnMenuBarEx.Name = "btnMenuBarEx";
            this.btnMenuBarEx.Size = new System.Drawing.Size(165, 45);
            this.btnMenuBarEx.TabIndex = 2;
            this.btnMenuBarEx.Text = "Adding Menus";
            this.btnMenuBarEx.UseVisualStyleBackColor = true;
            this.btnMenuBarEx.Click += new System.EventHandler(this.btnMenuBarEx_Click);
            // 
            // btnCalculateTwoNum
            // 
            this.btnCalculateTwoNum.Location = new System.Drawing.Point(48, 208);
            this.btnCalculateTwoNum.Name = "btnCalculateTwoNum";
            this.btnCalculateTwoNum.Size = new System.Drawing.Size(165, 45);
            this.btnCalculateTwoNum.TabIndex = 3;
            this.btnCalculateTwoNum.Text = "CalculateTwoNum";
            this.btnCalculateTwoNum.UseVisualStyleBackColor = true;
            this.btnCalculateTwoNum.Click += new System.EventHandler(this.btnCalculateTwoNum_Click);
            // 
            // btnArrandLoops
            // 
            this.btnArrandLoops.Location = new System.Drawing.Point(48, 264);
            this.btnArrandLoops.Name = "btnArrandLoops";
            this.btnArrandLoops.Size = new System.Drawing.Size(165, 45);
            this.btnArrandLoops.TabIndex = 4;
            this.btnArrandLoops.Text = "ArraysAndLoops";
            this.btnArrandLoops.UseVisualStyleBackColor = true;
            this.btnArrandLoops.Click += new System.EventHandler(this.btnArrandLoops_Click);
            // 
            // btnUserForm
            // 
            this.btnUserForm.Location = new System.Drawing.Point(250, 40);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(165, 45);
            this.btnUserForm.TabIndex = 5;
            this.btnUserForm.Text = "User Form";
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.btnArrandLoops);
            this.Controls.Add(this.btnCalculateTwoNum);
            this.Controls.Add(this.btnMenuBarEx);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.BtnMultiplyTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMultiplyTable;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnMenuBarEx;
        private System.Windows.Forms.Button btnCalculateTwoNum;
        private System.Windows.Forms.Button btnArrandLoops;
        private System.Windows.Forms.Button btnUserForm;
    }
}

