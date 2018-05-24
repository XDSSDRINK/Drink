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
    public partial class DETALLE_COMPRAS : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();
        public DETALLE_COMPRAS()
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

        private void Limpiar() {
            txtDocumento.Text = "";
            txtNombreDoc.Text = "";
            txtConsecutivoDoc.Text = "";
            txtItemProd.Text = "";
            txtNombreProd.Text = "";
            txtDNIProveedor.Text = "";
            txtNombreComercial.Text = "";
            txtRazonSocial.Text = "";
            txtFechaVence.Text = "";
            txtCantidad.Text = "";
            txtDescripcionCantidad.Text = "";
            txtCosto.Text = "";
            txtMargen.Text = "";
            txtIVA.Text = "";
            txtLote.Text = "";
            txtSerial.Text = "";
            txtCodigoBarras.Text = "";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
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
