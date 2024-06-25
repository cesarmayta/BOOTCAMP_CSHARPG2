﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.MODELS
{
    internal class Profesor : Persona
    {
        private string especialidad;

        public Profesor(int id,string nombre,string email,string especialidad) : base(id, nombre, email)
        {
            this.especialidad = especialidad;
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"ESPECIALIDAD : {this.especialidad}");
        }

        public override string ToString()
        {
            return $"NOMBRE : {Nombre},EMAIL : {Email},ESPECIALIDAD {this.especialidad}";
        }
    }
}
