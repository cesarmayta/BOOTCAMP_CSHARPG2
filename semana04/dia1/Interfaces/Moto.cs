using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Moto : IVehiculo
    {
        private int velocidad;
        public Moto() { 
            this.velocidad = 0;
        }

        public void Arrancar()
        {
            Console.WriteLine("La moto ha arrancado");
        }

        public void Detener()
        {
            Console.WriteLine("La moto se ha detenido");
            velocidad = 0;
        }

        public void Acelerar(int incremento)
        {
            velocidad += incremento;
            Console.WriteLine($"La moto ha acelerado a {velocidad} km/h");
        }

        public void Frenar(int decremento)
        {
            velocidad -= decremento;
            Console.WriteLine($"La Moto ha frenado a {velocidad} km/h");
        }
    }
}
