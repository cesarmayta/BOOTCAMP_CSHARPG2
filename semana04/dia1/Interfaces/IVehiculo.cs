using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IVehiculo
    {
        void Arrancar();
        void Detener();
        void Acelerar(int incremento);
        void Frenar(int incremento);

    }
}
