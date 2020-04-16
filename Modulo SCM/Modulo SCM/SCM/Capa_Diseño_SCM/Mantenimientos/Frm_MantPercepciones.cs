
using Capa_Logica_SCM;
using CapaDiseño.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño.Mantenimientos
{
    public partial class Frm_MantPercepciones : Form
    {
        Logica logic = new Logica();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;


        public Frm_MantPercepciones(String susuario)
        {
            InitializeComponent();
            scampo = logic.siguiente("concepto", "pkcodigoconcepto");
            obtenerip();
            suser = susuario;
            bloqueartxt();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Percepciones";
            Txt_Cod.Text = scampo;
        }
        /*---------------------------------------------------Codigo general------------------------------------------------------------------------------------------*/
        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }
        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Saldo.Enabled = false;
            Cbo_estado.Enabled = false;
            Cbo_tipo.Enabled = false;
            Cbo_tipooperacion.Enabled = false;
        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_Saldo.Enabled = true;
            Cbo_estado.Enabled = true;
            Cbo_tipo.Enabled = true;
            Cbo_tipooperacion.Enabled = true;
        }
        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            Txt_Saldo.Text = "";
            Cbo_estado.Text = "";
            Cbo_tipo.Text = "";
            Cbo_tipooperacion.Text = "";
        }
        /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("2");
            try
            {
                while (mostrarayuda.Read())
                {
                    ruta = mostrarayuda.GetString(1);
                    indice = mostrarayuda.GetString(2);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Help.ShowHelp(this, ruta, indice);
         }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarconcepto(Txt_Cod.Text,Txt_nombre.Text,Cbo_tipo.Text,Txt_Saldo.Text,Cbo_tipooperacion.Text,Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarConcepto(Txt_Cod.Text, Txt_nombre.Text, Cbo_tipo.Text, Txt_Saldo.Text, Cbo_tipooperacion.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarconcepto(Txt_Cod.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        public void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConceptos concep = new Frm_consultaConceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Cbo_tipo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Saldo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Cbo_tipooperacion.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                     Cells[5].Value.ToString();
            }
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposLetras(e);
        }

        private void Txt_Saldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Camposdecimales(e);
        }

        private void Frm_MantPercepciones_Load(object sender, EventArgs e)
        {

        }
    }
}
