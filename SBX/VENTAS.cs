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
    public partial class VENTAS : Form
    {
        REGISTRO_VENTASS rEGISTRO_VENTASS = new REGISTRO_VENTASS();
        CONTROLLER.Ventas ventas = new CONTROLLER.Ventas();
        CONTROLLER.Caja cj = new CONTROLLER.Caja();
        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        public string Usuario { get; set; }

        DataTable DT;
        int Filas = 0;
        int contador = 0;
        int CodigoUsuario = 0;
        DataRow rows;

        public VENTAS()
        {
            InitializeComponent();
            dtpkFechaIni.Value = DateTime.Today.AddMonths(-1);
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            CargarVentas();
            EstiloTabla();
            CargarUsuario();
        }

        private void EstiloTabla()
        {
            dtgVentas.EnableHeadersVisualStyles = false;
            dtgVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarUsuario()
        {
            DT = usuario.Cargar(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow perso in DT.Rows)
                {
                    if (perso["Usuario"].ToString() == Usuario)
                    {
                        CodigoUsuario = Convert.ToInt32(perso["CodigoUsuario"]);
                    }
                }
            }
        }

        private void VerificarEstadoCaja()
        {
            cj.Usuario = CodigoUsuario;
            DT = cj.CargarCaja();
            if (DT.Rows.Count > 0)
            {
                rows = DT.Rows[0];
                if (rows["TipoOperacion"].ToString() == "Cierre")
                {
                    mENSAJE_CONFIRMACION.txtMensaje.Text = "Se debe realizar apertura de caja, deseas realizar apertura de caja ";
                    mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                    mENSAJE_CONFIRMACION.ShowDialog();
                    if (mENSAJE_CONFIRMACION.Ok)
                    {
                        APERTURA_CAJ AptC = new APERTURA_CAJ();
                        AptC.usuario = Usuario;
                        AptC.ShowDialog();
                    }                 
                }
            }
            else
            {
                mENSAJE_CONFIRMACION.txtMensaje.Text = "Se debe realizar apertura de caja, deseas realizar apertura de caja ";
                mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                mENSAJE_CONFIRMACION.ShowDialog();
                if (mENSAJE_CONFIRMACION.Ok)
                {
                    APERTURA_CAJ AptC = new APERTURA_CAJ();
                    AptC.usuario = Usuario;
                    AptC.ShowDialog();
                }
            }
        }

        private void AgregarVenta()
        {
            rEGISTRO_VENTASS.Usuario = this.Usuario;
            rEGISTRO_VENTASS.AgregarVenta += new REGISTRO_VENTASS.AgregaVentas(CargarVentas);
            rEGISTRO_VENTASS.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cj.Usuario = CodigoUsuario;
            DT = cj.CargarCaja();
            if (DT.Rows.Count > 0)
            {
                rows = DT.Rows[0];
                if (rows["TipoOperacion"].ToString() == "Cierre")
                {
                    mENSAJE_CONFIRMACION.txtMensaje.Text = "No se ha realizado apertura caja, desea continuar ";
                    mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                    mENSAJE_CONFIRMACION.ShowDialog();
                    if (mENSAJE_CONFIRMACION.Ok)
                    {
                        AgregarVenta();
                    }
                }
                else
                {
                    AgregarVenta();
                }
            }
            else
            {
                mENSAJE_CONFIRMACION.txtMensaje.Text = "No se ha realizado apertura caja, desea continuar ";
                mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                mENSAJE_CONFIRMACION.ShowDialog();

                if (mENSAJE_CONFIRMACION.Ok)
                {
                    AgregarVenta();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarVentas()
        {
            ventas.buscar = txtBuscar.Text;
            ventas.NombreDoc = txtNombreDoc.Text;
            ventas.ConsecutivoDoc = txtConsecutivoDoc.Text;
            ventas.FechaIni = dtpkFechaIni.Text;
            ventas.FechaFin = dtpkFechaFinal.Text;
            ventas.FechaIniD = dtpkFechaIni.Value;
            ventas.FechaFinD = dtpkFechaFinal.Value;

            DT = ventas.CargarVentas();
            dtgVentas.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgVentas.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgVentas.Rows[contador].Cells["ClFechaRegistro"].Value = row["FechaRegistro"];
                    dtgVentas.Rows[contador].Cells["ClHoraRegistro"].Value = row["HoraRegistro"];
                    dtgVentas.Rows[contador].Cells["ClUsuario"].Value = row["Usuario"];
                    dtgVentas.Rows[contador].Cells["ClNombreDocumento"].Value = row["NombreDocumento"];
                    dtgVentas.Rows[contador].Cells["ClConsecutivoDoc"].Value = row["ConsecutivoDocumento"];
                    dtgVentas.Rows[contador].Cells["ClItem"].Value = row["Item"];
                    dtgVentas.Rows[contador].Cells["ClCodigoB"].Value = row["CodigoBarras"];
                    dtgVentas.Rows[contador].Cells["ClNombreP"].Value = row["Nombre"];
                    dtgVentas.Rows[contador].Cells["ClReferencia"].Value = row["Referencia"];
                    dtgVentas.Rows[contador].Cells["ClIVA"].Value = row["IVA"];
                    dtgVentas.Rows[contador].Cells["ClCantidad"].Value = row["Cantidad"];
                    dtgVentas.Rows[contador].Cells["ClValorVeta"].Value = row["ValorVenta"];
                    dtgVentas.Rows[contador].Cells["ClDescuento"].Value = row["ValorDescuento"];
                    dtgVentas.Rows[contador].Cells["ClTotalVenta"].Value = row["TotalVenta"];
                    dtgVentas.Rows[contador].Cells["ClMedioPago"].Value = row["MedioPago"];
                    contador++;
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar Item")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar Item";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CargarVentas();
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

        private void txtNombreDoc_KeyUp(object sender, KeyEventArgs e)
        {
            CargarVentas();
        }

        private void txtConsecutivoDoc_KeyUp(object sender, KeyEventArgs e)
        {
            CargarVentas();
        }
    }
}
