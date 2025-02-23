using System;

namespace CicloFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Console.Write("Ingresa el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for(int i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificación: ");
                calificacion = Convert.ToByte(Console.ReadLine());

                sumaCalif += calificacion;
            }

            promedio = sumaCalif / numAlumnos;
            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
