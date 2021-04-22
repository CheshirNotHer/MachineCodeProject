
namespace MachineCodeProject.ViewWinForm
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.buttonCopyResult = new System.Windows.Forms.Button();
            this.textBoxNumeric = new System.Windows.Forms.TextBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.labelToTranslateTB = new System.Windows.Forms.Label();
            this.labelToResultTB = new System.Windows.Forms.Label();
            this.labelToRandomTB = new System.Windows.Forms.Label();
            this.textBoxRandomCount = new System.Windows.Forms.TextBox();
            this.buttonTranslateRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(12, 106);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(246, 30);
            this.buttonTranslate.TabIndex = 0;
            this.buttonTranslate.Text = "Перевести";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(12, 325);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(276, 58);
            this.buttonCopyResult.TabIndex = 1;
            this.buttonCopyResult.Text = "Копировать результаты";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            this.buttonCopyResult.Click += new System.EventHandler(this.buttonCopyResult_Click);
            // 
            // textBoxNumeric
            // 
            this.textBoxNumeric.Location = new System.Drawing.Point(12, 70);
            this.textBoxNumeric.Name = "textBoxNumeric";
            this.textBoxNumeric.Size = new System.Drawing.Size(246, 30);
            this.textBoxNumeric.TabIndex = 2;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(340, 54);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(412, 527);
            this.richTextBoxResult.TabIndex = 3;
            this.richTextBoxResult.Text = "";
            // 
            // labelToTranslateTB
            // 
            this.labelToTranslateTB.AutoSize = true;
            this.labelToTranslateTB.Location = new System.Drawing.Point(12, 44);
            this.labelToTranslateTB.Name = "labelToTranslateTB";
            this.labelToTranslateTB.Size = new System.Drawing.Size(246, 23);
            this.labelToTranslateTB.TabIndex = 4;
            this.labelToTranslateTB.Text = "Введите число для перевода:";
            // 
            // labelToResultTB
            // 
            this.labelToResultTB.AutoSize = true;
            this.labelToResultTB.Location = new System.Drawing.Point(340, 18);
            this.labelToResultTB.Name = "labelToResultTB";
            this.labelToResultTB.Size = new System.Drawing.Size(170, 23);
            this.labelToResultTB.TabIndex = 5;
            this.labelToResultTB.Text = "Результат перевода:";
            // 
            // labelToRandomTB
            // 
            this.labelToRandomTB.AutoSize = true;
            this.labelToRandomTB.Location = new System.Drawing.Point(12, 199);
            this.labelToRandomTB.Name = "labelToRandomTB";
            this.labelToRandomTB.Size = new System.Drawing.Size(276, 23);
            this.labelToRandomTB.TabIndex = 6;
            this.labelToRandomTB.Text = "Введите количество чисел(<201):";
            // 
            // textBoxRandomCount
            // 
            this.textBoxRandomCount.Location = new System.Drawing.Point(12, 225);
            this.textBoxRandomCount.Name = "textBoxRandomCount";
            this.textBoxRandomCount.Size = new System.Drawing.Size(276, 30);
            this.textBoxRandomCount.TabIndex = 7;
            // 
            // buttonTranslateRandom
            // 
            this.buttonTranslateRandom.Location = new System.Drawing.Point(12, 261);
            this.buttonTranslateRandom.Name = "buttonTranslateRandom";
            this.buttonTranslateRandom.Size = new System.Drawing.Size(276, 30);
            this.buttonTranslateRandom.TabIndex = 8;
            this.buttonTranslateRandom.Text = "Перевести числа";
            this.buttonTranslateRandom.UseVisualStyleBackColor = true;
            this.buttonTranslateRandom.Click += new System.EventHandler(this.buttonTranslateRandom_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 593);
            this.Controls.Add(this.buttonTranslateRandom);
            this.Controls.Add(this.textBoxRandomCount);
            this.Controls.Add(this.labelToRandomTB);
            this.Controls.Add(this.labelToResultTB);
            this.Controls.Add(this.labelToTranslateTB);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.textBoxNumeric);
            this.Controls.Add(this.buttonCopyResult);
            this.Controls.Add(this.buttonTranslate);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Text = "Перевод числа в машинный код.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Button buttonCopyResult;
        private System.Windows.Forms.TextBox textBoxNumeric;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label labelToTranslateTB;
        private System.Windows.Forms.Label labelToResultTB;
        private System.Windows.Forms.Label labelToRandomTB;
        private System.Windows.Forms.TextBox textBoxRandomCount;
        private System.Windows.Forms.Button buttonTranslateRandom;
    }
}

