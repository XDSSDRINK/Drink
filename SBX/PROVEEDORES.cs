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
    public partial class PROVEEDORES : Form
    {
        DETALLE_PROVEEDOR dETALLE_PROVEEDOR = new DETALLE_PROVEEDOR();
        CONTROLLER.Proveedor proveedor = new CONTROLLER.Proveedor();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        CARGANDO cARGANDO = new CARGANDO();
        public string NombreUsuario { get; set; }
        bool AutorizaModificar = false;
        DataTable DT;
        int contador = 0;
        int Filas = 0;

        public PROVEEDORES()
        {
            InitializeComponent();
        }

        private void PROVEEDORES_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            cargarProveedores();
            ValidacionPermisos();
        }

        public void cargarProveedores()
        {
            DT = null;
            contador = 0;

            DT = proveedor.CargarProveedor("", "", "");
            dtgProveedores.Rows.Clear();

            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgProveedores.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgProveedores.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                    dtgProveedores.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                    dtgProveedores.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                    dtgProveedores.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                    dtgProveedores.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                    dtgProveedores.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                    dtgProveedores.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                    dtgProveedores.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                    dtgProveedores.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                    dtgProveedores.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                    dtgProveedores.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                    dtgProveedores.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                    dtgProveedores.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                    dtgProveedores.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                    dtgProveedores.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                    if (row["Estado"].ToString() == "1")
                    {
                        dtgProveedores.Rows[contador].Cells["ClEstado"].Value = "Activo";
                    }
                    else
                    {
                        dtgProveedores.Rows[contador].Cells["ClEstado"].Value = "Inactivo";
                    }
                    dtgProveedores.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                    dtgProveedores.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                    dtgProveedores.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                    dtgProveedores.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                    dtgProveedores.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                    dtgProveedores.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                    dtgProveedores.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                    dtgProveedores.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                    dtgProveedores.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                    contador++;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dETALLE_PROVEEDOR.Agregar = true;
            dETALLE_PROVEEDOR.NombreUsuario = this.NombreUsuario;
            dETALLE_PROVEEDOR.AgregarProveedor += new DETALLE_PROVEEDOR.AgregaProveedores(cargarProveedores);
            dETALLE_PROVEEDOR.ShowDialog();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar proveedor")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar proveedor";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EstiloTabla()
        {
            dtgProveedores.EnableHeadersVisualStyles = false;
            dtgProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void DetalleProveedor()
        {
            foreach (DataGridViewRow rows in dtgProveedores.SelectedRows)
            {
                dETALLE_PROVEEDOR.txtCodigo.Text = rows.Cells["ClCodigo"].Value.ToString();
                dETALLE_PROVEEDOR.txtDNI.Text = rows.Cells["ClDNI"].Value.ToString();
                dETALLE_PROVEEDOR.txtDigitoV.Text = rows.Cells["ClDigitoVerficacion"].Value.ToString();
                dETALLE_PROVEEDOR.TipoProveedor = rows.Cells["ClTipoProveedor"].Value.ToString();
                dETALLE_PROVEEDOR.TipoIdentificacion = rows.Cells["ClTipoDNI"].Value.ToString();
                dETALLE_PROVEEDOR.txtRazonSocial.Text = rows.Cells["ClRazonSocial"].Value.ToString();
                dETALLE_PROVEEDOR.txtNombreComercial.Text = rows.Cells["ClNombreComercial"].Value.ToString();
                dETALLE_PROVEEDOR.Departamento = rows.Cells["ClDepartamento"].Value.ToString();
                dETALLE_PROVEEDOR.Municipio = rows.Cells["ClMunicipio"].Value.ToString();
                dETALLE_PROVEEDOR.txtBarrioVereda.Text = rows.Cells["ClBarrioVereda"].Value.ToString();
                dETALLE_PROVEEDOR.txtDireccion.Text = rows.Cells["ClDireccion"].Value.ToString();
                dETALLE_PROVEEDOR.txtTelefono.Text = rows.Cells["ClTelefono"].Value.ToString();
                dETALLE_PROVEEDOR.txtExt.Text = rows.Cells["ClExtension"].Value.ToString();
                dETALLE_PROVEEDOR.Estado = rows.Cells["ClEstado"].Value.ToString();
                dETALLE_PROVEEDOR.txtFax.Text = rows.Cells["ClFax"].Value.ToString();
                dETALLE_PROVEEDOR.txtCelular1.Text = rows.Cells["ClCelular1"].Value.ToString();
                dETALLE_PROVEEDOR.txtCelular2.Text = rows.Cells["ClCelular2"].Value.ToString();
                dETALLE_PROVEEDOR.txtEmail.Text = rows.Cells["ClEmail"].Value.ToString();
                dETALLE_PROVEEDOR.txtSitioWeb.Text = rows.Cells["ClSitioWeb"].Value.ToString();
                dETALLE_PROVEEDOR.IVA = rows.Cells["ClIVA"].Value.ToString();
                dETALLE_PROVEEDOR.Banco = rows.Cells["ClBanco"].Value.ToString();
                dETALLE_PROVEEDOR.TipoCuenta = rows.Cells["ClTipoCuenta"].Value.ToString();
                dETALLE_PROVEEDOR.txtCuenta.Text = rows.Cells["ClNumeroCuenta"].Value.ToString();
            }
        }

        private void dtgProveedores_DoubleClick(object sender, EventArgs e)
        {
            if (AutorizaModificar == true)
            {
                dETALLE_PROVEEDOR.Agregar = false;
                DetalleProveedor();
                dETALLE_PROVEEDOR.NombreUsuario = this.NombreUsuario;
                dETALLE_PROVEEDOR.AgregarProveedor += new DETALLE_PROVEEDOR.AgregaProveedores(cargarProveedores);
                dETALLE_PROVEEDOR.ShowDialog();
            }
        }

        private void Eliminar()
        {
            List<string> Codigos = new List<string>();

            foreach (DataGridViewRow rows in dtgProveedores.SelectedRows)
            {
                Codigos.Add(rows.Cells["ClCodigo"].Value.ToString());
            }

            mENSAJE_CONFIRMACION.Proveedores = Codigos;
            mENSAJE_CONFIRMACION.ActualizarProveedores += new MENSAJE_CONFIRMACION.RecargaProveedores(cargarProveedores);
            mENSAJE_CONFIRMACION.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mENSAJE_CONFIRMACION.Modulo = "Proveedor";
            Eliminar();
        }

        private void ExportaExcel()
        {
            cARGANDO.Show();

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            cARGANDO.Progreso(20);

            foreach (DataGridViewColumn columna in dtgProveedores.Columns)
            {
                if (columna.Visible == true)
                {
                    IndiceColumna++;
                    Excel.Cells[1, IndiceColumna] = columna.HeaderText;
                }
            }
            cARGANDO.Progreso(70);
            int IndiceFila = 0;

            foreach (DataGridViewRow Row in dtgProveedores.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn Columna in dtgProveedores.Columns)
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

        private void Buscar()
        {
            dtgProveedores.Rows.Clear();
            DT = proveedor.CargarProveedor("c.Codigo", txtBuscar.Text, "Relacionados");
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgProveedores.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgProveedores.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                    dtgProveedores.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                    dtgProveedores.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                    dtgProveedores.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                    dtgProveedores.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                    dtgProveedores.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                    dtgProveedores.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                    dtgProveedores.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                    dtgProveedores.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                    dtgProveedores.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                    dtgProveedores.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                    dtgProveedores.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                    dtgProveedores.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                    dtgProveedores.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                    dtgProveedores.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                    dtgProveedores.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                    dtgProveedores.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                    dtgProveedores.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                    dtgProveedores.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                    dtgProveedores.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                    dtgProveedores.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                    dtgProveedores.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                    dtgProveedores.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                    dtgProveedores.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                    dtgProveedores.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                    contador++;
                }
            }
            else
            {
                dtgProveedores.Rows.Clear();
                DT = proveedor.CargarProveedor("DNI", txtBuscar.Text, "Relacionados");
                if (DT.Rows.Count > 0)
                {
                    contador = 0;
                    Filas = DT.Rows.Count;
                    dtgProveedores.Rows.Add(Filas);

                    foreach (DataRow row in DT.Rows)
                    {
                        dtgProveedores.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                        dtgProveedores.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                        dtgProveedores.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                        dtgProveedores.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                        dtgProveedores.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                        dtgProveedores.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                        dtgProveedores.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                        dtgProveedores.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                        dtgProveedores.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                        dtgProveedores.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                        dtgProveedores.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                        dtgProveedores.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                        dtgProveedores.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                        dtgProveedores.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                        dtgProveedores.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                        dtgProveedores.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                        dtgProveedores.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                        dtgProveedores.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                        dtgProveedores.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                        dtgProveedores.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                        dtgProveedores.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                        dtgProveedores.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                        dtgProveedores.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                        dtgProveedores.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                        dtgProveedores.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                        contador++;
                    }
                }
                else
                {
                    dtgProveedores.Rows.Clear();
                    DT = proveedor.CargarProveedor("RazonSocial", txtBuscar.Text, "Relacionados");
                    if (DT.Rows.Count > 0)
                    {
                        contador = 0;
                        Filas = DT.Rows.Count;
                        dtgProveedores.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgProveedores.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                            dtgProveedores.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                            dtgProveedores.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                            dtgProveedores.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                            dtgProveedores.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                            dtgProveedores.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                            dtgProveedores.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                            dtgProveedores.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                            dtgProveedores.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                            dtgProveedores.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                            dtgProveedores.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                            dtgProveedores.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                            dtgProveedores.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                            dtgProveedores.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                            dtgProveedores.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                            dtgProveedores.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                            dtgProveedores.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                            dtgProveedores.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                            dtgProveedores.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                            dtgProveedores.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                            dtgProveedores.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                            dtgProveedores.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                            dtgProveedores.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                            dtgProveedores.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                            dtgProveedores.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
                            contador++;
                        }
                    }
                    else
                    {
                        dtgProveedores.Rows.Clear();
                        DT = proveedor.CargarProveedor("NombreComercial", txtBuscar.Text, "Relacionados");
                        if (DT.Rows.Count > 0)
                        {
                            contador = 0;
                            Filas = DT.Rows.Count;
                            dtgProveedores.Rows.Add(Filas);

                            foreach (DataRow row in DT.Rows)
                            {
                                dtgProveedores.Rows[contador].Cells["ClCodigo"].Value = row["Codigo"];
                                dtgProveedores.Rows[contador].Cells["ClDNI"].Value = row["DNI"];
                                dtgProveedores.Rows[contador].Cells["ClDigitoVerficacion"].Value = row["DigitoVerificacion"];
                                dtgProveedores.Rows[contador].Cells["ClTipoProveedor"].Value = row["TipoPersona"];
                                dtgProveedores.Rows[contador].Cells["ClTipoDNI"].Value = row["TipoIdentificacion"];
                                dtgProveedores.Rows[contador].Cells["ClRazonSocial"].Value = row["RazonSocial"];
                                dtgProveedores.Rows[contador].Cells["ClNombreComercial"].Value = row["NombreComercial"];
                                dtgProveedores.Rows[contador].Cells["ClNombres"].Value = row["Nombres"];
                                dtgProveedores.Rows[contador].Cells["ClApellidos"].Value = row["Apellidos"];
                                dtgProveedores.Rows[contador].Cells["ClDepartamento"].Value = row["Departamento"];
                                dtgProveedores.Rows[contador].Cells["ClMunicipio"].Value = row["Municipio"];
                                dtgProveedores.Rows[contador].Cells["ClBarrioVereda"].Value = row["BarrioVereda"];
                                dtgProveedores.Rows[contador].Cells["ClDireccion"].Value = row["Direccion"];
                                dtgProveedores.Rows[contador].Cells["ClTelefono"].Value = row["TelefonoFijo"];
                                dtgProveedores.Rows[contador].Cells["ClExtension"].Value = row["Extension"];
                                dtgProveedores.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                                dtgProveedores.Rows[contador].Cells["ClFax"].Value = row["Fax"];
                                dtgProveedores.Rows[contador].Cells["ClCelular1"].Value = row["Celular1"];
                                dtgProveedores.Rows[contador].Cells["ClCelular2"].Value = row["Celular2"];
                                dtgProveedores.Rows[contador].Cells["ClEmail"].Value = row["Email"];
                                dtgProveedores.Rows[contador].Cells["ClSitioWeb"].Value = row["SitioWeb"];
                                dtgProveedores.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                                dtgProveedores.Rows[contador].Cells["ClBanco"].Value = row["Banco"];
                                dtgProveedores.Rows[contador].Cells["ClTipoCuenta"].Value = row["TipoCuenta"];
                                dtgProveedores.Rows[contador].Cells["ClNumeroCuenta"].Value = row["NumeroCuenta"];
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ValidacionPermisos()
        {
            DT = proveedor.CargarPermisos(NombreUsuario, "Proveedores");
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow permisos in DT.Rows)
                {
                    switch (permisos["Nombre"].ToString())
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
    }
}
