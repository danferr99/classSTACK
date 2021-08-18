using aulaH1.Classes;
using System;

namespace aulaH1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            PilhaEstatica p = new PilhaEstatica();
            PilhaEstatica p = new PilhaEstatica();
            bool flVazia = p.EstaVazia();
            p.Empilha(1);
            p.Empilha(2);
            p.Empilha(3);
            var numeros = p.RetornaTodosElementos();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            p.Desempilha();
            Console.WriteLine("E agora");
            numeros = p.RetornaTodosElementos();
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
