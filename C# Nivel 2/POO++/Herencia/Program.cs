using System;
using System.Collections.Generic;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona 👉🏼 Líder -- Developer
            
            List<Persona> personas = new List<Persona>();

            Console.WriteLine($"Cantidad de personas en la lista: {personas.Count}");

            personas.Add(new Lider("Lio", "Messi", 123));

            personas.Add(new Developer("Julián", "Álvarez", 321));

            personas.Add(new Developer("Emiliano", "Martínez", 456));

            //personas.RemoveAt(1);

            Console.WriteLine($"Cantidad de personas en la lista: {personas.Count}");

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.ToString());
            }

        }
    }
}
