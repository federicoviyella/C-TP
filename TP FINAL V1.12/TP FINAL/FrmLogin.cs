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
    public partial class FrmLogin : Form
    {
        Usuario usuario = new Usuario();
        Administrador administrador = new Administrador();
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            FrmRecuperacionContraseña ventana = new FrmRecuperacionContraseña();
            ventana.ShowDialog();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse ventana = new FrmRegistrarse();
            ventana.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)  /////////BTNINICIARSESION//////////
        {

            string correo = tbEmailUsuarioLogin.Text;
            string contraseña = tbContraseñaLogin.Text;

          

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor ingrese todos los campos.");
                return;
            }

            if (usuario.Login(correo, contraseña))
            {


                MessageBox.Show("Inicio de sesión exitoso.");

                string rol = usuario.ObtenerNivelUsuario(correo);
                if (rol == "Administrador")
                {
                    FrmPantallaPrincipalAdmin ventana = new FrmPantallaPrincipalAdmin();
                    ventana.ShowDialog();

                }
                else
                {
                    FrmPantallaPrincipal ventana = new FrmPantallaPrincipal();
                    ventana.ShowDialog();

                }




            }

            else
            {
                
                MessageBox.Show("Datos incorrectos, intente de vuelta");
                

            }



            


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseñaLogin_TextChanged(object sender, EventArgs e)
        {
            tbContraseñaLogin.PasswordChar = '*';
        }

        private void tbEmailUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
