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
                cn.conexionbd();
                string consulta = "SELECT * FROM impuestos WHERE estado = 1 ;";
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
        //---------------------------------------------------------------INSERT IMPUESTO------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarImpuesto(string sCodigo, string sNombre, string sDescripcion, string sValor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into impuestos values(" + sCodigo + ", '" + sNombre + "' ,'" + sDescripcion + "'," + sValor + ",1);";
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

        public OdbcDataReader modificarImpuesto(string sCodigo, string sNombre, string sDescripcion, string sValor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE impuestos set nombre='" + sNombre + "', descripcion='" + sDescripcion+ "'"+ ", valor = " + sValor + " where pkidImpuesto = " + sCodigo + ";";
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
        //---------------------------------------------------------------CONSULTA ORDEN DE COMPRA ENCABEZADO------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaOrdenCompraEncabezado()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM ordencomrpaencabezado WHERE estado = 1 ;";
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
        //---------------------------------------------------------------CONSULTA PROVEEDOR-ORDEN DE COMPRA------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaProveedorOrden(string sCOD)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("select P.pkidProveedor, P.nombre, P.nit from ordencomrpaencabezado O left join  proveedor P on O.fkIdProveedor = P.pkidProveedor where O.pkIdOrdenCompraEncabezado = "+ sCOD +";", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                //Console.WriteLine(reader.GetString(0)+ reader.GetString(1) + reader.GetString(2));
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }

        }
        //---------------------------------------------------------------CONSULTA DETALLE DE ORDEN DE COMPRA-----------------------------------------------------------------------------------------//

        public OdbcDataReader consultaDetalleOrden(string sCOD)
        {

            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM ordencompradetalle WHERE fkIdordenCompraEncabezado = " + sCOD +";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
            /*
            try
            {
                OdbcCommand command = new OdbcCommand(" SELECT fkIdProducto, cantidad, subTotal, estado FROM ordencompradetalle WHERE fkIdordenCompraEncabezado = " + sCOD + ";", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                //Console.WriteLine(reader.GetString(0)+ reader.GetString(1) + reader.GetString(2));
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }
            */

        }


        //-------------------------------------------------------------------------Foemulario de orden de compra----------------------------------------------------------
        public OdbcDataReader mostrarproductos(string sIdProveedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT Nombre, Costo  FROM mydb.producto  where pkidProveedor = '" + sIdProveedor + "';";
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
        public OdbcDataReader sumaimpustos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT sum(valor) FROM mydb.impuestos;";
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
        public OdbcDataReader InsertarEncabezadoOrdenCompra(string pkencabezado, string codproveedor, string formapago, string fechapedido, string fecharequerida, string codempleado, string observaciones, string impuesto, string total, string descuento)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into mydb.ordencomrpaencabezado values(" + pkencabezado + ", '" + codproveedor + "' ,'" + formapago + "','" + fechapedido + "','" + fecharequerida + "','" + codempleado + "','" + observaciones + "','" + impuesto + "','" + total + "','" + descuento + "','1');";
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

        public OdbcDataReader consultaempleados()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM mydb.empleado;";
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
        public OdbcDataReader formaspago()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM mydb.formaspago;;";
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

        public OdbcDataReader InsertardetallerdenCompra(string codigo, string producto, string cantidad, string total)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into mydb.ordencompradetalle(fkIdordenCompraEncabezado, Producto, cantidad, subTotal, estado )  values(" + codigo + ", '" + producto + "' ,'" + cantidad + "','" + total + "','1');";
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
