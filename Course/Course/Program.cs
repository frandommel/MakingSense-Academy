using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int? numero = 0;   //con el signo de interrogacion permito  que el entero sea null
            Console.WriteLine(numero);

            var claseAnonima = new { name = "francisco", surName = "Dommel", age = "23", year = "1996" };

            Console.WriteLine(claseAnonima.name);
            Console.WriteLine(claseAnonima.surName);
            Console.WriteLine(claseAnonima.age);

            string s = "1";
            int numero1 = Convert.ToInt32(s);   // es como un parseo
            Console.WriteLine(numero1);

        }
    }
}
