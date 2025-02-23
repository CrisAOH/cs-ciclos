using System;

namespace Tarea4_2_NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDivisores = 0;
            //LOS NUMEROS PRIMOS SON AQUELLOS MAYORES A UNO QUE SÓLO SE PUEDEN DIVIDIR ENTRE 1 Y ELLOS MISMOS.
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numDivisores += 1;
                    }
                }

                if(numDivisores <= 2)
                {
                    Console.WriteLine(i);
                }

                numDivisores = 0;
            }
        }
    }
}
