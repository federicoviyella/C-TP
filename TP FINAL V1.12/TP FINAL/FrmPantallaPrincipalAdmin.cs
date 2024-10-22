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
        Usuario usuario = new Usuario();
        Administrador administrador = new Administrador();
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
            int selectedRowIndex = dgvUsuarios.CurrentCell.RowIndex;
            dgvUsuarios.DataSource = null;
            CargarUsuarios();

            dgvUsuarios.CurrentCell = dgvUsuarios.Rows[selectedRowIndex].Cells[0];


            


        }

        private void FrmPantallaPrincipalAdmin_Load(object sender, EventArgs e)
        {
            cmbNivelUsuario.Items.Add("Usuario");
            cmbNivelUsuario.Items.Add("Administrador");
            dgvUsuarios.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            cmbNivelUsuario.Text = "Seleccione nivel de usuario";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nivelSeleccionado = cmbNivelUsuario.SelectedItem.ToString();
            string email = dgvUsuarios.SelectedRows[0].Cells["Email"].Value.ToString(); 
            

            if (nivelSeleccionado == "Usuario" || nivelSeleccionado == "Administrador")
            {
               
                administrador.ActualizarNivelUsuario(email, nivelSeleccionado);
                CargarUsuarios();
                
                


            }
            else
            {
                MessageBox.Show("Error al modificar el nivel de Usuario");
                
            }
            



        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0) 
            {
                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                txtNombre.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtNivelUsuario.Text = row.Cells["NivelUsuario"].Value.ToString();


            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("Esta seguro que desea eliminar al usuario?",

             "Advertencia",

             MessageBoxButtons.YesNoCancel,
             MessageBoxIcon.Hand,
             MessageBoxDefaultButton.Button3);

            switch (Resultado)
            {
                case DialogResult.Yes:
                    if (dgvUsuarios.SelectedRows.Count > 0)
                    {
                        string email = dgvUsuarios.SelectedRows[0].Cells["Email"].Value.ToString();
                        administrador.EliminarUsuario(email);
                        CargarUsuarios();

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar al usuario");
                    }
                    MessageBox.Show("Se ha eliminado al Usuario correctamente.");
                    break;
                    
                case DialogResult.No:
                    
                    return;

                case DialogResult.Cancel:
                    

                    return;

                default:
                    break;
            }














            
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblListaUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void cmbNivelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
