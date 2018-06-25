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
    public partial class PUNTOS : Form
    {
        CONTROLLER.General gnr = new CONTROLLER.General();
        CONTROLLER.CONFG_PUNTOS confPuntos = new CONTROLLER.CONFG_PUNTOS();
        MENSAJECORRECTO MSGcORRECTO = new MENSAJECORRECTO();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        DataTable DT;

        double Monto = 0;
        double Descuento = 0;
        int Validado = 0;
        bool OK = true;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public PUNTOS()
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

        private void PUNTOS_Load(object sender, EventArgs e)
        {
            CargarInfoPuntos();
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

        private void CargarInfoPuntos()
        {
            DT = confPuntos.CargarConfgPuntos();
            if (DT.Rows.Count > 0)
            {
                DataRow rows = DT.Rows[0];
                Monto = Convert.ToDouble(rows["XcadaMonto"]);
                txtMonto.Text = Monto.ToString("N");
                txtPuntos.Text = rows["AcumulaPuntos"].ToString();
                txtPuntosPremio.Text = rows["XcadaPuntos"].ToString();
                Descuento = Convert.ToDouble(rows["Descuento"]);
                txtDescuentoP.Text = Descuento.ToString("N");
            }           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            errorProvider1.Clear();
            txtMonto.Text = "";
            txtPuntos.Text = "";
            txtPuntosPremio.Text = "";
            txtDescuentoP.Text = "";
            this.Close();
        }

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            if (txtMonto.Text == "")
            {
                errorProvider1.SetError(txtMonto, "Rellena: X cada 0000 Pesos");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtMonto.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtMonto, "Ingrese Valores numericos");
                    Validado++;
                }
            }

            if (txtPuntos.Text == "")
            {
                errorProvider1.SetError(txtPuntos, "Rellena: Acumula 00 Puntos");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtPuntos.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtPuntos, "Ingrese Valores numericos");
                    Validado++;
                }
            }

            if (txtPuntosPremio.Text == "")
            {
                errorProvider1.SetError(txtPuntosPremio, "Rellena: X cada 00 Puntos");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtPuntosPremio.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtPuntosPremio, "Ingrese Valores numericos");
                    Validado++;
                }
            }

            if (txtDescuentoP.Text == "")
            {
                errorProvider1.SetError(txtDescuentoP, "Rellena: Descuento 00 %");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtDescuentoP.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtDescuentoP, "Ingrese Valores numericos");
                    Validado++;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void txtPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnr.ValidaNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion();

            if (Validado == 0)
            {
                // Limpiar tabla [CONFG_PUNTOS]
                OK = confPuntos.Eliminar();
                if (OK)
                {
                    confPuntos.XcadaMonto = Convert.ToDouble(txtMonto.Text);
                    confPuntos.AcumulaPuntos = Convert.ToInt32(txtPuntos.Text);
                    confPuntos.XcadaPuntos = Convert.ToInt32(txtPuntosPremio.Text);
                    confPuntos.Descuento = float.Parse(txtDescuentoP.Text);
                    OK = confPuntos.Registrar();

                    if (OK)
                    {
                        MSGcORRECTO.lblMensaje.Text = "Puntos configurados correctamente";
                        MSGcORRECTO.ShowDialog();
                    }
                    else
                    {
                        msgError.lblMensaje.Text = "Error al intentar registrar";
                        msgError.ShowDialog();
                    }
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

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            Validacion();

            if (Validado == 0)
            {
                Monto = Convert.ToDouble(txtMonto.Text);
                txtMonto.Text = Monto.ToString("N");
            }
        }

        private void txtPuntos_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtPuntosPremio_Leave(object sender, EventArgs e)
        {
       
        }

        private void txtDescuentoP_Leave(object sender, EventArgs e)
        {
            Validacion();

            if (Validado == 0)
            {
                Descuento = Convert.ToDouble(txtDescuentoP.Text);
                txtDescuentoP.Text = Descuento.ToString("N");
            }
        }

        private void txtPuntosPremio_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnr.ValidaNumeros(e);
        }
    }
}
