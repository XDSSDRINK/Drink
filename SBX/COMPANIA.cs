using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class COMPANIA : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPANIA));
        CONTROLLER.General gnl = new CONTROLLER.General();
        CONTROLLER.Departamento dpt = new CONTROLLER.Departamento();
        CONTROLLER.Municipio mnp = new CONTROLLER.Municipio();
        CONTROLLER.Regimen rg = new CONTROLLER.Regimen();
        CONTROLLER.EstadoGlobal estg = new CONTROLLER.EstadoGlobal();
        CONTROLLER.Banco banco = new CONTROLLER.Banco();
        CONTROLLER.TipoCuenta tpc = new CONTROLLER.TipoCuenta();
        CONTROLLER.Compania cmp = new CONTROLLER.Compania();
        CONTROLLER.Usuario usu = new CONTROLLER.Usuario();
        MENSAJECORRECTO msgC = new MENSAJECORRECTO();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();

        int Validado = 0;
        DataTable DT;
        bool ok = true;
        public string  Usuario { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public COMPANIA()
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

        private void COMPANIA_Load(object sender, EventArgs e)
        {
            CargarDepartamento();
            CargarMunicipio();
            CargarRegimen();
            CargarEstado();
            CargarBanco();
            CargarTipoCuenta();
            CargarCompania();
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

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void CargarCompania()
        {
            DT = cmp.CargarCompania();
            foreach (DataRow rows in DT.Rows)
            {
                txtDNI.Text = rows["DNI"].ToString();
                txtDigitoV.Text = rows["DigVerificacion"].ToString();
                txtRazonSocial.Text = rows["RazonSocial"].ToString();
                txtNombreComercial.Text = rows["NombreComercial"].ToString();
                cbxDepartamento.Text = rows["Departamento"].ToString();
                cbxMunicipio.Text = rows["Municipio"].ToString();
                txtBarrioVereda.Text = rows["BarrioVereda"].ToString();
                txtDireccion.Text = rows["Direccion"].ToString();
                txtTelefono.Text = rows["Telefono"].ToString();
                txtExt.Text = rows["Extension"].ToString();
                cbxRegimen.Text = rows["Regimen"].ToString();
                cbxEstado.Text = rows["Estado"].ToString();
                txtLicencia.Text = rows["numLic"].ToString(); 
                txtFax.Text = rows["Fax"].ToString();
                txtCelular.Text = rows["Celular"].ToString();
                txtEmail.Text = rows["Email"].ToString();
                txtSitioWeb.Text = rows["SitioWeb"].ToString();
                cbxBanco.Text = rows["Banco"].ToString();
                cbxTipoCuenta.Text = rows["TipoCuenta"].ToString();
                txtCuenta.Text = rows["NumCuenta"].ToString();
                byte[] imagen = (byte[])rows["Logo"];
                pbxFoto.Image = byteArrayToImage(imagen);
            }
        }

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            if (txtDNI.Text == "")
            {
                errorProvider1.SetError(txtDNI, "Ingrese DNI");
                Validado++;
            }

            if (txtRazonSocial.Text == "")
            {
                errorProvider1.SetError(txtRazonSocial, "Ingrese Razon Social");
                Validado++;
            }

            if (txtNombreComercial.Text == "")
            {
                errorProvider1.SetError(txtNombreComercial, "Ingrese nombre comercial");
                Validado++;
            }

            if (txtBarrioVereda.Text == "")
            {
                errorProvider1.SetError(txtBarrioVereda, "Ingrese Barrio vereda");
                Validado++;
            }

            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtDireccion, "Ingrese direccion");
                Validado++;
            }

            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "Ingrese telefono");
                Validado++;
            }

        }

        private void Limpiar()
        {
            errorProvider1.Clear();
            txtDNI.Text = "";
            txtDigitoV.Text = "";
            txtRazonSocial.Text = "";
            txtNombreComercial.Text = "";
            txtBarrioVereda.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtExt.Text = "";
            txtLicencia.Text = "";
            txtFax.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtSitioWeb.Text = "";
            txtCuenta.Text = "";
            pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void Salir()
        {
            Limpiar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void txtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDNI.Text != "")
            {
                txtDigitoV.Text = CalcularDigitoVerificacion(txtDNI.Text);
            }
            else
            {
                txtDigitoV.Text = "";
            }
        }

        public string CalcularDigitoVerificacion(string Nit)
        {
            string Temp;
            int Contador;
            int Residuo;
            int Acumulador;
            int[] Vector = new int[15];

            Vector[0] = 3;
            Vector[1] = 7;
            Vector[2] = 13;
            Vector[3] = 17;
            Vector[4] = 19;
            Vector[5] = 23;
            Vector[6] = 29;
            Vector[7] = 37;
            Vector[8] = 41;
            Vector[9] = 43;
            Vector[10] = 47;
            Vector[11] = 53;
            Vector[12] = 59;
            Vector[13] = 67;
            Vector[14] = 71;

            Acumulador = 0;

            Residuo = 0;

            for (Contador = 0; Contador < Nit.Length; Contador++)
            {
                Temp = Nit[(Nit.Length - 1) - Contador].ToString();
                Acumulador = Acumulador + (Convert.ToInt32(Temp) * Vector[Contador]);
            }

            Residuo = Acumulador % 11;

            if (Residuo > 1)
                return Convert.ToString(11 - Residuo);

            return Residuo.ToString();
        }

        private void CargarDepartamento()
        {
            cbxDepartamento.Items.Clear();
            DT = dpt.CargarDepartamento(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxDepartamento.Items.Add(rows["Nombre"].ToString());
                }

                cbxDepartamento.SelectedIndex = 0;
            }     
        }

        private void CargarMunicipio()
        {
            cbxMunicipio.Items.Clear();
            if (cbxDepartamento.Items.Count > 0)
            {
                mnp.Departamento = cbxDepartamento.Text;
                DT = mnp.CargarMunicipio(true);
                if (DT.Rows.Count > 0)
                {
                    foreach (DataRow rows in DT.Rows)
                    {
                        cbxMunicipio.Items.Add(rows["Nombre"].ToString());
                    }

                    cbxMunicipio.SelectedIndex = 0;
                }
            }
        }

        private void CargarRegimen()
        {
            cbxRegimen.Items.Clear();
            DT = rg.CargarRegimen();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxRegimen.Items.Add(rows["Nombre"].ToString());
                }

                cbxRegimen.SelectedIndex = 0;
            }
        }

        private void CargarEstado()
        {
            cbxEstado.Items.Clear();
            DT = estg.CargaEstado();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxEstado.Items.Add(rows["Nombre"].ToString());
                }

                cbxEstado.SelectedIndex = 0;
            }
        }

        private void CargarBanco()
        {
            cbxBanco.Items.Clear();
            DT = banco.CargarBanco(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxBanco.Items.Add(rows["Nombre"].ToString());
                }

                cbxBanco.SelectedIndex = 0;
            }
        }

        private void CargarTipoCuenta()
        {
            cbxTipoCuenta.Items.Clear();
            DT = tpc.CargarTipoCuenta(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxTipoCuenta.Items.Add(rows["Nombre"].ToString());
                }

                cbxTipoCuenta.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                cmp.DNI = txtDNI.Text;
                cmp.DigVerificacion = Convert.ToInt32(txtDigitoV.Text);
                cmp.RazonSocial = txtRazonSocial.Text;
                cmp.NombreComercial = txtNombreComercial.Text;
                //Departamento
                dpt.Nombre_ = cbxDepartamento.Text;
                DT = dpt.CargarDepartamento(false);
                foreach (DataRow rows in DT.Rows)
                {
                    cmp.Departamento = rows["Codigo"].ToString();
                }
                //Municipio
                mnp.Nombre_ = cbxMunicipio.Text;
                mnp.Departamento = cbxDepartamento.Text;
                DT = mnp.CargarMunicipio(false);
                foreach (DataRow rows in DT.Rows)
                {
                    cmp.Municipio = rows["Codigo"].ToString();
                }
                cmp.BarrioVereda = txtBarrioVereda.Text;
                cmp.Direccion = txtDireccion.Text;
                cmp.Telefono = txtTelefono.Text;
                cmp.Extension = txtExt.Text;
                //Regimen
                DT = rg.CargarRegimen();
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Nombre"].ToString() == cbxRegimen.Text)
                    {
                        cmp.Regimen = Convert.ToInt32(rows["ID"]);
                    }
                }
                //Estado
                DT = estg.CargaEstado();
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Nombre"].ToString() == cbxEstado.Text)
                    {
                        cmp.Estado = Convert.ToInt32(rows["ID"]);
                    }
                }
                cmp.numLic = txtLicencia.Text;
                cmp.Fax = txtFax.Text;
                cmp.Celular = txtCelular.Text;
                cmp.Email = txtEmail.Text;
                cmp.SitioWeb = txtSitioWeb.Text;
                //Banco
                DT = banco.CargarBanco(true);
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Nombre"].ToString() == cbxBanco.Text)
                    {
                        cmp.Banco = Convert.ToInt32(rows["ID"]);
                    }
                }
                //Tipo cuenta
                DT = tpc.CargarTipoCuenta(true);
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Nombre"].ToString() == cbxTipoCuenta.Text)
                    {
                        cmp.TipoCuenta = Convert.ToInt32(rows["ID"]);
                    }
                }
                cmp.NumeroCuenta = txtCuenta.Text;
                cmp.Logo = pbxFoto.Image;

                //usuario
                DT = usu.Cargar(true);
                foreach (DataRow rows in DT.Rows)
                {
                    Usuario = rows["CodigoUsuario"].ToString();
                }
                cmp.UsuarioCrea = Convert.ToInt32(Usuario);

                //Limpia la tabla compañia
                 ok = cmp.Eliminar();
                if (ok)
                {
                    ok = cmp.Registrar();
                    if (ok)
                    {
                        msgC.lblMensaje.Text = "Compañia registrada correctamente";
                        msgC.ShowDialog();
                    }
                    else
                    {
                        msgError.lblMensaje.Text = "Error al intentar registrar compañia";
                        msgError.ShowDialog();
                    }
                }
                else
                {
                    msgError.lblMensaje.Text = "Error al intentar registrar compañia";
                    msgError.ShowDialog();
                }
            }
        }

        private void CargarFoto()
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(dialog.FileName);
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

        private void btnFoto_Click(object sender, EventArgs e)
        {
            CargarFoto();
        }
    }
}
