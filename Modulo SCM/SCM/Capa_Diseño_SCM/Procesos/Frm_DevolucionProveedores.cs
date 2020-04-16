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

namespace Capa_Diseño_SCM.Procesos
{
    public partial class Frm_DevolucionProveedores : Form
    {

        LIFSCM logic = new LIFSCM();
        public Frm_DevolucionProveedores()
        {
            InitializeComponent();
            textBox2.Text = logic.siguiente("mydb.devoluciones", "pkcodigodev");
        }

        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.detalle(textBox1.Text);
            try
            {
                while (mostrar.Read())
                {
                    string s = mostrar.GetString(2) + mostrar.GetString(3) + mostrar.GetString(5) ;
                    Console.WriteLine(s);
                    dataGridView1.Rows.Add(mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }


        public void guardar()
        {
            OdbcDataReader mostrar = logic.dev(textBox2.Text, textBox1.Text , txt_Nombreproveedor.Text , Txt_Cod.Text , txt_nit.Text, txt_total.Text, textBox3.Text );
            //spkidmovimiento_general,pkidProducto, concepto,  documento,cantidad, fecha


        }

        public void guardar2()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                string producto = Convert.ToString(row.Cells["Column1"].Value);
                string cantidad = Convert.ToString(row.Cells["Column2"].Value);
                string fechas = fecha.Value.ToString("yyyy-MM-dd");
                string concepto = "devolucion/compra";


                OdbcDataReader cita = logic.movi( producto,concepto, txt_nit.Text,"-"+cantidad, fechas );



            }

            
            //,pkidProducto, concepto,  documento,cantidad, fecha


        }
        private void Lbl_codOrden_Click(object sender, EventArgs e)
        {

        }

        private void gp_detalle_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_DevolucionProveedores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Frm_consulta_facturas concep = new Frm_consulta_facturas();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                textBox1.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_Nombreproveedor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_nit.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                txt_total.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[4].Value.ToString();
            }
            MostrarConsulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardar();
            guardar2();
            MessageBox.Show("generada");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
