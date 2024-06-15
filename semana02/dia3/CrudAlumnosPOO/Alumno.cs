﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAlumnosPOO
{
    internal class Alumno
    {
        //atributos de clase
        private string nombre;
        private string email;
        private string celular;

        //constructor de clase
        public Alumno(string nom,string ema,string cel)
        {
            this.nombre = nom;
            this.email = ema;
            this.celular = cel;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre : {this.nombre}");
            Console.WriteLine($"Email : {this.email}");
            Console.WriteLine($"Celular : {this.celular}");
        }
    }
}
