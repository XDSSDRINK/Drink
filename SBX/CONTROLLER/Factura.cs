using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
   public class Factura
    {
        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        System.Data.DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public string Nombre { get; set; }
        public float ConsecutivoInicial { get; set; }
        public float Consecutivofinal { get; set; }
        public string Resolucion { get; set; }
        public string Detalle { get; set; }
        public float Alerta { get; set; }

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[6];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = Nombre;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@ConsecutivoInicial";
            Parametros[1].SqlDbType = SqlDbType.Float;
            Parametros[1].SqlValue = ConsecutivoInicial;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Consecutivofinal";
            Parametros[2].SqlDbType = SqlDbType.Float;
            Parametros[2].SqlValue = Consecutivofinal;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Resolucion";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = Resolucion;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Detalle";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = Detalle;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Alerta";
            Parametros[5].SqlDbType = SqlDbType.Float;
            Parametros[5].SqlValue = Alerta;

            Query = "INSERT INTO Factura (Nombre,ConsecutivoInicial,Consecutivofinal,Resolucion,Detalle,Alerta)  VALUES(@Nombre,@ConsecutivoInicial,@Consecutivofinal,@Resolucion,@Detalle,@Alerta) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM Factura ";
            ok = datos.Eliminar(Query);
            return ok;
        }

        public DataTable CargarFacura()
        {
            Query = "SELECT * " +
                    "FROM Factura ";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
