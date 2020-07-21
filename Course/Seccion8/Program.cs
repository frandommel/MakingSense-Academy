using System;
using System.Collections.Generic;

namespace Seccion8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1 */
            //ejercicio1();

            /* EJERCICIO 2 */
            //ejercicio2();

            /* EJERCICIO 3 */
            //ejercicio3();

            /* EJERCICIO 4 */
            //ejercicio4();

            /* EJERCICIO 5 */
            //ejercicio5();
        }
        public static void ejercicio1()
        {
            Console.WriteLine("Ingrese numeros (1-2-3)");
            var stringNumero = Console.ReadLine();

            var numeros = new List<int>();

            foreach (var numero in stringNumero.Split('-'))
            {
                numeros.Add(Convert.ToInt32(numero));
            }
               

            numeros.Sort();

            var consecutivo = true;

            for (var i = 0; i < numeros.Count; i++)
            {
                   //// if (numeros[i] + 1 != numeros[i + 1])
                   // {
                   //     consecutivo = false;
                   //     break;
                   // }
              
            }

            var mensaje = consecutivo ? "numero consectuvio" : "numero No consecutivo";
            Console.WriteLine(mensaje);
        }

         public static void ejercicio2()
        {
            Console.Write("Ingrese numeros (1-2-3) ");
            var stringNumeros = Console.ReadLine();

            var numeros = new List<int>();
            foreach (var numero in stringNumeros.Split('-'))
            {
                numeros.Add(Convert.ToInt32(numero));

            }
            var lista = new List<int>();
            var duplicados = false;

            foreach (var numero in numeros)
            {
                if (!lista.Contains(numero))
                {
                    lista.Add(numero);

                }       
                else
                {
                    duplicados = true;
                    break;
                }
            }

            if (duplicados)
            {
                Console.WriteLine("Duplicado");
            }
               
        }
        public static void ejercicio3()
        {
            Console.Write("Ingrese Tiempo: ");
            var stringTiempo = Console.ReadLine();

            var componente = stringTiempo.Split(':');
            if (componente.Length != 2)
            {
                Console.WriteLine("Tiempo invalido");
                return;
            }

                var hora = Convert.ToInt32(componente[0]);
                var minuto = Convert.ToInt32(componente[1]);

                if (hora >= 0 && hora <= 23 && minuto >= 0 && minuto <= 59)
                {
                    Console.WriteLine("Tiempo valido");
                }
                else
                {
                    Console.WriteLine("Tiempo invalido");
                }
        }

        public static void ejercicio4()
        {
            Console.Write("Ingre palabras");
            var palabras = Console.ReadLine();

            var nombre = "";
            foreach (var palabra in palabras.Split(' '))
            {
                var pascalCase = char.ToUpper(palabra[0]) + palabra.ToLower().Substring(1);
                nombre += pascalCase;
            }

            Console.WriteLine(nombre);
        }

        //EJERCICIO RESULETO POR MOSH
        public static void Exercise5()
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
