using System;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    public enum values
    {
        value1= 1,
        value2= 2,
        value3= 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int? numero = 0;   //con el signo de interrogacion permito  que el entero sea null
            //Console.WriteLine(numero);
            //string s = "1";
            //int numero1 = Convert.ToInt32(s);   // es como un parseo
            //Console.WriteLine(numero1);
            Persona persona1 = new Estudiante("Gonzalo", "diaz", 22, 1997, "arquitectura");
            var claseAnonima = new { FistName = "francisco", LastName = "Dommel", age = 23, year = 1996, carrera = "tup" };
            Persona persona2 = new Estudiante(claseAnonima.FistName, claseAnonima.LastName, claseAnonima.age,claseAnonima.year,claseAnonima.carrera);

            Persona[] ArrayPersona = new Estudiante[2];

            ArrayPersona[0] = persona1;
            ArrayPersona[1] = persona2;

            foreach (Persona persona in ArrayPersona)
            {
                Console.WriteLine(persona.ToString());
            }


            string nombre = "pedro";
            string apellido = "garcia";
            string nombreCompleto = string.Format("MI nombre completo es {0} {1}", nombre, apellido);
            Console.WriteLine(nombreCompleto);

            var method = values.value1;


        

          




        }

    }
}
