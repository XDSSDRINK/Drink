using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
    class SDL
    {
        DataTable data;
        Boolean ok = true;
        SqlParameter[] Parametros;
        String query = "", where = "";
        MODEL.Datos datos = new MODEL.Datos();

        //getter and setter
        private String codEmpresa;
        private String numLic;
        private String codigo;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private String estado;

        public String codEmpresa_
        {
            get { return codEmpresa; }
            set { codEmpresa = value; }
        }

        public String numLic_
        {
            get { return numLic; }
            set { numLic = value; }
        }

        public String codigo_
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime fechaIni_
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }

        public DateTime fechaFin_
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public String estado_
        {
            get { return estado; }
            set { estado = value; }
        }

        public DataTable buscarSDL(String codEmpresa, String numLic)
        {
            data = null;
            where = "";

            query = "SELECT codEmpresa, numLic, codigo, fechaIni, fechaFin, Estado " +
                    " FROM SDL " +
                    " WHERE 1 = 1 ";

            if (!codEmpresa.Equals(""))
            {
                query += " AND codEmpresa = '" + codEmpresa.ToString() + "' ";
            }

            if (!numLic.Equals(""))
            {
                query += " AND numlic = '" + numLic + "' ";
            }

            data = datos.Consultar(query);
            return data;
        }

        public Boolean registrar()
        {
            Parametros = new SqlParameter[6];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@codEmpresa";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 100;
            Parametros[0].SqlValue = codEmpresa;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@numLic";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].Size = 200;
            Parametros[1].SqlValue = numLic;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@codigo";
            Parametros[2].SqlDbType = SqlDbType.VarChar;
            Parametros[2].Size = 4000;
            Parametros[2].SqlValue = codigo;

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@fechaIni";
            Parametros[3].SqlDbType = SqlDbType.SmallDateTime;
            Parametros[3].SqlValue = fechaIni;

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@fechaFin";
            Parametros[4].SqlDbType = SqlDbType.SmallDateTime;
            Parametros[4].SqlValue = fechaFin;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Estado";
            Parametros[5].SqlDbType = SqlDbType.VarChar;
            Parametros[5].Size = 1;
            Parametros[5].SqlValue = estado;

            query = "INSERT INTO SDL (codEmpresa, numLic, codigo, fechaIni, fechaFin, Estado) " +
                    " VALUES(@codEmpresa, @numLic, @codigo, @fechaIni, @fechaFin, @Estado) ";
            ok = datos.Registrar(Parametros, query);

            return ok;
        }

        public Boolean Eliminar(String codEmpresa, String numLic)
        {
            query = " DELETE FROM SDL WHERE 1 = 1 AND codEmpresa = '" + codEmpresa.ToString() + "' AND numlic = '" + numLic + "' ";
            ok = datos.Eliminar(query);
            return ok;
        }

        /// <summary>
        /// Genera la licencia con las siguientes posiciones
        /// año Inicial
        /// 2 numeros aleatorios entre 10 y 99
        /// numero de liciencia
        /// codigo de cliente
        /// 3 numeros aleatorios entre 100 y 999
        /// mes final
        /// 2 numeros aleatorios entre 10 y 99
        /// año final
        /// dia final
        /// 1 numero aleatorio entre 0 y 9
        /// dia inicial
        /// numero de licencia
        /// 4 numeros aleatorios entre 1000 y 9999
        /// mes inicial
        /// </summary>
        /// <returns></returns>
        public String generarLicencia()
        {
            int numAle;
            String salida = "";
            String diaIni = "", mesIni = "", diaFin = "", mesFin = "";

            if (fechaIni.Day < 10)
            {
                diaIni = "0" + fechaIni.Day.ToString();
            }
            else
            {
                diaIni = fechaIni.Day.ToString();
            }

            if (fechaIni.Month < 10)
            {
                mesIni = "0" + fechaIni.Month.ToString();
            }
            else
            {
                mesIni = fechaIni.Month.ToString();
            }

            if (fechaFin.Day < 10)
            {
                diaFin = "0" + fechaFin.Day.ToString();
            }
            else
            {
                diaFin = fechaFin.Day.ToString();
            }

            if (fechaFin.Month < 10)
            {
                mesFin = "0" + fechaFin.Month.ToString();
            }
            else
            {
                mesFin = fechaFin.Month.ToString();
            }

            numAle = numeroAleatorio(10, 99);
            salida = fechaIni.Year.ToString() + numAle.ToString() + numLic.ToString();
            numAle = numeroAleatorio(100, 999);
            salida += codEmpresa.ToString() + numAle.ToString() + mesFin;
            numAle = numeroAleatorio(10, 99);
            salida += numAle.ToString() + fechaFin.Year.ToString() + diaFin;
            numAle = numeroAleatorio(0, 9);
            salida += numAle.ToString() + diaIni + numLic.ToString();
            numAle = numeroAleatorio(1000, 9999);
            salida += numAle.ToString() + mesIni;
            return salida;
        }

        //Para generar numeros aleatorios
        private int numeroAleatorio(int numIni, int numFin)
        {
            int salida = 0;
            Random rnd = new Random();
            salida = rnd.Next(numIni, numFin);
            return salida;
        }

        //Algoritmo para leer la licencia
        public SDL leerLicencia(String cadena)
        {
            SDL oSDL = new SDL();
            int anioIni = 0, anioFin = 0, mesIni = 0, mesfin = 0, diaIni = 0, diaFin = 0;

            anioIni = int.Parse(cadena.Substring(0, 4));
            mesIni = int.Parse(cadena.Substring(41, 2));
            diaIni = int.Parse(cadena.Substring(30, 2));

            anioFin = int.Parse(cadena.Substring(23, 4));
            mesfin = int.Parse(cadena.Substring(19, 2));
            diaFin = int.Parse(cadena.Substring(27, 2));

            oSDL.codEmpresa_ = cadena.Substring(11, 5);
            oSDL.numLic_ = cadena.Substring(6, 5);
            oSDL.codigo_ = cadena;
            oSDL.fechaIni_ = new DateTime(anioIni, mesIni, diaIni);
            oSDL.fechaFin_ = new DateTime(anioFin, mesfin, diaFin);
            oSDL.estado_ = "A";

            return oSDL;
        }
    }
}
