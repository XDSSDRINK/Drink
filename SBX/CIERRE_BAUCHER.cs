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
    public partial class CIERRE_BAUCHER : Form
    {
        CONTROLLER.General Gnl = new CONTROLLER.General();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        bool OK = true;
        int Validado = 0;
        public List<double> MonedasT = new List<double>();
        public List<double> BilletesT = new List<double>();
        private List<double> Baucher = new List<double>();

        public int CodigoUsuario { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public CIERRE_BAUCHER()
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

        private void CIERRE_BAUCHER_Load(object sender, EventArgs e)
        {
            EstiloTabla();

            foreach (DataGridViewRow rows in dtgBaucher.Rows)
            {
               rows.Cells["ClNumeroBaucher"].Value = "0";
               rows.Cells["ClValor"].Value = "0";
            }

            CalcularBase();
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

        private void EstiloTabla()
        {
            dtgBaucher.EnableHeadersVisualStyles = false;
            dtgBaucher.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgBaucher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgBaucher.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidacionCantidad()
        {
            Validado = 0;
            foreach (DataGridViewRow rows in dtgBaucher.Rows)
            {
                if (rows.Cells["ClNumeroBaucher"].Value == null)
                {
                    rows.Cells["ClNumeroBaucher"].Value = "0";
                }
                if (rows.Cells["ClValor"].Value == null)
                {
                    rows.Cells["ClValor"].Value = "0";
                }

                OK = Gnl.IsNumericDouble(rows.Cells["ClNumeroBaucher"].Value.ToString());
                if (!OK)
                {
                    rows.Cells["ClNumeroBaucher"].Value = "0";
                    Validado++;
                }

                OK = Gnl.IsNumericDouble(rows.Cells["ClValor"].Value.ToString());
                if (!OK)
                {
                    rows.Cells["ClValor"].Value = "0";
                    Validado++;
                }

                if (Validado > 0)
                {
                    msgError.lblMensaje.Text = "Ingrese valores numericos";
                    msgError.ShowDialog();
                }
            }
        }

        private void RellenarCampo()
        {
            foreach (DataGridViewRow rows in dtgBaucher.Rows)
            {
                if (rows.Cells["ClNumeroBaucher"].Value.ToString().Trim() == "")
                {
                    rows.Cells["ClNumeroBaucher"].Value = "0";
                }
                if (rows.Cells["ClValor"].Value.ToString().Trim() == "")
                {
                    rows.Cells["ClValor"].Value = "0";
                }
            }
        }

        private void CalcularBase()
        {
            //Total Billetes
            double Temp = 0;
            double Total = 0;
            double Base = 0;
            double TotalBaucher = 0;

            foreach (var Bill in BilletesT)
            {
                if (Temp == 0)
                {
                    Temp = Bill;
                }
                else
                {
                    Total += Temp * Bill;
                    Temp = 0;
                }
            }

            //Total Monedas
            foreach (var Mon in MonedasT)
            {
                if (Temp == 0)
                {
                    Temp = Mon;
                }
                else
                {
                    Total += Temp * Mon;
                    Temp = 0;
                }
            }

            //Total Baucher
            foreach (DataGridViewRow rows in dtgBaucher.Rows)
            {
                TotalBaucher += Convert.ToDouble(rows.Cells["ClValor"].Value);
            }

            txtTotalBaucher.Text = TotalBaucher.ToString("N");

            //Total base
            Base = Total + TotalBaucher;
            txtValorTotalBase.Text = Base.ToString("N");
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidacionCantidad();

            if (Validado == 0)
            {
                CalcularBase();

                INFORME_CIERRE_CAJA InfoC = new INFORME_CIERRE_CAJA();
                //Billetes
                for (int i = 0; i < this.BilletesT.Count; i++)
                {
                    InfoC.Billetes.Add(this.BilletesT[i]);
                }
                //Monedas
                for (int i = 0; i < this.MonedasT.Count; i++)
                {
                    InfoC.Monedas.Add(this.MonedasT[i]);
                }
                //Baucher
                foreach (DataGridViewRow rows in dtgBaucher.Rows)
                {
                    Baucher.Add(Convert.ToDouble(rows.Cells["ClNumeroBaucher"].Value));
                    Baucher.Add(Convert.ToDouble(rows.Cells["ClValor"].Value));
                }

                for (int i = 0; i < this.Baucher.Count; i++)
                {
                    InfoC.Baucher.Add(this.Baucher[i]);
                }
                InfoC.CodigoUsuario = this.CodigoUsuario;
                this.Dispose();
                this.Close();
                InfoC.ShowDialog();
            }
        }

        private void dtgBaucher_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            ValidacionCantidad();

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
    }
}
