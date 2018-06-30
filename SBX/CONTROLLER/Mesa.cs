using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SBX.CONTROLLER
{
    public class Mesa
    {                
        DataTable dtDatos;
        Boolean ok = true;
        String strSQL = "";
        SqlParameter[] parametros;
        MODEL.Datos datos = new MODEL.Datos();

        public string nomBoton { get; set; }
        public string nomMesa { get; set; }
        public string detalle { get; set; }
        public string coordenadax { get; set; }
        public string coordenaday { get; set; }
        public string largo { get; set; }
        public string ancho { get; set; }

        public DataTable buscar(String nomBoton)
        {
            dtDatos = null;

            strSQL = "SELECT * FROM Mesas WHERE 1 = 1 ";

            if (!nomBoton.Equals(""))
            {
                strSQL += " AND nomBoton = '" + nomBoton + "' ";
            }

            dtDatos = datos.Consultar(strSQL);
            return dtDatos;
        }

        public Boolean eliminar()
        {
            strSQL = " DELETE FROM Mesas WHERE 1 = 1 ";
            ok = datos.Eliminar(strSQL);
            return ok;
        }

        public Boolean registrar(List<Mesa> oMesa)
        {
            //Limpiamos la tabla
            eliminar();

            for (int x = 0; x <= oMesa.Count - 1; x++)
            {
                parametros = new SqlParameter[7];

                parametros[0] = new SqlParameter();
                parametros[0].ParameterName = "@nomBoton";
                parametros[0].SqlDbType = SqlDbType.VarChar;
                parametros[0].Size = 20;
                parametros[0].SqlValue = oMesa[x].nomBoton;

                parametros[1] = new SqlParameter();
                parametros[1].ParameterName = "@nomMesa";
                parametros[1].SqlDbType = SqlDbType.VarChar;
                parametros[1].Size = 20;
                parametros[1].SqlValue = oMesa[x].nomMesa;

                parametros[2] = new SqlParameter();
                parametros[2].ParameterName = "@detalle";
                parametros[2].SqlDbType = SqlDbType.VarChar;
                parametros[2].Size = 200;
                parametros[2].SqlValue = oMesa[x].detalle;

                parametros[3] = new SqlParameter();
                parametros[3].ParameterName = "@coordenadax";
                parametros[3].SqlDbType = SqlDbType.VarChar;
                parametros[3].Size = 30;
                parametros[3].SqlValue = oMesa[x].coordenadax;

                parametros[4] = new SqlParameter();
                parametros[4].ParameterName = "@coordenaday";
                parametros[4].SqlDbType = SqlDbType.VarChar;
                parametros[4].Size = 30;
                parametros[4].SqlValue = oMesa[x].coordenaday;

                parametros[5] = new SqlParameter();
                parametros[5].ParameterName = "@largo";
                parametros[5].SqlDbType = SqlDbType.VarChar;
                parametros[5].Size = 30;
                parametros[5].SqlValue = oMesa[x].largo;

                parametros[6] = new SqlParameter();
                parametros[6].ParameterName = "@ancho";
                parametros[6].SqlDbType = SqlDbType.VarChar;
                parametros[6].Size = 30;
                parametros[6].SqlValue = oMesa[x].ancho;

                strSQL = "INSERT INTO Mesas (nomBoton, nomMesa, detalle, coordenadax, coordenaday, largo, ancho) " +
                        " VALUES(@nomBoton, @nomMesa, @detalle, @coordenadax, @coordenaday, @largo, @ancho) ";
                ok = datos.Registrar(parametros, strSQL);

            }

            return ok;
            
        }               
         
    }
}
