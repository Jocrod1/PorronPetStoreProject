using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DProductos
    {
        private int _IdProducto;
        private string _NombreProducto;
        private int _IdProveedores;
        private int _StockProducto;
        private float _PrecioProducto;
        private float _PrecioVentaProducto;
        private string _TextoBuscar;

        /// <summary>
        
        /// </summary>
       public int IdProducto
       {
           get { return _IdProducto; }
           set { _IdProducto = value; }
       }

       public string NombreProducto
       {
           get { return _NombreProducto; }
           set { _NombreProducto = value; }
       }

       public int IdProveedores
       {
           get { return _IdProveedores; }
           set { _IdProveedores = value; }
       }

       public int StockProducto
       {
           get { return _StockProducto; }
           set { _StockProducto = value; }
       }

       public float PrecioProducto
       {
           get { return _PrecioProducto; }
           set { _PrecioProducto = value; }
       }

       public float PrecioVentaProducto
       {
           get { return _PrecioVentaProducto; }
           set { _PrecioVentaProducto = value; }
       }

       public string TextoBuscar
       {
           get { return _TextoBuscar; }
           set { _TextoBuscar = value; }
       }

       ///Constructores
       public DProductos()
       {

       }

       public DProductos( int IdProducto, string NombreProducto, int IdProveedores, int StockProducto, float PrecioProducto, float PrecioVentaProducto)
       {
           this.IdProducto = IdProducto;
           this.NombreProducto = NombreProducto;
           this.IdProveedores = IdProveedores;
           this.StockProducto = StockProducto;
           this.PrecioProducto = PrecioProducto;
           this.PrecioVentaProducto = PrecioVentaProducto;
       }


       // Metodo Insertar
       public string Insertar(DProductos Productos)
       {
           string respuesta = "";
           SqlConnection SqlConnection = new SqlConnection();
           try
           {
                //Conexion
               SqlConnection.ConnectionString = Conexion.Cn;
               SqlConnection.Open();
               //Comandos
               SqlCommand SqlCommand = new SqlCommand();
               SqlCommand.Connection = SqlConnection;
               SqlCommand.CommandText = "";



           }
           catch (Exception ex)
           {
               respuesta = ex.Message;
           }
           finally
           {
               if (SqlConnection.State == ConnectionState.Open) SqlConnection.Close();
           }
           return respuesta;
       }

       // Metodo Editar
       public string Editar(DProductos Productos)
       {

       }

       // Metodo Eliminar
       public string Eliminar(DProductos Productos)
       {

       }

       // Metodo Mostras
       public DataTable Mostrar()
       {

       }

       //MetodoBuscar
       public DataTable BuscarIdProductos (DProductos IdProducto)
       {

       }


    }
}
