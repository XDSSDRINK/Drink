namespace SBX
{
    partial class CIERRE_BAUCHER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIERRE_BAUCHER));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgBaucher = new System.Windows.Forms.DataGridView();
            this.ClNumeroBaucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtValorTotalBase = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTotalBaucher = new System.Windows.Forms.TextBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaucher)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(481, 38);
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
            this.btnCerrar.Location = new System.Drawing.Point(453, 9);
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
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre Baucher";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // dtgBaucher
            // 
            this.dtgBaucher.AllowUserToDeleteRows = false;
            this.dtgBaucher.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgBaucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBaucher.BackgroundColor = System.Drawing.Color.White;
            this.dtgBaucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBaucher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBaucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBaucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNumeroBaucher,
            this.ClValor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBaucher.GridColor = System.Drawing.Color.CadetBlue;
            this.dtgBaucher.Location = new System.Drawing.Point(12, 47);
            this.dtgBaucher.Name = "dtgBaucher";
            this.dtgBaucher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBaucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgBaucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dtgBaucher.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgBaucher.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgBaucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgBaucher.Size = new System.Drawing.Size(457, 275);
            this.dtgBaucher.TabIndex = 7;
            this.dtgBaucher.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBaucher_CellValidated);
            // 
            // ClNumeroBaucher
            // 
            this.ClNumeroBaucher.HeaderText = "Numero Baucher";
            this.ClNumeroBaucher.Name = "ClNumeroBaucher";
            this.ClNumeroBaucher.Width = 225;
            // 
            // ClValor
            // 
            this.ClValor.HeaderText = "Valor";
            this.ClValor.Name = "ClValor";
            this.ClValor.Width = 210;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(197, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 40);
            this.btnGuardar.TabIndex = 105;
            this.btnGuardar.Text = "Siguiente";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 367);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 15);
            this.label20.TabIndex = 108;
            this.label20.Text = "Base";
            // 
            // txtValorTotalBase
            // 
            this.txtValorTotalBase.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotalBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotalBase.Enabled = false;
            this.txtValorTotalBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalBase.Location = new System.Drawing.Point(75, 367);
            this.txtValorTotalBase.MaxLength = 20;
            this.txtValorTotalBase.Name = "txtValorTotalBase";
            this.txtValorTotalBase.Size = new System.Drawing.Size(349, 20);
            this.txtValorTotalBase.TabIndex = 107;
            this.txtValorTotalBase.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 341);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 15);
            this.label19.TabIndex = 110;
            this.label19.Text = "Σ";
            // 
            // txtTotalBaucher
            // 
            this.txtTotalBaucher.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalBaucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBaucher.Enabled = false;
            this.txtTotalBaucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBaucher.Location = new System.Drawing.Point(75, 340);
            this.txtTotalBaucher.MaxLength = 20;
            this.txtTotalBaucher.Name = "txtTotalBaucher";
            this.txtTotalBaucher.Size = new System.Drawing.Size(349, 20);
            this.txtTotalBaucher.TabIndex = 109;
            this.txtTotalBaucher.Text = "0";
            // 
            // CIERRE_BAUCHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtTotalBaucher);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtValorTotalBase);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgBaucher);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIERRE_BAUCHER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIERRE_BAUCHER";
            this.Load += new System.EventHandler(this.CIERRE_BAUCHER_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBaucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgBaucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNumeroBaucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClValor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtValorTotalBase;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtTotalBaucher;
    }
}