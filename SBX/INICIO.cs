using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SBX
{
    public partial class INICIO : Form
    {
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        COMPRAS cOMPRAS = new COMPRAS();
        PRODUCTO pRODUCTO = new PRODUCTO();
        PROVEEDORES pROVEEDORES = new PROVEEDORES();
        PRODUCTO_PARAMETROS pRODUCTO_PARAMETROS = new PRODUCTO_PARAMETROS();
        USUARIOS uSUARIOS = new USUARIOS();
        ROLES_USUARIO _USUARIO = new ROLES_USUARIO();
        PERSONAL pERSONAL = new PERSONAL();
        CLIENTES cLIENTES = new CLIENTES();
       

        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();

        DataTable DT;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));

        public string Persona { get; set; }

        public INICIO()
        {
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            DT = usuario.Cargar(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow perso in DT.Rows)
                {
                    if (perso["CodigoPersona"].ToString() == Persona)
                    {
                        lblUsuario.Text = perso["Nombres"].ToString() + " " + perso["Apellidos"].ToString() + " ("+ perso["Usuario"].ToString()+")";
                        lblNombreUsuario.Text = perso["Usuario"].ToString();
                        ValidacionRolPermiso(perso["IDRol"].ToString());
                    }
                }
            }
        }

        private void ValidacionRolPermiso(string Rol)
        {
            CONTROLLER.Rol_Permiso rol_Permiso = new CONTROLLER.Rol_Permiso();
            rol_Permiso.Rol = Convert.ToInt32(Rol);
            DT = rol_Permiso.CargarDetalleRol(false);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rolPer in DT.Rows)
                {
                    switch (rolPer["Modulo"])
                    {
                        case "VENTAS":
                            btnVentas.Enabled = true;
                            break;
                        case "COMPRAS":
                            btnCompras.Enabled = true;
                            break;
                        case "CLIENTES":
                            btnClientes.Enabled = true;
                            break;
                        case "PRODUCTO":
                            btnProductos.Enabled = true;
                            break;
                        case "PROVEEDOR":
                            btnProveedores.Enabled = true;
                            break;
                        case "USUARIOS":
                            btnUsuario.Enabled = true;
                            break;
                        case "P_PRODUCTO":
                            btnPproducto.Enabled = true;
                            break;
                        case "P_FACTURA":
                            btnPfactura.Enabled = true;
                            break;
                        case "P_DOCUMENTOS":
                            btnPdocumentos.Enabled = true;
                            break;
                        case "P_VENTA":
                            btnPventa.Enabled = true;
                            break;
                        case "P_ROL_Y_PERMISOS":
                            btnPRol_permiso.Enabled = true;
                            break;
                        case "PERSONAL":
                            btnPersonal.Enabled = true;
                            break;
                        case "COMPAÑIA":
                            btnCompania.Enabled = true;
                            break;
                        case "R_GANANCIAS_Y_PERDIDAS":
                            btnReporteGananciasYperdidas.Enabled = true;
                            break;
                        case "R_VENTAS":
                            btnReporteVentas.Enabled = true;
                            break;
                        case "R_COMPRAS":
                            btnReporteCompras.Enabled = true;
                            break;
                        case "R_INVENTARIO":
                            btnReporteInventario.Enabled = true;
                            break;
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        public void AbrirFormularioEnPanel(object FormularioHijo)
        {     
            if (this.pnlCentral.Controls.Count > 0)
                this.pnlCentral.Controls.RemoveAt(0);
            Form formul;  
            formul = FormularioHijo as Form;
            formul.TopLevel = false;
            formul.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(formul);
            this.pnlCentral.Tag = formul;
            formul.Show();
            pnlCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCentral.BackgroundImage")));
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            pRODUCTO.NombreUsuario = lblNombreUsuario.Text;
            AbrirFormularioEnPanel(pRODUCTO);
            lblFormulario.Text = btnProductos.Text;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReporteGananciasYperdidas_Click(object sender, EventArgs e)
        {
            pnlSubmenuReportes.Visible = false;
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
        }

        private void btnReporteInventario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            pROVEEDORES.NombreUsuario = lblNombreUsuario.Text;
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(pROVEEDORES);
            lblFormulario.Text = btnProveedores.Text;
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPproducto_Click(object sender, EventArgs e)
        {
            pnlParametros.Visible = false;
            AbrirFormularioEnPanel(pRODUCTO_PARAMETROS);
            lblFormulario.Text = btnPproducto.Text;
        }

        private void btnPfactura_Click(object sender, EventArgs e)
        {
            lblFormulario.Text = btnPfactura.Text;
        }

        private void btnPdocumentos_Click(object sender, EventArgs e)
        {
            lblFormulario.Text = btnPdocumentos.Text;
        }

        private void btnPventa_Click(object sender, EventArgs e)
        {
            lblFormulario.Text = btnPventa.Text;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            cOMPRAS.NombreUsuario = lblNombreUsuario.Text;
            AbrirFormularioEnPanel(cOMPRAS);
            lblFormulario.Text = btnCompras.Text;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(uSUARIOS);
            lblFormulario.Text = btnUsuario.Text;
        }

        private void btnPproducto_Click_1(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(pRODUCTO_PARAMETROS);
            lblFormulario.Text = btnPproducto.Text;
        }

        private void btnParametrosUsuarios_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(_USUARIO);
            lblFormulario.Text = btnPRol_permiso.Text;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(pERSONAL);
            lblFormulario.Text = btnPersonal.Text;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            cLIENTES.NombreUsuario = lblNombreUsuario.Text;
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(cLIENTES);
            lblFormulario.Text = btnClientes.Text;
        }

        private void btnReporteInventario_Click_1(object sender, EventArgs e)
        {
            INVENTARIO iNVENTARIO = new INVENTARIO();
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(iNVENTARIO);
            lblFormulario.Text = btnReporteInventario.Text;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }
    }
}
