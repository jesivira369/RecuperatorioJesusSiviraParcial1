using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperatorioJesusSivira
{
    public partial class Form1 : Form
    {

        LaPila Pila = new LaPila();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ImprimirPila()
        {
            listPila.Items.Clear();

            if (Pila.Tope() != null)
            {
                MostrarNodos(Pila.Tope());
            }
        }

        void MostrarNodos(Nodo nodo)
        {
            listPila.Items.Add(nodo.Nombre);

             if(nodo.Siguiente != null)
            {
                MostrarNodos(nodo.Siguiente);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (Pila.Vacia())
            {
                MessageBox.Show("La Pila esta vacia.");
            }
            else
            {
                Pila.Quitar();
                ImprimirPila();
            }
        }

        // Programamos los botones y listas de la cola

        Cola miCola = new Cola();

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            /*if (txtNodoNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
            else
            {
                NodoCola nuevoNodo = new NodoCola();
                nuevoNodo.Nombre = txtNodoNombre.Text;
                miCola.Enqueue(nuevoNodo);
                ImprimirCola();
            }*/
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La Cola esta vacia.");
            }
            else
            {
                miCola.Dequeue();
                ImprimirCola();
            }
        }

        private void ImprimirCola()
        {
            listCola.Items.Clear();
            MostrarNodoCola(miCola.Primero);
        }

        private void MostrarNodoCola(NodoCola nodo)
        {
            if (nodo != null)
            {
                listCola.Items.Add(nodo.Nombre);

                if (nodo.Siguiente != null)
                {
                    MostrarNodoCola(nodo.Siguiente);
                }
            }
        }

        // El BOTON DE CARGAR LO HICE COMUN PARA AMBOS, SUBIMOS EL MISMO NUMERO A LA PILA Y A LA COLA AL MISMO TIEMPO 

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {

            if (txtNodoNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido.");
            }
            else
            {
                //Para al pila
                Nodo nuevoNodoPila = new Nodo();
                nuevoNodoPila.Nombre = txtNodoNombre.Text;

                Pila.Agregar(nuevoNodoPila);
                ImprimirPila();


                // Para cargar la cola
                NodoCola nuevoNodoCola = new NodoCola();
                nuevoNodoCola.Nombre = txtNodoNombre.Text;
                miCola.Enqueue(nuevoNodoCola);
                ImprimirCola();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
