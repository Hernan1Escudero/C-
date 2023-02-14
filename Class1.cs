using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace ConsoleApp4
{

    internal class Usuario{
        private Int64 id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Mail { get => mail; set => mail = value; }

        public Usuario(long id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Mail = mail;
        }
        public Usuario()
        {
            
        }
    }

    internal class Producto{

        private Int64 id;
        private Decimal costo;
        private string descripcion;
        private Decimal precioVenta;
        private int stock;
        private Int64 idUsuario;

        public Producto(long id, decimal costo, string descripcion, decimal precioVenta, int stock, long idUsuario)
        {
            this.id = id;
            this.costo = costo;
            this.descripcion = descripcion;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
        public Producto()
        {
           
        }

        public long Id { get => id; set => id = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }


    }


     internal class ProductoVendido{
        private Int64 id;
        private int stock;
        private Int64 idProducto;
        private Int64 idVenta;

        public long Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public long IdVenta { get => idVenta; set => idVenta = value; }

        public ProductoVendido(long id, int stock, long idProducto, long idVenta)
        {
            Id = id;
            Stock = stock;
            IdProducto = idProducto;
            IdVenta = idVenta;
        }
        public ProductoVendido()
        {
         
        }
    }
    internal class Venta{
        private Int64 id;
        private string comentario;
        private Int64 idUsuario;

        public long Id { get => id; set => id = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }

        public Venta(long id, string comentario, long idUsuario)
        {
            Id = id;
            Comentario = comentario;
            IdUsuario = idUsuario;
        }
        public Venta()
        {
            
        }
    }

    

    class Mascota {

       private string Nombre;
       private Int64 edad;

        public Mascota(string nombre, long edad)
        {
            Nombre = nombre;
            this.edad = edad;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public long Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"Nombre:{Nombre}\t edad:{edad}";
        }
    }

   


}
