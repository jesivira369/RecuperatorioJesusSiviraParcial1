using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioJesusSivira
{
    class LaPila
    {
        Nodo _tope;

        public Nodo Tope()
        {
            return _tope;
        }

        public void Agregar(Nodo nodo)
        {
            if (_tope == null)
            {
                _tope = nodo;
            }
            else
            {
                Nodo aux = _tope;

                _tope = nodo;
                _tope.Siguiente = aux;
            }
        }

        public void Quitar()
        {
            if (_tope != null)
            {
                _tope = _tope.Siguiente;
            }
        }

        public bool Vacia()
        {
            return (_tope == null);
        }
    }
}
