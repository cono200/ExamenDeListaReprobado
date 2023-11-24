using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Nodo
    {
        private Persona _valor;
        private Nodo _siguiente;


       

       public Nodo(Persona Valor, Nodo Siguiente)
        {
            _valor = Valor;
            _siguiente = Siguiente;
        }




        public Persona Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }



        



    }
}
