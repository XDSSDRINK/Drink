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
    public partial class ROLES_USUARIO : Form
    {
        DETALLE_ROL_USUARIO _USUARIO = new DETALLE_ROL_USUARIO();
        CONTROLLER.Rol rol = new CONTROLLER.Rol();
        CONTROLLER.Rol_Permiso Rp = new CONTROLLER.Rol_Permiso();
        MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
        MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        DataTable DT;
        int contador = 0;
        int Filas = 0;
        bool ok = true;

        public ROLES_USUARIO()
        {
            InitializeComponent();
        }

        private void ROLES_USUARIO_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            CargarRol();
        }

        private void EstiloTabla()
        {
            dtgRolesUsuario.EnableHeadersVisualStyles = false;
            dtgRolesUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgRolesUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgRolesUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarRol()
        {
            DT = rol.Cargar(true);
            dtgRolesUsuario.Rows.Clear();

            if (DT.Rows.Count > 0)
            {
                contador = 0;
                Filas = DT.Rows.Count;
                dtgRolesUsuario.Rows.Add(Filas);
                foreach (DataRow rol in DT.Rows)
                {
                    dtgRolesUsuario.Rows[contador].Cells["clId"].Value = rol["ID"].ToString();
                    dtgRolesUsuario.Rows[contador].Cells["ClNombre"].Value = rol["Nombre"].ToString();
                    dtgRolesUsuario.Rows[contador].Cells["ClDescripcion"].Value = rol["Descripcion"].ToString();
                    contador++;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _USUARIO.IDRol = "";
            _USUARIO.Nuevo = true;
            _USUARIO.AgregaRol_Permiso += new DETALLE_ROL_USUARIO.AgregaRol_Permisos(CargarRol);
            _USUARIO.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarRol();
        }

        private void dtgRolesUsuario_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dtgRolesUsuario.SelectedRows)
            {
               _USUARIO.IDRol = rows.Cells["clId"].Value.ToString();
               _USUARIO.Nuevo = false;
               _USUARIO.AgregaRol_Permiso += new DETALLE_ROL_USUARIO.AgregaRol_Permisos(CargarRol);
               _USUARIO.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mENSAJE_CONFIRMACION.txtMensaje.Text = "Esta seguro que desea eliminar Rol";
            mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
            mENSAJE_CONFIRMACION.ShowDialog();

            if (mENSAJE_CONFIRMACION.Ok == true)
            {
                Eliminar();
                CargarRol();
            }
        }

        private void Eliminar()
        {
            foreach (DataGridViewRow rows in dtgRolesUsuario.SelectedRows)
            {
                Rp.Rol = Convert.ToInt32(rows.Cells["clId"].Value);
                ok = Rp.EliminarTotalRol();
                if (ok == true)
                {
                    mENSAJECORRECTO.lblMensaje.Text = "Rol Eliminado correctamente";
                    mENSAJECORRECTO.ShowDialog();
                }
                else
                {
                    mENSAJE_ERROR.lblMensaje.Text = "No fue posible eliminar rol";
                    mENSAJE_ERROR.ShowDialog();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
