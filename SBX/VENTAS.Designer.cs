namespace SBX
{
    partial class VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VENTAS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpkFechaIni = new System.Windows.Forms.DateTimePicker();
            this.txtConsecutivoDoc = new System.Windows.Forms.TextBox();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.ClFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClHoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClConsecutivoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValorVeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClTotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMedioPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArriba.Controls.Add(this.txtBuscar);
            this.pnlArriba.Controls.Add(this.btnBuscar);
            this.pnlArriba.Controls.Add(this.btnActualizar);
            this.pnlArriba.Controls.Add(this.btnAgregar);
            this.pnlArriba.Controls.Add(this.btnCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(730, 52);
            this.pnlArriba.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(419, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(616, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            this.btnCerrar.Location = new System.Drawing.Point(694, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpkFechaFinal);
            this.panel1.Controls.Add(this.dtpkFechaIni);
            this.panel1.Controls.Add(this.txtConsecutivoDoc);
            this.panel1.Controls.Add(this.txtNombreDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 35);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha Fin.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha InI.";
            // 
            // dtpkFechaFinal
            // 
            this.dtpkFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpkFechaFinal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaFinal.Location = new System.Drawing.Point(546, 6);
            this.dtpkFechaFinal.Name = "dtpkFechaFinal";
            this.dtpkFechaFinal.Size = new System.Drawing.Size(114, 21);
            this.dtpkFechaFinal.TabIndex = 11;
            // 
            // dtpkFechaIni
            // 
            this.dtpkFechaIni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpkFechaIni.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFechaIni.Location = new System.Drawing.Point(363, 6);
            this.dtpkFechaIni.Name = "dtpkFechaIni";
            this.dtpkFechaIni.Size = new System.Drawing.Size(114, 21);
            this.dtpkFechaIni.TabIndex = 10;
            // 
            // txtConsecutivoDoc
            // 
            this.txtConsecutivoDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConsecutivoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsecutivoDoc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivoDoc.ForeColor = System.Drawing.Color.Gray;
            this.txtConsecutivoDoc.Location = new System.Drawing.Point(153, 6);
            this.txtConsecutivoDoc.Name = "txtConsecutivoDoc";
            this.txtConsecutivoDoc.Size = new System.Drawing.Size(126, 21);
            this.txtConsecutivoDoc.TabIndex = 9;
            this.txtConsecutivoDoc.Text = "Consecutivo Doc";
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreDoc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoc.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreDoc.Location = new System.Drawing.Point(67, 6);
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(80, 21);
            this.txtNombreDoc.TabIndex = 8;
            this.txtNombreDoc.Text = "Nombre Doc";
            // 
            // dtgVentas
            // 
            this.dtgVentas.AllowUserToAddRows = false;
            this.dtgVentas.AllowUserToDeleteRows = false;
            this.dtgVentas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVentas.BackgroundColor = System.Drawing.Color.White;
            this.dtgVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClFechaRegistro,
            this.ClHoraRegistro,
            this.ClUsuario,
            this.ClNombreDocumento,
            this.ClConsecutivoDoc,
            this.ClItem,
            this.ClCodigoB,
            this.ClNombreP,
            this.ClReferencia,
            this.ClIVA,
            this.ClCantidad,
            this.ClValorVeta,
            this.ClDescuento,
            this.ClTotalVenta,
            this.ClMedioPago});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgVentas.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgVentas.Location = new System.Drawing.Point(0, 87);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.ReadOnly = true;
            this.dtgVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentas.Size = new System.Drawing.Size(730, 314);
            this.dtgVentas.TabIndex = 15;
            // 
            // ClFechaRegistro
            // 
            this.ClFechaRegistro.HeaderText = "Fecha ";
            this.ClFechaRegistro.Name = "ClFechaRegistro";
            this.ClFechaRegistro.ReadOnly = true;
            // 
            // ClHoraRegistro
            // 
            this.ClHoraRegistro.HeaderText = "Hora";
            this.ClHoraRegistro.Name = "ClHoraRegistro";
            this.ClHoraRegistro.ReadOnly = true;
            // 
            // ClUsuario
            // 
            this.ClUsuario.HeaderText = "Usuario";
            this.ClUsuario.Name = "ClUsuario";
            this.ClUsuario.ReadOnly = true;
            // 
            // ClNombreDocumento
            // 
            this.ClNombreDocumento.HeaderText = "Nombre documento";
            this.ClNombreDocumento.Name = "ClNombreDocumento";
            this.ClNombreDocumento.ReadOnly = true;
            this.ClNombreDocumento.Width = 200;
            // 
            // ClConsecutivoDoc
            // 
            this.ClConsecutivoDoc.HeaderText = "Consecutivo Doc";
            this.ClConsecutivoDoc.Name = "ClConsecutivoDoc";
            this.ClConsecutivoDoc.ReadOnly = true;
            this.ClConsecutivoDoc.Width = 200;
            // 
            // ClItem
            // 
            this.ClItem.HeaderText = "Item";
            this.ClItem.Name = "ClItem";
            this.ClItem.ReadOnly = true;
            // 
            // ClCodigoB
            // 
            this.ClCodigoB.HeaderText = "Codigo barras";
            this.ClCodigoB.Name = "ClCodigoB";
            this.ClCodigoB.ReadOnly = true;
            this.ClCodigoB.Width = 200;
            // 
            // ClNombreP
            // 
            this.ClNombreP.HeaderText = "Nombre";
            this.ClNombreP.Name = "ClNombreP";
            this.ClNombreP.ReadOnly = true;
            // 
            // ClReferencia
            // 
            this.ClReferencia.HeaderText = "Referencia";
            this.ClReferencia.Name = "ClReferencia";
            this.ClReferencia.ReadOnly = true;
            // 
            // ClIVA
            // 
            this.ClIVA.HeaderText = "IVA";
            this.ClIVA.Name = "ClIVA";
            this.ClIVA.ReadOnly = true;
            // 
            // ClCantidad
            // 
            this.ClCantidad.HeaderText = "Cantidad";
            this.ClCantidad.Name = "ClCantidad";
            this.ClCantidad.ReadOnly = true;
            // 
            // ClValorVeta
            // 
            this.ClValorVeta.HeaderText = "Valor";
            this.ClValorVeta.Name = "ClValorVeta";
            this.ClValorVeta.ReadOnly = true;
            // 
            // ClDescuento
            // 
            this.ClDescuento.HeaderText = "Descuento";
            this.ClDescuento.Name = "ClDescuento";
            this.ClDescuento.ReadOnly = true;
            // 
            // ClTotalVenta
            // 
            this.ClTotalVenta.HeaderText = "Total venta";
            this.ClTotalVenta.Name = "ClTotalVenta";
            this.ClTotalVenta.ReadOnly = true;
            this.ClTotalVenta.Width = 150;
            // 
            // ClMedioPago
            // 
            this.ClMedioPago.HeaderText = "Medio de pago";
            this.ClMedioPago.Name = "ClMedioPago";
            this.ClMedioPago.ReadOnly = true;
            this.ClMedioPago.Width = 200;
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(730, 401);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpkFechaIni;
        private System.Windows.Forms.TextBox txtConsecutivoDoc;
        private System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClHoraRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClConsecutivoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValorVeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClTotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMedioPago;
    }
}