
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

namespace CapaDiseño.Consulta
{
    public partial class Frm_consultaConceptos : Form
    {
        Logica logic = new Logica();
        public Frm_consultaConceptos()
        {
            InitializeComponent();
            Dgv_consultaConceptos.Rows.Clear();
            MostrarConsulta();
        }


        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultarconcepto("1");
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaConceptos.Rows.Add(mostrar.GetString(0), mostrar.GetString(1),mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------



        public void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaConceptos.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaConceptos.Rows.Clear();
            MostrarConsulta();
        }

        public void Frm_consultaConceptos_Load(object sender, EventArgs e)
        {
            Dgv_consultaConceptos.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
