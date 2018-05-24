using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
   public class Rol
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;
        string where = "";

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public DataTable Cargar(Boolean Todos)
        {
            DT = null;

            where = "";

            if (Todos != true)
            {
                where = "WHERE ID = "+ ID;
            }

            Query = "SELECT * FROM Rol " + where;
            DT = datos.Consultar(Query);

            return DT;
        }

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[2];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 20;
            Parametros[0].SqlValue = Nombre;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Descripcion";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].Size = 300;
            Parametros[1].SqlValue = Descripcion;

            Query = "INSERT INTO Rol (Nombre,Descripcion)  VALUES(@Nombre,@Descripcion) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public Boolean Modificar()
        {
            Parametros = new SqlParameter[1];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Descripcion";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 300;
            Parametros[0].SqlValue = Descripcion;

            Query = " UPDATE Rol SET Descripcion = @Descripcion WHERE Nombre = '"+Nombre+"'";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM Rol WHERE Nombre = '" + Nombre + "'";
            ok = datos.Eliminar(Query);
            return ok;
        }
    }
}
