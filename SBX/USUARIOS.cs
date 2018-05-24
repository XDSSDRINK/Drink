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
    public partial class USUARIOS : Form
    {
        DETALLE_USUARIOS eTALLE_USUARIOS = new DETALLE_USUARIOS();
        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();
        CONTROLLER.Persona persona = new CONTROLLER.Persona();
        CONTROLLER.Departamento departamento = new CONTROLLER.Departamento();
        CONTROLLER.Municipio municipio = new CONTROLLER.Municipio();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        
        DataTable DT;
        int contador = 0;
        int Filas = 0;        

        public USUARIOS()
        {
            InitializeComponent();
        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            CargarUsuariosTodos();
        }

        private void EstiloTabla()
        {
            dtgUsuarios.EnableHeadersVisualStyles = false;
            dtgUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            eTALLE_USUARIOS.Estado = "";
            eTALLE_USUARIOS.Rol = "";
            eTALLE_USUARIOS.Nuevo = true;
            eTALLE_USUARIOS.ActualizarUsuarios += new DETALLE_USUARIOS.ActualizarUsuario(CargarUsuariosTodos);
            eTALLE_USUARIOS.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarUsuariosTodos()
        {
            DT = usuario.Cargar(true);
            dtgUsuarios.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgUsuarios.Rows.Add(Filas);

                foreach (DataRow Usuarios in DT.Rows)
                {
                    dtgUsuarios.Rows[contador].Cells["ClCodigoUsuario"].Value = Usuarios["CodigoUsuario"];
                    dtgUsuarios.Rows[contador].Cells["ClCodigoPersona"].Value = Usuarios["CodigoPersona"];
                    dtgUsuarios.Rows[contador].Cells["ClDNI"].Value = Usuarios["DNI"];
                    dtgUsuarios.Rows[contador].Cells["ClTipoDNI"].Value = Usuarios["TipoIdentificacion"];
                    dtgUsuarios.Rows[contador].Cells["ClNombres"].Value = Usuarios["Nombres"];
                    dtgUsuarios.Rows[contador].Cells["ClApellidos"].Value = Usuarios["Apellidos"];
                    dtgUsuarios.Rows[contador].Cells["ClDepartamento"].Value = Usuarios["Departamento"];
                    dtgUsuarios.Rows[contador].Cells["ClMunicipio"].Value = Usuarios["Municipio"];
                    dtgUsuarios.Rows[contador].Cells["ClBarrioVereda"].Value = Usuarios["BarrioVereda"];
                    dtgUsuarios.Rows[contador].Cells["ClDireccion"].Value = Usuarios["Direccion"];
                    dtgUsuarios.Rows[contador].Cells["ClTelefono"].Value = Usuarios["TelefonoFijo"];
                    dtgUsuarios.Rows[contador].Cells["ClEmail"].Value = Usuarios["Email"];
                    dtgUsuarios.Rows[contador].Cells["ClCelular"].Value = Usuarios["Celular"];
                    dtgUsuarios.Rows[contador].Cells["ClUsuario"].Value = Usuarios["Usuario"];
                    dtgUsuarios.Rows[contador].Cells["ClContrasena"].Value = Usuarios["Contraseña"];
                    dtgUsuarios.Rows[contador].Cells["ClEstado"].Value = Usuarios["Estado"];
                    dtgUsuarios.Rows[contador].Cells["ClRol"].Value = Usuarios["Rol"];

                    contador++;
                }
            }
        }

        private void Buscar()
        {
            if (txtBuscar.Text.Trim() != "")
            {
                DT = usuario.Buscar(txtBuscar.Text);
            }
            else
            {
                DT = usuario.Cargar(true);
            }
           
            dtgUsuarios.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgUsuarios.Rows.Add(Filas);

                foreach (DataRow Usuarios in DT.Rows)
                {
                    dtgUsuarios.Rows[contador].Cells["ClCodigoUsuario"].Value = Usuarios["CodigoUsuario"];
                    dtgUsuarios.Rows[contador].Cells["ClDNI"].Value = Usuarios["DNI"];
                    dtgUsuarios.Rows[contador].Cells["ClTipoDNI"].Value = Usuarios["TipoIdentificacion"];
                    dtgUsuarios.Rows[contador].Cells["ClNombres"].Value = Usuarios["Nombres"];
                    dtgUsuarios.Rows[contador].Cells["ClApellidos"].Value = Usuarios["Apellidos"];
                    dtgUsuarios.Rows[contador].Cells["ClDepartamento"].Value = Usuarios["Departamento"];
                    dtgUsuarios.Rows[contador].Cells["ClMunicipio"].Value = Usuarios["Municipio"];
                    dtgUsuarios.Rows[contador].Cells["ClBarrioVereda"].Value = Usuarios["BarrioVereda"];
                    dtgUsuarios.Rows[contador].Cells["ClDireccion"].Value = Usuarios["Direccion"];
                    dtgUsuarios.Rows[contador].Cells["ClTelefono"].Value = Usuarios["TelefonoFijo"];
                    dtgUsuarios.Rows[contador].Cells["ClEmail"].Value = Usuarios["Email"];
                    dtgUsuarios.Rows[contador].Cells["ClCelular"].Value = Usuarios["Celular"];
                    dtgUsuarios.Rows[contador].Cells["ClUsuario"].Value = Usuarios["Usuario"];
                    dtgUsuarios.Rows[contador].Cells["ClContrasena"].Value = Usuarios["Contraseña"];
                    dtgUsuarios.Rows[contador].Cells["ClEstado"].Value = Usuarios["Estado"];
                    dtgUsuarios.Rows[contador].Cells["ClRol"].Value = Usuarios["Rol"];

                    contador++;
                }
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar usuario")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar usuario";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
           Buscar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuariosTodos();
        }

        private void Eliminar()
        {
            foreach (DataGridViewRow Usua in dtgUsuarios.SelectedRows)
            {
                usuario.Codigo = Convert.ToInt32(Usua.Cells["ClCodigoUsuario"].Value);
                usuario.Eliminar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mENSAJE_CONFIRMACION.txtMensaje.Text = "Esta seguro que desea eliminar usuario";
            mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
            mENSAJE_CONFIRMACION.ShowDialog();
            if (mENSAJE_CONFIRMACION.Ok == true)
            {
                Eliminar();
                CargarUsuariosTodos();
            } 
        }

        private void dtgUsuarios_DoubleClick(object sender, EventArgs e)
        {

            foreach (DataGridViewRow usuario in dtgUsuarios.SelectedRows)
            {
                eTALLE_USUARIOS.CodigoUsuario = Convert.ToInt32(usuario.Cells["ClCodigoUsuario"].Value);
                eTALLE_USUARIOS.txtPersona.Text = usuario.Cells["ClDNI"].Value.ToString();
                eTALLE_USUARIOS.txtPersona.Enabled = false;
                eTALLE_USUARIOS.btnBuscarPersona.Enabled = false;
                eTALLE_USUARIOS.lblNombrePersona.Text = usuario.Cells["ClNombres"].Value.ToString() + " " + usuario.Cells["ClApellidos"].Value.ToString();
                eTALLE_USUARIOS.txtUsuario.Text = usuario.Cells["ClUsuario"].Value.ToString();
                eTALLE_USUARIOS.txtContrasena.Text = usuario.Cells["ClContrasena"].Value.ToString();
                eTALLE_USUARIOS.Estado = usuario.Cells["ClEstado"].Value.ToString();
                eTALLE_USUARIOS.Rol = usuario.Cells["ClRol"].Value.ToString();
                eTALLE_USUARIOS.Nuevo = false;
                eTALLE_USUARIOS.ActualizarUsuarios += new DETALLE_USUARIOS.ActualizarUsuario(CargarUsuariosTodos);
                eTALLE_USUARIOS.ShowDialog();
            }      
        }
    }
}
