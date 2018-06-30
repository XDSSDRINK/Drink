using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SBX.CONTROLLER
{
    public class MesaMesero
    {                
        DataTable dtDatos;
        Boolean ok = true;
        String strSQL = "";
        SqlParameter[] parametros;
        MODEL.Datos datos = new MODEL.Datos();

        public string nomBoton { get; set; }
        public long codigo { get; set; }
        public DateTime fecha { get; set; }
        
        public Boolean registrar()
        {
            parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@nomBoton";
            parametros[0].SqlDbType = SqlDbType.VarChar;
            parametros[0].Size = 20;
            parametros[0].SqlValue = nomBoton;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@codigo";
            parametros[1].SqlDbType = SqlDbType.BigInt;
            parametros[1].Size = 20;
            parametros[1].SqlValue = codigo;
                
            strSQL = "INSERT INTO mesasMeseros (nomBoton, codigo) " +
                    " VALUES(@nomBoton, @codigo) ";
            ok = datos.Registrar(parametros, strSQL);

            return ok;
            
        }               
         
    }
}
