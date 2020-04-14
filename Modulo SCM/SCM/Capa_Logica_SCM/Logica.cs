using Capa_Datos_SCM;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_SCM
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
 /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }
        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }
        public OdbcDataReader consultaayuda(string id)
        {
            return sn.consultaayudas(id);
        }



        public OdbcDataReader consultarconcepto(string numero)
        {
            return sn.consultaconcepto(numero);
        }


        //------------------------------------------------------------------------------------------------------INSERTS-------------------------------------------------------//
        public OdbcDataReader Insertarconcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            return sn.Insertarconcepto(sCodigo, sNombre, sTipoconcepto, ssaldo, stipoaccion, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarConcepto(string sCodigo, string sNombre, string sTipoconcepto, string ssaldo, string stipoaccion, string sestado)
        {
            return sn.modificarconcepto(sCodigo, sNombre, sTipoconcepto, ssaldo, stipoaccion, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            return sn.eliminarconcepto(sCodigo);

        }
    }
}
