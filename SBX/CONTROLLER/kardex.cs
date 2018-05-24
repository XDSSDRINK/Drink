using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBX.CONTROLLER
{
   public class kardex
    {
        MODEL.Datos datos = new MODEL.Datos();

        string Query = "";
        DataTable DT;
        Boolean ok = true;
        SqlParameter[] Parametros;

        public int ID { get; set; }
        public int IdCompra { get; set; }
        public float Entrada { get; set; }
        public int IdVenta { get; set; }
        public float Salida { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Modulo { get; set; }

        public int CodigoUsuario { get; set; }

        public DataTable CargarKardex(Boolean Todos)
        {
            DT = null;
          
            Query = "SELECT * FROM Kardex ";
            DT = datos.Consultar(Query);

            return DT;
        }

        public Boolean Registrar()
        {
            Query = "EXECUTE SP_INSERTAR_KARDEX '"+ Modulo +"', "+ CodigoUsuario + " ";

            ok = datos.Execute(Query);

            return ok;
        }

        //En caso de que despues de que se registro una venta o compra por alguna razon x, no se registra en kardex,
        //se deberia eliminar la compra o la venta. 
        //Nota: Este metodo no esta en uso por el momento
        public Boolean EliminarReistroCompra()
        {
            //Query = "EXECUTE SP_ELIMINAR_COMPRA_O_VENTA '" + Modulo + "' ";

            //ok = datos.Execute(Query);

            return ok;
        }

    }
}
