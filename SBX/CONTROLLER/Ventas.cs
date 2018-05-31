using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable InformeVentas()
        {
            Query = "EXECUTE SP_InformeVentas " + "'" + buscar + "','" + NombreDoc + "','"+ConsecutivoDoc+"','"+ FechaIni +"','" + FechaFin + "'";
            DT = datos.Consultar(Query);
            return DT;
        }

        public DataTable producto_venta()
        {
            Query = "EXECUTE SP_CONSULTAR_PRODUCTO_PARA_VENTA "+ "'"+buscar+"'";
            DT = datos.Consultar(Query);
            return DT;
        }

    }
}
