using System.Collections.Generic;
using System.Linq;
using Core.Models;

namespace Core.Extensions
{
    public static class GraphExtensions
    {
        public static bool Regular<T>(this Grafo<T> grafo)
        {
            var primeiro = grafo.Vertices.First();

            return grafo.Vertices.Count(v => v.Vizinhos.Count == primeiro.Vizinhos.Count) == grafo.Vertices.Count;
        }

        public static bool Completo<T>(this Grafo<T> grafo)
        {
            return grafo.Vertices.All(v => v.Vizinhos.Count == grafo.Vertices.Count - 1);
        }

        public static bool Conexo<T>(this Grafo<T> grafo)
        {
            var primeiro = grafo.Vertices.First();
            var count = 1;
            var fila = new Queue<Vertice<T>>();
            primeiro.Visitado = true;
            fila.Enqueue(primeiro);
            
            do
            {
                var vertice = fila.Dequeue();
                foreach (var vertex in vertice.Vizinhos.Where(v => !v.Visitado))
                {
                    vertex.Visitado = true;
                    fila.Enqueue(vertex);
                    count++;
                }
            } while (fila.Any());

            return grafo.Vertices.Count == count;
        }
    }
}