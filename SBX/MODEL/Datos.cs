using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBX.MODEL
{
    public class Datos
    {
        conexion cn = new conexion();

        DataTable DT;
        SqlDataAdapter SDA;
        SqlCommand SC;
        string QUERY = "";
        Boolean ok = true;
        int contador = 0;

        #region SQL
        #region SELECT
        public DataTable Consultar(string query)
        {
            DT = null;
            QUERY = query;

            if (cn.Cadenacn.State == ConnectionState.Open)
            {
                cn.Cadenacn.Close();
            }
           
            try
            {
                cn.Cadenacn.Open();
                SDA = new SqlDataAdapter(QUERY, cn.Cadenacn);
                DT = new DataTable();
                SDA.Fill(DT);
                cn.Cadenacn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SDA.Dispose();
            }
     
            return DT;
        }
        #endregion
        #region DELETE,UPDATE,INSERT
        #region Delete
        public Boolean Eliminar(string query)
        {
            QUERY = query;
           
            try
            {
                cn.Cadenacn.Open();
                SC = new SqlCommand(QUERY, cn.Cadenacn);
                SC.ExecuteNonQuery();
                cn.Cadenacn.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar Eliminar: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
           
            return ok;
        }

        public Boolean EliminarConParametros(SqlParameter[] Parametros, string query)
        {
            QUERY = query;
            cn.Cadenacn.Open();
            SC = new SqlCommand(QUERY, cn.Cadenacn);
            contador = 0;

            while (contador < Parametros.Length)
            {
                //// Creando los parámetros necesarios
                SC.Parameters.Add(Parametros[contador].ParameterName, Parametros[contador].SqlDbType);

                //// Asignando los valores a los atributos
                SC.Parameters[Parametros[contador].ParameterName].Value = Parametros[contador].Value;

                contador++;
            }

            try
            {
                SC.ExecuteNonQuery();
                cn.Cadenacn.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar Eliminar: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            return ok;
        }

        #endregion
        #region Update
        public Boolean Modificar(SqlParameter[] Parametros, string query)
        {
            if (cn.Cadenacn.State == ConnectionState.Open)
            {
                cn.Cadenacn.Close();
            }

            QUERY = query;
            cn.Cadenacn.Open();
            SC = new SqlCommand(QUERY, cn.Cadenacn);
            contador = 0;

            if (Parametros != null)
            {
                while (contador < Parametros.Length)
                {
                    //// Creando los parámetros necesarios
                    SC.Parameters.Add(Parametros[contador].ParameterName, Parametros[contador].SqlDbType);

                    //// Asignando los valores a los atributos
                    SC.Parameters[Parametros[contador].ParameterName].Value = Parametros[contador].Value;

                    contador++;
                }
            }

            try
            {
                SC.ExecuteNonQuery();
                cn.Cadenacn.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar modificar: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            
            return ok;
        }
        #endregion
        #region Insert
        public Boolean Registrar(SqlParameter[] Parametros, string query)
        {
            QUERY = query;
            cn.Cadenacn.Open();
            SC = new SqlCommand(QUERY, cn.Cadenacn);
            contador = 0;

            while (contador < Parametros.Length)
            {
                //// Creando los parámetros necesarios
                SC.Parameters.Add(Parametros[contador].ParameterName, Parametros[contador].SqlDbType);

                //// Asignando los valores a los atributos
                SC.Parameters[Parametros[contador].ParameterName].Value = Parametros[contador].Value;

                contador++;
            }

            try
            {
                SC.ExecuteNonQuery();
                cn.Cadenacn.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar registrar: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
           
            return ok;
        }
        #endregion

        #region Sp
        public Boolean Execute(string query)
        {
            QUERY = query;

            try
            {
                cn.Cadenacn.Open();
                SC = new SqlCommand(QUERY, cn.Cadenacn);
                SC.ExecuteNonQuery();
                cn.Cadenacn.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar Ejecutar SP: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            return ok;
        }
        #endregion
        #endregion
        #endregion
    }
}
