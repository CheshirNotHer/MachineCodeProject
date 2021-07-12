
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.TranslateCode = new System.Windows.Forms.TabPage();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.buttonSaveToTXT = new System.Windows.Forms.Button();
            this.buttonClearTBResult = new System.Windows.Forms.Button();
            this.buttonTranslateRandom = new System.Windows.Forms.Button();
            this.textBoxRandomCount = new System.Windows.Forms.TextBox();
            this.labelToRandomTB = new System.Windows.Forms.Label();
            this.labelToResultTB = new System.Windows.Forms.Label();
            this.labelToTranslateTB = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.textBoxNumeric = new System.Windows.Forms.TextBox();
            this.buttonCopyResult = new System.Windows.Forms.Button();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.MathOperation = new System.Windows.Forms.TabPage();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.richTextBoxCalculateResult = new System.Windows.Forms.RichTextBox();
            this.dataGridViewOperation = new System.Windows.Forms.DataGridView();
            this.FirstNumeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNumeric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControlMain.SuspendLayout();
            this.TranslateCode.SuspendLayout();
            this.MathOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.TranslateCode);
            this.tabControlMain.Controls.Add(this.MathOperation);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1043, 624);
            this.tabControlMain.TabIndex = 11;
            // 
            // TranslateCode
            // 
            this.TranslateCode.Controls.Add(this.labelTo);
            this.TranslateCode.Controls.Add(this.labelFrom);
            this.TranslateCode.Controls.Add(this.textBoxTo);
            this.TranslateCode.Controls.Add(this.textBoxFrom);
            this.TranslateCode.Controls.Add(this.buttonSaveToTXT);
            this.TranslateCode.Controls.Add(this.buttonClearTBResult);
            this.TranslateCode.Controls.Add(this.buttonTranslateRandom);
            this.TranslateCode.Controls.Add(this.textBoxRandomCount);
            this.TranslateCode.Controls.Add(this.labelToRandomTB);
            this.TranslateCode.Controls.Add(this.labelToResultTB);
            this.TranslateCode.Controls.Add(this.labelToTranslateTB);
            this.TranslateCode.Controls.Add(this.richTextBoxResult);
            this.TranslateCode.Controls.Add(this.textBoxNumeric);
            this.TranslateCode.Controls.Add(this.buttonCopyResult);
            this.TranslateCode.Controls.Add(this.buttonTranslate);
            this.TranslateCode.Location = new System.Drawing.Point(4, 32);
            this.TranslateCode.Name = "TranslateCode";
            this.TranslateCode.Padding = new System.Windows.Forms.Padding(3);
            this.TranslateCode.Size = new System.Drawing.Size(1035, 588);
            this.TranslateCode.TabIndex = 0;
            this.TranslateCode.Text = "Перевод чисел";
            this.TranslateCode.UseVisualStyleBackColor = true;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(180, 237);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(36, 23);
            this.labelTo.TabIndex = 25;
            this.labelTo.Text = "До:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(29, 237);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(34, 23);
            this.labelFrom.TabIndex = 24;
            this.labelFrom.Text = "От:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(180, 263);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(125, 30);
            this.textBoxTo.TabIndex = 23;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(29, 263);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(125, 30);
            this.textBoxFrom.TabIndex = 22;
            // 
            // buttonSaveToTXT
            // 
            this.buttonSaveToTXT.Location = new System.Drawing.Point(75, 444);
            this.buttonSaveToTXT.Name = "buttonSaveToTXT";
            this.buttonSaveToTXT.Size = new System.Drawing.Size(166, 47);
            this.buttonSaveToTXT.TabIndex = 21;
            this.buttonSaveToTXT.TabStop = false;
            this.buttonSaveToTXT.Text = "Save";
            this.buttonSaveToTXT.UseVisualStyleBackColor = true;
            this.buttonSaveToTXT.Click += new System.EventHandler(this.buttonSaveToTXT_Click);
            // 
            // buttonClearTBResult
            // 
            this.buttonClearTBResult.Location = new System.Drawing.Point(579, 8);
            this.buttonClearTBResult.Name = "buttonClearTBResult";
            this.buttonClearTBResult.Size = new System.Drawing.Size(190, 29);
            this.buttonClearTBResult.TabIndex = 20;
            this.buttonClearTBResult.Text = "Очистить";
            this.buttonClearTBResult.UseVisualStyleBackColor = true;
            this.buttonClearTBResult.Click += new System.EventHandler(this.buttonClearTBResult_Click);
            // 
            // buttonTranslateRandom
            // 
            this.buttonTranslateRandom.Location = new System.Drawing.Point(29, 299);
            this.buttonTranslateRandom.Name = "buttonTranslateRandom";
            this.buttonTranslateRandom.Size = new System.Drawing.Size(276, 30);
            this.buttonTranslateRandom.TabIndex = 19;
            this.buttonTranslateRandom.Text = "Перевести числа";
            this.buttonTranslateRandom.UseVisualStyleBackColor = true;
            this.buttonTranslateRandom.Click += new System.EventHandler(this.buttonTranslateRandom_Click);
            // 
            // textBoxRandomCount
            // 
            this.textBoxRandomCount.Location = new System.Drawing.Point(29, 197);
            this.textBoxRandomCount.Name = "textBoxRandomCount";
            this.textBoxRandomCount.Size = new System.Drawing.Size(276, 30);
            this.textBoxRandomCount.TabIndex = 18;
            // 
            // labelToRandomTB
            // 
            this.labelToRandomTB.AutoSize = true;
            this.labelToRandomTB.Location = new System.Drawing.Point(29, 171);
            this.labelToRandomTB.Name = "labelToRandomTB";
            this.labelToRandomTB.Size = new System.Drawing.Size(276, 23);
            this.labelToRandomTB.TabIndex = 17;
            this.labelToRandomTB.Text = "Введите количество чисел(<201):";
            // 
            // labelToResultTB
            // 
            this.labelToResultTB.AutoSize = true;
            this.labelToResultTB.Location = new System.Drawing.Point(357, 15);
            this.labelToResultTB.Name = "labelToResultTB";
            this.labelToResultTB.Size = new System.Drawing.Size(170, 23);
            this.labelToResultTB.TabIndex = 16;
            this.labelToResultTB.Text = "Результат перевода:";
            // 
            // labelToTranslateTB
            // 
            this.labelToTranslateTB.AutoSize = true;
            this.labelToTranslateTB.Location = new System.Drawing.Point(29, 15);
            this.labelToTranslateTB.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelToTranslateTB.Name = "labelToTranslateTB";
            this.labelToTranslateTB.Size = new System.Drawing.Size(282, 46);
            this.labelToTranslateTB.TabIndex = 15;
            this.labelToTranslateTB.Text = "Введите число для перевода или несколько через пробелы: ";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(357, 51);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(412, 527);
            this.richTextBoxResult.TabIndex = 14;
            this.richTextBoxResult.Text = "";
            // 
            // textBoxNumeric
            // 
            this.textBoxNumeric.Location = new System.Drawing.Point(29, 67);
            this.textBoxNumeric.Name = "textBoxNumeric";
            this.textBoxNumeric.Size = new System.Drawing.Size(246, 30);
            this.textBoxNumeric.TabIndex = 13;
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(29, 362);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(276, 58);
            this.buttonCopyResult.TabIndex = 12;
            this.buttonCopyResult.Text = "Копировать результаты";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            this.buttonCopyResult.Click += new System.EventHandler(this.buttonCopyResult_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(29, 103);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(246, 30);
            this.buttonTranslate.TabIndex = 11;
            this.buttonTranslate.Text = "Перевести";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // MathOperation
            // 
            this.MathOperation.Controls.Add(this.splitter1);
            this.MathOperation.Controls.Add(this.buttonCalculate);
            this.MathOperation.Controls.Add(this.richTextBoxCalculateResult);
            this.MathOperation.Controls.Add(this.dataGridViewOperation);
            this.MathOperation.Location = new System.Drawing.Point(4, 32);
            this.MathOperation.Name = "MathOperation";
            this.MathOperation.Padding = new System.Windows.Forms.Padding(3);
            this.MathOperation.Size = new System.Drawing.Size(1035, 588);
            this.MathOperation.TabIndex = 1;
            this.MathOperation.Text = "Матемтические операции";
            this.MathOperation.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(442, 14);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(115, 37);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Посчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // richTextBoxCalculateResult
            // 
            this.richTextBoxCalculateResult.Location = new System.Drawing.Point(442, 69);
            this.richTextBoxCalculateResult.Name = "richTextBoxCalculateResult";
            this.richTextBoxCalculateResult.Size = new System.Drawing.Size(585, 511);
            this.richTextBoxCalculateResult.TabIndex = 1;
            this.richTextBoxCalculateResult.Text = "";
            // 
            // dataGridViewOperation
            // 
            this.dataGridViewOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNumeric,
            this.Operation,
            this.LastNumeric});
            this.dataGridViewOperation.Location = new System.Drawing.Point(8, 14);
            this.dataGridViewOperation.Name = "dataGridViewOperation";
            this.dataGridViewOperation.RowHeadersWidth = 51;
            this.dataGridViewOperation.RowTemplate.Height = 29;
            this.dataGridViewOperation.Size = new System.Drawing.Size(428, 566);
            this.dataGridViewOperation.TabIndex = 0;
            // 
            // FirstNumeric
            // 
            this.FirstNumeric.HeaderText = "число 1";
            this.FirstNumeric.MinimumWidth = 6;
            this.FirstNumeric.Name = "FirstNumeric";
            this.FirstNumeric.Width = 125;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Операция";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.Width = 125;
            // 
            // LastNumeric
            // 
            this.LastNumeric.HeaderText = "число 2";
            this.LastNumeric.MinimumWidth = 6;
            this.LastNumeric.Name = "LastNumeric";
            this.LastNumeric.Width = 125;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 582);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 624);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Text = "Перевод числа в машинный код.";
            this.tabControlMain.ResumeLayout(false);
            this.TranslateCode.ResumeLayout(false);
            this.TranslateCode.PerformLayout();
            this.MathOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage TranslateCode;
        private System.Windows.Forms.Button buttonSaveToTXT;
        private System.Windows.Forms.Button buttonClearTBResult;
        private System.Windows.Forms.Button buttonTranslateRandom;
        private System.Windows.Forms.TextBox textBoxRandomCount;
        private System.Windows.Forms.Label labelToRandomTB;
        private System.Windows.Forms.Label labelToResultTB;
        private System.Windows.Forms.Label labelToTranslateTB;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.TextBox textBoxNumeric;
        private System.Windows.Forms.Button buttonCopyResult;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.TabPage MathOperation;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.DataGridView dataGridViewOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNumeric;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNumeric;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RichTextBox richTextBoxCalculateResult;
        private System.Windows.Forms.Splitter splitter1;
    }
}

