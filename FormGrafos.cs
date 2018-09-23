/*
 * FormGrafos.cs
 * Yael Arturo Chavoya Andalón
 * 
 * Programa que busca un camino de un nodo a otro en un grafo dirigido
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrafosDirigidos.Tipos;
using GrafosDirigidos.Procesos;

namespace GrafosDirigidos
{
    public partial class FormGrafos : Form
    {

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Propiedades
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =

        Grafo grafo;
        int autoNombres;

        // Genera un nombre Automático A-Z y AA-ZZ
        string AutoNombre
        {
            get
            {
                if (autoNombres <= 26)
                {
                    return ((char)('A' + autoNombres++)).ToString();
                }
                else
                {
                    string cadena = ((char)(autoNombres / 26 + 'A')).ToString() +
                        ((char)(autoNombres % 26 + 'A')).ToString();
                    autoNombres++;
                    return cadena;
                }
            }
        }


        public FormGrafos()
        {
            InitializeComponent();
            grafo = new Grafo();
        }


        #region Código Controles Forms

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Agregar nodo
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        private void btnNewNodo_Click(object sender, EventArgs e)
        {
            string cadena = txtNewNodo.Text;
            if(cadena.Trim() == "")
            {
                MessageBox.Show("El nodo no puede tener un nombre vacío.");
                return;
            }
            if (grafo.Buscar(cadena) != null)
            {
                MessageBox.Show("Ya existe un nodo con ese nombre.");
                return;
            }
            grafo.AgregarNodo(new Nodo(cadena));
            ActualizarListasNodos();
        }

        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            string cadena = AutoNombre;

            while(grafo.Buscar(cadena) != null)
            {
                cadena = AutoNombre;
            }
            grafo.AgregarNodo(new Nodo(cadena));
            ActualizarListasNodos();
        }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Listas Nodos
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        private void listVNodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarConectados();
        }

        private void listCNodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarConectables();
        }

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Conectar
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (listCNodos.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado un nodo padre.");
                return;
            }
            if (listConectados.SelectedItems == null)
            {
                MessageBox.Show("No se ha seleccionado al menos un nodo hijo.");
                return;
            }

            Nodo padre = null;
            foreach (Nodo elemento in grafo.Nodos)
            {
                if (listCNodos.SelectedItem == elemento) padre = elemento;
            }
            foreach (object iter in listConectados.SelectedItems)
            {
                Nodo hijo = null;
                foreach (Nodo elemento in grafo.Nodos)
                {
                    if (iter == elemento) hijo = elemento;
                }

                grafo.ConectarNodos(padre, hijo);
            }

            ActualizarConectables();
            ActualizarConectados();
        }

#endregion

        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =  
        // Actualizar
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        void ActualizarListasNodos()
        {
            listNodos.Items.Clear();
            listVNodos.Items.Clear();
            listCNodos.Items.Clear();
            listOrigen.Items.Clear();
            listDestino.Items.Clear();

            foreach (Nodo elemento in grafo.Nodos)
            {
                listNodos.Items.Add(elemento);
                listVNodos.Items.Add(elemento);
                listCNodos.Items.Add(elemento);
                listOrigen.Items.Add(elemento);
                listDestino.Items.Add(elemento);
            }
        }

        void ActualizarConectables()
        {
            listConectados.Items.Clear();
            Nodo actual = (Nodo)listCNodos.SelectedItem;
            foreach (Nodo elemento in grafo.Nodos)
            {
                if (listCNodos.SelectedItem != elemento &&
                    !grafo.IsConectado(actual, elemento))
                    listConectados.Items.Add(elemento);
            }
        }

        void ActualizarConectados()
        {
            listVConectados.Items.Clear();
            Nodo actual = (Nodo)listVNodos.SelectedItem;
            foreach (Nodo elemento in grafo.Nodos)
            {

                if (grafo.IsConectado(actual, elemento))
                    listVConectados.Items.Add(elemento);
            }
        }


        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        // Buscar camino
        // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =
        private void btnSearchPath_Click(object sender, EventArgs e)
        {
            
            // Revisar si hay origen y destino
            if(listOrigen.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado un origen.");
                return;
            }
            if (listOrigen.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado un destino.");
                return;
            }

            // Buscar origen y destino en el grafo
            Nodo origen = null;
            foreach (Nodo elemento in grafo.Nodos)
            {
                if (listOrigen.SelectedItem == elemento) origen = elemento;
            }

            Nodo destino = null;
            foreach (Nodo elemento in grafo.Nodos)
            {
                if (listDestino.SelectedItem == elemento) destino = elemento;
            }

            // Ver que no se esté viajando al mismo nodo
            if(origen == destino)
            {
                MessageBox.Show("Ya estás en " + origen + ".");
                return;
            }

            //Buscar el camino
            List<Nodo> resultado;
            DialogResult input;

            Grafos.IniciarBúsqueda(grafo, origen, destino);

            do
            {
                resultado = Grafos.BuscarCamino(grafo, ref origen, ref destino);
                // Si no hay camino
                if (resultado == null)
                {
                    MessageBox.Show("No se pudo encontrar un camino");
                    return;
                }

                //Invertir el orden de la lista e imprimir el camino
                Nodo explorador = resultado.Last();
                Nodo inicial = explorador;

                Stack<Nodo> invertir = new Stack<Nodo>();


                invertir.Push(explorador);

                while (explorador.Siguiente != null)
                {
                    explorador = explorador.Siguiente;
                    if (explorador == inicial) break;
                    invertir.Push(explorador);
                }

                string cadena = "";

                while (invertir.Count > 1)
                {
                    cadena += invertir.Pop().ToString();
                    cadena += " -> ";
                }
                cadena += invertir.Pop().ToString();
                cadena += "\n¿Buscar otro?";
                input = MessageBox.Show(cadena, "Camino encontrado", MessageBoxButtons.YesNo);
            } while (input == DialogResult.Yes);
        }// función

    }//class
}
