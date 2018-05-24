using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Departamento
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

        public DataTable CargarDepartamento(Boolean Todos)
        {
            DT = null;
            WHERE = "";

            if (Todos == false)
            {
                WHERE = " WHERE Nombre = '" + Nombre + "'";
            }

            Query = "SELECT Codigo,Nombre,Pais FROM Departamento " + WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
