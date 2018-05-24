namespace SBX
{
    partial class DETALLE_COMPRAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DETALLE_COMPRAS));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsecutivoDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDNIProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMargen = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDescripcionCantidad = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaVence = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbodega = new System.Windows.Forms.TextBox();
            this.pnlTitulo.SuspendLayout();
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
            this.pnlTitulo.Size = new System.Drawing.Size(705, 38);
            this.pnlTitulo.TabIndex = 1;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(677, 9);
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
            this.label1.Location = new System.Drawing.Point(279, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle compra";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Item producto";
            // 
            // txtItemProd
            // 
            this.txtItemProd.BackColor = System.Drawing.SystemColors.Window;
            this.txtItemProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemProd.Enabled = false;
            this.txtItemProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemProd.Location = new System.Drawing.Point(145, 140);
            this.txtItemProd.MaxLength = 4;
            this.txtItemProd.Name = "txtItemProd";
            this.txtItemProd.Size = new System.Drawing.Size(187, 21);
            this.txtItemProd.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Consecutivo Doc.";
            // 
            // txtConsecutivoDoc
            // 
            this.txtConsecutivoDoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtConsecutivoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsecutivoDoc.Enabled = false;
            this.txtConsecutivoDoc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivoDoc.Location = new System.Drawing.Point(145, 113);
            this.txtConsecutivoDoc.MaxLength = 2;
            this.txtConsecutivoDoc.Name = "txtConsecutivoDoc";
            this.txtConsecutivoDoc.Size = new System.Drawing.Size(187, 21);
            this.txtConsecutivoDoc.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre Doc.";
            // 
            // txtNombreDoc
            // 
            this.txtNombreDoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreDoc.Enabled = false;
            this.txtNombreDoc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoc.Location = new System.Drawing.Point(145, 86);
            this.txtNombreDoc.MaxLength = 50;
            this.txtNombreDoc.Name = "txtNombreDoc";
            this.txtNombreDoc.Size = new System.Drawing.Size(187, 21);
            this.txtNombreDoc.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(145, 60);
            this.txtDocumento.MaxLength = 30;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(187, 21);
            this.txtDocumento.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nombre producto";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProd.Enabled = false;
            this.txtNombreProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(145, 167);
            this.txtNombreProd.MaxLength = 4;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(187, 21);
            this.txtNombreProd.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Razon social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(145, 221);
            this.txtRazonSocial.MaxLength = 4;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(187, 21);
            this.txtRazonSocial.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "DNI proveedor";
            // 
            // txtDNIProveedor
            // 
            this.txtDNIProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtDNIProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNIProveedor.Enabled = false;
            this.txtDNIProveedor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIProveedor.Location = new System.Drawing.Point(145, 194);
            this.txtDNIProveedor.MaxLength = 4;
            this.txtDNIProveedor.Name = "txtDNIProveedor";
            this.txtDNIProveedor.Size = new System.Drawing.Size(187, 21);
            this.txtDNIProveedor.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Nombre comercial";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreComercial.Enabled = false;
            this.txtNombreComercial.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(145, 248);
            this.txtNombreComercial.MaxLength = 4;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(187, 21);
            this.txtNombreComercial.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Codigo barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarras.Enabled = false;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(498, 247);
            this.txtCodigoBarras.MaxLength = 4;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(187, 21);
            this.txtCodigoBarras.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(354, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Enabled = false;
            this.txtSerial.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(498, 220);
            this.txtSerial.MaxLength = 4;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(187, 21);
            this.txtSerial.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Lote";
            // 
            // txtLote
            // 
            this.txtLote.BackColor = System.Drawing.SystemColors.Window;
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLote.Enabled = false;
            this.txtLote.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(498, 193);
            this.txtLote.MaxLength = 4;
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(187, 21);
            this.txtLote.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(354, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "IVA";
            // 
            // txtIVA
            // 
            this.txtIVA.BackColor = System.Drawing.SystemColors.Window;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(498, 166);
            this.txtIVA.MaxLength = 4;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(187, 21);
            this.txtIVA.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(354, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "Margen";
            // 
            // txtMargen
            // 
            this.txtMargen.BackColor = System.Drawing.SystemColors.Window;
            this.txtMargen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMargen.Enabled = false;
            this.txtMargen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargen.Location = new System.Drawing.Point(498, 139);
            this.txtMargen.MaxLength = 2;
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Size = new System.Drawing.Size(187, 21);
            this.txtMargen.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(354, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.SystemColors.Window;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(498, 112);
            this.txtCosto.MaxLength = 50;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(187, 21);
            this.txtCosto.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(354, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Descripcion cantidad";
            // 
            // txtDescripcionCantidad
            // 
            this.txtDescripcionCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcionCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionCantidad.Enabled = false;
            this.txtDescripcionCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCantidad.Location = new System.Drawing.Point(498, 86);
            this.txtDescripcionCantidad.MaxLength = 30;
            this.txtDescripcionCantidad.Name = "txtDescripcionCantidad";
            this.txtDescripcionCantidad.Size = new System.Drawing.Size(187, 21);
            this.txtDescripcionCantidad.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(354, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(498, 57);
            this.txtCantidad.MaxLength = 20;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(187, 21);
            this.txtCantidad.TabIndex = 34;
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
            this.btnSalir.Location = new System.Drawing.Point(611, 304);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 40);
            this.btnSalir.TabIndex = 52;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha Venc.";
            // 
            // txtFechaVence
            // 
            this.txtFechaVence.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaVence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVence.Enabled = false;
            this.txtFechaVence.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVence.Location = new System.Drawing.Point(145, 275);
            this.txtFechaVence.MaxLength = 4;
            this.txtFechaVence.Name = "txtFechaVence";
            this.txtFechaVence.Size = new System.Drawing.Size(187, 21);
            this.txtFechaVence.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(354, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 56;
            this.label14.Text = "Bodega";
            // 
            // txtbodega
            // 
            this.txtbodega.BackColor = System.Drawing.SystemColors.Window;
            this.txtbodega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbodega.Enabled = false;
            this.txtbodega.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbodega.Location = new System.Drawing.Point(498, 274);
            this.txtbodega.MaxLength = 4;
            this.txtbodega.Name = "txtbodega";
            this.txtbodega.Size = new System.Drawing.Size(187, 21);
            this.txtbodega.TabIndex = 55;
            // 
            // DETALLE_COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 350);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbodega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaVence);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMargen);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDescripcionCantidad);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDNIProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtItemProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConsecutivoDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DETALLE_COMPRAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE_COMPRAS";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtItemProd;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtConsecutivoDoc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombreDoc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDNIProveedor;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtMargen;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtDescripcionCantidad;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFechaVence;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtbodega;
    }
}