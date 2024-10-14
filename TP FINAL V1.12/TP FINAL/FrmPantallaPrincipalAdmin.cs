using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL
{
    public partial class FrmPantallaPrincipalAdmin : Form

    {

        Conexion conexion = new Conexion();
        public FrmPantallaPrincipalAdmin()
        {
            InitializeComponent();
            CargarUsuarios();
        }





        private void CargarUsuarios()
        {
            try
            {
                string sSql = "SELECT NombreCompleto, Apellido, Email,NivelUsuario FROM Registro";
                DataTable dt = new DataTable();

                using (OleDbDataAdapter da = new OleDbDataAdapter(sSql, conexion.AbrirConexion()))
                {
                    da.Fill(dt);
                }
                dgvUsuarios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuario: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }





        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpPersonaSeleccionada_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPersonalizado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios.DataSource = null;
            CargarUsuarios();
        }

        private void FrmPantallaPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
