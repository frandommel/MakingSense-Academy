using System;
using System.Collections.Generic;
using System.Linq;

namespace Seccion6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1 */
            //List<string> nombres = new List<string>();
            //ejercicio1(nombres);

            /* EJERCICIO 2 */
            //string nombreInvertido = ejercicio2("francisco");
            //Console.WriteLine(nombreInvertido);

            /* EJERCICIO 3 */
            //ejercicio3();

            /* EJERCICIO 4 */
            //ejercicio4();

            /* EJERCICIO 5 */
            //ejercicio5();
        }
        public static void ejercicio1(List <string> friends)
        {
            int cantLike = 0;
            friends = ingreseNombres(friends);
            if(friends.Count == 0)
            {
                Console.WriteLine("Nadie likeo tu post");
            }else if( friends.Count == 1)
            {
                Console.WriteLine(string.Format(" a {0} le gusto tu foto",friends[0].ToString()));
            }else if( friends.Count == 2)
            {
                Console.WriteLine(string.Format(" a {0} y {1} le gusto tu foto", friends[0].ToString(), friends[1].ToString()));
            }
            else
            {
                foreach(var friend in friends)
                {
                    cantLike++;
                }
                Console.WriteLine(string.Format(" a {0} , {1} y {2} le gusto tu foto", friends[0].ToString(), friends[1].ToString(),cantLike-2));
            }

        }
        public static List<string> ingreseNombres(List <string> nombres)
        {
            int salir = 0;
            Console.WriteLine("Quieres  ingresar nombes? 0 para seguir");
            salir = Int32.Parse(Console.ReadLine());
            while (salir == 0)
            {
                Console.WriteLine("Ingrese nombre");
                nombres.Add(Console.ReadLine());
                Console.WriteLine("Quieres seguir ingresando nombes? 0 para seguir");
                salir = Int32.Parse(Console.ReadLine());
            }
            return nombres;
        }
        public static string ejercicio2(string name)
        {
            string[] arrayName = new string[ name.Length ];
            string nombreInvertido = "";
            for(int i=0; i<arrayName.Length; i++)
            {
                arrayName[i] = name[i].ToString();
            }
            Array.Reverse(arrayName);

            for (int i = 0; i < arrayName.Length; i++)
            {
                nombreInvertido += arrayName[i];
            }
            return nombreInvertido;
        }
        public static void ejercicio3()
        {
            int[] numbers = new int[5];
            int i = 1;
            Console.WriteLine("ingrese numero");
            numbers[0] = Int32.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("ingrese otro numero");
                numbers[i] = Int32.Parse(Console.ReadLine());

                while(numbers.Contains(numbers[i]))
                {
                    Console.WriteLine("Numero repetido vuelve a ingresar otro numero");
                    numbers[i] = Int32.Parse(Console.ReadLine());
                }
                i++;
            } while (i < numbers.Length);

                for(int j=0; j<numbers.Length; j++)
                 {
                      Console.WriteLine("arreglo cargado: " + numbers[j]);
                 }
                 Array.Sort(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.WriteLine("arreglo ordenado: " + numbers[j]);
                }
        }
        public static  void ejercicio4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Ingrese un numero o quit para salir");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            var lista = new List<int>();

            foreach (var number in numbers)
            {
                if (!lista.Contains(number))
                    lista.Add(number);
            }

            Console.WriteLine("lista numeros:");
            foreach (var number in lista)
                Console.WriteLine(number);
        }
        public static void ejercicio5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }

}
