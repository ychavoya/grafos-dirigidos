/*
 * Nodo.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Define una clase de Nodos de grafo
 */

namespace GrafosDirigidos.Tipos
{
    public class Nodo {
        
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public string Dato { set; get; }
        public Nodo Siguiente { set; get; }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Constructores
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public Nodo(string dato, Nodo ptr = null)
        {
            Dato = dato;
            Siguiente = ptr;
        }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Conversión de tipos
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public override string ToString()
        {
            return Dato;
        }
    }
}
