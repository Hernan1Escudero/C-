using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4;

namespace ConsoleApp4

{   
    
    internal static class Manejador
    {
      
        public static List<Producto> obtenerProductos( Int64 id)
        {
            List<Producto> productos = new List<Producto>();
            string conectionString = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection conection = new SqlConnection(conectionString))
            {

                SqlCommand ProductWithUserID = new SqlCommand($"\r\nselect * from [dbo].[Producto]\r\ninner join Usuario on\r\nProducto.IdUsuario = Usuario.Id\r\nwhere Usuario.Id = '{id}' ", conection);

                conection.Open();
                SqlDataReader reader = ProductWithUserID.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.Id = reader.GetInt64(0);
                        producto.Descripcion = reader.GetString(1);// si quisiera ser mas especifico traeria el nombre del producto cargado pero me parecio mejor traer el producto en si  osea  sus valores 
                        producto.Costo = reader.GetDecimal(2);
                        producto.PrecioVenta = reader.GetDecimal(3);
                        producto.Stock = reader.GetInt32(4);
                        producto.IdUsuario = reader.GetInt64(5);

                        productos.Add(producto);
                    }
                    
                }
                return productos;


            }

        }

        public static List<ProductoVendido> obtenerProductosVendidos(Int64 id)
        {
            List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
            string conectionString = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

         using (SqlConnection conection = new SqlConnection(conectionString))
            {

                SqlCommand ProductWithUserID = new SqlCommand($"select * from [dbo].[ProductoVendido]\r\nwhere idVenta ='{id}' ", conection);

                conection.Open();
                SqlDataReader reader = ProductWithUserID.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductoVendido productoVendido = new ProductoVendido();
                        productoVendido.Id = reader.GetInt64(0);
                        productoVendido.Stock = reader.GetInt32(1);
                        productoVendido.IdProducto = reader.GetInt64(2);
                        productoVendido.IdVenta = reader.GetInt64(3);
                        

                        productosVendidos.Add(productoVendido);
                    }

                }
                return productosVendidos;


            }

        }

        public static List<Venta> obtenerVentas(Int64 id)
        {
            List<Venta> ventas = new List<Venta>();
            string conectionString = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection conection = new SqlConnection(conectionString))
            {

                SqlCommand ProductWithUserID = new SqlCommand($"select * from [dbo].[Venta] where idUsuario = '{id}' ", conection);

                conection.Open();
                SqlDataReader reader = ProductWithUserID.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta();
                        venta.Id = reader.GetInt64(0);
                        venta.Comentario = reader.GetString(1);
                        venta.IdUsuario = reader.GetInt64(2);
                        

                        ventas.Add(venta);
                    }

                }
                return ventas;


            }

        }

        public static Usuario obtenerUsuario(int id)
        {
            // en como recibe un numero asumo que es el ID y como es unico solo debo traer un solo usuario
            Usuario usuario = new Usuario();
            string conectionString = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection conection = new SqlConnection(conectionString))
            {

                SqlCommand ProductWithUserID = new SqlCommand($"select * from [dbo].[Usuario] where id = '{id}' ", conection);

                conection.Open();
                SqlDataReader reader = ProductWithUserID.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        usuario.Id = reader.GetInt64(0);
                        usuario.Nombre = reader.GetString(1);// si quisiera ser mas especifico traeria el nombre del usuario cargado pero me parecio mejor traer el producto en si  osea  sus valores  
                        usuario.Apellido = reader.GetString(2);
                        usuario.NombreUsuario = reader.GetString(3);
                        usuario.Contraseña = reader.GetString(4);
                        usuario.Mail = reader.GetString(5);
                        
                    }

                }
                return usuario;


            }

        }

        public static Usuario obtenerInicioDeSesion( string usuario, string contraseña)
        { // en este caso tambien traigo un solo usuario  ya que es por contraseña y nombre 
            Usuario Login = new Usuario();
            string conectionString = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection conection = new SqlConnection(conectionString))
            {

                SqlCommand ProductWithUserID = new SqlCommand($"select * from [dbo].[Usuario] where NombreUsuario = '{usuario}' and Contraseña='{contraseña}' ", conection);

                conection.Open();
                SqlDataReader reader = ProductWithUserID.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        Login.Id = reader.GetInt64(0);
                        Login.Nombre = reader.GetString(1);// si quisiera ser mas especifico traeria el nombre del usuario cargado pero me parecio mejor traer el producto en si  osea  sus valores  
                        Login.Apellido = reader.GetString(2);
                        Login.NombreUsuario = reader.GetString(3);
                        Login.Contraseña = reader.GetString(4);
                        Login.Mail = reader.GetString(5);

                        
                    }

                }
                return Login;


            }

        }


        /*
       public static Producto obtenerProducto( )
       {
           string conectionString = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


           Producto productos = new Producto();

           using (SqlConnection conection = new SqlConnection(conectionString))
           {

               SqlCommand ProductWithUserID = new SqlCommand("select * from [dbo].[Producto] where idUsuario = '1' ", conection);

               conection.Open();
               SqlDataReader reader = ProductWithUserID.ExecuteReader();

               if (reader.HasRows)
               {
                   reader.Read();


                   productos.Id = reader.GetInt64(0);
                   productos.Descripcion = reader.GetString(1);
                   productos.Costo = reader.GetDecimal(2);
                   productos.PrecioVenta = reader.GetDecimal(3);
                   productos.Stock = reader.GetInt32(4);
                   productos.IdUsuario = reader.GetInt64(5);



               }
               return productos;


           }

       }
       */
    }



}


