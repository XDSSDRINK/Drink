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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTARIO));
        DataTable DT;
        int Fila = 0;
        int Contador = 0;
        bool currentlyAnimating = false;
        public INVENTARIO()
        {
            InitializeComponent();
        }

        private void INVENTARIO_Load(object sender, EventArgs e)
        {
            CargarInventario();
            EstiloTabla();
            this.dtgInventario.Paint += new PaintEventHandler(dtgAlertas_Paint);
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
                    dtgInventario.Rows[Contador].Cells["ClDiasFechaV"].Value = rows["DiasAlertFechaV"];
                    dtgInventario.Rows[Contador].Cells["ClAplicaFV"].Value = rows["AplicaFechaVencimiento"];
                    dtgInventario.Rows[Contador].Cells["ClStockMax"].Value = rows["StockMaximo"];
                    
                    Contador++;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //private void PintarTablaSegunAlerta()
        //{
        //    if (dtgInventario.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewRow rows in dtgInventario.Rows)
        //        {
        //            //Alerta Stock
        //            if (Convert.ToDecimal(rows.Cells["ClStockMinimo"].Value) == Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value) || Convert.ToDecimal(rows.Cells["ClStockMinimo"].Value) > Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value))
        //            {
        //                rows.DefaultCellStyle.BackColor = Color.Yellow;
        //            }
        //            //Alerta agotado
        //            if (Convert.ToDecimal(rows.Cells["ClCantidadExistente"].Value) == 0)
        //            {
        //                rows.DefaultCellStyle.BackColor = Color.OrangeRed;
        //            }
        //            //Alerta proximo a vencer
        //            DateTime FechaVencimiento = Convert.ToDateTime(rows.Cells["ClFechaVencimiento"].Value);
        //            DateTime FechaActual = DateTime.Today;
        //            TimeSpan TiempoFaltante = FechaVencimiento.Subtract(FechaActual);
        //            if ((Convert.ToDouble(rows.Cells["ClDiasFechaV"].Value) >= TiempoFaltante.Days && TiempoFaltante.Days > 0) && Convert.ToInt32(rows.Cells["ClAplicaFV"].Value) == 1)
        //            {
        //                rows.DefaultCellStyle.BackColor = Color.Orange;
        //            }
        //            //Alerta Vencidos
        //            if (TiempoFaltante.Days <= 0 && Convert.ToInt32(rows.Cells["ClAplicaFV"].Value) == 1)
        //            {
        //                rows.DefaultCellStyle.BackColor = Color.Olive;
        //            }
        //        }
        //    }
        //}

        //This method begins the animation.
        public void AnimateImage()
        {
            dtgAlertas.Rows.Clear();
            int contador = 0;

            if (!currentlyAnimating)
            {
                //Begin the animation.
                if (dtgInventario.Rows.Count > 0)
                {
                    dtgAlertas.Rows.Add(dtgInventario.Rows.Count);

                    foreach (DataGridViewRow row in this.dtgInventario.Rows)
                    {
                        if (row.IsNewRow == false)
                        {
                            Image ImgStocks = dtgAlertas.Rows[contador].Cells["ClStock15"].Value as Image;
                            Image ImgAgotado = dtgAlertas.Rows[contador].Cells["ClAgotado15"].Value as Image;
                            Image ImgProxV = dtgAlertas.Rows[contador].Cells["ClProxV15"].Value as Image;
                            Image ImgVencido = dtgAlertas.Rows[contador].Cells["ClVencido15"].Value as Image;
                           
                            if (ImgStocks != null && ImgAgotado != null && ImgProxV != null && ImgVencido != null)
                            {
                                //Alerta Stock
                                if (Convert.ToDecimal(row.Cells["ClStockMinimo"].Value) == Convert.ToDecimal(row.Cells["ClCantidadExistente"].Value) || Convert.ToDecimal(row.Cells["ClStockMinimo"].Value) > Convert.ToDecimal(row.Cells["ClCantidadExistente"].Value))
                                {
                                    ImageAnimator.Animate(ImgStocks, new EventHandler(this.OnFrameChanged));                                  
                                }
                                else
                                {
                                    dtgAlertas.Rows[contador].Cells["ClStock15"].Value = ((System.Drawing.Image)(resources.GetObject("ClStock15.Image")));
                                }
                                //Alerta agotado
                                if (Convert.ToDecimal(row.Cells["ClCantidadExistente"].Value) == 0)
                                {
                                    ImageAnimator.Animate(ImgAgotado, new EventHandler(this.OnFrameChanged));
                                }
                                else
                                {
                                    dtgAlertas.Rows[contador].Cells["ClAgotado15"].Value = ((System.Drawing.Image)(resources.GetObject("ClAgotado15.Image")));
                                }
                                //Alerta proximo a vencer
                                DateTime FechaVencimiento = Convert.ToDateTime(row.Cells["ClFechaVencimiento"].Value);
                                DateTime FechaActual = DateTime.Today;
                                TimeSpan TiempoFaltante = FechaVencimiento.Subtract(FechaActual);
                                if ((Convert.ToDouble(row.Cells["ClDiasFechaV"].Value) >= TiempoFaltante.Days && TiempoFaltante.Days > 0) && Convert.ToInt32(row.Cells["ClAplicaFV"].Value) == 1)
                                {
                                    ImageAnimator.Animate(ImgProxV, new EventHandler(this.OnFrameChanged));
                                }
                                else
                                {
                                    dtgAlertas.Rows[contador].Cells["ClProxV15"].Value = ((System.Drawing.Image)(resources.GetObject("ClProxV15.Image")));
                                }
                                //Alerta Vencidos
                                if (TiempoFaltante.Days <= 0 && Convert.ToInt32(row.Cells["ClAplicaFV"].Value) == 1)
                                {
                                    ImageAnimator.Animate(ImgVencido, new EventHandler(this.OnFrameChanged));
                                }
                                else
                                {
                                    dtgAlertas.Rows[contador].Cells["ClVencido15"].Value = ((System.Drawing.Image)(resources.GetObject("ClVencido15.Image")));
                                }
                            }
                        }
                        contador++;
                    }
                    currentlyAnimating = true;
                }
            }       
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
            //Force a call to the Paint event handler.
            this.dtgInventario.Invalidate();
        }

        private void dtgAlertas_Paint(object sender, PaintEventArgs e)
        {
            AnimateImage();
            ImageAnimator.UpdateFrames();
        }
    }
}
