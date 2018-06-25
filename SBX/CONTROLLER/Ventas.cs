using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Ventas
    {
        MODEL.Datos datos = new MODEL.Datos();

        DataTable DT;

        public string buscar { get; set; }
        public string NombreDoc { get; set; }
        public string ConsecutivoDoc { get; set; }
        public string FechaIni { get; set; }
        public string FechaFin { get; set; }
      
        string Query = "";
        string WHERE = "";
        SqlParameter[] Parametros;
        bool ok = true;

        public int ID { get; set; }
        public int CodigoProducto { get; set; }
        public string CodigoBarras { get; set; }
        public double IVA { get; set; }
        public int CodigoCliente { get; set; }
        public double Puntos { get; set; }
        public string Documento { get; set; }
        public string NombreDocumento { get; set; }
        public string ConsecutivoDocumento { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public double Margen { get; set; }
        public double Descuento { get; set; }
        public string MedioPago { get; set; }
        public int CodigoUsuario { get; set; }
        public double Efectivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime HoraRegistro { get; set; }
        public double OtrosDescuentos { get; set; }

        public DataTable InformeVentas()
        {
            Query = "EXECUTE SP_InformeVentas " + "'" + buscar + "','" + NombreDoc + "','"+ConsecutivoDoc+"','"+ FechaIni +"','" + FechaFin + "'";
            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable producto_venta()
        {
            Query = "EXECUTE SP_CARGAR_PRODUCTO_VENTA " + "'"+buscar+"'";
            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable Cargar_producto(string Prod)
        {
            WHERE = "";
            if (Prod.Trim() != "")
            {
                WHERE = "WHERE p.Item = '"+Prod+"'";
            }
            Query = "SELECT c.CodigoProducto,p.Item,c.CodigoBarras,p.Nombre,p.Referencia,p.Descripcion "+
                    "FROM Compras c "+
                    "INNER JOIN Producto p "+
                    "ON c.CodigoProducto = p.ID "+ WHERE +
                    " GROUP BY c.CodigoProducto,p.Item,c.CodigoBarras,p.Nombre,p.Referencia,p.Descripcion ";
            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable AUTORIZACION()
        {
            Query = "EXECUTE SP_VERIFICACION_ROL_PERMISO_VENTA " + "'" + buscar + "'";
            DT = datos.Consultar(Query);
            return DT;
        }

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[18];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@CodigoProducto";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = CodigoProducto;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@CodigoBarras";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].SqlValue = CodigoBarras;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@IVA";
            Parametros[2].SqlDbType = SqlDbType.Float;
            Parametros[2].SqlValue = IVA;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@CodigoCliente";
            Parametros[3].SqlDbType = SqlDbType.Int;
            Parametros[3].SqlValue = CodigoCliente;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Puntos";
            Parametros[4].SqlDbType = SqlDbType.Float;
            Parametros[4].SqlValue = Puntos;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Documento";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = Documento;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@NombreDocumento";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = NombreDocumento;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@ConsecutivoDocumento";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = ConsecutivoDocumento;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Cantidad";
            Parametros[8].SqlDbType = SqlDbType.Float;
            Parametros[8].SqlValue = Cantidad;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Costo";
            Parametros[9].SqlDbType = SqlDbType.Money;
            Parametros[9].SqlValue = Costo;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Margen";
            Parametros[10].SqlDbType = SqlDbType.Float;
            Parametros[10].SqlValue = Margen;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Descuento";
            Parametros[11].SqlDbType = SqlDbType.Float;
            Parametros[11].SqlValue = Descuento;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@MedioPago";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].SqlValue = MedioPago;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@CodigoUsuario";
            Parametros[13].SqlDbType = SqlDbType.Int;
            Parametros[13].SqlValue = CodigoUsuario;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@Efectivo";
            Parametros[14].SqlDbType = SqlDbType.Money;
            Parametros[14].SqlValue = Efectivo;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@FechaRegistro";
            Parametros[15].SqlDbType = SqlDbType.DateTime;
            Parametros[15].SqlValue = DateTime.Today;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@HoraRegistro";
            Parametros[16].SqlDbType = SqlDbType.DateTime2;
            Parametros[16].SqlValue = DateTime.Now;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@OtrosDescuento";
            Parametros[17].SqlDbType = SqlDbType.Float;
            Parametros[17].SqlValue = OtrosDescuentos;

            Query =  "INSERT INTO Venta (CodigoProducto,CodigoBarras,IVA,CodigoCliente,Puntos,Documento, "+
                     "NombreDocumento,ConsecutivoDocumento,Cantidad,Costo,Margen,Descuento,MedioPago, "+
                     "CodigoUsuario,Efectivo,FechaRegistro,HoraRegistro,OtrosDescuento) "+
                     "VALUES(@CodigoProducto,@CodigoBarras,@IVA,@CodigoCliente,@Puntos,@Documento," +
                     "@NombreDocumento,@ConsecutivoDocumento,@Cantidad,@Costo,@Margen,@Descuento,@MedioPago, " +
                     "@CodigoUsuario,@Efectivo,@FechaRegistro,@HoraRegistro,@OtrosDescuento) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public DataTable CargarUltimoConsecutivo()
        {
            Query = "SELECT ISNULL(MAX(ConsecutivoDocumento),0) UltimoConsecutivo FROM Venta ";
            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable CargarVentas()
        {
            WHERE = " WHERE v.FechaRegistro BETWEEN '" + FechaIni+"' AND '"+FechaFin+"' ";

            if (buscar != "" && buscar != "Buscar Item")
            {
                WHERE = WHERE + " AND p.Item LIKE '"+buscar+"%' ";
            }
            if (NombreDoc.Trim() != "" && NombreDoc.Trim() != "Nombre Doc")
            {
                WHERE = WHERE + " AND  v.NombreDocumento LIKE '" + NombreDoc + "%' ";
            }

            if (ConsecutivoDoc.Trim() != "" && ConsecutivoDoc.Trim() != "Consecutivo Doc")
            {
                WHERE = WHERE + " AND  v.ConsecutivoDocumento LIKE '" + ConsecutivoDoc + "%' ";
            }

            Query = "SELECT v.FechaRegistro,v.HoraRegistro,u.Usuario,v.NombreDocumento,v.ConsecutivoDocumento, "+
                    "p.Item,v.CodigoBarras,p.Nombre,p.Referencia,v.Cantidad,((v.Costo / (1 - (v.Margen / 100))) * v.Cantidad) ValorVenta, "+
                    "(((v.Costo / (1 - (v.Margen / 100))) * (v.Descuento / 100)) * v.Cantidad) ValorDescuento, "+
                    "((v.Costo / (1 - (v.Margen / 100))) * v.Cantidad) - (((v.Costo / (1 - (v.Margen / 100))) * (v.Descuento / 100)) * v.Cantidad) TotalVenta, "+
                    "v.Costo,v.Margen,v.Descuento,p.IVA,v.MedioPago "+
                    "FROM Venta v "+
                    "INNER JOIN Producto p ON v.CodigoProducto = p.ID "+
                    "INNER JOIN Cliente c ON v.CodigoCliente = c.Codigo "+
                    "INNER JOIN Usuario u ON v.CodigoUsuario = u.Codigo "+
                    WHERE +
                    "ORDER BY v.FechaRegistro ASC ";

            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable CargarProductosCodigoBarras()
        {
            Query = "SELECT c.CodigoProducto PRODUCTO,p.Item,c.CodigoBarras COD_BARRAS,p.Nombre,p.Referencia, "+
            "AVG(c.Costo) / (1 - (AVG(c.Margen) / 100)) PRECIO_VENTA,c.IVA,AVG(c.Costo) Costo,AVG(c.Margen) Margen "+
            "FROM Compras C "+
            "INNER JOIN Producto p ON C.CodigoProducto = P.ID "+
            "WHERE c.CodigoBarras = '"+buscar+"' "+
            "GROUP BY CodigoProducto,p.Item,CodigoBarras,p.Nombre,p.Referencia,c.IVA";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
