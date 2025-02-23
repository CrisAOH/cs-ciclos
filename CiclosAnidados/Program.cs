using System;

namespace CiclosAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla de multiplicar del {0}", i);

                for (int j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine("{0} = {1} * {2}", i, j, resultado);
                }
            }
        }
    }
}
