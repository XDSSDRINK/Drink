using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
   public class Rol_Permiso
    {
        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;
        string WHERE = "";

        public int Rol { get; set; }
        public int Permiso { get; set; }
        public int Modulo { get; set; }

        public DataTable Cargar(Boolean Todos)
        {
            DT = null;
            WHERE = "";
            if (Todos != true) {
                WHERE = " WHERE Rol = "+Rol;
            }
 
            Query = "SELECT * FROM Rol_permiso "+WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }

        public DataTable CargarDetalleRol(Boolean Todos)
        {
            DT = null;
            WHERE = "";
            if (Todos != true)
            {
                WHERE = " WHERE rp.Rol = " + Rol;
            }

            Query = "SELECT r.ID IdRol,r.Nombre Rol,r.Descripcion,m.ID IdModulo,m.Modulo,p.ID IdPermiso,P.Nombre Permiso FROM rol_permiso rp " +
                    "INNER JOIN rol r ON r.ID = rp.Rol "+
                    "INNER JOIN Permiso p ON p.ID = rp.permiso "+
                    "INNER JOIN Modulo m ON m.ID = rp.modulo "+
                     WHERE +
                    " ORDER BY rp.Rol,rp.modulo ";

            DT = datos.Consultar(Query);
            return DT;
        }

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[3];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Rol";
            Parametros[0].SqlDbType = SqlDbType.Int;
            Parametros[0].SqlValue = Rol;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Permiso";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = Permiso;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Modulo";
            Parametros[2].SqlDbType = SqlDbType.Int;
            Parametros[2].SqlValue = Modulo;

            Query = "INSERT INTO Rol_permiso (Rol,Permiso,Modulo)  VALUES(@Rol,@Permiso,@Modulo) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public Boolean Modificar()
        {
            Query = "DELETE FROM Rol_permiso  WHERE Rol = "+Rol+" AND Permiso = "+Permiso+" AND Modulo = "+Modulo+" ";
            ok = datos.Eliminar(Query);

            return ok;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM Rol_permiso  WHERE Rol = " + Rol;
            ok = datos.Eliminar(Query);

            return ok;
        }

        public Boolean EliminarTotalRol()
        {
            Query = "EXECUTE SP_EliminarRol " + Rol;
            ok = datos.Eliminar(Query);

            return ok;
        }

    }
}
