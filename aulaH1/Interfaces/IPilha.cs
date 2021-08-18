
using aulaH1.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace aulaH1.Interfaces
{
    public interface IPilha<T>
    {
        public void Empilha(T valor);

        public T Desempilha();

        public T MaiorElemento();
        
        
        public T BuscaTopo();

        public T MenorElemento();

        public bool Eigual(PilhaEstatica pilha);



    }
}
