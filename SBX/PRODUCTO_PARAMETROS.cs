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
    public partial class PRODUCTO_PARAMETROS : Form
    {
        CONTROLLER.Marca marca = new CONTROLLER.Marca();
        CONTROLLER.Presentacion presentacion = new CONTROLLER.Presentacion();
        CONTROLLER.Categoria Categoria = new CONTROLLER.Categoria();
        CONTROLLER.UnidadMedida unidadMedida = new CONTROLLER.UnidadMedida();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();

        int contador = 0;
        DataTable DT;

        public PRODUCTO_PARAMETROS()
        {
            InitializeComponent();
        }

        private void PRODUCTO_PARAMETROS_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            cbxCaracteristicas.SelectedIndex = 0;
            CargaCaracteristica();
        }

        private void EstiloTabla()
        {
            dtgCaracteristicas.EnableHeadersVisualStyles = false;
            dtgCaracteristicas.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgCaracteristicas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgCaracteristicas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DETALLE_PRODUCTO_PARAMETROS dETALLE_PRODUCTO_PARAMETROS = new DETALLE_PRODUCTO_PARAMETROS();
            dETALLE_PRODUCTO_PARAMETROS.AgregaCaracteristicas += new DETALLE_PRODUCTO_PARAMETROS.AgregaCaracteristica(CargaCaracteristica);
            dETALLE_PRODUCTO_PARAMETROS.ShowDialog();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void CargaCaracteristica()
        {
            int Filas = 0;
            contador = 0;
            dtgCaracteristicas.Rows.Clear();
            switch (cbxCaracteristicas.Text)
            {
                case "Marca":
                    DT = null;
                    marca.Nombre_ = txtBuscar.Text;
                    DT = marca.CargaMarca(true);
                    dtgCaracteristicas.Rows.Clear();

                    if (DT.Rows.Count > 0)
                    {
                        Filas = DT.Rows.Count;
                        dtgCaracteristicas.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgCaracteristicas.Rows[contador].Cells["Clid"].Value = row["ID"];
                            dtgCaracteristicas.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                            contador++;
                        }
                    }
                    break;

                case "Presentación":
                    DT = null;
                    presentacion.Nombre_ = txtBuscar.Text;
                    DT = presentacion.CargaPresentacion(true);
                    dtgCaracteristicas.Rows.Clear();
                    if (DT.Rows.Count > 0)
                    {
                        Filas = DT.Rows.Count;
                        dtgCaracteristicas.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgCaracteristicas.Rows[contador].Cells["Clid"].Value = row["ID"];
                            dtgCaracteristicas.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                            contador++;
                        }
                    }
                    break;

                case "Categoría":
                    DT = null;
                    Categoria.Nombre_ = txtBuscar.Text;
                    DT = Categoria.CargaCategoria(true);
                    dtgCaracteristicas.Rows.Clear();
                    if (DT.Rows.Count > 0)
                    {
                        Filas = DT.Rows.Count;
                        dtgCaracteristicas.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgCaracteristicas.Rows[contador].Cells["Clid"].Value = row["ID"];
                            dtgCaracteristicas.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                            contador++;
                        }
                    }
                    break;

                case "Unidad medida":
                    DT = null;
                    unidadMedida.Nombre_ = txtBuscar.Text;
                    DT = unidadMedida.CargaUnidadMedida(true);
                    dtgCaracteristicas.Rows.Clear();
                    if (DT.Rows.Count > 0)
                    {
                        Filas = DT.Rows.Count;
                        dtgCaracteristicas.Rows.Add(Filas);

                        foreach (DataRow row in DT.Rows)
                        {
                            dtgCaracteristicas.Rows[contador].Cells["Clid"].Value = row["ID"];
                            dtgCaracteristicas.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                            contador++;
                        }
                    }
                    break;
            }
        }

        private void cbxCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaCaracteristica();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaCaracteristica();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbxCaracteristicas.Text != "")
            {
                Eliminar();
            }        
        }

        private void Eliminar()
        {
            List<string> Caracteristica = new List<string>();

            foreach (DataGridViewRow rows in dtgCaracteristicas.SelectedRows)
            {
                Caracteristica.Add(rows.Cells["ClNombre"].Value.ToString());
            }
            mENSAJE_CONFIRMACION.Modulo = cbxCaracteristicas.Text;
            mENSAJE_CONFIRMACION.Caracteristicas = Caracteristica;
            mENSAJE_CONFIRMACION.ActualizaCaracteristica += new MENSAJE_CONFIRMACION.CargarCaracteristicas(CargaCaracteristica);
            mENSAJE_CONFIRMACION.ShowDialog();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            switch (cbxCaracteristicas.Text)
            {
                case "Marca":
                    marca.Relacionadas = true;
                    break;
                case "Presentación":
                    presentacion.Relacionadas = true;
                    break;
                case "Categoría":
                    Categoria.Relacionadas = true;
                    break;
                case "Unidad medida":
                    unidadMedida.Relacionadas = true;
                    break;
            }

            CargaCaracteristica();
        }
    }
}
