using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL
{
    public partial class FrmRegistrarse : Form
    {
        Usuario usuario = new Usuario();
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        private void lblConfirmarContraseñaRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

            string NombreCompleto = tbNombreCompletoRegistrarse.Text; 
            string Apellido = tbApellidoRegistrarse.Text;
            string Email = tbEmailRegistrarse.Text;
            string Contraseña = tbConfirmarContraseñaRegistrarse.Text;

            if (string.IsNullOrEmpty(NombreCompleto) || string.IsNullOrEmpty(Apellido)
                || string.IsNullOrEmpty (Email) || string.IsNullOrEmpty(Contraseña))
            {
                MessageBox.Show("Los campos estan vacios");
            }

            if (usuario.Registrarse(NombreCompleto, Apellido, Email, Contraseña))
            {
                MessageBox.Show("Registro Exitoso.");
            }

            else
            {
                MessageBox.Show("Error al registrar");
                FrmLogin ventana = new FrmLogin();

            }



        }

        private void tbEmailRegistrarse_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void tbNombreCompletoRegistrarse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidoRegistrarse_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellidoRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailRegistrarse_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseñaRegistrarse_TextChanged(object sender, EventArgs e)
        {
            tbContraseñaRegistrarse.PasswordChar = '*';
        }

        private void tbConfirmarContraseñaRegistrarse_TextChanged(object sender, EventArgs e)
        {
            tbConfirmarContraseñaRegistrarse.PasswordChar = '*';
        }
    }
}
