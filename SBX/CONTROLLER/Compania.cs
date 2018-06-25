using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    public class Compania
    {
        MODEL.Datos datos = new MODEL.Datos();
        string Query = "";
        System.Data.DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public int CodCompania { get; set; }
        public string DNI { get; set; }
        public int DigVerificacion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public Image Logo { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string BarrioVereda { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string SitioWeb { get; set; }
        public int Regimen { get; set; }
        public int Estado { get; set; }
        public int Banco { get; set; }
        public int TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public int UsuarioCrea { get; set; }
        public string FechaRegistro { get; set; }
        public string HoraRegistro { get; set; }
        public int UsuarioModifica { get; set; }
        public string FechaModificacion { get; set; }
        public string HoraModificacion { get; set; }
        public string numLic { get; set; }

        public Boolean Registrar()
        {
            Parametros = new SqlParameter[24];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@DNI";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].SqlValue = DNI;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@DigVerificacion";
            Parametros[1].SqlDbType = SqlDbType.Int;
            Parametros[1].SqlValue = DigVerificacion;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@RazonSocial";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].SqlValue = RazonSocial;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@NombreComercial";
            Parametros[3].SqlDbType = SqlDbType.VarChar;
            Parametros[3].SqlValue = NombreComercial;

            // Asignando el valor de la imagen
            // Stream usado como buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer

            Logo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.


            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Logo";
            Parametros[4].SqlDbType = SqlDbType.Image;
            Parametros[4].SqlValue = ms.GetBuffer();  

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Departamento";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].SqlValue = Departamento;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@Municipio";
            Parametros[6].SqlDbType = SqlDbType.VarChar;
            Parametros[6].SqlValue = Municipio;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@BarrioVereda";
            Parametros[7].SqlDbType = SqlDbType.VarChar;
            Parametros[7].SqlValue = BarrioVereda;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@Direccion";
            Parametros[8].SqlDbType = SqlDbType.VarChar;
            Parametros[8].SqlValue = Direccion;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Telefono";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].SqlValue = Telefono;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@Extension";
            Parametros[10].SqlDbType = SqlDbType.VarChar;
            Parametros[10].SqlValue = Extension;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Fax";
            Parametros[11].SqlDbType = SqlDbType.VarChar;
            Parametros[11].SqlValue = Fax;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@Celular";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].SqlValue = Celular;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@Email";
            Parametros[13].SqlDbType = SqlDbType.VarChar;
            Parametros[13].SqlValue = Email;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@SitioWeb";
            Parametros[14].SqlDbType = SqlDbType.VarChar;
            Parametros[14].SqlValue = SitioWeb;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@Regimen";
            Parametros[15].SqlDbType = SqlDbType.Int;
            Parametros[15].SqlValue = Regimen;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@Estado";
            Parametros[16].SqlDbType = SqlDbType.Int;
            Parametros[16].SqlValue = Estado;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@Banco";
            Parametros[17].SqlDbType = SqlDbType.Int;
            Parametros[17].SqlValue = Banco;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@TipoCuenta";
            Parametros[18].SqlDbType = SqlDbType.Int;
            Parametros[18].SqlValue = TipoCuenta;

            Parametros[19] = new SqlParameter();
            Parametros[19].ParameterName = "@NumeroCuenta";
            Parametros[19].SqlDbType = SqlDbType.VarChar;
            Parametros[19].SqlValue = NumeroCuenta;

            Parametros[20] = new SqlParameter();
            Parametros[20].ParameterName = "@UsuarioCrea";
            Parametros[20].SqlDbType = SqlDbType.Int;
            Parametros[20].SqlValue = UsuarioCrea;

            Parametros[21] = new SqlParameter();
            Parametros[21].ParameterName = "@FechaRegistro";
            Parametros[21].SqlDbType = SqlDbType.Date;
            Parametros[21].SqlValue = DateTime.Today;

            Parametros[22] = new SqlParameter();
            Parametros[22].ParameterName = "@HoraRegistro";
            Parametros[22].SqlDbType = SqlDbType.DateTime2;
            Parametros[22].SqlValue = DateTime.Now;

            //Parametros[23] = new SqlParameter();
            //Parametros[23].ParameterName = "@UsuarioModifica";
            //Parametros[23].SqlDbType = SqlDbType.Int;
            //Parametros[23].SqlValue = UsuarioModifica;

            //Parametros[24] = new SqlParameter();
            //Parametros[24].ParameterName = "@FechaModificacion";
            //Parametros[24].SqlDbType = SqlDbType.Date;
            //Parametros[24].SqlValue = FechaModificacion;

            //Parametros[25] = new SqlParameter();
            //Parametros[25].ParameterName = "@HoraModificacion";
            //Parametros[25].SqlDbType = SqlDbType.DateTime2;
            //Parametros[25].SqlValue = HoraModificacion;

            Parametros[23] = new SqlParameter();
            Parametros[23].ParameterName = "@numLic";
            Parametros[23].SqlDbType = SqlDbType.VarChar;
            Parametros[23].SqlValue = numLic;

            Query = "INSERT INTO COMPANIA (DNI,DigVerificacion,RazonSocial,NombreComercial,Logo,Departamento "+
                ",Municipio,BarrioVereda,Direccion,Telefono,Extension,Fax,Celular,Email,SitioWeb,Regimen,Estado "+
                ",Banco,TipoCuenta,NumCuenta,UsuarioCrea,FechaRegistro,HoraRegistro "+
                ",numLic)  " +
                "VALUES(@DNI,@DigVerificacion,@RazonSocial,@NombreComercial,@Logo,@Departamento " +
                ",@Municipio,@BarrioVereda,@Direccion,@Telefono,@Extension,@Fax,@Celular,@Email,@SitioWeb,@Regimen,@Estado " +
                ",@Banco,@TipoCuenta,@NumeroCuenta,@UsuarioCrea,@FechaRegistro,@HoraRegistro " +
                ",@numLic) ";

            ok = datos.Registrar(Parametros, Query);

            return ok;
        }

        public Boolean Eliminar()
        {
            Query = "DELETE FROM COMPANIA";
            ok = datos.Eliminar(Query);
            return ok;
        }

        public DataTable CargarCompania()
        {
            Query = "SELECT cmp.codCompania,cmp.DNI,cmp.DigVerificacion,cmp.RazonSocial,cmp.NombreComercial, "+
            "dp.Nombre Departamento, mnp.Nombre Municipio, cmp.BarrioVereda,cmp.Direccion, cmp.Telefono, "+
            "cmp.Extension,cmp.Fax,cmp.Celular,cmp.Email,cmp.SitioWeb,rg.Nombre Regimen, est.Nombre Estado, "+
            "bc.Nombre Banco, tpc.Nombre TipoCuenta, cmp.NumCuenta,cmp.numLic,cmp.logo " +
            "FROM Compania cmp "+
            "INNER JOIN Departamento dp ON cmp.Departamento = dp.Codigo "+
            "INNER JOIN Municipio mnp ON cmp.Municipio = mnp.Codigo "+
            "INNER JOIN Regimen rg ON cmp.Regimen = rg.ID " +
            "INNER JOIN Estado est ON cmp.Estado = est.ID "+
            "INNER JOIN Banco bc ON cmp.Banco = bc.ID "+
            "INNER JOIN TipoCuenta tpc ON cmp.TipoCuenta = tpc.ID";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
