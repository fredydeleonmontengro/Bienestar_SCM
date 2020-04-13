using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Datos_SCM
{
    public class SIFSCM
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //---------------------------------------------------------------CONSULTA IMPUESTO------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaImpuesto()
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM impuestos WHERE estado = 1 ;", cn.conexionbd());
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
        //---------------------------------------------------------------INSERT IMPUESTO------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarImpuesto(string sCodigo, string sNombre, string sDescripcion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into impuestos values(" + sCodigo + ", '" + sNombre + "' ,'" + sDescripcion + "',1);";
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
        //---------------------------------------------------------------UPDATE IMPUESTO------------------------------------------------------------------------------------------//

        public OdbcDataReader modificarImpuesto(string sCodigo, string sNombre, string sDescripcion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE impuestos set nombre='" + sNombre + "',descripcion='" + sDescripcion+ "'"+ " where pkidImpuesto='" + sCodigo + "';";
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
        //--------------------------------------------------------------ELIMINAR IMPUESTO------------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarImpuesto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE impuestos set estado='0' where pkidImpuesto='" + sCodigo + "';";
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
