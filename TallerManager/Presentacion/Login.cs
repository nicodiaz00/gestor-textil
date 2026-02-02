using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegisterAdmin registerForm = new FrmRegisterAdmin();
            registerForm.ShowDialog();
        }
    }
}
