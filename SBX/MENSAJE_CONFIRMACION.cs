using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX
{
    public partial class MENSAJE_CONFIRMACION : Form
    {
        //Delegado 
        public delegate void RecargaProductos();
        public event RecargaProductos ActualizarProductos;

        //Delegado 
        public delegate void RecargaProveedores();
        public event RecargaProveedores ActualizarProveedores;

        //Delegado 
        public delegate void CargarCaracteristicas();
        public event CargarCaracteristicas ActualizaCaracteristica;

        CONTROLLER.Producto productoController = new CONTROLLER.Producto();
        CONTROLLER.Proveedor proveedor = new CONTROLLER.Proveedor();
        CONTROLLER.Marca marca = new CONTROLLER.Marca();
        CONTROLLER.Presentacion presentacion = new CONTROLLER.Presentacion();
        CONTROLLER.Categoria Categoria = new CONTROLLER.Categoria();
        CONTROLLER.UnidadMedida unidadMedida = new CONTROLLER.UnidadMedida();

      
        public string ProItem { get; set; }
        public string Modulo { get; set; }

        public bool Ok { get; set; }
       
        public List<string> Productos { get; set; }
        public List<string> Proveedores { get; set; }
        public List<string> Caracteristicas { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Form FrmMensaje = new Form();

        public MENSAJE_CONFIRMACION()
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            FrmMensaje.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)
                {
                    ctl.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Ok = false;
            this.Close();
        }

        public bool EliminarProducto()
        {
            foreach (var productos in Productos)
            {
                productoController.Item_ = productos.ToString();
                Ok = productoController.Eliminar();
            }
            ActualizarProductos();
            return Ok;
        }

        public bool EliminarProveedor()
        {
            foreach (var Proveedor in Proveedores)
            {
                proveedor.Codigo = Proveedor.ToString();
                Ok = proveedor.Eliminar();
            }
            ActualizarProveedores();
            return Ok;
        }

        public bool EliminarMarca()
        {
            foreach (var NombreCaract in Caracteristicas)
            {
                marca.Nombre_ = NombreCaract;
                Ok = marca.Eliminar();
            }
            ActualizaCaracteristica();
            return Ok;
        }

        public bool EliminarPresentacion()
        {
            foreach (var NombreCaract in Caracteristicas)
            {
                presentacion.Nombre_ = NombreCaract;
                presentacion.Eliminar();
            }
            ActualizaCaracteristica();
            return Ok;
        }

        public bool EliminarCategoria()
        {
            foreach (var NombreCaract in Caracteristicas)
            {
                Categoria.Nombre_ = NombreCaract;
                Ok = Categoria.Eliminar();
            }
            ActualizaCaracteristica();
            return Ok;
        }

        public bool EliminarUnidadMedida()
        {
            foreach (var NombreCaract in Caracteristicas)
            {
                unidadMedida.Nombre_ = NombreCaract;
                Ok = unidadMedida.Eliminar();
            }
            ActualizaCaracteristica();
            return Ok;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modulo)
            {
                case "Producto":
                    EliminarProducto();
                    break;   
                case "Proveedor":
                    EliminarProveedor();
                    break;
                case "Marca":
                    EliminarMarca();
                    break;
                case "Presentación":
                    EliminarPresentacion();
                    break;
                case "Categoría":
                    EliminarCategoria();
                    break;
                case "Unidad medida":
                    EliminarUnidadMedida();
                    break;
                case "Confirmacion":
                    Ok = true;
                    break;
            }
           
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
