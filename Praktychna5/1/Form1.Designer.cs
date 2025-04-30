namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelUsd = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelResultText = new System.Windows.Forms.Label();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelUsd
            this.labelUsd.AutoSize = true;
            this.labelUsd.Location = new System.Drawing.Point(20, 30);
            this.labelUsd.Name = "labelUsd";
            this.labelUsd.Size = new System.Drawing.Size(70, 13);
            this.labelUsd.TabIndex = 0;
            this.labelUsd.Text = "Ціна (USD):";

            // labelCourse
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(20, 60);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(95, 13);
            this.labelCourse.TabIndex = 1;
            this.labelCourse.Text = "Курс (UAH/USD):";

            // labelResultText
            this.labelResultText.AutoSize = true;
            this.labelResultText.Location = new System.Drawing.Point(20, 90);
            this.labelResultText.Name = "labelResultText";
            this.labelResultText.Size = new System.Drawing.Size(70, 13);
            this.labelResultText.TabIndex = 2;
            this.labelResultText.Text = "Ціна (UAH):";

            // textBoxUSD
            this.textBoxUSD.Location = new System.Drawing.Point(120, 27);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxUSD.TabIndex = 3;

            // textBoxCourse
            this.textBoxCourse.Location = new System.Drawing.Point(120, 57);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourse.TabIndex = 4;

            // labelResult
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(120, 90);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "0,00 ₴";

            // buttonCalculate
            this.buttonCalculate.Location = new System.Drawing.Point(120, 120);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            // buttonExit
            this.buttonExit.Location = new System.Drawing.Point(120, 150);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Вийти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 190);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.labelResultText);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelUsd);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelUsd;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelResultText;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
    }
}