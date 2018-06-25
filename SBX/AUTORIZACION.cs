using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class AUTORIZACION : Form
    {
        DataTable DT;
        public bool Atorizacion { get; set; }
        CONTROLLER.Ventas venta = new CONTROLLER.Ventas();
        MENSAJE_ERROR mENSAJEErro = new MENSAJE_ERROR();
        CONTROLLER.Login lg = new CONTROLLER.Login();
        int Validado = 0;
        public AUTORIZACION()
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

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            if (txtUsuario.Text == "" || txtUsuario.Text == "USUARIO")
            {
                errorProvider1.SetError(txtUsuario, "Ingrese usuario");
                Validado++;
            }

            if (txtContrasena.Text == "" || txtContrasena.Text == "CONTRASEÑA")
            {
                errorProvider1.SetError(txtContrasena, "Ingrese Contraseña");
                Validado++;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Atorizacion = false;
            Validacion();
            if (Validado == 0)
            {
                //Verificacion de credenciales
                lg.Usuario = txtUsuario.Text;
                lg.Contrasena = txtContrasena.Text;
                DT = lg.VerificarUsuario();
                if (DT.Rows.Count > 0)
                {
                    venta.buscar = txtUsuario.Text;
                    DT = venta.AUTORIZACION();
                    if (DT.Rows.Count > 0)
                    {
                        Atorizacion = true;
                        Limpiar();
                        this.Close();
                    }
                    else
                    {
                        mENSAJEErro.lblMensaje.Text = "Usuario NO Autorizado";
                        mENSAJEErro.ShowDialog();
                    }
                }
                else
                {
                    mENSAJEErro.lblMensaje.Text = "Usuario o contraseña incorrecto";
                    mENSAJEErro.ShowDialog();
                } 
            }
        }

        private void Limpiar()
        {
            errorProvider1.Clear();
           
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;

                txtContrasena.UseSystemPasswordChar = false;
                txtContrasena.ForeColor = Color.Silver;
                txtContrasena.Text = "CONTRASEÑA"; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Atorizacion = false;
            Limpiar();
            this.Close();
        }
    }
}
