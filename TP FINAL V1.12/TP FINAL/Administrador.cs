using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_FINAL
{
    internal class Administrador : Usuario
    {
        Conexion conexion = new Conexion();


        public Administrador() { }  //Constructor vacio

        public Administrador(string email, string contraseña, string apellido, string nombre, string nivelUsuario) : base (email,contraseña, nombre, apellido, nivelUsuario)
        {
            if (string.IsNullOrEmpty(nivelUsuario) || nivelUsuario != "Administrador")
            {
                throw new Exception("El usuario no tiene privilegios de Administrador");

            }
        }

        //public bool LoginAdmin(string nombre, string nivelUsuario)
        //{
        //    string sSql = "SELECT COUNT(*) FROM Registro WHERE NombreCompleto = @NombreCompleto AND NivelUsuario = @NivelUsuario";

        //    using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
        //    {

        //        cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
        //        cmd.Parameters.AddWithValue("@NivelUsuario", nivelUsuario);

        //        int count = (int)cmd.ExecuteScalar();
        //        conexion.CerrarConexion();

        //        return count > 0;
        //    }
        //}




    }
}
