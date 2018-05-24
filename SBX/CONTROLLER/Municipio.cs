using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Municipio
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
        public string Departamento { get; set; }

        public DataTable CargarMunicipio(Boolean Todos)
        {
            DT = null;
            WHERE = "";

            if (Todos == false)
            {
                WHERE = " WHERE M.Nombre = '" + Nombre + "' AND D.Nombre = '" + Departamento + "' ";
            }
            else
            {
                WHERE = " WHERE D.Nombre = '"+Departamento+"' ";
            }

            Query = "SELECT M.Codigo,M.Nombre,M.Departamento FROM Municipio M " +
                    "INNER JOIN Departamento D ON D.Codigo = M.Departamento " +
                    WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
    }
}
