
namespace MachineCodeProject.ViewForm
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTranslateNumeric = new System.Windows.Forms.TextBox();
            this.labelToTextBox = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelToTranslResult = new System.Windows.Forms.Label();
            this.buttonTranlate = new System.Windows.Forms.Button();
            this.buttonCopyResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTranslateNumeric
            // 
            this.textBoxTranslateNumeric.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranslateNumeric.Location = new System.Drawing.Point(310, 64);
            this.textBoxTranslateNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTranslateNumeric.Name = "textBoxTranslateNumeric";
            this.textBoxTranslateNumeric.Size = new System.Drawing.Size(152, 30);
            this.textBoxTranslateNumeric.TabIndex = 0;
            this.textBoxTranslateNumeric.Text = "*число*";
            // 
            // labelToTextBox
            // 
            this.labelToTextBox.AutoSize = true;
            this.labelToTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToTextBox.Location = new System.Drawing.Point(15, 68);
            this.labelToTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToTextBox.Name = "labelToTextBox";
            this.labelToTextBox.Size = new System.Drawing.Size(246, 23);
            this.labelToTextBox.TabIndex = 1;
            this.labelToTextBox.Text = "Введите число для перевода:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 164);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 415);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // labelToTranslResult
            // 
            this.labelToTranslResult.AutoSize = true;
            this.labelToTranslResult.Location = new System.Drawing.Point(16, 127);
            this.labelToTranslResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToTranslResult.Name = "labelToTranslResult";
            this.labelToTranslResult.Size = new System.Drawing.Size(170, 23);
            this.labelToTranslResult.TabIndex = 3;
            this.labelToTranslResult.Text = "Результат перевода:\r\n";
            // 
            // buttonTranlate
            // 
            this.buttonTranlate.Location = new System.Drawing.Point(522, 57);
            this.buttonTranlate.Name = "buttonTranlate";
            this.buttonTranlate.Size = new System.Drawing.Size(145, 37);
            this.buttonTranlate.TabIndex = 4;
            this.buttonTranlate.Text = "Перевести";
            this.buttonTranlate.UseVisualStyleBackColor = true;
            this.buttonTranlate.Click += new System.EventHandler(this.buttonTranlate_Click);
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(478, 164);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(235, 50);
            this.buttonCopyResult.TabIndex = 5;
            this.buttonCopyResult.Text = "Копировать результат.";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 609);
            this.Controls.Add(this.buttonCopyResult);
            this.Controls.Add(this.buttonTranlate);
            this.Controls.Add(this.labelToTranslResult);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelToTextBox);
            this.Controls.Add(this.textBoxTranslateNumeric);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Перевод в машинный код";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTranslateNumeric;
        private System.Windows.Forms.Label labelToTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelToTranslResult;
        private System.Windows.Forms.Button buttonTranlate;
        private System.Windows.Forms.Button buttonCopyResult;
    }
}

