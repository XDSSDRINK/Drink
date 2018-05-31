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

        DataTable DT;
        int Filas = 0;
        int contador = 0;

        public VENTAS()
        {
            InitializeComponent();
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            CargarVentas();
            EstiloTabla();
        }

        private void EstiloTabla()
        {
            dtgVentas.EnableHeadersVisualStyles = false;
            dtgVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            rEGISTRO_VENTASS.ShowDialog();
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

            DT = ventas.InformeVentas();

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
    }
}
