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
        //------------------------------------------------------------------------------------------------------CONSULTA IMPUESTO-------------------------------------------------------//

        public OdbcDataReader consultaImpuesto()
        {
            return sn.consultaImpuesto();
        }


        //------------------------------------------------------------------------------------------------------INSERTS IMPUESTO-------------------------------------------------------//
        public OdbcDataReader InsertarImpuesto(string sCodigo, string sNombre, string sTipoconcepto)
        {
            return sn.InsertarImpuesto(sCodigo, sNombre, sTipoconcepto);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE IMPUESTO-------------------------------------------------------//
        public OdbcDataReader modificarImpuesto(string sCodigo, string sNombre, string sTipoconcepto)
        {
            return sn.modificarImpuesto(sCodigo, sNombre, sTipoconcepto);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE ELIMINAR IMPUESTO-------------------------------------------------------//
        public OdbcDataReader eliminarImpuesto(string sCodigo)
        {
            return sn.eliminarImpuesto(sCodigo);

        }
    }
}
