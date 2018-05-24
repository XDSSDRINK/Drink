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
    public partial class REGISTRO_COMPRAS : Form
    {

        //Delegado 
        public delegate void AgregaCompra();
        public event AgregaCompra AgregarCompras;

        MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
        MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();
        CONTROLLER.Compras compras = new CONTROLLER.Compras();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();
        CONTROLLER.General general = new CONTROLLER.General();
        CONTROLLER.Producto producto = new CONTROLLER.Producto();
        CONTROLLER.Proveedor proveedor = new CONTROLLER.Proveedor();
        AYUDA aYUDA = new AYUDA();
        CalcularMargen calcularMargen = new CalcularMargen();
        DETALLE_COMPRAS dETALLE_COMPRAS = new DETALLE_COMPRAS();
        CONTROLLER.Bodega bodega = new CONTROLLER.Bodega();
        CONTROLLER.kardex kardex = new CONTROLLER.kardex();

        DataTable DT;
        DataRow Rows;
        int Validacion = 0;
        bool ok;
        double Costo = 0;
        double SubTotalCompra = 0;
        double CostoMasIVA = 0;
        double ValorIVA = 0;
        int CodigoUsuario;
        public string NombreUsuario { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //// Create a new form.
        Form mdiChildForm = new Form();

        public REGISTRO_COMPRAS()
        {
            InitializeComponent();

            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;

            // Set the child form's MdiParent property to 
            // the current form.
            mdiChildForm.MdiParent = this;

            // Call the method that changes the background color.
            SetBackGroundColorOfMDIForm();

            dtpFechaVenc.MinDate = DateTime.Today;
        }

        private void REGISTRO_COMPRAS_Load(object sender, EventArgs e)
        {
            cbxDocumento.SelectedIndex = 0;
            EstiloTabla();
            CargarBodega();
            toolStripCbxRegistro.SelectedIndex = 0;
            ValidaREgistroDocumentos();
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
            dtgRegistroCompras.EnableHeadersVisualStyles = false;
            dtgRegistroCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgRegistroCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgRegistroCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void ValidaREgistroDocumentos()
        {
            if (toolStripCbxRegistro.SelectedIndex == 0)
            {
                cbxDocumento.Enabled = true;
                txtNombreFactura.Enabled = true;
                txtConsecutivo.Enabled = true;
            }
            else
            {
                cbxDocumento.Enabled = false;
                txtNombreFactura.Enabled = false;
                txtConsecutivo.Enabled = false;
            }

            txtNombreFactura.Text = "";
            txtConsecutivo.Text = "";
            errorProvider.Clear();
        }

        private void Guardar()
        {
            CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();
            DT = usuario.Cargar(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Usuario"].ToString() == NombreUsuario)
                    {
                        CodigoUsuario = Convert.ToInt32(rows["CodigoUsuario"]);
                    }
                }
            }

            producto.CodigoUsuario = this.CodigoUsuario;

            bool Continuar = true;
            if (dtgRegistroCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow DatosCompra in dtgRegistroCompras.Rows)
                {
                    if (Continuar == true)
                    {
                        compras.Documento = DatosCompra.Cells["ClDocumento"].Value.ToString();
                        compras.NombreDocumento = DatosCompra.Cells["ClNombreDocumento"].Value.ToString();
                        compras.ConsecutivoDocumento = DatosCompra.Cells["ClConsecutivoDocumento"].Value.ToString();
                        DT = producto.CargarProducto("pd.Item", DatosCompra.Cells["ClCodigoProducto"].Value.ToString(), "Unico");
                        Rows = DT.Rows[0];
                        compras.CodigoProducto = Convert.ToInt32(Rows["CodigoProducto"]);
                        DT = proveedor.CargarProveedor("DNI", DatosCompra.Cells["ClCodigoProveedor"].Value.ToString(), "Unico");
                        Rows = DT.Rows[0];
                        compras.CodigoProveedor = Rows["Codigo"].ToString();
                        compras.Cantidad = float.Parse(DatosCompra.Cells["ClCantidad"].Value.ToString());
                        compras.DescripcionCantidad = DatosCompra.Cells["ClDescripcionCantidad"].Value.ToString();
                        compras.Costo = Convert.ToDouble(DatosCompra.Cells["ClCosto"].Value);
                        compras.Margen = float.Parse(DatosCompra.Cells["ClMargen"].Value.ToString());
                        compras.IVA = float.Parse(DatosCompra.Cells["ClIVAProducto"].Value.ToString());
                        compras.GeneraIVA = Convert.ToInt32(DatosCompra.Cells["CLGeneraIVAProducto"].Value);
                        compras.Lote = DatosCompra.Cells["CLLote"].Value.ToString();
                        compras.Serial = DatosCompra.Cells["ClSerial"].Value.ToString();
                        compras.CodigoBarras = DatosCompra.Cells["ClCodigoBarras"].Value.ToString();
                        compras.FechaRegistro = DateTime.Today;
                        compras.HoraRegistro = DateTime.Now;
                        compras.FechaVencimiento = Convert.ToDateTime(DatosCompra.Cells["ClFechaVence"].Value);
                        //consulta id bodega
                        DT = bodega.CargarBodega(true);
                        foreach (DataRow rows in DT.Rows)
                        {
                            if (DatosCompra.Cells["ClBodega"].Value.ToString() == rows["Nombre"].ToString())
                            {
                                compras.IDBodega = Convert.ToInt32(rows["ID"]);
                            }
                        }

                        compras.CodigoUsuario = this.CodigoUsuario;
                        ok = compras.Registrar();

                        if (ok == true)
                        {
                            //Registro en kardex
                            kardex.CodigoUsuario = this.CodigoUsuario;
                            kardex.Modulo = "Compras";
                            ok = kardex.Registrar();

                            if (ok == false)
                            {
                                mENSAJE_ERROR.lblMensaje.Text = "Error al intentar registrar en kardex ";
                                mENSAJE_ERROR.ShowDialog();
                            }
                        }
                        else
                        {
                            mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                            mENSAJE_CONFIRMACION.txtMensaje.Text = "Error en registro de Producto: " + DatosCompra.Cells["ClCodigoProducto"].Value.ToString() + " Desea Continuar registrando ";
                            mENSAJE_CONFIRMACION.ShowDialog();
                            if (mENSAJE_CONFIRMACION.Ok == false)
                            {
                                Continuar = false;
                            }
                        }
                    }
                }

                mENSAJECORRECTO.lblMensaje.Text = "Registro de documento terminado";
                mENSAJECORRECTO.ShowDialog();
                if (Continuar == true) {
                    Limpiar();
                }
                AgregarCompras();
            }
            else
            {
                mENSAJE_ERROR.lblMensaje.Text = "Se deben agregar productos a documento";
                mENSAJE_ERROR.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            Limpiar();
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CalcularTotales()
        {
            double TCantidad = 0;
            double TCosto = 0;
            double TIVA = 0;
            double ValorIVATemp = 0;
            double CostoTemp = 0;
            double TCompra = 0;
            double TCantidadPesaje = 0;

            foreach (DataGridViewRow rows in dtgRegistroCompras.Rows)
            {
                if (rows.Cells["ClDescripcionCantidad"].Value.ToString() == "Unidad")
                {
                    TCantidad += Convert.ToDouble(rows.Cells["ClCantidad"].Value);
                }
                else
                {
                    TCantidadPesaje += Convert.ToDouble(rows.Cells["ClCantidad"].Value);
                }

                CostoTemp = Convert.ToDouble(rows.Cells["ClCosto"].Value) * Convert.ToDouble(rows.Cells["ClCantidad"].Value);
                TCosto += CostoTemp;
                ValorIVATemp = CostoTemp * (Convert.ToDouble(rows.Cells["ClIVAProducto"].Value) / 100);
                TIVA += ValorIVATemp;
                TCompra += CostoTemp + ValorIVATemp;
            }

            txtCantidadTotal.Text = TCantidad.ToString();
            txtCantidadPesaje.Text = TCantidadPesaje.ToString("N");
            txtCostoTotal.Text = TCosto.ToString("N");
            txtIVATotal.Text = TIVA.ToString("N");
            txtCompraTotal.Text = TCompra.ToString("N");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            CalcularTotales();
        }

        private void Agregar()
        {
            errorProvider.Clear();
            Validaciones();
            bool Producto = false;

            if (Validacion == 0)
            {
                foreach (DataGridViewRow produc in dtgRegistroCompras.Rows)
                {
                    if (produc.Cells["ClCodigoProducto"].Value.ToString() == txtProducto.Text && produc.Cells["ClBodega"].Value.ToString() == cbxBodega.Text)
                    {
                        Producto = true;
                    }
                }

                if (Producto == false)
                {
                    errorProvider.Clear();
                    dtgRegistroCompras.Rows.Add(0, cbxDocumento.Text, txtNombreFactura.Text, txtConsecutivo.Text, txtProducto.Text, txtProveedor.Text, txtCantidad.Text,
                    lblModoVenta.Text, txtCosto.Text, txtMargen.Text, txtIVA.Text, 0, txtLote.Text, txtSerial.Text, txtCodigoBarras.Text, dtpFechaVenc.Text,cbxBodega.Text);
                    Limpiar2();
                }
                else
                {
                    errorProvider.SetError(txtProducto,"Producto ya existe en lista");
                }       
            }     
        }

        private void Quitar()
        {
            if (dtgRegistroCompras.CurrentRow != null)
            {
                mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                mENSAJE_CONFIRMACION.txtMensaje.Text = "Esta seguro que desea quitar registro de lista";
                mENSAJE_CONFIRMACION.ShowDialog();
                if (mENSAJE_CONFIRMACION.Ok == true)
                {
                    foreach (DataGridViewRow rows in dtgRegistroCompras.SelectedRows)
                    {
                        dtgRegistroCompras.Rows.RemoveAt(dtgRegistroCompras.CurrentRow.Index);
                    }
                } 
            }
        }

        private bool ValidarIntegridaDocumento()
        {
            ok = true;
            int Contador = 0;
            if (cbxDocumento.Text != "" && txtNombreFactura.Text != "" && txtConsecutivo.Text != "")
            {
                DT = compras.CargarTodo();
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Documento"].ToString() == cbxDocumento.Text && rows["NombreDocumento"].ToString() == txtNombreFactura.Text && rows["ConsecutivoDocumento"].ToString() == txtConsecutivo.Text)
                    {
                        Contador++;
                    }
                }
            }

            if (Contador > 0)
            {
                mENSAJE_ERROR.lblMensaje.Text = "Documento "+cbxDocumento.Text+": "+txtNombreFactura.Text+"-"+txtConsecutivo.Text+" Ya existe";
                mENSAJE_ERROR.ShowDialog();
                ok = false;
            }

            return ok;
        }

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            ok = ValidarIntegridaDocumento();
            if (ok == true)
            {
                Guardar();
            } 
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Quitar();
            CalcularTotales();
        }

        private void Validaciones()
        {
            Validacion = 0;
            errorProvider.Clear();

            //Validacion Documento

            if (toolStripCbxRegistro.SelectedIndex == 0)
            { 
                if (cbxDocumento.Text == "")
                {
                    errorProvider.SetError(cbxDocumento, "Ingrese documento");
                    Validacion++;
                }
                else
                {
                    if (dtgRegistroCompras.Rows.Count > 0)
                    {
                        if (dtgRegistroCompras.Rows[0].Cells["ClDocumento"].Value.ToString() != cbxDocumento.Text)
                        {
                            errorProvider.SetError(cbxDocumento, "Documento NO existe en lista");
                            Validacion++;
                        }
                    }
                }
            }

            if (toolStripCbxRegistro.SelectedIndex == 0)
            { 
                if (txtNombreFactura.Text == "")
                {
                    errorProvider.SetError(txtNombreFactura, "Ingrese nombre de documento");
                    Validacion++;
                }
                else
                {
                    if (dtgRegistroCompras.Rows.Count > 0)
                    {
                        if (dtgRegistroCompras.Rows[0].Cells["ClNombreDocumento"].Value.ToString() != txtNombreFactura.Text)
                        {
                            errorProvider.SetError(txtNombreFactura, "Nombre Documento NO existe en lista");
                            Validacion++;
                        }
                    }
                }
            }

            if (toolStripCbxRegistro.SelectedIndex == 0)
            {
                if (txtConsecutivo.Text == "")
                {
                    errorProvider.SetError(txtConsecutivo, "Ingrese consecutivo documento");
                    Validacion++;
                }
                else
                {
                    if (dtgRegistroCompras.Rows.Count > 0)
                    {
                        if (dtgRegistroCompras.Rows[0].Cells["ClConsecutivoDocumento"].Value.ToString() != txtConsecutivo.Text)
                        {
                            errorProvider.SetError(txtConsecutivo, "Consecutivo Documento NO existe en lista");
                            Validacion++;
                        }
                    }
                }
            }

            if (Validacion == 0)
            {
                DT = compras.VerificacionDocumento(cbxDocumento.Text, txtNombreFactura.Text, txtConsecutivo.Text);
                if (DT.Rows.Count > 0)
                {
                    errorProvider.SetError(txtConsecutivo, " " + cbxDocumento.Text + ": " + txtNombreFactura.Text + "-" + txtConsecutivo.Text + " ya existe");
                    Validacion++;
                }  
            } //Fin Validacion Documento

            //Validacion Producto
            if (txtProducto.Text.Trim() == "")
            {
                errorProvider.SetError(txtProducto, "Ingrese producto");
                Validacion++;
            }
            else
            {
                VerificarProducto();
            }//fin Validacion producto

            //Validacion Proveedor
          
                if (txtProveedor.Text.Trim() == "")
                {
                    errorProvider.SetError(txtProveedor, "Ingrese proveedor");
                    Validacion++;
                }
                else
                {
                    if (dtgRegistroCompras.Rows.Count > 0)
                    {
                        if (dtgRegistroCompras.Rows[0].Cells["ClCodigoProveedor"].Value.ToString() != txtProveedor.Text)
                        {
                            errorProvider.SetError(txtProveedor, "Proveedor NO existe en lista");
                            Validacion++;
                        }
                    }

                    VerificarProveedor();
                }//Fin validacion proveedor

            if (txtCantidad.Text.Trim() == "")
            {
                errorProvider.SetError(txtCantidad, "Ingrese cantidad");
                Validacion++;
            }
            else
            {
               ok = ValidacionCantidad();
                if (ok != true)
                {
                    Validacion++;
                }
            }

            if (txtCosto.Text.Trim() == "")
            {
                errorProvider.SetError(txtCosto, "Ingrese costo");
                Validacion++;
            }
            else
            {
                ok = ValidacionCosto();
                if (ok != true)
                {
                    Validacion++;
                }
            }

            if (txtCostoMasIVA.Text.Trim() == "")
            {
                errorProvider.SetError(txtCostoMasIVA, "Ingrese costo mas iva");
                Validacion++;
            }
            else
            {
                ok = ValidacionCostoMasIVA();
                if (ok != true)
                {
                    Validacion++;
                }
            }

            if (txtIVA.Text.Trim() == "")
            {
                errorProvider.SetError(txtIVA, "Ingrese IVA");
                Validacion++;
            }

            if (txtMargen.Text.Trim() == "")
            {
                errorProvider.SetError(txtMargen, "Ingrese margen");
                Validacion++;
            }

            if (cbxBodega.Text == "")
            {
                errorProvider.SetError(cbxBodega, "Seleccione Bodega");
                Validacion++;
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                ok = general.IsNumericDouble(txtCantidad.Text);
                if (ok == true)
                {
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(txtCantidad,"Ingrese valores numericos");
                }
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text != "")
            {
                ok = general.IsNumericDouble(txtCosto.Text);
                if (ok == true)
                {
                    errorProvider.Clear();
                    Costo = Convert.ToDouble(txtCosto.Text);
                    txtCosto.Text = Costo.ToString("N");
                }
                else
                {
                    errorProvider.SetError(txtCosto, "Ingrese valores numericos");
                }
            }
        }

        private void txtCostoMasIVA_Leave(object sender, EventArgs e)
        {
            if (txtCostoMasIVA.Text != "")
            {
                ok = general.IsNumericDouble(txtCostoMasIVA.Text);
                if (ok == true)
                {
                    errorProvider.Clear();
                    CostoMasIVA = Convert.ToDouble(txtCostoMasIVA.Text);
                    txtCostoMasIVA.Text = CostoMasIVA.ToString("N");
                }
                else
                {
                    errorProvider.SetError(txtCostoMasIVA, "Ingrese valores numericos");
                }
            }
        }

        private bool ValidacionCantidad()
        {
            if (txtCantidad.Text.Trim() != "")
            {
                if (general.IsNumericDouble(txtCantidad.Text) == true)
                {
                    if (Convert.ToDouble(txtCantidad.Text) > 0)
                    {
                        ok = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtCantidad, "Valor debe ser mayor a Cero(0)");
                        txtValorIVA.Text = "";
                        txtSubtalCompra.Text = "";
                        ok = false;
                    }
                }
                else
                {
                    errorProvider.SetError(txtCantidad, "Debe ingresar valores numericos");
                    txtValorIVA.Text = "";
                    txtSubtalCompra.Text = "";
                    ok = false;
                }
            }
            else
            {
                txtValorIVA.Text = "";
                txtSubtalCompra.Text = "";
                ok = false;
            }

            return ok;
        }

        private bool ValidacionCosto()
        {
            if (txtCosto.Text.Trim() != "")
            {
                ok = general.IsNumericDouble(txtCosto.Text);
                if (ok == true)
                {
                    if (Convert.ToDouble(txtCosto.Text) > 0)
                    {
                        ok = ValidacionCantidad();
                        if (ok == true)
                        {
                            //Calcular Costo + IVA, Valor IVA,Valor subtotal compra 
                            CalculoPrecioConIVA();
                        }
                        else
                        {
                            txtCostoMasIVA.Text = "";
                            txtValorIVA.Text = "";
                            txtSubtalCompra.Text = "";
                        }
                        ok = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtCosto, "Valor debe ser mayor a Cero(0)");
                        txtCostoMasIVA.Text = "";
                        txtValorIVA.Text = "";
                        txtSubtalCompra.Text = "";
                        ok = false;
                    }
                }
                else
                {
                    errorProvider.SetError(txtCosto, "Ingrese valores numericos");
                    txtCostoMasIVA.Text = "";
                    txtValorIVA.Text = "";
                    txtSubtalCompra.Text = "";
                    ok = false;
                }
            }
            else
            {
                txtCostoMasIVA.Text = "";
                txtValorIVA.Text = "";
                txtSubtalCompra.Text = "";
                ok = false;
            }

            return ok;
        }

        private bool ValidacionCostoMasIVA()
        {
            if (txtCostoMasIVA.Text.Trim() != "")
            {
                ok = general.IsNumericDouble(txtCostoMasIVA.Text);
                if (ok == true)
                {
                    if (Convert.ToDouble(txtCostoMasIVA.Text) > 0)
                    {
                        ok = ValidacionCantidad();
                        if (ok == true)
                        {
                            //Calcular Costo, Valor IVA,Valor subtotal compra 
                            CalularPrecioSinIVA();
                        }
                        else
                        {
                            txtCosto.Text = "";
                            txtValorIVA.Text = "";
                            txtSubtalCompra.Text = "";
                        }
                        ok = true;
                    }
                    else
                    {
                        errorProvider.SetError(txtCosto, "Valor debe ser mayor a Cero(0)");
                        txtCosto.Text = "";
                        txtValorIVA.Text = "";
                        txtSubtalCompra.Text = "";
                        ok = false;
                    }
                }
                else
                {
                    errorProvider.SetError(txtCosto, "Ingrese valores numericos");
                    txtCosto.Text = "";
                    txtValorIVA.Text = "";
                    txtSubtalCompra.Text = "";
                    ok = false;
                }
            }
            else
            {
                txtCosto.Text = "";
                txtValorIVA.Text = "";
                txtSubtalCompra.Text = "";
                ok = false;
            }

            return ok;
        }

        private void txtCosto_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider.Clear();
            ValidacionCosto();
        }

        private void CalculoPrecioConIVA()
        {
            if (txtIVA.Text.Trim() == "")
            {
                txtIVA.Text = "0";
            }

            SubTotalCompra = 0;
            ValorIVA = (Convert.ToDouble(txtCosto.Text) * (Convert.ToDouble(txtIVA.Text) / 100));
            CostoMasIVA = Convert.ToDouble(txtCosto.Text) + ValorIVA;
            txtCostoMasIVA.Text = CostoMasIVA.ToString("N");
            txtValorIVA.Text = ValorIVA.ToString("N");
            SubTotalCompra = (Convert.ToDouble(txtCosto.Text) * Convert.ToDouble(txtCantidad.Text)) + (ValorIVA * Convert.ToDouble(txtCantidad.Text));
            txtSubtalCompra.Text = SubTotalCompra.ToString("N");
        }

        private void CalularPrecioSinIVA()
        {
            if (txtIVA.Text.Trim() == "")
            {
                txtIVA.Text = "0";
            }

            SubTotalCompra = 0;
            Costo = Convert.ToDouble(txtCostoMasIVA.Text) / ((Convert.ToDouble(txtIVA.Text) / 100) + 1);
            txtCosto.Text = Costo.ToString("N");
            ValorIVA = Convert.ToDouble(txtCostoMasIVA.Text) - Costo;
            txtValorIVA.Text = ValorIVA.ToString("N");
            SubTotalCompra = (Convert.ToDouble(txtCostoMasIVA.Text) * Convert.ToDouble(txtCantidad.Text));
            txtSubtalCompra.Text = SubTotalCompra.ToString("N2");
        }

        private void CalcularValorVenta(string Margen)
        {
            txtMargen.Text = Margen;
            if (Margen != "")
            {
                if (general.IsNumericDouble(Margen) == true)
                {
                    errorProvider.Clear();

                    double ValorVenta = 0;
                    if (txtCosto.Text != "")
                    {
                        if (general.IsNumericDouble(txtCosto.Text) == true)
                        {
                            errorProvider.Clear();
                            ValorVenta = Convert.ToDouble(txtCosto.Text) / (1 - (Convert.ToDouble(Margen) / 100));
                            txtValorVenta.Text = ValorVenta.ToString("N");
                        }
                        else
                        {
                            txtValorVenta.Text = "";
                            errorProvider.SetError(txtCosto, "Ingrese valores numericos");
                        }
                    }

                }
                else
                {
                    txtValorVenta.Text = "";
                    errorProvider.SetError(txtMargen, "Ingrese valores numericos");
                }
            }
            else
            {
                txtValorVenta.Text = "";
                errorProvider.Clear();
            }
        }

        private void txtCostoMasIVA_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider.Clear();
            ValidacionCostoMasIVA();
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider.Clear();
            ValidacionCantidad();
        }

        private void txtMargen_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularValorVenta(txtMargen.Text);
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            VerificarProducto();
            Validaciones();
        }

        private bool VerificarProducto()
        {
            if (txtProducto.Text.Trim() != "")
            {
                DT = producto.CargarProducto("pd.Item", txtProducto.Text, "AyudaUnico");
                if (DT.Rows.Count > 0)
                {
                    Rows = DT.Rows[0];
                    lblNombreProducto.Text = Rows["Nombre"].ToString();
                    txtIVA.Text = Rows["iva"].ToString();
                    if (Rows["ModoVenta"].ToString() == "Pesaje")
                    {
                        lblModoVenta.Text = Rows["UnidadMedida"].ToString();
                    }
                    else
                    {
                        lblModoVenta.Text = Rows["ModoVenta"].ToString();
                    }                  
                }
                else
                {
                    errorProvider.SetError(txtProducto, "Producto no esta disponible");
                    lblNombreProducto.Text = "- - - - - - - - ";
                    lblModoVenta.Text = "Unidad";
                    txtIVA.Text = "0";
                    Validacion++;
                    ok = false;
                }
            }
            else
            {
                lblNombreProducto.Text = "- - - - - - - - ";
                lblModoVenta.Text = "Unidad";
                ok = false;
            }

            return ok;
        }

        private void txtNombreFactura_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtConsecutivo_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
        }

        private void txtProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            VerificarProveedor();
            Validaciones();
        }

        private void VerificarProveedor()
        {
            if (txtProveedor.Text.Trim() != "")
            {
                DT = proveedor.CargarProveedor("DNI", txtProveedor.Text, "AyudaUnico");
                if (DT.Rows.Count > 0)
                {
                    Rows = DT.Rows[0];
                    lblNombreProveedor.Text = Rows["RazonSocial"].ToString();
                }
                else
                {
                    errorProvider.SetError(txtProveedor, "Proveedor no esta disponible");
                    lblNombreProveedor.Text = "- - - - - - - - ";
                    Validacion++;
                }
            }
            else
            {
                lblNombreProveedor.Text = "- - - - - - - - ";
            }
        }

        private void CargarProducto(string Producto)
        {
            txtProducto.Text = Producto;
            VerificarProducto();
        }

        private void CargarProveedor(string Proveedor)
        {
            txtProveedor.Text = Proveedor;
            VerificarProveedor();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            aYUDA.Modulo = "Producto";
            aYUDA.EnviaProductos += new AYUDA.EnviaProducto(CargarProducto);
            aYUDA.ShowDialog();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            aYUDA.Modulo = "Proveedor";
            aYUDA.EnviaProveedores += new AYUDA.EnviaProveedor(CargarProveedor);
            aYUDA.ShowDialog();
        }

        private void Limpiar()
        {
            errorProvider.Clear();
            cbxDocumento.SelectedIndex = 0;
            txtNombreFactura.Text = "";
            txtConsecutivo.Text = "";
            txtProducto.Text = "";
            lblNombreProducto.Text = "- - - - - - - - ";
            txtProveedor.Text = "";
            lblNombreProveedor.Text = "- - - - - - - - ";
            txtCantidad.Text = "";
            lblModoVenta.Text = "Unidad";
            txtCosto.Text = "";
            txtCostoMasIVA.Text = "";
            txtIVA.Text = "";
            txtValorIVA.Text = "";
            txtSubtalCompra.Text = "";
            dtpFechaVenc.Value = DateTime.Today;
            txtMargen.Text = "";
            txtValorVenta.Text = "";
            txtLote.Text = "";
            txtSerial.Text = "";
            txtCodigoBarras.Text = "";
            dtgRegistroCompras.Rows.Clear();
            txtCantidadTotal.Text = "";
            txtIVATotal.Text = "";
            txtCompraTotal.Text = "";
            txtCostoTotal.Text = "";
            txtCantidadPesaje.Text = "";
        }

        private void Limpiar2()
        {
            errorProvider.Clear();
           
            txtProducto.Text = "";
            lblNombreProducto.Text = "- - - - - - - - ";
            txtCantidad.Text = "";
            lblModoVenta.Text = "Unidad";
            txtCosto.Text = "";
            txtCostoMasIVA.Text = "";
            txtIVA.Text = "";
            txtValorIVA.Text = "";
            txtSubtalCompra.Text = "";
            dtpFechaVenc.Value = DateTime.Today;
            txtMargen.Text = "";
            txtValorVenta.Text = "";
            txtLote.Text = "";
            txtSerial.Text = "";
            txtCodigoBarras.Text = "";
        }

        private void toolStripBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar2();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ok = ValidacionCosto();
            if (ok == true)
            {
                calcularMargen.MargenVentas += new CalcularMargen.EnviaMargenVenta(CalcularValorVenta);
                calcularMargen.Producto = txtProducto.Text;
                calcularMargen.Costos = txtCosto.Text;
                calcularMargen.ShowDialog();
            }
            else
            {
                errorProvider.SetError(btnCalcular,"Ingrese costo");
            }    
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
            mENSAJE_CONFIRMACION.txtMensaje.Text = "Esta seguro que desea crear un nuevo documento";
            mENSAJE_CONFIRMACION.ShowDialog();
            if (mENSAJE_CONFIRMACION.Ok == true)
            {
                Limpiar();
            }
        }

        private void EnviarDatos()
        {
            foreach (DataGridViewRow rows in dtgRegistroCompras.SelectedRows)
            {
                dETALLE_COMPRAS.txtDocumento.Text = rows.Cells["ClDocumento"].Value.ToString();
                dETALLE_COMPRAS.txtNombreDoc.Text = rows.Cells["ClNombreDocumento"].Value.ToString();
                dETALLE_COMPRAS.txtConsecutivoDoc.Text = rows.Cells["ClConsecutivoDocumento"].Value.ToString();
                dETALLE_COMPRAS.txtItemProd.Text = rows.Cells["ClCodigoProducto"].Value.ToString();
                DT = producto.CargarProducto("pd.Item", rows.Cells["ClCodigoProducto"].Value.ToString(),"Unico");
                Rows = DT.Rows[0];
                dETALLE_COMPRAS.txtNombreProd.Text = Rows["Nombre"].ToString();
                dETALLE_COMPRAS.txtDNIProveedor.Text = rows.Cells["ClCodigoProveedor"].Value.ToString();
                DT = proveedor.CargarProveedor("DNI", rows.Cells["ClCodigoProveedor"].Value.ToString(),"Unico");
                Rows = DT.Rows[0];
                dETALLE_COMPRAS.txtRazonSocial.Text = Rows["RazonSocial"].ToString();
                dETALLE_COMPRAS.txtNombreComercial.Text = Rows["NombreComercial"].ToString();
                dETALLE_COMPRAS.txtCantidad.Text = rows.Cells["ClCantidad"].Value.ToString();
                dETALLE_COMPRAS.txtDescripcionCantidad.Text = rows.Cells["ClDescripcionCantidad"].Value.ToString();
                dETALLE_COMPRAS.txtCosto.Text = rows.Cells["ClCosto"].Value.ToString();
                dETALLE_COMPRAS.txtMargen.Text = rows.Cells["ClMargen"].Value.ToString();
                dETALLE_COMPRAS.txtIVA.Text = rows.Cells["ClIVAProducto"].Value.ToString();
                dETALLE_COMPRAS.txtLote.Text = rows.Cells["CLLote"].Value.ToString();
                dETALLE_COMPRAS.txtSerial.Text = rows.Cells["ClSerial"].Value.ToString();
                dETALLE_COMPRAS.txtCodigoBarras.Text = rows.Cells["ClCodigoBarras"].Value.ToString();
                dETALLE_COMPRAS.txtFechaVence.Text = rows.Cells["ClFechaVence"].Value.ToString();
                dETALLE_COMPRAS.txtbodega.Text = rows.Cells["ClBodega"].Value.ToString();
            }

            dETALLE_COMPRAS.ShowDialog();
        }

        private void dtgRegistroCompras_DoubleClick(object sender, EventArgs e)
        {
            EnviarDatos();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CargarBodega()
        {
            DT = bodega.CargarBodega(true);
            cbxBodega.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    cbxBodega.Items.Add(rows["Nombre"]);
                }
                cbxBodega.SelectedIndex = 0;
            }
        }

        private void toolStripCbxRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaREgistroDocumentos();

        }
    }
}
