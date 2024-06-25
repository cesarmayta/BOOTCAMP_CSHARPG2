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

        Moto miMoto = new Moto();
        miMoto.Arrancar();
        miMoto.Acelerar(60);
        miMoto.Frenar(30);
        miMoto.Detener();

        List<IVehiculo> vehiculos = new List<IVehiculo>()
        {
            new Coche(),
            new Moto(),
            new Coche(),
            new Moto()
        };

        foreach(IVehiculo vehiculo in vehiculos)
        {
            vehiculo.Arrancar();
        }

        Administrador admin1 = new Administrador();
        admin1.Login("admin", "1234");

        UsuarioRegular usuario1 = new UsuarioRegular("cesar","cesar");
        usuario1.Login("cesar", "1234");


    }
}

