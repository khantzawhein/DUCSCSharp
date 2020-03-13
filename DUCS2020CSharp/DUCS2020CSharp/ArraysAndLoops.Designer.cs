namespace DUCS2020CSharp
{
    partial class ArraysAndLoops
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
            this.btnArrOne = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStringArr = new System.Windows.Forms.Button();
            this.btnTwoDimen = new System.Windows.Forms.Button();
            this.btnTimesTable = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnArrOne
            // 
            this.btnArrOne.Location = new System.Drawing.Point(26, 24);
            this.btnArrOne.Name = "btnArrOne";
            this.btnArrOne.Size = new System.Drawing.Size(135, 31);
            this.btnArrOne.TabIndex = 0;
            this.btnArrOne.Text = "Array One";
            this.btnArrOne.UseVisualStyleBackColor = true;
            this.btnArrOne.Click += new System.EventHandler(this.btnArrOne_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(26, 61);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(135, 31);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.Text = "Using Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 30);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set the Array Size at Run Time : ";
            // 
            // btnStringArr
            // 
            this.btnStringArr.Location = new System.Drawing.Point(26, 267);
            this.btnStringArr.Name = "btnStringArr";
            this.btnStringArr.Size = new System.Drawing.Size(235, 31);
            this.btnStringArr.TabIndex = 4;
            this.btnStringArr.Text = "String Arrays";
            this.btnStringArr.UseVisualStyleBackColor = true;
            this.btnStringArr.Click += new System.EventHandler(this.btnStringArr_Click);
            // 
            // btnTwoDimen
            // 
            this.btnTwoDimen.Location = new System.Drawing.Point(26, 222);
            this.btnTwoDimen.Name = "btnTwoDimen";
            this.btnTwoDimen.Size = new System.Drawing.Size(235, 31);
            this.btnTwoDimen.TabIndex = 5;
            this.btnTwoDimen.Text = "2-DimensionalArray";
            this.btnTwoDimen.UseVisualStyleBackColor = true;
            this.btnTwoDimen.Click += new System.EventHandler(this.btnTwoDimen_Click);
            // 
            // btnTimesTable
            // 
            this.btnTimesTable.Location = new System.Drawing.Point(26, 177);
            this.btnTimesTable.Name = "btnTimesTable";
            this.btnTimesTable.Size = new System.Drawing.Size(235, 31);
            this.btnTimesTable.TabIndex = 6;
            this.btnTimesTable.Text = "Exercise:  Times Table";
            this.btnTimesTable.UseVisualStyleBackColor = true;
            this.btnTimesTable.Click += new System.EventHandler(this.btnTimesTable_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(307, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 316);
            this.listBox1.TabIndex = 7;
            // 
            // ArraysAndLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 414);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTimesTable);
            this.Controls.Add(this.btnTwoDimen);
            this.Controls.Add(this.btnStringArr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnArrOne);
            this.Name = "ArraysAndLoops";
            this.Text = "ArraysAndLoops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArrOne;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStringArr;
        private System.Windows.Forms.Button btnTwoDimen;
        private System.Windows.Forms.Button btnTimesTable;
        private System.Windows.Forms.ListBox listBox1;
    }
}