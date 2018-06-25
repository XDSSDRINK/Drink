
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class EstadoGlobal
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;

        public DataTable CargaEstado()
        {
            Query = "SELECT ID,Nombre FROM Estado ";
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
