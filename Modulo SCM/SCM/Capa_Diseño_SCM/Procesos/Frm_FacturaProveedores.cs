using Capa_Diseño_SCM.Consultas;
using Capa_Logica_SCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Capa_Diseño_SCM
{
    public partial class Frm_FacturaProveedores : Form
    {
        string sUsuario, sCODOrden;
        LIFSCM logic = new LIFSCM();
        
        public Frm_FacturaProveedores(string Usuario, string CodOrdenEncabezado)
        {
            InitializeComponent();
            sUsuario = Usuario;
            sCODOrden = CodOrdenEncabezado;


        }
        void llenarEncabezado()
        {
            //LLENADO DE DATOS DEL LA ORDEN DE COMPRA
            OdbcDataReader mostrar = logic.consultaProveedorOrden(sCODOrden);
            string[] aValores = new string[4];
            string sCampo;
            try
            {
                aValores[0] = mostrar.GetString(0);
                sCampo = mostrar.GetString(0);
                aValores[1] = mostrar.GetString(1);
                aValores[2] = mostrar.GetString(2);

                txt_CODproveedor.Text = aValores[0];
                txt_Nombreproveedor.Text = aValores[1];
                txt_nit.Text = aValores[2];
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        void llenarDetalle()
        {
            
            MessageBox.Show(sCODOrden);
            OdbcDataReader mostrar = logic.consultaDetalleOrden(sCODOrden);
            try
            {
                while (mostrar.Read())
                {
                   
                    Dgv_pedido.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscarI_Click(object sender, EventArgs e)
        {
            Frm_consultaImpuesto concep = new Frm_consultaImpuesto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                txt_codImpuesto.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_nombreImpuesto.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_valor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Frm_FacturaProveedores_Load(object sender, EventArgs e)
        {
            Txt_Cod.Text = sCODOrden;
            txt_CODUsuario.Text = sUsuario;
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "yyyy/MM/dd";
            llenarEncabezado();
            llenarDetalle();
        }
    }
}
