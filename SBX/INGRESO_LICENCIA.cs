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
    public partial class INGRESO_LICENCIA : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Form FrmMensaje = new Form();

        public INGRESO_LICENCIA()
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            FrmMensaje.MdiParent = this;

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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MENSAJE_ERROR oMsgErrLic = new MENSAJE_ERROR();
            MENSAJECORRECTO oMsgCorr = new MENSAJECORRECTO();

            if (txtCodLic.Text.Length != 43)
            {
                //Mensaje de error
                oMsgErrLic.lblMensaje.Text = "Codigo de licencia no valido.";
                oMsgErrLic.ShowDialog();
            }
            else
            {
                try
                {
                    CONTROLLER.Empresas oEmp = new CONTROLLER.Empresas();
                    oEmp.numlic_ = txtCodLic.Text;
                    oEmp.modificar();

                    oMsgCorr.lblMensaje.Text = "Licencia activada correctamente.";
                    oMsgCorr.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    oMsgErrLic.lblMensaje.Text = "Error activando licencia.";
                    oMsgErrLic.ShowDialog();
                }
            }
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
