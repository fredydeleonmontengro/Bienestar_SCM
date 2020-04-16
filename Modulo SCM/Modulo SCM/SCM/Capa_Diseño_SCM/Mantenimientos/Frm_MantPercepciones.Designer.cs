namespace CapaDiseño.Mantenimientos
{
    partial class Frm_MantPercepciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantPercepciones));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.Cbo_tipooperacion = new System.Windows.Forms.ComboBox();
            this.lbl_accion = new System.Windows.Forms.Label();
            this.Txt_Saldo = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_tipo = new System.Windows.Forms.ComboBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nom = new System.Windows.Forms.Label();
            this.Lbl_codPercepcion = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.Pnl_nombreForm.SuspendLayout();
            this.gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(-1, -2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1293, 63);
            this.Pnl_nombreForm.TabIndex = 0;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1183, 15);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1136, 15);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE PERCEPCIONES Y DEDUCCIONES";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1233, 15);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(818, 91);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(186, 109);
            this.Btn_consultar.TabIndex = 67;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(705, 91);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(115, 109);
            this.Btn_borrar.TabIndex = 66;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(593, 91);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(115, 109);
            this.Btn_guardar.TabIndex = 64;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(481, 91);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(115, 109);
            this.Btn_editar.TabIndex = 63;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(369, 91);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(115, 109);
            this.Btn_ingresar.TabIndex = 62;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.Cbo_estado);
            this.gpb_datos.Controls.Add(this.lbl_estado);
            this.gpb_datos.Controls.Add(this.Cbo_tipooperacion);
            this.gpb_datos.Controls.Add(this.lbl_accion);
            this.gpb_datos.Controls.Add(this.Txt_Saldo);
            this.gpb_datos.Controls.Add(this.lbl_saldo);
            this.gpb_datos.Controls.Add(this.label2);
            this.gpb_datos.Controls.Add(this.Cbo_tipo);
            this.gpb_datos.Controls.Add(this.Txt_nombre);
            this.gpb_datos.Controls.Add(this.Lbl_nom);
            this.gpb_datos.Controls.Add(this.Lbl_codPercepcion);
            this.gpb_datos.Controls.Add(this.Txt_Cod);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(30, 232);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Size = new System.Drawing.Size(1221, 205);
            this.gpb_datos.TabIndex = 68;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Datos";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_estado.Location = new System.Drawing.Point(732, 132);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(162, 28);
            this.Cbo_estado.TabIndex = 11;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(575, 140);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(61, 20);
            this.lbl_estado.TabIndex = 10;
            this.lbl_estado.Text = "Estado";
            // 
            // Cbo_tipooperacion
            // 
            this.Cbo_tipooperacion.FormattingEnabled = true;
            this.Cbo_tipooperacion.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_tipooperacion.Location = new System.Drawing.Point(732, 85);
            this.Cbo_tipooperacion.Name = "Cbo_tipooperacion";
            this.Cbo_tipooperacion.Size = new System.Drawing.Size(162, 28);
            this.Cbo_tipooperacion.TabIndex = 9;
            // 
            // lbl_accion
            // 
            this.lbl_accion.AutoSize = true;
            this.lbl_accion.Location = new System.Drawing.Point(571, 91);
            this.lbl_accion.Name = "lbl_accion";
            this.lbl_accion.Size = new System.Drawing.Size(147, 20);
            this.lbl_accion.TabIndex = 8;
            this.lbl_accion.Text = "Tipo de operacion:";
            // 
            // Txt_Saldo
            // 
            this.Txt_Saldo.Location = new System.Drawing.Point(732, 42);
            this.Txt_Saldo.Name = "Txt_Saldo";
            this.Txt_Saldo.Size = new System.Drawing.Size(162, 27);
            this.Txt_Saldo.TabIndex = 7;
            this.Txt_Saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Saldo_KeyPress);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(571, 46);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(56, 20);
            this.lbl_saldo.TabIndex = 6;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Concepto:";
            // 
            // Cbo_tipo
            // 
            this.Cbo_tipo.FormattingEnabled = true;
            this.Cbo_tipo.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_tipo.Location = new System.Drawing.Point(293, 130);
            this.Cbo_tipo.Name = "Cbo_tipo";
            this.Cbo_tipo.Size = new System.Drawing.Size(173, 28);
            this.Cbo_tipo.TabIndex = 4;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(293, 84);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(173, 27);
            this.Txt_nombre.TabIndex = 3;
            this.Txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            // 
            // Lbl_nom
            // 
            this.Lbl_nom.AutoSize = true;
            this.Lbl_nom.Location = new System.Drawing.Point(26, 91);
            this.Lbl_nom.Name = "Lbl_nom";
            this.Lbl_nom.Size = new System.Drawing.Size(149, 20);
            this.Lbl_nom.TabIndex = 2;
            this.Lbl_nom.Text = "Nombre Concepto:";
            // 
            // Lbl_codPercepcion
            // 
            this.Lbl_codPercepcion.AutoSize = true;
            this.Lbl_codPercepcion.Location = new System.Drawing.Point(26, 42);
            this.Lbl_codPercepcion.Name = "Lbl_codPercepcion";
            this.Lbl_codPercepcion.Size = new System.Drawing.Size(261, 20);
            this.Lbl_codPercepcion.TabIndex = 1;
            this.Lbl_codPercepcion.Text = "Codigo de percepcion/Deduccion:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Location = new System.Drawing.Point(332, 42);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(134, 27);
            this.Txt_Cod.TabIndex = 0;
            // 
            // Frm_MantPercepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 510);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MantPercepciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantPercepciones";
            this.Load += new System.EventHandler(this.Frm_MantPercepciones_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox Cbo_tipooperacion;
        private System.Windows.Forms.Label lbl_accion;
        private System.Windows.Forms.TextBox Txt_Saldo;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_tipo;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nom;
        private System.Windows.Forms.Label Lbl_codPercepcion;
        private System.Windows.Forms.TextBox Txt_Cod;
    }
}