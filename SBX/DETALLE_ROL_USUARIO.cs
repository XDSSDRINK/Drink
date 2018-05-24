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
    public partial class DETALLE_ROL_USUARIO : Form
    {
        //Delegado 
        public delegate void AgregaRol_Permisos();
        public event AgregaRol_Permisos AgregaRol_Permiso;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        CONTROLLER.Modulo modulo = new CONTROLLER.Modulo();
        CONTROLLER.Permiso permiso = new CONTROLLER.Permiso();
        CONTROLLER.Rol rol = new CONTROLLER.Rol();
        CONTROLLER.Rol_Permiso rol_Permiso = new CONTROLLER.Rol_Permiso();
        MENSAJE_ERROR mENSAJE = new MENSAJE_ERROR();
        MENSAJECORRECTO eNSAJECORRECTO = new MENSAJECORRECTO();
        MENSAJE_CONFIRMACION mENSAJE_CONFIRMACION = new MENSAJE_CONFIRMACION();

        DataTable DT;
        DataTable DTPermisos;
        DataTable DTModulos;
        int contador = 0;
        int Filas = 0;
        int Validado = 0;
        bool ok;
        string NombreRol = "";
        public string IDRol { get; set; }
        public bool Nuevo { get; set; }

        //// Create a new form.
        Form mdiChildForm = new Form();
        public DETALLE_ROL_USUARIO()
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

        private void DETALLE_ROL_USUARIO_Load(object sender, EventArgs e)
        {
            EstiloTabla();
            Cargar();     
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

        private void Cargar()
        {
            if (IDRol == "")
            {
                CargarModulos();
            }
            else
            {
                cargarRol_permisos_Modulo();
            }     
        }

        private void cargarRol_permisos_Modulo()
        {
            dtgModulos.Columns["ClModulo"].ReadOnly = true;
            rol_Permiso.Rol = Convert.ToInt32(IDRol);
            DT = rol_Permiso.CargarDetalleRol(false);

            if (DT.Rows.Count > 0)
            {
                DataRow rows = DT.Rows[0];
                txtNombreRol.Enabled = false;
                txtNombreRol.Text = rows["Rol"].ToString();
                txtDescripcionRol.Text = rows["Descripcion"].ToString();

                //CargarPermisos
                DTPermisos = permiso.CargarPermiso(true);
                if (DTPermisos.Rows.Count > 0)
                {
                    if (dtgModulos.Columns.Count > 2)
                    {
                        dtgModulos.Columns.Remove("SELECT");
                        dtgModulos.Columns.Remove("CREATE");
                        dtgModulos.Columns.Remove("UPDATE");
                        dtgModulos.Columns.Remove("DELETE");
                    }
                    foreach (DataRow permisos in DTPermisos.Rows)
                    {
                        DataGridViewCheckBoxColumn Per = new DataGridViewCheckBoxColumn();
                        switch (permisos["Nombre"].ToString())
                        {
                            case "SELECT":
                                Per.Name = "SELECT";
                                Per.HeaderText = "Lectura";
                                break;
                            case "CREATE":
                                Per.Name = "CREATE";
                                Per.HeaderText = "Escritura";
                                break;
                            case "UPDATE":
                                Per.Name = "UPDATE";
                                Per.HeaderText = "Modificar";
                                break;
                            case "DELETE":
                                Per.Name = "DELETE";
                                Per.HeaderText = "Eliminar";
                                break;
                        }

                        dtgModulos.Columns.Add(Per);
                    }
                }

                //Cargar Modulos
                DTModulos = modulo.CargarModulo(true);
                dtgModulos.Rows.Clear();
                if (DTModulos.Rows.Count > 0)
                {
                    contador = 0;
                    Filas = DTModulos.Rows.Count;
                    dtgModulos.Rows.Add(Filas);

                    foreach (DataRow Modulo in DTModulos.Rows)
                    {
                        dtgModulos.Rows[contador].Cells["ClID"].Value = Modulo["ID"];
                        dtgModulos.Rows[contador].Cells["ClModulo"].Value = Modulo["Modulo"];
                        contador++;
                    }
                }

                //Asignar permisos
                foreach (DataGridViewRow Permiso in dtgModulos.Rows)
                {
                    foreach (DataRow Permisos in DT.Rows)
                    {
                        if (Permiso.Cells["ClModulo"].Value.ToString() == Permisos["Modulo"].ToString())
                        {
                            switch (Permisos["Permiso"].ToString())
                            {
                                case "SELECT":
                                    Permiso.Cells["SELECT"].Value = true;
                                    break;
                                case "CREATE":
                                    Permiso.Cells["CREATE"].Value = true;
                                    break;
                                case "UPDATE":
                                    Permiso.Cells["UPDATE"].Value = true;
                                    break;
                                case "DELETE":
                                    Permiso.Cells["DELETE"].Value = true;
                                    break;
                            }
                        }
                    }
                }

            }
        }

        private void EstiloTabla()
        {
            dtgModulos.EnableHeadersVisualStyles = false;
            dtgModulos.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;
            dtgModulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgModulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void CargarModulos()
        {
            txtNombreRol.Enabled = true;
            contador = 0;
            dtgModulos.Columns["ClModulo"].ReadOnly = true;

            //CargarPermisos
            DT = permiso.CargarPermiso(true);

            if (DT.Rows.Count > 0)
            {
                if (dtgModulos.Columns.Count > 2)
                {
                    dtgModulos.Columns.Remove("SELECT");
                    dtgModulos.Columns.Remove("CREATE");
                    dtgModulos.Columns.Remove("UPDATE");
                    dtgModulos.Columns.Remove("DELETE");
                }

                foreach (DataRow permisos in DT.Rows)
                {
                    DataGridViewCheckBoxColumn Per = new DataGridViewCheckBoxColumn();
                    switch (permisos["Nombre"].ToString())
                    {
                        case "SELECT":
                            Per.Name = "SELECT";
                            Per.HeaderText = "Lectura";
                            break;
                        case "CREATE":
                            Per.Name = "CREATE";
                            Per.HeaderText = "Escritura";
                            break;                     
                        case "UPDATE":
                            Per.Name = "UPDATE";
                            Per.HeaderText = "Modificar";
                            break;
                        case "DELETE":
                            Per.Name = "DELETE";
                            Per.HeaderText = "Eliminar";
                            break;
                    }
                  
                    dtgModulos.Columns.Add(Per);
                }
            }

            DT = modulo.CargarModulo(true);

            dtgModulos.Rows.Clear();
            if (DT.Rows.Count > 0)
            {
                Filas = DT.Rows.Count;
                dtgModulos.Rows.Add(Filas);

                foreach (DataRow rows in DT.Rows)
                {
                    dtgModulos.Rows[contador].Cells["ClID"].Value = rows["ID"];
                    dtgModulos.Rows[contador].Cells["ClModulo"].Value = rows["Modulo"];
                    contador++;
                }
            }
        }

        private void Limpiar()
        {
            txtNombreRol.Text = "";
            txtDescripcionRol.Text = "";
            chkControlTotal.Checked = false;
            errorProvider1.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void Validacion()
        {
            Validado = 0;

            if (txtNombreRol.Text == "")
            {
                errorProvider1.SetError(txtNombreRol, "Ingrese rol");
                Validado++;
            }
            else
            {
                if (Nuevo == true)
                {
                    DT = rol.Cargar(true);
                    if (DT.Rows.Count > 0)
                    {
                        foreach (DataRow rows in DT.Rows)
                        {
                            if (txtNombreRol.Text == rows["Nombre"].ToString())
                            {
                                errorProvider1.SetError(txtNombreRol, "Rol: " + txtNombreRol.Text + " ya existe");
                                Validado++;
                            }
                        }
                    }
                }  
            }

            if (txtDescripcionRol.Text == "")
            {
                errorProvider1.SetError(txtDescripcionRol, "Ingrese descripcion de rol");
                Validado++;
            }
        }

        private void Guardar()
        {
            if (Nuevo == true)
            {
                string IdRol = "0";
                Validacion();
                if (Validado == 0)
                {
                    //registrar rol
                    NombreRol = txtNombreRol.Text;
                    rol.Nombre = NombreRol;
                    rol.Descripcion = txtDescripcionRol.Text;
                    ok = rol.Registrar();
                    if (ok == true)
                    {
                        //Traer id de rol registrado
                        DT = rol.Cargar(true);
                        foreach (DataRow roles in DT.Rows)
                        {
                            if (NombreRol == roles["Nombre"].ToString())
                            {
                                IdRol = roles["ID"].ToString();
                            }
                        }
                        //registra rol_permiso
                        if (dtgModulos.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow modulo_permiso in dtgModulos.Rows)
                            {
                                if (Convert.ToBoolean(modulo_permiso.Cells["SELECT"].Value) == true)
                                {
                                    rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                    rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                    rol_Permiso.Permiso = 1;
                                    rol_Permiso.Registrar();
                                }

                                if (Convert.ToBoolean(modulo_permiso.Cells["CREATE"].Value) == true)
                                {
                                    rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                    rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                    rol_Permiso.Permiso = 2;
                                    rol_Permiso.Registrar();
                                }

                                if (Convert.ToBoolean(modulo_permiso.Cells["UPDATE"].Value) == true)
                                {
                                    rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                    rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                    rol_Permiso.Permiso = 3;
                                    rol_Permiso.Registrar();
                                }

                                if (Convert.ToBoolean(modulo_permiso.Cells["DELETE"].Value) == true)
                                {
                                    rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                    rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                    rol_Permiso.Permiso = 4;
                                    rol_Permiso.Registrar();
                                }
                            }
                        }

                        eNSAJECORRECTO.lblMensaje.Text = "Rol Registrado";
                        eNSAJECORRECTO.ShowDialog();
                        LimpiarAlGuardar();
                    }
                    else
                    {
                        mENSAJE.lblMensaje.Text = " Error al intentar registrar rol ";
                        mENSAJE.ShowDialog();
                    }
                }
            }
            else
            {
                string IdRol = "0";
                Validacion();
                if (Validado == 0)
                {
                    //Actualizar rol
                    NombreRol = txtNombreRol.Text;
                    rol.Nombre = NombreRol;
                    rol.Descripcion = txtDescripcionRol.Text;
                    ok = rol.Modificar();

                    if (ok == true)
                    {
                        //Traer id de rol registrado
                        DT = rol.Cargar(true);
                        foreach (DataRow roles in DT.Rows)
                        {
                            if (NombreRol == roles["Nombre"].ToString())
                            {
                                IdRol = roles["ID"].ToString();
                            }
                        }
                        //Actualizar rol_permiso
                        if (dtgModulos.Rows.Count > 0)
                        {
                            rol_Permiso.Rol = Convert.ToInt32(IdRol);
                            ok = rol_Permiso.Eliminar();
                            if (ok == true)
                            {
                                foreach (DataGridViewRow modulo_permiso in dtgModulos.Rows)
                                {
                                    if (Convert.ToBoolean(modulo_permiso.Cells["SELECT"].Value) == true)
                                    {
                                        rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                        rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                        rol_Permiso.Permiso = 1;
                                        rol_Permiso.Registrar();
                                    }

                                    if (Convert.ToBoolean(modulo_permiso.Cells["CREATE"].Value) == true)
                                    {
                                        rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                        rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                        rol_Permiso.Permiso = 2;
                                        rol_Permiso.Registrar();
                                    }

                                    if (Convert.ToBoolean(modulo_permiso.Cells["UPDATE"].Value) == true)
                                    {
                                        rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                        rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                        rol_Permiso.Permiso = 3;
                                        rol_Permiso.Registrar();
                                    }

                                    if (Convert.ToBoolean(modulo_permiso.Cells["DELETE"].Value) == true)
                                    {
                                        rol_Permiso.Rol = Convert.ToInt32(IdRol);
                                        rol_Permiso.Modulo = Convert.ToInt32(modulo_permiso.Cells["ClID"].Value);
                                        rol_Permiso.Permiso = 4;
                                        rol_Permiso.Registrar();
                                    }
                                }
                            }
                            else
                            {
                                mENSAJE.lblMensaje.Text = " Error al intentar modificar rol ";
                                mENSAJE.ShowDialog();
                            }
                        }

                        eNSAJECORRECTO.lblMensaje.Text = "Rol Modificado";
                        eNSAJECORRECTO.ShowDialog();
                        mENSAJE_CONFIRMACION.Modulo = "Confirmacion";
                        mENSAJE_CONFIRMACION.txtMensaje.Text = "Para aplicar los cambios es necesario Reiniciar SBX, Desea reiniciar ";
                        mENSAJE_CONFIRMACION.ShowDialog();
                        if (mENSAJE_CONFIRMACION.Ok == true)
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        mENSAJE.lblMensaje.Text = " Error al intentar modificar rol ";
                        mENSAJE.ShowDialog();
                    }
                }
            }

            AgregaRol_Permiso();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void LimpiarAlGuardar()
        {
            Limpiar();
            Cargar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();  
        }

        private void ControlTotal(bool Control)
        {
            if (dtgModulos.Rows.Count > 0)
            {
                if (Control == true)
                {
                    foreach (DataGridViewRow permisos in dtgModulos.Rows)
                    {
                        permisos.Cells["CREATE"].Value = true;
                        permisos.Cells["SELECT"].Value = true;
                        permisos.Cells["UPDATE"].Value = true;
                        permisos.Cells["DELETE"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow permisos in dtgModulos.Rows)
                    {
                        permisos.Cells["CREATE"].Value = false;
                        permisos.Cells["SELECT"].Value = false;
                        permisos.Cells["UPDATE"].Value = false;
                        permisos.Cells["DELETE"].Value = false;
                    }
                }             
            }
        }

        private void chkControlTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkControlTotal.Checked == true)
            {
                ControlTotal(true);
            }
            else
            {
                ControlTotal(false);
            }
        }

        private void LogicaPermisos()
        {   
            foreach (DataGridViewCell permisos in dtgModulos.SelectedCells)
            {
                if (permisos.ReadOnly == false)
                {
                    if (Convert.ToBoolean(permisos.Value) == false)
                    {
                        dtgModulos.Rows[permisos.RowIndex].Cells["SELECT"].Value = true;
                    }
                    else if (Convert.ToBoolean(permisos.Value) == true)
                    {
                        permisos.Value = false;
                    }

                    if (Convert.ToBoolean(dtgModulos.Rows[permisos.RowIndex].Cells["SELECT"].Value) == false)
                    {
                        dtgModulos.Rows[permisos.RowIndex].Cells["CREATE"].Value = false;
                        dtgModulos.Rows[permisos.RowIndex].Cells["UPDATE"].Value = false;
                        dtgModulos.Rows[permisos.RowIndex].Cells["DELETE"].Value = false;
                    }
                }      
            }
        }

        private void dtgModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LogicaPermisos();
        }
    }
}
