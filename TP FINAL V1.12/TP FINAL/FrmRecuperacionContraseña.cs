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
    public partial class FrmRecuperacionContraseña : Form
    {
        Usuario user = new Usuario();   
        public FrmRecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void FrmRecuperacionContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarRecuperoContraseña_Click(object sender, EventArgs e)
        {
            string IngresoEmail = tbIngreseEmail.Text;
            string CodigoEnviado = tbCodigoEnviadoEmail.Text;
            string NuevaContraseña = tbNuevaContraseña.Text;
            string ConfirmarContraseña = tbConfirmarContraseña.Text;
            
            
            if (string.IsNullOrEmpty(IngresoEmail) || (string.IsNullOrEmpty(NuevaContraseña))
                || string.IsNullOrEmpty(CodigoEnviado) || string.IsNullOrEmpty(ConfirmarContraseña)) 
            {
                MessageBox.Show("Los campos estan vacios");
                return;
            }

            



            if (NuevaContraseña != ConfirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }





            else if (user.CambiarContraseña(IngresoEmail, CodigoEnviado, NuevaContraseña))
            {
                MessageBox.Show("Se ha cambiado la contraseña correctamente");
                FrmLogin ventana = new FrmLogin();
                ventana.ShowDialog();
            }
        
        
        
        }

        private void tbNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            tbNuevaContraseña.PasswordChar = '*';
        }

        private void tbConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            tbConfirmarContraseña.PasswordChar = '*';
        }

        private void btnObtenerCodigo_Click(object sender, EventArgs e)
        {
            string correo = tbIngreseEmail.Text;
            MessageBox.Show($"El codigo de recuperacion es: {user.GenerarCodigoRecuperacion(correo)}");
             



        }

        private void tbIngreseEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
