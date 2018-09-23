/*
 * Grafo.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Define una clase de Grafos dirigidos
 */

using System.Collections.Generic;

namespace GrafosDirigidos.Tipos
{
    public class Grafo
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public List<Nodo> Nodos { set; get; }
        public List<Arco> Arcos { set; get; }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Constructores
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public Grafo()
        {
            Nodos = new List<Nodo>();
            Arcos = new List<Arco>();
        }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Métodos
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public void AgregarNodo(Nodo nuevo)
        {
            Nodos.Add(nuevo);
        }

        public void ConectarNodos(Nodo padre, Nodo hijo)
        {
            Arcos.Add(new Arco(padre, hijo));
        }

        public bool IsConectado(Nodo origen, Nodo destino) {
            foreach(Arco elemento in Arcos)
            {
                if (elemento.Origen == origen && elemento.Destino == destino)
                    return true;
            }
            return false;
        }

        public Nodo Buscar(string cadena)
        {
            foreach (Nodo elemento in Nodos)
            {
                if (elemento.Dato == cadena)       
                    return elemento;
            }
            return null;
        }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Sobrecarga de operadores
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        public Nodo this[int x]
        {
            get
            {
                return Nodos[x];
            }
            set
            {
                Nodos[x] = value;
            }
        }
    }//class
}
