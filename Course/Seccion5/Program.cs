using System;

namespace Seccion5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1 */
            //Console.WriteLine("(Ejercicio 1 ) Ingrese un numero.");
            //int numero = Int32.Parse(Console.ReadLine());
            //ejercicio1(numero);

            /* EJERCICIO 2 */
            //Console.WriteLine("(Ejercicio 2 ) Ingrese dos numeros.");
            //int num1 = Int32.Parse(Console.ReadLine());
            //int num2 = Int32.Parse(Console.ReadLine());
            //ejercicio2(num1, num2);

            /* EJERCICIO 3 */
            //Console.WriteLine("(Ejercicio 3 ) Ingrese ancho y largo");
            //int width = Int32.Parse(Console.ReadLine());
            //int height = Int32.Parse(Console.ReadLine());
            //ejercicio3(width, height);

            /* EJERCICIO 4 */
            //Console.WriteLine("(Ejercicio 3 ) Ingrese Speed Limit y Speed car");
            //int speedLimit = Int32.Parse(Console.ReadLine());
            //int speedCar = Int32.Parse(Console.ReadLine());
            //ejercicio4(speedLimit, speedCar);


            // * -- SEGUNDA PARTE EJERCITACIONES -- *//

            /* EJERCICIO 5 */
            //Console.WriteLine(string.Format("HAY {0} numeros divisores por 3", ejercicio5()));

            /* EJERCICIO 6 */
            // ejercicio6();

            /* EJERCICIO 7 */
            // ejercicio7();

            /* EJERCICIO 8 */
            //ejercicio8();

            /* EJERCICIO 9 */



        }
        public static void ejercicio1(int numero)
        {
            if(numero>=1 && numero <= 10)
                Console.WriteLine("valido");
            else
                Console.WriteLine("invalido");
        }
        public static void ejercicio2(int num1, int num2)
        {
            if(num1 > num2)
                Console.WriteLine("mayor numero: " + num1);
            else if(num2 > num1)
                Console.WriteLine("mayor numero: " + num2);
            else
                Console.WriteLine( "son iguales");
        }
        public static void ejercicio3(int width, int height)
        {
            if (width > height)
                Console.WriteLine("es un paisaje");
            else
                Console.WriteLine("Es un retrato");
        }
        public static void ejercicio4(int speedLimit, int speedCar)
        {
            int demeritPoin = 0, diferencia;
            if (speedCar < speedLimit)
            {
                Console.WriteLine("OK");
            } else
            {
                diferencia = speedCar - speedLimit;
                demeritPoin = (diferencia / 5);
            }
            if(demeritPoin >= 12)
            {
                Console.WriteLine("Licencia suspendida");
            }
        }
        public static int ejercicio5()
        {
            int cant = 0;
            for(int i=0; i<100; i++)
            {
                if( i % 3 == 0)
                {
                    cant++;
                }
            }
            return cant;
        }
        public static void ejercicio6()
        {
            string palabra = "";
            int numero = 0;
            do
            {
                Console.WriteLine("Ingrese numero");
                numero += Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese ok para salir o cualquier cosa para seguir");
                palabra = Console.ReadLine();
            } while (!palabra.Equals("ok"));
            Console.WriteLine("suma de todos los numeros ingresados = "+ numero);
        }
        public static void ejercicio7()
        {
            Console.WriteLine("Ingrese numero");
            int numero = Int32.Parse(Console.ReadLine());
            int factorial = 1;
            for(int i=numero; i>0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(string.Format("factorial de {0} es {1}", numero, factorial));

        }
        public static void ejercicio8()
        {
            Random numero = new Random();
            int i = 0, ingresoUser=0;
            int random = numero.Next(1, 10);
            Console.WriteLine("numero random es:"+random);
            while(i<4 &&  ingresoUser != random)
            {
                Console.WriteLine("ingresse numero para advinar");
                ingresoUser = Int32.Parse(Console.ReadLine());
                i++;
            }
            if(ingresoUser == random)
                Console.WriteLine("encontraste el numero");
            else
                Console.WriteLine("perdiste");
        }


    }
}
