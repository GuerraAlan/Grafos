using System.Collections.Generic;

namespace Core.Models
{
    public class Grafo<T>
    {
        
        public Grafo()
        {
            Vertices = new List<Vertice<T>>();
        }

        public List<Vertice<T>> Vertices { get; set; }
    }
}