
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
            this.SuspendLayout();
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(466, 44);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(137, 30);
            this.buttonTranslate.TabIndex = 0;
            this.buttonTranslate.Text = "Перевести";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(466, 151);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(137, 58);
            this.buttonCopyResult.TabIndex = 1;
            this.buttonCopyResult.Text = "Копировать результат";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            this.buttonCopyResult.Click += new System.EventHandler(this.buttonCopyResult_Click);
            // 
            // textBoxNumeric
            // 
            this.textBoxNumeric.Location = new System.Drawing.Point(264, 44);
            this.textBoxNumeric.Name = "textBoxNumeric";
            this.textBoxNumeric.Size = new System.Drawing.Size(160, 30);
            this.textBoxNumeric.TabIndex = 2;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 151);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(412, 430);
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
            this.labelToResultTB.Location = new System.Drawing.Point(12, 111);
            this.labelToResultTB.Name = "labelToResultTB";
            this.labelToResultTB.Size = new System.Drawing.Size(170, 23);
            this.labelToResultTB.TabIndex = 5;
            this.labelToResultTB.Text = "Результат перевода:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 593);
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
    }
}

