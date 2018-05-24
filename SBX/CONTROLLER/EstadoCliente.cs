using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class EstadoCliente
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;
        string WHERE = "";

        //getter and setter
        private int Codigo;
        private string Nombre;

        public int Codigo_
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string Nombre_
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public DataTable CargaEstadoCliente(Boolean Todos)
        {
            DT = null;
            WHERE = "";

            if (Todos == false)
            {
                WHERE = " WHERE Estado = '" + Nombre + "'";
            }

            Query = "SELECT Codigo,Estado FROM EstadoCliente " + WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
