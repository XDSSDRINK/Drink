namespace SBX
{
    partial class INVENTARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTARIOS));
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.dtgKARDEX = new System.Windows.Forms.DataGridView();
            this.ClFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarInventario = new System.Windows.Forms.Button();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKARDEX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArriba.Controls.Add(this.btnCargarInventario);
            this.pnlArriba.Controls.Add(this.button1);
            this.pnlArriba.Controls.Add(this.txtBuscar);
            this.pnlArriba.Controls.Add(this.btnBuscar);
            this.pnlArriba.Controls.Add(this.btnActualizar);
            this.pnlArriba.Controls.Add(this.btnCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(0, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(961, 52);
            this.pnlArriba.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(48, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(650, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar item";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            this.txtBuscar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(847, 9);
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
            this.btnActualizar.Location = new System.Drawing.Point(9, 11);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(33, 31);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(925, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 15);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtgKARDEX
            // 
            this.dtgKARDEX.AllowUserToAddRows = false;
            this.dtgKARDEX.AllowUserToDeleteRows = false;
            this.dtgKARDEX.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgKARDEX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKARDEX.BackgroundColor = System.Drawing.Color.White;
            this.dtgKARDEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgKARDEX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKARDEX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgKARDEX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKARDEX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClFechaRegistro,
            this.ClAccion,
            this.Clitem,
            this.ClDetalle,
            this.ClCosto,
            this.ClEntrada,
            this.ClSalida,
            this.ClExistencia,
            this.ClSaldo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKARDEX.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgKARDEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKARDEX.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgKARDEX.Location = new System.Drawing.Point(0, 52);
            this.dtgKARDEX.Name = "dtgKARDEX";
            this.dtgKARDEX.ReadOnly = true;
            this.dtgKARDEX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKARDEX.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgKARDEX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgKARDEX.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgKARDEX.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgKARDEX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKARDEX.Size = new System.Drawing.Size(961, 441);
            this.dtgKARDEX.TabIndex = 5;
            // 
            // ClFechaRegistro
            // 
            this.ClFechaRegistro.HeaderText = "Fecha registro";
            this.ClFechaRegistro.Name = "ClFechaRegistro";
            this.ClFechaRegistro.ReadOnly = true;
            this.ClFechaRegistro.Width = 200;
            // 
            // ClAccion
            // 
            this.ClAccion.HeaderText = "Accion";
            this.ClAccion.Name = "ClAccion";
            this.ClAccion.ReadOnly = true;
            // 
            // Clitem
            // 
            this.Clitem.HeaderText = "Item";
            this.Clitem.Name = "Clitem";
            this.Clitem.ReadOnly = true;
            // 
            // ClDetalle
            // 
            this.ClDetalle.HeaderText = "Detalle";
            this.ClDetalle.Name = "ClDetalle";
            this.ClDetalle.ReadOnly = true;
            this.ClDetalle.Width = 235;
            // 
            // ClCosto
            // 
            this.ClCosto.HeaderText = "Costo";
            this.ClCosto.Name = "ClCosto";
            this.ClCosto.ReadOnly = true;
            // 
            // ClEntrada
            // 
            this.ClEntrada.HeaderText = "Entrada";
            this.ClEntrada.Name = "ClEntrada";
            this.ClEntrada.ReadOnly = true;
            // 
            // ClSalida
            // 
            this.ClSalida.HeaderText = "Salida";
            this.ClSalida.Name = "ClSalida";
            this.ClSalida.ReadOnly = true;
            // 
            // ClExistencia
            // 
            this.ClExistencia.HeaderText = "Existencia";
            this.ClExistencia.Name = "ClExistencia";
            this.ClExistencia.ReadOnly = true;
            // 
            // ClSaldo
            // 
            this.ClSaldo.HeaderText = "Saldo";
            this.ClSaldo.Name = "ClSaldo";
            this.ClSaldo.ReadOnly = true;
            // 
            // btnCargarInventario
            // 
            this.btnCargarInventario.BackColor = System.Drawing.SystemColors.Window;
            this.btnCargarInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarInventario.FlatAppearance.BorderSize = 0;
            this.btnCargarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarInventario.Image")));
            this.btnCargarInventario.Location = new System.Drawing.Point(87, 11);
            this.btnCargarInventario.Name = "btnCargarInventario";
            this.btnCargarInventario.Size = new System.Drawing.Size(33, 31);
            this.btnCargarInventario.TabIndex = 8;
            this.btnCargarInventario.UseVisualStyleBackColor = false;
            this.btnCargarInventario.Click += new System.EventHandler(this.btnCargarInventario_Click);
            // 
            // INVENTARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(961, 493);
            this.Controls.Add(this.dtgKARDEX);
            this.Controls.Add(this.pnlArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "INVENTARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTARIOS";
            this.Load += new System.EventHandler(this.INVENTARIOS_Load);
            this.pnlArriba.ResumeLayout(false);
            this.pnlArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKARDEX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataGridView dtgKARDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCargarInventario;
    }
}