using System;
using System.Windows.Forms;

namespace MachineCodeProject.ViewForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonTranlate_Click(object sender, EventArgs e)
        {
            MachineCodeClass mc = new MachineCodeClass();
        }
    }
}
