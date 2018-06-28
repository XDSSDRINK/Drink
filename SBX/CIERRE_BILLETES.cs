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
    public partial class CIERRE_BILLETES : Form
    {
        CONTROLLER.General gnl = new CONTROLLER.General();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public CIERRE_BILLETES()
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

        int Validado = 0;
        public int CodigoUsuario { get; set; }
        List<double> Billetes = new List<double>();

        //Billetes
        double B100 = 0;
        double B50 = 0;
        double B20 = 0;
        double B10 = 0;
        double B5 = 0;
        double B2 = 0;
        double B1 = 0;
        double TotalB = 0;

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            //Billetes
            if (txtCantidad100000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad100000, "Ingrese Billetes de 100.000");
                Validado++;
            }
            if (txtCantidad50000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad50000, "Ingrese Billetes de 50.000");
                Validado++;
            }
            if (txtCantidad20000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad20000, "Ingrese Billetes de 20.000");
                Validado++;
            }
            if (txtcantidad10000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtcantidad10000, "Ingrese Billetes de 10.000");
                Validado++;
            }
            if (txtCantidad5000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad5000, "Ingrese Billetes de 5.000");
                Validado++;
            }
            if (txtcantidad2000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtcantidad2000, "Ingrese Billetes de 2.000");
                Validado++;
            }
            if (txtcantidad1000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtcantidad1000, "Ingrese Billetes de 1.000");
                Validado++;
            }
        }

        private void CalcularBase()
        {
            //Calcular Billetes
            B100 = Convert.ToDouble(txtCantidad100000.Text) * 100000;
            txtValor100000.Text = B100.ToString("N");
            B50 = Convert.ToDouble(txtCantidad50000.Text) * 50000;
            txtValor50000.Text = B50.ToString("N");
            B20 = Convert.ToDouble(txtCantidad20000.Text) * 20000;
            txtValor20000.Text = B20.ToString("N");
            B10 = Convert.ToDouble(txtcantidad10000.Text) * 10000;
            txtValor10000.Text = B10.ToString("N");
            B5 = Convert.ToDouble(txtCantidad5000.Text) * 5000;
            txtValor5000.Text = B5.ToString("N");
            B2 = Convert.ToDouble(txtcantidad2000.Text) * 2000;
            txtValor2000.Text = B2.ToString("N");
            B1 = Convert.ToDouble(txtcantidad1000.Text) * 1000;
            txtValor1000.Text = B1.ToString("N");

            TotalB = (B100 + B50 + B20 + B10 + B5 + B2 + B1);
            txtTotalBilletes.Text = TotalB.ToString("N");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();

                Billetes.Add(100000);
                Billetes.Add(Convert.ToInt32(txtCantidad100000.Text));
                Billetes.Add(50000);
                Billetes.Add(Convert.ToInt32(txtCantidad50000.Text));
                Billetes.Add(20000);
                Billetes.Add(Convert.ToInt32(txtCantidad20000.Text));
                Billetes.Add(10000);
                Billetes.Add(Convert.ToInt32(txtcantidad10000.Text));
                Billetes.Add(5000);
                Billetes.Add(Convert.ToInt32(txtCantidad5000.Text));
                Billetes.Add(2000);
                Billetes.Add(Convert.ToInt32(txtcantidad2000.Text));
                Billetes.Add(1000);
                Billetes.Add(Convert.ToInt32(txtcantidad1000.Text));

                CIERRE_MONEDAS CM = new CIERRE_MONEDAS();
                for (int i = 0; i < this.Billetes.Count; i++)
                {
                    CM.BilletesT.Add(this.Billetes[i]);
                }
                CM.CodigoUsuario = this.CodigoUsuario;
                this.Dispose();
                this.Close();
                CM.ShowDialog();
            }
        }

        private void txtCantidad100000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad50000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad20000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtcantidad10000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad5000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtcantidad2000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtcantidad1000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad100000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidad50000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidad20000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtcantidad10000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidad5000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtcantidad2000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void Limpiar()
        {
            txtCantidad100000.Text = "0";
            txtcantidad10000.Text = "0";
            txtcantidad1000.Text = "0";
            txtCantidad50000.Text = "0";
            txtCantidad20000.Text = "0";
            txtCantidad5000.Text = "0";
            txtcantidad2000.Text = "0";
            txtTotalBilletes.Text = "0";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
