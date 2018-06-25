namespace SBX
{
    partial class CIERRE_MONEDAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIERRE_MONEDAS));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCantidadM10 = new System.Windows.Forms.TextBox();
            this.txtCantidadM20 = new System.Windows.Forms.TextBox();
            this.txtCantidadM50 = new System.Windows.Forms.TextBox();
            this.txtCantidadM100 = new System.Windows.Forms.TextBox();
            this.txtCantidadM200 = new System.Windows.Forms.TextBox();
            this.txtCantidadM500 = new System.Windows.Forms.TextBox();
            this.txtCantidadM1000 = new System.Windows.Forms.TextBox();
            this.txtTotalMonedas = new System.Windows.Forms.TextBox();
            this.txtValorM10 = new System.Windows.Forms.TextBox();
            this.txtValorM20 = new System.Windows.Forms.TextBox();
            this.txtValorM50 = new System.Windows.Forms.TextBox();
            this.txtValorM100 = new System.Windows.Forms.TextBox();
            this.txtValorM200 = new System.Windows.Forms.TextBox();
            this.txtValorM500 = new System.Windows.Forms.TextBox();
            this.txtValorM1000 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtValorTotalBase = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(342, 38);
            this.pnlTitulo.TabIndex = 6;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(314, 9);
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
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre monedas";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(14, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 17);
            this.label19.TabIndex = 103;
            this.label19.Text = "Σ";
            // 
            // txtCantidadM10
            // 
            this.txtCantidadM10.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM10.Location = new System.Drawing.Point(73, 214);
            this.txtCantidadM10.MaxLength = 20;
            this.txtCantidadM10.Name = "txtCantidadM10";
            this.txtCantidadM10.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM10.TabIndex = 102;
            this.txtCantidadM10.Text = "0";
            this.txtCantidadM10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtCantidadM20
            // 
            this.txtCantidadM20.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM20.Location = new System.Drawing.Point(73, 187);
            this.txtCantidadM20.MaxLength = 20;
            this.txtCantidadM20.Name = "txtCantidadM20";
            this.txtCantidadM20.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM20.TabIndex = 101;
            this.txtCantidadM20.Text = "0";
            this.txtCantidadM20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM20.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtCantidadM50
            // 
            this.txtCantidadM50.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM50.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM50.Location = new System.Drawing.Point(73, 160);
            this.txtCantidadM50.MaxLength = 20;
            this.txtCantidadM50.Name = "txtCantidadM50";
            this.txtCantidadM50.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM50.TabIndex = 100;
            this.txtCantidadM50.Text = "0";
            this.txtCantidadM50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM50.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtCantidadM100
            // 
            this.txtCantidadM100.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM100.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM100.Location = new System.Drawing.Point(73, 133);
            this.txtCantidadM100.MaxLength = 20;
            this.txtCantidadM100.Name = "txtCantidadM100";
            this.txtCantidadM100.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM100.TabIndex = 99;
            this.txtCantidadM100.Text = "0";
            this.txtCantidadM100.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM100.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtCantidadM200
            // 
            this.txtCantidadM200.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM200.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM200.Location = new System.Drawing.Point(73, 106);
            this.txtCantidadM200.MaxLength = 20;
            this.txtCantidadM200.Name = "txtCantidadM200";
            this.txtCantidadM200.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM200.TabIndex = 98;
            this.txtCantidadM200.Text = "0";
            this.txtCantidadM200.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM200.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtCantidadM500
            // 
            this.txtCantidadM500.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM500.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM500.Location = new System.Drawing.Point(73, 79);
            this.txtCantidadM500.MaxLength = 20;
            this.txtCantidadM500.Name = "txtCantidadM500";
            this.txtCantidadM500.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM500.TabIndex = 97;
            this.txtCantidadM500.Text = "0";
            this.txtCantidadM500.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM500.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtCantidadM1000
            // 
            this.txtCantidadM1000.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadM1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadM1000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadM1000.Location = new System.Drawing.Point(73, 52);
            this.txtCantidadM1000.MaxLength = 20;
            this.txtCantidadM1000.Name = "txtCantidadM1000";
            this.txtCantidadM1000.Size = new System.Drawing.Size(85, 21);
            this.txtCantidadM1000.TabIndex = 96;
            this.txtCantidadM1000.Text = "0";
            this.txtCantidadM1000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadM1000_KeyPress);
            this.txtCantidadM1000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidadM1000_KeyUp);
            // 
            // txtTotalMonedas
            // 
            this.txtTotalMonedas.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalMonedas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalMonedas.Enabled = false;
            this.txtTotalMonedas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMonedas.Location = new System.Drawing.Point(73, 241);
            this.txtTotalMonedas.MaxLength = 20;
            this.txtTotalMonedas.Name = "txtTotalMonedas";
            this.txtTotalMonedas.Size = new System.Drawing.Size(250, 21);
            this.txtTotalMonedas.TabIndex = 95;
            this.txtTotalMonedas.Text = "0";
            // 
            // txtValorM10
            // 
            this.txtValorM10.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM10.Enabled = false;
            this.txtValorM10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM10.Location = new System.Drawing.Point(183, 215);
            this.txtValorM10.MaxLength = 20;
            this.txtValorM10.Name = "txtValorM10";
            this.txtValorM10.Size = new System.Drawing.Size(140, 21);
            this.txtValorM10.TabIndex = 94;
            this.txtValorM10.Text = "0";
            // 
            // txtValorM20
            // 
            this.txtValorM20.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM20.Enabled = false;
            this.txtValorM20.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM20.Location = new System.Drawing.Point(183, 188);
            this.txtValorM20.MaxLength = 20;
            this.txtValorM20.Name = "txtValorM20";
            this.txtValorM20.Size = new System.Drawing.Size(140, 21);
            this.txtValorM20.TabIndex = 93;
            this.txtValorM20.Text = "0";
            // 
            // txtValorM50
            // 
            this.txtValorM50.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM50.Enabled = false;
            this.txtValorM50.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM50.Location = new System.Drawing.Point(183, 161);
            this.txtValorM50.MaxLength = 20;
            this.txtValorM50.Name = "txtValorM50";
            this.txtValorM50.Size = new System.Drawing.Size(140, 21);
            this.txtValorM50.TabIndex = 92;
            this.txtValorM50.Text = "0";
            // 
            // txtValorM100
            // 
            this.txtValorM100.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM100.Enabled = false;
            this.txtValorM100.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM100.Location = new System.Drawing.Point(183, 134);
            this.txtValorM100.MaxLength = 20;
            this.txtValorM100.Name = "txtValorM100";
            this.txtValorM100.Size = new System.Drawing.Size(140, 21);
            this.txtValorM100.TabIndex = 91;
            this.txtValorM100.Text = "0";
            // 
            // txtValorM200
            // 
            this.txtValorM200.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM200.Enabled = false;
            this.txtValorM200.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM200.Location = new System.Drawing.Point(183, 107);
            this.txtValorM200.MaxLength = 20;
            this.txtValorM200.Name = "txtValorM200";
            this.txtValorM200.Size = new System.Drawing.Size(140, 21);
            this.txtValorM200.TabIndex = 90;
            this.txtValorM200.Text = "0";
            // 
            // txtValorM500
            // 
            this.txtValorM500.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM500.Enabled = false;
            this.txtValorM500.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM500.Location = new System.Drawing.Point(183, 80);
            this.txtValorM500.MaxLength = 20;
            this.txtValorM500.Name = "txtValorM500";
            this.txtValorM500.Size = new System.Drawing.Size(140, 21);
            this.txtValorM500.TabIndex = 89;
            this.txtValorM500.Text = "0";
            // 
            // txtValorM1000
            // 
            this.txtValorM1000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorM1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorM1000.Enabled = false;
            this.txtValorM1000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorM1000.Location = new System.Drawing.Point(183, 53);
            this.txtValorM1000.MaxLength = 20;
            this.txtValorM1000.Name = "txtValorM1000";
            this.txtValorM1000.Size = new System.Drawing.Size(140, 21);
            this.txtValorM1000.TabIndex = 88;
            this.txtValorM1000.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 87;
            this.label11.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 86;
            this.label12.Text = "20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 85;
            this.label13.Text = "50";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 84;
            this.label14.Text = "100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 83;
            this.label15.Text = "200";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 17);
            this.label16.TabIndex = 82;
            this.label16.Text = "500";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 17);
            this.label17.TabIndex = 81;
            this.label17.Text = "1.000";
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
            this.btnGuardar.Location = new System.Drawing.Point(123, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 40);
            this.btnGuardar.TabIndex = 104;
            this.btnGuardar.Text = "Siguiente";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 17);
            this.label20.TabIndex = 106;
            this.label20.Text = "Base";
            // 
            // txtValorTotalBase
            // 
            this.txtValorTotalBase.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotalBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotalBase.Enabled = false;
            this.txtValorTotalBase.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalBase.Location = new System.Drawing.Point(73, 268);
            this.txtValorTotalBase.MaxLength = 20;
            this.txtValorTotalBase.Name = "txtValorTotalBase";
            this.txtValorTotalBase.Size = new System.Drawing.Size(250, 21);
            this.txtValorTotalBase.TabIndex = 105;
            this.txtValorTotalBase.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CIERRE_MONEDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtValorTotalBase);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCantidadM10);
            this.Controls.Add(this.txtCantidadM20);
            this.Controls.Add(this.txtCantidadM50);
            this.Controls.Add(this.txtCantidadM100);
            this.Controls.Add(this.txtCantidadM200);
            this.Controls.Add(this.txtCantidadM500);
            this.Controls.Add(this.txtCantidadM1000);
            this.Controls.Add(this.txtTotalMonedas);
            this.Controls.Add(this.txtValorM10);
            this.Controls.Add(this.txtValorM20);
            this.Controls.Add(this.txtValorM50);
            this.Controls.Add(this.txtValorM100);
            this.Controls.Add(this.txtValorM200);
            this.Controls.Add(this.txtValorM500);
            this.Controls.Add(this.txtValorM1000);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIERRE_MONEDAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIERRE_MONEDAS";
            this.Load += new System.EventHandler(this.CIERRE_MONEDAS_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtCantidadM10;
        public System.Windows.Forms.TextBox txtCantidadM20;
        public System.Windows.Forms.TextBox txtCantidadM50;
        public System.Windows.Forms.TextBox txtCantidadM100;
        public System.Windows.Forms.TextBox txtCantidadM200;
        public System.Windows.Forms.TextBox txtCantidadM500;
        public System.Windows.Forms.TextBox txtCantidadM1000;
        public System.Windows.Forms.TextBox txtTotalMonedas;
        public System.Windows.Forms.TextBox txtValorM10;
        public System.Windows.Forms.TextBox txtValorM20;
        public System.Windows.Forms.TextBox txtValorM50;
        public System.Windows.Forms.TextBox txtValorM100;
        public System.Windows.Forms.TextBox txtValorM200;
        public System.Windows.Forms.TextBox txtValorM500;
        public System.Windows.Forms.TextBox txtValorM1000;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtValorTotalBase;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}