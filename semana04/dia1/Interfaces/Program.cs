using Interfaces;
using System;

public class Program
{
    public static void Main()
    {
        Coche miCoche = new Coche();

        miCoche.Arrancar();
        miCoche.Acelerar(50);
        miCoche.Frenar(20);
        miCoche.Detener();
    }
}

