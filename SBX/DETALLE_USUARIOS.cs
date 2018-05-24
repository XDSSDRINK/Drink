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
    public partial class DETALLE_USUARIOS : Form
    {

        //Delegado ActualizarUsuario
        public delegate void ActualizarUsuario();
        public event ActualizarUsuario ActualizarUsuarios;

        AYUDA aYUDA = new AYUDA();
        CONTROLLER.Persona persona = new CONTROLLER.Persona();
        CONTROLLER.Rol rol = new CONTROLLER.Rol();
        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();
        MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();
        MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
        CONTROLLER.General general = new CONTROLLER.General();

        bool OK = true;
        DataTable DT;
        int Validado = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public int CodigoUsuario { get; set; }
        public string Estado { get; set; }
        public string Rol { get; set; }
        public bool Nuevo { get; set; }

        //// Create a new form.
        Form mdiChildForm = new Form();

        public DETALLE_USUARIOS()
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

        private void DETALLE_USUARIOS_Load(object sender, EventArgs e)
        {
            CargarRol();
            cbxEstado.Text = "Activo";
            CargarcbxUsuarios();
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

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            aYUDA.Modulo = "Persona";
            aYUDA.EnviaPersonas += new AYUDA.EnviaPersona(CargarPersona);
            aYUDA.ShowDialog();
        }

        private void CargarPersona(string Persona)
        {
            if (Persona != "")
            {
                txtPersona.Text = Persona;
            }

            if (txtPersona.Text.Trim() != "")
            {
                DT = persona.BuscarUnico(Persona);
                if (DT.Rows.Count > 0)
                {
                    DataRow per = DT.Rows[0];
                    lblNombrePersona.Text = per["NombreApellido"].ToString();
                }
                else
                {
                    lblNombrePersona.Text = "";
                }        
            }
            else
            {
                lblNombrePersona.Text = "";
            }

            ValidarPersona(txtPersona.Text);
        }

        private void CargarRol()
        {
           DT = rol.Cargar(true);
            cbxRol.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow Roles in DT.Rows)
                {
                    cbxRol.Items.Add(Roles["Nombre"]);
                }
                cbxRol.SelectedIndex = 0;
            }
        }

        private void ValidarPersona(string Persona)
        {
            if (txtPersona.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPersona, "Ingrese persona");
                lblNombrePersona.Text = "";
            }
            else
            {
                errorProvider1.Clear();
                if (general.IsNumericDouble(txtPersona.Text) == true)
                {
                    DT = persona.BuscarUnico(txtPersona.Text);
                    if (DT.Rows.Count > 0)
                    {
                        DataRow rows = DT.Rows[0];

                        lblNombrePersona.Text = rows["NombreApellido"].ToString();
                    }
                    else
                    {
                        errorProvider1.SetError(txtPersona, "Persona no existe");
                        lblNombrePersona.Text = "";
                    }
                }
                else
                {
                    errorProvider1.SetError(txtPersona, "Ingrese valores numericos");
                    lblNombrePersona.Text = "";
                }
            }
        }

        private void txtPersona_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarPersona(txtPersona.Text);
        }

        private void Limpiar()
        {
            errorProvider1.Clear();
            txtPersona.Text = "";
            txtPersona.Enabled = true;
            btnBuscarPersona.Enabled = true;
            lblNombrePersona.Text = "-------------";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            cbxEstado.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void Validaciones()
        {
            Validado = 0;

            if (txtPersona.Text.Trim() == "")
            {
                errorProvider1.SetError(txtPersona, "Ingrese persona");
                Validado++;
            }
            else
            {
                DT = persona.BuscarUnico(txtPersona.Text);
                if (DT.Rows.Count <= 0)
                {
                    errorProvider1.SetError(txtPersona,"Persona no existe");
                    Validado++;
                }   
            }

            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "Ingrese Usuario");
                Validado++;
            }
            else
            {
                if (Nuevo == true)
                {
                    DT = usuario.Cargar(true);
                    if (DT.Rows.Count > 0)
                    {
                        foreach (DataRow rows in DT.Rows)
                        {
                            if (rows["Usuario"].ToString() == txtUsuario.Text)
                            {
                                errorProvider1.SetError(txtUsuario, "Usuario no disponible");
                                Validado++;
                            }
                        }
                    }
                }
                else
                {
                    DT = usuario.Cargar(true);
                    if (DT.Rows.Count > 0)
                    {
                        foreach (DataRow rows in DT.Rows)
                        {
                            if (rows["CodigoPersona"].ToString() == txtPersona.Text && rows["Usuario"].ToString() != txtUsuario.Text)
                            {
                                if (rows["Usuario"].ToString() == txtUsuario.Text)
                                {

                                    errorProvider1.SetError(txtUsuario, "Usuario no disponible");
                                    Validado++;
                                }
                            }
                        }
                    }
                }      
            }

            if (txtContrasena.Text == "")
            {
                errorProvider1.SetError(txtContrasena,"Ingrese contraseña");
                Validado++;
            }

            if (cbxRol.Text == "")
            {
                errorProvider1.SetError(cbxRol, "Ingrese Rol");
                Validado++;
            }
        }

        private void Guardar()
        {
            Validaciones();
            if (Validado == 0)
            {
                if (Nuevo == true)
                {
                    usuario.Persona = Convert.ToInt32(txtPersona.Text);
                    usuario.usu = txtUsuario.Text;
                    usuario.Contrasena = txtContrasena.Text;
                    usuario.Estado = cbxEstado.Text;
                    usuario.NombreRol = cbxRol.Text;

                    OK = usuario.Registrar();
                    if (OK == true)
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Usuario registrado correctamente";
                        mENSAJECORRECTO.ShowDialog();
                        Limpiar();
                    }
                    else
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "Error al intentar registrar Usuario ";
                        mENSAJE_ERROR.ShowDialog();
                    }
                }
                else
                {
                    usuario.Codigo = CodigoUsuario;
                    usuario.Persona = Convert.ToInt32(txtPersona.Text);
                    usuario.usu = txtUsuario.Text;
                    usuario.Contrasena = txtContrasena.Text;
                    usuario.Estado = cbxEstado.Text;
                    usuario.NombreRol = cbxRol.Text;

                    OK = usuario.Actualizar();
                    if (OK == true)
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Usuario Modificado correctamente";
                        mENSAJECORRECTO.ShowDialog();
                        Limpiar();
                        this.Close();
                    }
                    else
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "Error al intentar modificar Usuario ";
                        mENSAJE_ERROR.ShowDialog();
                    }
                }                            
            }

            ActualizarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void CargarcbxUsuarios()
        {
            if (Estado != "" && Rol != "")
            {
                cbxEstado.Text = Estado;
                cbxRol.Text = Rol;
            }
        }
    }
}
