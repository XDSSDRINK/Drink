namespace SBX
{
    partial class INVENTARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTARIO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportaraExcel = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.dtgAlertas = new System.Windows.Forms.DataGridView();
            this.ClStock15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClAgotado15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClProxV15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClVencido15 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCantidadExistente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClStockMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPresentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDiasFechaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAplicaFV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.Controls.Add(this.label3);
            this.pnlArriba.Controls.Add(this.label2);
            this.pnlArriba.Controls.Add(this.label1);
            this.pnlArriba.Controls.Add(this.lblstock);
            this.pnlArriba.Controls.Add(this.pictureBox4);
            this.pnlArriba.Controls.Add(this.pictureBox3);
            this.pnlArriba.Controls.Add(this.pictureBox2);
            this.pnlArriba.Controls.Add(this.pictureBox1);
            this.pnlArriba.Controls.Add(this.btnExportaraExcel);
            this.pnlArriba.Controls.Add(this.txtBuscar);
            this.pnlArriba.Controls.Add(this.btnBuscar);
            this.pnlArriba.Controls.Add(this.btnCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(761, 52);
            this.pnlArriba.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vencido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prox. v";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agotado";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(82, 21);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(37, 16);
            this.lblstock.TabIndex = 12;
            this.lblstock.Text = "Stock";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(293, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(215, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnExportaraExcel
            // 
            this.btnExportaraExcel.BackColor = System.Drawing.SystemColors.Window;
            this.btnExportaraExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportaraExcel.FlatAppearance.BorderSize = 0;
            this.btnExportaraExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportaraExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportaraExcel.Image")));
            this.btnExportaraExcel.Location = new System.Drawing.Point(8, 11);
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
            this.txtBuscar.Location = new System.Drawing.Point(446, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar item";
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
            this.btnBuscar.Location = new System.Drawing.Point(647, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 31);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(733, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgInventario
            // 
            this.dtgInventario.AllowUserToAddRows = false;
            this.dtgInventario.AllowUserToDeleteRows = false;
            this.dtgInventario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgInventario.BackgroundColor = System.Drawing.Color.White;
            this.dtgInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClItem,
            this.ClNombre,
            this.ClReferencia,
            this.ClCantidadExistente,
            this.ClStockMinimo,
            this.ClStockMax,
            this.ClFechaVencimiento,
            this.ClIVA,
            this.ClMarca,
            this.ClPresentacion,
            this.CLCategoria,
            this.ClUnidadMedida,
            this.ClMedida,
            this.ClEstado,
            this.ClDiasFechaV,
            this.ClAplicaFV});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventario.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgInventario.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgInventario.Location = new System.Drawing.Point(118, 52);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.ReadOnly = true;
            this.dtgInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgInventario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgInventario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventario.Size = new System.Drawing.Size(643, 371);
            this.dtgInventario.TabIndex = 12;
            // 
            // dtgAlertas
            // 
            this.dtgAlertas.AllowUserToAddRows = false;
            this.dtgAlertas.AllowUserToDeleteRows = false;
            this.dtgAlertas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClStock15,
            this.ClAgotado15,
            this.ClProxV15,
            this.ClVencido15});
            this.dtgAlertas.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgAlertas.Location = new System.Drawing.Point(0, 52);
            this.dtgAlertas.Name = "dtgAlertas";
            this.dtgAlertas.ReadOnly = true;
            this.dtgAlertas.Size = new System.Drawing.Size(119, 371);
            this.dtgAlertas.TabIndex = 13;
            this.dtgAlertas.Paint += new System.Windows.Forms.PaintEventHandler(this.dtgAlertas_Paint);
            // 
            // ClStock15
            // 
            this.ClStock15.HeaderText = "";
            this.ClStock15.Image = ((System.Drawing.Image)(resources.GetObject("ClStock15.Image")));
            this.ClStock15.Name = "ClStock15";
            this.ClStock15.ReadOnly = true;
            this.ClStock15.Width = 20;
            // 
            // ClAgotado15
            // 
            this.ClAgotado15.HeaderText = "";
            this.ClAgotado15.Image = ((System.Drawing.Image)(resources.GetObject("ClAgotado15.Image")));
            this.ClAgotado15.Name = "ClAgotado15";
            this.ClAgotado15.ReadOnly = true;
            this.ClAgotado15.Width = 20;
            // 
            // ClProxV15
            // 
            this.ClProxV15.HeaderText = "";
            this.ClProxV15.Image = ((System.Drawing.Image)(resources.GetObject("ClProxV15.Image")));
            this.ClProxV15.Name = "ClProxV15";
            this.ClProxV15.ReadOnly = true;
            this.ClProxV15.Width = 20;
            // 
            // ClVencido15
            // 
            this.ClVencido15.HeaderText = "";
            this.ClVencido15.Image = ((System.Drawing.Image)(resources.GetObject("ClVencido15.Image")));
            this.ClVencido15.Name = "ClVencido15";
            this.ClVencido15.ReadOnly = true;
            this.ClVencido15.Width = 20;
            // 
            // ClItem
            // 
            this.ClItem.HeaderText = "Item";
            this.ClItem.Name = "ClItem";
            this.ClItem.ReadOnly = true;
            // 
            // ClNombre
            // 
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            this.ClNombre.Width = 200;
            // 
            // ClReferencia
            // 
            this.ClReferencia.HeaderText = "Referencia";
            this.ClReferencia.Name = "ClReferencia";
            this.ClReferencia.ReadOnly = true;
            // 
            // ClCantidadExistente
            // 
            this.ClCantidadExistente.HeaderText = "Existencia";
            this.ClCantidadExistente.Name = "ClCantidadExistente";
            this.ClCantidadExistente.ReadOnly = true;
            // 
            // ClStockMinimo
            // 
            this.ClStockMinimo.HeaderText = "Stock minimo";
            this.ClStockMinimo.Name = "ClStockMinimo";
            this.ClStockMinimo.ReadOnly = true;
            this.ClStockMinimo.Width = 150;
            // 
            // ClStockMax
            // 
            this.ClStockMax.HeaderText = "Stock maximo";
            this.ClStockMax.Name = "ClStockMax";
            this.ClStockMax.ReadOnly = true;
            this.ClStockMax.Width = 150;
            // 
            // ClFechaVencimiento
            // 
            this.ClFechaVencimiento.HeaderText = "Fecha vencimiento";
            this.ClFechaVencimiento.Name = "ClFechaVencimiento";
            this.ClFechaVencimiento.ReadOnly = true;
            this.ClFechaVencimiento.Width = 300;
            // 
            // ClIVA
            // 
            this.ClIVA.HeaderText = "IVA";
            this.ClIVA.Name = "ClIVA";
            this.ClIVA.ReadOnly = true;
            // 
            // ClMarca
            // 
            this.ClMarca.HeaderText = "Marca";
            this.ClMarca.Name = "ClMarca";
            this.ClMarca.ReadOnly = true;
            // 
            // ClPresentacion
            // 
            this.ClPresentacion.HeaderText = "Presentacion";
            this.ClPresentacion.Name = "ClPresentacion";
            this.ClPresentacion.ReadOnly = true;
            // 
            // CLCategoria
            // 
            this.CLCategoria.HeaderText = "Categoria";
            this.CLCategoria.Name = "CLCategoria";
            this.CLCategoria.ReadOnly = true;
            // 
            // ClUnidadMedida
            // 
            this.ClUnidadMedida.HeaderText = "Unidad medida";
            this.ClUnidadMedida.Name = "ClUnidadMedida";
            this.ClUnidadMedida.ReadOnly = true;
            this.ClUnidadMedida.Width = 300;
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
            // ClDiasFechaV
            // 
            this.ClDiasFechaV.HeaderText = "Dias fecha V";
            this.ClDiasFechaV.Name = "ClDiasFechaV";
            this.ClDiasFechaV.ReadOnly = true;
            this.ClDiasFechaV.Width = 150;
            // 
            // ClAplicaFV
            // 
            this.ClAplicaFV.HeaderText = "Aplica F.V";
            this.ClAplicaFV.Name = "ClAplicaFV";
            this.ClAplicaFV.ReadOnly = true;
            // 
            // INVENTARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(761, 423);
            this.Controls.Add(this.dtgAlertas);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INVENTARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTARIO";
            this.Load += new System.EventHandler(this.INVENTARIO_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Button btnExportaraExcel;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataGridView dtgInventario;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgAlertas;
        private System.Windows.Forms.DataGridViewImageColumn ClStock15;
        private System.Windows.Forms.DataGridViewImageColumn ClAgotado15;
        private System.Windows.Forms.DataGridViewImageColumn ClProxV15;
        private System.Windows.Forms.DataGridViewImageColumn ClVencido15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCantidadExistente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClStockMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPresentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDiasFechaV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAplicaFV;
    }
}