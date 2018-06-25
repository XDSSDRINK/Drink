
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class DescuentoCliente
    {
        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        System.Data.DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public int ID { get; set; }
        public int Cliente { get; set; }
        public int Producto { get; set; }
        public string Codigobarras { get; set; }
        public double Descuento { get; set; }

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[4];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Cliente";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Cliente;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Producto";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = Producto;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@CodigoBarras";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = Codigobarras;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Descuento";
            Parametros[3].SqlDbType = SqlDbType.Float;
            Parametros[3].SqlValue = Descuento;

            Query = "INSERT INTO DescuentoCliente (Cliente,Producto,CodigoBarras,Descuento)  VALUES(@Cliente,@Producto,@CodigoBarras,@Descuento) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM DescuentoCliente WHERE Cliente = " + Cliente;
            ok = datos.Eliminar(Query);
            return ok;
        }

        public DataTable CargarDescuentosCliente()
        {
            Query = "SELECT dc.ID,dc.Cliente,dc.Producto,p.Item,dc.Descuento " +
                    "FROM DescuentoCliente dc "+
                    "INNER JOIN Cliente c ON dc.Cliente = c.Codigo "+
                    "INNER JOIN Producto p ON dc.Producto = p.ID "+
                    "WHERE dc.Cliente = "+ Cliente;
            DT = datos.Consultar(Query);
            return DT;
        }

    }
}
