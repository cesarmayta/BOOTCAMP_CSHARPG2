﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAlumnosPOO
{
    internal class Alumno
    {
        private string nombre;
        private string email;
        private string celular;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Celular { get => celular; set => celular = value; }

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
