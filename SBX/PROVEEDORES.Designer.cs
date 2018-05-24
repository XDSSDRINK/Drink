namespace SBX
{
    partial class PROVEEDORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PROVEEDORES));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.btnExportaraExcel = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDigitoVerficacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipoDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClBarrioVereda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCelular1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCelular2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSitioWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.Controls.Add(this.btnExportaraExcel);
            this.pnlArriba.Controls.Add(this.txtBuscar);
            this.pnlArriba.Controls.Add(this.btnBuscar);
            this.pnlArriba.Controls.Add(this.btnEliminar);
            this.pnlArriba.Controls.Add(this.btnActualizar);
            this.pnlArriba.Controls.Add(this.btnAgregar);
            this.pnlArriba.Controls.Add(this.btnCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(778, 52);
            this.pnlArriba.TabIndex = 4;
            // 
            // btnExportaraExcel
            // 
            this.btnExportaraExcel.BackColor = System.Drawing.SystemColors.Window;
            this.btnExportaraExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportaraExcel.FlatAppearance.BorderSize = 0;
            this.btnExportaraExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportaraExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportaraExcel.Image")));
            this.btnExportaraExcel.Location = new System.Drawing.Point(136, 12);
            this.btnExportaraExcel.Name = "btnExportaraExcel";
            this.btnExportaraExcel.Size = new System.Drawing.Size(33, 31);
            this.btnExportaraExcel.TabIndex = 7;
            this.btnExportaraExcel.UseVisualStyleBackColor = false;
            this.btnExportaraExcel.Click += new System.EventHandler(this.btnExportaraExcel_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(467, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar proveedor";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(664, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(97, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(58, 11);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(33, 31);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(19, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(750, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 487);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(764, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 487);
            this.panel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(14, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 14);
            this.panel4.TabIndex = 8;
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProductos.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgProductos.Location = new System.Drawing.Point(14, 52);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(750, 473);
            this.dtgProductos.TabIndex = 9;
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.AllowUserToAddRows = false;
            this.dtgProveedores.AllowUserToDeleteRows = false;
            this.dtgProveedores.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.ClDNI,
            this.ClDigitoVerficacion,
            this.ClTipoProveedor,
            this.ClTipoDNI,
            this.ClRazonSocial,
            this.ClNombreComercial,
            this.ClNombres,
            this.ClApellidos,
            this.ClDepartamento,
            this.ClMunicipio,
            this.ClBarrioVereda,
            this.ClDireccion,
            this.ClTelefono,
            this.ClExtension,
            this.ClEstado,
            this.ClFax,
            this.ClCelular1,
            this.ClCelular2,
            this.ClEmail,
            this.ClSitioWeb,
            this.ClIVA,
            this.ClBanco,
            this.ClTipoCuenta,
            this.ClNumeroCuenta});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProveedores.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProveedores.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgProveedores.Location = new System.Drawing.Point(14, 52);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgProveedores.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgProveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedores.Size = new System.Drawing.Size(750, 473);
            this.dtgProveedores.TabIndex = 10;
            this.dtgProveedores.DoubleClick += new System.EventHandler(this.dtgProveedores_DoubleClick);
            // 
            // ClCodigo
            // 
            this.ClCodigo.HeaderText = "Codigo";
            this.ClCodigo.Name = "ClCodigo";
            this.ClCodigo.ReadOnly = true;
            // 
            // ClDNI
            // 
            this.ClDNI.HeaderText = "DNI";
            this.ClDNI.Name = "ClDNI";
            this.ClDNI.ReadOnly = true;
            this.ClDNI.Width = 150;
            // 
            // ClDigitoVerficacion
            // 
            this.ClDigitoVerficacion.HeaderText = "Digito verificacion";
            this.ClDigitoVerficacion.Name = "ClDigitoVerficacion";
            this.ClDigitoVerficacion.ReadOnly = true;
            // 
            // ClTipoProveedor
            // 
            this.ClTipoProveedor.HeaderText = "Tipo proveedor";
            this.ClTipoProveedor.Name = "ClTipoProveedor";
            this.ClTipoProveedor.ReadOnly = true;
            this.ClTipoProveedor.Width = 150;
            // 
            // ClTipoDNI
            // 
            this.ClTipoDNI.HeaderText = "Tipo DNI";
            this.ClTipoDNI.Name = "ClTipoDNI";
            this.ClTipoDNI.ReadOnly = true;
            // 
            // ClRazonSocial
            // 
            this.ClRazonSocial.HeaderText = "Razon social";
            this.ClRazonSocial.Name = "ClRazonSocial";
            this.ClRazonSocial.ReadOnly = true;
            this.ClRazonSocial.Width = 200;
            // 
            // ClNombreComercial
            // 
            this.ClNombreComercial.HeaderText = "Nombre comercial";
            this.ClNombreComercial.Name = "ClNombreComercial";
            this.ClNombreComercial.ReadOnly = true;
            this.ClNombreComercial.Width = 220;
            // 
            // ClNombres
            // 
            this.ClNombres.HeaderText = "Nombres";
            this.ClNombres.Name = "ClNombres";
            this.ClNombres.ReadOnly = true;
            this.ClNombres.Visible = false;
            // 
            // ClApellidos
            // 
            this.ClApellidos.HeaderText = "Apellidos";
            this.ClApellidos.Name = "ClApellidos";
            this.ClApellidos.ReadOnly = true;
            this.ClApellidos.Visible = false;
            // 
            // ClDepartamento
            // 
            this.ClDepartamento.HeaderText = "Departamento";
            this.ClDepartamento.Name = "ClDepartamento";
            this.ClDepartamento.ReadOnly = true;
            this.ClDepartamento.Width = 150;
            // 
            // ClMunicipio
            // 
            this.ClMunicipio.HeaderText = "Municipio";
            this.ClMunicipio.Name = "ClMunicipio";
            this.ClMunicipio.ReadOnly = true;
            // 
            // ClBarrioVereda
            // 
            this.ClBarrioVereda.HeaderText = "Barrio/Vereda";
            this.ClBarrioVereda.Name = "ClBarrioVereda";
            this.ClBarrioVereda.ReadOnly = true;
            // 
            // ClDireccion
            // 
            this.ClDireccion.HeaderText = "Direccion";
            this.ClDireccion.Name = "ClDireccion";
            this.ClDireccion.ReadOnly = true;
            // 
            // ClTelefono
            // 
            this.ClTelefono.HeaderText = "Telefono";
            this.ClTelefono.Name = "ClTelefono";
            this.ClTelefono.ReadOnly = true;
            // 
            // ClExtension
            // 
            this.ClExtension.HeaderText = "Extension";
            this.ClExtension.Name = "ClExtension";
            this.ClExtension.ReadOnly = true;
            // 
            // ClEstado
            // 
            this.ClEstado.HeaderText = "Estado";
            this.ClEstado.Name = "ClEstado";
            this.ClEstado.ReadOnly = true;
            // 
            // ClFax
            // 
            this.ClFax.HeaderText = "Fax";
            this.ClFax.Name = "ClFax";
            this.ClFax.ReadOnly = true;
            // 
            // ClCelular1
            // 
            this.ClCelular1.HeaderText = "Celular 1";
            this.ClCelular1.Name = "ClCelular1";
            this.ClCelular1.ReadOnly = true;
            // 
            // ClCelular2
            // 
            this.ClCelular2.HeaderText = "Celular 2";
            this.ClCelular2.Name = "ClCelular2";
            this.ClCelular2.ReadOnly = true;
            // 
            // ClEmail
            // 
            this.ClEmail.HeaderText = "Email";
            this.ClEmail.Name = "ClEmail";
            this.ClEmail.ReadOnly = true;
            this.ClEmail.Width = 200;
            // 
            // ClSitioWeb
            // 
            this.ClSitioWeb.HeaderText = "Sitio web";
            this.ClSitioWeb.Name = "ClSitioWeb";
            this.ClSitioWeb.ReadOnly = true;
            this.ClSitioWeb.Width = 200;
            // 
            // ClIVA
            // 
            this.ClIVA.HeaderText = "IVA";
            this.ClIVA.Name = "ClIVA";
            this.ClIVA.ReadOnly = true;
            // 
            // ClBanco
            // 
            this.ClBanco.HeaderText = "Banco";
            this.ClBanco.Name = "ClBanco";
            this.ClBanco.ReadOnly = true;
            // 
            // ClTipoCuenta
            // 
            this.ClTipoCuenta.HeaderText = "Tipo cuenta";
            this.ClTipoCuenta.Name = "ClTipoCuenta";
            this.ClTipoCuenta.ReadOnly = true;
            // 
            // ClNumeroCuenta
            // 
            this.ClNumeroCuenta.HeaderText = "# Cuenta";
            this.ClNumeroCuenta.Name = "ClNumeroCuenta";
            this.ClNumeroCuenta.ReadOnly = true;
            // 
            // PROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(778, 539);
            this.Controls.Add(this.dtgProveedores);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PROVEEDORES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.PROVEEDORES_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Button btnExportaraExcel;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDigitoVerficacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClBarrioVereda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCelular1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCelular2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSitioWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNumeroCuenta;
    }
}