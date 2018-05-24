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
    public partial class INVENTARIO : Form
    {
        CONTROLLER.Inventario inventario = new CONTROLLER.Inventario();
        CARGANDO cARGANDO = new CARGANDO();

        DataTable DT;
        int Fila = 0;
        int Contador = 0;

        public INVENTARIO()
        {
            InitializeComponent();
        }

        private void INVENTARIO_Load(object sender, EventArgs e)
        {
            CargarInventario();
            EstiloTabla();
            PintarTablaSegunAlerta();
        }

        private void EstiloTabla()
        {
            dtgInventario.EnableHeadersVisualStyles = false;
            dtgInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarInventario()
        {
            inventario.Item = txtBuscar.Text;
            if (txtBuscar.Text != "Buscar item")
            {
                DT = inventario.Cargar(false);
            }
            else
            {
                DT = inventario.Cargar(true);
            }
           
            dtgInventario.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                Contador = 0;
                Fila = DT.Rows.Count;
                dtgInventario.Rows.Add(Fila);

                foreach (DataRow rows in DT.Rows)
                {
                    dtgInventario.Rows[Contador].Cells["ClItem"].Value = rows["Item"];
                    dtgInventario.Rows[Contador].Cells["ClNombre"].Value = rows["Nombre"];
                    dtgInventario.Rows[Contador].Cells["ClReferencia"].Value = rows["Referencia"];
                    dtgInventario.Rows[Contador].Cells["ClCantidadExistente"].Value = rows["CANTIDAD_EXISTENTE"];
                    dtgInventario.Rows[Contador].Cells["ClStockMinimo"].Value = rows["StockMinimo"];
                    dtgInventario.Rows[Contador].Cells["ClFechaVencimiento"].Value = rows["FechaVencimiento"];
                    dtgInventario.Rows[Contador].Cells["ClIVA"].Value = rows["IVA"];
                    dtgInventario.Rows[Contador].Cells["ClMarca"].Value = rows["Marca"];
                    dtgInventario.Rows[Contador].Cells["ClPresentacion"].Value = rows["Presentacion"];
                    dtgInventario.Rows[Contador].Cells["CLCategoria"].Value = rows["Categoria"];
                    dtgInventario.Rows[Contador].Cells["ClUnidadMedida"].Value = rows["UnidadMedida"];
                    dtgInventario.Rows[Contador].Cells["ClMedida"].Value = rows["Medida"];
                    dtgInventario.Rows[Contador].Cells["ClEstado"].Value = rows["Estado"];
                    Contador++;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar item")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar item";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CargarInventario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarInventario();
            PintarTablaSegunAlerta();
        }

        private void ExportaExcel()
        {
            cARGANDO.Show();

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;

            cARGANDO.Progreso(20);

            foreach (DataGridViewColumn columna in dtgInventario.Columns)
            {
                if (columna.Visible == true)
                {
                    IndiceColumna++;
                    Excel.Cells[1, IndiceColumna] = columna.HeaderText;
                }
            }
            cARGANDO.Progreso(70);
            int IndiceFila = 0;

            foreach (DataGridViewRow Row in dtgInventario.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn Columna in dtgInventario.Columns)
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

        private void PintarTablaSegunAlerta()
        {
            if (dtgInventario.Rows.Count > 0)
            {
                foreach (DataGridViewRow rows in dtgInventario.Rows)
                {
                    //Alerta Stock
                    if (Convert.ToDecimal(rows.Cells["ClStockMinimo"].Value) == Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value) || Convert.ToDecimal(rows.Cells["ClStockMinimo"].Value) > Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value))
                    {
                        rows.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    //Alerta agotado
                    if (Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value) == 0)
                    {
                        rows.DefaultCellStyle.BackColor = Color.Red;
                    }
                    //Alerta Proximo a vencer
                    if (Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value) == 0)
                    {
                        rows.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
