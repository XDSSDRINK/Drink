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
    public partial class CIERRE_MONEDAS : Form
    {
        CONTROLLER.General gnl = new CONTROLLER.General();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();
        public CIERRE_MONEDAS()
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

        int Validado = 0;
        //Monedas
        double M1000 = 0;
        double M500 = 0;
        double M200 = 0;
        double M100 = 0;
        double M50 = 0;
        double M20 = 0;
        double M10 = 0;
        double TotalM = 0;
        double Base = 0;

        List<double> Monedas = new List<double>();
        public List<double> BilletesT = new List<double>();

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

        private void txtCantidadM1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            //Monedas
            if (txtCantidadM1000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM1000, "Ingrese Monedas de 1.000");
                Validado++;
            }
            if (txtCantidadM500.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM500, "Ingrese Monedas de 500");
                Validado++;
            }
            if (txtCantidadM200.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM200, "Ingrese Monedas de 200");
                Validado++;
            }
            if (txtCantidadM100.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM100, "Ingrese Monedas de 100");
                Validado++;
            }
            if (txtCantidadM50.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM50, "Ingrese Monedas de 50");
                Validado++;
            }
            if (txtCantidadM20.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM20, "Ingrese Monedas de 20");
                Validado++;
            }
            if (txtCantidadM10.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM10, "Ingrese Monedas de 10");
                Validado++;
            }
        }

        private void CalcularBase()
        {
            //Calcular Monedas
            M1000 = Convert.ToDouble(txtCantidadM1000.Text) * 1000;
            txtValorM1000.Text = M1000.ToString("N");
            M500 = Convert.ToDouble(txtCantidadM500.Text) * 500;
            txtValorM500.Text = M500.ToString("N");
            M200 = Convert.ToDouble(txtCantidadM200.Text) * 200;
            txtValorM200.Text = M200.ToString("N");
            M100 = Convert.ToDouble(txtCantidadM100.Text) * 100;
            txtValorM100.Text = M100.ToString("N");
            M50 = Convert.ToDouble(txtCantidadM50.Text) * 50;
            txtValorM50.Text = M50.ToString("N");
            M20 = Convert.ToDouble(txtCantidadM20.Text) * 20;
            txtValorM20.Text = M20.ToString("N");
            M10 = Convert.ToDouble(txtCantidadM10.Text) * 10;
            txtValorM10.Text = M10.ToString("N");

            TotalM = (M1000 + M500 + M200 + M100 + M50 + M20 + M10);
            txtTotalMonedas.Text = TotalM.ToString("N");

            //Calculo Total
            double BilleTemp = 0;
            double TotalBilletes = 0;
            
            foreach (var Bill in BilletesT)
            {
                if (BilleTemp == 0)
                {
                    BilleTemp = Bill;
                }
                else
                {
                    TotalBilletes += BilleTemp * Bill;
                    BilleTemp = 0;
                }
            }
            Base = TotalM + TotalBilletes;
            txtValorTotalBase.Text = Base.ToString("N");
        }

        private void Limpiar()
        {
            //MONEDAS
            txtCantidadM1000.Text = "0";
            txtCantidadM500.Text = "0";
            txtCantidadM200.Text = "0";
            txtCantidadM100.Text = "0";
            txtCantidadM50.Text = "0";
            txtCantidadM20.Text = "0";
            txtCantidadM10.Text = "0";

            txtValorM1000.Text = "0";
            txtValorM500.Text = "0";
            txtValorM200.Text = "0";
            txtValorM100.Text = "0";
            txtValorM50.Text = "0";
            txtValorM20.Text = "0";
            txtValorM10.Text = "0";

            txtTotalMonedas.Text = "0";
            txtValorTotalBase.Text = "0";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();

                Monedas.Add(1000);
                Monedas.Add(Convert.ToInt32(txtCantidadM1000.Text));
                Monedas.Add(500);
                Monedas.Add(Convert.ToInt32(txtCantidadM500.Text));
                Monedas.Add(200);
                Monedas.Add(Convert.ToInt32(txtCantidadM200.Text));
                Monedas.Add(100);
                Monedas.Add(Convert.ToInt32(txtCantidadM100.Text));
                Monedas.Add(50);
                Monedas.Add(Convert.ToInt32(txtCantidadM50.Text));
                Monedas.Add(20);
                Monedas.Add(Convert.ToInt32(txtCantidadM20.Text));
                Monedas.Add(10);
                Monedas.Add(Convert.ToInt32(txtCantidadM10.Text));

                CIERRE_BAUCHER CB = new CIERRE_BAUCHER();
                //Billetes
                for (int i = 0; i < this.BilletesT.Count; i++)
                {
                    CB.BilletesT.Add(this.BilletesT[i]);
                }
                //Monedas
                for (int i = 0; i < this.Monedas.Count; i++)
                {
                    CB.MonedasT.Add(this.Monedas[i]);
                }

                this.Dispose();
                this.Close();
                CB.ShowDialog();
            }
        }

        private void txtCantidadM1000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void CIERRE_MONEDAS_Load(object sender, EventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
