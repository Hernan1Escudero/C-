using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cliente {

        public string Nombre;
        public string Apellido;
        public string Edad;
        public string Mail;
        public string TelefonoCelular;

    }
    public class Cita
        
    {  // La clase esta basada en un sistema de citas para un centro de estetica
        public DateTime FechaHora;
        public string Lugar;
        public float Precio;// no me decido si crear una clase de precios aparte
     

        public Cita( ) {

        
        }

        public Cita (DateTime fechaHora, string lugar,float precio)
        {
            this.FechaHora = fechaHora;
            this.Lugar = lugar;
           

        }
    }

    public class Zonas {

        public bool Piernas;
        public bool Brazos;
        public bool Abdomen;
        public bool Espalda;
        public bool Nuca;
        public bool AreaDeBikini;



    }

    public class Servicios {
        public bool Peeling;
        public bool Depilacion;
        public bool Lipo;
        public bool Crio;
        public bool Facial;
        public bool Botox;


    }

   
}
