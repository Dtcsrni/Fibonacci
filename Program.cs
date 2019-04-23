using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           long[] numeros = new long[2] { 0, 1 };

            long resultado = 0;
            Console.WriteLine("Hola");
            int i=0;
            while (i<200)
            {

                resultado = (numeros[0] + numeros[1]);
                Console.WriteLine(resultado + "     " + numeros[0] + " " + numeros[1]+" numero "+i);
                numeros[0] = numeros[1];
                numeros[1] = resultado;
              i++;
            }
            Console.ReadKey();


        }
    }
}
