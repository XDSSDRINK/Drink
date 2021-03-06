﻿using System;
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
    public partial class DETALLE_CLIENTES : Form
    {
        //Delegado 
        public delegate void AgregaClientes();
        public event AgregaClientes AgregarCliente;

        CONTROLLER.Cliente cliente = new CONTROLLER.Cliente();
        CONTROLLER.Departamento departamento = new CONTROLLER.Departamento();
        CONTROLLER.Municipio municipio = new CONTROLLER.Municipio();
        CONTROLLER.EstadoCliente estadoCliente = new CONTROLLER.EstadoCliente();
        CONTROLLER.Banco banco = new CONTROLLER.Banco();
        CONTROLLER.TipoCuenta tipoCuenta = new CONTROLLER.TipoCuenta();
        CONTROLLER.General general = new CONTROLLER.General();

        int Validado = 0;
        DataTable DT;
        DataRow row;
        bool OK;
        int CodigoUsuario;

        public string TipoProveedor { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string IVA { get; set; }
        public string Banco { get; set; }
        public string TipoCuenta { get; set; }
        public bool Agregar { get; set; }
        public string NombreUsuario { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();
        public DETALLE_CLIENTES()
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

        private void DETALLE_CLIENTES_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            if (Agregar == false)
            {
                errorProvider.Clear();

                txtDNI.Enabled = false;
                cbxTipoProveedor.Text = TipoProveedor;
                cbxTipoDNI.Text = TipoIdentificacion;
                cbxDepartamento.Text = Departamento;
                cbxMunicipio.Text = Municipio;
                cbxEstado.Text = Estado;
                cbxIVA.Text = IVA;
                cbxBanco.Text = Banco;
                cbxTipoCuenta.Text = TipoCuenta;

            }
            else
            {
                errorProvider.Clear();
                txtDNI.Enabled = true;
            }

            cbxTipoProveedor.SelectedIndex = 0;
            cbxTipoDNI.SelectedIndex = 0;
            cbxIVA.SelectedIndex = 0;
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

        private void BuscaDNI()
        {
            DT = cliente.Cargar("DNI", txtDNI.Text, "Unico");
            if (DT.Rows.Count > 0)
            {
                row = DT.Rows[0];
                if (txtDNI.Text == row["DNI"].ToString())
                {
                    errorProvider.SetError(txtDNI, "DNI ya existe");
                    Validado--;
                }
            }
        }

        private void ValidacionCampos()
        {
            Validado = 0;

            if (txtDNI.Text == "")
            {
                errorProvider.SetError(txtDNI, "Ingrese DNI");
                Validado--;
            }
            else
            {
                if (Agregar == true)
                {
                    BuscaDNI();
                }
            }
            if (cbxTipoProveedor.Text == "")
            {
                errorProvider.SetError(cbxTipoProveedor, "Seleccione tipo proveedor");
                Validado--;
            }
            if (cbxTipoDNI.Text == "")
            {
                errorProvider.SetError(cbxTipoDNI, "Seleccione tipo DNI");
                Validado--;
            }
            if (txtRazonSocial.Text == "")
            {
                errorProvider.SetError(txtRazonSocial, "Ingrese Razon social");
                Validado--;
            }
            if (txtNombreComercial.Text == "")
            {
                errorProvider.SetError(txtNombreComercial, "Ingrese nombre comercial");
                Validado--;
            }
            if (cbxDepartamento.Text == "")
            {
                errorProvider.SetError(cbxDepartamento, "Seleccione departamento");
                Validado--;
            }
            if (cbxMunicipio.Text == "")
            {
                errorProvider.SetError(cbxMunicipio, "Seleccione municipio");
                Validado--;
            }
            if (txtBarrioVereda.Text == "")
            {
                errorProvider.SetError(txtBarrioVereda, "Ingrese Barrio/vereda");
                Validado--;
            }
            if (txtDireccion.Text == "")
            {
                errorProvider.SetError(txtDireccion, "Ingrese direccion");
                Validado--;
            }
            if (cbxEstado.Text == "")
            {
                errorProvider.SetError(cbxEstado, "Seleccione estado");
                Validado--;
            }
            if (txtCelular1.Text == "")
            {
                errorProvider.SetError(txtCelular1, "Ingrese celular 1");
                Validado--;
            }
            if (cbxIVA.Text == "")
            {
                errorProvider.SetError(cbxIVA, "Seleccione IVA");
                Validado--;
            }
            if (cbxBanco.Text == "")
            {
                errorProvider.SetError(cbxBanco, "Seleccione banco");
                Validado--;
            }
            if (cbxTipoCuenta.Text == "")
            {
                errorProvider.SetError(cbxTipoCuenta, "Seleccione tipo cuenta");
                Validado--;
            }
        }

        private void RellenaCampos()
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "0";
            }
            if (txtExt.Text == "")
            {
                txtExt.Text = "0";
            }
            if (txtFax.Text == "")
            {
                txtFax.Text = "0";
            }
            if (txtCelular2.Text == "")
            {
                txtCelular2.Text = "0";
            }
            if (txtCuenta.Text == "")
            {
                txtCuenta.Text = "0";
            }

            if (cbxBanco.Text == "Ninguno")
            {
                txtCuenta.Text = "0";
            }
        }

        private void AsignaCliente()
        {
            cliente.DNI = long.Parse(txtDNI.Text);
            cliente.DgVerificacion = Convert.ToInt32(txtDigitoV.Text);
            cliente.TipoPersona = cbxTipoProveedor.Text;
            cliente.TipoIdentificacion = cbxTipoDNI.Text;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.NombreComercial = txtNombreComercial.Text;
            //consulta codigo departamento 
            departamento.Nombre_ = cbxDepartamento.Text;
            DT = departamento.CargarDepartamento(false);
            row = DT.Rows[0];
            cliente.Departamento = row["Codigo"].ToString();
            //consulta codigo municipio
            municipio.Nombre_ = cbxMunicipio.Text;
            DT = municipio.CargarMunicipio(false);
            row = DT.Rows[0];
            cliente.Municipio = row["Codigo"].ToString();
            cliente.BarrioVereda = txtBarrioVereda.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Extension = txtExt.Text;
            //consulta codigo estado
            estadoCliente.Nombre_ = cbxEstado.Text;
            DT = estadoCliente.CargaEstadoCliente(false);
            row = DT.Rows[0];
            cliente.Estado = Convert.ToInt32(row["Codigo"]);
            cliente.Fax = txtFax.Text;
            cliente.Celular1 = txtCelular1.Text;
            cliente.Celular2 = txtCelular2.Text;
            cliente.Email = txtEmail.Text;
            cliente.SitioWeb = txtSitioWeb.Text;
            cliente.IVA = cbxIVA.Text;
            //consulta codigo banco
            banco.Nombre_ = cbxBanco.Text;
            DT = banco.CargarBanco(false);
            row = DT.Rows[0];
            cliente.Banco = Convert.ToInt32(row["ID"]);
            //consulta codigo tipo cuenta
            tipoCuenta.Nombre_ = cbxTipoCuenta.Text;
            DT = tipoCuenta.CargarTipoCuenta(false);
            row = DT.Rows[0];
            cliente.TipoCuenta = Convert.ToInt32(row["ID"]);
            cliente.NumeroCuenta = txtCuenta.Text;
        }

        private void Limpiar()
        {
            if (Agregar == true)
            {
                txtDNI.Text = "";
                txtDigitoV.Text = "";
            }
            errorProvider.Clear();

            txtRazonSocial.Text = "";
            txtNombreComercial.Text = "";
            txtBarrioVereda.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtExt.Text = "";
            txtFax.Text = "";
            txtCelular1.Text = "";
            txtCelular2.Text = "";
            txtEmail.Text = "";
            txtSitioWeb.Text = "";
            txtCuenta.Text = "";
        }

        private void Guardar()
        {
            ValidacionCampos();
            if (Validado == 0)
            {
                RellenaCampos();
                AsignaCliente();

                CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();
                DT = usuario.Cargar(true);
                if (DT.Rows.Count > 0)
                {
                    foreach (DataRow rows in DT.Rows)
                    {
                        if (rows["Usuario"].ToString() == NombreUsuario)
                        {
                            CodigoUsuario = Convert.ToInt32(rows["CodigoUsuario"]);
                        }
                    }
                }

                cliente.CodigoUsuario = this.CodigoUsuario;

                if (Agregar == true)
                {
                    OK = cliente.Registrar();
                }
                else
                {
                    OK = cliente.Modificar();
                }

                if (OK == true)
                {
                    MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();

                    if (Agregar == true)
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Cliente guardado correctamente";
                        Limpiar();
                    }
                    else
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Cliente modificado correctamente";
                        Limpiar();
                    }
                    mENSAJECORRECTO.ShowDialog();
                    this.Close();
                }
                else
                {
                    MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
                    if (Agregar == true)
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "Error al intentar guardar Cliente";
                    }
                    else
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "Error al intentar modificar Cliente";
                    }

                    mENSAJE_ERROR.ShowDialog();
                }
            }

            AgregarCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }   

        private void CargarComboBox()
        {
            CargarEstado();
            CargarDepartamento();
            CargarMunicipio();
            CargarBanco();
            CargarTipoCuenta();
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

        private void CargarEstado()
        {
            DT = estadoCliente.CargaEstadoCliente(true);
            cbxEstado.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxEstado.Items.Add(row["Estado"]);
                }
                cbxEstado.SelectedIndex = 0;
            }
        }
        private void CargarDepartamento()
        {
            DT = departamento.CargarDepartamento(true);
            cbxDepartamento.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxDepartamento.Items.Add(row["Nombre"]);
                }
                cbxDepartamento.SelectedIndex = 0;
            }
        }
        private void CargarMunicipio()
        {
            municipio.Departamento = cbxDepartamento.Text;
            DT = municipio.CargarMunicipio(true);
            cbxMunicipio.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxMunicipio.Items.Add(row["Nombre"]);
                }
                cbxMunicipio.SelectedIndex = 0;
            }
        }
        private void CargarBanco()
        {
            DT = banco.CargarBanco(true);
            cbxBanco.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxBanco.Items.Add(row["Nombre"]);
                }
                cbxBanco.SelectedIndex = 0;
            }
        }
        private void CargarTipoCuenta()
        {
            DT = tipoCuenta.CargarTipoCuenta(true);
            cbxTipoCuenta.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxTipoCuenta.Items.Add(row["Nombre"]);
                }
                cbxTipoCuenta.SelectedIndex = 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Agregar = true;
            Limpiar();
            this.Close();
        }

        private void txtNombreComercial_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDNI.Text != "")
            {
                CalcularDigitoVerificacion(txtDNI.Text);
                txtDigitoV.Text = CalcularDigitoVerificacion(txtDNI.Text);
            }
            else
            {
                txtDigitoV.Text = "";
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtCelular1_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtCelular2_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Agregar = true;
            Limpiar();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
