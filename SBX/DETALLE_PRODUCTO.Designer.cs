namespace SBX
{
    partial class DETALLE_PRODUCTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DETALLE_PRODUCTO));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.chkAplicaFechaV = new System.Windows.Forms.CheckBox();
            this.chkGeneraIVA = new System.Windows.Forms.CheckBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxPresentacion = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxModoVenta = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.txtStockMaximo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAlertaFechaVenc = new System.Windows.Forms.TextBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(663, 38);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(635, 9);
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
            this.label1.Location = new System.Drawing.Point(241, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle producto";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(197, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 40);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(298, 398);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 40);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(399, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 40);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.Window;
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(123, 70);
            this.txtItem.MaxLength = 20;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(187, 21);
            this.txtItem.TabIndex = 0;
            this.txtItem.Enter += new System.EventHandler(this.txtItem_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(123, 98);
            this.txtReferencia.MaxLength = 30;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(187, 21);
            this.txtReferencia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre *";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(123, 124);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 21);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "IVA %";
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.SystemColors.Window;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(123, 151);
            this.txtIVA.MaxLength = 2;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(187, 21);
            this.txtIVA.TabIndex = 3;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock minimo";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Window;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(123, 178);
            this.txtStock.MaxLength = 4;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(187, 21);
            this.txtStock.TabIndex = 4;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(123, 235);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 61);
            this.txtDescripcion.TabIndex = 6;
            // 
            // pbxFoto
            // 
            this.pbxFoto.BackColor = System.Drawing.SystemColors.Window;
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(452, 250);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(100, 100);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFoto.TabIndex = 18;
            this.pbxFoto.TabStop = false;
            // 
            // chkAplicaFechaV
            // 
            this.chkAplicaFechaV.AutoSize = true;
            this.chkAplicaFechaV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAplicaFechaV.Location = new System.Drawing.Point(15, 357);
            this.chkAplicaFechaV.Name = "chkAplicaFechaV";
            this.chkAplicaFechaV.Size = new System.Drawing.Size(120, 21);
            this.chkAplicaFechaV.TabIndex = 9;
            this.chkAplicaFechaV.Text = "Aplica Fecha v.";
            this.chkAplicaFechaV.UseVisualStyleBackColor = true;
            // 
            // chkGeneraIVA
            // 
            this.chkGeneraIVA.AutoSize = true;
            this.chkGeneraIVA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGeneraIVA.Location = new System.Drawing.Point(179, 357);
            this.chkGeneraIVA.Name = "chkGeneraIVA";
            this.chkGeneraIVA.Size = new System.Drawing.Size(96, 21);
            this.chkGeneraIVA.TabIndex = 10;
            this.chkGeneraIVA.Text = "Genera IVA";
            this.chkGeneraIVA.UseVisualStyleBackColor = true;
            this.chkGeneraIVA.Visible = false;
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxEstado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(452, 99);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(183, 24);
            this.cbxEstado.TabIndex = 12;
            this.cbxEstado.Enter += new System.EventHandler(this.cbxEstado_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Marca";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxMarca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(452, 129);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(183, 24);
            this.cbxMarca.TabIndex = 13;
            this.cbxMarca.Enter += new System.EventHandler(this.cbxMarca_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(343, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCategoria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(452, 159);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(183, 24);
            this.cbxCategoria.TabIndex = 14;
            this.cbxCategoria.Enter += new System.EventHandler(this.cbxCategoria_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Presentacion";
            // 
            // cbxPresentacion
            // 
            this.cbxPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxPresentacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPresentacion.FormattingEnabled = true;
            this.cbxPresentacion.Location = new System.Drawing.Point(452, 189);
            this.cbxPresentacion.Name = "cbxPresentacion";
            this.cbxPresentacion.Size = new System.Drawing.Size(183, 24);
            this.cbxPresentacion.TabIndex = 15;
            this.cbxPresentacion.Enter += new System.EventHandler(this.cbxPresentacion_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(343, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "ModoVenta";
            // 
            // cbxModoVenta
            // 
            this.cbxModoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxModoVenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModoVenta.FormattingEnabled = true;
            this.cbxModoVenta.Location = new System.Drawing.Point(452, 219);
            this.cbxModoVenta.Name = "cbxModoVenta";
            this.cbxModoVenta.Size = new System.Drawing.Size(183, 24);
            this.cbxModoVenta.TabIndex = 16;
            this.cbxModoVenta.Enter += new System.EventHandler(this.cbxModoVenta_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(343, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Unidad medida";
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Location = new System.Drawing.Point(452, 68);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(183, 24);
            this.cbxUnidadMedida.TabIndex = 11;
            this.cbxUnidadMedida.Enter += new System.EventHandler(this.cbxUnidadMedida_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Medida";
            // 
            // txtMedida
            // 
            this.txtMedida.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedida.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedida.Location = new System.Drawing.Point(123, 329);
            this.txtMedida.MaxLength = 5;
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(187, 21);
            this.txtMedida.TabIndex = 8;
            this.txtMedida.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMedida_KeyUp);
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFoto.BackColor = System.Drawing.Color.DimGray;
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.Location = new System.Drawing.Point(569, 315);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(40, 35);
            this.btnFoto.TabIndex = 17;
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Stock maximo";
            // 
            // txtStockMaximo
            // 
            this.txtStockMaximo.BackColor = System.Drawing.SystemColors.Window;
            this.txtStockMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockMaximo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMaximo.Location = new System.Drawing.Point(123, 206);
            this.txtStockMaximo.MaxLength = 4;
            this.txtStockMaximo.Name = "txtStockMaximo";
            this.txtStockMaximo.Size = new System.Drawing.Size(187, 21);
            this.txtStockMaximo.TabIndex = 5;
            this.txtStockMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMaximo_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Alerta dias F.V";
            // 
            // txtAlertaFechaVenc
            // 
            this.txtAlertaFechaVenc.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlertaFechaVenc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlertaFechaVenc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlertaFechaVenc.Location = new System.Drawing.Point(123, 302);
            this.txtAlertaFechaVenc.MaxLength = 5;
            this.txtAlertaFechaVenc.Name = "txtAlertaFechaVenc";
            this.txtAlertaFechaVenc.Size = new System.Drawing.Size(187, 21);
            this.txtAlertaFechaVenc.TabIndex = 37;
            this.txtAlertaFechaVenc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlertaFechaVenc_KeyPress);
            // 
            // DETALLE_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(663, 451);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAlertaFechaVenc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtStockMaximo);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxUnidadMedida);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxModoVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxPresentacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.chkGeneraIVA);
            this.Controls.Add(this.chkAplicaFechaV);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DETALLE_PRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE_PRODUCTO";
            this.Load += new System.EventHandler(this.DETALLE_PRODUCTO_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DETALLE_PRODUCTO_MouseDown);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.TextBox txtReferencia;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtIVA;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.PictureBox pbxFoto;
        public System.Windows.Forms.CheckBox chkAplicaFechaV;
        public System.Windows.Forms.CheckBox chkGeneraIVA;
        public System.Windows.Forms.ComboBox cbxEstado;
        public System.Windows.Forms.ComboBox cbxMarca;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.ComboBox cbxPresentacion;
        public System.Windows.Forms.ComboBox cbxModoVenta;
        public System.Windows.Forms.ComboBox cbxUnidadMedida;
        public System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtStockMaximo;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtAlertaFechaVenc;
    }
}