using Poo_Escturura.Entities;
using Poo_Escturura.Services;
using System;

namespace Poo_Escturura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AlumnoServices servicio = new AlumnoServices();

            Alumno alumno1 = servicio.Agregar();

            servicio.Imprmr(alumno1);

            Console.WriteLine("La calificacion es"+servicio.ValidarProm(alumno1.Promedio));

        }
    }
}
