using Core.Models;

namespace Core.Util
{
    public static class Exemplos
    {
        public static Grafo<int> GrafoDesconexo()
        {
            var grafo = new Grafo<int>();
            
            var vertice1 = new Vertice<int> {Valor = 1};
            var vertice2 = new Vertice<int> {Valor = 2};
            var vertice3 = new Vertice<int> {Valor = 3};
            var vertice4 = new Vertice<int> {Valor = 4};
            var vertice5 = new Vertice<int> {Valor = 5};
            var vertice6 = new Vertice<int> {Valor = 6};
            var vertice7 = new Vertice<int> {Valor = 7};
            var vertice8 = new Vertice<int> {Valor = 8};
            var vertice9 = new Vertice<int> {Valor = 9};
            
            vertice1.Vizinhos.AddRange(new[] {vertice2, vertice4, vertice5});
            vertice2.Vizinhos.AddRange(new[] {vertice1, vertice3, vertice5});
            vertice3.Vizinhos.AddRange(new[] {vertice2, vertice9});
            vertice4.Vizinhos.AddRange(new[] {vertice1, vertice5});
            vertice5.Vizinhos.AddRange(new[] {vertice1, vertice2, vertice4});
            vertice6.Vizinhos.AddRange(new[] {vertice7, vertice8});
            vertice7.Vizinhos.AddRange(new[] {vertice6, vertice8});
            vertice8.Vizinhos.AddRange(new[] {vertice6, vertice7});
            
            grafo.Vertices.AddRange(new[] {vertice1, vertice2, vertice3, vertice4, vertice5, vertice6, vertice7, vertice8, vertice9});

            return grafo;
        }

        public static Grafo<int> GrafoRegular()
        {
            var grafo = new Grafo<int>();
            
            var vertice1 = new Vertice<int> {Valor = 1};
            var vertice2 = new Vertice<int> {Valor = 2};
            var vertice3 = new Vertice<int> {Valor = 3};
            var vertice4 = new Vertice<int> {Valor = 4};
            var vertice5 = new Vertice<int> {Valor = 5};
            var vertice6 = new Vertice<int> {Valor = 6};
            
            vertice1.Vizinhos.AddRange(new[] {vertice2, vertice3, vertice6});
            vertice2.Vizinhos.AddRange(new[] {vertice1, vertice3, vertice4});
            vertice3.Vizinhos.AddRange(new[] {vertice1, vertice2, vertice5});
            vertice4.Vizinhos.AddRange(new[] {vertice2, vertice5, vertice6});
            vertice5.Vizinhos.AddRange(new[] {vertice3, vertice4, vertice6});
            vertice6.Vizinhos.AddRange(new[] {vertice1, vertice5, vertice6});
            
            grafo.Vertices.AddRange(new[] {vertice1, vertice2, vertice3, vertice4, vertice5, vertice6});

            return grafo;
        }
        
        public static Grafo<int> GrafoCompleto()
        {
            var grafo = new Grafo<int>();
            
            var vertice1 = new Vertice<int> {Valor = 1};
            var vertice2 = new Vertice<int> {Valor = 2};
            var vertice3 = new Vertice<int> {Valor = 3};
            var vertice4 = new Vertice<int> {Valor = 4};
            var vertice5 = new Vertice<int> {Valor = 5};
            
            vertice1.Vizinhos.AddRange(new[] {vertice2, vertice3, vertice4, vertice5});
            vertice2.Vizinhos.AddRange(new[] {vertice1, vertice3, vertice4, vertice5});
            vertice3.Vizinhos.AddRange(new[] {vertice1, vertice2, vertice4, vertice5});
            vertice4.Vizinhos.AddRange(new[] {vertice1, vertice2, vertice3, vertice5});
            vertice5.Vizinhos.AddRange(new[] {vertice1, vertice2, vertice3, vertice4});
            
            grafo.Vertices.AddRange(new[] {vertice1, vertice2, vertice3, vertice4, vertice5});

            return grafo;
        }
    }
}