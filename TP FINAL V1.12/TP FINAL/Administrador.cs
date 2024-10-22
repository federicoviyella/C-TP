using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL
{
    internal class Administrador : Usuario
    {
        Conexion conexion = new Conexion();


        public Administrador() { }  //Constructor vacio

        public Administrador(string email, string contraseña, string apellido, string nombre, string nivelUsuario) : base(email, contraseña, nombre, apellido, nivelUsuario)
        {
            if (string.IsNullOrEmpty(nivelUsuario) || nivelUsuario != "Administrador")
            {
                throw new Exception("El usuario no tiene privilegios de Administrador");

            }
        }


        public void ActualizarDatosUsuario(string nombre, string apellido, string correo)
        {
            string sSql = "UPDATE Registro SET NombreCompleto = @NombreCompleto, Apellido = @Apellido WHERE Email =@Email";
            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nivel de usuario actualizado exitosamente.");

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el nivel de usuario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }



            }
        }


        public void ModificarUsuario(string email, string nuevaContraseña)
        {
            string sSql = "UPDATE Registro SET Contraseña = @NuevaContraseña WHERE Email = @Email";
            using (OleDbDataAdapter da = new OleDbDataAdapter())
            {
                using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@NuevaContraseña", nuevaContraseña);
                    cmd.Parameters.AddWithValue("@Email", email);
                    da.UpdateCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conexion.CerrarConexion();
                }
            }
        }

        public void EliminarUsuario(string email)
        {
            string sSql = "DELETE * FROM Registro WHERE Email = @Email";
            using (OleDbDataAdapter da = new OleDbDataAdapter())
            {
                using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    da.DeleteCommand = cmd;
                    DataTable dt = new DataTable();
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();
                }
            }
        }


        public void ActualizarNivelUsuario(string email, string nuevoNivel)
        {
            string sSql = "UPDATE Registro SET NivelUsuario = @NuevoNivel WHERE Email =@Email";
            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@NuevoNivel", nuevoNivel);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nivel de usuario actualizado exitosamente.");

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el nivel de usuario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }


               
            }

        }
    }
}


        


        






    

