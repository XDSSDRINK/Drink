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
    public partial class DESCUENTO_CLIENTE : Form
    {
        AYUDA aYUDA = new AYUDA();

        CONTROLLER.Producto productoController = new CONTROLLER.Producto();
        CONTROLLER.General Gnl = new CONTROLLER.General();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        CONTROLLER.DescuentoCliente descClien = new CONTROLLER.DescuentoCliente();
        CONTROLLER.Cliente clien = new CONTROLLER.Cliente();
        MENSAJECORRECTO msgCorrecto = new MENSAJECORRECTO();

        DataTable DT;
        int contador = 0;
        int Filas = 0;
        bool OK = true;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public DESCUENTO_CLIENTE()
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)

                // If the control is the correct type,
                // change the color.
                {
                    ctl.BackColor = System.Drawing.Color.White;
                }
            }

        }

        private void EstiloTabla()
        {
            dtgDescClientes.EnableHeadersVisualStyles = false;
            dtgDescClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgDescClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgDescClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void DESCUENTO_CLIENTE_Load(object sender, EventArgs e)
        {
            CargarProductos();
            EstiloTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            aYUDA.Modulo = "DescuentoProducto";
            aYUDA.EnviaProductos += new AYUDA.EnviaProducto(CargarProducto);
            aYUDA.ShowDialog();
        }

        private void CargarProducto(string Item)
        {
            txtProducto.Text = Item;
            CargarProductos();
        }

        private void CargarProductos()
        {
            DT = null;
            contador = 0;
          
            //cargar los productos
            DT = productoController.CargarProductosDescuento("p.Item", txtProducto.Text);
            dtgDescClientes.Rows.Clear();

            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgDescClientes.Rows.Add(Filas);

                foreach (DataRow row in DT.Rows)
                {
                    dtgDescClientes.Rows[contador].Cells["ClItem"].Value = row["Item"];
                    dtgDescClientes.Rows[contador].Cells["ClCodBarras"].Value = row["CodigoBarras"];
                    dtgDescClientes.Rows[contador].Cells["ClNombre"].Value = row["Nombre"];
                    dtgDescClientes.Rows[contador].Cells["ClDescuento"].Value = "0";

                    contador++;
                }
            }

            //Agregar los descuentos del cliente
          
            DT = clien.CargarActivos(lblCliente.Text);
            if (DT.Rows.Count > 0)
            {
                DataRow clientes = DT.Rows[0];
                descClien.Cliente = Convert.ToInt32(clientes["Codigo"]);
                DT = descClien.CargarDescuentosCliente();

                foreach (DataRow rows in DT.Rows)
                {
                    foreach (DataGridViewRow prod in dtgDescClientes.Rows)
                    {
                        if (rows["Item"].ToString() == prod.Cells["ClItem"].Value.ToString())
                        {
                            prod.Cells["ClDescuento"].Value = rows["Descuento"];
                        }
                    }
                }
            }
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            CargarProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            lblCliente.Text = "----------------";
            lblNombre.Text = "-----------------------";
            txtProducto.Text = "";
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rows in dtgDescClientes.Rows)
            {
                rows.Cells["ClDescuento"].Value = "0";
            }
        }

        private void dtgDescClientes_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow rows in dtgDescClientes.Rows)
            {
                OK = Gnl.IsNumericDouble(rows.Cells["ClDescuento"].Value.ToString());
                if (!OK)
                {
                    msgError.lblMensaje.Text = "Ingrese valores numericos";
                    msgError.ShowDialog();
                    rows.Cells["ClDescuento"].Value = "0";
                }
            }
        }

        private void dtgDescClientes_Validating(object sender, CancelEventArgs e)
        {
            foreach (DataGridViewRow rows in dtgDescClientes.Rows)
            {
                OK = Gnl.IsNumericDouble(rows.Cells["ClDescuento"].Value.ToString());
                if (!OK)
                {
                    msgError.lblMensaje.Text = "Ingrese valores numericos";
                    msgError.ShowDialog();
                    rows.Cells["ClDescuento"].Value = "0";
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataRow row = null;
            DT = clien.CargarActivos(lblCliente.Text);
            if (DT.Rows.Count > 0)
            {
                row = DT.Rows[0];

                descClien.Cliente = Convert.ToInt32(row["Codigo"]);

                //Eliminar descuentos de cliente
                OK = descClien.Eliminar();
                if (OK)
                {
                    foreach (DataGridViewRow prod in dtgDescClientes.Rows)
                    {
                        DT = productoController.CargarProductosDescuento("Item", prod.Cells["ClItem"].Value.ToString());
                        if (DT.Rows.Count > 0)
                        {
                            row = DT.Rows[0];
                            descClien.Producto = Convert.ToInt32(row["ID"]);
                            descClien.Codigobarras = prod.Cells["ClCodBarras"].Value.ToString();
                            descClien.Descuento = Convert.ToDouble(prod.Cells["ClDescuento"].Value);
                            descClien.Registrar();
                        }
                    }

                    msgCorrecto.lblMensaje.Text = "Proceso Terminado";
                    msgCorrecto.ShowDialog();

                }
                else
                {
                    msgError.lblMensaje.Text = "Error al intentar registrar descuentos ";
                    msgError.ShowDialog();
                }         
            }     
        }
    }
}
