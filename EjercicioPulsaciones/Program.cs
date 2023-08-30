using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPulsaciones
{
     class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            string sexo;
            string identificacion;
            Console.WriteLine("Ingrese su identificacion:");
            identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su sexo: ");
            sexo= Console.ReadLine();
            Console.WriteLine("Ingrese su nombre: ");
            nombre= Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Persona persona = new Persona(identificacion,nombre,edad,sexo);
            PersonaService personaService = new PersonaService();
            persona.Pulsacion = personaService.CalcularPulsacion(sexo, edad);
            Console.WriteLine($"Su pulsacion es {persona.Pulsacion}");
            Console.ReadKey();
        }
    }
}
