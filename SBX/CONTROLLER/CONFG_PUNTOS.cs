using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class CONFG_PUNTOS
    {
        public int ID { get; set; }
        public double XcadaMonto { get; set; }
        public int AcumulaPuntos { get; set; }
        public int XcadaPuntos { get; set; }
        public float Descuento { get; set; }

        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        System.Data.DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[4];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@XcadaMonto";
            Parametros[0].SqlDbType = SqlDbType.Money;
            Parametros[0].SqlValue = XcadaMonto;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@XcadaPuntos";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = XcadaPuntos;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@AcumulaPuntos";
            Parametros[2].SqlDbType = SqlDbType.Int;
            Parametros[2].SqlValue = AcumulaPuntos;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Descuento";
            Parametros[3].SqlDbType = SqlDbType.Float;
            Parametros[3].SqlValue = Descuento;

            Query = "INSERT INTO CONFG_PUNTOS (XcadaMonto,XcadaPuntos,AcumulaPuntos,Descuento)  VALUES(@XcadaMonto,@XcadaPuntos,@AcumulaPuntos,@Descuento) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public DataTable CargarConfgPuntos()
        {
            Query = "SELECT *  " +
                    "FROM CONFG_PUNTOS ";
            DT = datos.Consultar(Query);
            return DT;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM CONFG_PUNTOS";
            ok = datos.Eliminar(Query);
            return ok;
        }
    }
}
