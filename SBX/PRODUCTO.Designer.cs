namespace SBX
{
    partial class PRODUCTO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRODUCTO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.ClItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClModoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAplicaFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClGeneraIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStockMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDiasAlertFechaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlArriba.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClItem,
            this.ClNombre,
            this.ClReferencia,
            this.ClDescripcion,
            this.ClIva,
            this.ClUnidadMedida,
            this.ClMedida,
            this.ClEstado,
            this.ClMarca,
            this.ClCategoria,
            this.ClPresentacion,
            this.ClModoVenta,
            this.ClAplicaFechaVencimiento,
            this.ClGeneraIVA,
            this.ClFoto,
            this.ClStock,
            this.clStockMaximo,
            this.ClDiasAlertFechaV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProductos.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgProductos.Location = new System.Drawing.Point(0, 0);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.Size = new System.Drawing.Size(750, 473);
            this.dtgProductos.TabIndex = 2;
            this.dtgProductos.DoubleClick += new System.EventHandler(this.dtgProductos_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(764, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 487);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 487);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(14, 525);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 14);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgProductos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(14, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 473);
            this.panel5.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(742, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.pnlArriba.Size = new System.Drawing.Size(778, 52);
            this.pnlArriba.TabIndex = 3;
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
            this.txtBuscar.Text = "Buscar producto";
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
            // ClItem
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.ClItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClItem.HeaderText = "Item";
            this.ClItem.Name = "ClItem";
            this.ClItem.ReadOnly = true;
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            this.ClNombre.Width = 150;
            // 
            // ClReferencia
            // 
            this.ClReferencia.HeaderText = "Referencia";
            this.ClReferencia.Name = "ClReferencia";
            this.ClReferencia.ReadOnly = true;
            // 
            // ClDescripcion
            // 
            this.ClDescripcion.HeaderText = "Descripcion";
            this.ClDescripcion.Name = "ClDescripcion";
            this.ClDescripcion.ReadOnly = true;
            this.ClDescripcion.Width = 200;
            // 
            // ClIva
            // 
            this.ClIva.HeaderText = "IVA %";
            this.ClIva.Name = "ClIva";
            this.ClIva.ReadOnly = true;
            // 
            // ClUnidadMedida
            // 
            this.ClUnidadMedida.HeaderText = "Unidad medida";
            this.ClUnidadMedida.Name = "ClUnidadMedida";
            this.ClUnidadMedida.ReadOnly = true;
            this.ClUnidadMedida.Width = 200;
            // 
            // ClMedida
            // 
            this.ClMedida.HeaderText = "Medida";
            this.ClMedida.Name = "ClMedida";
            this.ClMedida.ReadOnly = true;
            // 
            // ClEstado
            // 
            this.ClEstado.HeaderText = "Estado";
            this.ClEstado.Name = "ClEstado";
            this.ClEstado.ReadOnly = true;
            // 
            // ClMarca
            // 
            this.ClMarca.HeaderText = "Marca";
            this.ClMarca.Name = "ClMarca";
            this.ClMarca.ReadOnly = true;
            // 
            // ClCategoria
            // 
            this.ClCategoria.HeaderText = "Categoria";
            this.ClCategoria.Name = "ClCategoria";
            this.ClCategoria.ReadOnly = true;
            // 
            // ClPresentacion
            // 
            this.ClPresentacion.HeaderText = "Presentacion";
            this.ClPresentacion.Name = "ClPresentacion";
            this.ClPresentacion.ReadOnly = true;
            // 
            // ClModoVenta
            // 
            this.ClModoVenta.HeaderText = "ModoVenta";
            this.ClModoVenta.Name = "ClModoVenta";
            this.ClModoVenta.ReadOnly = true;
            // 
            // ClAplicaFechaVencimiento
            // 
            this.ClAplicaFechaVencimiento.HeaderText = "Aplica F.V";
            this.ClAplicaFechaVencimiento.Name = "ClAplicaFechaVencimiento";
            this.ClAplicaFechaVencimiento.ReadOnly = true;
            // 
            // ClGeneraIVA
            // 
            this.ClGeneraIVA.HeaderText = "Genera IVA";
            this.ClGeneraIVA.Name = "ClGeneraIVA";
            this.ClGeneraIVA.ReadOnly = true;
            this.ClGeneraIVA.Visible = false;
            this.ClGeneraIVA.Width = 200;
            // 
            // ClFoto
            // 
            this.ClFoto.HeaderText = "Foto";
            this.ClFoto.Name = "ClFoto";
            this.ClFoto.ReadOnly = true;
            this.ClFoto.Visible = false;
            // 
            // ClStock
            // 
            this.ClStock.HeaderText = "Stock";
            this.ClStock.Name = "ClStock";
            this.ClStock.ReadOnly = true;
            // 
            // clStockMaximo
            // 
            this.clStockMaximo.HeaderText = "Stock maximo";
            this.clStockMaximo.Name = "clStockMaximo";
            this.clStockMaximo.ReadOnly = true;
            // 
            // ClDiasAlertFechaV
            // 
            this.ClDiasAlertFechaV.HeaderText = "Dias alerta fecha v";
            this.ClDiasAlertFechaV.Name = "ClDiasAlertFechaV";
            this.ClDiasAlertFechaV.ReadOnly = true;
            this.ClDiasAlertFechaV.Width = 200;
            // 
            // PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(778, 539);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PRODUCTO";
            this.Text = "PRODUCTO";
            this.Load += new System.EventHandler(this.PRODUCTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClModoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAplicaFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClGeneraIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStockMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDiasAlertFechaV;
    }
}