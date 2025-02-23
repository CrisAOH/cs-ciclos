using System;

namespace CicloFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong numero, factorial = 1;

            Console.Write("Ingresa el número para calcular su factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            for (ulong i = numero; i >= 1; i--)
            {
                factorial *= i; //factorial = factorial * i
            }

            Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
        }
    }
}
