using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class LOGIN : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        int Validado = 0;
        DataTable DT;
        CONTROLLER.Login login = new CONTROLLER.Login();
        INICIO iNICIO = new INICIO();
        MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();

        public LOGIN()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.ForeColor = Color.Silver;
                txtContrasena.Text = "CONTRASEÑA";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            if (txtUsuario.Text == "" || txtUsuario.Text == "USUARIO")
            {
                errorProvider1.SetError(txtUsuario,"Ingrese usuario");
                Validado++;
            }

            if (txtContrasena.Text == "" || txtContrasena.Text == "CONTRASEÑA")
            {
                errorProvider1.SetError(txtContrasena, "Ingrese Contraseña");
                Validado++;
            }
        }

        private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                login.Usuario = txtUsuario.Text;
                login.Contrasena = txtContrasena.Text;
                DT = login.VerificarUsuario();
                if (DT.Rows.Count > 0)
                {
                    DataRow rows;
                    rows = DT.Rows[0];

                    if (rows[0].ToString() != "0")
                    {
                        iNICIO.Persona = rows[0].ToString();
                        iNICIO.Show();
                        Limpiar();
                        this.Hide();                        
                    }
                }
                else
                {
                    mENSAJE_ERROR.lblMensaje.Text = "Usuario o contraseña incorrecto";
                    mENSAJE_ERROR.ShowDialog();
                }
            }
        }

        private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
        }

        private void txtContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
        }
    }
}
