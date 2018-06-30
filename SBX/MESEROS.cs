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
    public partial class MESEROS : Form
    {
        CONTROLLER.Mesero oMesero = new CONTROLLER.Mesero();
        DETALLE_MESERO oDETALLE_MESERO = new DETALLE_MESERO();
        
        DataTable DT;
        int contador = 0;
        int Filas = 0;

        public MESEROS()
        {
            InitializeComponent();
        }

        private void MESEROS_Load(object sender, EventArgs e)
        {
            CargarMeseros();
            EstiloTabla();
        }

        private void EstiloTabla()
        {
            dtgMeseros.EnableHeadersVisualStyles = false;
            dtgMeseros.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgMeseros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgMeseros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarMeseros() {
            DT = oMesero.Cargar();
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                dtgMeseros.Rows.Clear();
                Filas = DT.Rows.Count;
                dtgMeseros.Rows.Add(Filas);

                foreach (DataRow rows in DT.Rows)
                {
                    dtgMeseros.Rows[contador].Cells["ClCodigo"].Value = rows["Codigo"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClDNI"].Value = rows["DNI"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClTipoIdentificacion"].Value = rows["TipoIdentificacion"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClNombres"].Value = rows["Nombres"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClApellidos"].Value = rows["Apellidos"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClCodigoDepartamento"].Value = rows["CodigoDepartamento"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClDepartamento"].Value = rows["Departamento"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClCodigoMunicipio"].Value = rows["CodigoMunicipio"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClMunicipio"].Value = rows["Municipio"].ToString();           
                    dtgMeseros.Rows[contador].Cells["ClBarrioVereda"].Value = rows["BarrioVereda"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClDireccion"].Value = rows["Direccion"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClTelefonoFijo"].Value = rows["TelefonoFijo"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClEmail"].Value = rows["Email"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClCelular"].Value = rows["Celular"].ToString();
                    contador++;
                }
            }
        }

        private void Buscar()
        {
            DT = oMesero.Buscar(txtBuscar.Text);

            dtgMeseros.Rows.Clear();
            contador = 0;
            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgMeseros.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtgMeseros.Rows[contador].Cells["ClCodigo"].Value = rows["Codigo"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClDNI"].Value = rows["DNI"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClTipoIdentificacion"].Value = rows["TipoIdentificacion"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClNombres"].Value = rows["Nombres"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClApellidos"].Value = rows["Apellidos"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClCodigoDepartamento"].Value = rows["CodigoDepartamento"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClDepartamento"].Value = rows["Departamento"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClCodigoMunicipio"].Value = rows["CodigoMunicipio"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClMunicipio"].Value = rows["Municipio"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClBarrioVereda"].Value = rows["BarrioVereda"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClDireccion"].Value = rows["Direccion"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClTelefonoFijo"].Value = rows["TelefonoFijo"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClEmail"].Value = rows["Email"].ToString();
                    dtgMeseros.Rows[contador].Cells["ClCelular"].Value = rows["Celular"].ToString();
                    contador++;
                }
            }         
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMeseros();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgMeseros_DoubleClick(object sender, EventArgs e)
        {
            EnviarMesero();
            oDETALLE_MESERO.Nuevo = false;
            oDETALLE_MESERO.AgregarPersona += new DETALLE_MESERO.AgregarPersonas(CargarMeseros);
            oDETALLE_MESERO.ShowDialog();
        }

        private void EnviarMesero()
        {
            foreach (DataGridViewRow rows in dtgMeseros.SelectedRows)
            {
                oDETALLE_MESERO.txtDNI.Text = rows.Cells["ClDNI"].Value.ToString();
                oDETALLE_MESERO.txtDNI.Enabled = false;
                oDETALLE_MESERO.txtTipoIdentificacion.Text = rows.Cells["ClTipoIdentificacion"].Value.ToString();
                oDETALLE_MESERO.txtNombres.Text = rows.Cells["ClNombres"].Value.ToString();
                oDETALLE_MESERO.txtApellidos.Text = rows.Cells["ClApellidos"].Value.ToString();
                oDETALLE_MESERO.Departamento = rows.Cells["ClDepartamento"].Value.ToString();
                oDETALLE_MESERO.Municipio = rows.Cells["ClMunicipio"].Value.ToString();
                oDETALLE_MESERO.txtBarrioVereda.Text = rows.Cells["ClBarrioVereda"].Value.ToString();
                oDETALLE_MESERO.txtDireccion.Text = rows.Cells["ClDireccion"].Value.ToString();
                oDETALLE_MESERO.txtTelefonoFijo.Text = rows.Cells["ClTelefonoFijo"].Value.ToString();
                oDETALLE_MESERO.txtCelular.Text = rows.Cells["ClCelular"].Value.ToString();
            } 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oDETALLE_MESERO.Nuevo = true;
            oDETALLE_MESERO.AgregarPersona += new DETALLE_MESERO.AgregarPersonas(CargarMeseros);
            oDETALLE_MESERO.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
