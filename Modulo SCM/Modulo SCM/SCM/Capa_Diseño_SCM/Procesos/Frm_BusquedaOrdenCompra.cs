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
    public partial class Frm_BusquedaOrdenCompra : Form
    {
        string usuario;
        LIFSCM logic = new LIFSCM();
        Validaciones v = new Validaciones();
        int renglon;
        public Frm_BusquedaOrdenCompra(string idusuario)
        {
            InitializeComponent();
            usuario = idusuario;
            Dgv_consultaOrdenCompra.Rows.Clear();
            MostrarConsulta();
        }

        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaOrdenCompraEncabezado();
            try
            {
                while (mostrar.Read())
                {
                    string s = mostrar.GetString(0) + mostrar.GetString(1) + mostrar.GetString(2);
                    Console.WriteLine(s);
                    Dgv_consultaOrdenCompra.Refresh();
                    Dgv_consultaOrdenCompra.Rows.Add(mostrar.GetString(0), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(1), mostrar.GetString(8));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_BusquedaOrdenCompra_Load(object sender, EventArgs e)
        {
            Dgv_consultaOrdenCompra.Rows.Clear();
            MostrarConsulta();
            Txt_Cod.Enabled = false;
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Cod.Text))
            {
                MessageBox.Show("Debe de seleccionar una orden de compra.");
            }
            else
            {
                Frm_FacturaProveedores consultaReporte = new Frm_FacturaProveedores(usuario,Txt_Cod.Text);
                consultaReporte.ShowDialog();
            }
            
        }

        private void Txt_Cod_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Txt_Cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Dgv_consultaOrdenCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Cod.Text = Convert.ToString(Dgv_consultaOrdenCompra.CurrentRow.Cells[0].Value);
        }

        private void Dgv_consultaOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
