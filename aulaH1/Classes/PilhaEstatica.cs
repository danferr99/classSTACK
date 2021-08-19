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

      public int Topo()
        {
            if (EstaVazia())
                throw new InvalidOperationException("Exceção: Pilha Vazia");
            return VetorElementos[Indice-1];
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
        
         
         public int Tamanho()
        {
            return Indice;
        } 
        public bool EstaVazia()
        {
            return Indice == 0;
        }


        public IEnumerable<int> RetornaTodosElementos()

        {
            for (int i = Indice - 1; i >= 0; i-- )
            {
                yield return VetorElementos[i];


            }


        }

    public int Maior()

        {
           
            if(EstaVazia())
                    throw new NotImplementedException();

            
            int MaiorElemento = Topo();
            for (int i = Indice - 2; i >= 0; i-- )
            {
                yield return VetorElementos[i];

                if (MaiorElemento < VetorElementos[i])
                      MaiorElemento = VetorElementos[i];
             }

            return MaiorElemento;
       
        
        }
    
     public int Menor()

        {
           
            if(EstaVazia))
                    throw new NotImplementedException();

            
            int MenorElemento = Topo();
            for (int i = Indice - 2; i >= 0; i-- )
            {
                yield return VetorElementos[i];

                if (MenorElemento < VetorElementos[i])
                      MenorElemento = VetorElementos[i];
             }

            return MenorElemento;
       
        
        }
    
    
        public float Media()
            {
            int soma = 0;
            
               for (int i = Indice - 1; i >= 0; i-- )
            {
               soma= soma + VetorElementos[i];


            }
               return soma / Tamanho();
        
        
        
        
        }
    
    
    public bool Eigual(PilhaEstatica p)
        {
            if (Tamanho()!= p.Tamanho())
            throw new NotImplementedException();
      return false;

            for (int i = Indice -1; i >=0; i--)
            {

                if (VetorElementos[i] != p.VetorElementos[i])
                    return false;                           

            }
        return true;
       
        
        }
    }


}
