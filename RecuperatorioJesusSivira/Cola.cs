using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioJesusSivira
{
    class Cola
    {
        NodoCola inicio;

        public void Enqueue(NodoCola nodo)
        {
            if (inicio == null)
            {
                inicio = nodo;
            }
            else
            {
                NodoCola aux = Ultimo(inicio);
                aux.Siguiente = nodo;
            }
        }

        private NodoCola Ultimo(NodoCola nodo)
        {
            if (nodo.Siguiente == null)
            {
                return nodo;
            }
            else
            {
                return Ultimo(nodo.Siguiente);
            }
        }

        public void Dequeue()
        {
            inicio = inicio.Siguiente;
        }
        public NodoCola Primero
        {
            get
            {
                return inicio;
            }
        }

        public bool Vacia()
        {
            return (inicio == null);
        }
    }
}
