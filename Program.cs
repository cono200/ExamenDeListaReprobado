namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple listaSimple1 = new ListaSimple();

            listaSimple1.InsertarFinal(new Persona("nombre", 18));
           



            listaSimple1.ImprimirLista();
        }
    }
}

