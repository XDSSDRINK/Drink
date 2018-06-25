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
    public partial class AYUDA : Form
    {
        CONTROLLER.Producto producto = new CONTROLLER.Producto();
        CONTROLLER.Proveedor proveedor = new CONTROLLER.Proveedor();
        CONTROLLER.Persona persona = new CONTROLLER.Persona();
        CONTROLLER.Ventas ventas = new CONTROLLER.Ventas();
        CONTROLLER.Cliente clien = new CONTROLLER.Cliente();
        CONTROLLER.General GNR = new CONTROLLER.General();

        //Delegado 
        public delegate void EnviaProducto(string Producto);
        public event EnviaProducto EnviaProductos;

        //Delegado 
        public delegate void EnviaProveedor(string proveedor);
        public event EnviaProveedor EnviaProveedores;

        //Delegado 
        public delegate void EnviaPersona(string persona);
        public event EnviaPersona EnviaPersonas;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public string Modulo { get; set; }
        DataTable DT;
        int Contador = 0;
        int Filas = 0;
        string Dato = "";
        bool OK = true;

        //// Create a new form.
        Form mdiChildForm = new Form();

        public AYUDA()
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

        private void AYUDA_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            EstiloTabla();
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

        private void EstiloTabla()
        {
            dtgAyuda.EnableHeadersVisualStyles = false;
            dtgAyuda.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgAyuda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgAyuda.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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

        private void Limpiar()
        {
            txtBuscar.Text = "";
            dtgAyuda.Rows.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        public void CargarInformacion()
        {
            lblDetalle.Text = Modulo;

            switch (Modulo)
            {
                case "Producto":
                    CargarProductos();
                    break;
                case "Proveedor":
                    CargarProveedor();
                    break;
                case "Persona":
                    CargarPersonas();
                    break;
                case "Venta":
                    CargarProductosVenta();
                    break;
                case "Cliente":
                    CargarClientes();
                    break;
                case "DescuentoProducto":
                    CargarDescProducto();
                    break;

            }
        }

        private void CargarProductos()
        {
            dtgAyuda.Rows.Clear();
            DT = producto.CargarProducto("pd.Item", txtBuscar.Text, "Ayuda");
            if (DT.Rows.Count > 0)
            {
                dtgAyuda.Columns.Clear();

                dtgAyuda.Columns.Add("ClItem", "Item");
                dtgAyuda.Columns.Add("ClNombre", "Nombre");
                dtgAyuda.Columns.Add("ClReferencia", "Referencia");
                dtgAyuda.Columns.Add("ClDescripcion", "Descripcion");
                dtgAyuda.Columns.Add("ClIVA", "IVA");
                dtgAyuda.Columns.Add("ClStock", "Stock");
                dtgAyuda.Columns.Add("ClUnidadMedida", "Unidad medida");
                dtgAyuda.Columns.Add("ClMedida", "Medida");
                dtgAyuda.Columns.Add("ClAplicaFV", "Aplica FV.");
                dtgAyuda.Columns.Add("ClMarca", "Marca");
                dtgAyuda.Columns.Add("ClPresentacion", "Presentacion");
                dtgAyuda.Columns.Add("ClCategoria", "Categoria");
                dtgAyuda.Columns.Add("ClModoVenta", "Modo venta");
                dtgAyuda.Columns.Add("ClEstado", "Estado");
                
                Contador = 0;
                Filas = DT.Rows.Count;
                dtgAyuda.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClDescripcion"].Value = rows["Descripcion"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = rows["iva"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClStock"].Value = rows["Stock"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClUnidadMedida"].Value = rows["UnidadMedida"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClMedida"].Value = rows["Medida"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClAplicaFV"].Value = rows["AplicaFechaVencimiento"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClMarca"].Value = rows["Marca"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClPresentacion"].Value = rows["Presentacion"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCategoria"].Value = rows["Categoria"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClModoVenta"].Value = rows["ModoVenta"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = rows["Estado"].ToString();
                    Contador++;
                }
            }
            else
            {
                dtgAyuda.Rows.Clear();
                DT = producto.CargarProducto("pd.Nombre", txtBuscar.Text, "Relacionados");
                if (DT.Rows.Count > 0)
                {
                    dtgAyuda.Columns.Clear();

                    dtgAyuda.Columns.Add("ClItem", "Item");
                    dtgAyuda.Columns.Add("ClNombre", "Nombre");
                    dtgAyuda.Columns.Add("ClReferencia", "Referencia");
                    dtgAyuda.Columns.Add("ClDescripcion", "Descripcion");
                    dtgAyuda.Columns.Add("ClIVA", "IVA");
                    dtgAyuda.Columns.Add("ClStock", "Stock");
                    dtgAyuda.Columns.Add("ClUnidadMedida", "Unidad medida");
                    dtgAyuda.Columns.Add("ClMedida", "Medida");
                    dtgAyuda.Columns.Add("ClAplicaFV", "Aplica FV.");
                    dtgAyuda.Columns.Add("ClMarca", "Marca");
                    dtgAyuda.Columns.Add("ClPresentacion", "Presentacion");
                    dtgAyuda.Columns.Add("ClCategoria", "Categoria");
                    dtgAyuda.Columns.Add("ClModoVenta", "Modo venta");
                    dtgAyuda.Columns.Add("ClEstado", "Estado");

                    Contador = 0;
                    Filas = DT.Rows.Count;
                    dtgAyuda.Rows.Add(Filas);
                    foreach (DataRow rows in DT.Rows)
                    {
                        dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClDescripcion"].Value = rows["Descripcion"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = rows["iva"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClStock"].Value = rows["Stock"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClUnidadMedida"].Value = rows["UnidadMedida"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClMedida"].Value = rows["Medida"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClAplicaFV"].Value = rows["AplicaFechaVencimiento"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClMarca"].Value = rows["Marca"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClPresentacion"].Value = rows["Presentacion"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClCategoria"].Value = rows["Categoria"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClModoVenta"].Value = rows["ModoVenta"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = rows["Estado"].ToString();
                        Contador++;
                    }
                }
                else
                {
                    dtgAyuda.Rows.Clear();
                    DT = producto.CargarProducto("pd.Referencia", txtBuscar.Text, "Relacionados");
                    if (DT.Rows.Count > 0)
                    {
                        dtgAyuda.Columns.Clear();

                        dtgAyuda.Columns.Add("ClItem", "Item");
                        dtgAyuda.Columns.Add("ClNombre", "Nombre");
                        dtgAyuda.Columns.Add("ClReferencia", "Referencia");
                        dtgAyuda.Columns.Add("ClDescripcion", "Descripcion");
                        dtgAyuda.Columns.Add("ClIVA", "IVA");
                        dtgAyuda.Columns.Add("ClStock", "Stock");
                        dtgAyuda.Columns.Add("ClUnidadMedida", "Unidad medida");
                        dtgAyuda.Columns.Add("ClMedida", "Medida");
                        dtgAyuda.Columns.Add("ClAplicaFV", "Aplica FV.");
                        dtgAyuda.Columns.Add("ClMarca", "Marca");
                        dtgAyuda.Columns.Add("ClPresentacion", "Presentacion");
                        dtgAyuda.Columns.Add("ClCategoria", "Categoria");
                        dtgAyuda.Columns.Add("ClModoVenta", "Modo venta");
                        dtgAyuda.Columns.Add("ClEstado", "Estado");

                        Contador = 0;
                        Filas = DT.Rows.Count;
                        dtgAyuda.Rows.Add(Filas);
                        foreach (DataRow rows in DT.Rows)
                        {
                            dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClDescripcion"].Value = rows["Descripcion"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = rows["iva"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClStock"].Value = rows["Stock"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClUnidadMedida"].Value = rows["UnidadMedida"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClMedida"].Value = rows["Medida"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClAplicaFV"].Value = rows["AplicaFechaVencimiento"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClMarca"].Value = rows["Marca"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClPresentacion"].Value = rows["Presentacion"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClCategoria"].Value = rows["Categoria"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClModoVenta"].Value = rows["ModoVenta"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = rows["Estado"].ToString();
                            Contador++;
                        }
                    }
                }
            }
        }

        private void CargarProductosVenta()
        {
            dtgAyuda.Rows.Clear();
            DT = ventas.Cargar_producto(txtBuscar.Text);
            if (DT.Rows.Count > 0)
            {
                dtgAyuda.Columns.Clear();
                dtgAyuda.Columns.Add("ClItem", "Item");
                dtgAyuda.Columns.Add("ClCodigoProducto", "Codigo");
                dtgAyuda.Columns.Add("ClCodigoB", "Codigo Barras");
                dtgAyuda.Columns.Add("ClNombre", "Nombre");
                dtgAyuda.Columns.Add("ClReferencia", "Referencia");
                dtgAyuda.Columns.Add("ClDescripcion", "Descripcion");

                Contador = 0;
                Filas = DT.Rows.Count;
                dtgAyuda.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtgAyuda.Rows[Contador].Cells["ClCodigoProducto"].Value = rows["CodigoProducto"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCodigoB"].Value = rows["CodigoBarras"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClDescripcion"].Value = rows["Descripcion"].ToString();
                    Contador++;
                }
            }
        }

        private void CargarProveedor()
        {
            dtgAyuda.Rows.Clear();
            DT = proveedor.CargarProveedor("c.Codigo", txtBuscar.Text, "AyudaUnico");
            if (DT.Rows.Count > 0)
            {
                dtgAyuda.Columns.Clear();

                dtgAyuda.Columns.Add("ClDNI", "DNI");
                dtgAyuda.Columns.Add("ClDigitoVerficacion", "Digito verificacion");
                dtgAyuda.Columns.Add("ClTipoProveedor", "Tipo proveedor");
                dtgAyuda.Columns.Add("ClTipoDNI", "Tipo identificacion");            
                dtgAyuda.Columns.Add("ClRazonSocial", "Razon Social");
                dtgAyuda.Columns.Add("ClNombreComercial", "Nombre comercial");
                dtgAyuda.Columns.Add("ClDepartamento", "Departamento");
                dtgAyuda.Columns.Add("ClMunicipio", "Municipio");
                dtgAyuda.Columns.Add("ClBarrioVereda", "Barrio/Vereda");
                dtgAyuda.Columns.Add("ClDireccion", "Direccion");
                dtgAyuda.Columns.Add("ClTelefono", "Telefono fijo");
                dtgAyuda.Columns.Add("ClExtension", "Extension");
                dtgAyuda.Columns.Add("ClEstado", "Estado");
                dtgAyuda.Columns.Add("ClFax", "Fax");
                dtgAyuda.Columns.Add("ClCelular1", "Celular1");
                dtgAyuda.Columns.Add("ClCelular2", "Celular2");
                dtgAyuda.Columns.Add("ClEmail", "Email");
                dtgAyuda.Columns.Add("ClSitioWeb", "SitioWeb");
                dtgAyuda.Columns.Add("ClIVA", "IVA");
                dtgAyuda.Columns.Add("ClBanco", "Banco");
                dtgAyuda.Columns.Add("ClTipoCuenta", "Tipo cuenta");
                dtgAyuda.Columns.Add("ClNumeroCuenta", "Numero cuenta");

                Contador = 0;
                Filas = DT.Rows.Count;
                dtgAyuda.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgAyuda.Rows[Contador].Cells["ClDNI"].Value = row["DNI"];
                    dtgAyuda.Rows[Contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                    dtgAyuda.Rows[Contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                    dtgAyuda.Rows[Contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                    dtgAyuda.Rows[Contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                    dtgAyuda.Rows[Contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                    dtgAyuda.Rows[Contador].Cells["ClDepartamento"].Value = row["Departamento"];
                    dtgAyuda.Rows[Contador].Cells["ClMunicipio"].Value = row["Municipio"];
                    dtgAyuda.Rows[Contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                    dtgAyuda.Rows[Contador].Cells["ClDireccion"].Value = row["Direccion"];
                    dtgAyuda.Rows[Contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                    dtgAyuda.Rows[Contador].Cells["ClExtension"].Value = row["Extension"];
                    dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = row["Estado"];
                    dtgAyuda.Rows[Contador].Cells["ClFax"].Value = row["Fax"];
                    dtgAyuda.Rows[Contador].Cells["ClCelular1"].Value = row["Celular1"];
                    dtgAyuda.Rows[Contador].Cells["ClCelular2"].Value = row["Celular2"];
                    dtgAyuda.Rows[Contador].Cells["ClEmail"].Value = row["Email"];
                    dtgAyuda.Rows[Contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                    dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = row["IVA"];
                    dtgAyuda.Rows[Contador].Cells["ClBanco"].Value = row["Banco"];
                    dtgAyuda.Rows[Contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                    dtgAyuda.Rows[Contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                    Contador++;
                }
            }
            else
            {
                dtgAyuda.Rows.Clear();
                DT = proveedor.CargarProveedor("DNI", txtBuscar.Text, "AyudaUnico");
                if (DT.Rows.Count > 0)
                {
                    dtgAyuda.Columns.Clear();

                    dtgAyuda.Columns.Add("ClDNI", "DNI");
                    dtgAyuda.Columns.Add("ClDigitoVerficacion", "Digito verificacion");
                    dtgAyuda.Columns.Add("ClTipoProveedor", "Tipo proveedor");
                    dtgAyuda.Columns.Add("ClTipoDNI", "Tipo identificacion");
                    dtgAyuda.Columns.Add("ClRazonSocial", "Razon Social");
                    dtgAyuda.Columns.Add("ClNombreComercial", "Nombre comercial");
                    dtgAyuda.Columns.Add("ClDepartamento", "Departamento");
                    dtgAyuda.Columns.Add("ClMunicipio", "Municipio");
                    dtgAyuda.Columns.Add("ClBarrioVereda", "Barrio/Vereda");
                    dtgAyuda.Columns.Add("ClDireccion", "Direccion");
                    dtgAyuda.Columns.Add("ClTelefono", "Telefono fijo");
                    dtgAyuda.Columns.Add("ClExtension", "Extension");
                    dtgAyuda.Columns.Add("ClEstado", "Estado");
                    dtgAyuda.Columns.Add("ClFax", "Fax");
                    dtgAyuda.Columns.Add("ClCelular1", "Celular1");
                    dtgAyuda.Columns.Add("ClCelular2", "Celular2");
                    dtgAyuda.Columns.Add("ClEmail", "Email");
                    dtgAyuda.Columns.Add("ClSitioWeb", "SitioWeb");
                    dtgAyuda.Columns.Add("ClIVA", "IVA");
                    dtgAyuda.Columns.Add("ClBanco", "Banco");
                    dtgAyuda.Columns.Add("ClTipoCuenta", "Tipo cuenta");
                    dtgAyuda.Columns.Add("ClNumeroCuenta", "Numero cuenta");


                    Contador = 0;
                    Filas = DT.Rows.Count;
                    dtgAyuda.Rows.Add(Filas);

                    foreach (DataRow row in DT.Rows)
                    {
                        dtgAyuda.Rows[Contador].Cells["ClDNI"].Value = row["DNI"];
                        dtgAyuda.Rows[Contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                        dtgAyuda.Rows[Contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                        dtgAyuda.Rows[Contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                        dtgAyuda.Rows[Contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                        dtgAyuda.Rows[Contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                        dtgAyuda.Rows[Contador].Cells["ClDepartamento"].Value = row["Departamento"];
                        dtgAyuda.Rows[Contador].Cells["ClMunicipio"].Value = row["Municipio"];
                        dtgAyuda.Rows[Contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                        dtgAyuda.Rows[Contador].Cells["ClDireccion"].Value = row["Direccion"];
                        dtgAyuda.Rows[Contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                        dtgAyuda.Rows[Contador].Cells["ClExtension"].Value = row["Extension"];
                        dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = row["Estado"];
                        dtgAyuda.Rows[Contador].Cells["ClFax"].Value = row["Fax"];
                        dtgAyuda.Rows[Contador].Cells["ClCelular1"].Value = row["Celular1"];
                        dtgAyuda.Rows[Contador].Cells["ClCelular2"].Value = row["Celular2"];
                        dtgAyuda.Rows[Contador].Cells["ClEmail"].Value = row["Email"];
                        dtgAyuda.Rows[Contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                        dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = row["IVA"];
                        dtgAyuda.Rows[Contador].Cells["ClBanco"].Value = row["Banco"];
                        dtgAyuda.Rows[Contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                        dtgAyuda.Rows[Contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];

                        Contador++;
                    }
                }
                else
                {
                    dtgAyuda.Rows.Clear();
                    DT = proveedor.CargarProveedor("RazonSocial", txtBuscar.Text, "AyudaUnico");
                    if (DT.Rows.Count > 0)
                    {
                        dtgAyuda.Columns.Clear();

                        dtgAyuda.Columns.Add("ClDNI", "DNI");
                        dtgAyuda.Columns.Add("ClDigitoVerficacion", "Digito verificacion");
                        dtgAyuda.Columns.Add("ClTipoProveedor", "Tipo proveedor");
                        dtgAyuda.Columns.Add("ClTipoDNI", "Tipo identificacion");
                        dtgAyuda.Columns.Add("ClRazonSocial", "Razon Social");
                        dtgAyuda.Columns.Add("ClNombreComercial", "Nombre comercial");
                        dtgAyuda.Columns.Add("ClDepartamento", "Departamento");
                        dtgAyuda.Columns.Add("ClMunicipio", "Municipio");
                        dtgAyuda.Columns.Add("ClBarrioVereda", "Barrio/Vereda");
                        dtgAyuda.Columns.Add("ClDireccion", "Direccion");
                        dtgAyuda.Columns.Add("ClTelefono", "Telefono fijo");
                        dtgAyuda.Columns.Add("ClExtension", "Extension");
                        dtgAyuda.Columns.Add("ClEstado", "Estado");
                        dtgAyuda.Columns.Add("ClFax", "Fax");
                        dtgAyuda.Columns.Add("ClCelular1", "Celular1");
                        dtgAyuda.Columns.Add("ClCelular2", "Celular2");
                        dtgAyuda.Columns.Add("ClEmail", "Email");
                        dtgAyuda.Columns.Add("ClSitioWeb", "SitioWeb");
                        dtgAyuda.Columns.Add("ClIVA", "IVA");
                        dtgAyuda.Columns.Add("ClBanco", "Banco");
                        dtgAyuda.Columns.Add("ClTipoCuenta", "Tipo cuenta");
                        dtgAyuda.Columns.Add("ClNumeroCuenta", "Numero cuenta");


                        Contador = 0;
                        Filas = DT.Rows.Count;
                        dtgAyuda.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgAyuda.Rows[Contador].Cells["ClDNI"].Value = row["DNI"];
                            dtgAyuda.Rows[Contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                            dtgAyuda.Rows[Contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                            dtgAyuda.Rows[Contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                            dtgAyuda.Rows[Contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                            dtgAyuda.Rows[Contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                            dtgAyuda.Rows[Contador].Cells["ClDepartamento"].Value = row["Departamento"];
                            dtgAyuda.Rows[Contador].Cells["ClMunicipio"].Value = row["Municipio"];
                            dtgAyuda.Rows[Contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                            dtgAyuda.Rows[Contador].Cells["ClDireccion"].Value = row["Direccion"];
                            dtgAyuda.Rows[Contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                            dtgAyuda.Rows[Contador].Cells["ClExtension"].Value = row["Extension"];
                            dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = row["Estado"];
                            dtgAyuda.Rows[Contador].Cells["ClFax"].Value = row["Fax"];
                            dtgAyuda.Rows[Contador].Cells["ClCelular1"].Value = row["Celular1"];
                            dtgAyuda.Rows[Contador].Cells["ClCelular2"].Value = row["Celular2"];
                            dtgAyuda.Rows[Contador].Cells["ClEmail"].Value = row["Email"];
                            dtgAyuda.Rows[Contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                            dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = row["IVA"];
                            dtgAyuda.Rows[Contador].Cells["ClBanco"].Value = row["Banco"];
                            dtgAyuda.Rows[Contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                            dtgAyuda.Rows[Contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                            Contador++;
                        }
                    }
                    else
                    {
                        dtgAyuda.Rows.Clear();
                        DT = proveedor.CargarProveedor("NombreComercial", txtBuscar.Text, "AyudaUnico");
                        if (DT.Rows.Count > 0)
                        {
                            dtgAyuda.Columns.Clear();

                            dtgAyuda.Columns.Add("ClDNI", "DNI");
                            dtgAyuda.Columns.Add("ClDigitoVerficacion", "Digito verificacion");
                            dtgAyuda.Columns.Add("ClTipoProveedor", "Tipo proveedor");
                            dtgAyuda.Columns.Add("ClTipoDNI", "Tipo identificacion");
                            dtgAyuda.Columns.Add("ClRazonSocial", "Razon Social");
                            dtgAyuda.Columns.Add("ClNombreComercial", "Nombre comercial");
                            dtgAyuda.Columns.Add("ClDepartamento", "Departamento");
                            dtgAyuda.Columns.Add("ClMunicipio", "Municipio");
                            dtgAyuda.Columns.Add("ClBarrioVereda", "Barrio/Vereda");
                            dtgAyuda.Columns.Add("ClDireccion", "Direccion");
                            dtgAyuda.Columns.Add("ClTelefono", "Telefono fijo");
                            dtgAyuda.Columns.Add("ClExtension", "Extension");
                            dtgAyuda.Columns.Add("ClEstado", "Estado");
                            dtgAyuda.Columns.Add("ClFax", "Fax");
                            dtgAyuda.Columns.Add("ClCelular1", "Celular1");
                            dtgAyuda.Columns.Add("ClCelular2", "Celular2");
                            dtgAyuda.Columns.Add("ClEmail", "Email");
                            dtgAyuda.Columns.Add("ClSitioWeb", "SitioWeb");
                            dtgAyuda.Columns.Add("ClIVA", "IVA");
                            dtgAyuda.Columns.Add("ClBanco", "Banco");
                            dtgAyuda.Columns.Add("ClTipoCuenta", "Tipo cuenta");
                            dtgAyuda.Columns.Add("ClNumeroCuenta", "Numero cuenta");


                            Contador = 0;
                            Filas = DT.Rows.Count;
                            dtgAyuda.Rows.Add(Filas);

                            foreach (DataRow row in DT.Rows)
                            {
                                dtgAyuda.Rows[Contador].Cells["ClDNI"].Value = row["DNI"];
                                dtgAyuda.Rows[Contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                                dtgAyuda.Rows[Contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                                dtgAyuda.Rows[Contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                                dtgAyuda.Rows[Contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                                dtgAyuda.Rows[Contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                                dtgAyuda.Rows[Contador].Cells["ClDepartamento"].Value = row["Departamento"];
                                dtgAyuda.Rows[Contador].Cells["ClMunicipio"].Value = row["Municipio"];
                                dtgAyuda.Rows[Contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                                dtgAyuda.Rows[Contador].Cells["ClDireccion"].Value = row["Direccion"];
                                dtgAyuda.Rows[Contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                                dtgAyuda.Rows[Contador].Cells["ClExtension"].Value = row["Extension"];
                                dtgAyuda.Rows[Contador].Cells["ClEstado"].Value = row["Estado"];
                                dtgAyuda.Rows[Contador].Cells["ClFax"].Value = row["Fax"];
                                dtgAyuda.Rows[Contador].Cells["ClCelular1"].Value = row["Celular1"];
                                dtgAyuda.Rows[Contador].Cells["ClCelular2"].Value = row["Celular2"];
                                dtgAyuda.Rows[Contador].Cells["ClEmail"].Value = row["Email"];
                                dtgAyuda.Rows[Contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                                dtgAyuda.Rows[Contador].Cells["ClIVA"].Value = row["IVA"];
                                dtgAyuda.Rows[Contador].Cells["ClBanco"].Value = row["Banco"];
                                dtgAyuda.Rows[Contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                                dtgAyuda.Rows[Contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                                Contador++;
                            }
                        }
                    }
                }
            }
        }

        private void CargarPersonas()
        {
            DT = persona.Buscar(txtBuscar.Text);
            dtgAyuda.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                dtgAyuda.Columns.Clear();
                dtgAyuda.Columns.Add("ClDNI", "DNI");
                dtgAyuda.Columns.Add("ClCodigo", "Codigo");
                dtgAyuda.Columns.Add("ClTipoIdentificacion", "Tipo Identificacion");
                dtgAyuda.Columns.Add("ClNombres", "Nombres");
                dtgAyuda.Columns.Add("ClApellidos", "Apellidos");
                dtgAyuda.Columns.Add("ClCodigoDepartamento", "Codigo Departamento");
                dtgAyuda.Columns.Add("ClDepartamento", "Departamento");
                dtgAyuda.Columns.Add("ClCodigoMunicipio", "Codigo Municipio");
                dtgAyuda.Columns.Add("ClMunicipio", "Municipio");
                dtgAyuda.Columns.Add("ClBarrioVereda", "Barrio Vereda");
                dtgAyuda.Columns.Add("ClDireccion", "Direccion");
                dtgAyuda.Columns.Add("ClTelefonoFijo", "Telefono Fijo");
                dtgAyuda.Columns.Add("ClEmail", "Email");
                dtgAyuda.Columns.Add("ClCelular", "Celular");

                Contador = 0;
                Filas = 0;
                Filas = DT.Rows.Count;
                dtgAyuda.Rows.Add(Filas);

                foreach (DataRow rows in DT.Rows)
                {
                    dtgAyuda.Rows[Contador].Cells["ClDNI"].Value = rows["DNI"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCodigo"].Value = rows["Codigo"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClTipoIdentificacion"].Value = rows["TipoIdentificacion"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClNombres"].Value = rows["Nombres"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClApellidos"].Value = rows["Apellidos"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCodigoDepartamento"].Value = rows["CodigoDepartamento"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClDepartamento"].Value = rows["Departamento"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCodigoMunicipio"].Value = rows["CodigoMunicipio"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCodigoMunicipio"].Value = rows["Municipio"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClBarrioVereda"].Value = rows["BarrioVereda"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClDireccion"].Value = rows["Direccion"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClTelefonoFijo"].Value = rows["TelefonoFijo"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClEmail"].Value = rows["Email"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCelular"].Value = rows["Celular"].ToString();
                    Contador++;
                }
            }
        }

        private void CargarClientes()
        {
                errorProvider1.Clear();
                dtgAyuda.Rows.Clear();

            if (txtBuscar.Text.Trim() != "")
            {
                OK = GNR.IsNumericDouble(txtBuscar.Text);
                if (OK)
                {
                    DT = clien.CargarActivos(txtBuscar.Text);
                }
                else
                {
                    errorProvider1.SetError(txtBuscar, "DNI debe ser un valor numerico");
                }
            }
            else
            {
                DT = clien.CargarActivos(txtBuscar.Text);
            }

            if (DT.Rows.Count > 0)
            {
                dtgAyuda.Columns.Clear();
                dtgAyuda.Columns.Add("ClDNI", "DNI");
                dtgAyuda.Columns.Add("CLDgv", "Dg V");
                dtgAyuda.Columns.Add("ClTipoIdenti", "Tipo identificacion");
                dtgAyuda.Columns.Add("ClTipoPer", "Tipo persona");
                dtgAyuda.Columns.Add("ClRazonSo", "Razon social");
                dtgAyuda.Columns.Add("ClNombreCom", "Nombre comercial");

                Contador = 0;
                Filas = DT.Rows.Count;
                dtgAyuda.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtgAyuda.Rows[Contador].Cells["ClDNI"].Value = rows["DNI"].ToString();
                    dtgAyuda.Rows[Contador].Cells["CLDgv"].Value = rows["DigitoVerificacion"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClTipoIdenti"].Value = rows["TipoIdentificacion"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClTipoPer"].Value = rows["TipoPersona"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClRazonSo"].Value = rows["RazonSocial"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClNombreCom"].Value = rows["NombreComercial"].ToString();
                    Contador++;
                }
            }

            DT.Clear();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CargarInformacion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void dtgAyuda_DoubleClick(object sender, EventArgs e)
        {
            Filas = dtgAyuda.CurrentRow.Index;
            Dato = dtgAyuda[0, Filas].Value.ToString();

            switch (Modulo)
            {
                case "Producto":
                    EnviaProductos(Dato);
                    break;
                case "Proveedor":
                    EnviaProveedores(Dato);
                    break;
                case "Persona":
                    EnviaPersonas(Dato);
                    break;
                case "Venta":
                    EnviaProductos(Dato);
                    break;
                case "Cliente":
                    EnviaPersonas(Dato);
                    break;
                case "DescuentoProducto":
                    EnviaProductos(Dato);
                    break;
            }
            Limpiar();
            this.Close();
        }

        private void CargarDescProducto()
        {
            errorProvider1.Clear();
            dtgAyuda.Rows.Clear();

            DT = producto.CargarProductosDescuento("Item", txtBuscar.Text);
            if (DT.Rows.Count > 0)
            {
                dtgAyuda.Columns.Clear();

                dtgAyuda.Columns.Add("ClItem", "Item");
                dtgAyuda.Columns.Add("ClCodigoBarras", "Codigo barras");
                dtgAyuda.Columns.Add("ClNombre", "Nombre");

                Contador = 0;
                Filas = DT.Rows.Count;
                dtgAyuda.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["CodigoBarras"].ToString();
                    dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();               
                    
                    Contador++;
                }
            }
            else
            {
                DT = producto.CargarProductosDescuento("CodigoBarras", txtBuscar.Text);
                if (DT.Rows.Count > 0)
                {
                    dtgAyuda.Columns.Clear();

                    dtgAyuda.Columns.Add("ClItem", "Item");
                    dtgAyuda.Columns.Add("ClCodigoBarras", "Codigo barras");
                    dtgAyuda.Columns.Add("ClNombre", "Nombre");

                    Contador = 0;
                    Filas = DT.Rows.Count;
                    dtgAyuda.Rows.Add(Filas);
                    foreach (DataRow rows in DT.Rows)
                    {
                        dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["CodigoBarras"].ToString();
                        dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();

                        Contador++;
                    }
                }
                else
                {
                    DT = producto.CargarProductosDescuento("Nombre", txtBuscar.Text);
                    if (DT.Rows.Count > 0)
                    {
                        dtgAyuda.Columns.Clear();

                        dtgAyuda.Columns.Add("ClItem", "Item");
                        dtgAyuda.Columns.Add("ClCodigoBarras", "Codigo barras");
                        dtgAyuda.Columns.Add("ClNombre", "Nombre");

                        Contador = 0;
                        Filas = DT.Rows.Count;
                        dtgAyuda.Rows.Add(Filas);
                        foreach (DataRow rows in DT.Rows)
                        {
                            dtgAyuda.Rows[Contador].Cells["ClItem"].Value = rows["Item"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["CodigoBarras"].ToString();
                            dtgAyuda.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"].ToString();

                            Contador++;
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtBuscar,"Ingrese Item o Codigo de barras o Nombre");
                    }
                }
            }
        }
    }
}
