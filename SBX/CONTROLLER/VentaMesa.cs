using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SBX.CONTROLLER
{
    public class VentaMesa
    {                
        DataTable dtDatos;
        Boolean ok = true;
        String strSQL = "";
        SqlParameter[] parametros;
        MODEL.Datos datos = new MODEL.Datos();

        public string buscar { get; set; }


        public int ID { get; set; }
        public string nomBoton { get; set; }
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
        public string Usuario { get; set; }

        public Boolean anularVentaTemp(String nomBoton)
        {
            strSQL = " DELETE FROM Venta_temp WHERE 1 = 1 WHERE 1 = 1 AND nomBoton = '" + nomBoton + "' ";
            ok = datos.Eliminar(strSQL);
            return ok;
        }

        public DataTable CargarProductosCodigoBarras()
        {
            strSQL = "SELECT c.CodigoProducto PRODUCTO,p.Item,c.CodigoBarras COD_BARRAS,p.Nombre,p.Referencia, " +
            "AVG(c.Costo) / (1 - (AVG(c.Margen) / 100)) PRECIO_VENTA,c.IVA,AVG(c.Costo) Costo,AVG(c.Margen) Margen " +
            "FROM Compras C " +
            "INNER JOIN Producto p ON C.CodigoProducto = P.ID " +
            "WHERE c.CodigoBarras = '" + buscar + "' " +
            "GROUP BY CodigoProducto,p.Item,CodigoBarras,p.Nombre,p.Referencia,c.IVA";
            dtDatos = datos.Consultar(strSQL);
            return dtDatos;
        }

        public DataTable producto_venta()
        {
            strSQL = "EXECUTE SP_CARGAR_PRODUCTO_VENTA " + "'" + buscar + "'";
            dtDatos = datos.Consultar(strSQL);
            return dtDatos;
        }

        public DataTable CargarUltimoConsecutivo()
        {
            strSQL = "SELECT ISNULL(MAX(ConsecutivoDocumento),0) UltimoConsecutivo FROM Venta_temp ";
            dtDatos = datos.Consultar(strSQL);
            return dtDatos;
        }

        public Boolean Registrar()
        {
            parametros = new SqlParameter[19];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@CodigoProducto";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].SqlValue = CodigoProducto;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@CodigoBarras";
            parametros[1].SqlDbType = SqlDbType.VarChar;
            parametros[1].SqlValue = CodigoBarras;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@IVA";
            parametros[2].SqlDbType = SqlDbType.Float;
            parametros[2].SqlValue = IVA;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@CodigoCliente";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].SqlValue = CodigoCliente;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@Puntos";
            parametros[4].SqlDbType = SqlDbType.Float;
            parametros[4].SqlValue = Puntos;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@Documento";
            parametros[5].SqlDbType = SqlDbType.VarChar;
            parametros[5].SqlValue = Documento;

            parametros[6] = new SqlParameter();
            parametros[6].ParameterName = "@NombreDocumento";
            parametros[6].SqlDbType = SqlDbType.VarChar;
            parametros[6].SqlValue = NombreDocumento;

            parametros[7] = new SqlParameter();
            parametros[7].ParameterName = "@ConsecutivoDocumento";
            parametros[7].SqlDbType = SqlDbType.VarChar;
            parametros[7].SqlValue = ConsecutivoDocumento;

            parametros[8] = new SqlParameter();
            parametros[8].ParameterName = "@Cantidad";
            parametros[8].SqlDbType = SqlDbType.Float;
            parametros[8].SqlValue = Cantidad;

            parametros[9] = new SqlParameter();
            parametros[9].ParameterName = "@Costo";
            parametros[9].SqlDbType = SqlDbType.Money;
            parametros[9].SqlValue = Costo;

            parametros[10] = new SqlParameter();
            parametros[10].ParameterName = "@Margen";
            parametros[10].SqlDbType = SqlDbType.Float;
            parametros[10].SqlValue = Margen;

            parametros[11] = new SqlParameter();
            parametros[11].ParameterName = "@Descuento";
            parametros[11].SqlDbType = SqlDbType.Float;
            parametros[11].SqlValue = Descuento;

            parametros[12] = new SqlParameter();
            parametros[12].ParameterName = "@MedioPago";
            parametros[12].SqlDbType = SqlDbType.VarChar;
            parametros[12].SqlValue = MedioPago;

            parametros[13] = new SqlParameter();
            parametros[13].ParameterName = "@CodigoUsuario";
            parametros[13].SqlDbType = SqlDbType.Int;
            parametros[13].SqlValue = CodigoUsuario;

            parametros[14] = new SqlParameter();
            parametros[14].ParameterName = "@Efectivo";
            parametros[14].SqlDbType = SqlDbType.Money;
            parametros[14].SqlValue = Efectivo;

            parametros[15] = new SqlParameter();
            parametros[15].ParameterName = "@FechaRegistro";
            parametros[15].SqlDbType = SqlDbType.DateTime;
            parametros[15].SqlValue = DateTime.Today;

            parametros[16] = new SqlParameter();
            parametros[16].ParameterName = "@HoraRegistro";
            parametros[16].SqlDbType = SqlDbType.DateTime2;
            parametros[16].SqlValue = DateTime.Now;

            parametros[17] = new SqlParameter();
            parametros[17].ParameterName = "@OtrosDescuento";
            parametros[17].SqlDbType = SqlDbType.Float;
            parametros[17].SqlValue = OtrosDescuentos;

            parametros[18] = new SqlParameter();
            parametros[18].ParameterName = "@nomBoton";
            parametros[18].SqlDbType = SqlDbType.VarChar;
            parametros[18].SqlValue = nomBoton;

            strSQL = "INSERT INTO Venta_temp (CodigoProducto,CodigoBarras,IVA,CodigoCliente,Puntos,Documento, " +
                     "NombreDocumento,ConsecutivoDocumento,Cantidad,Costo,Margen,Descuento,MedioPago, " +
                     "CodigoUsuario,Efectivo,FechaRegistro,HoraRegistro,OtrosDescuento, nomBoton) " +
                     "VALUES(@CodigoProducto,@CodigoBarras,@IVA,@CodigoCliente,@Puntos,@Documento," +
                     "@NombreDocumento,@ConsecutivoDocumento,@Cantidad,@Costo,@Margen,@Descuento,@MedioPago, " +
                     "@CodigoUsuario,@Efectivo,@FechaRegistro,@HoraRegistro,@OtrosDescuento, @nomBoton) ";

            ok = datos.Registrar(parametros, strSQL);

            return ok;
        }
        
        public DataTable buscarVentaMesa()
        {
            strSQL = "SELECT v.FechaRegistro,v.HoraRegistro,u.Usuario,v.NombreDocumento,v.ConsecutivoDocumento, " +
                   "p.Item,v.CodigoBarras,p.Nombre,p.Referencia,v.Cantidad,((v.Costo / (1 - (v.Margen / 100))) * v.Cantidad) ValorVenta, " +
                   "(((v.Costo / (1 - (v.Margen / 100))) * (v.Descuento / 100)) * v.Cantidad) ValorDescuento, " +
                   "((v.Costo / (1 - (v.Margen / 100))) * v.Cantidad) - (((v.Costo / (1 - (v.Margen / 100))) * (v.Descuento / 100)) * v.Cantidad) TotalVenta, " +
                   "v.Costo,v.Margen,v.Descuento,p.IVA,v.MedioPago " +
                   "FROM Venta_temp v " +
                   "INNER JOIN Producto p ON v.CodigoProducto = p.ID " +
                   "INNER JOIN Cliente c ON v.CodigoCliente = c.Codigo " +
                   "INNER JOIN Usuario u ON v.CodigoUsuario = u.Codigo " +
                   "WHERE 1 = 1 " +
                   "AND nomBoton = '" + nomBoton + "' " +
                   "ORDER BY v.FechaRegistro ASC ";

            dtDatos = datos.Consultar(strSQL);
            return dtDatos;
        }









    }
}
