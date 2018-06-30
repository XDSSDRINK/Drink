using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SBX
{
    public partial class REGISTRO_VENTASS : Form
    {
        //Delegado 
        public delegate void AgregaVentas();
        public event AgregaVentas AgregarVenta;

        CONTROLLER.Ventas ventas = new CONTROLLER.Ventas();
        AYUDA aYUDA = new AYUDA();
        CONTROLLER.General general = new CONTROLLER.General();
        AUTORIZACION aUTORIZACION = new AUTORIZACION();
        MENSAJE_CONFIRMACION mCONFIRMACION = new MENSAJE_CONFIRMACION();
        CONTROLLER.VentaAnulada VentAnu = new CONTROLLER.VentaAnulada();
        CalcularMargen Calculos = new CalcularMargen();
        CONTROLLER.Compras comp = new CONTROLLER.Compras();
        CONTROLLER.Producto prod = new CONTROLLER.Producto();
        CONTROLLER.General Gnl = new CONTROLLER.General();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        MENSAJECORRECTO msgCorrecto = new MENSAJECORRECTO();
        CONTROLLER.Cliente client = new CONTROLLER.Cliente();
        CONTROLLER.Usuario usu = new CONTROLLER.Usuario();
        CONTROLLER.CONFG_PUNTOS puntos = new CONTROLLER.CONFG_PUNTOS();
        CONTROLLER.Factura fact = new CONTROLLER.Factura();
        CONTROLLER.DescuentoCliente descC = new CONTROLLER.DescuentoCliente();
        CONTROLLER.kardex kardx = new CONTROLLER.kardex();

        public string Usuario { get; set; }
        public bool registroProductos = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable DT;
        int Filas = 0;
        int Contador = 0;
        bool OK = true;
        string item = "";
        string codigoBarras = "";
        int Usuariosreg = 0;
        CONTROLLER.Mesero oMesero = new CONTROLLER.Mesero();

        //// Create a new form.
        Form mdiChildForm = new Form();

        public REGISTRO_VENTASS()
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();

            lblMesa.Visible = false;
            lblNomMesero.Visible = false;
            txtNomBoton.Visible = false;
            lblCedulaMesero.Visible = false;
            txtCedulaMesero.Visible = false;
            txtCodInternoMesero.Visible = false;
            lblNomMesero.Visible = false;
            btnBuscarMesero.Visible = false;
        }

        public REGISTRO_VENTASS(String nomMesa, String nomBoton)
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();
            
            txtNomBoton.Text = nomBoton;
            lblMesa.Text = "MESA: " + nomMesa;

            lblMesa.Visible = true;
            lblNomMesero.Visible = true;
            lblCedulaMesero.Visible = true;
            txtCedulaMesero.Visible = true;
            lblNomMesero.Visible = true;
            btnBuscarMesero.Visible = true;
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
            //Cuando es visible es por que es una compra de una mesa
            if (lblMesa.Visible)
            {
                if (dtgRegistroVentas.Rows.Count > 0)
                {
                    registroProductos = true;
                }
                else
                {
                    registroProductos = false;
                }
                this.Hide();
            }
            else
            {
                Limpiar();
                this.Close();
            }
        }

        private void Limpiar(String bandera = "0")
        {
            txtProducto.Text = "";
            dtgRegistroVentas.Rows.Clear();
            txtCliente.Text = "Cliente";
            lblNombreCliente.Text = "--";
            txtRecibido.Text = "";
            txtCambio.Text = "";
            txtTotal.Text = "";
            txtImpuesto.Text = "";
            txtCantidad.Text = "";
            btnCerrar.Enabled = true;
            txtPuntos.Text = "";
            btnGuardar.Enabled = true;

            if (!bandera.Equals("0"))
            {
                lblMesa.Visible = true;
                txtNomBoton.Visible = false;
                lblNomMesero.Visible = true;
                btnBuscarMesero.Visible = true;
                lblCedulaMesero.Visible = true;
                txtCedulaMesero.Visible = true;
                txtCodInternoMesero.Visible = false;

                //txtNomBoton.Text = "";
                txtCodInternoMesero.Text = "";
                //lblMesa.Text = "MESA:";
                lblNomMesero.Text = "ATIENDE:";
                txtCedulaMesero.Text = "Buscar Mesero";
            }
            else
            {                
                lblMesa.Visible = false;
                txtNomBoton.Visible = false;
                lblNomMesero.Visible = false;
                btnBuscarMesero.Visible = false;
                lblCedulaMesero.Visible = false;
                txtCedulaMesero.Visible = false;
                txtCodInternoMesero.Visible = false;

                txtNomBoton.Text = "";
                txtCodInternoMesero.Text = "";
                lblMesa.Text = "MESA:";
                lblNomMesero.Text = "ATIENDE:";
                txtCedulaMesero.Text = "Buscar Mesero";
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

        private void CargaProductoVenta()
        {
            errorProvider1.Clear();

            double ValorUnidad = 0;
            double NuevaCantidad = 0;
            Filas = 0;
            bool NuevoProducto = true;

            if (txtProducto.Text.Trim() != "")
            {
                ventas.buscar = txtProducto.Text;

                DT = ventas.producto_venta();

                if (DT.Rows.Count > 0)
                {
                    DataRow Pro = DT.Rows[0];
                    string items = Pro["Item"].ToString();
                    //verificar existencia de producto

                    if (dtgRegistroVentas.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow proexit in dtgRegistroVentas.Rows)
                        {
                            if (proexit.Cells["ClItem"].Value.ToString() == Pro["Item"].ToString() && proexit.Cells["ClCodigoBarras"].Value.ToString() == "")
                            {
                                NuevoProducto = false;
                                NuevaCantidad = Convert.ToDouble(proexit.Cells["ClCantidad"].Value) + 1;
                                proexit.Cells["ClCantidad"].Value = NuevaCantidad.ToString();
                            }
                        }

                        if (NuevoProducto == true)
                        {
                            Filas = DT.Rows.Count;
                            dtgRegistroVentas.Rows.Add(Filas);
                            foreach (DataRow rows in DT.Rows)
                            {
                                dtgRegistroVentas.Rows[Contador].Cells["ClNombreDoc"].Value = "Prueba";
                                dtgRegistroVentas.Rows[Contador].Cells["ClConseDoc"].Value = "0001";
                                dtgRegistroVentas.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClCodigoBarras"].Value = "";
                                dtgRegistroVentas.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClCantidad"].Value = "1";
                                ValorUnidad = Convert.ToDouble(rows["PRECIO_VENTA"]);
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorUnidad"].Value = ValorUnidad.ToString("N2");
                                dtgRegistroVentas.Rows[Contador].Cells["ClDescuento"].Value = "0";
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorDesc"].Value = "0";
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorTotal"].Value = "0";
                                dtgRegistroVentas.Rows[Contador].Cells["ClIva"].Value = rows["IVA"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorIva"].Value = "0";
                                Contador++;
                            }
                        }
                    }
                    else
                    {
                        Contador = 0;
                        Filas = DT.Rows.Count;
                        dtgRegistroVentas.Rows.Add(Filas);
                        foreach (DataRow rows in DT.Rows)
                        {
                            dtgRegistroVentas.Rows[Contador].Cells["ClNombreDoc"].Value = "Prueba";
                            dtgRegistroVentas.Rows[Contador].Cells["ClConseDoc"].Value = "0001";
                            dtgRegistroVentas.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClCodigoBarras"].Value = "";
                            dtgRegistroVentas.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClCantidad"].Value = "1";
                            ValorUnidad = Convert.ToDouble(rows["PRECIO_VENTA"]);
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorUnidad"].Value = ValorUnidad.ToString("N2");
                            dtgRegistroVentas.Rows[Contador].Cells["ClDescuento"].Value = "0";
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorDesc"].Value = "0";
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorTotal"].Value = "0";
                            dtgRegistroVentas.Rows[Contador].Cells["ClIva"].Value = rows["IVA"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorIva"].Value = "0";
                            Contador++;
                        }
                    }

                    txtProducto.Text = "";
                }
                else
                {
                    //Buscar por codigo de barras
                    ventas.buscar = txtProducto.Text;
                    DT = ventas.CargarProductosCodigoBarras();

                    if (DT.Rows.Count > 0)
                    {
                        DataRow Pro = DT.Rows[0];
                        string items = Pro["Item"].ToString();
                        //verificar existencia de producto

                        if (dtgRegistroVentas.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow proexit in dtgRegistroVentas.Rows)
                            {
                                if (proexit.Cells["ClItem"].Value.ToString() == Pro["Item"].ToString() && proexit.Cells["ClCodigoBarras"].Value.ToString() == Pro["COD_BARRAS"].ToString())
                                {
                                    NuevoProducto = false;
                                    NuevaCantidad = Convert.ToDouble(proexit.Cells["ClCantidad"].Value) + 1;
                                    proexit.Cells["ClCantidad"].Value = NuevaCantidad.ToString();
                                }
                            }

                            if (NuevoProducto == true)
                            {
                                Filas = DT.Rows.Count;
                                dtgRegistroVentas.Rows.Add(Filas);
                                foreach (DataRow rows in DT.Rows)
                                {
                                    dtgRegistroVentas.Rows[Contador].Cells["ClNombreDoc"].Value = "Prueba";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClConseDoc"].Value = "0001";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["COD_BARRAS"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClCantidad"].Value = "1";
                                    ValorUnidad = Convert.ToDouble(rows["PRECIO_VENTA"]);
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorUnidad"].Value = ValorUnidad.ToString("N2");
                                    dtgRegistroVentas.Rows[Contador].Cells["ClDescuento"].Value = "0";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorDesc"].Value = "0";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorTotal"].Value = "0";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClIva"].Value = rows["IVA"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorIva"].Value = "0";
                                    Contador++;
                                }
                            }
                        }
                        else
                        {
                            Contador = 0;
                            Filas = DT.Rows.Count;
                            dtgRegistroVentas.Rows.Add(Filas);
                            foreach (DataRow rows in DT.Rows)
                            {
                                dtgRegistroVentas.Rows[Contador].Cells["ClNombreDoc"].Value = "Prueba";
                                dtgRegistroVentas.Rows[Contador].Cells["ClConseDoc"].Value = "0001";
                                dtgRegistroVentas.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["COD_BARRAS"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClCantidad"].Value = "1";
                                ValorUnidad = Convert.ToDouble(rows["PRECIO_VENTA"]);
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorUnidad"].Value = ValorUnidad.ToString("N2");
                                dtgRegistroVentas.Rows[Contador].Cells["ClDescuento"].Value = "0";
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorDesc"].Value = "0";
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorTotal"].Value = "0";
                                dtgRegistroVentas.Rows[Contador].Cells["ClIva"].Value = rows["IVA"].ToString();
                                dtgRegistroVentas.Rows[Contador].Cells["ClValorIva"].Value = "0";
                                Contador++;
                            }
                        }

                        txtProducto.Text = "";
                    }
                    else
                    {
                        errorProvider1.SetError(txtProducto, "Producto no disponible");
                    }
                }
            }

            if (dtgRegistroVentas.Rows.Count > 0)
            {
                //Cuando es visible es por que es una compra de una mesa
                if (lblMesa.Visible)
                {
                    btnCerrar.Enabled = true;
                }
                else
                {
                    btnCerrar.Enabled = false;
                }


            }
            else
            {
                btnCerrar.Enabled = true;
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            CargaProductoVenta();
            CalculoValores();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            aYUDA.Modulo = "Venta";
            aYUDA.EnviaProductos += new AYUDA.EnviaProducto(CargarProducto);
            aYUDA.ShowDialog();
        }

        private void CargarProducto(string Producto)
        {
            txtProducto.Text = Producto;
        }

        private void QuitarProductLista()
        {
            Filas = 0;
            if (dtgRegistroVentas.CurrentRow != null)
            {
                Filas = dtgRegistroVentas.CurrentRow.Index;
                dtgRegistroVentas.Rows.Remove(dtgRegistroVentas.Rows[Filas]);
            }

            if (dtgRegistroVentas.RowCount == 0)
            {
                btnCerrar.Enabled = true;
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (dtgRegistroVentas.Rows.Count > 0)
            {
                aUTORIZACION.ShowDialog();
                if (aUTORIZACION.Atorizacion)
                {
                    QuitarProductLista();
                }
            }

            CalculoValores();
        }

        private void RegistrarVentaAnulada()
        {
            List<string> Items = new List<string>();
            foreach (DataGridViewRow rows in dtgRegistroVentas.Rows)
            {
                VentAnu.Item = rows.Cells["ClItem"].Value.ToString();
                VentAnu.CodBarras = rows.Cells["ClCodigoBarras"].Value.ToString();
                VentAnu.Cantidad = Convert.ToDouble(rows.Cells["ClCantidad"].Value);
                VentAnu.PrecioUN = Convert.ToDouble(rows.Cells["ClValorUnidad"].Value);
                VentAnu.Descuento = Convert.ToDouble(rows.Cells["ClDescuento"].Value);
                VentAnu.Usuario = Usuario;
                OK = VentAnu.Registrar();

                if (OK)
                {
                    Items.Add(rows.Cells["ClItem"].Value.ToString());
                }
            }

            foreach (var lista in Items)
            {
                foreach (DataGridViewRow items in dtgRegistroVentas.Rows)
                {
                    if (lista == items.Cells["ClItem"].Value.ToString())
                    {
                        dtgRegistroVentas.Rows.Remove(items);
                    }
                }
            }
        }

        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            if (dtgRegistroVentas.Rows.Count > 0)
            {
                mCONFIRMACION.txtMensaje.Text = "Seguro que desea Anular la venta";
                mCONFIRMACION.Modulo = "Confirmacion";
                mCONFIRMACION.ShowDialog();
                if (mCONFIRMACION.Ok)
                {
                    RegistrarVentaAnulada();
                    if (OK)
                    {
                        btnCerrar.Enabled = true;
                    }
                }
            }

            CalculoValores();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            Filas = 0;
            item = "";
            codigoBarras = "";
            DataRow rows;

            if (dtgRegistroVentas.RowCount > 0)
            {
                Filas = dtgRegistroVentas.CurrentRow.Index;
                item = dtgRegistroVentas.Rows[Filas].Cells["ClItem"].Value.ToString();
                codigoBarras = dtgRegistroVentas.Rows[Filas].Cells["ClCodigoBarras"].Value.ToString();

                if (codigoBarras != "")
                {
                    item = codigoBarras;
                }

                //Busca productos por item
                ventas.buscar = item;
                DT = ventas.producto_venta();

                if (DT.Rows.Count > 0)
                {
                    rows = DT.Rows[0];
                    Calculos.Costos = rows["Costo"].ToString();
                    Calculos.Margen = rows["Margen"].ToString();
                }
                else
                {
                    //Busca productos por codigo de barras
                    ventas.buscar = codigoBarras;
                    DT = ventas.CargarProductosCodigoBarras();
                    if (DT.Rows.Count > 0)
                    {
                        rows = DT.Rows[0];
                        Calculos.Costos = rows["Costo"].ToString();
                        Calculos.Margen = rows["Margen"].ToString();
                    }
                }

                Calculos.Producto = dtgRegistroVentas.Rows[Filas].Cells["ClItem"].Value.ToString();
                Calculos.Modulo = "Venta";
                Calculos.PrecioVenta = Convert.ToDouble(dtgRegistroVentas.Rows[Filas].Cells["ClValorUnidad"].Value);
                Calculos.MargenVentas += new CalcularMargen.EnviaMargenVenta(AplicarDescuentos);
                Calculos.ShowDialog();
            }

            CalculoValores();
        }

        private void AplicarDescuentos(string Descuento)
        {
            foreach (DataGridViewRow rows in dtgRegistroVentas.Rows)
            {
                if (item == rows.Cells["ClItem"].Value.ToString() && rows.Cells["ClCodigoBarras"].Value.ToString() == "")
                {
                    rows.Cells["ClDescuento"].Value = Descuento;
                }
                else if(item == rows.Cells["ClCodigoBarras"].Value.ToString())
                {
                    rows.Cells["ClDescuento"].Value = Descuento;
                }
            }
        }

        private void CalculoValores()
        {
            double PrecioTotal = 0;
            double CantidadTotal = 0;
            double ValorDescuento = 0;
            double TPuntos = 0;
            double Monto = 0;
            double PuntosPremio = 0;
            double DescuentoPuntos = 0;
            double ValorDescuentoPuntos = 0;
            int CodigoCliente = 3;

            if (dtgRegistroVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow cal in dtgRegistroVentas.Rows)
                {
                    PrecioTotal = Convert.ToDouble(cal.Cells["ClValorUnidad"].Value) * Convert.ToDouble(cal.Cells["ClCantidad"].Value);
                    cal.Cells["ClValorTotal"].Value = PrecioTotal.ToString("N2");

                    ValorDescuento = Convert.ToDouble(cal.Cells["ClValorTotal"].Value) * (Convert.ToDouble(cal.Cells["ClDescuento"].Value) / 100);
                    cal.Cells["ClValorDesc"].Value = ValorDescuento.ToString("N2");
                    PrecioTotal = Convert.ToDouble(cal.Cells["ClValorTotal"].Value) + Convert.ToDouble(cal.Cells["ClValorDesc"].Value);
                    cal.Cells["ClValorTotal"].Value = PrecioTotal.ToString("N2");
                }

                PrecioTotal = 0;
                CantidadTotal = 0;

                foreach (DataGridViewRow cal in dtgRegistroVentas.Rows)
                {
                    PrecioTotal += Convert.ToDouble(cal.Cells["ClValorTotal"].Value);
                    CantidadTotal += Convert.ToDouble(cal.Cells["ClCantidad"].Value);
                }

                //Calcular Puntos
                //Cliente
                if (txtCliente.Text.Trim() != "" && txtCliente.Text != "Cliente")
                {
                    DT = client.CargarActivos(txtCliente.Text);
                    foreach (DataRow rows in DT.Rows)
                    {
                        CodigoCliente = Convert.ToInt32(rows["Codigo"]);
                    }
                }
                else
                {
                    CodigoCliente = 3;
                }

                if (CodigoCliente != 3)
                {
                    DT = puntos.CargarConfgPuntos();
                    foreach (DataRow rows in DT.Rows)
                    {
                        Monto = Convert.ToDouble(rows["XcadaMonto"]);
                        PuntosPremio = Convert.ToDouble(rows["XcadaPuntos"]);
                        DescuentoPuntos = Convert.ToDouble(rows["Descuento"]);
                        ventas.OtrosDescuentos = DescuentoPuntos;
                    }

                    TPuntos = PrecioTotal / Monto;

                    //Aplicar Descuento por acomulacion de puntos
                    if (TPuntos >= PuntosPremio)
                    {
                        ValorDescuentoPuntos = PrecioTotal * DescuentoPuntos;
                        PrecioTotal = PrecioTotal - ValorDescuentoPuntos;
                    }
                }

                txtDescPuntos.Text = ValorDescuentoPuntos.ToString("N2");
                txtCantidad.Text = CantidadTotal.ToString("N");
                txtTotal.Text = PrecioTotal.ToString("N2");
                txtPuntos.Text = TPuntos.ToString();
            }

        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            if (txtCliente.Text == "Cliente")
            {
                txtCliente.Text = "";
                txtCliente.ForeColor = Color.Black;
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                txtCliente.Text = "Cliente";
                txtCliente.ForeColor = Color.Silver;
            }
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process calc = new Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();

            calc.WaitForExit();
        }

        private void dtgRegistroVentas_Validating(object sender, CancelEventArgs e)
        {
            ValidacionCantidad();
        }

        private void ValidacionCantidad()
        {
            foreach (DataGridViewRow rows in dtgRegistroVentas.Rows)
            {
                OK = Gnl.IsNumericDouble(rows.Cells["ClCantidad"].Value.ToString());
                if (!OK)
                {
                    msgError.lblMensaje.Text = "Ingrese valores numericos";
                    msgError.ShowDialog();
                    rows.Cells["ClCantidad"].Value = "1";
                }
            }

            CalculoValores();
        }

        private void dtgRegistroVentas_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            ValidacionCantidad();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            aYUDA.Modulo = "Cliente";
            aYUDA.EnviaPersonas += new AYUDA.EnviaPersona(CargarCliente);
            aYUDA.ShowDialog();
        }

        private void CargarCliente(string Cliente)
        {
            if (Cliente.Trim() != "")
            {
                txtCliente.Text = Cliente;
                DT = client.CargarActivos(Cliente);
                DataRow rows = DT.Rows[0];
                lblNombreCliente.Text = rows["RazonSocial"].ToString() + " " + rows["NombreComercial"].ToString();
            }
        }

        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            double Descuento = 0;
            DataTable DTCliente;
            DataTable DTDescuento;
            DataTable DTCodProducto;
            if (txtCliente.Text.Trim() != "")
            {
                DTCliente = client.CargarActivos(txtCliente.Text);
                if (DTCliente.Rows.Count > 0)
                {
                    DataRow rows = DTCliente.Rows[0];
                    lblNombreCliente.Text = rows["RazonSocial"].ToString() + " " + rows["NombreComercial"].ToString();

                    //Asigna descuentos
                    descC.Cliente = Convert.ToInt32(rows["Codigo"]);
                    DTDescuento = descC.CargarDescuentosCliente();

                    foreach (DataRow descli in DTDescuento.Rows)
                    {
                        foreach (DataGridViewRow prodVen in dtgRegistroVentas.Rows)
                        {
                            DTCodProducto = prod.CargarProducto("pd.Item", prodVen.Cells["ClItem"].Value.ToString(), "Unico");
                            DataRow prods = DTCodProducto.Rows[0];
                            if (prods["CodigoProducto"].ToString() == descli["Producto"].ToString())
                            {
                                Descuento = Convert.ToDouble(descli["Descuento"]);
                                Descuento = Descuento * -1;
                                prodVen.Cells["ClDescuento"].Value = Descuento.ToString("N");
                            }
                        }
                    }
                }
                else
                {
                    lblNombreCliente.Text = "--";
                }
            }
            else
            {
                lblNombreCliente.Text = "--";
            }

            CalculoValores();
        }

        private void RellenaCampo()
        {
            if (txtRecibido.Text.Trim() == "")
            {
                txtRecibido.Text = "0";
            }
            if (txtCambio.Text.Trim() == "")
            {
                txtCambio.Text = "0";
            }
            if (txtPuntos.Text.Trim() == "")
            {
                txtPuntos.Text = "0";
            }
            if (txtCantidad.Text.Trim() == "")
            {
                txtCantidad.Text = "0";
            }
            if (txtImpuesto.Text.Trim() == "")
            {
                txtImpuesto.Text = "0";
            }
            if (txtDescPuntos.Text.Trim() == "")
            {
                txtDescPuntos.Text = "0";
            }
            if (txtTotal.Text.Trim() == "")
            {
                txtTotal.Text = "0";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            DataRow rowsGlobal;
            Boolean continua = true;
            double NuevoConsecutivo = 0;
            int ContadorErrorKardex = 0;
            int ContadorErrorVenta = 0;
            codigoBarras = "";
            item = "";
            ValidacionCantidad();
            CalculoValores();
            RellenaCampo();

            if (dtgRegistroVentas.Rows.Count > 0)
            {
                //Cuando es visible es por que es una compra de una mesa
                if (lblMesa.Visible)
                {
                    //Valido que deba asignarle un codigo de mesero a la mesa
                    if (txtCodInternoMesero.Text == "" || txtCodInternoMesero.Text.Trim().Equals(""))
                    {
                        msgError.lblMensaje.Text = "Debe asignar a alguien que atienda la mesa.";
                        msgError.ShowDialog();
                        txtCedulaMesero.Focus();
                        continua = false;
                    }
                    else
                    {
                        mCONFIRMACION.txtMensaje.Text = "Seguro que desea totalizar esta venta?";
                        mCONFIRMACION.Modulo = "Confirmacion";
                        mCONFIRMACION.ShowDialog();
                        if (mCONFIRMACION.Ok)
                        {
                            continua = true;
                        }
                        else
                        {
                            continua = false;
                        }
                    }
                }

                if (continua)
                {
                    //Usuario
                    DT = usu.Cargar(true);
                    foreach (DataRow rows in DT.Rows)
                    {
                        if (rows["Usuario"].ToString() == Usuario)
                        {
                            Usuariosreg = Convert.ToInt32(rows["CodigoUsuario"]);
                            ventas.CodigoUsuario = Convert.ToInt32(rows["CodigoUsuario"]);
                        }
                    }
<<<<<<< HEAD
                    //Cliente
                    if (txtCliente.Text.Trim() != "" && txtCliente.Text != "Cliente")
                    {
                        DT = client.CargarActivos(txtCliente.Text);
                        foreach (DataRow rows in DT.Rows)
                        {
                            ventas.CodigoCliente = Convert.ToInt32(rows["Codigo"]);
                        }
                    }
                    else
                    {
                        ventas.CodigoCliente = 3;
                    }

                    foreach (DataGridViewRow rows in dtgRegistroVentas.Rows)
                    {
                        //Producto
                        DT = prod.CargarProducto("pd.Item", rows.Cells["ClItem"].Value.ToString(), "Unico");
                        rowsGlobal = DT.Rows[0];
                        ventas.CodigoProducto = Convert.ToInt32(rowsGlobal["CodigoProducto"]);
                        ventas.CodigoBarras = rows.Cells["ClCodigoBarras"].Value.ToString();
                        ventas.IVA = Convert.ToDouble(rows.Cells["ClIva"].Value);
                        ventas.Puntos = Convert.ToDouble(txtPuntos.Text);
                        //Factura
                        ventas.Documento = "Factura";
                        DT = fact.CargarFacura();
                        foreach (DataRow fac in DT.Rows)
                        {
                            //Verificacion en ventas
                            DT = ventas.CargarUltimoConsecutivo();
                            foreach (DataRow ventasrow in DT.Rows)
                            {
                                if (ventasrow["UltimoConsecutivo"].ToString() != "0")
                                {
                                    NuevoConsecutivo = Convert.ToDouble(ventasrow["UltimoConsecutivo"]) + 1;
                                    ventas.ConsecutivoDocumento = NuevoConsecutivo.ToString();
                                }
                                else
                                {
                                    ventas.ConsecutivoDocumento = "1";
                                }
                            }
                            ventas.NombreDocumento = fac["Nombre"].ToString();
                        }

                        ventas.Cantidad = Convert.ToDouble(rows.Cells["ClCantidad"].Value);

                        ventas.buscar = rows.Cells["ClItem"].Value.ToString();
                        DT = ventas.producto_venta();
                        foreach (DataRow DatosVenta in DT.Rows)
                        {
                            ventas.Costo = Convert.ToDouble(DatosVenta["Costo"]);
                            ventas.Margen = Convert.ToDouble(DatosVenta["Margen"]);
                        }

                        ventas.Descuento = Convert.ToDouble(rows.Cells["ClDescuento"].Value);
                        ventas.MedioPago = "Efectivo";
                        ventas.Efectivo = Convert.ToDouble(txtRecibido.Text);

                        OK = ventas.Registrar();
=======
                }
                else
                {
                    ventas.CodigoCliente = 3;
                }

                DT = fact.CargarFacura();
                foreach (DataRow fac in DT.Rows)
                {
                    //Verificacion en ventas
                    DT = ventas.CargarUltimoConsecutivo();
                    foreach (DataRow ventasrow in DT.Rows)
                    {
                        if (ventasrow["UltimoConsecutivo"].ToString() != "0")
                        {
                            NuevoConsecutivo = Convert.ToDouble(ventasrow["UltimoConsecutivo"]) + 1;
                            ventas.ConsecutivoDocumento = NuevoConsecutivo.ToString();
                        }
                        else
                        {
                            ventas.ConsecutivoDocumento = "1";
                        }
                    }
                    ventas.NombreDocumento = fac["Nombre"].ToString();
                }

                foreach (DataGridViewRow rows in dtgRegistroVentas.Rows)
                {
                    //Producto
                    DT = prod.CargarProducto("pd.Item", rows.Cells["ClItem"].Value.ToString(), "Unico");
                    rowsGlobal = DT.Rows[0];
                    ventas.CodigoProducto = Convert.ToInt32(rowsGlobal["CodigoProducto"]);
                    ventas.CodigoBarras = rows.Cells["ClCodigoBarras"].Value.ToString();
                    ventas.IVA = Convert.ToDouble(rows.Cells["ClIva"].Value);
                    ventas.Puntos = Convert.ToDouble(txtPuntos.Text);
                    //Factura
                    ventas.Documento = "Factura";

                    ventas.Cantidad = Convert.ToDouble(rows.Cells["ClCantidad"].Value);
                    item = rows.Cells["ClItem"].Value.ToString();
                    codigoBarras = rows.Cells["ClCodigoBarras"].Value.ToString();

                    if (codigoBarras != "")
                    {
                        item = codigoBarras;
                    }
                    //Busca productos por item
                    ventas.buscar = item;
                    DT = ventas.producto_venta();

                    if (DT.Rows.Count > 0)
                    {
                        rowsGlobal = DT.Rows[0];
                        ventas.Costo = Convert.ToDouble(rowsGlobal["Costo"]);
                        ventas.Margen = Convert.ToDouble(rowsGlobal["Margen"]);
                    }
                    else
                    {
                        //Busca productos por codigo de barras
                        ventas.buscar = codigoBarras;
                        DT = ventas.CargarProductosCodigoBarras();
                        if (DT.Rows.Count > 0)
                        {
                            rowsGlobal = DT.Rows[0];
                            ventas.Costo = Convert.ToDouble(rowsGlobal["Costo"]);
                            ventas.Margen = Convert.ToDouble(rowsGlobal["Margen"]);
                        }
>>>>>>> 306e46297e10b2ace8f6288c603c474a9e3f0cda
                    }

                    if (OK)
                    {
                        kardx.CodigoUsuario = Usuariosreg;
                        kardx.Modulo = "Ventas";
                        OK = kardx.Registrar();

<<<<<<< HEAD
                        if (!OK)
                        {
                            msgError.lblMensaje.Text = "Error al intentar registrar en kardex";
                            msgError.ShowDialog();
                        }

                        try
                        {
                            if (lblMesa.Visible)
                            {
                                CONTROLLER.MesaMesero oMesaMesero = new CONTROLLER.MesaMesero();
                                oMesaMesero.nomBoton = txtNomBoton.Text;
                                oMesaMesero.codigo = long.Parse(txtCodInternoMesero.Text);
                                oMesaMesero.registrar();
                            }                            
                        }
                        catch(Exception ex)
                        {

                        }

                        msgCorrecto.lblMensaje.Text = "Venta registrada correctamente";
                        msgCorrecto.ShowDialog();                       

                        if (!lblMesa.Visible)
                        {
                            Limpiar();
                            AgregarVenta();

                        }
                        else
                        {
                            Limpiar("1");
                        }
                    }
                    else
                    {
                        msgError.lblMensaje.Text = "Error al intentar registrar venta";
                        msgError.ShowDialog();
                    }
                }
=======
                    OK = ventas.Registrar();
                    if (OK)
                    {
                        kardx.CodigoUsuario = Usuariosreg;
                        kardx.Modulo = "Ventas";
                        OK = kardx.Registrar();
                        if (!OK)
                        {
                            ContadorErrorKardex++;
                            //Crear arhivo log de errores en ventas
                            StreamWriter EscriturasKardex = File.AppendText("ErrorRegistroKardex.txt");
                            EscriturasKardex.WriteLine("Fecha: " + DateTime.Now + ", Error al intentar registrar producto en kardex: " + rowsGlobal["Item"].ToString());
                            EscriturasKardex.Close();
                        }
                    }
                    else
                    {
                        ContadorErrorVenta++;
                        //Crear arhivo log de errores en ventas
                        StreamWriter EscriturasVentas = File.AppendText("ErrorRegistroVenta.txt");
                        EscriturasVentas.WriteLine("Fecha: " + DateTime.Now + ", Error al intentar registrar producto en venta: " + rowsGlobal["Item"].ToString());
                        EscriturasVentas.Close();
                    }

                    StreamWriter Finalizado = File.AppendText("ProductosRegistradosVentas.txt");
                    Finalizado.WriteLine(" Fecha: "+DateTime.Now+", Producto: " + rowsGlobal["Item"].ToString());
                    Finalizado.Close();
                }

                if (ContadorErrorVenta == 0 && ContadorErrorKardex == 0)
                {
                    msgCorrecto.lblMensaje.Text = "Venta registrada correctamente";
                    msgCorrecto.ShowDialog();
                    Limpiar();
                    AgregarVenta();
                }
                else
                {
                    if (ContadorErrorVenta > 0)
                    {
                        msgError.lblMensaje.Text = "No fue posible registrar en ventas " + ContadorErrorVenta + " Productos \n ";
                        if (ContadorErrorKardex > 0)
                        {
                            msgError.lblMensaje.Text = msgError.lblMensaje.Text + "No fue posible registrar en kardex " + ContadorErrorKardex + " Productos ";
                        }
                    }
                    else if(ContadorErrorKardex > 0)
                    {
                        msgError.lblMensaje.Text = msgError.lblMensaje.Text + "No fue posible registrar en kardex " + ContadorErrorKardex + " Productos ";
                    }

                    msgError.ShowDialog();
                }    
>>>>>>> 306e46297e10b2ace8f6288c603c474a9e3f0cda
            }

        }

        private void txtRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gnl.ValidaNumeros(e);
        }

        private void txtRecibido_KeyUp(object sender, KeyEventArgs e)
        {
            CalculoValores();

            double Cambio = 0;

            if (txtRecibido.Text.Trim() != "")
            {
                if (txtTotal.Text.Trim() == "")
                {
                    txtTotal.Text = "0";
                }

                Cambio = Convert.ToDouble(txtRecibido.Text) - Convert.ToDouble(txtTotal.Text);
            }

            txtCambio.Text = Cambio.ToString("N");
        }

        private void dtgRegistroVentas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidacionCantidad();
            CalculoValores();
        }

        private void dtgRegistroVentas_KeyUp(object sender, KeyEventArgs e)
        {
            ValidacionCantidad();
            CalculoValores();
        }

        private void dtgRegistroVentas_Enter(object sender, EventArgs e)
        {
            ValidacionCantidad();
            CalculoValores();
        }

        private void dtgRegistroVentas_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            ValidacionCantidad();
            CalculoValores();
        }

        private void dtgRegistroVentas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ValidacionCantidad();
            CalculoValores();
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
            if (txtProducto.Text.Trim() != "")
            {
                ventas.buscar = txtProducto.Text;

                DT = ventas.producto_venta();

                if (DT.Rows.Count == 0)
                {
                    CargaProductoVenta();
                    CalculoValores();
                }
            }
        }

        private void txtCodigoMesero_Leave(object sender, EventArgs e)
        {
            if (txtCedulaMesero.Text == "")
            {
                txtCedulaMesero.Text = "Buscar Mesero";
                txtCedulaMesero.ForeColor = Color.Gray;
            }
        }
        
        private void txtCodigoMesero_Enter(object sender, EventArgs e)
        {
            if (txtCedulaMesero.Text == "Buscar Mesero")
            {
                txtCedulaMesero.Text = "";
                txtCedulaMesero.ForeColor = Color.Black;
            }
        }

        private void txtCodigoMesero_KeyUp(object sender, KeyEventArgs e)
        {
            //buscarMesero();
        }

        private void buscarMesero()
        {
            if (general.IsNumericDouble(txtCedulaMesero.Text) == true)
            {
                DataTable dtDatos = new DataTable();
                dtDatos = oMesero.BuscarUnico(txtCedulaMesero.Text);

                if (dtDatos.Rows.Count > 0)
                {
                    foreach (DataRow rows in dtDatos.Rows)
                    {
                        txtCodInternoMesero.Text = rows["Codigo"].ToString();
                        txtCedulaMesero.Text = rows["DNI"].ToString();
                        lblNomMesero.Text = "ATIENDE: " + rows["nombreapellido"].ToString();
                        txtCedulaMesero.ForeColor = Color.Black;
                    }
                }
                else
                {
                    msgError.lblMensaje.Text = "Mesero no existe";
                    msgError.ShowDialog();
                    txtCodInternoMesero.Text = "";
                    txtCedulaMesero.Text = "Buscar Mesero";
                    txtCedulaMesero.ForeColor = Color.Gray;
                    lblNomMesero.Text = "ATIENDE:";
                }
            }
        }

        private void btnBuscarMesero_Click(object sender, EventArgs e)
        {
            buscarMesero();
        }
    }
}
