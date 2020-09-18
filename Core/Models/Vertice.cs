using System.Collections.Generic;

namespace Core.Models
{
    public class Vertice<T>
    {
        public Vertice()
        {
            Vizinhos = new List<Vertice<T>>();
        }
        
        public List<Vertice<T>> Vizinhos { get; set; }
        public T Valor { get; set; }
        public bool Visitado { get; set; }
    }
}