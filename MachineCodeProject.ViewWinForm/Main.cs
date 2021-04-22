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

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNumeric.Text))
                    throw new ArgumentException("Переводимое число не может быть пустым или равно null.", nameof(textBoxNumeric));
    
                MachineCodeClass mc = TranslateInCode.TranslateNumericInMachineCode(Int32.Parse(textBoxNumeric.Text));

                richTextBoxResult.Text = mc.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void buttonCopyResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxResult.Text);
        }

        private void buttonTranslateRandom_Click(object sender, EventArgs e)
        {
            try
            {
                #region Проверка на ошибки
                if (string.IsNullOrWhiteSpace(textBoxRandomCount.Text))
                    throw new ArgumentNullException("Поле \"Введите количество чисел\" должно быть заполнено.", nameof(textBoxRandomCount));

                if (Convert.ToInt32(textBoxRandomCount.Text) > 200)
                    throw new ArgumentException("Число в поле \"Введите количество чисел\" должно быть меньше 201.", nameof(textBoxRandomCount));
                #endregion

                richTextBoxResult.Clear();
                Random rnd = new Random();
                MachineCodeClass mc;
                for (int i = 0; i < Convert.ToInt32(textBoxRandomCount.Text); i++)
                {
                    mc = TranslateInCode.TranslateNumericInMachineCode(rnd.Next(-100, 100));
                    richTextBoxResult.Text += mc.ToString() + "\n\n";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
