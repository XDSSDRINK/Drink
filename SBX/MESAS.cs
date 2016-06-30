using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;
using System.Data;

namespace SBX
{
    public partial class MESAS : Form
    {        
        double cont = 1;
        int seleccionar = 0, editar = 0;
        MENSAJE_ERROR msgError = new MENSAJE_ERROR();
        List<String> listEliminar = new List<String>();
        MENSAJECORRECTO msgCorrecto = new MENSAJECORRECTO();
        List<CONTROLLER.Mesa> listaMesa = new List<CONTROLLER.Mesa>();

        #region Declaracion de variables y dlls
        int DY, DX;
        //
        //' Declaraciones del API para 32 bits
        [DllImport("user32.DLL", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(
            int hWnd,	// handle to window
            int nIndex	// offset of value to retrieve
        );
        [DllImport("user32.DLL", EntryPoint = "SetWindowLong")]
        static extern int SetWindowLong(
            int hWnd,		// handle to window
            int nIndex,     // offset of value to set
            int dwNewLong	// new value
        );
        [DllImport("user32.DLL", EntryPoint = "SetWindowPos")]
        static extern bool SetWindowPos(
            int hWnd,				// handle to window
            int hWndInsertAfter,	// placement-order handle
            int X,					// horizontal position
            int Y,					// vertical position
            int cx,					// width
            int cy,					// height
            uint uFlags				// window-positioning options
        );
        //'
        //' Constantes para usar con el API
        const int GWL_STYLE = (-16);
        const int WS_THICKFRAME = 0x40000; //' Con borde redimensionable
        //'
        const int SWP_DRAWFRAME = 0x20;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOSIZE = 0x1;
        const int SWP_NOZORDER = 0x4;
        #endregion

        #region Metodos para poder mover objetos

        void CambiarEstilo(Control aControl)
        {
            //' Hacer este control redimensionable, usando el API
            //' Pone o quita el estilo dimensionable
            int Style;
            //'
            //' Si se produce un error, no hacer nada...
            try
            {
                Style = GetWindowLong(aControl.Handle.ToInt32(), GWL_STYLE);
                if ((Style & WS_THICKFRAME) == WS_THICKFRAME) // & = And
                {
                    //' Si ya lo tiene, lo quita
                    Style = Style ^ WS_THICKFRAME; // ^ = Xor
                }
                else
                {
                    //' Si no lo tiene, lo pone
                    Style = Style | WS_THICKFRAME; // | = Or
                }
                SetWindowLong(aControl.Handle.ToInt32(), GWL_STYLE, Style);
                SetWindowPos(aControl.Handle.ToInt32(), this.Handle.ToInt32(), 0, 0, 0, 0, SWP_NOZORDER | SWP_NOSIZE | SWP_NOMOVE | SWP_DRAWFRAME);
            }
            catch //(Exception e)
            {
                //MessageBox.Show(e.Message ); 
                //MessageBox.Show("El control " + aControl.Name + " no permite que se redimensione","",MessageBoxButtons.OK ,MessageBoxIcon.Warning  );
            }
        }

        private void Control_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //' Cuando se pulsa con el ratón
            DX = e.X;
            DY = e.Y;
            //' Al pulsar con el botón derecho, 
            //' cambiar el estilo entre redimensionable y normal
            Control elControl = (Control)sender;
            //lblStatus.Text = "Control: " + elControl.Name ;
            if (e.Button == MouseButtons.Right)
                CambiarEstilo(elControl);
            else
                //' Cuando se pulsa en un control, posicionarlo encima del resto
                elControl.BringToFront();
        }

        private void Control_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //' Cuando se mueve el ratón... mover el control
            if (e.Button == MouseButtons.Left)
            {
                Control elControl = (Control)sender;
                elControl.Left = e.X + elControl.Left - DX;
                elControl.Top = e.Y + elControl.Top - DY;
            }
        }

        private void Control_MouseEnter(object sender, System.EventArgs e)
        {
            Control elControl = (Control)sender;
            //lblStatus.Text = "Control: " + elControl.Name;
        }
        
        #endregion

        public MESAS()
        {
            InitializeComponent();
        }

        private void MESAS_Load(object sender, EventArgs e)
        {
            cargarMesas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarMesa("0");
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

            oButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            oButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            oButton.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            oButton.Click += new System.EventHandler(this.control_Click);
            
            contenedor.Controls.Add(oButton);            
            cont++;            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (seleccionar == 0)
            {
                seleccionar = 1;
                editar = 0;
            }
            else
            {
                seleccionar = 0;
                restablecerColor();
            }
        }

        private void control_Click(object sender, EventArgs e)
        {
            if (seleccionar == 1)
            {
                Button btn = (Button)sender;

                if (btn.ForeColor == Color.Blue)
                {
                    btn.ForeColor = Color.Black;
                    listEliminar.Remove(btn.Name);
                }
                else
                {
                    btn.ForeColor = Color.Blue;
                    listEliminar.Add(btn.Name);
                }
            }

            if (editar == 1)
            {
                Button oButton = (Button)sender;
                DETALLE_MESA oDetMesa = new DETALLE_MESA(oButton.Text, oButton.Tag.ToString());
                oDetMesa.ShowDialog();
                oButton.Text = oDetMesa.nombre;
                oButton.Tag = oDetMesa.detalle;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listEliminar.Count > 0)
            {
                DialogResult resp = MessageBox.Show("Esta seguro de eliminar los registros seleccionados ? ", "Eliminar Registros", MessageBoxButtons.YesNo);

                if (resp.ToString().ToUpper().Equals("YES"))
                {
                    for (int x = 0; x <= listEliminar.Count - 1; x++)
                    {

                        foreach (Control ctrl in contenedor.Controls)
                        {
                            if (ctrl.Name == listEliminar[x])
                            {
                                contenedor.Controls.Remove(ctrl);
                            }
                        }
                    }

                    //limpiar();
                    //cargarMesas();
                }
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editar == 0)
            {
                editar = 1;
                seleccionar = 0;
                restablecerColor();
            }
            else
            {
                editar = 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Limpiamos antes de guardar las nuevas mesas
            listaMesa.Clear();
            foreach (Control ctrl in contenedor.Controls)
            {
                //Agregamos a la lista de mesas todas las mesas en el formulario
                CONTROLLER.Mesa oMesa = new CONTROLLER.Mesa();
                oMesa.nomBoton = ctrl.Name;
                oMesa.nomMesa = ctrl.Text;
                oMesa.detalle = ctrl.Tag.ToString();
                oMesa.coordenadax = ctrl.Location.X.ToString();
                oMesa.coordenaday = ctrl.Location.Y.ToString();
                oMesa.largo = ctrl.Height.ToString();
                oMesa.ancho = ctrl.Width.ToString();
                listaMesa.Add(oMesa);
            }

            guardarMesas();

        }

        private void guardarMesas()
        {
            CONTROLLER.Mesa oMesa = new CONTROLLER.Mesa();
            if (oMesa.registrar(listaMesa))
            {
                msgCorrecto.lblMensaje.Text = "Mesas actualizadas correctamente.";
                msgCorrecto.ShowDialog();
            }
            else
            {
                msgError.lblMensaje.Text = "No fue posible actualizar las mesas.";
                msgError.ShowDialog();
            }

            limpiar();
            cargarMesas();
        }

        private void restablecerColor()
        {
            for (int x = 0; x <= listEliminar.Count - 1; x++) {

                foreach (Control ctrl in contenedor.Controls)
                {
                    if (ctrl.Name == listEliminar[x])
                    {
                        ctrl.ForeColor = Color.Black;
                    }
                }                
            }           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarMesas();
        }

        private void limpiar()
        {
            contenedor.Controls.Clear();
            cont = 1;
            seleccionar = 0;
            editar = 0;
            listEliminar.Clear();
            listaMesa.Clear();
        }

        private void cargarMesas()
        {
            contenedor.Controls.Clear();
            DataTable dtDatos = new DataTable();
            CONTROLLER.Mesa oMesa = new CONTROLLER.Mesa();
            dtDatos = oMesa.buscar("");

            if (dtDatos.Rows.Count > 0)
            {
                for (int x = 0; x <= dtDatos.Rows.Count - 1; x++) {
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

    }
}
