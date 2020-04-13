using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Frm_BusquedaOrdenCompra(string idusuario)
        {
            InitializeComponent();
            usuario = idusuario;
        }

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

        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            Frm_FacturaProveedores consultaReporte = new Frm_FacturaProveedores(usuario);
            consultaReporte.ShowDialog();
        }
    }
}
