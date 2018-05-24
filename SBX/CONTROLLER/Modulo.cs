using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Modulo
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;

        public DataTable CargarModulo(Boolean Todos)
        {
            DT = null;

            Query = "SELECT * FROM Modulo ";
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
