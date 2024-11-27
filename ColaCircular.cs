using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    internal class ColaCircular
    {
        private ProductoColasCirculares[] cola;
        private int frente;
        private int final;
        private int tamaño;
        private int contador;

        public ColaCircular(int tamañoMaximo)
        {
            tamaño = tamañoMaximo;
            cola = new ProductoColasCirculares[tamaño];
            frente = -1;
            final = -1;
            contador = 0;
        }

        public bool EstaVacia() => contador == 0;
        public bool EstaLlena() => contador == tamaño;

        public void Añadir(ProductoColasCirculares item)
        {
            if (EstaLlena())
            {
                throw new InvalidOperationException("La cola está llena.");
            }

            if (EstaVacia())
            {
                frente = 0;
            }

            final = (final + 1) % tamaño;
            cola[final] = item;
            contador++;
        }

        public ProductoColasCirculares Eliminar()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            ProductoColasCirculares item = cola[frente];
            frente = (frente + 1) % tamaño;
            contador--;

            if (EstaVacia())
            {
                frente = -1;
                final = -1;
            }

            return item;
        }



        public ProductoColasCirculares VerFrente()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            return cola[frente];
        }

        public ProductoColasCirculares VerFinal()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            return cola[final];
        }

        public List<ProductoColasCirculares> ObtenerElementos()
        {
            List<ProductoColasCirculares> elementos = new List<ProductoColasCirculares>();

            if (!EstaVacia())
            {
                int i = frente;
                int elementosContados = 0;

                while (elementosContados < contador)
                {
                    elementos.Add(cola[i]);
                    i = (i + 1) % tamaño;
                    elementosContados++;
                }
            }

            return elementos;
        }
    }
}
