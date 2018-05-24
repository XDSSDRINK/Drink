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
    public partial class DETALLE_PRODUCTO_PARAMETROS : Form
    {
        CONTROLLER.Marca marca = new CONTROLLER.Marca();
        CONTROLLER.Presentacion presentacion = new CONTROLLER.Presentacion();
        CONTROLLER.Categoria Categoria = new CONTROLLER.Categoria();
        CONTROLLER.UnidadMedida unidadMedida = new CONTROLLER.UnidadMedida();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Delegado 
        public delegate void AgregaCaracteristica();
        public event AgregaCaracteristica AgregaCaracteristicas;

        bool ok;
        DataTable DT;
        int contador = 0;

        //// Create a new form.
        Form mdiChildForm = new Form();

        public DETALLE_PRODUCTO_PARAMETROS()
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

        private void DETALLE_PRODUCTO_PARAMETROS_Load(object sender, EventArgs e)
        {
            cbxCaracteristicas.SelectedIndex = 0;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ok = validaNombre();
            Guardar();
            AgregaCaracteristicas();
        }

        private bool validaNombre()
        {
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider.SetError(txtNombre, "Ingrese " + cbxCaracteristicas.Text);
                txtNombre.Focus();
                ok = false;
            }
            else
            {
                errorProvider.Clear();
                ok = true;
            }

            return ok;
        }

        private void Guardar()
        {
            if (ok == true)
                {
                   switch (cbxCaracteristicas.Text)
                    {
                        case "Marca":
                            DT = null;
                            contador = 0;
                            DT = marca.CargaMarca(true);
                            if (DT.Rows.Count > 0)
                            {
                                foreach (DataRow row in DT.Rows)
                                {
                                    if (row["Nombre"].ToString() == txtNombre.Text)
                                    {
                                        contador++;
                                    }
                                }
                            }
                            if (contador > 0)
                            {
                                errorProvider.SetError(txtNombre, txtNombre.Text + " Ya existe");
                                txtNombre.Focus();
                            }
                            else
                            {
                                errorProvider.Clear();
                                marca.Nombre_ = txtNombre.Text;
                                ok = marca.Registrar();
                            }
                            break;

                        case "Presentación":
                            DT = null;
                            contador = 0;
                            DT = presentacion.CargaPresentacion(true);
                            if (DT.Rows.Count > 0)
                            {
                                foreach (DataRow row in DT.Rows)
                                {
                                    if (row["Nombre"].ToString() == txtNombre.Text)
                                    {
                                        contador++;
                                    }
                                }
                            }
                            if (contador > 0)
                            {
                                errorProvider.SetError(txtNombre, txtNombre.Text + " Ya existe");
                                txtNombre.Focus();
                            }
                            else
                            {
                                errorProvider.Clear();
                                presentacion.Nombre_ = txtNombre.Text;
                                ok = presentacion.Registrar();
                            }
                            break;

                        case "Categoría":
                            DT = null;
                            contador = 0;
                            DT = Categoria.CargaCategoria(true);
                            if (DT.Rows.Count > 0)
                            {
                                foreach (DataRow row in DT.Rows)
                                {
                                    if (row["Nombre"].ToString() == txtNombre.Text)
                                    {
                                        contador++;
                                    }
                                }
                            }
                            if (contador > 0)
                            {
                                errorProvider.SetError(txtNombre, txtNombre.Text + " Ya existe");
                                txtNombre.Focus();
                            }
                            else
                            {
                                errorProvider.Clear();
                                Categoria.Nombre_ = txtNombre.Text;
                                ok = Categoria.Registrar();
                            }
                            break;

                        case "Unidad medida":
                            DT = null;
                            contador = 0;
                            DT = unidadMedida.CargaUnidadMedida(true);
                            if (DT.Rows.Count > 0)
                            {
                                foreach (DataRow row in DT.Rows)
                                {
                                    if (row["Nombre"].ToString() == txtNombre.Text)
                                    {
                                        contador++;
                                    }
                                }
                            }
                            if (contador > 0)
                            {
                                errorProvider.SetError(txtNombre, txtNombre.Text + " Ya existe");
                                txtNombre.Focus();
                            }
                            else
                            {
                                errorProvider.Clear();
                                unidadMedida.Nombre_ = txtNombre.Text;
                                ok = unidadMedida.Registrar();
                            }
                            break;
                   }

                    if (contador == 0)
                    {
                        if (ok == true)
                        {
                            MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();
                            mENSAJECORRECTO.lblMensaje.Text = cbxCaracteristicas.Text + " registrada correctamente";
                            mENSAJECORRECTO.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
                            mENSAJE_ERROR.lblMensaje.Text = "Error al intentar registrar " + cbxCaracteristicas.Text;
                            mENSAJE_ERROR.ShowDialog();
                        }
                    }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
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

        private void cbxCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
