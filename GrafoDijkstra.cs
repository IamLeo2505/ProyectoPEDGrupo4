using ProyectoFinalEstructuraDatosGrupo4.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static ProyectoFinalEstructuraDatosGrupo4.GrafoDijkstra;
using static ProyectoFinalEstructuraDatosGrupo4.GrafoDijkstra.Grafo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class GrafoDijkstra : Form
    {
        private Grafo grafo;
        public GrafoDijkstra()
        {
            InitializeComponent();
            grafo = new Grafo();
            txtcodigo.KeyPress += Numeros_KeyPress;
            txtpreciocompra.KeyPress += Numeros_KeyPress;
            txtprecioventa.KeyPress += Numeros_KeyPress;
            txtdescripcion.KeyPress += Letras_KeyPress;
            txtproducto.KeyPress += Letras_KeyPress;

        }

        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public class Dijkstra
        {
            private Grafo grafo;

            public Dijkstra(Grafo grafo)
            {
                this.grafo = grafo;
            }

            public Dictionary<NodoD, int> FindShortestPath(NodoD Inicio)
            {
                var distancias = new Dictionary<NodoD, int>();
                var nodoanterior = new Dictionary<NodoD, NodoD>();
                var nodos = new List<NodoD>(grafo.Nodos);

                foreach (var nodo in nodos)
                {
                    distancias[nodo] = int.MaxValue;
                    nodoanterior[nodo] = null;
                }
                distancias[Inicio] = 0;

                while (nodos.Count > 0)
                {
                    nodos = nodos.OrderBy(n => distancias[n]).ToList();
                    var nodoAct = nodos.First();
                    nodos.Remove(nodoAct);

                    foreach (var vecino in grafo.ObtenerVecinos(nodoAct))
                    {
                        int distanciaposible = distancias[nodoAct] + grafo.Aristas.First(e => e.Desde == nodoAct && e.Hacia == vecino).Peso;
                        if (distanciaposible < distancias[vecino])
                        {
                            distancias[vecino] = distanciaposible;
                            nodoanterior[vecino] = nodoAct;
                        }
                    }
                }

                return distancias;
            }
        }
        public class Grafo
        {
            public List<NodoD> Nodos { get; set; }
            public List<Arista> Aristas { get; set; }

            public Grafo()
            {
                Nodos = new List<NodoD>();
                Aristas = new List<Arista>();
            }

            public void AgregarNodo(NodoD nodo)
            {
                Nodos.Add(nodo);
            }

            public void AgregarArista(NodoD Desde, NodoD Hacia, int peso)
            {
                Aristas.Add(new Arista(Desde, Hacia, peso));
            }

            public List<NodoD> ObtenerVecinos(NodoD nodo)
            {
                return Aristas.Where(e => e.Desde == nodo).Select(e => e.Hacia).ToList();
            }

            public class NodoD
            {
                public string Nombre { get; set; }
                public Point Posicion { get; set; }

                public NodoD(string nombre, Point posicion)
                {
                    Nombre = nombre;
                    Posicion = posicion;
                }

                public override bool Equals(object obj)
                {
                    return obj is NodoD nodo && Nombre == nodo.Nombre;
                }

                public override int GetHashCode()
                {
                    return Nombre.GetHashCode();
                }
            }

        }



        public class Arista
        {
            public NodoD Desde { get; set; }
            public NodoD Hacia { get; set; }
            public int Peso { get; set; }

            public Arista(NodoD desde, NodoD hacia, int peso)
            {
                Desde = desde;
                Hacia = hacia;
                Peso = peso;
            }
        }


        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            grafo.Nodos.Clear();
            grafo.Aristas.Clear();



            // Leer datos de los controles
            string nodo1Name = txtcodigo.Text;
            string nodo2Name = txtdescripcion.Text;
            string nodo3Name = cbcategoria.Text;
            string nodo4Name = dtpfechaingreso.Value.ToString("yyyy-MM-dd"); // Convertir la fecha a string
            string nodo5Name = dtpfechavencimiento.Value.ToString("yyyy-MM-dd"); // Convertir la fecha a string
            string nodo6Name = txtpreciocompra.Text;
            string nodo7Name = txtprecioventa.Text;


            if (string.IsNullOrEmpty(nodo1Name) || string.IsNullOrEmpty(nodo2Name) ||
            string.IsNullOrEmpty(nodo3Name) || string.IsNullOrEmpty(nodo4Name) ||
            string.IsNullOrEmpty(nodo5Name) || string.IsNullOrEmpty(nodo6Name) ||
            string.IsNullOrEmpty(nodo7Name))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear nodos usando los datos leídos
            NodoD nodo1 = new NodoD(nodo1Name, new Point(50, 50));
            NodoD nodo2 = new NodoD(nodo2Name, new Point(200, 50));
            NodoD nodo3 = new NodoD(nodo3Name, new Point(200, 200));
            NodoD nodo4 = new NodoD(nodo4Name, new Point(50, 200));
            NodoD nodo5 = new NodoD(nodo5Name, new Point(50, 300));
            NodoD nodo6 = new NodoD(nodo6Name, new Point(50, 350));
            NodoD nodo7 = new NodoD(nodo7Name, new Point(50, 400));

            grafo.AgregarNodo(nodo1);
            grafo.AgregarNodo(nodo2);
            grafo.AgregarNodo(nodo3);
            grafo.AgregarNodo(nodo4);
            grafo.AgregarNodo(nodo5);
            grafo.AgregarNodo(nodo6);
            grafo.AgregarNodo(nodo7);

            // Crear aristas (con pesos fijos por ahora, puedes cambiar los valores o añadir más lógica para personalizar)
            grafo.AgregarArista(nodo1, nodo2, 1);
            grafo.AgregarArista(nodo2, nodo3, 2);
            grafo.AgregarArista(nodo3, nodo4, 3);
            grafo.AgregarArista(nodo4, nodo1, 4);
            grafo.AgregarArista(nodo5, nodo1, 5);
            grafo.AgregarArista(nodo6, nodo1, 6);
            grafo.AgregarArista(nodo7, nodo1, 7);

            

            GenerarPosiciones();
            // Solicitar que el panel se vuelva a dibujar
            paneldijsktra.Invalidate();
            LimpiarCampos();
        }

        private void GenerarPosiciones()
        {
            int totalNodos = grafo.Nodos.Count;
            if (totalNodos == 0) return;

            int radio = Math.Min(paneldijsktra.Width, paneldijsktra.Height) / 3;
            Point centro = new Point(paneldijsktra.Width / 2, paneldijsktra.Height / 2);
            
            double angulo = 360.0 / totalNodos;

            for (int i = 0; i < totalNodos; i++)
            {
                double radianes = (angulo * i) * Math.PI / 180;
                int x = centro.X + (int)(radio * Math.Cos(radianes));
                int y = centro.Y + (int)(radio * Math.Sin(radianes));
                grafo.Nodos[i].Posicion = new Point(x, y);
            }
        }

        private void LimpiarCampos()
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            cbcategoria.SelectedItem = -1;
            txtproducto.Clear();
            dtpfechaingreso.Value = DateTime.Now;
            dtpfechavencimiento.Value = DateTime.Now;
        }

        private void paneldijsktra_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            g.Clear(paneldijsktra.BackColor);

            // Dibujar los nodos
            foreach (var nodo in grafo.Nodos)
            {
                g.FillEllipse(Brushes.Red, nodo.Posicion.X - 15, nodo.Posicion.Y - 15, 30, 30); // Nodo Inicial
                g.FillEllipse(Brushes.Green, nodo.Posicion.X - 15, nodo.Posicion.Y - 15, 30, 30); // Nodo final
                g.DrawString(nodo.Nombre, this.Font, Brushes.White, nodo.Posicion.X - 10, nodo.Posicion.Y - 10);
            }

            // Dibujar las aristas
            foreach (var arista in grafo.Aristas)
            {
                g.DrawLine(Pens.Black, arista.Desde.Posicion, arista.Hacia.Posicion);
                g.DrawString(arista.Peso.ToString(), this.Font, Brushes.Black,
                    (arista.Desde.Posicion.X + arista.Hacia.Posicion.X) / 2,
                    (arista.Desde.Posicion.Y + arista.Hacia.Posicion.Y) / 2);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }
    }
}