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
            Txt_Reporte.Visible = true;
            REPORTES.Visible = true;
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

        Bitmap bmp;
        private void Txt_Reporte_Click(object sender, EventArgs e)
        {

            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string fechapedido = dtp_fecha.Value.ToString("yyyy-MM-dd");
            e.Graphics.DrawString("FACTURA PROVEEDORES", new Font("Times New Roman", 35, FontStyle.Bold), Brushes.Black, new PointF(200, 10));
            e.Graphics.DrawString("FECHA DE ENTREGA: " + fechapedido, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 190));

            e.Graphics.DrawString("CODIGO USUARIO:" + txt_CODUsuario.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 450));
            e.Graphics.DrawString("CODIGO PROVEEDOR:" + txt_CODproveedor.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 480));
            e.Graphics.DrawString("CODIGO ORDEN DE COMPRA:" + Txt_Cod.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 510));
            e.Graphics.DrawString("TOTAL IMPUESTO:" + txt_totalImpuesto.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 540));



            e.Graphics.DrawString("DETALLE ENTREGADO", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 600));
            e.Graphics.DrawImage(bmp, 100, 650);


            e.Graphics.DrawString("TOTAL:" + txt_total.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 1000));

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
