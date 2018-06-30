using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.MODEL;

namespace SBX.CONTROLLER
{
    public class Compras
    {
        Datos datos = new Datos();

        DataTable DT;
        string Query = "";
        Boolean ok = true;
        SqlParameter[] Parametros;
        string Where = "";
        public int CodigoUsuario { get; set; }

        public int ID { get; set; }
        public string Documento { get; set; }
        public string NombreDocumento { get; set; }
        public string ConsecutivoDocumento { get; set; }
        public int CodigoProducto { get; set; }
        public string CodigoProveedor { get; set; }
        public float Cantidad { get; set; }
        public string DescripcionCantidad { get; set; }
        public double Costo { get; set; }
        public float Margen { get; set; }
        public float IVA { get; set; }
        public int GeneraIVA { get; set; }
        public string Lote { get; set; }
        public string Serial { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime HoraRegistro { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IDBodega { get; set; }

        public DataTable CargarTodo()
        {
            Query = "SELECT * FROM Compras";
            
            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable CargarPrimeroUltimo(bool Primero)
        {
            if (Primero == true)
            {
                Where = " WHERE ID = (SELECT MAX(ID) FROM Compras) ";
            }
            else
            {
                Where = " WHERE ID = (SELECT MIN(ID) FROM Compras) ";
            }

            Query = "SELECT * FROM Compras " + Where;

            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable CargarCompra(string Documento, string NombreDoc, string ConsecutivoDoc, string FechaIni, string FechaFin, string modulo)
        {
            string WHERE = "";
            switch (modulo)
            {
                case "Unico":
                    WHERE = " WHERE (Documento = '" + Documento + "' AND NombreDocumento = '" + NombreDoc + "' AND ConsecutivoDocumento = '" + ConsecutivoDoc + "') AND (FechaRegistro BETWEEN '" + FechaIni + "' AND '" + FechaFin + "') ";
                    break;
                case "Completo":
                    WHERE = " WHERE (Documento = '"+Documento+ "' AND NombreDocumento LIKE '" + NombreDoc+ "%' AND ConsecutivoDocumento LIKE '" + ConsecutivoDoc + "%') AND (FechaRegistro BETWEEN '" + FechaIni+"' AND '"+FechaFin+"') ";
                    break;
                case "NombreDoc":
                    WHERE = " WHERE (Documento = '" + Documento + "' AND NombreDocumento LIKE '" + NombreDoc + "%') AND (FechaRegistro BETWEEN '" + FechaIni + "' AND '" + FechaFin + "') ";
                    break;
                case "ConsecutivoDoc":
                    WHERE = " WHERE (Documento = '" + Documento + "' AND ConsecutivoDocumento LIKE '" + ConsecutivoDoc + "%') AND (FechaRegistro BETWEEN '" + FechaIni + "' AND '" + FechaFin + "') ";
                    break;
                case "Documento":
                    WHERE = " WHERE Documento LIKE '" + Documento + "%' AND (FechaRegistro BETWEEN '" + FechaIni + "' AND '" + FechaFin + "') ";
                    break;
            }

            Query = "SELECT * FROM Compras " + WHERE;

            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable VerificacionDocumento(string Documento, string NombreDoc, string ConsecutivoDoc)
        {
            Query = "SELECT * FROM Compras WHERE Documento = '"+ Documento + "' AND NombreDocumento = '" + NombreDoc + "' AND ConsecutivoDocumento = '" + ConsecutivoDoc + "' ";

            DT = datos.Consultar(Query);
            return DT;
        }

        private void AsignaParametros()
        {
            Parametros = new SqlParameter[19];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Documento";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 20;
            Parametros[0].SqlValue = Documento;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@NombreDocumento";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].Size = 20;
            Parametros[1].SqlValue = NombreDocumento;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@ConsecutivoDocumento";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].Size = 20;
            Parametros[2].SqlValue = ConsecutivoDocumento;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@CodigoProducto";
            Parametros[3].SqlDbType = SqlDbType.Int;
            Parametros[3].SqlValue = CodigoProducto;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@CodigoProveedor";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].SqlValue = CodigoProveedor;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Cantidad";
            Parametros[5].SqlDbType = SqlDbType.Float;
            Parametros[5].SqlValue = Cantidad;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@DescripcionCantidad";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].Size = 15;
            Parametros[6].SqlValue = DescripcionCantidad;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Costo";
            Parametros[7].SqlDbType = SqlDbType.Money;
            Parametros[7].SqlValue = Costo;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Margen";
            Parametros[8].SqlDbType = SqlDbType.Float;
            Parametros[8].SqlValue = Margen;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@IVA";
            Parametros[9].SqlDbType = SqlDbType.Float;
            Parametros[9].SqlValue = IVA;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@GeneraIVA";
            Parametros[10].SqlDbType = SqlDbType.Int;
            Parametros[10].SqlValue = GeneraIVA;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Lote";
            Parametros[11].SqlDbType = SqlDbType.VarChar;
            Parametros[11].Size = 100;
            Parametros[11].SqlValue = Lote;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@Serial";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].Size = 100;
            Parametros[12].SqlValue = Serial;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@CodigoBarras";
            Parametros[13].SqlDbType = SqlDbType.VarChar;
            Parametros[13].Size = 100;
            Parametros[13].SqlValue = CodigoBarras;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@FechaRegistro";
            Parametros[14].SqlDbType = SqlDbType.DateTime;
            Parametros[14].SqlValue = FechaRegistro;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@HoraRegistro";
            Parametros[15].SqlDbType = SqlDbType.DateTime2;
            Parametros[15].SqlValue = HoraRegistro;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@FechaVencimiento";
            Parametros[16].SqlDbType = SqlDbType.Date;
            Parametros[16].SqlValue = FechaVencimiento;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@Bodega";
            Parametros[17].SqlDbType = SqlDbType.Int;
            Parametros[17].SqlValue = IDBodega;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@UsuarioCrea";
            Parametros[18].SqlDbType = SqlDbType.Int;
            Parametros[18].SqlValue = CodigoUsuario;
        }

        public Boolean Registrar()
        {
            Query = "INSERT INTO Compras(Documento,NombreDocumento,ConsecutivoDocumento,CodigoProducto,CodigoProveedor,Cantidad, " +
                        "DescripcionCantidad,Costo,Margen,IVA,GeneraIVA,Lote,Serial,CodigoBarras,FechaRegistro,HoraRegistro,FechaVencimiento,Bodega,UsuarioCrea) " +
                        "VALUES(@Documento,@NombreDocumento,@ConsecutivoDocumento,@CodigoProducto,@CodigoProveedor,@Cantidad, " +
                        "@DescripcionCantidad,@Costo,@Margen,@IVA,@GeneraIVA,@Lote,@Serial,@CodigoBarras,@FechaRegistro,@HoraRegistro,@FechaVencimiento,@Bodega,@UsuarioCrea)";

            AsignaParametros();
            ok = datos.Registrar(Parametros, Query);
            return ok;
        }
    }
}
