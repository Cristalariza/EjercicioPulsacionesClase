using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonaRepository
    {
        List<Persona> listaPersonas=new List<Persona>();
        private readonly string FileName = "Persona.txt";
        public void Guardar (Persona persona) 
        { 
            listaPersonas.Add(persona);
        }
        public Persona Buscar (string identificacion) 
        {
            foreach (var persona in listaPersonas)
            {
                if (persona.Identificacion == identificacion)
                {
                    return persona;
                }
            }
            return null;
        }
        public List<Persona> ConsultarTodos()
        {
            return listaPersonas;
        }
        public void Eliminar (string identificacion)
        {
            foreach (var persona in listaPersonas)
            {
                if (persona.Identificacion == identificacion)
                {
                    listaPersonas.Remove(persona);
                }
            }
        }
        public void Modificar (Persona personaOld, Persona personaNew)
        {
            listaPersonas.Remove (personaOld);
            listaPersonas.Add (personaNew);

        }

    }
}
