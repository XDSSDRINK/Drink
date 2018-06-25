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
    public partial class INVENTARIOS : Form
    {
        IMPORTAR_EXCEL ImportExcel = new IMPORTAR_EXCEL();
        CONTROLLER.kardex kardex = new CONTROLLER.kardex();
        CARGANDO CARGANDO = new CARGANDO();

        DataTable DT;
        int fila = 0;
        int Contador = 0;
        String acumulador = "";
        double existencia = 0;
        double existenciaAcu = 0;
        bool bandera = true;
        double saldo = 0;
        double saldoAcu = 0;

        public INVENTARIOS()
        {
            InitializeComponent();
        }

        private void INVENTARIOS_Load(object sender, EventArgs e)
        {
            CargarKardex();
            EstiloTabla();
        }

        public void EstiloTabla()
        {
            dtgKARDEX.EnableHeadersVisualStyles =
                 false;
            dtgKARDEX.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;

            dtgKARDEX.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgKARDEX.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarKardex()
        {
            double Costo = 0;
            acumulador = "";
            existencia = 0;
            existenciaAcu = 0;
            bandera = true;
            saldo = 0;
            saldoAcu = 0;
            kardex.Item = txtBuscar.Text;
            if (txtBuscar.Text != "Buscar item" && txtBuscar.Text.Trim() != "")
            {
                DT = kardex.Cargar(false);
            }
            else
            {
                DT = kardex.Cargar(true);
            }

            dtgKARDEX.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                Contador = 0;
                fila = DT.Rows.Count;
                dtgKARDEX.Rows.Add(fila);

                foreach (DataRow rows in DT.Rows)
                {

                    existencia = Convert.ToDouble(rows["ENTRADA"]) - Convert.ToDouble(rows["SALIDA"]);
                    saldo = (Convert.ToDouble(rows["costo"]) * Convert.ToDouble(rows["Entrada"]) - (Convert.ToDouble(rows["costo"]) * Convert.ToDouble(rows["SALIDA"])));

                    dtgKARDEX.Rows[Contador].Cells["ClFechaRegistro"].Value = rows["Fecha_Registro"];
                    dtgKARDEX.Rows[Contador].Cells["ClAccion"].Value = rows["Accion"];
                    dtgKARDEX.Rows[Contador].Cells["Clitem"].Value = rows["Item"];
                    dtgKARDEX.Rows[Contador].Cells["ClDetalle"].Value = rows["Detalle"];
                    Costo = Convert.ToDouble(rows["costo"]);
                    dtgKARDEX.Rows[Contador].Cells["ClCosto"].Value = Costo.ToString("N2");
                    dtgKARDEX.Rows[Contador].Cells["ClEntrada"].Value = rows["ENTRADA"];
                    dtgKARDEX.Rows[Contador].Cells["ClSalida"].Value = rows["SALIDA"];
                    if (bandera || acumulador.Equals(rows["Item"].ToString()))
                    {
                        saldoAcu += saldo;
                        existenciaAcu += existencia;

                        dtgKARDEX.Rows[Contador].Cells["ClExistencia"].Value = existenciaAcu.ToString("N2");
                        dtgKARDEX.Rows[Contador].Cells["ClSaldo"].Value = saldoAcu.ToString("N2");

                        acumulador = rows["Item"].ToString();
                        bandera = false;
                    }
                    else
                    {
                        saldoAcu = saldo;
                        existenciaAcu = 0;
                        existenciaAcu += existencia;

                        dtgKARDEX.Rows[Contador].Cells["ClExistencia"].Value = existenciaAcu.ToString("N2");
                        dtgKARDEX.Rows[Contador].Cells["ClSaldo"].Value = saldo.ToString("N2");
                        acumulador = rows["Item"].ToString();
                        bandera = false;
                    }
                    Contador++;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarKardex();
        }

        private void txtBuscar_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCargarInventario_Click(object sender, EventArgs e)
        {
            ImportExcel.ShowDialog();
        }
    }
}
