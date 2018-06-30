using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;
using System.Data;

namespace SBX
{
    public partial class VENTAS_MESAS : Form
    {   
        DataTable DT;
        DataRow rows;
        Double cont = 1;
        int CodigoUsuario = 0;        
        int agregarArticulos = 0;

        public string Usuario { get; set; }
        CONTROLLER.Caja cj = new CONTROLLER.Caja();
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        MENSAJECORRECTO msgCorrecto = new MENSAJECORRECTO();
        CONTROLLER.Usuario usuario = new CONTROLLER.Usuario();        
        MENSAJE_CONFIRMACION msgConfirmacion = new MENSAJE_CONFIRMACION();
        List<REGISTRO_VENTASS> listVentasMesas = new List<REGISTRO_VENTASS>();

        public VENTAS_MESAS()
        {
            InitializeComponent();
        }

        private void VENTAS_MESAS_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            cargarMesas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void CargarUsuario()
        {
            DT = usuario.Cargar(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow perso in DT.Rows)
                {
                    if (perso["Usuario"].ToString() == Usuario)
                    {
                        CodigoUsuario = Convert.ToInt32(perso["CodigoUsuario"]);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo que me agrega objetos en el panel
        /// </summary>
        /// <param name="opcion">Me dice si me llama la ventana para crear una nueva mesa desde cero (0) o si la cargo de la bd (1)</param>
        /// <param name="nomBoton"></param>
        /// <param name="nomMesa"></param>
        /// <param name="detalle"></param>
        /// <param name="coorX"></param>
        /// <param name="coorY"></param>
        /// <param name="largo"></param>
        /// <param name="ancho"></param>
        private void agregarMesa(String opcion, String nomBoton = "", String nomMesa = "", String detalle = "", int coorX = 0, int coorY = 0, int largo = 0, int ancho = 0)
        {
            Button oButton = new Button();

            if (opcion.Equals("0"))
            {
                DETALLE_MESA oDetMesa = new DETALLE_MESA();
                oDetMesa.ShowDialog();
                nomBoton = "btn" + cont;
                nomMesa = oDetMesa.nombre;
                detalle = oDetMesa.detalle;
                coorX = (contenedor.Width / 2);
                coorY = (contenedor.Height / 2);
                largo = 30;
                ancho = 100;
            }

            oButton.Name = nomBoton;
            oButton.Text = nomMesa;
            oButton.Tag = detalle;
            oButton.Height = largo;
            oButton.Width = ancho;
            oButton.Location = new Point(coorX, coorY);

            /*
            oButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            oButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            oButton.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            */
            oButton.Click += new System.EventHandler(this.control_Click);

            contenedor.Controls.Add(oButton);
            cont++;
        }

        private void cargarMesas()
        {
            contenedor.Controls.Clear();
            DataTable dtDatos = new DataTable();
            CONTROLLER.Mesa oMesa = new CONTROLLER.Mesa();
            dtDatos = oMesa.buscar("");

            if (dtDatos.Rows.Count > 0)
            {
                for (int x = 0; x <= dtDatos.Rows.Count - 1; x++)
                {
                    agregarMesa("1",
                                dtDatos.Rows[x]["nomBoton"].ToString(),
                                dtDatos.Rows[x]["nomMesa"].ToString(),
                                dtDatos.Rows[x]["detalle"].ToString(),
                                int.Parse(dtDatos.Rows[x]["coordenadax"].ToString()),
                                int.Parse(dtDatos.Rows[x]["coordenaday"].ToString()),
                                int.Parse(dtDatos.Rows[x]["largo"].ToString()),
                                int.Parse(dtDatos.Rows[x]["ancho"].ToString()));

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cj.Usuario = CodigoUsuario;
            DT = cj.CargarCaja();
            if (DT.Rows.Count > 0)
            {
                rows = DT.Rows[0];
                if (rows["TipoOperacion"].ToString() == "Cierre")
                {
                    msgConfirmacion.txtMensaje.Text = "No se ha realizado apertura caja, desea continuar ";
                    msgConfirmacion.Modulo = "Confirmacion";
                    msgConfirmacion.ShowDialog();
                    if (msgConfirmacion.Ok)
                    {
                        AgregarVenta();
                    }
                }
                else
                {
                    AgregarVenta();
                }
            }
            else
            {
                msgConfirmacion.txtMensaje.Text = "No se ha realizado apertura caja, desea continuar ";
                msgConfirmacion.Modulo = "Confirmacion";
                msgConfirmacion.ShowDialog();

                if (msgConfirmacion.Ok)
                {
                    AgregarVenta();
                }
            }
        }

        private void AgregarVenta()
        {
            if (agregarArticulos == 0)
            {
                agregarArticulos = 1;
            }
            else
            {
                agregarArticulos = 0;
            }
        }

        private void control_Click(object sender, EventArgs e)
        {
            if (agregarArticulos == 1)
            {
                bool regProducto = false;
                Button btn = (Button)sender;

                if (listVentasMesas.Count > 0)
                {
                    Boolean encontro = false;

                    for (int x = 0; x <= listVentasMesas.Count - 1; x++)
                    {
                        if (listVentasMesas[x].Name.ToString().Equals(btn.Name.ToString()))
                        {
                            encontro = true;
                            listVentasMesas[x].ShowDialog();
                        }                        
                    }

                    if (!encontro)
                    {
                        REGISTRO_VENTASS regVentas = new REGISTRO_VENTASS(btn.Text, btn.Name.ToString());
                        regVentas.Usuario = this.Usuario;
                        //regVentas.AgregarVenta += new REGISTRO_VENTASS.AgregaVentas(CargarVentas);
                        regVentas.Name = btn.Name;
                        listVentasMesas.Add(regVentas);
                        regVentas.ShowDialog();
                        regProducto = regVentas.registroProductos;
                    }
                }
                else
                {
                    REGISTRO_VENTASS regVentas = new REGISTRO_VENTASS(btn.Text, btn.Name.ToString());
                    regVentas.Usuario = this.Usuario;
                    //regVentas.AgregarVenta += new REGISTRO_VENTASS.AgregaVentas(CargarVentas);
                    regVentas.Name = btn.Name;
                    listVentasMesas.Add(regVentas);
                    regVentas.ShowDialog();
                    
                }


                for (int x = 0; x <= listVentasMesas.Count - 1; x++)
                {
                    if (listVentasMesas[x].Name.ToString().Equals(btn.Name.ToString()))
                    {
                        regProducto = listVentasMesas[x].registroProductos;
                    }
                }

                if (regProducto)
                {
                    btn.BackColor = Color.OrangeRed;
                }
                else
                {
                    btn.BackColor = Color.Transparent;
                }
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        
        private void limpiar()
        {
            agregarArticulos = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (listVentasMesas.Count > 0)
            {
                msgConfirmacion.Modulo = "Confirmacion";
                msgConfirmacion.txtMensaje.Text = "Las transacciones actuales que no se hayan guardado se perderan, esta seguro que desea continuar?";
                msgConfirmacion.ShowDialog();

                if (msgConfirmacion.Ok)
                {
                    cargarMesas();
                }
            }
            else
            {
                cargarMesas();
            }
            
        }
    }
}
