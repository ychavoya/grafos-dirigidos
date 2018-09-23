/*
 * Grafos.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Realiza todas las operaciones relacionadas con buscar caminos en los grafos
 */

using System;
using System.Collections.Generic;
using GrafosDirigidos.Tipos;

namespace GrafosDirigidos.Procesos
{
    public static class Grafos
    {
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades estáticas
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        static Stack<Nodo> pila;
        static List<Nodo> salida;

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Métodos búsqueda
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        /// <summary>
        /// Prepara la pila para la búsqueda del primer camino.
        /// </summary>
        /// <param name="grafo">El grafo dónde buscar el camino</param>
        /// <param name="origen">El nodo origen</param>
        /// <param name="destino">El nodo destino</param>
        public static void IniciarBúsqueda(Grafo grafo, Nodo origen, Nodo destino)
        {
            if (!grafo.Nodos.Contains(origen)) return;
            if (!grafo.Nodos.Contains(destino)) return;

            pila = new Stack<Nodo>();
            salida = new List<Nodo>();

            pila.Push(origen);
        }

        /// <summary>
        /// Busca un camino en el grafo.
        /// Debe usarse IniciarBúsqueda antes de buscar el primer camino.
        /// </summary>
        /// <param name="grafo">El grafo dónde buscar el camino</param>
        /// <param name="origen">El nodo origen</param>
        /// <param name="destino">El nodo destino</param>
        /// <returns>Una lista con el orden inverso de los nodos del camino,
        /// o null si no hay camino</returns>
        public static List<Nodo> BuscarCamino(Grafo grafo, ref Nodo origen, ref Nodo destino)
        {
            origen.Siguiente = null;
            do
            {
                // 1. Sacar un dato de la pila
                Nodo dato;
                try
                {
                    dato = pila.Pop();
                }
                catch(InvalidOperationException ex)
                {
                    return null;
                }
                
                // 2. Agregarlo a la lista
                salida.Add(dato);

                // 3. Meter a la pila los destinos de ese dato
                foreach (Arco elemento in grafo.Arcos)
                {
                    if(elemento.Origen == dato)
                    {
                        elemento.Destino.Siguiente = elemento.Origen;
                        pila.Push(elemento.Destino);
                    }
                }

                // 4. ¿Es el dato?
                if (dato == destino) return salida;
            } while (pila.Count > 0);

            return null;
        }


       
    }
}
