using System;
using System.IO;
using System.Security.Cryptography;

namespace Seccion9
{
    class Program
    {
        static void Main(string[] args)
        {
            //File metodos staticos donde combiene utilizar cuando manejamos pocos datos
            //FileInfo combiene utilziar con mas datos


            var files = Directory.GetFiles("path","*.*",SearchOption.AllDirectories);
               foreach(var file in files)
            {
                Console.WriteLine(file);
            }
            //mamipular la traida del nombre de un path
            Path.GetExtension("path");  

            Path.GetFileNameWithoutExtension("path");

            Path.GetDirectoryName("path");
           
        }
    }
}
