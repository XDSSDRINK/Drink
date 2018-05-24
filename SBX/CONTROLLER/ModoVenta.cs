using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class ModoVenta
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

        public DataTable CargaModoVenta(Boolean Todas)
        {
            DT = null;
            WHERE = "";

            if (Todas == false)
            {
                WHERE = " WHERE Nombre = '" + Nombre + "'";
            }

            Query = "SELECT ID,Nombre FROM ModoVenta " + WHERE;
            DT = datos.Consultar(Query);

            return DT;
        }
        public DataTable VerificaDependencia(string Tabla)
        {
            DT = null;
            Query = "SELECT ModoVenta FROM " + Tabla + " WHERE ModoVenta = " + ID + "";
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

            Query = "INSERT INTO ModoVenta (Nombre)  VALUES(@Nombre) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }
        public Boolean Eliminar()
        {
            Query = "DELETE FROM ModoVenta WHERE Nombre = '" + Nombre + "'";
            ok = datos.Eliminar(Query);
            return ok;
        }
    }
}
