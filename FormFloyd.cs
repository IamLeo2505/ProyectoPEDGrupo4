using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class FormFloyd : Form
    {
        private List<Nodo> nodos = new List<Nodo>();
        private List<Conexion> conexiones = new List<Conexion>();
        private int contadorId = 1;

        public FormFloyd()
        {
            InitializeComponent();
        }

        // Clase para representar un Nodo
        private class Nodo
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public Point Ubicacion { get; set; }
        }

        // Clase para representar una Conexión
        private class Conexion
        {
            public int NodoOrigen { get; set; }
            public int NodoDestino { get; set; }
            public int Distancia { get; set; }
        }

        // Método para agregar un Nodo al grafo
        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtProducto.Text.Trim();

            if (string.IsNullOrEmpty(nombreProducto))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el nodo.");
                return;
            }

            Random random = new Random();
            Nodo nuevoNodo = new Nodo
            {
                Id = contadorId,
                Nombre = nombreProducto,
                Ubicacion = new Point(random.Next(50, panelGrafo.Width - 50), random.Next(50, panelGrafo.Height - 50))
            };

            nodos.Add(nuevoNodo);
            contadorId++;

            txtIdNodo.Text = contadorId.ToString();
            txtProducto.Clear();
            panelGrafo.Invalidate();
        }

        // Método para agregar una conexión entre nodos
        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodoOrigen.Text, out int nodoOrigenId) &&
                int.TryParse(txtNodoDestino.Text, out int nodoDestinoId) &&
                int.TryParse(txtDistancia.Text, out int distancia))
            {
                Nodo origen = nodos.FirstOrDefault(n => n.Id == nodoOrigenId);
                Nodo destino = nodos.FirstOrDefault(n => n.Id == nodoDestinoId);

                if (origen == null || destino == null)
                {
                    MessageBox.Show("Asegúrese de que los nodos especificados existan.");
                    return;
                }

                Conexion nuevaConexion = new Conexion
                {
                    NodoOrigen = nodoOrigenId,
                    NodoDestino = nodoDestinoId,
                    Distancia = distancia
                };

                conexiones.Add(nuevaConexion);
                panelGrafo.Invalidate();
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para la conexión.");
            }

            txtNodoOrigen.Clear();
            txtNodoDestino.Clear();
            txtDistancia.Clear();
        }

        // Método para eliminar una conexión
        private void btnEliminarConexion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNodoOrigen.Text, out int nodoOrigenId) &&
                int.TryParse(txtNodoDestino.Text, out int nodoDestinoId))
            {
                Conexion conexion = conexiones.FirstOrDefault(c =>
                    (c.NodoOrigen == nodoOrigenId && c.NodoDestino == nodoDestinoId) ||
                    (c.NodoOrigen == nodoDestinoId && c.NodoDestino == nodoOrigenId));

                if (conexion != null)
                {
                    conexiones.Remove(conexion);
                    MessageBox.Show("Conexión eliminada correctamente.");
                    panelGrafo.Invalidate();
                }
                else
                {
                    MessageBox.Show("No se encontró una conexión entre los nodos especificados.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para los nodos.");
            }

            txtNodoOrigen.Clear();
            txtNodoDestino.Clear();
        }

        // Método para calcular la matriz de distancias utilizando el algoritmo de Floyd-Warshall
        private void btnCalcularDistancias_Click(object sender, EventArgs e)
        {
            int cantidadNodos = nodos.Count;

            if (cantidadNodos == 0)
            {
                MessageBox.Show("No hay nodos en el grafo.");
                return;
            }

            int[,] matrizDistancias = new int[cantidadNodos, cantidadNodos];
            const int INF = int.MaxValue / 2;

            for (int i = 0; i < cantidadNodos; i++)
            {
                for (int j = 0; j < cantidadNodos; j++)
                {
                    matrizDistancias[i, j] = (i == j) ? 0 : INF;
                }
            }

            foreach (var conexion in conexiones)
            {
                int origenIndex = nodos.FindIndex(n => n.Id == conexion.NodoOrigen);
                int destinoIndex = nodos.FindIndex(n => n.Id == conexion.NodoDestino);

                matrizDistancias[origenIndex, destinoIndex] = conexion.Distancia;
                matrizDistancias[destinoIndex, origenIndex] = conexion.Distancia;
            }

            for (int k = 0; k < cantidadNodos; k++)
            {
                for (int i = 0; i < cantidadNodos; i++)
                {
                    for (int j = 0; j < cantidadNodos; j++)
                    {
                        if (matrizDistancias[i, k] + matrizDistancias[k, j] < matrizDistancias[i, j])
                        {
                            matrizDistancias[i, j] = matrizDistancias[i, k] + matrizDistancias[k, j];
                        }
                    }
                }
            }

            string resultado = "Matriz de Distancias:\n";
            for (int i = 0; i < cantidadNodos; i++)
            {
                for (int j = 0; j < cantidadNodos; j++)
                {
                    resultado += (matrizDistancias[i, j] == INF ? "∞" : matrizDistancias[i, j].ToString()) + "\t";
                }
                resultado += "\n";
            }

            MessageBox.Show(resultado, "Resultados");
        }

        // Método para pintar el grafo en el panel
        private void panelGrafo_Paint(object sender, PaintEventArgs e)
        {
            var graficos = e.Graphics;

            foreach (var conexion in conexiones)
            {
                Nodo origen = nodos.FirstOrDefault(n => n.Id == conexion.NodoOrigen);
                Nodo destino = nodos.FirstOrDefault(n => n.Id == conexion.NodoDestino);

                if (origen != null && destino != null)
                {
                    graficos.DrawLine(Pens.Black, origen.Ubicacion, destino.Ubicacion);
                    Point puntoMedio = new Point(
                        (origen.Ubicacion.X + destino.Ubicacion.X) / 2,
                        (origen.Ubicacion.Y + destino.Ubicacion.Y) / 2
                    );
                    graficos.DrawString(conexion.Distancia.ToString(), DefaultFont, Brushes.Red, puntoMedio);
                }
            }

            foreach (var nodo in nodos)
            {
                graficos.FillEllipse(Brushes.LightGreen, nodo.Ubicacion.X - 15, nodo.Ubicacion.Y - 15, 30, 30);
                graficos.DrawEllipse(Pens.Black, nodo.Ubicacion.X - 15, nodo.Ubicacion.Y - 15, 30, 30);
                graficos.DrawString(nodo.Id.ToString(), DefaultFont, Brushes.Black, nodo.Ubicacion.X - 5, nodo.Ubicacion.Y - 5);
                graficos.DrawString(nodo.Nombre, DefaultFont, Brushes.Black, nodo.Ubicacion.X - 20, nodo.Ubicacion.Y + 20);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
