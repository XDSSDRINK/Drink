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
    public partial class DETALLE_MESA : Form
    {
        public String nombre = "";
        public String detalle = "";

        int Validado = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public DETALLE_MESA()
        {           
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();
            txtNombre.Text = "";
            txtDetalle.Text = "";
        }

        public DETALLE_MESA(string nombre, string detalle)
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();

            this.nombre = nombre;
            this.detalle = detalle;
            txtNombre.Text = nombre;
            txtDetalle.Text = detalle;
        }

        private void DETALLE_MESA_Load(object sender, EventArgs e)
        {
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
            //Limpiar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Limpiar();
            this.Close();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtNombre.Enabled = true;
            txtDetalle.Text = "";
            errorProvider1.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Validaciones()
        {
            Validado = 0;
            errorProvider1.Clear();

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre para la mesa.");
                Validado++;
            }

            if (txtDetalle.Text == "")
            {
                errorProvider1.SetError(txtDetalle, "Ingrese un detalle para la mesa.");
                Validado++;
            }            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();

            if (Validado == 0)
            {
                errorProvider1.Clear();
                nombre = txtNombre.Text;
                detalle = txtDetalle.Text;
                this.Close();              
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
