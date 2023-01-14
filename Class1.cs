using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Producto
        
    {  // La clase esta basada en un sistema de citas para un centro de estetica
        public DateTime FechaHora;
        public string Lugar;
        public string Cliente;
        public float Precio;
        public string Servicio;// Si buscamos un servicio generalmente es para una zna en especifico, pero hay algunos que tienen varias zonas a elegir por lo que un argumento zonas  sirve para definir cuales
        public string Zona;

        public Producto( string lugar) {

            Lugar = lugar;
        
        }
    }
}
