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
    public partial class APERTURA_CAJ : Form
    {
        CONTROLLER.General gnl = new CONTROLLER.General();
        CONTROLLER.Caja cj = new CONTROLLER.Caja();
        CONTROLLER.Usuario usu = new CONTROLLER.Usuario();
        MENSAJECORRECTO msgc = new MENSAJECORRECTO();
        MENSAJE_ERROR msge = new MENSAJE_ERROR();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public string usuario { get; set; }

        //Billetes
        double B100 = 0;
        double B50 = 0;
        double B20 = 0;
        double B10 = 0;
        double B5 = 0;
        double B2 = 0;
        double B1 = 0;
        double TotalB = 0;
        //Monedas
        double M1000 = 0;
        double M500 = 0;
        double M200 = 0;
        double M100 = 0;
        double M50 = 0;
        double M20 = 0;
        double M10 = 0;
        double TotalM = 0;
        //Base
        double Base = 0;

        int Validado = 0;
        bool OK = true;
        DataTable DT;
        int CodigoUsuario = 0;
        double Billete = 0;
        DataRow rows;

        //// Create a new form.
        Form mdiChildForm = new Form();

        public APERTURA_CAJ()
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

        private void APERTURA_CAJ_Load(object sender, EventArgs e)
        {
            DT = usu.Cargar(true);
            foreach (DataRow usuar in DT.Rows)
            {
                if (usuar["Usuario"].ToString() == usuario)
                {
                    CodigoUsuario = Convert.ToInt32(usuar["CodigoUsuario"]);
                }
            }

            CargarDatosCaja();
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

        private void Limpiar()
        {
            //BILLETES
            txtCantidad100000.Text = "0";
            txtCantidad50000.Text = "0";
            txtCantidad20000.Text = "0";
            txtcantidad10000.Text = "0";
            txtCantidad5000.Text = "0";
            txtcantidad2000.Text = "0";
            txtcantidad1000.Text = "0";

            txtValor100000.Text = "0";
            txtValor50000.Text = "0";
            txtValor20000.Text = "0";
            txtValor10000.Text = "0";
            txtValor5000.Text = "0";
            txtValor2000.Text = "0";
            txtValor1000.Text = "0";

            txtTotalBilletes.Text = "0";

            //MONEDAS
            txtCantidadM1000.Text = "0";
            txtCantidadM500.Text = "0";
            txtCantidadM200.Text = "0";
            txtCantidadM100.Text = "0";
            txtCantidadM50.Text = "0";
            txtCantidadM20.Text = "0";
            txtCantidadM10.Text = "0";

            txtValorM1000.Text = "0";
            txtValorM500.Text = "0";
            txtValorM200.Text = "0";
            txtValorM100.Text = "0";
            txtValorM50.Text = "0";
            txtValorM20.Text = "0";
            txtValorM10.Text = "0";

            txtTotalMonedas.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validacion();
            Billete = 0;
            if (Validado == 0)
            {
                CalcularBase();

                //Verifica estado caja
                DT = cj.CargarCaja();
                if (DT.Rows.Count > 0)
                {
                    foreach (DataRow regis in DT.Rows)
                    {
                        Billete = Convert.ToDouble(regis["Billete"]);
                        switch (Billete.ToString())
                        {
                            case "100000":
                                if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                {
                                    cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                    cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                    cj.Billete = 100000;
                                    OK = cj.Eliminar();
                                    if (OK)
                                    {
                                        //Billetes 100.000 y Monedas 1.000
                                        cj.Billete = 100000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad100000.Text);
                                        cj.Moneda = 1000;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM1000.Text);
                                        cj.NumeroBaucher = 0;
                                        cj.ValorBaucher = 0;
                                        cj.TipoOperacion = "Apertura";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                }
                                else if(regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                {
                                    cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                    cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                    cj.Billete = 100000;
                                    //Billetes 100.000 y Monedas 1.000
                                    cj.Billete = 100000;
                                    cj.CantidadBilletes = Convert.ToInt32(txtCantidad100000.Text);
                                    cj.Moneda = 1000;
                                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM1000.Text);
                                    cj.NumeroBaucher = 0;
                                    cj.ValorBaucher = 0;
                                    cj.TipoOperacion = "Apertura";
                                    cj.Usuario = CodigoUsuario;
                                    cj.FechaRegistro = DateTime.Now;
                                    OK = cj.Registrar();
                                }
                                break;
                            case "50000":
                                if (OK)
                                {
                                    if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 50000;
                                        OK = cj.Eliminar();
                                        if (OK)
                                        {
                                            //Billetes 50.000 y Monedas 500      
                                            cj.Billete = 50000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtCantidad50000.Text);
                                            cj.Moneda = 500;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM500.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                    }
                                    else if (regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 50000;
                                            //Billetes 50.000 y Monedas 500      
                                            cj.Billete = 50000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtCantidad50000.Text);
                                            cj.Moneda = 500;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM500.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                    }
                                }
                                break;
                            case "20000":
                                if (OK)
                                {
                                    if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 20000;
                                        OK = cj.Eliminar();
                                        if (OK)
                                        {
                                            //Billetes 20.000 y Monedas 200      
                                            cj.Billete = 20000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtCantidad20000.Text);
                                            cj.Moneda = 200;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM200.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                    }
                                    else if (regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 20000;
                                       
                                            //Billetes 20.000 y Monedas 200      
                                            cj.Billete = 20000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtCantidad20000.Text);
                                            cj.Moneda = 200;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM200.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                }
                                break;
                            case "10000":
                                if (OK)
                                {
                                    if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 10000;
                                        OK = cj.Eliminar();
                                        if (OK)
                                        {
                                            //Billetes 10.000 y Monedas 100      
                                            cj.Billete = 10000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtcantidad10000.Text);
                                            cj.Moneda = 100;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM100.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                    }
                                    else if (regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 10000;

                                            //Billetes 10.000 y Monedas 100      
                                            cj.Billete = 10000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtcantidad10000.Text);
                                            cj.Moneda = 100;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM100.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                }
                                break;
                            case "5000":
                                if (OK)
                                {
                                    if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 5000;
                                        OK = cj.Eliminar();
                                        if (OK)
                                        {
                                            //Billetes 5.000 y Monedas 50      
                                            cj.Billete = 5000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtCantidad5000.Text);
                                            cj.Moneda = 50;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM50.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                    }
                                    else if (regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 5000;
                                       
                                            //Billetes 5.000 y Monedas 50      
                                            cj.Billete = 5000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtCantidad5000.Text);
                                            cj.Moneda = 50;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM50.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                    }
                                }
                                break;
                            case "2000":
                                if (OK)
                                {
                                    if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 2000;
                                        OK = cj.Eliminar();
                                        if (OK)
                                        {
                                            //Billetes 2.000 y Monedas 20      
                                            cj.Billete = 2000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtcantidad2000.Text);
                                            cj.Moneda = 20;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM20.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                    }
                                    else if (regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 2000;
                                     
                                            //Billetes 2.000 y Monedas 20      
                                            cj.Billete = 2000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtcantidad2000.Text);
                                            cj.Moneda = 20;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM20.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                    }
                                }
                                break;
                            case "1000":
                                if (OK)
                                {
                                    if (regis["TipoOperacion"].ToString() == "Apertura" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 1000;
                                        OK = cj.Eliminar();
                                        if (OK)
                                        {
                                            //Billetes 1.000 y Monedas 10      
                                            cj.Billete = 1000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtcantidad1000.Text);
                                            cj.Moneda = 10;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM10.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                        }
                                    }
                                    else if (regis["TipoOperacion"].ToString() == "Cierre" && regis["Usuario"].ToString() == CodigoUsuario.ToString())
                                    {
                                        cj.TipoOperacion = regis["TipoOperacion"].ToString();
                                        cj.FechaRegistro = Convert.ToDateTime(regis["FechaRegistro"]);
                                        cj.Billete = 1000;
                                       
                                            //Billetes 1.000 y Monedas 10      
                                            cj.Billete = 1000;
                                            cj.CantidadBilletes = Convert.ToInt32(txtcantidad1000.Text);
                                            cj.Moneda = 10;
                                            cj.CantidadMonedas = Convert.ToInt32(txtCantidadM10.Text);
                                            cj.NumeroBaucher = 0;
                                            cj.ValorBaucher = 0;
                                            cj.TipoOperacion = "Apertura";
                                            cj.Usuario = CodigoUsuario;
                                            cj.FechaRegistro = DateTime.Now;
                                            OK = cj.Registrar();
                                    }
                                }
                                break;
                        }
                    }
                }
                else
                {
                    //Billetes 100.000 y Monedas 1.000
                    cj.Billete = 100000;
                    cj.CantidadBilletes = Convert.ToInt32(txtCantidad100000.Text);
                    cj.Moneda = 1000;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM1000.Text);
                    cj.NumeroBaucher = 0;
                    cj.ValorBaucher = 0;
                    cj.TipoOperacion = "Apertura";
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    OK = cj.Registrar();

                    //Billetes 50.000 y Monedas 500      
                    if (OK)
                    {
                        cj.Billete = 50000;
                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad50000.Text);
                        cj.Moneda = 500;
                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM500.Text);
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                        cj.TipoOperacion = "Apertura";
                        cj.Usuario = CodigoUsuario;
                        cj.FechaRegistro = DateTime.Now;
                        OK = cj.Registrar();
                    }

                    //Billetes 20.000 y Monedas 200      
                    if (OK)
                    {
                        cj.Billete = 20000;
                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad20000.Text);
                        cj.Moneda = 200;
                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM200.Text);
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                        cj.TipoOperacion = "Apertura";
                        cj.Usuario = CodigoUsuario;
                        cj.FechaRegistro = DateTime.Now;
                        OK = cj.Registrar();
                    }

                    //Billetes 10.000 y Monedas 100      
                    if (OK)
                    {
                        cj.Billete = 10000;
                        cj.CantidadBilletes = Convert.ToInt32(txtcantidad10000.Text);
                        cj.Moneda = 100;
                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM100.Text);
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                        cj.TipoOperacion = "Apertura";
                        cj.Usuario = CodigoUsuario;
                        cj.FechaRegistro = DateTime.Now;
                        OK = cj.Registrar();
                    }

                    //Billetes 5.000 y Monedas 50      
                    if (OK)
                    {
                        cj.Billete = 5000;
                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad5000.Text);
                        cj.Moneda = 50;
                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM50.Text);
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                        cj.TipoOperacion = "Apertura";
                        cj.Usuario = CodigoUsuario;
                        cj.FechaRegistro = DateTime.Now;
                        OK = cj.Registrar();
                    }

                    //Billetes 2.000 y Monedas 20      
                    if (OK)
                    {
                        cj.Billete = 2000;
                        cj.CantidadBilletes = Convert.ToInt32(txtcantidad2000.Text);
                        cj.Moneda = 20;
                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM20.Text);
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                        cj.TipoOperacion = "Apertura";
                        cj.Usuario = CodigoUsuario;
                        cj.FechaRegistro = DateTime.Now;
                        OK = cj.Registrar();
                    }

                    //Billetes 1.000 y Monedas 10      
                    if (OK)
                    {
                        cj.Billete = 1000;
                        cj.CantidadBilletes = Convert.ToInt32(txtcantidad1000.Text);
                        cj.Moneda = 10;
                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM10.Text);
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                        cj.TipoOperacion = "Apertura";
                        cj.Usuario = CodigoUsuario;
                        cj.FechaRegistro = DateTime.Now;
                        OK = cj.Registrar();
                    }
                }

                if (OK)
                {
                    msgc.lblMensaje.Text = "Caja registrada correctamente";
                    msgc.ShowDialog();                  
                    Limpiar();
                    this.Close();
                }
                else
                {
                    msge.lblMensaje.Text = "Error al intentar registrar Caja";
                    msge.ShowDialog();
                }
            }
        }

        private void txtCantidad100000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidad50000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidad20000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtcantidad10000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidad5000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtcantidad2000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtcantidad1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM500_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM200_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM100_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM50_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM20_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
        }

        private void txtCantidadM10_KeyPress(object sender, KeyPressEventArgs e)
        {
            gnl.ValidaNumeros(e);
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

        private void Validacion()
        {
            Validado = 0;
            errorProvider1.Clear();

            //Billetes
            if (txtCantidad100000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad100000,"Ingrese Billetes de 100.000");
                Validado++;
            }
            if (txtCantidad50000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad50000, "Ingrese Billetes de 50.000");
                Validado++;
            }
            if (txtCantidad20000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad20000, "Ingrese Billetes de 20.000");
                Validado++;
            }
            if (txtcantidad10000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtcantidad10000, "Ingrese Billetes de 10.000");
                Validado++;
            }
            if (txtCantidad5000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidad5000, "Ingrese Billetes de 5.000");
                Validado++;
            }
            if (txtcantidad2000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtcantidad2000, "Ingrese Billetes de 2.000");
                Validado++;
            }
            if (txtcantidad1000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtcantidad1000, "Ingrese Billetes de 1.000");
                Validado++;
            }
            //Monedas
            if (txtCantidadM1000.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM1000, "Ingrese Monedas de 1.000");
                Validado++;
            }
            if (txtCantidadM500.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM500, "Ingrese Monedas de 500");
                Validado++;
            }
            if (txtCantidadM200.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM200, "Ingrese Monedas de 200");
                Validado++;
            }
            if (txtCantidadM100.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM100, "Ingrese Monedas de 100");
                Validado++;
            }
            if (txtCantidadM50.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM50, "Ingrese Monedas de 50");
                Validado++;
            }
            if (txtCantidadM20.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM20, "Ingrese Monedas de 20");
                Validado++;
            }
            if (txtCantidadM10.Text.Trim() == "")
            {
                errorProvider1.SetError(txtCantidadM10, "Ingrese Monedas de 10");
                Validado++;
            }
        }

        private void CalcularBase()
        {
            //Calcular Billetes
            B100 = Convert.ToDouble(txtCantidad100000.Text) * 100000;
            txtValor100000.Text = B100.ToString("N");
            B50 = Convert.ToDouble(txtCantidad50000.Text) * 50000;
            txtValor50000.Text = B50.ToString("N");
            B20 = Convert.ToDouble(txtCantidad20000.Text) * 20000;
            txtValor20000.Text = B20.ToString("N");
            B10 = Convert.ToDouble(txtcantidad10000.Text) * 10000;
            txtValor10000.Text = B10.ToString("N");
            B5 = Convert.ToDouble(txtCantidad5000.Text) * 5000;
            txtValor5000.Text = B5.ToString("N");
            B2 = Convert.ToDouble(txtcantidad2000.Text) * 2000;
            txtValor2000.Text = B2.ToString("N");
            B1 = Convert.ToDouble(txtcantidad1000.Text) * 1000;
            txtValor1000.Text = B1.ToString("N");

            TotalB = (B100 + B50 + B20 + B10 + B5 + B2 + B1);
            txtTotalBilletes.Text = TotalB.ToString("N");

            //Calcular Monedas
            M1000 = Convert.ToDouble(txtCantidadM1000.Text) * 1000;
            txtValorM1000.Text = M1000.ToString("N");
            M500 = Convert.ToDouble(txtCantidadM500.Text) * 500;
            txtValorM500.Text = M500.ToString("N");
            M200 = Convert.ToDouble(txtCantidadM200.Text) * 200;
            txtValorM200.Text = M200.ToString("N");
            M100 = Convert.ToDouble(txtCantidadM100.Text) * 100;
            txtValorM100.Text = M100.ToString("N");
            M50 = Convert.ToDouble(txtCantidadM50.Text) * 50;
            txtValorM50.Text = M50.ToString("N");
            M20 = Convert.ToDouble(txtCantidadM20.Text) * 20;
            txtValorM20.Text = M20.ToString("N");
            M10 = Convert.ToDouble(txtCantidadM10.Text) * 10;
            txtValorM10.Text = M10.ToString("N");

            TotalM = (M1000 + M500 + M200 + M100 + M50 + M20 + M10);
            txtTotalMonedas.Text = TotalM.ToString("N");

            Base = TotalB + TotalM;
            txtValorTotalBase.Text = Base.ToString("N");
            //Calcular Base
        }

        private void CargarDatosCaja()
        {
            Limpiar();
            cj.Usuario = CodigoUsuario;
            DT = cj.CargarCaja();
            Billete = 0;
            if (DT.Rows.Count > 0)
            {
                rows = DT.Rows[0];
                if (rows["TipoOperacion"].ToString() == "Apertura")
                {
                    foreach (DataRow Estad in DT.Rows)
                    {
                        Billete = Convert.ToDouble(Estad["Billete"]);
                        switch (Billete.ToString())
                        {
                            case "1000":
                                txtcantidad1000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM10.Text = Estad["CantidadMonedas"].ToString();
                                break;
                            case "2000":
                                txtcantidad2000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM20.Text = Estad["CantidadMonedas"].ToString();
                                break;
                            case "5000":
                                txtCantidad5000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM50.Text = Estad["CantidadMonedas"].ToString();
                                break;
                            case "10000":
                                txtcantidad10000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM100.Text = Estad["CantidadMonedas"].ToString();
                                break;
                            case "20000":
                                txtCantidad20000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM200.Text = Estad["CantidadMonedas"].ToString();
                                break;
                            case "50000":
                                txtCantidad50000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM500.Text = Estad["CantidadMonedas"].ToString();
                                break;
                            case "100000":
                                txtCantidad100000.Text = Estad["CantidadBilletes"].ToString();
                                txtCantidadM1000.Text = Estad["CantidadMonedas"].ToString();
                                break;
                        }
                    }
                }
                else
                {
                    Limpiar();
                }
            }
            else
            {
                Limpiar();
            }
         
            Validacion();

            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad100000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }           
        }

        private void txtCantidad50000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad20000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtcantidad10000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidad5000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtcantidad2000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtcantidad1000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM1000_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM500_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM200_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM100_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM50_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM20_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }

        private void txtCantidadM10_KeyUp(object sender, KeyEventArgs e)
        {
            Validacion();
            if (Validado == 0)
            {
                CalcularBase();
            }
        }
    }
}
