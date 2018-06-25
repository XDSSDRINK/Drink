using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public  class Regimen
    {
        MODEL.Datos datos = new MODEL.Datos();

        public int ID { get; set; }
        public string Nombre { get; set; }

        string Query = "";
        DataTable DT;

        public DataTable CargarRegimen()
        {
            DT = null;
          
            Query = "SELECT * FROM Regimen ";
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
