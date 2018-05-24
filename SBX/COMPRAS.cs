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
    public partial class COMPRAS : Form
    {
        CONTROLLER.Compras compras = new CONTROLLER.Compras();
        REGISTRO_COMPRAS REGISTRO_COMPRA = new REGISTRO_COMPRAS();
        CONTROLLER.Producto producto = new CONTROLLER.Producto();
        CONTROLLER.Proveedor proveedor = new CONTROLLER.Proveedor();
        DETALLE_COMPRAS dETALLE_COMPRAS = new DETALLE_COMPRAS();
        CONTROLLER.Bodega bodega = new CONTROLLER.Bodega();

        DataTable DT;
        DataTable DT2;
        DataRow Rows;
        int contador = 0;
        int Filas = 0;
        double Costo = 0;
        double Margen = 0;
        public string NombreUsuario { get; set; }

        public COMPRAS()
        {
            InitializeComponent();
            cbxDocumento.SelectedIndex = 0;
            dtpkFechaIni.Value = DateTime.Today.AddMonths(-1);
        }

        private void COMPRAS_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            CargarCompras();
            FechaFinal();
        }

        private void EstiloTabla()
        {
            dtgCompras.EnableHeadersVisualStyles = false;
            dtgCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarCompras()
        {
            dtgCompras.Rows.Clear();
            DT = compras.CargarTodo();
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgCompras.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgCompras.Rows[contador].Cells["ClID"].Value = row["ID"];
                    dtgCompras.Rows[contador].Cells["ClDocumento"].Value = row["Documento"];
                    dtgCompras.Rows[contador].Cells["ClNombreDocumento"].Value = row["NombreDocumento"];
                    dtgCompras.Rows[contador].Cells["ClConsecutivoDocumento"].Value = row["ConsecutivoDocumento"];
                    dtgCompras.Rows[contador].Cells["ClCodigoProducto"].Value = row["CodigoProducto"];
                    DT2 = producto.CargarProducto(" pd.ID", row["CodigoProducto"].ToString(),"Unico");
                    Rows = DT2.Rows[0];
                    dtgCompras.Rows[contador].Cells["ClItemPorducto"].Value = Rows["Item"].ToString();
                    dtgCompras.Rows[contador].Cells["ClNombreProducto"].Value = Rows["Nombre"].ToString();
                    dtgCompras.Rows[contador].Cells["ClCodigoProveedor"].Value = row["CodigoProveedor"];
                    DT2 = proveedor.CargarProveedor("c.Codigo", row["CodigoProveedor"].ToString(), "Unico");
                    Rows = DT2.Rows[0];
                    dtgCompras.Rows[contador].Cells["ClDNIProveedor"].Value = Rows["DNI"].ToString();
                    dtgCompras.Rows[contador].Cells["ClDigitoVerificacion"].Value = Rows["DigitoVerificacion"].ToString();
                    dtgCompras.Rows[contador].Cells["ClRazonSocialProveedor"].Value = Rows["RazonSocial"].ToString();
                    dtgCompras.Rows[contador].Cells["ClNombreComercialProveedor"].Value = Rows["NombreComercial"].ToString();
                    dtgCompras.Rows[contador].Cells["ClCantidad"].Value = row["Cantidad"];
                    dtgCompras.Rows[contador].Cells["ClDescripcionCantidad"].Value = row["DescripcionCantidad"];
                    Costo = Convert.ToDouble(row["Costo"]);
                    dtgCompras.Rows[contador].Cells["ClCosto"].Value = Costo.ToString("N");
                    Margen = Convert.ToDouble(row["Margen"]);
                    dtgCompras.Rows[contador].Cells["ClMargen"].Value = Margen.ToString("N");
                    dtgCompras.Rows[contador].Cells["ClIVAProducto"].Value = row["IVA"];
                    dtgCompras.Rows[contador].Cells["CLGeneraIVAProducto"].Value = row["GeneraIVA"];
                    dtgCompras.Rows[contador].Cells["ClFechaVence"].Value = row["FechaVencimiento"];
                    dtgCompras.Rows[contador].Cells["CLLote"].Value = row["Lote"];
                    dtgCompras.Rows[contador].Cells["ClSerial"].Value = row["Serial"];
                    dtgCompras.Rows[contador].Cells["ClCodigoBarras"].Value = row["CodigoBarras"];
                    dtgCompras.Rows[contador].Cells["ClFechaRegistro"].Value = row["FechaRegistro"];
                    dtgCompras.Rows[contador].Cells["ClHoraRegistro"].Value = row["HoraRegistro"];
                    //Consulta Nombre Bodega
                    DT = bodega.CargarBodega(true);
                    foreach (DataRow bog in DT.Rows)
                    {
                        if (row["Bodega"].ToString() == bog["ID"].ToString())
                        {
                            dtgCompras.Rows[contador].Cells["ClBodegas"].Value = bog["Nombre"].ToString();
                        }
                    }

                    contador++;
                }
            }
        }

        private void Buscars()
        {
            dtgCompras.Rows.Clear();

            if (txtNombreDoc.Text != "Nombre Doc" && txtConsecutivoDoc.Text != "Consecutivo Doc")
            {
                DT = compras.CargarCompra(cbxDocumento.Text, txtNombreDoc.Text, txtConsecutivoDoc.Text, dtpkFechaIni.Text, dtpkFechaFinal.Text, "Completo");
            }
            else if (txtNombreDoc.Text != "Nombre Doc" || txtConsecutivoDoc.Text != "Consecutivo Doc")
            {
                if (txtNombreDoc.Text != "Nombre Doc")
                {
                    DT = compras.CargarCompra(cbxDocumento.Text, txtNombreDoc.Text, txtConsecutivoDoc.Text, dtpkFechaIni.Text, dtpkFechaFinal.Text, "NombreDoc");
                }
                else if (txtConsecutivoDoc.Text != "Consecutivo Doc")
                {
                    DT = compras.CargarCompra(cbxDocumento.Text, txtNombreDoc.Text, txtConsecutivoDoc.Text, dtpkFechaIni.Text, dtpkFechaFinal.Text, "ConsecutivoDoc");
                }
            } else if (txtNombreDoc.Text == "Nombre Doc" && txtConsecutivoDoc.Text == "Consecutivo Doc")
            {
                DT = compras.CargarCompra(cbxDocumento.Text, txtNombreDoc.Text, txtConsecutivoDoc.Text, dtpkFechaIni.Text, dtpkFechaFinal.Text, "Documento");
            }

            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgCompras.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgCompras.Rows[contador].Cells["ClID"].Value = row["ID"];
                    dtgCompras.Rows[contador].Cells["ClDocumento"].Value = row["Documento"];
                    dtgCompras.Rows[contador].Cells["ClNombreDocumento"].Value = row["NombreDocumento"];
                    dtgCompras.Rows[contador].Cells["ClConsecutivoDocumento"].Value = row["ConsecutivoDocumento"];
                    dtgCompras.Rows[contador].Cells["ClCodigoProducto"].Value = row["CodigoProducto"];
                    DT2 = producto.CargarProducto(" pd.ID", row["CodigoProducto"].ToString(), "Unico");
                    Rows = DT2.Rows[0];
                    dtgCompras.Rows[contador].Cells["ClItemPorducto"].Value = Rows["Item"].ToString();
                    dtgCompras.Rows[contador].Cells["ClNombreProducto"].Value = Rows["Nombre"].ToString();
                    dtgCompras.Rows[contador].Cells["ClCodigoProveedor"].Value = row["CodigoProveedor"];
                    DT2 = proveedor.CargarProveedor("c.Codigo", row["CodigoProveedor"].ToString(), "Unico");
                    Rows = DT2.Rows[0];
                    dtgCompras.Rows[contador].Cells["ClDNIProveedor"].Value = Rows["DNI"].ToString();
                    dtgCompras.Rows[contador].Cells["ClDigitoVerificacion"].Value = Rows["DigitoVerificacion"].ToString();
                    dtgCompras.Rows[contador].Cells["ClRazonSocialProveedor"].Value = Rows["RazonSocial"].ToString();
                    dtgCompras.Rows[contador].Cells["ClNombreComercialProveedor"].Value = Rows["NombreComercial"].ToString();
                    dtgCompras.Rows[contador].Cells["ClCantidad"].Value = row["Cantidad"];
                    dtgCompras.Rows[contador].Cells["ClDescripcionCantidad"].Value = row["DescripcionCantidad"];
                    Costo = Convert.ToDouble(row["Costo"]);
                    dtgCompras.Rows[contador].Cells["ClCosto"].Value = Costo.ToString("N");
                    Margen = Convert.ToDouble(row["Margen"]);
                    dtgCompras.Rows[contador].Cells["ClMargen"].Value = Margen.ToString("N");
                    dtgCompras.Rows[contador].Cells["ClIVAProducto"].Value = row["IVA"];
                    dtgCompras.Rows[contador].Cells["CLGeneraIVAProducto"].Value = row["GeneraIVA"];
                    dtgCompras.Rows[contador].Cells["ClFechaVence"].Value = row["FechaVencimiento"];
                    dtgCompras.Rows[contador].Cells["CLLote"].Value = row["Lote"];
                    dtgCompras.Rows[contador].Cells["ClSerial"].Value = row["Serial"];
                    dtgCompras.Rows[contador].Cells["ClCodigoBarras"].Value = row["CodigoBarras"];
                    dtgCompras.Rows[contador].Cells["ClFechaRegistro"].Value = row["FechaRegistro"];
                    dtgCompras.Rows[contador].Cells["ClHoraRegistro"].Value = row["HoraRegistro"];

                    //Consulta Nombre Bodega
                    DT = bodega.CargarBodega(true);
                    foreach (DataRow bog in DT.Rows)
                    {
                        if (row["Bodega"].ToString() == bog["ID"].ToString())
                        {
                            dtgCompras.Rows[contador].Cells["ClBodegas"].Value = bog["Nombre"].ToString();
                        }
                    }

                    contador++;
                }
            }
        }

        private void EnviarDatos()
        {
            foreach (DataGridViewRow rows in dtgCompras.SelectedRows)
            {
                dETALLE_COMPRAS.txtDocumento.Text = rows.Cells["ClDocumento"].Value.ToString();
                dETALLE_COMPRAS.txtNombreDoc.Text = rows.Cells["ClNombreDocumento"].Value.ToString();
                dETALLE_COMPRAS.txtConsecutivoDoc.Text = rows.Cells["ClConsecutivoDocumento"].Value.ToString();
                DT = producto.CargarProducto("pd.ID", rows.Cells["ClCodigoProducto"].Value.ToString(), "Unico");
                Rows = DT.Rows[0];
                dETALLE_COMPRAS.txtItemProd.Text = Rows["Item"].ToString();
                dETALLE_COMPRAS.txtNombreProd.Text = Rows["Nombre"].ToString();          
                DT = proveedor.CargarProveedor("c.Codigo", rows.Cells["ClCodigoProveedor"].Value.ToString(), "Unico");
                Rows = DT.Rows[0];
                dETALLE_COMPRAS.txtDNIProveedor.Text = Rows["DNI"].ToString();
                dETALLE_COMPRAS.txtRazonSocial.Text = Rows["RazonSocial"].ToString();
                dETALLE_COMPRAS.txtNombreComercial.Text = Rows["NombreComercial"].ToString();
                dETALLE_COMPRAS.txtCantidad.Text = rows.Cells["ClCantidad"].Value.ToString();
                dETALLE_COMPRAS.txtDescripcionCantidad.Text = rows.Cells["ClDescripcionCantidad"].Value.ToString();
                dETALLE_COMPRAS.txtCosto.Text = rows.Cells["ClCosto"].Value.ToString();
                dETALLE_COMPRAS.txtMargen.Text = rows.Cells["ClMargen"].Value.ToString();
                dETALLE_COMPRAS.txtIVA.Text = rows.Cells["ClIVAProducto"].Value.ToString();
                dETALLE_COMPRAS.txtLote.Text = rows.Cells["CLLote"].Value.ToString();
                dETALLE_COMPRAS.txtSerial.Text = rows.Cells["ClSerial"].Value.ToString();
                dETALLE_COMPRAS.txtCodigoBarras.Text = rows.Cells["ClCodigoBarras"].Value.ToString();
                dETALLE_COMPRAS.txtFechaVence.Text = rows.Cells["ClFechaVence"].Value.ToString();
                dETALLE_COMPRAS.txtbodega.Text = rows.Cells["ClBodegas"].Value.ToString();
            }

            dETALLE_COMPRAS.ShowDialog();
        }

        private void dtgCompras_DoubleClick(object sender, EventArgs e)
        {
            EnviarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Buscars();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            REGISTRO_COMPRA.NombreUsuario = this.NombreUsuario;
            REGISTRO_COMPRA.AgregarCompras += new REGISTRO_COMPRAS.AgregaCompra(CargarCompras);
            REGISTRO_COMPRA.ShowDialog();
        }

        private void txtNombreDoc_Enter(object sender, EventArgs e)
        {
            if (txtNombreDoc.Text == "Nombre Doc")
            {
                txtNombreDoc.Text = "";
                txtNombreDoc.ForeColor = Color.Black;
            }
        }

        private void txtNombreDoc_Leave(object sender, EventArgs e)
        {
            if (txtNombreDoc.Text == "")
            {
                txtNombreDoc.Text = "Nombre Doc";
                txtNombreDoc.ForeColor = Color.Gray;
            }
        }

        private void txtConsecutivoDoc_Enter(object sender, EventArgs e)
        {
            if (txtConsecutivoDoc.Text == "Consecutivo Doc")
            {
                txtConsecutivoDoc.Text = "";
                txtConsecutivoDoc.ForeColor = Color.Black;
            }
        }

        private void txtConsecutivoDoc_Leave(object sender, EventArgs e)
        {
            if (txtConsecutivoDoc.Text == "")
            {
                txtConsecutivoDoc.Text = "Consecutivo Doc";
                txtConsecutivoDoc.ForeColor = Color.Gray;
            }
        }

        private void cbxDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            Buscars();
        }

        private void txtNombreDoc_KeyUp(object sender, KeyEventArgs e)
        {
            Buscars();
        }

        private void txtConsecutivoDoc_KeyUp(object sender, KeyEventArgs e)
        {
            Buscars();
        }

        private void dtpkFechaIni_CloseUp(object sender, EventArgs e)
        {
            Buscars();
            FechaFinal();
        }

        private void dtpkFechaFinal_CloseUp(object sender, EventArgs e)
        {
            Buscars();
        }

        private void FechaFinal()
        {
            dtpkFechaFinal.MinDate = dtpkFechaIni.Value;
        }
    } 
}
