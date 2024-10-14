using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_FINAL
{
    //public class ConsultasGenericas
    //{

    //    private Conexion conexion = new Conexion();
    //    private OleDbCommand com;
    //    private OleDbDataAdapter da;
    //    private DataTable dt;


    //    public void EjecutarComando(string sSql)
    //    {

    //        try
    //        {
    //            com = new OleDbCommand(sSql, conexion.AbrirConexion());
    //            com.ExecuteNonQuery();

    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error al ejecutar el comando: " + ex.Message);
    //        }

    //        finally
    //        {
    //            conexion.CerrarConexion();
    //        }
    //    }
    //    public void Eliminar(string sSql)
    //    {
    //        EjecutarComando(sSql);
    //    }

    //    public DataTable BuscarDesc(string sSql)
    //    {
    //        try
    //        {
    //            dt = new DataTable();
    //            da = new OleDbDataAdapter(sSql, conexion.AbrirConexion());
    //            da.Fill(dt);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Error al buscar los datos: " + ex.Message);
    //        }
    //        finally
    //        {
    //            conexion.CerrarConexion();
    //        }
    //        return dt;
    //    }


    //    public void Insertar(string sSql)
    //    {
    //        EjecutarComando(sSql);
    //    }

        
    //    public void Actualizar(string sSql)
    //    {
    //        EjecutarComando(sSql);
    //    }
    //}






}












   
