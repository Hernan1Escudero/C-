﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Cita
        
    {  // La clase esta basada en un sistema de citas para un centro de estetica
        public DateTime FechaHora;
        public string Lugar;
        public string Cliente;
        public float Precio;// no me decido si crear una clase de precios aparte
        public string Servicio;// Si buscamos un servicio generalmente es para una zna en especifico, pero hay algunos que tienen varias zonas a elegir por lo que un argumento zonas  sirve para definir cuales
        public string Zona;

        public Cita( ) {

        
        }

        public Cita (DateTime fechaHora, string lugar, string cliente, float precio, string servicio, string zona)
        {
            this.FechaHora = fechaHora;
            this.Lugar = lugar;
            this.Cliente = cliente;

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
