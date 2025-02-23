using System;

namespace Tarea4_1_Exponentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular potencias positivas o negativas
            int numero, exponente;
            double resultado = 1, resultadoNegativo;

            Console.Write("Dame la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            if (exponente < 0)
            {
                exponente *= -1;

                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }

                resultadoNegativo = 1 / resultado;

                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
            } else
            {
                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }

                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
            }
        }
    }
}
