namespace SBX
{
    partial class USUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USUARIOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.ClCodigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCodigoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTipoDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClBarrioVereda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClContrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
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
            this.pnlArriba.Size = new System.Drawing.Size(701, 52);
            this.pnlArriba.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(390, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar usuario";
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
            this.btnBuscar.Location = new System.Drawing.Point(587, 9);
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
            this.btnCerrar.Location = new System.Drawing.Point(665, 15);
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
            this.panel3.Size = new System.Drawing.Size(14, 391);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(687, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 391);
            this.panel2.TabIndex = 7;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClCodigoUsuario,
            this.ClUsuario,
            this.ClCodigoPersona,
            this.ClDNI,
            this.ClTipoDNI,
            this.ClNombres,
            this.ClApellidos,
            this.ClDepartamento,
            this.ClMunicipio,
            this.ClBarrioVereda,
            this.ClDireccion,
            this.ClTelefono,
            this.ClEmail,
            this.ClCelular,
            this.ClContrasena,
            this.ClEstado,
            this.ClRol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsuarios.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgUsuarios.Location = new System.Drawing.Point(14, 52);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(673, 391);
            this.dtgUsuarios.TabIndex = 8;
            this.dtgUsuarios.DoubleClick += new System.EventHandler(this.dtgUsuarios_DoubleClick);
            // 
            // ClCodigoUsuario
            // 
            this.ClCodigoUsuario.HeaderText = "Codigo usuario";
            this.ClCodigoUsuario.Name = "ClCodigoUsuario";
            this.ClCodigoUsuario.ReadOnly = true;
            this.ClCodigoUsuario.Visible = false;
            // 
            // ClUsuario
            // 
            this.ClUsuario.HeaderText = "Usuario";
            this.ClUsuario.Name = "ClUsuario";
            this.ClUsuario.ReadOnly = true;
            // 
            // ClCodigoPersona
            // 
            this.ClCodigoPersona.HeaderText = "Codigo persona";
            this.ClCodigoPersona.Name = "ClCodigoPersona";
            this.ClCodigoPersona.ReadOnly = true;
            this.ClCodigoPersona.Visible = false;
            // 
            // ClDNI
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ClDNI.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClDNI.HeaderText = "DNI";
            this.ClDNI.Name = "ClDNI";
            this.ClDNI.ReadOnly = true;
            this.ClDNI.Width = 200;
            // 
            // ClTipoDNI
            // 
            this.ClTipoDNI.HeaderText = "Tipo DNI";
            this.ClTipoDNI.Name = "ClTipoDNI";
            this.ClTipoDNI.ReadOnly = true;
            this.ClTipoDNI.Width = 150;
            // 
            // ClNombres
            // 
            this.ClNombres.HeaderText = "Nombres";
            this.ClNombres.Name = "ClNombres";
            this.ClNombres.ReadOnly = true;
            this.ClNombres.Width = 200;
            // 
            // ClApellidos
            // 
            this.ClApellidos.HeaderText = "Apellidos";
            this.ClApellidos.Name = "ClApellidos";
            this.ClApellidos.ReadOnly = true;
            this.ClApellidos.Width = 200;
            // 
            // ClDepartamento
            // 
            this.ClDepartamento.HeaderText = "Departamento";
            this.ClDepartamento.Name = "ClDepartamento";
            this.ClDepartamento.ReadOnly = true;
            this.ClDepartamento.Width = 200;
            // 
            // ClMunicipio
            // 
            this.ClMunicipio.HeaderText = "Municipio";
            this.ClMunicipio.Name = "ClMunicipio";
            this.ClMunicipio.ReadOnly = true;
            this.ClMunicipio.Width = 200;
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
            this.ClDireccion.Width = 200;
            // 
            // ClTelefono
            // 
            this.ClTelefono.HeaderText = "Telefono";
            this.ClTelefono.Name = "ClTelefono";
            this.ClTelefono.ReadOnly = true;
            // 
            // ClEmail
            // 
            this.ClEmail.HeaderText = "Email";
            this.ClEmail.Name = "ClEmail";
            this.ClEmail.ReadOnly = true;
            this.ClEmail.Width = 200;
            // 
            // ClCelular
            // 
            this.ClCelular.HeaderText = "Celular";
            this.ClCelular.Name = "ClCelular";
            this.ClCelular.ReadOnly = true;
            this.ClCelular.Width = 150;
            // 
            // ClContrasena
            // 
            this.ClContrasena.HeaderText = "Contraseña";
            this.ClContrasena.Name = "ClContrasena";
            this.ClContrasena.ReadOnly = true;
            this.ClContrasena.Visible = false;
            // 
            // ClEstado
            // 
            this.ClEstado.HeaderText = "Estado";
            this.ClEstado.Name = "ClEstado";
            this.ClEstado.ReadOnly = true;
            // 
            // ClRol
            // 
            this.ClRol.HeaderText = "Rol";
            this.ClRol.Name = "ClRol";
            this.ClRol.ReadOnly = true;
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 443);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "USUARIOS";
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.USUARIOS_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTipoDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClBarrioVereda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClContrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClRol;
    }
}