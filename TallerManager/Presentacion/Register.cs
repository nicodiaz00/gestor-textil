using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmRegisterAdmin : Form
    {
        public FrmRegisterAdmin()
        {
            InitializeComponent();
        }
        private void ejecutarRegistro()
        {
            if (string.IsNullOrEmpty(txtNameRegister.Text) || string.IsNullOrEmpty(txtEmailRegister.Text) || string.IsNullOrEmpty(txtPassRegister.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassRegister.Text != txtRepeatPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string passwordHash = Helper.Helper.ComputeSha256Hash(txtPassRegister.Text);
                AdminNegocio adminNegocio = new AdminNegocio();
                adminNegocio.RegistrarAdmin(txtNameRegister.Text, txtEmailRegister.Text, passwordHash);
                MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptRegister_Click(object sender, EventArgs e)
        {
            ejecutarRegistro();
        }
    }
}
