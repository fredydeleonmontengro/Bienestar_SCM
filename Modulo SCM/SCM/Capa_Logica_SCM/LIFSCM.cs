using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos_SCM;
using System.Data.Odbc;

namespace Capa_Logica_SCM
{
    public class LIFSCM
    {
        Sentencias sn1 = new Sentencias();
 
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn1.obtenerfinal(tabla, campo);
            return llave;
        }
        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn1.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }
        public OdbcDataReader consultaayuda(string id)
        {
            return sn1.consultaayudas(id);
        }

        SIFSCM sn = new SIFSCM();
        //------------------------------------------------------------------------------------------------------CONSULTA IMPUESTO y EMPLEADO-------------------------------------------------------//

        public OdbcDataReader consultaImpuesto()
        {
            return sn.consultaImpuesto();
        }
        public OdbcDataReader consultaempleado()
        {
            return sn.consultaempleados();
        }
        public OdbcDataReader formasdepago()
        {
            return sn.formaspago ();
        }


        //------------------------------------------------------------------------------------------------------INSERTS IMPUESTO-------------------------------------------------------//
        public OdbcDataReader InsertarImpuesto(string sCodigo, string sNombre, string sTipoconcepto, string sValor)
        {
            return sn.InsertarImpuesto(sCodigo, sNombre, sTipoconcepto, sValor);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE IMPUESTO-------------------------------------------------------//
        public OdbcDataReader modificarImpuesto(string sCodigo, string sNombre, string sTipoconcepto, string sValor)
        {
            return sn.modificarImpuesto(sCodigo, sNombre, sTipoconcepto, sValor);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE ELIMINAR IMPUESTO-------------------------------------------------------//
        public OdbcDataReader eliminarImpuesto(string sCodigo)
        {
            return sn.eliminarImpuesto(sCodigo);

        }
        //------------------------------------------------------------------------------------------------------CONSULTA ENCABEZADO ORDEN DE COMPRA------------------------------------------------------//

        public OdbcDataReader consultaOrdenCompraEncabezado()
        {
            return sn.consultaOrdenCompraEncabezado();
        }

        //------------------------------------------------------------------------------------------------------CONSULTA PROVEEDOR-ORDEN DE COMPRA-----------------------------------------------------//

        public OdbcDataReader consultaProveedorOrden(string sCod)
        {
            return sn.consultaProveedorOrden(sCod);
        }

        //------------------------------------------------------------------------------------------------------CONSULTA DETALLE ORDEN DE COMPRA-----------------------------------------------------//

        public OdbcDataReader consultaDetalleOrden(string sCod)
        {
            return sn.consultaDetalleOrden(sCod);
        }


        public OdbcDataReader productosmostrar(string sIdProveedor)
        {
            return sn.mostrarproductos(sIdProveedor);

        }
        public OdbcDataReader impuestos()
        {
            return sn.sumaimpustos();

        }

        public OdbcDataReader insertarencabezado(string pkencabezado, string codproveedor, string formapago, string fechapedido, string fecharequerida, string codempleado, string observaciones, string impuesto, string total, string descuento)

        {
            return sn.InsertarEncabezadoOrdenCompra(pkencabezado, codproveedor, formapago, fechapedido, fecharequerida, codempleado, observaciones, impuesto, total, descuento)
        ;

        }

        public OdbcDataReader insertardetalle(string codigo, string producto, string cantidad, string total)

        {
            return sn.InsertardetallerdenCompra(codigo,producto,cantidad,total)
        ;

        }
        public OdbcDataReader codorden()

        {
            return sn.ordencod()
        ;

        }



    }
}
