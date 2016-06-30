namespace SBX
{
    partial class PERSONAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PERSONAL));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.dtgPersonal = new System.Windows.Forms.DataGridView();
            this.ClCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCodigoDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCodigoMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClBarrioVereda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefonoFijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArriba.Controls.Add(this.txtBuscar);
            this.pnlArriba.Controls.Add(this.btnBuscar);
            this.pnlArriba.Controls.Add(this.btnEliminar);
            this.pnlArriba.Controls.Add(this.btnActualizar);
            this.pnlArriba.Controls.Add(this.btnAgregar);
            this.pnlArriba.Controls.Add(this.btnCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(651, 52);
            this.pnlArriba.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(340, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar";
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
            this.btnBuscar.Location = new System.Drawing.Point(537, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnCerrar.Location = new System.Drawing.Point(623, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgPersonal
            // 
            this.dtgPersonal.AllowUserToAddRows = false;
            this.dtgPersonal.AllowUserToDeleteRows = false;
            this.dtgPersonal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dtgPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigo,
            this.ClDNI,
            this.ClTipoIdentificacion,
            this.ClNombres,
            this.ClApellidos,
            this.ClCodigoDepartamento,
            this.ClDepartamento,
            this.ClCodigoMunicipio,
            this.ClMunicipio,
            this.ClBarrioVereda,
            this.ClDireccion,
            this.ClTelefonoFijo,
            this.ClEmail,
            this.ClCelular});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPersonal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPersonal.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgPersonal.Location = new System.Drawing.Point(0, 52);
            this.dtgPersonal.Name = "dtgPersonal";
            this.dtgPersonal.ReadOnly = true;
            this.dtgPersonal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPersonal.Size = new System.Drawing.Size(651, 357);
            this.dtgPersonal.TabIndex = 5;
            this.dtgPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonal_CellContentClick);
            this.dtgPersonal.DoubleClick += new System.EventHandler(this.dtgPersonal_DoubleClick);
            // 
            // ClCodigo
            // 
            this.ClCodigo.HeaderText = "Codigo";
            this.ClCodigo.Name = "ClCodigo";
            this.ClCodigo.ReadOnly = true;
            this.ClCodigo.Visible = false;
            // 
            // ClDNI
            // 
            this.ClDNI.HeaderText = "DNI";
            this.ClDNI.Name = "ClDNI";
            this.ClDNI.ReadOnly = true;
            // 
            // ClTipoIdentificacion
            // 
            this.ClTipoIdentificacion.HeaderText = "Tipo identificacion";
            this.ClTipoIdentificacion.Name = "ClTipoIdentificacion";
            this.ClTipoIdentificacion.ReadOnly = true;
            this.ClTipoIdentificacion.Width = 200;
            // 
            // ClNombres
            // 
            this.ClNombres.HeaderText = "Nombres";
            this.ClNombres.Name = "ClNombres";
            this.ClNombres.ReadOnly = true;
            // 
            // ClApellidos
            // 
            this.ClApellidos.HeaderText = "Apellidos";
            this.ClApellidos.Name = "ClApellidos";
            this.ClApellidos.ReadOnly = true;
            // 
            // ClCodigoDepartamento
            // 
            this.ClCodigoDepartamento.HeaderText = "Codigo Dp";
            this.ClCodigoDepartamento.Name = "ClCodigoDepartamento";
            this.ClCodigoDepartamento.ReadOnly = true;
            this.ClCodigoDepartamento.Visible = false;
            // 
            // ClDepartamento
            // 
            this.ClDepartamento.HeaderText = "Departamento";
            this.ClDepartamento.Name = "ClDepartamento";
            this.ClDepartamento.ReadOnly = true;
            this.ClDepartamento.Width = 200;
            // 
            // ClCodigoMunicipio
            // 
            this.ClCodigoMunicipio.HeaderText = "Codigo munp";
            this.ClCodigoMunicipio.Name = "ClCodigoMunicipio";
            this.ClCodigoMunicipio.ReadOnly = true;
            this.ClCodigoMunicipio.Visible = false;
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
            this.ClBarrioVereda.Width = 200;
            // 
            // ClDireccion
            // 
            this.ClDireccion.HeaderText = "Direccion";
            this.ClDireccion.Name = "ClDireccion";
            this.ClDireccion.ReadOnly = true;
            // 
            // ClTelefonoFijo
            // 
            this.ClTelefonoFijo.HeaderText = "Telefono fijo";
            this.ClTelefonoFijo.Name = "ClTelefonoFijo";
            this.ClTelefonoFijo.ReadOnly = true;
            this.ClTelefonoFijo.Width = 200;
            // 
            // ClEmail
            // 
            this.ClEmail.HeaderText = "Email";
            this.ClEmail.Name = "ClEmail";
            this.ClEmail.ReadOnly = true;
            // 
            // ClCelular
            // 
            this.ClCelular.HeaderText = "Celular";
            this.ClCelular.Name = "ClCelular";
            this.ClCelular.ReadOnly = true;
            // 
            // PERSONAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 409);
            this.Controls.Add(this.dtgPersonal);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PERSONAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONAL";
            this.Load += new System.EventHandler(this.PERSONAL_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonal)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClBarrioVereda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefonoFijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCelular;
    }
}