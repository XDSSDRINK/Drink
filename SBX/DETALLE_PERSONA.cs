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
    public partial class DETALLE_PERSONA : Form
    {
        //Delegado recargarPersonas
        public delegate void AgregarPersonas();
        public event AgregarPersonas AgregarPersona;

        CONTROLLER.Departamento departamento = new CONTROLLER.Departamento();
        CONTROLLER.Municipio municipio = new CONTROLLER.Municipio();
        CONTROLLER.Persona persona = new CONTROLLER.Persona();
        MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();
        MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
        CONTROLLER.General general = new CONTROLLER.General();

        DataTable DT;
        public  string Departamento { get; set; }
        public string Municipio { get; set; }
        public bool Nuevo { get; set; }
        bool ok = true;
        int Validado = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public DETALLE_PERSONA()
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

        private void DETALLE_PERSONA_Load(object sender, EventArgs e)
        {
            CargaDepartamentoMunicipio();
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

        private void CargaDepartamentoMunicipio()
        {
            //CargarDepartamento 
           
            DT = departamento.CargarDepartamento(true);

            cbxDepartamento.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxDepartamento.Items.Add(rows["Nombre"]);
                }

                cbxDepartamento.SelectedIndex = 0;

                //Cargar municipios de departamento
                municipio.Departamento = cbxDepartamento.Text;
                DT = municipio.CargarMunicipio(true);
                cbxMunicipio.Items.Clear();
                if (DT.Rows.Count > 0)
                {
                    foreach (DataRow rows in DT.Rows)
                    {
                        cbxMunicipio.Items.Add(rows["Nombre"]);
                    }

                    cbxMunicipio.SelectedIndex = 0;
                }
            }

            if (Departamento != "" && Municipio != "")
            {
                cbxDepartamento.Text = Departamento;
                cbxMunicipio.Text = Municipio;
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

        private void Limpiar()
        {
            txtDNI.Text = "";
            txtDNI.Enabled = true;
            txtTipoIdentificacion.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtBarrioVereda.Text = "";
            txtDireccion.Text = "";
            txtTelefonoFijo.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
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

            if (txtDNI.Text == "")
            {
                errorProvider1.SetError(txtDNI, "Ingrese DNI");
                Validado++;
            }
            else
            {
                if (general.IsNumericDouble(txtDNI.Text) == true)
                {
                    if (Nuevo == true)
                    {
                        DT = persona.Cargar();
                        if (DT.Rows.Count > 0)
                        {
                            foreach (DataRow personas in DT.Rows)
                            {
                                if (txtDNI.Text == personas["DNI"].ToString())
                                {
                                    errorProvider1.SetError(txtDNI, "DNI ya existe");
                                    Validado++;
                                }
                            }
                        }
                    }
                }
                else
                {
                    errorProvider1.SetError(txtDNI,"Ingrese valores numericos");
                    Validado++;
                }
            }

            if (txtTipoIdentificacion.Text == "")
            {
                errorProvider1.SetError(txtTipoIdentificacion, "Ingrese tipo de identificacion");
                Validado++;
            }

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres,"Ingrese nombres");
                Validado++;
            }

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese Apellidos");
                Validado++;
            }

            if (cbxDepartamento.Text == "")
            {
                errorProvider1.SetError(cbxDepartamento, "Ingrese Departamento");
                Validado++;
            }

            if (cbxMunicipio.Text == "")
            {
                errorProvider1.SetError(cbxMunicipio, "Ingrese Municipio");
                Validado++;
            }

            if (txtBarrioVereda.Text == "")
            {
                errorProvider1.SetError(txtBarrioVereda, "Ingrese Barrio/Vereda");
                Validado++;
            }

            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "Ingrese Direccion");
                Validado++;
            }

            if (txtTelefonoFijo.Text == "")
            {
                errorProvider1.SetError(txtTelefonoFijo, "Ingrese Telefono ");
                Validado++;
            }
            else
            {
                if (general.IsNumericDouble(txtTelefonoFijo.Text) == false)
                {
                    errorProvider1.SetError(txtTelefonoFijo,"Ingrese valores numericos");
                    Validado++;
                }
            }

            //if (txtEmail.Text == "")
            //{
            //    errorProvider1.SetError(txtEmail, "Ingrese txtEmail ");
            //    Validado++;
            //}

            if (txtCelular.Text == "")
            {
                errorProvider1.SetError(txtCelular, "Ingrese Celular ");
                Validado++;
            }
            else
            {
                if (general.IsNumericDouble(txtCelular.Text) == false)
                {
                    errorProvider1.SetError(txtCelular, "Ingrese valores numericos");
                    Validado++;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validaciones();

            if (Validado == 0)
            {
                errorProvider1.Clear();

                if (Nuevo == true)
                {
                    persona.DNI = Convert.ToDouble(txtDNI.Text);
                    persona.TipoIdentificacion = txtTipoIdentificacion.Text;
                    persona.Nombres = txtNombres.Text;
                    persona.Apellidos = txtApellidos.Text;
                    DT = departamento.CargarDepartamento(true);
                    foreach (DataRow depar in DT.Rows)
                    {
                        if (cbxDepartamento.Text == depar["Nombre"].ToString())
                        {
                            persona.Departamento = depar["Codigo"].ToString();
                        }
                    }

                    DT = municipio.CargarMunicipio(true);
                    foreach (DataRow muni in DT.Rows)
                    {
                        if (cbxMunicipio.Text == muni["Nombre"].ToString())
                        {
                            persona.Municipio = muni["Codigo"].ToString();
                        }
                    }

                    persona.BarrioVereda = txtBarrioVereda.Text;
                    persona.Direccion = txtDireccion.Text;
                    persona.Telefono = txtTelefonoFijo.Text;
                    persona.Email = txtEmail.Text;
                    persona.Celular = txtCelular.Text;

                    ok = persona.Registrar();

                    if (ok == true)
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Persona registrada correctamente";
                        mENSAJECORRECTO.ShowDialog();
                        Limpiar();
                    }
                    else
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "No fue posible registrar persona";
                        mENSAJE_ERROR.ShowDialog();
                    }
                }
                else
                {
                    persona.DNI = Convert.ToDouble(txtDNI.Text);
                    persona.TipoIdentificacion = txtTipoIdentificacion.Text;
                    persona.Nombres = txtNombres.Text;
                    persona.Apellidos = txtApellidos.Text;
                    DT = departamento.CargarDepartamento(true);
                    foreach (DataRow depar in DT.Rows)
                    {
                        if (cbxDepartamento.Text == depar["Nombre"].ToString())
                        {
                            persona.Departamento = depar["Codigo"].ToString();
                        }
                    }

                    DT = municipio.CargarMunicipio(true);
                    foreach (DataRow muni in DT.Rows)
                    {
                        if (cbxMunicipio.Text == muni["Nombre"].ToString())
                        {
                            persona.Municipio = muni["Codigo"].ToString();
                        }
                    }

                    persona.BarrioVereda = txtBarrioVereda.Text;
                    persona.Direccion = txtDireccion.Text;
                    persona.Telefono = txtTelefonoFijo.Text;
                    persona.Email = txtEmail.Text;
                    persona.Celular = txtCelular.Text;

                    ok = persona.Modificar();

                    if (ok == true)
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Persona modificada correctamente";
                        mENSAJECORRECTO.ShowDialog();
                        Limpiar();
                        this.Close();
                    }
                    else
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "No fue posible modificar persona";
                        mENSAJE_ERROR.ShowDialog();
                    }
                }
                AgregarPersona();
            }
        }

        private void txtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtTipoIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtNombres_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtApellidos_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtBarrioVereda_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtTelefonoFijo_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtCelular_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
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
