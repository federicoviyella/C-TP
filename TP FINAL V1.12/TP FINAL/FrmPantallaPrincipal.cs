using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TP_FINAL
{
    public partial class FrmPantallaPrincipal : Form

    {
        Usuario usuario = new Usuario();
        Conexion conexion = new Conexion();


        public FrmPantallaPrincipal()
        {
            InitializeComponent();
            
            
        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblNivelUsuarioUser_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //tbUsuarioBienvenida.Text = ObtenerUsuario();
            
        }

        private void tbNivelUsuarioBienvenida_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        
        }
    }
}
