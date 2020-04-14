namespace Capa_Diseño_SCM
{
    partial class Frm_FacturaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FacturaProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_codOrden = new System.Windows.Forms.Label();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.lbl_codPro = new System.Windows.Forms.Label();
            this.txt_CODproveedor = new System.Windows.Forms.TextBox();
            this.Dgv_pedido = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_pasarTodo = new System.Windows.Forms.Button();
            this.Btn_pasaUno = new System.Windows.Forms.Button();
            this.Btn_pasarUnoI = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nomPro = new System.Windows.Forms.Label();
            this.txt_Nombreproveedor = new System.Windows.Forms.TextBox();
            this.lbl_codU = new System.Windows.Forms.Label();
            this.txt_CODUsuario = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_totalImpuesto = new System.Windows.Forms.TextBox();
            this.lbl_subTo = new System.Windows.Forms.Label();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.lbl_totalImpuesto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTn_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.gb_impuestos = new System.Windows.Forms.GroupBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombreImpuesto = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_codImpuesto = new System.Windows.Forms.Label();
            this.txt_codImpuesto = new System.Windows.Forms.TextBox();
            this.gb_encabezado = new System.Windows.Forms.GroupBox();
            this.gp_detalle = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_buscarI = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_impuestos.SuspendLayout();
            this.gb_encabezado.SuspendLayout();
            this.gp_detalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA PROVEEDORES";
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(2, 2);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1108, 51);
            this.Pnl_nombreForm.TabIndex = 2;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1000, 12);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(965, 12);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1038, 12);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Lbl_codOrden
            // 
            this.Lbl_codOrden.AutoSize = true;
            this.Lbl_codOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codOrden.Location = new System.Drawing.Point(644, 35);
            this.Lbl_codOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codOrden.Name = "Lbl_codOrden";
            this.Lbl_codOrden.Size = new System.Drawing.Size(183, 18);
            this.Lbl_codOrden.TabIndex = 77;
            this.Lbl_codOrden.Text = "Codigo Orden de Compra:";
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Enabled = false;
            this.Txt_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cod.Location = new System.Drawing.Point(841, 32);
            this.Txt_Cod.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(156, 24);
            this.Txt_Cod.TabIndex = 76;
            // 
            // lbl_codPro
            // 
            this.lbl_codPro.AutoSize = true;
            this.lbl_codPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codPro.Location = new System.Drawing.Point(76, 70);
            this.lbl_codPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codPro.Name = "lbl_codPro";
            this.lbl_codPro.Size = new System.Drawing.Size(133, 18);
            this.lbl_codPro.TabIndex = 79;
            this.lbl_codPro.Text = "Codigo Proveedor:";
            // 
            // txt_CODproveedor
            // 
            this.txt_CODproveedor.Enabled = false;
            this.txt_CODproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CODproveedor.Location = new System.Drawing.Point(273, 67);
            this.txt_CODproveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CODproveedor.Name = "txt_CODproveedor";
            this.txt_CODproveedor.Size = new System.Drawing.Size(156, 24);
            this.txt_CODproveedor.TabIndex = 78;
            // 
            // Dgv_pedido
            // 
            this.Dgv_pedido.AllowUserToAddRows = false;
            this.Dgv_pedido.AllowUserToDeleteRows = false;
            this.Dgv_pedido.AllowUserToResizeColumns = false;
            this.Dgv_pedido.AllowUserToResizeRows = false;
            this.Dgv_pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.cantidad,
            this.pu,
            this.sub});
            this.Dgv_pedido.Location = new System.Drawing.Point(15, 42);
            this.Dgv_pedido.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_pedido.MultiSelect = false;
            this.Dgv_pedido.Name = "Dgv_pedido";
            this.Dgv_pedido.ReadOnly = true;
            this.Dgv_pedido.RowHeadersVisible = false;
            this.Dgv_pedido.RowHeadersWidth = 51;
            this.Dgv_pedido.RowTemplate.Height = 24;
            this.Dgv_pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_pedido.Size = new System.Drawing.Size(492, 333);
            this.Dgv_pedido.TabIndex = 80;
            // 
            // cod
            // 
            this.cod.HeaderText = "COD Producto";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // pu
            // 
            this.pu.HeaderText = "Precio Unitario";
            this.pu.Name = "pu";
            this.pu.ReadOnly = true;
            // 
            // sub
            // 
            this.sub.HeaderText = "SubTotal";
            this.sub.Name = "sub";
            this.sub.ReadOnly = true;
            // 
            // Btn_pasarTodo
            // 
            this.Btn_pasarTodo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_pasarTodo.FlatAppearance.BorderSize = 3;
            this.Btn_pasarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_pasarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_pasarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pasarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pasarTodo.Location = new System.Drawing.Point(522, 55);
            this.Btn_pasarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_pasarTodo.Name = "Btn_pasarTodo";
            this.Btn_pasarTodo.Size = new System.Drawing.Size(47, 33);
            this.Btn_pasarTodo.TabIndex = 82;
            this.Btn_pasarTodo.Text = ">>";
            this.Btn_pasarTodo.UseVisualStyleBackColor = true;
            // 
            // Btn_pasaUno
            // 
            this.Btn_pasaUno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_pasaUno.FlatAppearance.BorderSize = 3;
            this.Btn_pasaUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_pasaUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_pasaUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pasaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pasaUno.Location = new System.Drawing.Point(522, 109);
            this.Btn_pasaUno.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_pasaUno.Name = "Btn_pasaUno";
            this.Btn_pasaUno.Size = new System.Drawing.Size(47, 33);
            this.Btn_pasaUno.TabIndex = 83;
            this.Btn_pasaUno.Text = ">";
            this.Btn_pasaUno.UseVisualStyleBackColor = true;
            // 
            // Btn_pasarUnoI
            // 
            this.Btn_pasarUnoI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_pasarUnoI.FlatAppearance.BorderSize = 3;
            this.Btn_pasarUnoI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_pasarUnoI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_pasarUnoI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pasarUnoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pasarUnoI.Location = new System.Drawing.Point(522, 165);
            this.Btn_pasarUnoI.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_pasarUnoI.Name = "Btn_pasarUnoI";
            this.Btn_pasarUnoI.Size = new System.Drawing.Size(47, 33);
            this.Btn_pasarUnoI.TabIndex = 84;
            this.Btn_pasarUnoI.Text = "<";
            this.Btn_pasarUnoI.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 86;
            this.label3.Text = "Fecha Entrega:";
            // 
            // lbl_nomPro
            // 
            this.lbl_nomPro.AutoSize = true;
            this.lbl_nomPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomPro.Location = new System.Drawing.Point(76, 105);
            this.lbl_nomPro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nomPro.Name = "lbl_nomPro";
            this.lbl_nomPro.Size = new System.Drawing.Size(139, 18);
            this.lbl_nomPro.TabIndex = 88;
            this.lbl_nomPro.Text = "Nombre Proveedor:";
            // 
            // txt_Nombreproveedor
            // 
            this.txt_Nombreproveedor.Enabled = false;
            this.txt_Nombreproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombreproveedor.Location = new System.Drawing.Point(273, 102);
            this.txt_Nombreproveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombreproveedor.Name = "txt_Nombreproveedor";
            this.txt_Nombreproveedor.Size = new System.Drawing.Size(156, 24);
            this.txt_Nombreproveedor.TabIndex = 87;
            // 
            // lbl_codU
            // 
            this.lbl_codU.AutoSize = true;
            this.lbl_codU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codU.Location = new System.Drawing.Point(76, 35);
            this.lbl_codU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codU.Name = "lbl_codU";
            this.lbl_codU.Size = new System.Drawing.Size(116, 18);
            this.lbl_codU.TabIndex = 90;
            this.lbl_codU.Text = "Codigo Usuario:";
            // 
            // txt_CODUsuario
            // 
            this.txt_CODUsuario.Enabled = false;
            this.txt_CODUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CODUsuario.Location = new System.Drawing.Point(273, 32);
            this.txt_CODUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CODUsuario.Name = "txt_CODUsuario";
            this.txt_CODUsuario.Size = new System.Drawing.Size(156, 24);
            this.txt_CODUsuario.TabIndex = 89;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(644, 132);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 18);
            this.lbl_total.TabIndex = 92;
            this.lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(841, 129);
            this.txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(156, 24);
            this.txt_total.TabIndex = 91;
            // 
            // txt_totalImpuesto
            // 
            this.txt_totalImpuesto.Enabled = false;
            this.txt_totalImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalImpuesto.Location = new System.Drawing.Point(841, 59);
            this.txt_totalImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_totalImpuesto.Name = "txt_totalImpuesto";
            this.txt_totalImpuesto.Size = new System.Drawing.Size(156, 24);
            this.txt_totalImpuesto.TabIndex = 95;
            // 
            // lbl_subTo
            // 
            this.lbl_subTo.AutoSize = true;
            this.lbl_subTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTo.Location = new System.Drawing.Point(644, 62);
            this.lbl_subTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subTo.Name = "lbl_subTo";
            this.lbl_subTo.Size = new System.Drawing.Size(110, 18);
            this.lbl_subTo.TabIndex = 96;
            this.lbl_subTo.Text = "Total Impuesto:";
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Enabled = false;
            this.txt_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subTotal.Location = new System.Drawing.Point(841, 96);
            this.txt_subTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.Size = new System.Drawing.Size(156, 24);
            this.txt_subTotal.TabIndex = 93;
            // 
            // lbl_totalImpuesto
            // 
            this.lbl_totalImpuesto.AutoSize = true;
            this.lbl_totalImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalImpuesto.Location = new System.Drawing.Point(644, 102);
            this.lbl_totalImpuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalImpuesto.Name = "lbl_totalImpuesto";
            this.lbl_totalImpuesto.Size = new System.Drawing.Size(75, 18);
            this.lbl_totalImpuesto.TabIndex = 94;
            this.lbl_totalImpuesto.Text = "Sub Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(581, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(492, 333);
            this.dataGridView1.TabIndex = 95;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "COD Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(794, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 94;
            this.label8.Text = "Entregado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "Solicitado";
            // 
            // BTn_guardar
            // 
            this.BTn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTn_guardar.FlatAppearance.BorderSize = 3;
            this.BTn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BTn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTn_guardar.Location = new System.Drawing.Point(929, 840);
            this.BTn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.BTn_guardar.Name = "BTn_guardar";
            this.BTn_guardar.Size = new System.Drawing.Size(169, 33);
            this.BTn_guardar.TabIndex = 86;
            this.BTn_guardar.Text = "Guardar";
            this.BTn_guardar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "NIT Proveedor:";
            // 
            // txt_nit
            // 
            this.txt_nit.Enabled = false;
            this.txt_nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nit.Location = new System.Drawing.Point(273, 132);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(156, 24);
            this.txt_nit.TabIndex = 97;
            // 
            // gb_impuestos
            // 
            this.gb_impuestos.Controls.Add(this.btn_buscarI);
            this.gb_impuestos.Controls.Add(this.lbl_nombre);
            this.gb_impuestos.Controls.Add(this.txt_nombreImpuesto);
            this.gb_impuestos.Controls.Add(this.lbl_valor);
            this.gb_impuestos.Controls.Add(this.lbl_codImpuesto);
            this.gb_impuestos.Controls.Add(this.txt_valor);
            this.gb_impuestos.Controls.Add(this.txt_codImpuesto);
            this.gb_impuestos.Controls.Add(this.lbl_subTo);
            this.gb_impuestos.Controls.Add(this.txt_totalImpuesto);
            this.gb_impuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_impuestos.Location = new System.Drawing.Point(11, 269);
            this.gb_impuestos.Name = "gb_impuestos";
            this.gb_impuestos.Size = new System.Drawing.Size(1086, 114);
            this.gb_impuestos.TabIndex = 95;
            this.gb_impuestos.TabStop = false;
            this.gb_impuestos.Text = "Impuestos";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(76, 65);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(131, 18);
            this.lbl_nombre.TabIndex = 104;
            this.lbl_nombre.Text = "Nombre Impuesto:";
            // 
            // txt_nombreImpuesto
            // 
            this.txt_nombreImpuesto.Enabled = false;
            this.txt_nombreImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreImpuesto.Location = new System.Drawing.Point(273, 62);
            this.txt_nombreImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreImpuesto.Name = "txt_nombreImpuesto";
            this.txt_nombreImpuesto.Size = new System.Drawing.Size(156, 24);
            this.txt_nombreImpuesto.TabIndex = 103;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(644, 22);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(111, 18);
            this.lbl_valor.TabIndex = 102;
            this.lbl_valor.Text = "Valor Impuesto:";
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(841, 19);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(156, 24);
            this.txt_valor.TabIndex = 101;
            // 
            // lbl_codImpuesto
            // 
            this.lbl_codImpuesto.AutoSize = true;
            this.lbl_codImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codImpuesto.Location = new System.Drawing.Point(76, 22);
            this.lbl_codImpuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codImpuesto.Name = "lbl_codImpuesto";
            this.lbl_codImpuesto.Size = new System.Drawing.Size(145, 18);
            this.lbl_codImpuesto.TabIndex = 100;
            this.lbl_codImpuesto.Text = "Codigo de Impuesto:";
            // 
            // txt_codImpuesto
            // 
            this.txt_codImpuesto.Enabled = false;
            this.txt_codImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codImpuesto.Location = new System.Drawing.Point(273, 19);
            this.txt_codImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codImpuesto.Name = "txt_codImpuesto";
            this.txt_codImpuesto.Size = new System.Drawing.Size(156, 24);
            this.txt_codImpuesto.TabIndex = 99;
            // 
            // gb_encabezado
            // 
            this.gb_encabezado.Controls.Add(this.dtp_fecha);
            this.gb_encabezado.Controls.Add(this.label2);
            this.gb_encabezado.Controls.Add(this.lbl_codU);
            this.gb_encabezado.Controls.Add(this.txt_CODproveedor);
            this.gb_encabezado.Controls.Add(this.txt_nit);
            this.gb_encabezado.Controls.Add(this.txt_total);
            this.gb_encabezado.Controls.Add(this.Lbl_codOrden);
            this.gb_encabezado.Controls.Add(this.txt_Nombreproveedor);
            this.gb_encabezado.Controls.Add(this.Txt_Cod);
            this.gb_encabezado.Controls.Add(this.lbl_codPro);
            this.gb_encabezado.Controls.Add(this.lbl_total);
            this.gb_encabezado.Controls.Add(this.label3);
            this.gb_encabezado.Controls.Add(this.txt_CODUsuario);
            this.gb_encabezado.Controls.Add(this.lbl_totalImpuesto);
            this.gb_encabezado.Controls.Add(this.lbl_nomPro);
            this.gb_encabezado.Controls.Add(this.txt_subTotal);
            this.gb_encabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_encabezado.Location = new System.Drawing.Point(11, 86);
            this.gb_encabezado.Name = "gb_encabezado";
            this.gb_encabezado.Size = new System.Drawing.Size(1086, 177);
            this.gb_encabezado.TabIndex = 96;
            this.gb_encabezado.TabStop = false;
            this.gb_encabezado.Text = "Encabezado";
            // 
            // gp_detalle
            // 
            this.gp_detalle.Controls.Add(this.dataGridView1);
            this.gp_detalle.Controls.Add(this.label7);
            this.gp_detalle.Controls.Add(this.label8);
            this.gp_detalle.Controls.Add(this.Btn_pasaUno);
            this.gp_detalle.Controls.Add(this.Btn_pasarTodo);
            this.gp_detalle.Controls.Add(this.Dgv_pedido);
            this.gp_detalle.Controls.Add(this.Btn_pasarUnoI);
            this.gp_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_detalle.Location = new System.Drawing.Point(11, 401);
            this.gp_detalle.Name = "gp_detalle";
            this.gp_detalle.Size = new System.Drawing.Size(1086, 422);
            this.gp_detalle.TabIndex = 96;
            this.gp_detalle.TabStop = false;
            this.gp_detalle.Text = "Detalle";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(841, 64);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(156, 26);
            this.dtp_fecha.TabIndex = 99;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            // 
            // btn_buscarI
            // 
            this.btn_buscarI.BackgroundImage = global::Capa_Diseño_SCM.Properties.Resources.icons8_espionaje_42;
            this.btn_buscarI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarI.Location = new System.Drawing.Point(445, 18);
            this.btn_buscarI.Name = "btn_buscarI";
            this.btn_buscarI.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarI.TabIndex = 105;
            this.btn_buscarI.UseVisualStyleBackColor = true;
            this.btn_buscarI.Click += new System.EventHandler(this.btn_buscarI_Click);
            // 
            // Frm_FacturaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 882);
            this.Controls.Add(this.gp_detalle);
            this.Controls.Add(this.gb_encabezado);
            this.Controls.Add(this.gb_impuestos);
            this.Controls.Add(this.BTn_guardar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FacturaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FacturaProveedores";
            this.Load += new System.EventHandler(this.Frm_FacturaProveedores_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_impuestos.ResumeLayout(false);
            this.gb_impuestos.PerformLayout();
            this.gb_encabezado.ResumeLayout(false);
            this.gb_encabezado.PerformLayout();
            this.gp_detalle.ResumeLayout(false);
            this.gp_detalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_codOrden;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.Label lbl_codPro;
        private System.Windows.Forms.TextBox txt_CODproveedor;
        public System.Windows.Forms.DataGridView Dgv_pedido;
        private System.Windows.Forms.Button Btn_pasarTodo;
        private System.Windows.Forms.Button Btn_pasaUno;
        private System.Windows.Forms.Button Btn_pasarUnoI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nomPro;
        private System.Windows.Forms.TextBox txt_Nombreproveedor;
        private System.Windows.Forms.Label lbl_codU;
        private System.Windows.Forms.TextBox txt_CODUsuario;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button BTn_guardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.Label lbl_totalImpuesto;
        private System.Windows.Forms.TextBox txt_totalImpuesto;
        private System.Windows.Forms.Label lbl_subTo;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox gb_impuestos;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_codImpuesto;
        private System.Windows.Forms.TextBox txt_codImpuesto;
        private System.Windows.Forms.GroupBox gb_encabezado;
        private System.Windows.Forms.GroupBox gp_detalle;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombreImpuesto;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_buscarI;
    }
}