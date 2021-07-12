using MachineCodeProject.BL.Model;
using MachineCodeProject.BL.Controll;
using System;
using System.Windows.Forms;

namespace MachineCodeProject.ViewWinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Перевод числа или нескольких чисел в машинный код.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNumeric.Text))
                    throw new ArgumentException("Переводимое число не может быть пустым или равно null.", nameof(textBoxNumeric));

                string[] strArr = textBoxNumeric.Text.Split(' ');
                MachineCodeClass mc;

                for (int i = 0; i < strArr.Length; i++)
                {
                    if (strArr[i] != null)
                    {
                        mc = TranslateInCode.TranslateNumericInMachineCode(Int32.Parse(strArr[i]));

                        richTextBoxResult.Text += mc.ToString()+"\n\n";
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        /// <summary>
        /// Копирование результата перевода числа в буфер.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxResult.Text);
        }

        /// <summary>
        /// Рандомит числа, количество введено в TextBox, для перевода и переводит их в машинный код. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTranslateRandom_Click(object sender, EventArgs e)
        {
            try
            {
                #region Проверка на ошибки

                if (string.IsNullOrWhiteSpace(textBoxRandomCount.Text))
                    throw new ArgumentNullException("Поле \"Введите количество чисел\" должно быть заполнено.", nameof(textBoxRandomCount));

                if (Convert.ToInt32(textBoxRandomCount.Text) > 200)
                    throw new ArgumentException("Число в поле \"Введите количество чисел\" должно быть меньше 201.", nameof(textBoxRandomCount));

                if (string.IsNullOrWhiteSpace(textBoxFrom.Text))
                    throw new ArgumentNullException("Поле не может быть пустым", nameof(textBoxFrom));

                if (string.IsNullOrWhiteSpace(textBoxTo.Text))
                    throw new ArgumentNullException("Поле не может быть пустым.", nameof(textBoxTo));

                #endregion

                richTextBoxResult.Clear();
                Random rnd = new Random();
                MachineCodeClass mc;
                for (int i = 0; i < Convert.ToInt32(textBoxRandomCount.Text); i++)
                {
                    mc = TranslateInCode.TranslateNumericInMachineCode(rnd.Next(Int32.Parse(textBoxFrom.Text), Int32.Parse(textBoxTo.Text)+1));
                    richTextBoxResult.Text += mc.ToString() + "\n\n";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        /// <summary>
        /// Удаления из richTextBox всех записей. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearTBResult_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Clear();
        }

        /// <summary>
        /// Производит сохранения файла с результатом перевод.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveToTXT_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBoxResult.Text);
            MessageBox.Show("Файл сохранен");

            //SaveMC.SaveToTxt(richTextBoxResult.Text);
        }

        /// <summary>
        /// Производит операции над введенными числами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                #region Проверка на ошибки

                if (dataGridViewOperation.Rows.Count == 1 && string.IsNullOrWhiteSpace(dataGridViewOperation.Rows[0].Cells[0].Value.ToString()))
                    throw new Exception("Таблица не должна быть пустой.");

                #endregion

                for (int i = 0; i < dataGridViewOperation.Rows.Count-1; i++)
                {
                    
              
                    switch (dataGridViewOperation.Rows[i].Cells[1].Value.ToString())
                    {
                        case "+":
                            richTextBoxCalculateResult.Text += TranslateInCode.TranslateNumericInMachineCode(
                                Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[0].Value)
                                + Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[2].Value)).ToString() + "\n\n";
                            break;

                        case "-":
                            richTextBoxCalculateResult.Text += TranslateInCode.TranslateNumericInMachineCode(
                                Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[0].Value)
                                - Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[2].Value)).ToString() + "\n\n"; 
                            break;

                        case "*":
                            richTextBoxCalculateResult.Text += TranslateInCode.TranslateNumericInMachineCode(
                                Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[0].Value)
                                * Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[2].Value)).ToString() + "\n\n"; 
                            break;

                        case "/":
                            richTextBoxCalculateResult.Text += TranslateInCode.TranslateNumericInMachineCode(
                                Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[0].Value)
                                / Convert.ToInt32(dataGridViewOperation.Rows[i].Cells[2].Value)).ToString() + "\n\n"; 
                            break;
                        default:
                            throw new Exception($"Указана не верная операция в строке {i+1}");

                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

       
    }
}
