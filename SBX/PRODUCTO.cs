using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class PRODUCTO : Form
    {
        CONTROLLER.Producto productoController = new CONTROLLER.Producto();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        DETALLE_PRODUCTO DTP = new DETALLE_PRODUCTO();
        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();
 
        DataTable DT;
        int contador;
        int Filas;
        bool AutorizaModificar = false;
        public string NombreUsuario { get; set; }

        public PRODUCTO()
        {
            InitializeComponent();
        }

        private void PRODUCTO_Load(object sender, EventArgs e)
        {
            cargarProductos();
            EstiloTabla();
            ValidacionPermisos();
        }

        private void EstiloTabla()
        {
            dtgProductos.EnableHeadersVisualStyles = false;
            dtgProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCargando_Click(object sender, EventArgs e)
        {
            CARGANDO carg = new CARGANDO();
            carg.Show();
        }

        public void cargarProductos()
        {
            DT = null;
            contador = 0;

            DT = productoController.CargarProducto("", "", "Productos");
            dtgProductos.Rows.Clear();

            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgProductos.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgProductos.Rows[contador].Cells["ClItem"].Value = row["Item"];
                    dtgProductos.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                    dtgProductos.Rows[contador].Cells["ClDescripcion"].Value = row["Descripcion"];
                    dtgProductos.Rows[contador].Cells["ClIva"].Value = row["iva"];            
                    dtgProductos.Rows[contador].Cells["ClMarca"].Value = row["Marca"];
                    dtgProductos.Rows[contador].Cells["ClCategoria"].Value = row["Categoria"];
                    dtgProductos.Rows[contador].Cells["ClPresentacion"].Value = row["Presentacion"];
                    dtgProductos.Rows[contador].Cells["ClModoVenta"].Value = row["ModoVenta"];
                    dtgProductos.Rows[contador].Cells["ClUnidadMedida"].Value = row["UnidadMedida"];
                    dtgProductos.Rows[contador].Cells["ClMedida"].Value = row["Medida"];
                    dtgProductos.Rows[contador].Cells["ClStock"].Value = row["Stock"];
                    dtgProductos.Rows[contador].Cells["ClFoto"].Value = row["Foto"];
                    dtgProductos.Rows[contador].Cells["ClReferencia"].Value = row["Referencia"];
                    string AplicaFechaV = "";
                    if (row["AplicaFechaVencimiento"].ToString() == "1")
                    {
                        AplicaFechaV = "SI";
                    }
                    else
                    {
                        AplicaFechaV = "NO";
                    }
                    dtgProductos.Rows[contador].Cells["ClAplicaFechaVencimiento"].Value = AplicaFechaV;
                    string GeneraIVA = "";
                    if (row["GeneraIVA"].ToString() == "1")
                    {
                        GeneraIVA = "SI";
                    }
                    else
                    {
                        GeneraIVA = "NO";
                    }
                    dtgProductos.Rows[contador].Cells["ClGeneraIVA"].Value = GeneraIVA;
                    dtgProductos.Rows[contador].Cells["ClEstado"].Value =  row["Estado"];
                    dtgProductos.Rows[contador].Cells["clStockMaximo"].Value = row["StockMaximo"];
                    dtgProductos.Rows[contador].Cells["ClDiasAlertFechaV"].Value = row["DiasAlertFechaV"];
                    
                     contador++;
                }
            }
        }

        private void dtgProductos_DoubleClick(object sender, EventArgs e)
        {
            if (AutorizaModificar == true)
            {
                DTP.Agregar_ = false;
                DTP.NombreUsuario = this.NombreUsuario;
                DTP.AgregarProductos += new DETALLE_PRODUCTO.AgregaProductos(cargarProductos);
                DetalleProducto();
                DTP.ShowDialog();
            }
        }

        private void DetalleProducto()
        {
            if (dtgProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow rows in dtgProductos.SelectedRows)
                {
                    DTP.txtItem.Text = rows.Cells["ClItem"].Value.ToString();
                    DTP.txtReferencia.Text = rows.Cells["ClReferencia"].Value.ToString();
                    DTP.txtNombre.Text = rows.Cells["ClNombre"].Value.ToString();
                    DTP.txtIVA.Text = rows.Cells["ClIva"].Value.ToString();
                    DTP.txtStock.Text = rows.Cells["ClStock"].Value.ToString();
                    DTP.txtDescripcion.Text = rows.Cells["ClDescripcion"].Value.ToString();
                    DTP.UnidadMedida = rows.Cells["ClUnidadMedida"].Value.ToString();
                    DTP.txtMedida.Text = rows.Cells["ClMedida"].Value.ToString();
                    if (rows.Cells["ClAplicaFechaVencimiento"].Value.ToString() == "SI")
                    {
                        DTP.chkAplicaFechaV.Checked = true;
                    }
                    else
                    {
                        DTP.chkAplicaFechaV.Checked = false;
                    }
                    if (rows.Cells["ClGeneraIVA"].Value.ToString() == "SI")
                    {
                        DTP.chkGeneraIVA.Checked = true;
                    }
                    else
                    {
                        DTP.chkGeneraIVA.Checked = false;
                    }
                    DTP.Estados = rows.Cells["ClEstado"].Value.ToString();
                    DTP.Marca = rows.Cells["ClMarca"].Value.ToString();
                    DTP.Categoria = rows.Cells["ClCategoria"].Value.ToString();
                    DTP.Presentacion = rows.Cells["ClPresentacion"].Value.ToString();
                    DTP.ModoVenta = rows.Cells["ClModoVenta"].Value.ToString();
                    byte[] imagen = (byte[])rows.Cells["ClFoto"].Value;
                    DTP.Foto = byteArrayToImage(imagen);
                    DTP.txtStockMaximo.Text = rows.Cells["clStockMaximo"].Value.ToString();
                    DTP.txtAlertaFechaVenc.Text = rows.Cells["ClDiasAlertFechaV"].Value.ToString();
                }
            }           
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CARGANDO cag = new CARGANDO();
            cag.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DTP.Agregar_ = true;
            DTP.NombreUsuario = this.NombreUsuario;
            DTP.AgregarProductos += new DETALLE_PRODUCTO.AgregaProductos(cargarProductos);
            DTP.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void Eliminar()
        {
            List<string> Items = new List<string>();

            foreach (DataGridViewRow rows in dtgProductos.SelectedRows)
            {
                Items.Add(rows.Cells["ClItem"].Value.ToString());
            }

            mENSAJE_CONFIRMACION.Productos = Items;
            mENSAJE_CONFIRMACION.ActualizarProductos += new MENSAJE_CONFIRMACION.RecargaProductos(cargarProductos);
            mENSAJE_CONFIRMACION.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mENSAJE_CONFIRMACION.Modulo = "Producto";
            Eliminar();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar producto")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar producto";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            dtgProductos.Rows.Clear();
            DT = productoController.CargarProducto("pd.Item",txtBuscar.Text, "Relacionados");
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgProductos.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgProductos.Rows[contador].Cells["ClItem"].Value = row["Item"];
                    dtgProductos.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                    dtgProductos.Rows[contador].Cells["ClDescripcion"].Value = row["Descripcion"];
                    dtgProductos.Rows[contador].Cells["ClIva"].Value = row["iva"];
                    dtgProductos.Rows[contador].Cells["ClMarca"].Value = row["Marca"];
                    dtgProductos.Rows[contador].Cells["ClCategoria"].Value = row["Categoria"];
                    dtgProductos.Rows[contador].Cells["ClPresentacion"].Value = row["Presentacion"];
                    dtgProductos.Rows[contador].Cells["ClModoVenta"].Value = row["ModoVenta"];
                    dtgProductos.Rows[contador].Cells["ClUnidadMedida"].Value = row["UnidadMedida"];
                    dtgProductos.Rows[contador].Cells["ClMedida"].Value = row["Medida"];
                    dtgProductos.Rows[contador].Cells["ClStock"].Value = row["Stock"];
                    dtgProductos.Rows[contador].Cells["ClFoto"].Value = row["Foto"];
                    dtgProductos.Rows[contador].Cells["ClReferencia"].Value = row["Referencia"];
                    string AplicaFechaV = "";
                    if (row["AplicaFechaVencimiento"].ToString() == "1")
                    {
                        AplicaFechaV = "SI";
                    }
                    else
                    {
                        AplicaFechaV = "NO";
                    }
                    dtgProductos.Rows[contador].Cells["ClAplicaFechaVencimiento"].Value = AplicaFechaV;
                    string GeneraIVA = "";
                    if (row["GeneraIVA"].ToString() == "1")
                    {
                        GeneraIVA = "SI";
                    }
                    else
                    {
                        GeneraIVA = "NO";
                    }
                    dtgProductos.Rows[contador].Cells["ClGeneraIVA"].Value = GeneraIVA;
                    dtgProductos.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                    dtgProductos.Rows[contador].Cells["clStockMaximo"].Value = row["StockMaximo"];
                    dtgProductos.Rows[contador].Cells["ClDiasAlertFechaV"].Value = row["DiasAlertFechaV"];
                    contador++;
                }
            }
            else
            {
                dtgProductos.Rows.Clear();
                DT = productoController.CargarProducto("pd.Nombre", txtBuscar.Text, "Relacionados");
                if (DT.Rows.Count > 0)
                {
                    contador = 0;
                    Filas = DT.Rows.Count;
                    dtgProductos.Rows.Add(Filas);

                    foreach (DataRow row in DT.Rows)
                    {
                        dtgProductos.Rows[contador].Cells["ClItem"].Value = row["Item"];
                        dtgProductos.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                        dtgProductos.Rows[contador].Cells["ClDescripcion"].Value = row["Descripcion"];
                        dtgProductos.Rows[contador].Cells["ClIva"].Value = row["iva"];
                        dtgProductos.Rows[contador].Cells["ClMarca"].Value = row["Marca"];
                        dtgProductos.Rows[contador].Cells["ClCategoria"].Value = row["Categoria"];
                        dtgProductos.Rows[contador].Cells["ClPresentacion"].Value = row["Presentacion"];
                        dtgProductos.Rows[contador].Cells["ClModoVenta"].Value = row["ModoVenta"];
                        dtgProductos.Rows[contador].Cells["ClUnidadMedida"].Value = row["UnidadMedida"];
                        dtgProductos.Rows[contador].Cells["ClMedida"].Value = row["Medida"];
                        dtgProductos.Rows[contador].Cells["ClStock"].Value = row["Stock"];
                        dtgProductos.Rows[contador].Cells["ClFoto"].Value = row["Foto"];
                        dtgProductos.Rows[contador].Cells["ClReferencia"].Value = row["Referencia"];
                        string AplicaFechaV = "";
                        if (row["AplicaFechaVencimiento"].ToString() == "1")
                        {
                            AplicaFechaV = "SI";
                        }
                        else
                        {
                            AplicaFechaV = "NO";
                        }
                        dtgProductos.Rows[contador].Cells["ClAplicaFechaVencimiento"].Value = AplicaFechaV;
                        string GeneraIVA = "";
                        if (row["GeneraIVA"].ToString() == "1")
                        {
                            GeneraIVA = "SI";
                        }
                        else
                        {
                            GeneraIVA = "NO";
                        }
                        dtgProductos.Rows[contador].Cells["ClGeneraIVA"].Value = GeneraIVA;
                        dtgProductos.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                        dtgProductos.Rows[contador].Cells["clStockMaximo"].Value = row["StockMaximo"];
                        dtgProductos.Rows[contador].Cells["ClDiasAlertFechaV"].Value = row["DiasAlertFechaV"];
                        contador++;
                    }
                }
                else
                {
                    dtgProductos.Rows.Clear();
                    DT = productoController.CargarProducto("pd.Referencia", txtBuscar.Text, "Relacionados");
                    if (DT.Rows.Count > 0)
                    {
                        contador = 0;
                        Filas = DT.Rows.Count;
                        dtgProductos.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgProductos.Rows[contador].Cells["ClItem"].Value = row["Item"];
                            dtgProductos.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                            dtgProductos.Rows[contador].Cells["ClDescripcion"].Value = row["Descripcion"];
                            dtgProductos.Rows[contador].Cells["ClIva"].Value = row["iva"];
                            dtgProductos.Rows[contador].Cells["ClMarca"].Value = row["Marca"];
                            dtgProductos.Rows[contador].Cells["ClCategoria"].Value = row["Categoria"];
                            dtgProductos.Rows[contador].Cells["ClPresentacion"].Value = row["Presentacion"];
                            dtgProductos.Rows[contador].Cells["ClModoVenta"].Value = row["ModoVenta"];
                            dtgProductos.Rows[contador].Cells["ClUnidadMedida"].Value = row["UnidadMedida"];
                            dtgProductos.Rows[contador].Cells["ClMedida"].Value = row["Medida"];
                            dtgProductos.Rows[contador].Cells["ClStock"].Value = row["Stock"];
                            dtgProductos.Rows[contador].Cells["ClFoto"].Value = row["Foto"];
                            dtgProductos.Rows[contador].Cells["ClReferencia"].Value = row["Referencia"];
                            string AplicaFechaV = "";
                            if (row["AplicaFechaVencimiento"].ToString() == "1")
                            {
                                AplicaFechaV = "SI";
                            }
                            else
                            {
                                AplicaFechaV = "NO";
                            }
                            dtgProductos.Rows[contador].Cells["ClAplicaFechaVencimiento"].Value = AplicaFechaV;
                            string GeneraIVA = "";
                            if (row["GeneraIVA"].ToString() == "1")
                            {
                                GeneraIVA = "SI";
                            }
                            else
                            {
                                GeneraIVA = "NO";
                            }
                            dtgProductos.Rows[contador].Cells["ClGeneraIVA"].Value = GeneraIVA;
                            dtgProductos.Rows[contador].Cells["ClEstado"].Value = row["Estado"];
                            dtgProductos.Rows[contador].Cells["clStockMaximo"].Value = row["StockMaximo"];
                            dtgProductos.Rows[contador].Cells["ClDiasAlertFechaV"].Value = row["DiasAlertFechaV"];
                            contador++;
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void ValidacionPermisos()
        {
           DT = productoController.CargarPermisos(NombreUsuario, "Productos");
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
    }
}
