using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class VentaAnulada
    {
        MODEL.Datos datos = new MODEL.Datos();
        Usuario usuarios = new Usuario();

        public int ID { get; set; }
        public string Item { get; set; }
        public string CodBarras { get; set; }
        public double Cantidad { get; set; }
        public double PrecioUN { get; set; }
        public double Descuento { get; set; }
        public string Usuario { get; set; }

        string Query = "";
        bool ok = true;
        SqlParameter[] Parametros;
        DataTable DT;

        private void AsignaParametros()
        {
            Parametros = new SqlParameter[7];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Item";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 15;
            Parametros[0].SqlValue = Item;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@CodBarras";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].Size = 100;
            Parametros[1].SqlValue = CodBarras;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Cantidad";
            Parametros[2].SqlDbType = SqlDbType.Float;
            Parametros[2].SqlValue = Cantidad;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@PrecioUN";
            Parametros[3].SqlDbType = SqlDbType.Money;
            Parametros[3].SqlValue = PrecioUN;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Descuento";
            Parametros[4].SqlDbType = SqlDbType.Float;
            Parametros[4].SqlValue = Descuento;

            string CodigoUsuario = "";
            DT = usuarios.Cargar(true);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow rows in DT.Rows)
                {
                    if (rows["Usuario"].ToString() == Usuario.ToString())
                    {
                        CodigoUsuario = rows["CodigoUsuario"].ToString();
                    }
                }
            }

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Usuario";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = CodigoUsuario;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@FechaRegistro";
            Parametros[6].SqlDbType = SqlDbType.DateTime;
            Parametros[6].SqlValue = DateTime.Now;
        }

        public Boolean Registrar()
        {
            Query = " INSERT INTO VentaAnulada(Item,CodBarras,Cantidad,PrecioUN,Descuento,Usuario,FechaRegistro) " +
                    " VALUES(@Item,@CodBarras,@Cantidad,@PrecioUN,@Descuento,@Usuario,@FechaRegistro) ";
                        
            AsignaParametros();
            ok = datos.Registrar(Parametros, Query);
            return ok;
        }
    }
}
