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
    public partial class P_FACTURA : Form
    {
        CONTROLLER.General gnr = new CONTROLLER.General();
        CONTROLLER.Factura fact = new CONTROLLER.Factura();
        MENSAJECORRECTO MSGc = new MENSAJECORRECTO();
        MENSAJE_ERROR MSGeRR = new MENSAJE_ERROR();

        int Validado = 0;
        bool OK = true;
        DataTable DT;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public P_FACTURA()
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

        private void P_FACTURA_Load(object sender, EventArgs e)
        {
            CargarFactura();
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

        private void Salir()
        {
            errorProvider1.Clear();
            txtNombre.Text = "";
            txtConsectivoInicial.Text = "";
            txtConsecutivoFinal.Text = "";
            txtResolucion.Text = "";
            txtDetalle.Text = "";
            txtAlerta.Text = "";
            this.Close();
        }

        private void CargarFactura()
        {
            DT = fact.CargarFacura();
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];

                txtNombre.Text = row["Nombre"].ToString();
                txtConsectivoInicial.Text = row["ConseCutivoInicial"].ToString();
                txtConsecutivoFinal.Text = row["ConseCutivoFinal"].ToString();
                txtResolucion.Text = row["Resolucion"].ToString();
                txtDetalle.Text = row["Detalle"].ToString();
                txtAlerta.Text = row["Alerta"].ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese nombre de factura");
                Validado++;
            }

            if (txtConsectivoInicial.Text == "")
            {
                errorProvider1.SetError(txtConsectivoInicial, "Ingrese consecutivo inicial");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtConsectivoInicial.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtConsectivoInicial, "Ingrese Valores numericos");
                    Validado++;
                }
            }

            if (txtConsecutivoFinal.Text == "")
            {
                errorProvider1.SetError(txtConsecutivoFinal, "Ingrese consecutivo final");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtConsecutivoFinal.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtConsecutivoFinal, "Ingrese Valores numericos");
                    Validado++;
                }
            }

            if (txtResolucion.Text == "")
            {
                errorProvider1.SetError(txtResolucion, "Ingrese resolucion");
                Validado++;
            }

            if (txtDetalle.Text == "")
            {
                errorProvider1.SetError(txtDetalle, "Ingrese Detalle");
                Validado++;
            }

            if (txtAlerta.Text == "")
            {
                errorProvider1.SetError(txtAlerta, "Ingrese Alerta");
                Validado++;
            }
            else
            {
                OK = gnr.IsNumericDouble(txtAlerta.Text);
                if (!OK)
                {
                    errorProvider1.SetError(txtAlerta, "Ingrese Valores numericos");
                    Validado++;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                OK = fact.Eliminar();
                if (OK)
                {
                    fact.Nombre = txtNombre.Text;
                    fact.ConsecutivoInicial = float.Parse(txtConsectivoInicial.Text);
                    fact.Consecutivofinal = float.Parse(txtConsecutivoFinal.Text);
                    fact.Resolucion = txtResolucion.Text;
                    fact.Detalle = txtDetalle.Text;
                    fact.Alerta = float.Parse(txtAlerta.Text);

                    OK = fact.Registrar();
                    if (OK)
                    {
                        MSGc.lblMensaje.Text = "Factura registrada correctamente";
                        MSGc.ShowDialog();
                    }
                    else
                    {
                        MSGeRR.lblMensaje.Text = "Error al intentar registrar Factura";
                        MSGeRR.ShowDialog();
                    }
                }
                else
                {
                    MSGeRR.lblMensaje.Text = "Error al intentar registrar Factura";
                    MSGeRR.ShowDialog();
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
    }
}
