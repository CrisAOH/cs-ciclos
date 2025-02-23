using System;

namespace EjercicioDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado = 0M;
            byte opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.Write("Escoge una opción: ");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while (opcion < 1 || opcion > 4);

            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num2 - num1;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("El divisor no es válido.");
                    }
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
