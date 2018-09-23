/*
 * Arco.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Define una clase de Arcos de grafo
 */

namespace GrafosDirigidos.Tipos
{
    public class Arco
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public Nodo Origen { get; }
        public Nodo Destino { get; }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Constructores
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public Arco(Nodo origen, Nodo destino)
        {
            Origen = origen;
            Destino = destino;
        }
    }
}
