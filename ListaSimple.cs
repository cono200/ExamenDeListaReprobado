using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListaSimple
    {

        Nodo primerNodo;
        Nodo ultimoNodo;

        public ListaSimple()
        {
            primerNodo = ultimoNodo = null;
        }

        public bool ListaVacia()
        {
            return (primerNodo== null);
        }

        public void InsertarFinal(Persona persona)
        {
           
            Nodo nuevoNodo = primerNodo;
            if (ListaVacia())
            {
                primerNodo= nuevoNodo;
                nuevoNodo = ultimoNodo;
                
            }
            
       
           
        }


        public void ImprimirLista()
        {
            Nodo actual = primerNodo;
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                while (actual != null)
                {
                    Console.WriteLine("aaaaaaaaaaaaaaaa");
                    Console.WriteLine(actual.Valor);
                    actual = actual.Siguiente;
                }
            }
            
        }


        public void BuscarNombre()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia por lo tanto no se puede buscar");
            }
            else
            {
                int contador = 0;
                Nodo actual = ultimoNodo;
                string buscar = "Juan";

                while (actual != null)
                {
                    buscar.CompareTo(actual.Valor);
                        contador++;
                    

                    
                }


            }
        }





    }

    /*ESTUDIAR INSERTAR
     * VER QUE COSAS LLEVA EL NODO
     * BUSQUEDA CON EL COMPARE
     * ORDENAMIENTO
     */

}

