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
                    throw new ArgumentException("Переводимое число не может быть пустым или равно null.", nameof(textBoxNumeric.Text));
    
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
    }
}
