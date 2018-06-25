namespace SBX
{
    partial class CLIENTES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTES));
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.btnExportaraExcel = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
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
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.Controls.Add(this.btnDescuentos);
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
            this.pnlArriba.Size = new System.Drawing.Size(809, 52);
            this.pnlArriba.TabIndex = 5;
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
            this.txtBuscar.Location = new System.Drawing.Point(498, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar cliente";
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
            this.btnBuscar.Location = new System.Drawing.Point(695, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(97, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(58, 12);
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
            this.btnAgregar.Location = new System.Drawing.Point(19, 12);
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
            this.btnCerrar.Location = new System.Drawing.Point(781, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgClientes.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgClientes.Location = new System.Drawing.Point(0, 52);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(809, 397);
            this.dtgClientes.TabIndex = 11;
            this.dtgClientes.DoubleClick += new System.EventHandler(this.dtgClientes_DoubleClick);
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
            this.ClDigitoVerficacion.Width = 200;
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
            this.ClBarrioVereda.Width = 150;
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
            this.ClTipoCuenta.Width = 150;
            // 
            // ClNumeroCuenta
            // 
            this.ClNumeroCuenta.HeaderText = "# Cuenta";
            this.ClNumeroCuenta.Name = "ClNumeroCuenta";
            this.ClNumeroCuenta.ReadOnly = true;
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.BackColor = System.Drawing.SystemColors.Window;
            this.btnDescuentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuentos.FlatAppearance.BorderSize = 0;
            this.btnDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuentos.Image")));
            this.btnDescuentos.Location = new System.Drawing.Point(175, 12);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(33, 31);
            this.btnDescuentos.TabIndex = 8;
            this.btnDescuentos.UseVisualStyleBackColor = false;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 449);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Button btnExportaraExcel;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataGridView dtgClientes;
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
        private System.Windows.Forms.Button btnDescuentos;
    }
}