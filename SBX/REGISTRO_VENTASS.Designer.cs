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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO_VENTASS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCalculadora = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.txtCodInternoMesero = new System.Windows.Forms.TextBox();
            this.lblNomMesero = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.txtNomBoton = new System.Windows.Forms.TextBox();
            this.btnAnularVenta = new System.Windows.Forms.Button();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarMesero = new System.Windows.Forms.Button();
            this.lblCedulaMesero = new System.Windows.Forms.Label();
            this.txtCedulaMesero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescPuntos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
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
            this.ClValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculadora)).BeginInit();
            this.pnlArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DimGray;
            this.pnlTitulo.Controls.Add(this.btnCalculadora);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(850, 38);
            this.pnlTitulo.TabIndex = 3;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.Location = new System.Drawing.Point(738, 7);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(24, 24);
            this.btnCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCalculadora.TabIndex = 9;
            this.btnCalculadora.TabStop = false;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(822, 9);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArriba.Controls.Add(this.txtCodInternoMesero);
            this.pnlArriba.Controls.Add(this.lblNomMesero);
            this.pnlArriba.Controls.Add(this.lblMesa);
            this.pnlArriba.Controls.Add(this.txtNomBoton);
            this.pnlArriba.Controls.Add(this.btnAnularVenta);
            this.pnlArriba.Controls.Add(this.btnDescuento);
            this.pnlArriba.Controls.Add(this.btnSacar);
            this.pnlArriba.Controls.Add(this.btnImprimir);
            this.pnlArriba.Controls.Add(this.btnBuscarProducto);
            this.pnlArriba.Controls.Add(this.txtProducto);
            this.pnlArriba.Controls.Add(this.btnGuardar);
            this.pnlArriba.Location = new System.Drawing.Point(3, 39);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(845, 52);
            this.pnlArriba.TabIndex = 6;
            // 
            // txtCodInternoMesero
            // 
            this.txtCodInternoMesero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodInternoMesero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodInternoMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodInternoMesero.ForeColor = System.Drawing.Color.Gray;
            this.txtCodInternoMesero.Location = new System.Drawing.Point(223, 27);
            this.txtCodInternoMesero.Name = "txtCodInternoMesero";
            this.txtCodInternoMesero.Size = new System.Drawing.Size(48, 20);
            this.txtCodInternoMesero.TabIndex = 91;
            this.txtCodInternoMesero.Visible = false;
            // 
            // lblNomMesero
            // 
            this.lblNomMesero.AutoSize = true;
            this.lblNomMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMesero.Location = new System.Drawing.Point(257, 32);
            this.lblNomMesero.Name = "lblNomMesero";
            this.lblNomMesero.Size = new System.Drawing.Size(61, 15);
            this.lblNomMesero.TabIndex = 90;
            this.lblNomMesero.Text = "ATIENDE:";
            this.lblNomMesero.Visible = false;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(323, 11);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(44, 15);
            this.lblMesa.TabIndex = 88;
            this.lblMesa.Text = "MESA:";
            this.lblMesa.Visible = false;
            // 
            // txtNomBoton
            // 
            this.txtNomBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomBoton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBoton.ForeColor = System.Drawing.Color.Gray;
            this.txtNomBoton.Location = new System.Drawing.Point(223, 3);
            this.txtNomBoton.Name = "txtNomBoton";
            this.txtNomBoton.Size = new System.Drawing.Size(48, 20);
            this.txtNomBoton.TabIndex = 89;
            this.txtNomBoton.Visible = false;
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnularVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularVenta.FlatAppearance.BorderSize = 0;
            this.btnAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnAnularVenta.Image")));
            this.btnAnularVenta.Location = new System.Drawing.Point(175, 11);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Size = new System.Drawing.Size(33, 31);
            this.btnAnularVenta.TabIndex = 11;
            this.btnAnularVenta.UseVisualStyleBackColor = false;
            this.btnAnularVenta.Click += new System.EventHandler(this.btnAnularVenta_Click);
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackColor = System.Drawing.SystemColors.Window;
            this.btnDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuento.FlatAppearance.BorderSize = 0;
            this.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.Location = new System.Drawing.Point(136, 11);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(33, 31);
            this.btnDescuento.TabIndex = 10;
            this.btnDescuento.UseVisualStyleBackColor = false;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacar.FlatAppearance.BorderSize = 0;
            this.btnSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacar.Image = ((System.Drawing.Image)(resources.GetObject("btnSacar.Image")));
            this.btnSacar.Location = new System.Drawing.Point(97, 11);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(33, 31);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
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
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(748, 13);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(25, 25);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.Gray;
            this.txtProducto.Location = new System.Drawing.Point(534, 15);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(195, 20);
            this.txtProducto.TabIndex = 6;
            this.txtProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyUp);
            this.txtProducto.Leave += new System.EventHandler(this.txtProducto_Leave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(19, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 31);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnBuscarMesero);
            this.panel1.Controls.Add(this.lblCedulaMesero);
            this.panel1.Controls.Add(this.txtCedulaMesero);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDescPuntos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPuntos);
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
            this.panel1.Size = new System.Drawing.Size(845, 163);
            this.panel1.TabIndex = 7;
            // 
            // btnBuscarMesero
            // 
            this.btnBuscarMesero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMesero.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarMesero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMesero.FlatAppearance.BorderSize = 0;
            this.btnBuscarMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMesero.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMesero.Image")));
            this.btnBuscarMesero.Location = new System.Drawing.Point(748, 6);
            this.btnBuscarMesero.Name = "btnBuscarMesero";
            this.btnBuscarMesero.Size = new System.Drawing.Size(33, 31);
            this.btnBuscarMesero.TabIndex = 90;
            this.btnBuscarMesero.UseVisualStyleBackColor = false;
            this.btnBuscarMesero.Visible = false;
            this.btnBuscarMesero.Click += new System.EventHandler(this.btnBuscarMesero_Click);
            // 
            // lblCedulaMesero
            // 
            this.lblCedulaMesero.AutoSize = true;
            this.lblCedulaMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaMesero.Location = new System.Drawing.Point(455, 22);
            this.lblCedulaMesero.Name = "lblCedulaMesero";
            this.lblCedulaMesero.Size = new System.Drawing.Size(52, 15);
            this.lblCedulaMesero.TabIndex = 89;
            this.lblCedulaMesero.Text = "Mesero:";
            // 
            // txtCedulaMesero
            // 
            this.txtCedulaMesero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedulaMesero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaMesero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaMesero.ForeColor = System.Drawing.Color.Gray;
            this.txtCedulaMesero.Location = new System.Drawing.Point(539, 16);
            this.txtCedulaMesero.Name = "txtCedulaMesero";
            this.txtCedulaMesero.Size = new System.Drawing.Size(195, 21);
            this.txtCedulaMesero.TabIndex = 88;
            this.txtCedulaMesero.Text = "Buscar Mesero";
            this.txtCedulaMesero.Enter += new System.EventHandler(this.txtCodigoMesero_Enter);
            this.txtCedulaMesero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoMesero_KeyUp);
            this.txtCedulaMesero.Leave += new System.EventHandler(this.txtCodigoMesero_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 86;
            this.label7.Text = "Desc. Puntos";
            // 
            // txtDescPuntos
            // 
            this.txtDescPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescPuntos.Enabled = false;
            this.txtDescPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescPuntos.ForeColor = System.Drawing.Color.Gray;
            this.txtDescPuntos.Location = new System.Drawing.Point(539, 107);
            this.txtDescPuntos.Name = "txtDescPuntos";
            this.txtDescPuntos.Size = new System.Drawing.Size(195, 20);
            this.txtDescPuntos.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "Puntos";
            // 
            // txtPuntos
            // 
            this.txtPuntos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuntos.Enabled = false;
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.ForeColor = System.Drawing.Color.Gray;
            this.txtPuntos.Location = new System.Drawing.Point(201, 107);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(195, 20);
            this.txtPuntos.TabIndex = 83;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(391, 16);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(15, 15);
            this.lblNombreCliente.TabIndex = 82;
            this.lblNombreCliente.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.Gray;
            this.txtCambio.Location = new System.Drawing.Point(201, 81);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(195, 20);
            this.txtCambio.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "Recibido";
            // 
            // txtRecibido
            // 
            this.txtRecibido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.ForeColor = System.Drawing.Color.Gray;
            this.txtRecibido.Location = new System.Drawing.Point(201, 55);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(195, 20);
            this.txtRecibido.TabIndex = 78;
            //this.txtRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibido_KeyPress);
            //this.txtRecibido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecibido_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 77;
            this.label5.Text = "T. Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.Gray;
            this.txtCantidad.Location = new System.Drawing.Point(539, 54);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(195, 20);
            this.txtCantidad.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "T. Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.ForeColor = System.Drawing.Color.Gray;
            this.txtImpuesto.Location = new System.Drawing.Point(539, 81);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(195, 20);
            this.txtImpuesto.TabIndex = 74;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(455, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 15);
            this.label22.TabIndex = 73;
            this.label22.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtTotal.Location = new System.Drawing.Point(539, 133);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 20);
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
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(352, 9);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(25, 25);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Gray;
            this.txtCliente.Location = new System.Drawing.Point(140, 12);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(195, 20);
            this.txtCliente.TabIndex = 8;
            this.txtCliente.Text = "Cliente";
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            this.txtCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyUp);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ClValorTotal,
            this.ClDescuento,
            this.ClValorDesc,
            this.ClIva,
            this.ClValorIva});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistroVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRegistroVentas.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgRegistroVentas.Location = new System.Drawing.Point(3, 92);
            this.dtgRegistroVentas.Name = "dtgRegistroVentas";
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
            this.dtgRegistroVentas.Size = new System.Drawing.Size(845, 233);
            this.dtgRegistroVentas.TabIndex = 24;
            this.dtgRegistroVentas.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRegistroVentas_CellLeave);
            this.dtgRegistroVentas.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRegistroVentas_CellMouseMove);
            this.dtgRegistroVentas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgRegistroVentas_CellValidating);
            this.dtgRegistroVentas.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRegistroVentas_RowValidated);
            this.dtgRegistroVentas.Enter += new System.EventHandler(this.dtgRegistroVentas_Enter);
            this.dtgRegistroVentas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtgRegistroVentas_KeyUp);
            this.dtgRegistroVentas.Validating += new System.ComponentModel.CancelEventHandler(this.dtgRegistroVentas_Validating);
            // 
            // ClNombreDoc
            // 
            this.ClNombreDoc.HeaderText = "Nombre Doc";
            this.ClNombreDoc.Name = "ClNombreDoc";
            this.ClNombreDoc.ReadOnly = true;
            this.ClNombreDoc.Visible = false;
            this.ClNombreDoc.Width = 130;
            // 
            // ClConseDoc
            // 
            this.ClConseDoc.HeaderText = "Conse Doc";
            this.ClConseDoc.Name = "ClConseDoc";
            this.ClConseDoc.ReadOnly = true;
            this.ClConseDoc.Visible = false;
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
            // 
            // ClValorUnidad
            // 
            this.ClValorUnidad.HeaderText = "Precio UN";
            this.ClValorUnidad.Name = "ClValorUnidad";
            this.ClValorUnidad.ReadOnly = true;
            this.ClValorUnidad.Width = 120;
            // 
            // ClValorTotal
            // 
            this.ClValorTotal.HeaderText = "Total";
            this.ClValorTotal.Name = "ClValorTotal";
            this.ClValorTotal.ReadOnly = true;
            this.ClValorTotal.Width = 160;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // REGISTRO_VENTASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(850, 501);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculadora)).EndInit();
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistroVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox btnCalculadora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClConseDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorIva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescPuntos;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.TextBox txtNomBoton;
        private System.Windows.Forms.Label lblNomMesero;
        private System.Windows.Forms.Label lblCedulaMesero;
        private System.Windows.Forms.TextBox txtCedulaMesero;
        private System.Windows.Forms.TextBox txtCodInternoMesero;
        private System.Windows.Forms.Button btnBuscarMesero;
    }
}