namespace SBX
{
    partial class CIERRE_BILLETES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIERRE_BILLETES));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcantidad1000 = new System.Windows.Forms.TextBox();
            this.txtcantidad2000 = new System.Windows.Forms.TextBox();
            this.txtCantidad5000 = new System.Windows.Forms.TextBox();
            this.txtcantidad10000 = new System.Windows.Forms.TextBox();
            this.txtCantidad20000 = new System.Windows.Forms.TextBox();
            this.txtCantidad50000 = new System.Windows.Forms.TextBox();
            this.txtCantidad100000 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalBilletes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValor1000 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValor2000 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor5000 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor10000 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor20000 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor50000 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor100000 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.pnlTitulo.Size = new System.Drawing.Size(328, 38);
            this.pnlTitulo.TabIndex = 5;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(300, 9);
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
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre Billetes";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // txtcantidad1000
            // 
            this.txtcantidad1000.BackColor = System.Drawing.SystemColors.Window;
            this.txtcantidad1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad1000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad1000.Location = new System.Drawing.Point(69, 212);
            this.txtcantidad1000.MaxLength = 20;
            this.txtcantidad1000.Name = "txtcantidad1000";
            this.txtcantidad1000.Size = new System.Drawing.Size(85, 21);
            this.txtcantidad1000.TabIndex = 88;
            this.txtcantidad1000.Text = "0";
            this.txtcantidad1000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad2000_KeyPress);
            this.txtcantidad1000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcantidad1000_KeyUp);
            // 
            // txtcantidad2000
            // 
            this.txtcantidad2000.BackColor = System.Drawing.SystemColors.Window;
            this.txtcantidad2000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad2000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad2000.Location = new System.Drawing.Point(69, 185);
            this.txtcantidad2000.MaxLength = 20;
            this.txtcantidad2000.Name = "txtcantidad2000";
            this.txtcantidad2000.Size = new System.Drawing.Size(85, 21);
            this.txtcantidad2000.TabIndex = 87;
            this.txtcantidad2000.Text = "0";
            this.txtcantidad2000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad2000_KeyPress);
            this.txtcantidad2000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcantidad2000_KeyUp);
            // 
            // txtCantidad5000
            // 
            this.txtCantidad5000.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad5000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad5000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad5000.Location = new System.Drawing.Point(69, 158);
            this.txtCantidad5000.MaxLength = 20;
            this.txtCantidad5000.Name = "txtCantidad5000";
            this.txtCantidad5000.Size = new System.Drawing.Size(85, 21);
            this.txtCantidad5000.TabIndex = 86;
            this.txtCantidad5000.Text = "0";
            this.txtCantidad5000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad5000_KeyPress);
            this.txtCantidad5000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad5000_KeyUp);
            // 
            // txtcantidad10000
            // 
            this.txtcantidad10000.BackColor = System.Drawing.SystemColors.Window;
            this.txtcantidad10000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad10000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad10000.Location = new System.Drawing.Point(69, 131);
            this.txtcantidad10000.MaxLength = 20;
            this.txtcantidad10000.Name = "txtcantidad10000";
            this.txtcantidad10000.Size = new System.Drawing.Size(85, 21);
            this.txtcantidad10000.TabIndex = 85;
            this.txtcantidad10000.Text = "0";
            this.txtcantidad10000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad10000_KeyPress);
            this.txtcantidad10000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcantidad10000_KeyUp);
            // 
            // txtCantidad20000
            // 
            this.txtCantidad20000.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad20000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad20000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad20000.Location = new System.Drawing.Point(69, 104);
            this.txtCantidad20000.MaxLength = 20;
            this.txtCantidad20000.Name = "txtCantidad20000";
            this.txtCantidad20000.Size = new System.Drawing.Size(85, 21);
            this.txtCantidad20000.TabIndex = 84;
            this.txtCantidad20000.Text = "0";
            this.txtCantidad20000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad20000_KeyPress);
            this.txtCantidad20000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad20000_KeyUp);
            // 
            // txtCantidad50000
            // 
            this.txtCantidad50000.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad50000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad50000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad50000.Location = new System.Drawing.Point(69, 77);
            this.txtCantidad50000.MaxLength = 20;
            this.txtCantidad50000.Name = "txtCantidad50000";
            this.txtCantidad50000.Size = new System.Drawing.Size(85, 21);
            this.txtCantidad50000.TabIndex = 83;
            this.txtCantidad50000.Text = "0";
            this.txtCantidad50000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad50000_KeyPress);
            this.txtCantidad50000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad50000_KeyUp);
            // 
            // txtCantidad100000
            // 
            this.txtCantidad100000.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad100000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad100000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad100000.Location = new System.Drawing.Point(69, 50);
            this.txtCantidad100000.MaxLength = 20;
            this.txtCantidad100000.Name = "txtCantidad100000";
            this.txtCantidad100000.Size = new System.Drawing.Size(85, 21);
            this.txtCantidad100000.TabIndex = 82;
            this.txtCantidad100000.Text = "0";
            this.txtCantidad100000.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad100000_KeyPress);
            this.txtCantidad100000.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad100000_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 240);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 17);
            this.label18.TabIndex = 81;
            this.label18.Text = "Σ";
            // 
            // txtTotalBilletes
            // 
            this.txtTotalBilletes.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalBilletes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBilletes.Enabled = false;
            this.txtTotalBilletes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBilletes.Location = new System.Drawing.Point(69, 240);
            this.txtTotalBilletes.MaxLength = 20;
            this.txtTotalBilletes.Name = "txtTotalBilletes";
            this.txtTotalBilletes.Size = new System.Drawing.Size(249, 21);
            this.txtTotalBilletes.TabIndex = 80;
            this.txtTotalBilletes.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "1.000";
            // 
            // txtValor1000
            // 
            this.txtValor1000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor1000.Enabled = false;
            this.txtValor1000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1000.Location = new System.Drawing.Point(178, 213);
            this.txtValor1000.MaxLength = 20;
            this.txtValor1000.Name = "txtValor1000";
            this.txtValor1000.Size = new System.Drawing.Size(140, 21);
            this.txtValor1000.TabIndex = 78;
            this.txtValor1000.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "2.000";
            // 
            // txtValor2000
            // 
            this.txtValor2000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor2000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor2000.Enabled = false;
            this.txtValor2000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2000.Location = new System.Drawing.Point(178, 186);
            this.txtValor2000.MaxLength = 20;
            this.txtValor2000.Name = "txtValor2000";
            this.txtValor2000.Size = new System.Drawing.Size(140, 21);
            this.txtValor2000.TabIndex = 76;
            this.txtValor2000.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 75;
            this.label8.Text = "5.000";
            // 
            // txtValor5000
            // 
            this.txtValor5000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor5000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor5000.Enabled = false;
            this.txtValor5000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor5000.Location = new System.Drawing.Point(178, 159);
            this.txtValor5000.MaxLength = 20;
            this.txtValor5000.Name = "txtValor5000";
            this.txtValor5000.Size = new System.Drawing.Size(140, 21);
            this.txtValor5000.TabIndex = 74;
            this.txtValor5000.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "10.000";
            // 
            // txtValor10000
            // 
            this.txtValor10000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor10000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor10000.Enabled = false;
            this.txtValor10000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor10000.Location = new System.Drawing.Point(178, 132);
            this.txtValor10000.MaxLength = 20;
            this.txtValor10000.Name = "txtValor10000";
            this.txtValor10000.Size = new System.Drawing.Size(140, 21);
            this.txtValor10000.TabIndex = 72;
            this.txtValor10000.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "20.000";
            // 
            // txtValor20000
            // 
            this.txtValor20000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor20000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor20000.Enabled = false;
            this.txtValor20000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor20000.Location = new System.Drawing.Point(178, 105);
            this.txtValor20000.MaxLength = 20;
            this.txtValor20000.Name = "txtValor20000";
            this.txtValor20000.Size = new System.Drawing.Size(140, 21);
            this.txtValor20000.TabIndex = 70;
            this.txtValor20000.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "50.000";
            // 
            // txtValor50000
            // 
            this.txtValor50000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor50000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor50000.Enabled = false;
            this.txtValor50000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor50000.Location = new System.Drawing.Point(178, 78);
            this.txtValor50000.MaxLength = 20;
            this.txtValor50000.Name = "txtValor50000";
            this.txtValor50000.Size = new System.Drawing.Size(140, 21);
            this.txtValor50000.TabIndex = 68;
            this.txtValor50000.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "100.000";
            // 
            // txtValor100000
            // 
            this.txtValor100000.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor100000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor100000.Enabled = false;
            this.txtValor100000.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor100000.Location = new System.Drawing.Point(178, 51);
            this.txtValor100000.MaxLength = 20;
            this.txtValor100000.Name = "txtValor100000";
            this.txtValor100000.Size = new System.Drawing.Size(140, 21);
            this.txtValor100000.TabIndex = 66;
            this.txtValor100000.Text = "0";
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
            this.btnGuardar.Location = new System.Drawing.Point(122, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 40);
            this.btnGuardar.TabIndex = 89;
            this.btnGuardar.Text = "Siguiente";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CIERRE_BILLETES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(328, 320);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtcantidad1000);
            this.Controls.Add(this.txtcantidad2000);
            this.Controls.Add(this.txtCantidad5000);
            this.Controls.Add(this.txtcantidad10000);
            this.Controls.Add(this.txtCantidad20000);
            this.Controls.Add(this.txtCantidad50000);
            this.Controls.Add(this.txtCantidad100000);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtTotalBilletes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValor1000);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValor2000);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValor5000);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor10000);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor20000);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor50000);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValor100000);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIERRE_BILLETES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIERRE_BILLETES";
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
        public System.Windows.Forms.TextBox txtcantidad1000;
        public System.Windows.Forms.TextBox txtcantidad2000;
        public System.Windows.Forms.TextBox txtCantidad5000;
        public System.Windows.Forms.TextBox txtcantidad10000;
        public System.Windows.Forms.TextBox txtCantidad20000;
        public System.Windows.Forms.TextBox txtCantidad50000;
        public System.Windows.Forms.TextBox txtCantidad100000;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtTotalBilletes;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtValor1000;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtValor2000;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtValor5000;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtValor10000;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtValor20000;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtValor50000;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtValor100000;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}