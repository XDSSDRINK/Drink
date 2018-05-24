using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    class Banco
    {
        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        DataTable DT;
        string WHERE = "";

        //getter and setter
        private int ID;
        private string Nombre;

        public int ID_
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Nombre_
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public DataTable CargarBanco(Boolean Todos)
        {
            DT = null;
            WHERE = "";

            if (Todos == false)
            {
                WHERE = " WHERE Nombre = '" + Nombre + "'";
            }

            Query = "SELECT ID,Nombre FROM Banco " + WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
