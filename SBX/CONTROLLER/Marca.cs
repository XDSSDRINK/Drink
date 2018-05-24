using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Marca
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;
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
        public bool Relacionadas { get; set; }

        public DataTable CargaMarca(Boolean Todas)
        {
            DT = null;
            WHERE = "";

            if (Todas == false)
            {
                WHERE = " WHERE Nombre = '" + Nombre + "'";
            }

            if (Relacionadas == true)
            {
                WHERE = " WHERE Nombre LIKE '" + Nombre + "%'";
            }

            Query = "SELECT ID,Nombre FROM Marca " + WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
        public DataTable VerificaDependencia(string Tabla)
        {
            DT = null;
            Query = "SELECT Marca FROM " + Tabla + " WHERE Marca = " + ID + "";
            DT = datos.Consultar(Query);

            return DT;
        }
        public Boolean Registrar()
        {
            Parametros = new SqlParameter[1];
            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 30;
            Parametros[0].SqlValue = Nombre;

            Query = "INSERT INTO Marca (Nombre)  VALUES(@Nombre) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }
        public Boolean Eliminar()
        {
            Query = "DELETE FROM Marca WHERE Nombre = '" + Nombre + "'";
            ok = datos.Eliminar(Query);
            return ok;
        }
    }
}
