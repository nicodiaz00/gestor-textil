using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }
        private void loginAdmin()
        {
            AdminNegocio adminNegocio = new AdminNegocio();
            string passHash = Helper.Helper.ComputeSha256Hash(txtPassLogin.Text);
            Admin admin = adminNegocio.Login(TxtEmailLogin.Text, passHash);
            if ( admin !=null)
            {
                Sesion.AdminLogeado = admin;
                this.DialogResult = DialogResult.OK;
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos. Intente nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegisterAdmin registerForm = new FrmRegisterAdmin();
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginAdmin();
        }
    }
}
