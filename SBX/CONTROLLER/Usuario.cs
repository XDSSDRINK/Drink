using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Usuario
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;
        Boolean ok = true;

        public int Codigo { get; set; }
        public int Persona { get; set; }
        public string usu { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public int Rol { get; set; }
        public string NombreRol { get; set; }

        public DataTable Cargar(Boolean Todos)
        {
            DT = null;

            Query = "SELECT per.Codigo CodigoPersona,per.DNI,per.TipoIdentificacion,per.Nombres,per.Apellidos,depart.Nombre Departamento,municip.Nombre Municipio, "+
                    "per.BarrioVereda,per.Direccion,per.TelefonoFijo,per.Email,per.Celular,usu.codigo CodigoUsuario,usu.Usuario,usu.Contraseña,usu.Estado," +
                    "r.ID IDRol,r.Nombre Rol "+
                    "FROM Usuario usu "+
                    "INNER JOIN Persona per on usu.Persona = per.Codigo "+
                    "INNER JOIN Departamento depart on per.Departamento = depart.Codigo "+
                    "INNER JOIN Municipio municip on per.Municipio = municip.Codigo "+
                    "INNER JOIN Rol r on r.ID = usu.Rol ";

            DT = datos.Consultar(Query);

            return DT;
        }

        public DataTable Buscar(string Dato)
        {
            DT = null;

            Query = "SELECT per.DNI,per.TipoIdentificacion,per.Nombres,per.Apellidos,depart.Nombre Departamento,municip.Nombre Municipio, " +
                    "per.BarrioVereda,per.Direccion,per.TelefonoFijo,per.Email,per.Celular,usu.codigo CodigoUsuario,usu.Usuario,usu.Contraseña,usu.Estado, " +
                    "r.Nombre Rol " +
                    "FROM Usuario usu " +
                    "INNER JOIN Persona per on usu.Persona = per.Codigo " +
                    "INNER JOIN Departamento depart on per.Departamento = depart.Codigo " +
                    "INNER JOIN Municipio municip on per.Municipio = municip.Codigo " +
                    "INNER JOIN Rol r on r.ID = usu.Rol WHERE usu.Usuario LIKE '"+Dato+"%'";

            DT = datos.Consultar(Query);

            return DT;
        }

        public bool Registrar()
        {
             Query = "EXECUTE SP_CREAR_USUARIOS "+ Persona + ",'"+usu+"','"+Contrasena+"','"+Estado+"','"+NombreRol+"'";
             ok = datos.Execute(Query);
            return ok; 
        }

        public bool Actualizar()
        {
            Query = "EXECUTE SP_ACTUALIZAR_USUARIOS "+Codigo+","+ Persona + ",'" + usu + "','" + Contrasena + "','" + Estado + "','" + NombreRol + "'";
            ok = datos.Execute(Query);
            return ok;
        }

        public bool Eliminar()
        {
            Query = "DELETE FROM Usuario WHERE Codigo = "+ Codigo;
            ok = datos.Eliminar(Query);
            return ok;
        }
    }
}
