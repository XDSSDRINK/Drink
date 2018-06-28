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
using System.Diagnostics;

namespace SBX
{
    public partial class INICIO : Form
    {
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        COMPRAS cOMPRAS = new COMPRAS();
        PRODUCTO pRODUCTO = new PRODUCTO();
        PROVEEDORES pROVEEDORES = new PROVEEDORES();
        PRODUCTO_PARAMETROS pRODUCTO_PARAMETROS = new PRODUCTO_PARAMETROS();
        USUARIOS uSUARIOS = new USUARIOS();
        ROLES_USUARIO _USUARIO = new ROLES_USUARIO();
        PERSONAL pERSONAL = new PERSONAL();
        CLIENTES cLIENTES = new CLIENTES();
        INVENTARIO iNVENTARIO = new INVENTARIO();
        VENTAS vENTAS = new VENTAS();
        INVENTARIOS iNVENTARIOS = new INVENTARIOS();
        CONTROLLER.Caja cj = new CONTROLLER.Caja();
        CIERRE_BILLETES Cbi = new CIERRE_BILLETES();

        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();

        DataTable DT;
        int CodigoUsuario= 0;
        DataRow rows;

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
            ValidacionCaja();
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
                        CodigoUsuario = Convert.ToInt32(perso["CodigoUsuario"]);
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
                    switch (rolPer["Modulo"].ToString())
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
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(iNVENTARIO);
            lblFormulario.Text = btnReporteInventario.Text;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            AbrirFormularioEnPanel(iNVENTARIOS);
            lblFormulario.Text = btnInventario.Text;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            pnlCentral.BackgroundImage = null;
            vENTAS.Usuario = lblNombreUsuario.Text;
            AbrirFormularioEnPanel(vENTAS);
            lblFormulario.Text = btnVentas.Text;
        }

        private void btnCompania_Click(object sender, EventArgs e)
        {
            COMPANIA cmp = new COMPANIA();
            cmp.Usuario = lblNombreUsuario.Text;
            cmp.ShowDialog();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process calc = new Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();

            calc.WaitForExit();
        }

        private void btnPuntos_Click(object sender, EventArgs e)
        {
            PUNTOS pnt = new PUNTOS();
            pnt.ShowDialog();
        }

        private void btnPfactura_Click_1(object sender, EventArgs e)
        {
            P_FACTURA fac = new P_FACTURA();
            fac.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            APERTURA_CAJ AptC = new APERTURA_CAJ();
            AptC.usuario = lblNombreUsuario.Text;
            AptC.ShowDialog();
        }

        private void ValidacionCaja()
        {
            cj.Usuario = CodigoUsuario;
            DT = cj.CargarCaja();
            if (DT.Rows.Count > 0)
            {
                rows = DT.Rows[0];
                if (rows["TipoOperacion"].ToString() == "Cierre")
                {
                    mENSAJE_CONFIRMACION.txtMensaje.Text = "Se debe realizar apertura de caja, deseas realizar apertura de caja ";
                    mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                    mENSAJE_CONFIRMACION.ShowDialog();
                    if (mENSAJE_CONFIRMACION.Ok)
                    {
                        APERTURA_CAJ AptC = new APERTURA_CAJ();
                        AptC.usuario = lblNombreUsuario.Text;
                        AptC.ShowDialog();
                    }
                }
            }
            else
            {
                mENSAJE_CONFIRMACION.txtMensaje.Text = "Se debe realizar apertura de caja, deseas realizar apertura de caja ";
                mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                mENSAJE_CONFIRMACION.ShowDialog();
                if (mENSAJE_CONFIRMACION.Ok)
                {
                    APERTURA_CAJ AptC = new APERTURA_CAJ();
                    AptC.usuario = lblNombreUsuario.Text;
                    AptC.ShowDialog();
                }
            }         
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            CIERRE_BILLETES Cbi = new CIERRE_BILLETES();
            cj.Usuario = CodigoUsuario;
            DT = cj.CargarCaja();
            if (DT.Rows.Count > 0)
            {
                rows = DT.Rows[0];
                if (rows["TipoOperacion"].ToString() == "Apertura")
                {
                    Cbi.CodigoUsuario = CodigoUsuario;
                    Cbi.ShowDialog();
                }
                else
                {
                    msgError.lblMensaje.Text = "No se ha realizado apertura de caja";
                    msgError.ShowDialog();
                }
            }
            else
            {
                msgError.lblMensaje.Text = "No se ha realizado apertura de caja";
                msgError.ShowDialog();
            }
        }
    }
}
