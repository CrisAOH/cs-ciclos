using System;

namespace EjercicioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasenia1, contrasenia2 = "";

            Console.Write("Escribe tu contraseña: ");
            contrasenia1 = Console.ReadLine();

            while(contrasenia1 != contrasenia2)
            {
                Console.Write("Confirma tu contraseña: ");
                contrasenia2 = Console.ReadLine();
            }

            Console.WriteLine("La contraseña ha sido guardada.");
        }
    }
}
