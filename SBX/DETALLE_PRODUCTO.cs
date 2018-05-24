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
using SBX.CONTROLLER;

namespace SBX
{
    public partial class DETALLE_PRODUCTO : Form
    {
        //Delegado 
        public delegate void AgregaProductos();
        public event AgregaProductos AgregarProductos;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DETALLE_PRODUCTO));
        General general = new General();
      
        Estado Estado = new Estado();
        Marca marca = new Marca();
        Producto producto = new Producto();
        Presentacion presentacion = new Presentacion();
        Categoria categoria = new Categoria();
        ModoVenta modoVenta = new ModoVenta();
        UnidadMedida unidadMedida = new UnidadMedida();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable DT;
        DataRow row;
        bool OK = true;
        int Validado = 0;
        int CodigoUsuario;
        public bool Agregar_ { get; set; }
        public string UnidadMedida { get; set; }
        public string Estados { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Presentacion { get; set; }
        public string ModoVenta { get; set; }
        public Image Foto { get; set; }
        public string NombreUsuario { get; set; }

        //// Create a new form.
        Form mdiChildForm = new Form();

        public DETALLE_PRODUCTO()
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

        private void DETALLE_PRODUCTO_Load(object sender, EventArgs e)
        {
            VerificaAccion();
            CargarCombobox();
            if (Agregar_ == false)
            {
                errorProvider.Clear();
                DetalleProducto();
            }
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

        private void VerificaAccion()
        {
            if (Agregar_ == true)
            {
                txtItem.Enabled = true;
            }
            else
            {
                txtItem.Enabled = false;
            }
        }

        private void CargarCombobox()
        {
            CargarEstado();
            CargarMarca();
            CargarCategoria();
            CargarPresentacion();
            CargarModoVenta();
            CargarUnidadMedida();
        }

        private void CargarEstado()
        {
            DT = Estado.CargaEstado(true);
            cbxEstado.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxEstado.Items.Add(row["Estado"]);
                }
                cbxEstado.SelectedIndex = 0;
            }
        }

        private void CargarMarca()
        {
            DT = marca.CargaMarca(true);
            cbxMarca.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxMarca.Items.Add(row["Nombre"]);
                }
                cbxMarca.SelectedIndex = 0;
            }
        }

        private void CargarCategoria()
        {
            DT = categoria.CargaCategoria(true);
            cbxCategoria.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxCategoria.Items.Add(row["Nombre"]);
                }
                cbxCategoria.SelectedIndex = 0;
            }
        }

        private void CargarPresentacion()
        {
            DT = presentacion.CargaPresentacion(true);
            cbxPresentacion.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxPresentacion.Items.Add(row["Nombre"]);
                }
                cbxPresentacion.SelectedIndex = 0;
            }
        }

        private void CargarModoVenta()
        {
            DT = modoVenta.CargaModoVenta(true);
            cbxModoVenta.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxModoVenta.Items.Add(row["Nombre"]);
                }
                cbxModoVenta.SelectedIndex = 0;
            }
        }

        private void CargarUnidadMedida()
        {
            DT = unidadMedida.CargaUnidadMedida(true);
            cbxUnidadMedida.Items.Clear();
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cbxUnidadMedida.Items.Add(row["Nombre"]);
                }
                cbxUnidadMedida.SelectedIndex = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DETALLE_PRODUCTO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void CargarFoto()
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbxFoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            CargarFoto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void AsignaProducto()
        {
            int IdEstado = 1;
            int IdMarca = 1;
            int IdCategoria = 1;
            int IdPresentacion = 1;
            int IdModoVenta = 1;
            int IdUnidadMedida = 1;
            int AplicaFechaVence = 0;
            int GeneraIVA = 0;

            DataRow rows;

            Estado estado = new Estado();
            if (cbxEstado.Text != "")
            {
                estado.Nombre_ = cbxEstado.Text;
                DT = estado.CargaEstado(false);
                rows = DT.Rows[0];
                IdEstado = Convert.ToInt32(rows["IdEstado"]);
            }
            Marca marca = new Marca();
            if (cbxMarca.Text != "")
            {
                marca.Nombre_ = cbxMarca.Text;
                DT = marca.CargaMarca(false);
                rows = DT.Rows[0];
                IdMarca = Convert.ToInt32(rows["ID"]);
            }
            Categoria categoria = new Categoria();
            if (cbxCategoria.Text != "")
            {
                categoria.Nombre_ = cbxCategoria.Text;
                DT = categoria.CargaCategoria(false);
                rows = DT.Rows[0];
                IdCategoria = Convert.ToInt32(rows["ID"]);
            }
            Presentacion presentacion = new Presentacion();
            if (cbxPresentacion.Text != "")
            {
                presentacion.Nombre_ = cbxPresentacion.Text;
                DT =presentacion.CargaPresentacion(false);
                rows = DT.Rows[0];
                IdPresentacion = Convert.ToInt32(rows["ID"]);
            }
            ModoVenta modoVenta = new ModoVenta();
            if (cbxModoVenta.Text != "")
            {
                modoVenta.Nombre_ = cbxModoVenta.Text;
                DT = modoVenta.CargaModoVenta(false);
                rows = DT.Rows[0];
                IdModoVenta = Convert.ToInt32(rows["ID"]);
            }
            UnidadMedida unidadMedida = new UnidadMedida();
            if (cbxUnidadMedida.Text != "")
            {
                unidadMedida.Nombre_ = cbxUnidadMedida.Text;
                DT = unidadMedida.CargaUnidadMedida(false);
                rows = DT.Rows[0];
                IdUnidadMedida = Convert.ToInt32(rows["ID"]);
            }

            producto.Item_ = txtItem.Text;
            producto.Referencia_ = txtReferencia.Text;
            producto.Nombre_ = txtNombre.Text;
            producto.IVA_ = float.Parse(txtIVA.Text);
            producto.UnidadMedida_ = IdUnidadMedida;
            producto.Stock_ = Convert.ToDecimal(txtStock.Text);
            producto.StockMaximo = Convert.ToDecimal(txtStockMaximo.Text);
            producto.Descripcion_ = txtDescripcion.Text;
            if (chkAplicaFechaV.Checked == true)
            {
                AplicaFechaVence = 1;
            }
            producto.AplicaFechaVence_ = AplicaFechaVence;
            producto.Estado_ = IdEstado;
            producto.marca_ = IdMarca;
            producto.categoria_ = IdCategoria;
            producto.presentacion_ = IdPresentacion;
            producto.modoVenta_ = IdModoVenta;
            producto.Medida_ = txtMedida.Text;
            producto.Foto_ = pbxFoto.Image;

            producto.DiasFechaVence = Convert.ToInt32(txtAlertaFechaVenc.Text);
            if (chkGeneraIVA.Checked == true)
            {
                GeneraIVA = 1;
            }
            producto.GeneraIVA_ = GeneraIVA;
        }

        private void RellenaCampos()
        {
            if (txtIVA.Text == "")
            {
                txtIVA.Text = "0";
            }
            if (txtStock.Text == "")
            {
                txtStock.Text = "0";
            }
            if (txtStockMaximo.Text == "")
            {
                txtStockMaximo.Text = "0";
            }
            if (txtAlertaFechaVenc.Text == "")
            {
                txtAlertaFechaVenc.Text = "0";
            }
            if (txtMedida.Text == "")
            {
                txtMedida.Text = "0";
            }
        }

        private void Guardar()
        {
            ValidacionCampos();
            if (Validado == 0)
            {
                RellenaCampos();
                AsignaProducto();

                Usuario usuario = new Usuario();
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

                if (Agregar_ == true)
                {
                    OK = producto.Registrar();
                }
                else
                {
                    OK = producto.Modificar();
                }

                if (OK == true)
                {
                    MENSAJECORRECTO mENSAJECORRECTO = new MENSAJECORRECTO();
                    
                    if (Agregar_ == true)
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Producto guardado correctamente";
                        limpiar();
                        AgregarProductos();
                    }
                    else
                    {
                        mENSAJECORRECTO.lblMensaje.Text = "Producto modificado correctamente";
                        limpiar();
                        AgregarProductos();
                    }
                    mENSAJECORRECTO.ShowDialog();
                    this.Close();
                }
                else
                {
                    MENSAJE_ERROR mENSAJE_ERROR = new MENSAJE_ERROR();
                    if (Agregar_ == true)
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "Error al intentar guardar producto";
                    }
                    else
                    {
                        mENSAJE_ERROR.lblMensaje.Text = "Error al intentar modificar producto";
                    }

                    mENSAJE_ERROR.ShowDialog();
                }
            }
        }

        private void BuscaItem()
        {
            DT = producto.CargarProducto("pd.Item", txtItem.Text, "Unico");
            if (DT.Rows.Count > 0)
            {
                row = DT.Rows[0];
                if (txtItem.Text == row["Item"].ToString())
                {
                    errorProvider.SetError(txtItem, "Item ya existe");
                    Validado--;
                }
            }
        }

        private void ValidacionCampos()
        {
            Validado = 0;

            if (txtItem.Text == "")
            {
                errorProvider.SetError(txtItem, "Ingrese item");
                Validado--;
            }
            else
            {
                if (Agregar_ == true)
                {
                    BuscaItem();
                }  
            }
            if (txtNombre.Text == "")
            {
                errorProvider.SetError(txtNombre, "Ingrese nombre");
                Validado--;
            }
            if (cbxUnidadMedida.Text == "")
            {
                errorProvider.SetError(cbxUnidadMedida, "Seleccione unidad medida");
                Validado--;
            }
            if (cbxEstado.Text == "")
            {
                errorProvider.SetError(cbxEstado, "Seleccione estado");
                Validado--;
            }
            if (cbxMarca.Text == "")
            {
                errorProvider.SetError(cbxMarca, "Seleccione marca");
                Validado--;
            }
            if (cbxCategoria.Text == "")
            {
                errorProvider.SetError(cbxCategoria, "Seleccione categoria");
                Validado--;
            }
            if (cbxPresentacion.Text == "")
            {
                errorProvider.SetError(cbxPresentacion, "Seleccione presentacion");
                Validado--;
            }
            if (cbxModoVenta.Text == "")
            {
                errorProvider.SetError(cbxModoVenta, "Seleccione modo venta");
                Validado--;
            }

            if (txtIVA.Text != "")
            {
                OK = general.IsNumericFloat(txtIVA.Text);
                if (OK == false)
                {
                    errorProvider.SetError(txtIVA, "Ingrese valor numerico");
                    Validado--;
                }
            }

            if (txtStock.Text != "")
            {
                OK = general.IsNumericFloat(txtStock.Text);
                if (OK == false)
                {
                    errorProvider.SetError(txtStock, "Ingrese valor numerico");
                    Validado--;
                }
            }

            if (txtMedida.Text != "")
            {
                OK = general.IsNumericFloat(txtMedida.Text);
                if (OK == false)
                {
                    errorProvider.SetError(txtMedida, "Ingrese valor numerico");
                    Validado--;
                }
            }
        }

        private void txtItem_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbxUnidadMedida_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbxEstado_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbxMarca_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbxCategoria_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbxPresentacion_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void cbxModoVenta_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void ValidaIVA()
        {
            if (txtMedida.Text != "")
            {
                OK = general.IsNumericFloat(txtIVA.Text);
                if (OK == false)
                {
                    errorProvider.SetError(txtIVA, "Ingrese valor numerico");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaIVA();
        }

        private void ValidaStock()
        {
            if (txtStock.Text != "")
            {
                OK = general.IsNumericDecimal(txtStock.Text);
                if (OK == false)
                {
                    errorProvider.SetError(txtStock, "Ingrese valor numerico");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaStock();
        }

        private void ValidaMedida()
        {
            if (txtMedida.Text != "")
            {
                OK = general.IsNumericDecimal(txtMedida.Text);
                if (OK == false)
                {
                    errorProvider.SetError(txtMedida, "Ingrese valor numerico");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtMedida_KeyUp(object sender, KeyEventArgs e)
        {
            ValidaMedida();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            errorProvider.Clear();
            txtItem.Text = "";
            txtReferencia.Text = "";
            txtNombre.Text = "";
            txtIVA.Text = "";
            txtStock.Text = "";
            txtDescripcion.Text = "";
            if (cbxUnidadMedida.Text != "")
            {
                cbxUnidadMedida.SelectedIndex = 0;
            }
            txtMedida.Text = "";
            chkAplicaFechaV.Checked = false;
            chkGeneraIVA.Checked = false;
            if (cbxEstado.Text != "")
            {
                cbxEstado.SelectedIndex = 0;
            }
            if (cbxMarca.Text != "")
            {
                cbxMarca.SelectedIndex = 0;
            }
            if (cbxCategoria.Text != "")
            {
                cbxCategoria.SelectedIndex = 0;
            }
            if (cbxPresentacion.Text != "")
            {
                cbxPresentacion.SelectedIndex = 0;
            }
            if (cbxModoVenta.Text != "")
            {
                cbxModoVenta.SelectedIndex = 0;
            }
            pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
        }

        public void DetalleProducto()
        {
            cbxUnidadMedida.Text = UnidadMedida;
            cbxEstado.Text = Estados;
            cbxMarca.Text = Marca;
            cbxCategoria.Text = Categoria;
            cbxPresentacion.Text = Presentacion;
            cbxModoVenta.Text = ModoVenta;
            pbxFoto.Image = Foto;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtStockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }

        private void txtAlertaFechaVenc_KeyPress(object sender, KeyPressEventArgs e)
        {
            general.ValidaNumeros(e);
        }
    }
}
