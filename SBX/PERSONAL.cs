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
    public partial class PERSONAL : Form
    {
        CONTROLLER.Persona persona = new CONTROLLER.Persona();
        DETALLE_PERSONA dETALLE_PERSONA = new DETALLE_PERSONA();
        
        DataTable DT;
        int contador = 0;
        int Filas = 0;

        public PERSONAL()
        {
            InitializeComponent();
        }

        private void PERSONAL_Load(object sender, EventArgs e)
        {
            CargarPersonal();
            EstiloTabla();
        }

        private void EstiloTabla()
        {
            dtgPersonal.EnableHeadersVisualStyles = false;
            dtgPersonal.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgPersonal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgPersonal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarPersonal() {
            DT = persona.Cargar();
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                dtgPersonal.Rows.Clear();
                Filas = DT.Rows.Count;
                dtgPersonal.Rows.Add(Filas);

                foreach (DataRow rows in DT.Rows)
                {
                    dtgPersonal.Rows[contador].Cells["ClCodigo"].Value = rows["Codigo"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClDNI"].Value = rows["DNI"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClTipoIdentificacion"].Value = rows["TipoIdentificacion"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClNombres"].Value = rows["Nombres"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClApellidos"].Value = rows["Apellidos"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClCodigoDepartamento"].Value = rows["CodigoDepartamento"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClDepartamento"].Value = rows["Departamento"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClCodigoMunicipio"].Value = rows["CodigoMunicipio"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClMunicipio"].Value = rows["Municipio"].ToString();           
                    dtgPersonal.Rows[contador].Cells["ClBarrioVereda"].Value = rows["BarrioVereda"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClDireccion"].Value = rows["Direccion"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClTelefonoFijo"].Value = rows["TelefonoFijo"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClEmail"].Value = rows["Email"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClCelular"].Value = rows["Celular"].ToString();
                    contador++;
                }
            }
        }

        private void Buscar()
        {
            DT = persona.Buscar(txtBuscar.Text);

            dtgPersonal.Rows.Clear();
            contador = 0;
            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgPersonal.Rows.Add(Filas);
                foreach (DataRow rows in DT.Rows)
                {
                    dtgPersonal.Rows[contador].Cells["ClCodigo"].Value = rows["Codigo"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClDNI"].Value = rows["DNI"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClTipoIdentificacion"].Value = rows["TipoIdentificacion"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClNombres"].Value = rows["Nombres"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClApellidos"].Value = rows["Apellidos"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClCodigoDepartamento"].Value = rows["CodigoDepartamento"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClDepartamento"].Value = rows["Departamento"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClCodigoMunicipio"].Value = rows["CodigoMunicipio"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClMunicipio"].Value = rows["Municipio"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClBarrioVereda"].Value = rows["BarrioVereda"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClDireccion"].Value = rows["Direccion"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClTelefonoFijo"].Value = rows["TelefonoFijo"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClEmail"].Value = rows["Email"].ToString();
                    dtgPersonal.Rows[contador].Cells["ClCelular"].Value = rows["Celular"].ToString();
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
            CargarPersonal();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgPersonal_DoubleClick(object sender, EventArgs e)
        {
            EnviarPersona();
            dETALLE_PERSONA.Nuevo = false;
            dETALLE_PERSONA.AgregarPersona += new DETALLE_PERSONA.AgregarPersonas(CargarPersonal);
            dETALLE_PERSONA.ShowDialog();
        }

        private void EnviarPersona()
        {
            foreach (DataGridViewRow rows in dtgPersonal.SelectedRows)
            {
                dETALLE_PERSONA.txtDNI.Text = rows.Cells["ClDNI"].Value.ToString();
                dETALLE_PERSONA.txtDNI.Enabled = false;
                dETALLE_PERSONA.txtTipoIdentificacion.Text = rows.Cells["ClTipoIdentificacion"].Value.ToString();
                dETALLE_PERSONA.txtNombres.Text = rows.Cells["ClNombres"].Value.ToString();
                dETALLE_PERSONA.txtApellidos.Text = rows.Cells["ClApellidos"].Value.ToString();
                dETALLE_PERSONA.Departamento = rows.Cells["ClDepartamento"].Value.ToString();
                dETALLE_PERSONA.Municipio = rows.Cells["ClMunicipio"].Value.ToString();
                dETALLE_PERSONA.txtBarrioVereda.Text = rows.Cells["ClBarrioVereda"].Value.ToString();
                dETALLE_PERSONA.txtDireccion.Text = rows.Cells["ClDireccion"].Value.ToString();
                dETALLE_PERSONA.txtTelefonoFijo.Text = rows.Cells["ClTelefonoFijo"].Value.ToString();
                dETALLE_PERSONA.txtCelular.Text = rows.Cells["ClCelular"].Value.ToString();
            } 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dETALLE_PERSONA.Nuevo = true;
            dETALLE_PERSONA.AgregarPersona += new DETALLE_PERSONA.AgregarPersonas(CargarPersonal);
            dETALLE_PERSONA.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
