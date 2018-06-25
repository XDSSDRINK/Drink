using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Cliente
    {
        MODEL.Datos datos = new MODEL.Datos();

        DataTable DT;
        string Query = "";
        Boolean ok = true;
        SqlParameter[] Parametros;
        string WHERE = "";

        public string Codigo { get; set; }
        public long DNI { get; set; }
        public int DgVerificacion { get; set; }
        public string TipoPersona { get; set; }
        public string TipoIdentificacion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string BarrioVereda { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Email { get; set; }
        public string SitioWeb { get; set; }
        public string IVA { get; set; }
        public int Estado { get; set; }
        public int Banco { get; set; }
        public int TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }

        public int CodigoUsuario { get; set; }

        private void AsignaParametros()
        {
            Parametros = new SqlParameter[27];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@DNI";
            Parametros[0].SqlDbType = SqlDbType.BigInt;
            Parametros[0].SqlValue = DNI;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@DigitoVerificacion";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = DgVerificacion;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@TipoPersona";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].Size = 30;
            Parametros[2].SqlValue = TipoPersona;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@TipoIdentificacion";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].Size = 30;
            Parametros[3].SqlValue = TipoIdentificacion;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@RazonSocial";
            Parametros[4].SqlDbType = SqlDbType.VarChar;
            Parametros[4].Size = 60;
            Parametros[4].SqlValue = RazonSocial;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@NombreComercial";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].Size = 70;
            Parametros[5].SqlValue = NombreComercial;

            if (Nombre == null)
            {
                Nombre = "";
            }
            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@Nombres";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].Size = 35;
            Parametros[6].SqlValue = Nombre;

            if (Apellidos == null)
            {
                Apellidos = "";
            }
            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@Apellidos";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].Size = 40;
            Parametros[7].SqlValue = Apellidos;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Departamento";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].Size = 10;
            Parametros[8].SqlValue = Departamento;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Municipio";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].Size = 10;
            Parametros[9].SqlValue = Municipio;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@BarrioVereda";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].Size = 60;
            Parametros[10].SqlValue = BarrioVereda;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Direccion";
            Parametros[11].SqlDbType = SqlDbType.VarChar;
            Parametros[11].Size = 100;
            Parametros[11].SqlValue = Direccion;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@TelefonoFijo";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].Size = 8;
            Parametros[12].SqlValue = Telefono;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@Extension";
            Parametros[13].SqlDbType = SqlDbType.VarChar;
            Parametros[13].Size = 4;
            Parametros[13].SqlValue = Extension;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@Fax";
            Parametros[14].SqlDbType = SqlDbType.VarChar;
            Parametros[14].Size = 8;
            Parametros[14].SqlValue = Fax;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@Celular1";
            Parametros[15].SqlDbType = SqlDbType.VarChar;
            Parametros[15].Size = 10;
            Parametros[15].SqlValue = Celular1;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@Celular2";
            Parametros[16].SqlDbType = SqlDbType.VarChar;
            Parametros[16].Size = 10;
            Parametros[16].SqlValue = Celular2;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@Email";
            Parametros[17].SqlDbType = SqlDbType.VarChar;
            Parametros[17].Size = 100;
            Parametros[17].SqlValue = Email;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@SitioWeb";
            Parametros[18].SqlDbType = SqlDbType.VarChar;
            Parametros[18].Size = 100;
            Parametros[18].SqlValue = SitioWeb;

            Parametros[19] = new SqlParameter();
            Parametros[19].ParameterName = "@IVA";
            Parametros[19].SqlDbType = SqlDbType.VarChar;
            Parametros[19].Size = 2;
            Parametros[19].SqlValue = IVA;

            Parametros[20] = new SqlParameter();
            Parametros[20].ParameterName = "@Estado";
            Parametros[20].SqlDbType = SqlDbType.Int;
            Parametros[20].SqlValue = Estado;

            Parametros[21] = new SqlParameter();
            Parametros[21].ParameterName = "@Banco";
            Parametros[21].SqlDbType = SqlDbType.Int;
            Parametros[21].SqlValue = Banco;

            Parametros[22] = new SqlParameter();
            Parametros[22].ParameterName = "@TipoCuenta";
            Parametros[22].SqlDbType = SqlDbType.Int;
            Parametros[22].SqlValue = TipoCuenta;

            Parametros[23] = new SqlParameter();
            Parametros[23].ParameterName = "@NumeroCuenta";
            Parametros[23].SqlDbType = SqlDbType.VarChar;
            Parametros[23].Size = 20;
            Parametros[23].SqlValue = NumeroCuenta;

            Parametros[24] = new SqlParameter();
            Parametros[24].ParameterName = "@UsuarioCrea";
            Parametros[24].SqlDbType = SqlDbType.Int;
            Parametros[24].SqlValue = CodigoUsuario;
        
            Parametros[25] = new SqlParameter();
            Parametros[25].ParameterName = "@FechaRegistro";
            Parametros[25].SqlDbType = SqlDbType.Date;
            Parametros[25].SqlValue = DateTime.Today;

            Parametros[26] = new SqlParameter();
            Parametros[26].ParameterName = "@HoraRegistro";
            Parametros[26].SqlDbType = SqlDbType.DateTime2;
            Parametros[26].SqlValue = DateTime.Now;
        }

        public Boolean Registrar()
        {
            Query = " INSERT INTO Cliente(DNI,DigitoVerificacion,TipoPersona,TipoIdentificacion,RazonSocial,NombreComercial, " +
                          "Nombres,Apellidos,Departamento,Municipio,BarrioVereda,Direccion,TelefonoFijo,Extension,Fax,Celular1,Celular2, " +
                          "Email,SitioWeb,IVA,Estado,Banco,TipoCuenta,NumeroCuenta,FechaRegistro,HoraRegistro,UsuarioCrea)" +
                          " VALUES(@DNI,@DigitoVerificacion,@TipoPersona,@TipoIdentificacion,@RazonSocial,@NombreComercial, " +
                          "@Nombres,@Apellidos,@Departamento,@Municipio,@BarrioVereda,@Direccion,@TelefonoFijo,@Extension,@Fax,@Celular1,@Celular2, " +
                          "@Email,@SitioWeb,@IVA,@Estado,@Banco,@TipoCuenta,@NumeroCuenta,@FechaRegistro,@HoraRegistro,@UsuarioCrea)";

            AsignaParametros();
            ok = datos.Registrar(Parametros, Query);
            return ok;
        }

        public Boolean Modificar()
        {
            Query = "UPDATE Cliente SET TipoPersona = @TipoPersona,TipoIdentificacion = @TipoIdentificacion,RazonSocial = @RazonSocial, " +
                    " NombreComercial = @NombreComercial,Nombres = @Nombres,Apellidos = @Apellidos,Departamento = @Departamento, " +
                    "Municipio = @Municipio,BarrioVereda = @BarrioVereda, Direccion = @Direccion,TelefonoFijo = @TelefonoFijo, " +
                    "Extension = @Extension,Fax = @Fax,Celular1 = @Celular1,Celular2 = @Celular2, Email = @Email, " +
                    "SitioWeb = @SitioWeb,IVA = @IVA, Estado = @Estado,Banco = @Banco,TipoCuenta = @TipoCuenta,NumeroCuenta = @NumeroCuenta, " +
                    " UsuarioModifica = " + CodigoUsuario + ", FechaModificacion = '" + DateTime.Today + "',HoraModificacion = '" + DateTime.Now + "'" +
                    " WHERE DNI = '" + DNI + "' ";

            AsignaParametros();
            ok = datos.Registrar(Parametros, Query);
            return ok;
        }

        public DataTable Cargar(string Campo, string Dato, string modulo)
        {
            DT = null;
            

            if (modulo == "COMPRAS" || modulo == "Ayuda")
            {
                WHERE = " WHERE c.Estado = '1' ";

                if (Campo != "" || Dato != "")
                {
                    WHERE = " WHERE " + Campo + " like '" + Dato + "%' AND c.Estado = '1' ";
                }
            }
            else if (modulo == "Unico")
            {
                WHERE = " ";

                if (Campo != "" || Dato != "")
                {
                    WHERE = " WHERE " + Campo + " = '" + Dato + "' ";
                }
            }
            else if (modulo == "Relacionados")
            {
                WHERE = " ";

                if (Campo != "" || Dato != "")
                {
                    WHERE = " WHERE " + Campo + " like '" + Dato + "%' ";
                }
            }
            else if (modulo == "AyudaUnico")
            {
                WHERE = " ";

                if (Campo != "" && Dato != "")
                {
                    WHERE = " WHERE " + Campo + " = '" + Dato + "' AND c.Estado = '1' ";
                }
                else
                {
                    WHERE = " WHERE c.Estado = '1' ";
                }
            }

            Query = "SELECT c.Codigo,DNI,DigitoVerificacion,TipoPersona,TipoIdentificacion,RazonSocial,NombreComercial, " +
                        "Nombres,Apellidos,d.Nombre Departamento, m.Nombre Municipio, BarrioVereda, Direccion, " +
                        "TelefonoFijo,Extension,Fax,Celular1,Celular2, Email,SitioWeb,IVA,c.Estado, " +
                        "Ban.Nombre Banco, tpc.Nombre TipoCuenta,c.NumeroCuenta " +
                        "FROM Cliente c " +
                        "INNER JOIN Departamento d ON c.Departamento = d.Codigo " +
                        "INNER JOIN Municipio m ON c.Municipio = m.Codigo " +
                        "INNER JOIN Banco Ban ON c.Banco = Ban.ID " +
                        "INNER JOIN TipoCuenta tpc ON c.TipoCuenta = tpc.ID " + WHERE;

            DT = datos.Consultar(Query);

            return DT;
        }

        public DataTable CargarActivos(string Buscar)
        {
            WHERE = "";
            if (Buscar.Trim() != "")
            {
                WHERE = " AND DNI = "+Buscar;
            }

            Query = "SELECT * FROM Cliente c "+
                    "INNER JOIN EstadoCliente Ec ON c.Estado = ec.Codigo "+
                    "WHERE ec.Estado = 'Activo' "+WHERE;
            DT = datos.Consultar(Query);
            return DT;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM Cliente WHERE Codigo = '" + Codigo + "'";
            ok = datos.Eliminar(Query);
            return ok;
        }

        public DataTable CargarPermisos(string Usuario, string Modulo)
        {
            Query = "EXECUTE SP_VERIFICAR_MODULO_PERMISOS '" + Usuario + "','" + Modulo + "' ";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
