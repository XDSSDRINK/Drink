using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Caja
    {
        public int ID { get; set; }
        public double Billete { get; set; }
        public int CantidadBilletes { get; set; }
        public double Moneda { get; set; }
        public int CantidadMonedas { get; set; }
        public float NumeroBaucher { get; set; }
        public double ValorBaucher { get; set; }
        public string TipoOperacion { get; set; }
        public int Usuario { get; set; }
        public DateTime FechaRegistro { get; set; }

        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        System.Data.DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[9];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Billete";
            Parametros[0].SqlDbType = SqlDbType.Money;
            Parametros[0].SqlValue = Billete;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@CantidadBilletes";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = CantidadBilletes;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Moneda";
            Parametros[2].SqlDbType = SqlDbType.Money;
            Parametros[2].SqlValue = Moneda;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@CantidadMonedas";
            Parametros[3].SqlDbType = SqlDbType.Int;
            Parametros[3].SqlValue = CantidadMonedas;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@NumeroBaucher";
            Parametros[4].SqlDbType = SqlDbType.Float;
            Parametros[4].SqlValue = NumeroBaucher;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@ValorBaucher";
            Parametros[5].SqlDbType = SqlDbType.Money;
            Parametros[5].SqlValue = ValorBaucher;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@TipoOperacion";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = TipoOperacion;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Usuario";
            Parametros[7].SqlDbType = SqlDbType.Int;
            Parametros[7].SqlValue = Usuario;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@FechaRegistro";
            Parametros[8].SqlDbType = SqlDbType.DateTime;
            Parametros[8].SqlValue = FechaRegistro;


            Query = "INSERT INTO Caja (Billete,CantidadBilletes,Moneda,CantidadMonedas,NumeroBaucher,ValorBaucher,TipoOperacion,Usuario,FechaRegistro) "+
                    "VALUES(@Billete,@CantidadBilletes,@Moneda,@CantidadMonedas,@NumeroBaucher,@ValorBaucher,@TipoOperacion,@Usuario,@FechaRegistro) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public DataTable CargarCaja()
        {
            Query = "SELECT TOP(7) *  " +
                    "FROM Caja "+
                    "WHERE Usuario = "+ Usuario+
                    "ORDER BY FechaRegistro DESC ";
            DT = datos.Consultar(Query);
            return DT;
        }

        public Boolean Eliminar()
        {
            Parametros = new SqlParameter[1];
            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@FechaRegistros";
            Parametros[0].SqlDbType = SqlDbType.DateTime;
            Parametros[0].SqlValue = FechaRegistro;

            Query = "DELETE FROM Caja WHERE FechaRegistro = @FechaRegistros AND TipoOperacion = '" + TipoOperacion+"' AND Billete = "+Billete;
            ok = datos.EliminarConParametros(Parametros,Query);
            return ok;
        }
    }
}
