using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Mesero
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public double DNI { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string BarrioVereda { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public DataTable Cargar()
        {
            DT = null;

            Query = "SELECT p.Codigo,DNI,TipoIdentificacion,p.Nombres,p.Apellidos,p.Departamento CodigoDepartamento,d.Nombre Departamento, "+
                    "p.Municipio CodigoMunicipio, m.Nombre Municipio, p.BarrioVereda,p.Direccion,p.TelefonoFijo,p.Email,p.Celular "+
                    "FROM Meseros p "+
                    "INNER JOIN Departamento d ON d.Codigo = p.Departamento "+
                    "INNER JOIN Municipio m ON m.Codigo = p.Municipio ";
            DT = datos.Consultar(Query);

            return DT;
        }

        public DataTable Buscar(string Dato)
        {
            DT = null;

            Query = "SELECT p.Codigo,DNI,TipoIdentificacion,p.Nombres,p.Apellidos,p.Departamento CodigoDepartamento,d.Nombre Departamento, " +
                    "p.Municipio CodigoMunicipio, m.Nombre Municipio, p.BarrioVereda,p.Direccion,p.TelefonoFijo,p.Email,p.Celular " +
                    "FROM Meseros p " +
                    "INNER JOIN Departamento d ON d.Codigo = p.Departamento " +
                    "INNER JOIN Municipio m ON m.Codigo = p.Municipio "+
                    "WHERE  (CONCAT(p.Nombres,' ',p.Apellidos) LIKE '"+Dato+ "%') OR DNI LIKE '" + Dato + "%'";
            DT = datos.Consultar(Query);

            return DT;
        }

        public DataTable BuscarUnico(string Dato)
        {
            DT = null;

            Query = "SELECT p.Codigo,DNI,TipoIdentificacion,CONCAT(p.Nombres,' ',p.Apellidos) NombreApellido,p.Departamento CodigoDepartamento,d.Nombre Departamento, " +
                    "p.Municipio CodigoMunicipio, m.Nombre Municipio, p.BarrioVereda,p.Direccion,p.TelefonoFijo,p.Email,p.Celular " +
                    "FROM Meseros p " +
                    "INNER JOIN Departamento d ON d.Codigo = p.Departamento " +
                    "INNER JOIN Municipio m ON m.Codigo = p.Municipio " +
                    "WHERE  (CONCAT(p.Nombres,' ',p.Apellidos) = '" + Dato + "') OR DNI = '" + Dato + "'";
            DT = datos.Consultar(Query);

            return DT;
        }

        private void AsignaParametros()
        {
            Parametros = new SqlParameter[11];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@DNI";
            Parametros[0].SqlDbType = SqlDbType.BigInt;
            Parametros[0].SqlValue = DNI;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@TipoIdentificacion";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].Size = 30;
            Parametros[1].SqlValue = TipoIdentificacion;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@Nombres";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].Size = 30;
            Parametros[2].SqlValue = Nombres;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Apellidos";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].Size = 30;
            Parametros[3].SqlValue = Apellidos;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Departamento";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].Size = 10;
            Parametros[4].SqlValue = Departamento;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Municipio";
            Parametros[5].SqlDbType = SqlDbType.Int;
            Parametros[5].Size = 10;
            Parametros[5].SqlValue = Municipio;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@BarrioVereda";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].Size = 60;
            Parametros[6].SqlValue = BarrioVereda;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Direccion";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].Size = 100;
            Parametros[7].SqlValue = Direccion;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@TelefonoFijo";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].Size = 8;
            Parametros[8].SqlValue = Telefono;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Email";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].Size = 100;
            Parametros[9].SqlValue = Email;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Celular";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].Size = 11;
            Parametros[10].SqlValue = Celular;

        }

        public Boolean Registrar()
        {
            Query = " INSERT INTO Meseros(DNI,TipoIdentificacion,Nombres,Apellidos,Departamento,Municipio,BarrioVereda,Direccion, " +
                          " TelefonoFijo,Email,Celular) " +
                          " VALUES(@DNI,@TipoIdentificacion,@Nombres,@Apellidos,@Departamento,@Municipio,@BarrioVereda,@Direccion, " +
                          "@TelefonoFijo,@Email,@Celular) ";

            AsignaParametros();
            ok = datos.Registrar(Parametros, Query);
            return ok;
        }

        public Boolean Modificar()
        {
            Query = " UPDATE Meseros  " +
                        " SET TipoIdentificacion = @TipoIdentificacion,Nombres = @Nombres,Apellidos = @Apellidos,Departamento = @Departamento,Municipio = @Municipio,BarrioVereda = @BarrioVereda,Direccion = @Direccion, " +
                        " TelefonoFijo = @TelefonoFijo,Email = @Email,Celular = @Celular" +
                        " WHERE DNI = '" + DNI + "' ";

            AsignaParametros();
            ok = datos.Modificar(Parametros, Query);
            return ok;
        }
    }
}
