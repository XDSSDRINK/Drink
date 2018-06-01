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
    public partial class REGISTRO_VENTASS : Form
    {
        CONTROLLER.Ventas ventas = new CONTROLLER.Ventas();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable DT;
        int Filas = 0;
        int Contador = 0;
        //// Create a new form.
        Form mdiChildForm = new Form();

        public REGISTRO_VENTASS()
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        private void Limpiar()
        {
            txtProducto.Text = "";
            dtgRegistroVentas.Rows.Clear();
            txtCliente.Text = "Cliente";
            lblNombreCliente.Text = "--";
            txtRecibido.Text = "";
            txtCambio.Text = "";
            txtTotal.Text = "";
            txtImpuesto.Text = "";
            txtCantidad.Text = "";       
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

        private void CargaProductoVenta()
        {
            if (txtProducto.Text.Trim() != "")
            {
                ventas.buscar = txtProducto.Text;

                DT = ventas.producto_venta();

                if (DT.Rows.Count > 0)
                {
                    DataRow Pro = DT.Rows[0];
                    double NuevaCantidad = 0;
                    //verificar existencia de producto

                    if (dtgRegistroVentas.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow proexit in dtgRegistroVentas.Rows)
                        {
                            if (proexit.Cells["ClItem"].Value == Pro["ITEM"] || proexit.Cells["ClCodigoBarras"].Value == Pro["CODIGO_BARRAS"])
                            {
                                NuevaCantidad = Convert.ToDouble(proexit.Cells["ClCantidad"].Value) + 1;
                                proexit.Cells["ClCantidad"].Value = NuevaCantidad.ToString();
                            }
                            else
                            {
                                Filas = DT.Rows.Count;
                                dtgRegistroVentas.Rows.Add(Filas);
                                foreach (DataRow rows in DT.Rows)
                                {
                                    dtgRegistroVentas.Rows[Contador].Cells["ClNombreDoc"].Value = "Prueba";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClConseDoc"].Value = "0001";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClItem"].Value = rows["ITEM"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["CODIGO_BARRAS"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClNombre"].Value = rows["NOMBRE"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClReferencia"].Value = rows["REFERENCIA"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClCantidad"].Value = "1";
                                    double ValorUnidad = Convert.ToDouble(rows["VALOR_UN"]);
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorUnidad"].Value = ValorUnidad.ToString("N2");
                                    dtgRegistroVentas.Rows[Contador].Cells["ClDescuento"].Value = "0";
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorDesc"].Value = "0";
                                    double ValorTotal = Convert.ToDouble(rows["VALOR_UN"]) * 1;
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorTotal"].Value = ValorTotal.ToString("N2");
                                    dtgRegistroVentas.Rows[Contador].Cells["ClIva"].Value = rows["IVA"].ToString();
                                    dtgRegistroVentas.Rows[Contador].Cells["ClValorIva"].Value = "0";
                                    Contador++;
                                }
                            }
                        }
                    }
                    else
                    {
                        Filas = DT.Rows.Count;
                        dtgRegistroVentas.Rows.Add(Filas);
                        foreach (DataRow rows in DT.Rows)
                        {
                            dtgRegistroVentas.Rows[Contador].Cells["ClNombreDoc"].Value = "Prueba";
                            dtgRegistroVentas.Rows[Contador].Cells["ClConseDoc"].Value = "0001";
                            dtgRegistroVentas.Rows[Contador].Cells["ClItem"].Value = rows["ITEM"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClCodigoBarras"].Value = rows["CODIGO_BARRAS"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClNombre"].Value = rows["NOMBRE"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClReferencia"].Value = rows["REFERENCIA"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClCantidad"].Value = "1";
                            double ValorUnidad = Convert.ToDouble(rows["VALOR_UN"]);
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorUnidad"].Value = ValorUnidad.ToString("N2");
                            dtgRegistroVentas.Rows[Contador].Cells["ClDescuento"].Value = "0";
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorDesc"].Value = "0";
                            double ValorTotal = Convert.ToDouble(rows["VALOR_UN"]) * 1;
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorTotal"].Value = ValorTotal.ToString("N2");
                            dtgRegistroVentas.Rows[Contador].Cells["ClIva"].Value = rows["IVA"].ToString();
                            dtgRegistroVentas.Rows[Contador].Cells["ClValorIva"].Value = "0";
                            Contador++;
                        }
                    }
                }
                else
                {
                    errorProvider1.SetError(txtProducto,"Producto no disponible");
                }

                txtProducto.Text = "";
            } 
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            CargaProductoVenta();
        }
    }
}
