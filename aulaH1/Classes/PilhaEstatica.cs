using System;
using System.Collections.Generic;
using aulaH1.Classes;

namespace aulaH1.Classes
{
    public class PilhaEstatica : IPilha<int>
    {
        private int[] VetorElementos;
        private int TamanhoMaximo = 30;
        private int Indice;
        private int Topo;
       
        public PilhaEstatica()
        {          
            VetorElementos = new int[TamanhoMaximo];
            Indice = 0;
        }

        public PilhaEstatica(int tamanhoMaximo)
        {
            if (tamanhoMaximo < 0)
                throw new ArgumentException("tamanhoMaximo", "Tamanho não pode ser menor ou igual a zero");
            TamanhoMaximo = tamanhoMaximo;
            VetorElementos = new int[TamanhoMaximo];
            Indice = 0;
        }

       
        public int BuscaTopo()
        {


            if (Topo == 0)


            {

                throw new Exception("pilha vazia, topo não tem valor!!");

            }
            
            
            return VetorElementos[Topo - 1];



        }
        
        
     public int Desempilha()
        {
            if(Topo == 0 )

            {
                throw new Exception("Pilha Vazia!!!! Topo não removido!!");

            }
            else
            {
                int valorRetorno = VetorElementos[Topo - 1];

                Topo--;

                return valorRetorno;


            }
                    
                    
                    
         }

      
        
       public void Empilha(int valor)
        {
            if (Topo < TamanhoMaximo)

            {
                VetorElementos[Topo] = valor;
                Topo++;
            }

            else
            {
                throw new Exception("Pilha cheia!! Valor não inserido!!");

            }
        }

        public int MaiorElemento()
        {
            throw new NotImplementedException();


        }
        public int MenorElemento()
        {
            throw new NotImplementedException();


        }
        public bool Eigual(PilhaEstatica p)
        {

            throw new NotImplementedException();
        }


    }
}
