namespace SBX
{
    partial class REGISTRO_VENTASS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO_VENTASS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.btnAnularVenta = new System.Windows.Forms.Button();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtgRegistroVentas = new System.Windows.Forms.DataGridView();
            this.ClNombreDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClConseDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            this.pnlArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DimGray;
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(810, 38);
            this.pnlTitulo.TabIndex = 3;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(782, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArriba.Controls.Add(this.btnAnularVenta);
            this.pnlArriba.Controls.Add(this.btnDescuento);
            this.pnlArriba.Controls.Add(this.btnSacar);
            this.pnlArriba.Controls.Add(this.btnImprimir);
            this.pnlArriba.Controls.Add(this.btnBuscarProducto);
            this.pnlArriba.Controls.Add(this.txtProducto);
            this.pnlArriba.Controls.Add(this.btnGuardar);
            this.pnlArriba.Location = new System.Drawing.Point(3, 39);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(804, 52);
            this.pnlArriba.TabIndex = 6;
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnularVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularVenta.Enabled = false;
            this.btnAnularVenta.FlatAppearance.BorderSize = 0;
            this.btnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnAnularVenta.Image")));
            this.btnAnularVenta.Location = new System.Drawing.Point(175, 11);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Size = new System.Drawing.Size(33, 31);
            this.btnAnularVenta.TabIndex = 11;
            this.btnAnularVenta.UseVisualStyleBackColor = false;
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.btnDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuento.Enabled = false;
            this.btnDescuento.FlatAppearance.BorderSize = 0;
            this.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.Location = new System.Drawing.Point(136, 11);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(33, 31);
            this.btnDescuento.TabIndex = 10;
            this.btnDescuento.UseVisualStyleBackColor = false;
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.Enabled = false;
            this.btnSacar.FlatAppearance.BorderSize = 0;
            this.btnSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacar.Image = ((System.Drawing.Image)(resources.GetObject("btnSacar.Image")));
            this.btnSacar.Location = new System.Drawing.Point(97, 11);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(33, 31);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(58, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(33, 31);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(697, 13);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(25, 25);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Gray;
            this.txtProducto.Location = new System.Drawing.Point(493, 15);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(195, 21);
            this.txtProducto.TabIndex = 6;
            this.txtProducto.Text = "Producto";
            this.txtProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyUp);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(19, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 31);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblNombreCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCambio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRecibido);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtImpuesto);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Location = new System.Drawing.Point(3, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 140);
            this.panel1.TabIndex = 7;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(338, 17);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(51, 17);
            this.lblNombreCliente.TabIndex = 82;
            this.lblNombreCliente.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.Gray;
            this.txtCambio.Location = new System.Drawing.Point(190, 81);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(195, 21);
            this.txtCambio.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Recibido";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecibido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.ForeColor = System.Drawing.Color.Gray;
            this.txtRecibido.Location = new System.Drawing.Point(190, 55);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(195, 21);
            this.txtRecibido.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gray;
            this.txtCantidad.Location = new System.Drawing.Point(511, 54);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(195, 21);
            this.txtCantidad.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.ForeColor = System.Drawing.Color.Gray;
            this.txtImpuesto.Location = new System.Drawing.Point(511, 81);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(195, 21);
            this.txtImpuesto.TabIndex = 74;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(419, 109);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 17);
            this.label22.TabIndex = 73;
            this.label22.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtTotal.Location = new System.Drawing.Point(511, 108);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 21);
            this.txtTotal.TabIndex = 10;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(299, 13);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(25, 25);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Gray;
            this.txtCliente.Location = new System.Drawing.Point(95, 15);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(195, 21);
            this.txtCliente.TabIndex = 8;
            this.txtCliente.Text = "Cliente";
            // 
            // dtgRegistroVentas
            // 
            this.dtgRegistroVentas.AllowUserToAddRows = false;
            this.dtgRegistroVentas.AllowUserToDeleteRows = false;
            this.dtgRegistroVentas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgRegistroVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRegistroVentas.BackgroundColor = System.Drawing.Color.White;
            this.dtgRegistroVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgRegistroVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRegistroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNombreDoc,
            this.ClConseDoc,
            this.ClItem,
            this.ClCodigoBarras,
            this.ClNombre,
            this.ClReferencia,
            this.ClCantidad,
            this.ClValorUnidad,
            this.ClDescuento,
            this.ClValorDesc,
            this.ClValorTotal,
            this.ClIva,
            this.ClValorIva});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRegistroVentas.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgRegistroVentas.Location = new System.Drawing.Point(3, 92);
            this.dtgRegistroVentas.Name = "dtgRegistroVentas";
            this.dtgRegistroVentas.ReadOnly = true;
            this.dtgRegistroVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgRegistroVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgRegistroVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgRegistroVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgRegistroVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRegistroVentas.Size = new System.Drawing.Size(804, 233);
            this.dtgRegistroVentas.TabIndex = 24;
            // 
            // ClNombreDoc
            // 
            this.ClNombreDoc.HeaderText = "Nombre Doc";
            this.ClNombreDoc.Name = "ClNombreDoc";
            this.ClNombreDoc.ReadOnly = true;
            this.ClNombreDoc.Width = 130;
            // 
            // ClConseDoc
            // 
            this.ClConseDoc.HeaderText = "Conse Doc";
            this.ClConseDoc.Name = "ClConseDoc";
            this.ClConseDoc.ReadOnly = true;
            this.ClConseDoc.Width = 120;
            // 
            // ClItem
            // 
            this.ClItem.HeaderText = "Item";
            this.ClItem.Name = "ClItem";
            this.ClItem.ReadOnly = true;
            // 
            // ClCodigoBarras
            // 
            this.ClCodigoBarras.HeaderText = "Cod. Barras";
            this.ClCodigoBarras.Name = "ClCodigoBarras";
            this.ClCodigoBarras.ReadOnly = true;
            this.ClCodigoBarras.Width = 120;
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            // 
            // ClReferencia
            // 
            this.ClReferencia.HeaderText = "Referencia";
            this.ClReferencia.Name = "ClReferencia";
            this.ClReferencia.ReadOnly = true;
            this.ClReferencia.Width = 120;
            // 
            // ClCantidad
            // 
            this.ClCantidad.HeaderText = "Cantidad";
            this.ClCantidad.Name = "ClCantidad";
            this.ClCantidad.ReadOnly = true;
            // 
            // ClValorUnidad
            // 
            this.ClValorUnidad.HeaderText = "Precio UN";
            this.ClValorUnidad.Name = "ClValorUnidad";
            this.ClValorUnidad.ReadOnly = true;
            this.ClValorUnidad.Width = 120;
            // 
            // ClDescuento
            // 
            this.ClDescuento.HeaderText = "% Desc.";
            this.ClDescuento.Name = "ClDescuento";
            this.ClDescuento.ReadOnly = true;
            // 
            // ClValorDesc
            // 
            this.ClValorDesc.HeaderText = "Valor Desc.";
            this.ClValorDesc.Name = "ClValorDesc";
            this.ClValorDesc.ReadOnly = true;
            this.ClValorDesc.Width = 130;
            // 
            // ClValorTotal
            // 
            this.ClValorTotal.HeaderText = "Total";
            this.ClValorTotal.Name = "ClValorTotal";
            this.ClValorTotal.ReadOnly = true;
            // 
            // ClIva
            // 
            this.ClIva.HeaderText = "% IVA";
            this.ClIva.Name = "ClIva";
            this.ClIva.ReadOnly = true;
            // 
            // ClValorIva
            // 
            this.ClValorIva.HeaderText = "Valor IVA";
            this.ClValorIva.Name = "ClValorIva";
            this.ClValorIva.ReadOnly = true;
            // 
            // REGISTRO_VENTASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(810, 471);
            this.Controls.Add(this.dtgRegistroVentas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlArriba);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "REGISTRO_VENTASS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO_VENTASS";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Button btnAnularVenta;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dtgRegistroVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClConseDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorIva;
    }
}