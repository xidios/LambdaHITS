
namespace LambdaHITS
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
            this.lambda1Num = new System.Windows.Forms.NumericUpDown();
            this.lambda2Num = new System.Windows.Forms.NumericUpDown();
            this.nNum = new System.Windows.Forms.NumericUpDown();
            this.tNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelFlow1 = new System.Windows.Forms.Label();
            this.labelFlow2 = new System.Windows.Forms.Label();
            this.labelFlow1plus2 = new System.Windows.Forms.Label();
            this.labelFlow1and2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lambda1Num
            // 
            this.lambda1Num.Location = new System.Drawing.Point(11, 42);
            this.lambda1Num.Margin = new System.Windows.Forms.Padding(2);
            this.lambda1Num.Name = "lambda1Num";
            this.lambda1Num.Size = new System.Drawing.Size(90, 20);
            this.lambda1Num.TabIndex = 2;
            this.lambda1Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lambda2Num
            // 
            this.lambda2Num.Location = new System.Drawing.Point(132, 42);
            this.lambda2Num.Margin = new System.Windows.Forms.Padding(2);
            this.lambda2Num.Name = "lambda2Num";
            this.lambda2Num.Size = new System.Drawing.Size(90, 20);
            this.lambda2Num.TabIndex = 3;
            this.lambda2Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nNum
            // 
            this.nNum.Location = new System.Drawing.Point(11, 112);
            this.nNum.Margin = new System.Windows.Forms.Padding(2);
            this.nNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nNum.Name = "nNum";
            this.nNum.Size = new System.Drawing.Size(90, 20);
            this.nNum.TabIndex = 4;
            this.nNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tNum
            // 
            this.tNum.DecimalPlaces = 3;
            this.tNum.Location = new System.Drawing.Point(132, 112);
            this.tNum.Margin = new System.Windows.Forms.Padding(2);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(90, 20);
            this.tNum.TabIndex = 5;
            this.tNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lambda1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lambda2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "T";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(11, 167);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(298, 58);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelFlow1
            // 
            this.labelFlow1.AutoSize = true;
            this.labelFlow1.Location = new System.Drawing.Point(346, 17);
            this.labelFlow1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlow1.Name = "labelFlow1";
            this.labelFlow1.Size = new System.Drawing.Size(47, 13);
            this.labelFlow1.TabIndex = 11;
            this.labelFlow1.Text = "FLOW 1";
            // 
            // labelFlow2
            // 
            this.labelFlow2.AutoSize = true;
            this.labelFlow2.Location = new System.Drawing.Point(437, 17);
            this.labelFlow2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlow2.Name = "labelFlow2";
            this.labelFlow2.Size = new System.Drawing.Size(47, 13);
            this.labelFlow2.TabIndex = 12;
            this.labelFlow2.Text = "FLOW 2";
            // 
            // labelFlow1plus2
            // 
            this.labelFlow1plus2.AutoSize = true;
            this.labelFlow1plus2.Location = new System.Drawing.Point(519, 17);
            this.labelFlow1plus2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlow1plus2.Name = "labelFlow1plus2";
            this.labelFlow1plus2.Size = new System.Drawing.Size(65, 13);
            this.labelFlow1plus2.TabIndex = 13;
            this.labelFlow1plus2.Text = "FLOW 1 + 2";
            // 
            // labelFlow1and2
            // 
            this.labelFlow1and2.AutoSize = true;
            this.labelFlow1and2.Location = new System.Drawing.Point(606, 17);
            this.labelFlow1and2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFlow1and2.Name = "labelFlow1and2";
            this.labelFlow1and2.Size = new System.Drawing.Size(65, 13);
            this.labelFlow1and2.TabIndex = 14;
            this.labelFlow1and2.Text = "FLOW 1 && 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 231);
            this.Controls.Add(this.labelFlow1and2);
            this.Controls.Add(this.labelFlow1plus2);
            this.Controls.Add(this.labelFlow2);
            this.Controls.Add(this.labelFlow1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNum);
            this.Controls.Add(this.nNum);
            this.Controls.Add(this.lambda2Num);
            this.Controls.Add(this.lambda1Num);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lambda1Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown lambda1Num;
        private System.Windows.Forms.NumericUpDown lambda2Num;
        private System.Windows.Forms.NumericUpDown nNum;
        private System.Windows.Forms.NumericUpDown tNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelFlow1;
        private System.Windows.Forms.Label labelFlow2;
        private System.Windows.Forms.Label labelFlow1plus2;
        private System.Windows.Forms.Label labelFlow1and2;
    }
}

