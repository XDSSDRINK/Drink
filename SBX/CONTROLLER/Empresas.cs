using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    class Empresas
    {
        DataTable data;
        Boolean ok = true;
        SqlParameter[] Parametros;
        String query = "", where = "";
        MODEL.Datos datos = new MODEL.Datos();

        //getter and setter
        private String codEmpresa;
        private String DNI;
        private String nombre;
        private String numlic;

        public String codEmpresa_
        {
            get { return codEmpresa; }
            set { codEmpresa = value; }
        }

        public String DNI_
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public String nombre_
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String numlic_
        {
            get { return numlic; }
            set { numlic = value; }
        }

        //Funcion para buscar empresa
        public DataTable buscarEmpresa(String codEmpresa, String DNI = "")
        {
            data = null;
            where = "";

            query = "SELECT codEmpresa, dni, nombre, numLic " +
                    " FROM EMPRESA " +
                    " WHERE 1 = 1 ";

            if (!codEmpresa.Equals(""))
            {
                query += " AND codEmpresa = '" + codEmpresa + "' ";
            }

            if (!DNI.Equals(""))
            {
                query += " AND dni = '" + DNI + "' ";
            }

            data = datos.Consultar(query);
            return data;
        }

        public Boolean modificar()
        {
            Parametros = new SqlParameter[1];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@numLic";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 4000;
            Parametros[0].SqlValue = numlic;

            query = " UPDATE EMPRESA SET numLic = @numLic ";
            ok = datos.Modificar(Parametros, query);
            return ok;
        }
    }
}
