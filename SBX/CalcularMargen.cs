using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class CalcularMargen : Form
    {
        CONTROLLER.General general = new CONTROLLER.General();

        //Delegado  Margen de venta
        public delegate void EnviaMargenVenta(string Porcentaje);
        public event EnviaMargenVenta MargenVentas;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public string Modulo { get; set; }
        public string Producto { get; set; }
        public string Costos { get; set; }
        public string Margen { get; set; }
        double Costo = 0;
        double Aumento = 0;
        double MargenV = 0;

        public double PrecioVenta { get; set; }
        double Valor = 0;
        double Descuento = 0;
        double NuevoPrecioVenta = 0;

        //// Create a new form.
        Form mdiChildForm = new Form();

        public CalcularMargen()
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();
        }

        private void CalcularMargen_Load(object sender, EventArgs e)
        {
            Costo = Convert.ToDouble(Costos);
            txtCosto.Text = Costo.ToString("N2");
            MargenV = Convert.ToDouble(Margen);
            lblMargen.Text = MargenV.ToString("N2");
            lblProducto.Text = Producto;
            EstiloTabla();
            CalcularValores();
        }

        private void EstiloTabla()
        {
            dtgCalculoMargen.EnableHeadersVisualStyles = false;
            dtgCalculoMargen.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgCalculoMargen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgCalculoMargen.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.White;
                }
            }

        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CalculoPrecios()
        {
            Costo = Convert.ToDouble(txtCosto.Text);
            Aumento = Convert.ToDouble(txtPorcentaje.Text);
            if (Aumento < 0)
            {
                txtPorcentaje.Text = "0";
                Aumento = 0;
            }
            dtgCalculoMargen.Rows.Clear();

            while (Aumento <= 100)
            {
                PrecioVenta = Costo / (1 - (Aumento / 100));
                Valor = PrecioVenta - Costo;

                dtgCalculoMargen.Rows.Add(Costo.ToString("N2"), Aumento, Valor.ToString("N2"), PrecioVenta.ToString("N2"));

                if (Convert.ToDouble(txtPorcentaje.Text) == 0)
                {
                    Aumento++;
                }
                else
                {
                    Aumento = Aumento + Convert.ToDouble(txtPorcentaje.Text);
                }
            }
        }

        private void Calcular()
        {
            if (Modulo == "Venta")
            {
                CalculoDescuentos();
            }
            else
            {
                CalculoPrecios();
            }
        }

        private void CalculoDescuentos()
        {
            Costo = Convert.ToDouble(txtCosto.Text);
            Descuento = Convert.ToDouble(txtPorcentaje.Text);
            txtCosto.Enabled = false;
            if (Descuento < 0)
            {
                txtPorcentaje.Text = "0";
                Descuento = 0;
            }
            dtgCalculoMargen.Rows.Clear();

            while (Descuento <= 100)
            {
                Valor = PrecioVenta * (Descuento / 100);
                NuevoPrecioVenta = PrecioVenta - Valor;
                dtgCalculoMargen.Columns[0].HeaderText = "Precio UN";
                dtgCalculoMargen.Columns[2].HeaderText = "Descuento";
                dtgCalculoMargen.Rows.Add(PrecioVenta.ToString("N2"), Descuento * -1, Valor.ToString("N2"), NuevoPrecioVenta.ToString("N2"));

                if (Convert.ToDouble(txtPorcentaje.Text) == 0)
                {
                    Descuento++;
                }
                else
                {
                    Descuento = Descuento + Convert.ToDouble(txtPorcentaje.Text);
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularValores();
        }

        private void dtgCalculoMargen_DoubleClick(object sender, EventArgs e)
        {
            int fila = 0;
            double Porcentaje = 0;

            fila = dtgCalculoMargen.CurrentRow.Index;   
            Porcentaje = Convert.ToDouble(dtgCalculoMargen[1, fila].Value);
            
            MargenVentas(Porcentaje.ToString());
            Limpiar();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void Limpiar()
        {
            lblProducto.Text = "----------------";
            lblMargen.Text = "-----";
            txtCosto.Text = "";
            txtPorcentaje.Text = "";
            dtgCalculoMargen.Rows.Clear();
        }

        private void txtPorcentaje_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularValores();
        }

        private void CalcularValores()
        {
            if (txtPorcentaje.Text.Trim() != "")
            {
                errorProvider1.Clear();
                if (general.IsNumericDouble(txtPorcentaje.Text) == true)
                {
                    errorProvider1.Clear();
                    Calcular();
                }
                else
                {
                    errorProvider1.SetError(txtPorcentaje, "Ingrese valores numericos");
                }
            }
            else
            {
                errorProvider1.SetError(txtPorcentaje, "Ingrese porcentaje");
                dtgCalculoMargen.Rows.Clear();
            }
        }
    }
}
