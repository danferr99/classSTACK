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
            p.Empilha(10);
            p.Empilha(20);
            p.Empilha(30);
            p.Empilha(40);
            p.Empilha(50);
            p.Empilha(60);
            
            float media = p.Media();
            int maior =p.Maior();
            int menor = p.Menor();




            media= p2
            
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
