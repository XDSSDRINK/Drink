using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Bodega
    {
        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        DataTable DT;

        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public DataTable CargarBodega(Boolean Todos)
        {
            DT = null; 
            Query = "SELECT ID,Codigo,Nombre FROM Bodega ";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
