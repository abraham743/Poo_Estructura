using Poo_Escturura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Escturura.Services
{
    public class AlumnoServices
    {
        //el tipo de dato que esta a lado del "Publico" se llama"Respons" y en este caso los parametros se le llama "reques"
        public Alumno Agregar()
        {
            try
            {
                Alumno res = new Alumno()
                {
                    id = 1,
                    Nombre = "Abraham",
                    Apellido = "Guzman",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 7.5
                };
                return res;

            }
            catch (Exception ex) 
            {
                throw new Exception("Hay un error"+ex.Message);















































            }


            
        }
        
        public void Imprmr(Alumno request)
        {
            try
            {
                Console.WriteLine("El nombre es: " + request.Nombre);
                Console.WriteLine("El nombre es: " + request.Apellido);
                Console.WriteLine("El nombre es: " + request.FechaIngreso);
                Console.WriteLine("El nombre es: " + request.Grado);
            }
            catch (Exception ex)
            {

                throw new Exception("Succedio un error" + ex.Message);
            }
        }

        public bool ValidarProm(double num1)
        {
            bool validar=false;
            if (num1>7)
            {
                validar=true;
            }
            return validar;
        }

    }
}
