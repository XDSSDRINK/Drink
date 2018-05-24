using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    class Estado
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

        public DataTable CargaEstado(Boolean Todos)
        {
            DT = null;
            WHERE = "";

            if (Todos == false)
            {
                WHERE = " WHERE Estado = '" + Nombre + "'";
            }

            Query = "SELECT IdEstado,Estado FROM EstadoProducto " + WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
        public DataTable VerificaDependencia(string Tabla)
        {
            DT = null;
            Query = "SELECT EstadoProducto FROM " + Tabla + " WHERE IdEstado = " + ID + "";
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

            Query = "INSERT INTO EstadoProducto (Estado)  VALUES(@Nombre) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }
        public Boolean Eliminar()
        {
            Query = "DELETE FROM EstadoProducto WHERE Estado = '" + Nombre + "'";
            ok = datos.Eliminar(Query);
            return ok;
        }
    }
}
