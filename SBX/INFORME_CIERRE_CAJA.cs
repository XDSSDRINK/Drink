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
    public partial class INFORME_CIERRE_CAJA : Form
    {
        public List<double> Billetes = new List<double>();
        public List<double> Monedas = new List<double>();
        public List<double> Baucher = new List<double>();
        CONTROLLER.Caja cj = new CONTROLLER.Caja();
        double TotalCaja = 0;
        public int CodigoUsuario { get; set; }
        MENSAJECORRECTO msgc = new MENSAJECORRECTO();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public INFORME_CIERRE_CAJA()
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

        private void INFORME_CIERRE_CAJA_Load(object sender, EventArgs e)
        {
            CalculoCaja();
        }

        private void CalculoCaja()
        {
            //Billetes
            double Temp = 0;
            double Total = 0;
            double TotalTemp = 0;
            
            foreach (var Bill in Billetes)
            {
                if (Temp == 0)
                {
                    Temp = Bill;
                }
                else
                {
                    switch (Temp.ToString())
                    {
                        case "100000":
                            txtCantidad100000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor100000.Text = TotalTemp.ToString("N");
                            break;
                        case "50000":
                            txtCantidad50000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor50000.Text = TotalTemp.ToString("N");
                            break;
                        case "20000":
                            txtCantidad20000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor20000.Text = TotalTemp.ToString("N");
                            break;
                        case "10000":
                            txtcantidad10000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor10000.Text = TotalTemp.ToString("N");
                            break;
                        case "5000":
                            txtCantidad5000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor5000.Text = TotalTemp.ToString("N");
                            break;
                        case "2000":
                            txtcantidad2000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor2000.Text = TotalTemp.ToString("N");
                            break;
                        case "1000":
                            txtcantidad1000.Text = Bill.ToString();
                            TotalTemp = Bill * Temp;
                            txtValor1000.Text = TotalTemp.ToString("N");
                            break;
                    }

                    Total += Temp * Bill;
                    Temp = 0;
                }
            }
            txtTotalBilletes.Text = Total.ToString("N");

            //Total monedas
            Temp = 0;
            Total = 0;
            foreach (var MONE in Monedas)
            {
                if (Temp == 0)
                {
                    Temp = MONE;
                }
                else
                {
                    switch (Temp.ToString())
                    {
                        case "1000":
                            txtCantidadM1000.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM1000.Text = TotalTemp.ToString("N");
                            break;
                        case "500":
                            txtCantidadM500.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM500.Text = TotalTemp.ToString("N");
                            break;
                        case "200":
                            txtCantidadM200.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM200.Text = TotalTemp.ToString("N");
                            break;
                        case "100":
                            txtCantidadM100.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM100.Text = TotalTemp.ToString("N");
                            break;
                        case "50":
                            txtCantidadM50.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM50.Text = TotalTemp.ToString("N");
                            break;
                        case "20":
                            txtCantidadM20.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM20.Text = TotalTemp.ToString("N");
                            break;
                        case "10":
                            txtCantidadM10.Text = MONE.ToString();
                            TotalTemp = MONE * Temp;
                            txtValorM10.Text = TotalTemp.ToString("N");
                            break;
                    }

                    Total += Temp * MONE;
                    Temp = 0;
                }
            }

            txtTotalMonedas.Text = Total.ToString("N");

            //Total Baucher
            Temp = 0;
            Total = 0;
            int Filas = 0;
            int contador = 0;

            Filas = Baucher.Count / 2;
            dtgBaucher.Rows.Clear();
            dtgBaucher.Rows.Add(Filas);

            foreach (var Bauch in Baucher)
            {
                if (Temp == 0)
                {
                    Temp = Bauch;
                    dtgBaucher.Rows[contador].Cells["ClNumeroBaucher"].Value = Temp.ToString();
                }
                else
                {
                    dtgBaucher.Rows[contador].Cells["ClValor"].Value = Bauch.ToString("N");
                    Total += Bauch;
                    contador++;
                    Temp = 0;
                }
            }

            txtTotalBaucher.Text = Total.ToString("N");
            TotalCaja = Convert.ToDouble(txtTotalBilletes.Text) + Convert.ToDouble(txtTotalMonedas.Text) + Convert.ToDouble(txtTotalBaucher.Text);
            txtTotalCaja.Text = TotalCaja.ToString("N");

            //Calcular Total ventas despues de apertura de caja
            DataTable DT;
            double TotalVentas = 0;
            cj.Usuario = this.CodigoUsuario;
            DT = cj.ConsultarVentasParaCaja();

            foreach (DataRow vents in DT.Rows)
            {
                TotalVentas += Convert.ToDouble(vents["TotalVenta"]);
            }

            txtTotalVentasC.Text = TotalVentas.ToString("N");

            //Calcular total Apertura de caja
            double TBilletes = 0;
            double TMonedas = 0;
            double TBaucher = 0;
            double TotalBaseCaja = 0;
            double TotalDiferencia = 0;

            cj.Usuario = this.CodigoUsuario;
            DT = cj.CargarCaja();
            foreach (DataRow DCaja in DT.Rows)
            {
                if (DCaja["TipoOperacion"].ToString() == "Apertura")
                {
                    //Billetes
                    TBilletes += Convert.ToDouble(DCaja["Billete"]) * Convert.ToDouble(DCaja["CantidadBilletes"]);
                    //Monedas 
                    TMonedas += Convert.ToDouble(DCaja["Moneda"]) * Convert.ToDouble(DCaja["CantidadMonedas"]);
                    //Baucher
                    TBaucher += Convert.ToDouble(DCaja["ValorBaucher"]);
                }
            }

            TotalBaseCaja = TBilletes + TMonedas + TBaucher;

            txtTotalBaseCaja.Text = TotalBaseCaja.ToString("N");
            TotalDiferencia = (Convert.ToDouble(txtTotalCaja.Text) - (Convert.ToDouble(txtTotalVentasC.Text) + Convert.ToDouble(txtTotalBaseCaja.Text)));
            txtTotalDiferencia.Text = TotalDiferencia.ToString("N");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Filas = 0;
            Filas = dtgBaucher.Rows.Count;
            int Contador = 0;
            bool OK = true;

            Filas--;
            if (Filas <= 7)
            {
                //Billete 100.000  y moneda 1000
                cj.Billete = 100000;
                cj.CantidadBilletes = Convert.ToInt32(txtCantidad100000.Text);
                cj.Moneda = 1000;
                cj.CantidadMonedas = Convert.ToInt32(txtCantidadM1000.Text);
                if (Filas > 0)
                {
                    cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[0].Cells["ClNumeroBaucher"].Value.ToString());
                    cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[0].Cells["ClValor"].Value.ToString());
                }
                else
                {
                    cj.NumeroBaucher = 0;
                    cj.ValorBaucher = 0;
                }
                cj.Usuario = CodigoUsuario;
                cj.FechaRegistro = DateTime.Now;
                cj.TipoOperacion = "Cierre";

                OK = cj.Registrar();

                if (OK)
                {
                    //Billete 50.000  y moneda 500
                    cj.Billete = 50000;
                    cj.CantidadBilletes = Convert.ToInt32(txtCantidad50000.Text);
                    cj.Moneda = 500;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM500.Text);
                    if (Filas > 1)
                    {
                        cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[1].Cells["ClNumeroBaucher"].Value.ToString());
                        cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[1].Cells["ClValor"].Value.ToString());
                    }
                    else
                    {
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                    }
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    cj.TipoOperacion = "Cierre";

                    OK = cj.Registrar();
                }

                if (OK)
                {
                    //Billete 20.000  y moneda 200
                    cj.Billete = 20000;
                    cj.CantidadBilletes = Convert.ToInt32(txtCantidad20000.Text);
                    cj.Moneda = 200;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM200.Text);
                    if (Filas > 2)
                    {
                        cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[2].Cells["ClNumeroBaucher"].Value.ToString());
                        cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[2].Cells["ClValor"].Value.ToString());
                    }
                    else
                    {
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                    }
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    cj.TipoOperacion = "Cierre";

                    OK = cj.Registrar();
                }

                if (OK)
                {
                    //Billete 10.000  y moneda 100
                    cj.Billete = 10000;
                    cj.CantidadBilletes = Convert.ToInt32(txtcantidad10000.Text);
                    cj.Moneda = 100;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM100.Text);
                    if (Filas > 3)
                    {
                        cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[3].Cells["ClNumeroBaucher"].Value.ToString());
                        cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[3].Cells["ClValor"].Value.ToString());
                    }
                    else
                    {
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                    }
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    cj.TipoOperacion = "Cierre";

                    OK = cj.Registrar();
                }

                if (OK)
                {
                    //Billete 5.000  y moneda 50
                    cj.Billete = 5000;
                    cj.CantidadBilletes = Convert.ToInt32(txtCantidad5000.Text);
                    cj.Moneda = 50;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM50.Text);
                    if (Filas > 4)
                    {
                        cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[4].Cells["ClNumeroBaucher"].Value.ToString());
                        cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[4].Cells["ClValor"].Value.ToString());
                    }
                    else
                    {
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                    }
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    cj.TipoOperacion = "Cierre";

                    OK = cj.Registrar();
                }

                if (OK)
                {
                    //Billete 2.000  y moneda 20
                    cj.Billete = 2000;
                    cj.CantidadBilletes = Convert.ToInt32(txtcantidad2000.Text);
                    cj.Moneda = 20;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM20.Text);
                    if (Filas > 5)
                    {
                        cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[5].Cells["ClNumeroBaucher"].Value.ToString());
                        cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[5].Cells["ClValor"].Value.ToString());
                    }
                    else
                    {
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                    }
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    cj.TipoOperacion = "Cierre";

                    OK = cj.Registrar();
                }

                if (OK)
                {
                    //Billete 1.000  y moneda 10
                    cj.Billete = 1000;
                    cj.CantidadBilletes = Convert.ToInt32(txtcantidad1000.Text);
                    cj.Moneda = 10;
                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM10.Text);
                    if (Filas > 6)
                    {
                        cj.NumeroBaucher = float.Parse(dtgBaucher.Rows[6].Cells["ClNumeroBaucher"].Value.ToString());
                        cj.ValorBaucher = Convert.ToDouble(dtgBaucher.Rows[6].Cells["ClValor"].Value.ToString());
                    }
                    else
                    {
                        cj.NumeroBaucher = 0;
                        cj.ValorBaucher = 0;
                    }
                    cj.Usuario = CodigoUsuario;
                    cj.FechaRegistro = DateTime.Now;
                    cj.TipoOperacion = "Cierre";

                    OK = cj.Registrar();
                }
            }
            else
            {
                foreach (DataGridViewRow rowsBaucher in dtgBaucher.Rows)
                {
                    if (rowsBaucher.Cells["ClValor"].Value.ToString().Trim() != "")
                    {
                        if (Contador <= 6)
                        {
                            switch (Contador)
                            {
                                case 0:
                                    //Billete 100.000  y moneda 1000
                                    cj.Billete = 100000;
                                    cj.CantidadBilletes = Convert.ToInt32(txtCantidad100000.Text);
                                    cj.Moneda = 1000;
                                    cj.CantidadMonedas = Convert.ToInt32(txtCantidadM1000.Text);
                                    cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                    cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                    cj.TipoOperacion = "Cierre";
                                    cj.Usuario = CodigoUsuario;
                                    cj.FechaRegistro = DateTime.Now;
                                    OK = cj.Registrar();
                                    break;
                                case 1:
                                    if (OK)
                                    {
                                        //Billete 50.000  y moneda 500
                                        cj.Billete = 50000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad50000.Text);
                                        cj.Moneda = 500;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM500.Text);
                                        cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                        cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                        cj.TipoOperacion = "Cierre";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                    break;
                                case 2:
                                    if (OK)
                                    {

                                        //Billete 20.000  y moneda 200
                                        cj.Billete = 20000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad20000.Text);
                                        cj.Moneda = 200;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM200.Text);
                                        cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                        cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                        cj.TipoOperacion = "Cierre";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                    break;
                                case 3:
                                    if (OK)
                                    {
                                        //Billete 10.000  y moneda 100
                                        cj.Billete = 10000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtcantidad10000.Text);
                                        cj.Moneda = 100;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM100.Text);
                                        cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                        cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                        cj.TipoOperacion = "Cierre";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                    break;
                                case 4:
                                    if (OK)
                                    {
                                        //Billete 5.000  y moneda 50
                                        cj.Billete = 5000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtCantidad5000.Text);
                                        cj.Moneda = 50;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM50.Text);
                                        cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                        cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                        cj.TipoOperacion = "Cierre";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                    break;
                                case 5:
                                    if (OK)
                                    {
                                        //Billete 2.000  y moneda 20
                                        cj.Billete = 2000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtcantidad2000.Text);
                                        cj.Moneda = 20;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM20.Text);
                                        cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                        cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                        cj.TipoOperacion = "Cierre";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                    break;
                                case 6:
                                    if (OK)
                                    {
                                        //Billete 1.000  y moneda 10
                                        cj.Billete = 1000;
                                        cj.CantidadBilletes = Convert.ToInt32(txtcantidad1000.Text);
                                        cj.Moneda = 10;
                                        cj.CantidadMonedas = Convert.ToInt32(txtCantidadM10.Text);
                                        cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                                        cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                                        cj.TipoOperacion = "Cierre";
                                        cj.Usuario = CodigoUsuario;
                                        cj.FechaRegistro = DateTime.Now;
                                        OK = cj.Registrar();
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            cj.Billete = 0;
                            cj.CantidadBilletes = 0;
                            cj.Moneda = 0;
                            cj.CantidadMonedas = 0;
                            cj.NumeroBaucher = float.Parse(rowsBaucher.Cells["ClNumeroBaucher"].Value.ToString());
                            cj.ValorBaucher = Convert.ToDouble(rowsBaucher.Cells["ClValor"].Value);
                            cj.TipoOperacion = "Cierre";
                            cj.Usuario = CodigoUsuario;
                            cj.FechaRegistro = DateTime.Now;
                            OK = cj.Registrar();
                        }
                    }

                    Contador++;
                }
            }

            msgc.lblMensaje.Text = "Caja cerrada";
            msgc.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
