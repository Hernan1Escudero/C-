using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Data.SqlClient;
using System.Data;


namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

  
            string conection = "Data Source=DESKTOP-9SVG7S5;Initial Catalog=segundre;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            List<Producto> productos = Manejador.obtenerProductos(1);
            List<ProductoVendido> prodVendidos = Manejador.obtenerProductosVendidos(1);
            List<Venta> ventas = Manejador.obtenerVentas(1);
            Usuario userWithInt= Manejador.obtenerUsuario(1);
            string Name = userWithInt.NombreUsuario;
            string Pass = userWithInt.Contraseña;
            Usuario userWithNamePass = Manejador.obtenerInicioDeSesion(Name,Pass);
            
            /*using (SqlConnection connection = new SqlConnection(conection))
            {

                SqlCommand comando = new SqlCommand("select Id,Descripciones from [dbo].[Producto] ", connection);

                SqlCommand User = new SqlCommand($"select * from [dbo].[usuario]\r\nwhere id ='{userInt}'", connection);

                SqlCommand ProductWithUserID = new SqlCommand($"select * from [dbo].[Producto]\r\nwhere id ='{userID}'", connection);

                SqlCommand SoldProductsWithUserID = new SqlCommand($"select * from [dbo].[ProductoVendido]\r\nwhere idVenta='{userID}'", connection);

                SqlCommand SellsWithUserID = new SqlCommand($"select * from [dbo].[Venta]\r\nwhere idUsuario ='{userID}'", connection);

                SqlCommand Login = new SqlCommand($"select * from [dbo].[usuario]\r\nwhere contraseña = '{userPass}' and Mail ='{userEmail}'", connection);// con usuario y contraseña
               
                connection.Open();
                using (
                SqlDataReader getUser = User.ExecuteReader();
                SqlDataReader getProductWithUserID = ProductWithUserID.ExecuteReader();
                SqlDataReader getSoldProductsWithUserID = SoldProductsWithUserID.ExecuteReader();
                SqlDataReader getSellsWithUserID = SellsWithUserID.ExecuteReader();
                SqlDataReader getLogin = Login.ExecuteReader();
                )
                {
                    if (getProductWithUserID.HasRows)
                    {
                        while (reader.Read())
                        {
                            //mascotas.Add(new Mascota(reader.GetString(1), reader.GetInt64(0)));
                            //Console.WriteLine(reader.GetSqlInt64(0) + reader.GetString(1));

                        }

                    }
                }
                foreach (var mascota in mascotas)
                {
                    Console.WriteLine(mascota);

                }
                Console.WriteLine(connection.Database);
                connection.Close();
            }
            */
            var cocco = "";
        }



    }
}