﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Usuario{
        public int Id;
        public string Nombre;
        public string Apellido;
        public string NombreUsuario;
        private string Contraseña;
        public string Mail;
    }
    public class Producto{

        public string Id;
        public string Descripcion;
        public double PrecioVenta;
        public int IdUsuario;
        public int Stock;
     

    }
     public class ProductoVendido{
        public string Id; // como solo hay un id de producto lo dejo string por si es un nombre o un codigo de producto, si solo fuera un int no seria facil de identificar
        public int IdVenta;
        public int IdProducto;
        public int Stock;


    }
     public class Venta{
        public int Id;
        public int IdVenta;
        public int IdProducto;
        public int Stock;


    }

}
