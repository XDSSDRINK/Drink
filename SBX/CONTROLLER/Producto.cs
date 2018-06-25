using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBX.MODEL;

namespace SBX.CONTROLLER
{
    public class Producto
    {
        Datos datos = new Datos();

        DataTable DT;
        string Query = "";
        Boolean ok = true;
        SqlParameter[] Parametros;
        string WHERE = "";

        //getter and setter
        private string Item;
        private string CodigoBarras;
        private string Referencia;
        private string Nombre;
        private string Descripcion;
        private float IVA;
        private Image Foto;
        private int marca;
        private int presentacion;
        private int categoria;
        private int modoVenta;
        private int UnidadMedida;
        private string Medida;
        private decimal Stock;
        private int Estado;
        private int AplicaFechaVence;
        private int GeneraIVA;

        public string Item_
        {
            get { return Item; }
            set { Item = value; }
        }
        public string CodigoBarras_
        {
            get { return CodigoBarras; }
            set { CodigoBarras = value; }
        }
        public string Referencia_
        {
            get { return Referencia; }
            set { Referencia = value; }
        }
        public string Nombre_
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string Descripcion_
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public float IVA_
        {
            get { return IVA; }
            set { IVA = value; }
        }
        public Image Foto_
        {
            get { return Foto; }
            set { Foto = value; }
        }
        public int marca_
        {
            get { return marca; }
            set { marca = value; }
        }
        public int presentacion_
        {
            get { return presentacion; }
            set { presentacion = value; }
        }
        public int categoria_
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int modoVenta_
        {
            get { return modoVenta; }
            set { modoVenta = value; }
        }
        public int UnidadMedida_
        {
            get { return UnidadMedida; }
            set { UnidadMedida = value; }
        }
        public string Medida_
        {
            get { return Medida; }
            set { Medida = value; }
        }
        public decimal Stock_
        {
            get { return Stock; }
            set { Stock = value; }
        }
        public decimal StockMaximo { get; set; }
        public int Estado_
        {
            get { return Estado; }
            set { Estado = value; }
        }
        public int AplicaFechaVence_
        {
            get { return AplicaFechaVence; }
            set { AplicaFechaVence = value; }
        }
        public int GeneraIVA_
        {
            get { return GeneraIVA; }
            set { GeneraIVA = value; }
        }
        public int DiasFechaVence { get; set; }
        public int CodigoUsuario { get; set; }

        public DataTable CargarProducto(string Campo, string Dato, string modulo)
        {
            DT = null;

            WHERE = "";

            switch (modulo)
            {
                case "Ayuda":
                    WHERE = "WHERE pd.Estado = '1' ";

                    if (Campo != "" || Dato != "")
                    {
                        WHERE = "WHERE " + Campo + " like '" + Dato + "%' AND pd.Estado = '1' ";
                    }
                    break;
                case "Compra":
                    WHERE = "";

                    if (Campo != "" || Dato != "")
                    {
                        WHERE = "WHERE " + Campo + " = '" + Dato + "' AND pd.Estado = 'A' ";
                    }
                    break;
                case "Unico":
                    WHERE = "";

                    if (Campo != "" || Dato != "")
                    {
                        WHERE = "WHERE " + Campo + " = '" + Dato + "' ";
                    }
                    break;
                case "Relacionados":
                    WHERE = "";

                    if (Campo != "" || Dato != "")
                    {
                        WHERE = "WHERE " + Campo + " like '" + Dato + "%' ";
                    }
                    break;
                case "AyudaUnico":
                    WHERE = "";

                    if (Campo != "" || Dato != "")
                    {
                        WHERE = "WHERE " + Campo + " = '" + Dato + "' AND pd.Estado = '1' ";
                    }
                    break;
            }

            Query = "SELECT pd.ID CodigoProducto,pd.Item,pd.Referencia,pd.Nombre,pd.Descripcion,pd.iva,pd.Foto, " +
                    "mc.ID Idmarca,mc.Nombre Marca,ct.ID IdCategoria,ct.Nombre Categoria," +
                    "ps.ID IdPresentacion,ps.Nombre Presentacion,mv.ID IdModoVenta,mv.Nombre " +
                    "ModoVenta,um.ID IdUnidadMedida,um.Nombre UnidadMedida, pd.Medida, pd.Stock, " +
                    "EP.Estado,pd.AplicaFechaVencimiento,pd.GeneraIVA,pd.StockMaximo,pd.DiasAlertFechaV " +
                    "FROM Producto pd " +
                    "INNER JOIN Marca mc ON pd.Marca = mc.ID " +
                    "INNER JOIN Categoria ct ON pd.Categoria = ct.ID " +
                    "INNER JOIN Presentacion ps ON pd.Presentacion = ps.ID " +
                    "INNER JOIN ModoVenta mv ON pd.ModoVenta = mv.ID " +
                    "INNER JOIN UnidadMedida um ON pd.UnidadMedida = um.ID " +
                    "INNER JOIN EstadoProducto EP ON pd.Estado = EP.IdEstado " + WHERE + " ORDER BY pd.Item DESC ";

            DT = datos.Consultar(Query);

            return DT;
        }
        public DataTable CargarPermisos(string Usuario, string Modulo)
        {
            Query = "EXECUTE SP_VERIFICAR_MODULO_PERMISOS '"+Usuario+"','"+Modulo+"' ";
            DT = datos.Consultar(Query);
            return DT;
        }
        private void AsignaParametros()
        {
            Parametros = new SqlParameter[21];

            Parametros[0] = new SqlParameter();
            Parametros[0].ParameterName = "@Nombre";
            Parametros[0].SqlDbType = SqlDbType.VarChar;
            Parametros[0].Size = 50;
            Parametros[0].SqlValue = Nombre;

            Parametros[1] = new SqlParameter();
            Parametros[1].ParameterName = "@Descripcion";
            Parametros[1].SqlDbType = SqlDbType.VarChar;
            Parametros[1].Size = 200;
            Parametros[1].SqlValue = Descripcion;

            Parametros[2] = new SqlParameter();
            Parametros[2].ParameterName = "@iva";
            Parametros[2].SqlDbType = SqlDbType.Float;
            Parametros[2].SqlValue = IVA;

            // Asignando el valor de la imagen
            // Stream usado como buffer
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            // Se guarda la imagen en el buffer

            Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Se extraen los bytes del buffer para asignarlos como valor para el 
            // parámetro.

            Parametros[3] = new SqlParameter();
            Parametros[3].ParameterName = "@Foto";
            Parametros[3].SqlDbType = SqlDbType.Image;
            Parametros[3].SqlValue = ms.GetBuffer();

            Parametros[4] = new SqlParameter();
            Parametros[4].ParameterName = "@Marca";
            Parametros[4].SqlDbType = SqlDbType.Int;
            Parametros[4].SqlValue = marca;

            Parametros[5] = new SqlParameter();
            Parametros[5].ParameterName = "@Categoria";
            Parametros[5].SqlDbType = SqlDbType.Int;
            Parametros[5].SqlValue = categoria;

            Parametros[6] = new SqlParameter();
            Parametros[6].ParameterName = "@Presentacion";
            Parametros[6].SqlDbType = SqlDbType.Int;
            Parametros[6].SqlValue = presentacion;

            Parametros[7] = new SqlParameter();
            Parametros[7].ParameterName = "@ModoVenta";
            Parametros[7].SqlDbType = SqlDbType.Int;
            Parametros[7].SqlValue = modoVenta;

            Parametros[8] = new SqlParameter();
            Parametros[8].ParameterName = "@TipoUnidadMedida";
            Parametros[8].SqlDbType = SqlDbType.Int;
            Parametros[8].SqlValue = UnidadMedida;

            Parametros[9] = new SqlParameter();
            Parametros[9].ParameterName = "@Medida";
            Parametros[9].SqlDbType = SqlDbType.VarChar;
            Parametros[9].Size = 40;
            Parametros[9].SqlValue = Medida;

            Parametros[10] = new SqlParameter();
            Parametros[10].ParameterName = "@StockMinimo";
            Parametros[10].SqlDbType = SqlDbType.Decimal;
            Parametros[10].SqlValue = Stock;

            Parametros[11] = new SqlParameter();
            Parametros[11].ParameterName = "@Estado";
            Parametros[11].SqlDbType = SqlDbType.Int;
            Parametros[11].SqlValue = Estado;

            Parametros[12] = new SqlParameter();
            Parametros[12].ParameterName = "@Referencia";
            Parametros[12].SqlDbType = SqlDbType.VarChar;
            Parametros[12].Size = 30;
            Parametros[12].SqlValue = Referencia;

            Parametros[13] = new SqlParameter();
            Parametros[13].ParameterName = "@Item";
            Parametros[13].SqlDbType = SqlDbType.VarChar;
            Parametros[13].Size = 20;
            Parametros[13].SqlValue = Item;

            Parametros[14] = new SqlParameter();
            Parametros[14].ParameterName = "@AplicaFechaVence";
            Parametros[14].SqlDbType = SqlDbType.Int;
            Parametros[14].SqlValue = AplicaFechaVence;

            Parametros[15] = new SqlParameter();
            Parametros[15].ParameterName = "@GeneraIVA";
            Parametros[15].SqlDbType = SqlDbType.Int;
            Parametros[15].SqlValue = GeneraIVA;

            Parametros[16] = new SqlParameter();
            Parametros[16].ParameterName = "@UsuarioCrea";
            Parametros[16].SqlDbType = SqlDbType.Int;
            Parametros[16].SqlValue = CodigoUsuario;

            Parametros[17] = new SqlParameter();
            Parametros[17].ParameterName = "@FechaRegistro";
            Parametros[17].SqlDbType = SqlDbType.Date;
            Parametros[17].SqlValue = DateTime.Today;

            Parametros[18] = new SqlParameter();
            Parametros[18].ParameterName = "@HoraRegistro";
            Parametros[18].SqlDbType = SqlDbType.DateTime2;
            Parametros[18].SqlValue = DateTime.Now;

            Parametros[19] = new SqlParameter();
            Parametros[19].ParameterName = "@StockMaximo";
            Parametros[19].SqlDbType = SqlDbType.Decimal;
            Parametros[19].SqlValue = StockMaximo;

            Parametros[20] = new SqlParameter();
            Parametros[20].ParameterName = "@DiasAlertFechaV";
            Parametros[20].SqlDbType = SqlDbType.Int;
            Parametros[20].SqlValue = DiasFechaVence;
        }
        public Boolean Registrar()
        {
            Query = " INSERT INTO Producto(Item,Nombre,Descripcion,iva,Foto,Marca,Categoria,Presentacion, " +
                          "ModoVenta,UnidadMedida,Medida,Stock,Estado,Referencia,AplicaFechaVencimiento,GeneraIVA,UsuarioCrea,FechaRegistro,HoraRegistro,StockMaximo,DiasAlertFechaV) " +
                          " VALUES(@Item,@Nombre,@Descripcion,@iva,@Foto,@Marca,@Categoria,@Presentacion, " +
                          "@ModoVenta,@TipoUnidadMedida,@Medida,@StockMinimo,@Estado, @Referencia ,@AplicaFechaVence,@GeneraIVA,@UsuarioCrea,@FechaRegistro,@HoraRegistro,@StockMaximo,@DiasAlertFechaV) ";

            AsignaParametros();
            ok = datos.Registrar(Parametros, Query);
            return ok;
        }
        public Boolean Modificar()
        {
            Query = " UPDATE Producto  " +
                        " SET Nombre = @Nombre,Descripcion = @Descripcion,iva = @iva,Foto = @Foto, " +
                        " Marca = @Marca,Categoria = @Categoria,Presentacion = @Presentacion, " +
                        " ModoVenta = @ModoVenta,UnidadMedida = @TipoUnidadMedida,Medida = @Medida,Stock = @StockMinimo,  " +
                        " Estado = @Estado, Referencia =  @Referencia, AplicaFechaVencimiento = @AplicaFechaVence, GeneraIVA = @GeneraIVA, " +
                        " UsuarioModifica = "+ CodigoUsuario + ", FechaModificacion = '" + DateTime.Today+ "',HoraModificacion = '" + DateTime.Now + "',StockMaximo = @StockMaximo,DiasAlertFechaV = @DiasAlertFechaV " +
            " WHERE Item = '" + Item + "'";

            AsignaParametros();
            ok = datos.Modificar(Parametros, Query);
            return ok;
        }
        public Boolean Eliminar()
        {
            Query = "DELETE FROM Producto WHERE Item = '" + Item + "'";
            ok = datos.Eliminar(Query);
            return ok;
        }

        public DataTable CargarProductosDescuento(string Campo, string Dato)
        {
            WHERE = "";

            switch (Campo)
            {
                case "Item":
                    Campo = "p.Item";
                    break;
                case "CodigoBarras":
                    Campo = "c.CodigoBarras";
                    break;
                case "Nombre":
                    Campo = "p.Nombre";
                    break;
            }

            if (Campo != "" && Dato != "")
            {
                WHERE = " WHERE "+Campo+" LIKE '"+Dato+"%' ";
            }

            Query = "SELECT p.ID,p.Item, ISNULL(c.CodigoBarras,'') CodigoBarras, p.Nombre FROM Producto p "+
                    "LEFT JOIN Compras c ON C.CodigoProducto = P.ID "+
                     WHERE +
                    "GROUP BY p.ID,p.Item,c.CodigoBarras,p.Nombre " +
                    "ORDER BY p.Item";
            DT = datos.Consultar(Query);
            return DT;
        }
    }
}
