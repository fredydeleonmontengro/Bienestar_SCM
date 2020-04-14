using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_SCM
{
   public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
//--------------------------------------------------------------------Metodos General--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }
        public OdbcDataReader insertarbitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into bitacora values(" + sCodigo + ", '" + sip + "', '" + Smac + "' ,'" + susuario + "','" + sdepartamento + "','" + sfechahora + "','" + saccion + "','" + sformulario + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaayudas(string id)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from ayudas where pkcodigoayuda =" + id + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaconcepto(string campo)
        {          
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM concepto WHERE estado = " + campo + " ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
//-------------------------------------------------------------------------Foemulario de conceptos----------------------------------------------------------
        public OdbcDataReader Insertarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + sCodigo + ", '" + sNombre + "' ,'" + sTipoconcepto + "','" + ssaldo + "','" + stipoaccion + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set nombreconcepto='" + sNombre + "',tipo_concepto='" + sTipoconcepto + "',saldo='" + ssaldo + "',tipo_accion='" + stipoaccion + "',estado='" + sestado + "' where pkcodigoconcepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set estado='0' where pkcodigoconcepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
