using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Estudiante : Persona
    {
        public string Carrera { get; set; }

        public Estudiante(string FirstName, string LastName, int Age, int year, string Carrera) : base(FirstName,LastName,Age,year)
        {
            this.Carrera = Carrera;
        }
        public Estudiante() : base()
        {
            this.Carrera = "";
        }



        public override string ToString()
        {
            return base.ToString() + " Carrera " + Carrera;
        }

    }
}
