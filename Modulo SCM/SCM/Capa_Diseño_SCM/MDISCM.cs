using Capa_Diseño_SCM.Mantenimientos;
using Capa_Diseño_SCM.Procesos;
using CapaDiseño.Mantenimientos;
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
    public partial class MDISCM : Form
    {
        private int childFormNumber = 0;
        string susuario = "usuario";
        public MDISCM()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        bool ventanaConceptos = false;
        Frm_MantPercepciones conceptos = new Frm_MantPercepciones("");
        private void PercepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPercepciones);
            if (ventanaConceptos == false || frmC == null)
            {
                if (frmC == null)
                {
                    conceptos = new Frm_MantPercepciones(susuario);
                }

                conceptos.MdiParent = this;
                conceptos.Show();
                Application.DoEvents();
                ventanaConceptos = true;
            }
            else
            {
                conceptos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        bool ventanaFactura = false;
        Frm_BusquedaOrdenCompra facturaP = new Frm_BusquedaOrdenCompra("");
        private void ingresoFacturaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_BusquedaOrdenCompra);
            if (ventanaFactura == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturaP = new Frm_BusquedaOrdenCompra(susuario);
                }

                facturaP.MdiParent = this;
                facturaP.Show();
                Application.DoEvents();
                ventanaFactura = true;
            }
            else
            {
                facturaP.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaImpuestos = false;
        Frm_MantImpuestos impuestos = new Frm_MantImpuestos("");
        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantImpuestos);
            if (ventanaImpuestos == false || frmC == null)
            {
                if (frmC == null)
                {
                    impuestos = new Frm_MantImpuestos(susuario);
                }

                impuestos.MdiParent = this;
                impuestos.Show();
                Application.DoEvents();
                ventanaImpuestos = true;
            }
            else
            {
                impuestos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaordenDeCompra = false;
        Frm_Ordencompra orden = new Frm_Ordencompra();
        private void generarOrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Ordencompra);
            if (ventanaordenDeCompra == false || frmC == null)
            {
                if (frmC == null)
                {
                    orden = new Frm_Ordencompra();
                }

                orden.MdiParent = this;
                orden.Show();
                Application.DoEvents();
                ventanaordenDeCompra = true;
            }
            else
            {
                orden.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
    }
}
