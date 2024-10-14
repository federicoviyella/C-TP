using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TP_FINAL
{
    public class Usuario
    {
        Conexion conexion = new Conexion();
        #region atributos
        //atributos

        private string nombreCompleto;
        private string apellidoRegistro;
        private string emailRegistro;
        private string contraseñaRegistro;
        private string nivelUsuario;
        #endregion

        #region properties


        public string NombreCompleto { get; set; }
        public string ApellidoRegistro { get; set; }
        public string EmailRegistro { get; set; }
        public string ContraseñaRegistro { get; set; } 
        public string NivelUsuario { get; set; }

        #endregion

        public Usuario() { }



        public Usuario(string email, string contraseña, string apellido, string nombre, string nivelUsuario)
        {
            string sSql = "SELECT NombreCompleto, Apellido, Email, Contraseña, NivelUsuario FROM Registro WHERE Email = @EmailRegistro AND Contraseña = @ContraseñaRegistro AND Apellido = @Apellido AND NombreCompleto = @NombreCompleto AND NivelUsuario = @NivelUsuario";
            //AND Contraseña = @ContraseñaRegistro AND Apellido = @Apellido AND Nombre Completo = @NombreCompleto AND Nivel Usuario = @NivelUsuario
            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@EmailRegistro", email);
                cmd.Parameters.AddWithValue("@ContraseñaRegistro", contraseña);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@NombreCompleto", nombre);
                cmd.Parameters.AddWithValue("@NivelUsuario", nivelUsuario);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        this.nombreCompleto = reader["NombreCompleto"].ToString();
                        this.apellidoRegistro = reader["Apellido"].ToString();
                        this.contraseñaRegistro = reader["Contraseña"].ToString();
                        this.emailRegistro = reader["Email"].ToString();
                        this.nivelUsuario = reader["NivelUsuario"].ToString();
                    }
                    else
                    {
                        throw new Exception("usuario no encontrado en Base de Datos");
                    }
                }
            }
            conexion.CerrarConexion();

        }


        //metodos

        public bool Login(string correo, string  contraseña)
        {
            string sSql = "SELECT COUNT(*) FROM Registro WHERE Email = @EmailRegistro AND Contraseña = @ContraseñaRegistro";

            using(OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                
                cmd.Parameters.AddWithValue("@EmailRegistro", correo);
                cmd.Parameters.AddWithValue("@ContraseñaRegistro", contraseña);

                int count = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();

                return count > 0;
            }            
        }           
             
        public bool Registrarse(string NombreCompleto, string Apellido, string Email, string Contraseña)
        {
            string sSql = "INSERT INTO Registro (NombreCompleto, Apellido, Email, Contraseña, NivelUsuario) VALUES (@NombreCompleto, @Apellido, @Email, @Contraseña, @NivelUsuario)";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {

                cmd.Parameters.AddWithValue("@NombreCompleto",NombreCompleto);
                cmd.Parameters.AddWithValue("@ApellidoRegistro",Apellido);
                cmd.Parameters.AddWithValue("@EmailRegistro",Email);
                cmd.Parameters.AddWithValue("@ContraseñaRegistro",Contraseña);
                cmd.Parameters.AddWithValue("@NivelUsuario", "Usuario");

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al registrar:");
                    return false;
                }
            }

        }

        public string GenerarCodigoRecuperacion(string correo)
        {

            Random random = new Random();
            string codigo = random.Next(1000, 9999).ToString();
            GenerarCodigoRecuperacion(correo, codigo);
            return codigo;



        } //RANDOM
   
              
        public void GenerarCodigoRecuperacion(string correo, string codigo)
        {
            string sSql = "UPDATE Registro SET Codigo = @Codigo WHERE Email = @Email";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Email", correo);

                cmd.ExecuteNonQuery();

            }
            conexion.CerrarConexion();
        }
       
               
        public bool CambiarContraseña(string correo, string codigo, string contraseña)
        {
            string sSql = "SELECT COUNT(*) FROM Registro WHERE Email=@Email AND Codigo = @codigo";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Email", correo);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)

                {
                    string updateSql = "UPDATE Registro SET Contraseña = @Contraseña, Codigo = NULL WHERE Email = @Email";
                    cmd.CommandText = updateSql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.ExecuteNonQuery();

                    conexion.CerrarConexion();
                    return true;


                }

                conexion.CerrarConexion();
                return false;



            } 
            


        }

        
        public string ObtenerNivelUsuario(string correo)
        {
           string sSql = "SELECT NivelUsuario FROM Registro WHERE Email = @Email";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                    
                cmd.Parameters.AddWithValue("@Email", correo);
                                
                string rol = (string)cmd.ExecuteScalar();
                
                conexion.CerrarConexion();

                return rol;
            }
            

        }



        public void ObtenerUsuario (string correo)
        {
            string sSql = "SELECT Nombre, NivelUsuario FROM Registro WHERE Email = @Email";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {

                cmd.Parameters.AddWithValue("@Email",correo);
               

               cmd.ExecuteNonQuery();

                conexion.CerrarConexion();

             
            }



        }

    }













    

}
