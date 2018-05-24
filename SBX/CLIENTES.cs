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
    public partial class CLIENTES : Form
    {
        CONTROLLER.Cliente cliente = new CONTROLLER.Cliente();
        DETALLE_CLIENTES dETALLE_CLIENTES = new DETALLE_CLIENTES();
        CARGANDO cARGANDO = new CARGANDO();

        public string NombreUsuario { get; set; }
        bool AutorizaModificar = false;
        DataTable DT;
        int contador = 0;
        int Filas = 0;

        public CLIENTES()
        {
            InitializeComponent();
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            cargarClientes();
            ValidacionPermisos();
        }

        public void cargarClientes()
        {
            DT = null;
            contador = 0;

            DT = cliente.Cargar("", "", "");
            dtgClientes.Rows.Clear();

            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgClientes.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgClientes.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                    dtgClientes.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                    dtgClientes.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                    dtgClientes.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                    dtgClientes.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                    dtgClientes.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                    dtgClientes.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                    dtgClientes.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                    dtgClientes.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                    dtgClientes.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                    dtgClientes.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                    dtgClientes.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                    dtgClientes.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                    dtgClientes.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                    dtgClientes.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                    if (row["Estado"].ToString() == "1")
                    {
                        dtgClientes.Rows[contador].Cells["ClEstado"].Value = "Activo";
                    }
                    else
                    {
                        dtgClientes.Rows[contador].Cells["ClEstado"].Value = "Inactivo";
                    }
                    dtgClientes.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                    dtgClientes.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                    dtgClientes.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                    dtgClientes.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                    dtgClientes.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                    dtgClientes.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                    dtgClientes.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                    dtgClientes.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                    dtgClientes.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                    contador++;
                }
            }
        }

        private void EstiloTabla()
        {
            dtgClientes.EnableHeadersVisualStyles = false;
            dtgClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void ValidacionPermisos()
        {
            DT = cliente.CargarPermisos(NombreUsuario, "Clientes");
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow permisos in DT.Rows)
                {
                    switch (permisos["Nombre"])
                    {
                        case "CREATE":
                            btnAgregar.Enabled = true;
                            break;
                        case "UPDATE":
                            AutorizaModificar = true;
                            break;
                        case "DELETE":
                            btnEliminar.Enabled = true;
                            break;
                    }
                }
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar cliente")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar cliente";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void Buscar()
        {
            dtgClientes.Rows.Clear();
            DT = cliente.Cargar("c.Codigo", txtBuscar.Text, "Relacionados");
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgClientes.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgClientes.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                    dtgClientes.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                    dtgClientes.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                    dtgClientes.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                    dtgClientes.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                    dtgClientes.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                    dtgClientes.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                    dtgClientes.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                    dtgClientes.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                    dtgClientes.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                    dtgClientes.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                    dtgClientes.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                    dtgClientes.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                    dtgClientes.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                    dtgClientes.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                    dtgClientes.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                    dtgClientes.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                    dtgClientes.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                    dtgClientes.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                    dtgClientes.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                    dtgClientes.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                    dtgClientes.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                    dtgClientes.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                    dtgClientes.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                    dtgClientes.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                    contador++;
                }
            }
            else
            {
                dtgClientes.Rows.Clear();
                DT = cliente.Cargar("DNI", txtBuscar.Text, "Relacionados");
                if (DT.Rows.Count > 0)
                {
                    contador = 0;
                    Filas = DT.Rows.Count;
                    dtgClientes.Rows.Add(Filas);

                    foreach (DataRow row in DT.Rows)
                    {
                        dtgClientes.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                        dtgClientes.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                        dtgClientes.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                        dtgClientes.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                        dtgClientes.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                        dtgClientes.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                        dtgClientes.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                        dtgClientes.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                        dtgClientes.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                        dtgClientes.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                        dtgClientes.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                        dtgClientes.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                        dtgClientes.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                        dtgClientes.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                        dtgClientes.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                        dtgClientes.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                        dtgClientes.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                        dtgClientes.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                        dtgClientes.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                        dtgClientes.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                        dtgClientes.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                        dtgClientes.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                        dtgClientes.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                        dtgClientes.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                        dtgClientes.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                        contador++;
                    }
                }
                else
                {
                    dtgClientes.Rows.Clear();
                    DT = cliente.Cargar("RazonSocial", txtBuscar.Text, "Relacionados");
                    if (DT.Rows.Count > 0)
                    {
                        contador = 0;
                        Filas = DT.Rows.Count;
                        dtgClientes.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgClientes.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                            dtgClientes.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                            dtgClientes.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                            dtgClientes.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                            dtgClientes.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                            dtgClientes.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                            dtgClientes.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                            dtgClientes.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                            dtgClientes.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                            dtgClientes.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                            dtgClientes.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                            dtgClientes.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                            dtgClientes.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                            dtgClientes.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                            dtgClientes.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                            dtgClientes.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                            dtgClientes.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                            dtgClientes.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                            dtgClientes.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                            dtgClientes.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                            dtgClientes.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                            dtgClientes.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                            dtgClientes.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                            dtgClientes.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                            dtgClientes.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                            contador++;
                        }
                    }
                    else
                    {
                        dtgClientes.Rows.Clear();
                        DT = cliente.Cargar("NombreComercial", txtBuscar.Text, "Relacionados");
                        if (DT.Rows.Count > 0)
                        {
                            contador = 0;
                            Filas = DT.Rows.Count;
                            dtgClientes.Rows.Add(Filas);

                            foreach (DataRow row in DT.Rows)
                            {
                                dtgClientes.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                                dtgClientes.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                                dtgClientes.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                                dtgClientes.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                                dtgClientes.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                                dtgClientes.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                                dtgClientes.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                                dtgClientes.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                                dtgClientes.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                                dtgClientes.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                                dtgClientes.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                                dtgClientes.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                                dtgClientes.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                                dtgClientes.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                                dtgClientes.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                                dtgClientes.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                                dtgClientes.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                                dtgClientes.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                                dtgClientes.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                                dtgClientes.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                                dtgClientes.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                                dtgClientes.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                                dtgClientes.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                                dtgClientes.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                                dtgClientes.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                                contador++;
                            }
                        }
                    }
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dETALLE_CLIENTES.Agregar = true;
            dETALLE_CLIENTES.NombreUsuario = this.NombreUsuario;
            dETALLE_CLIENTES.AgregarCliente += new DETALLE_CLIENTES.AgregaClientes(cargarClientes);
            dETALLE_CLIENTES.ShowDialog();
        }

        private void DetalleProveedor()
        {
            foreach (DataGridViewRow rows in dtgClientes.SelectedRows)
            {
                dETALLE_CLIENTES.txtDNI.Text = rows.Cells["ClDNI"].Value.ToString();
                dETALLE_CLIENTES.txtDigitoV.Text = rows.Cells["ClDigitoVerficacion"].Value.ToString();
                dETALLE_CLIENTES.TipoProveedor = rows.Cells["ClTipoProveedor"].Value.ToString();
                dETALLE_CLIENTES.TipoIdentificacion = rows.Cells["ClTipoDNI"].Value.ToString();
                dETALLE_CLIENTES.txtRazonSocial.Text = rows.Cells["ClRazonSocial"].Value.ToString();
                dETALLE_CLIENTES.txtNombreComercial.Text = rows.Cells["ClNombreComercial"].Value.ToString();
                dETALLE_CLIENTES.Departamento = rows.Cells["ClDepartamento"].Value.ToString();
                dETALLE_CLIENTES.Municipio = rows.Cells["ClMunicipio"].Value.ToString();
                dETALLE_CLIENTES.txtBarrioVereda.Text = rows.Cells["ClBarrioVereda"].Value.ToString();
                dETALLE_CLIENTES.txtDireccion.Text = rows.Cells["ClDireccion"].Value.ToString();
                dETALLE_CLIENTES.txtTelefono.Text = rows.Cells["ClTelefono"].Value.ToString();
                dETALLE_CLIENTES.txtExt.Text = rows.Cells["ClExtension"].Value.ToString();
                dETALLE_CLIENTES.Estado = rows.Cells["ClEstado"].Value.ToString();
                dETALLE_CLIENTES.txtFax.Text = rows.Cells["ClFax"].Value.ToString();
                dETALLE_CLIENTES.txtCelular1.Text = rows.Cells["ClCelular1"].Value.ToString();
                dETALLE_CLIENTES.txtCelular2.Text = rows.Cells["ClCelular2"].Value.ToString();
                dETALLE_CLIENTES.txtEmail.Text = rows.Cells["ClEmail"].Value.ToString();
                dETALLE_CLIENTES.txtSitioWeb.Text = rows.Cells["ClSitioWeb"].Value.ToString();
                dETALLE_CLIENTES.IVA = rows.Cells["ClIVA"].Value.ToString();
                dETALLE_CLIENTES.Banco = rows.Cells["ClBanco"].Value.ToString();
                dETALLE_CLIENTES.TipoCuenta = rows.Cells["ClTipoCuenta"].Value.ToString();
                dETALLE_CLIENTES.txtCuenta.Text = rows.Cells["ClNumeroCuenta"].Value.ToString();
            }
        }

        private void dtgClientes_DoubleClick(object sender, EventArgs e)
        {
            if (AutorizaModificar == true)
            {
                dETALLE_CLIENTES.Agregar = false;
                DetalleProveedor();
                dETALLE_CLIENTES.NombreUsuario = this.NombreUsuario;
                dETALLE_CLIENTES.AgregarCliente += new DETALLE_CLIENTES.AgregaClientes(cargarClientes);
                dETALLE_CLIENTES.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExportaExcel()
        {
            cARGANDO.Show();

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            cARGANDO.Progreso(20);

            foreach (DataGridViewColumn columna in dtgClientes.Columns)
            {
                if (columna.Visible == true)
                {
                    IndiceColumna++;
                    Excel.Cells[1, IndiceColumna] = columna.HeaderText;
                }
            }
            cARGANDO.Progreso(70);
            int IndiceFila = 0;

            foreach (DataGridViewRow Row in dtgClientes.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn Columna in dtgClientes.Columns)
                {
                    if (Columna.Visible == true)
                    {
                        IndiceColumna++;
                        Excel.Cells[IndiceFila + 1, IndiceColumna] = Row.Cells[Columna.Name].Value;
                    }
                }
            }
            cARGANDO.Progreso(100);
            cARGANDO.Hide();

            Excel.Visible = true;

        }

        private void btnExportaraExcel_Click(object sender, EventArgs e)
        {
            ExportaExcel();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }
    }
}
