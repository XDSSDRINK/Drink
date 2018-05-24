using SBX.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.MODEL
{
    public class conexion
    {
        SqlConnection cadenaCn;

        public static string ObtenerConexion()
        {
            return Settings.Default.SBXConnectionString1;
        }
   
        public conexion()
        {
            try
            {  
                cadenaCn = new SqlConnection(ObtenerConexion());    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SqlConnection Cadenacn
        {
            get
            {
                return cadenaCn;
            }
        }
    }
}
