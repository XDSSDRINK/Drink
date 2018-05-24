using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Login
    {
        MODEL.Datos datos = new MODEL.Datos();

        DataTable DT;

        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        string Query = "";

        public DataTable VerificarUsuario()
        {
            Query = "EXECUTE SP_VERIFICA_USUARIO_LOGIN " + "'" + Usuario + "','" + Contrasena + "'";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
