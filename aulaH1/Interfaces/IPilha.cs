
using aulaH1.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace aulaH1.Interfaces
{
    public interface IPilha<Container>
    {
        public void Empilha(Container valor);

        public Container Desempilha();

        public Container MaiorElemento();
        
        
        public Container BuscaTopo();

        public Container MenorElemento();

         public Container RetornaTodosElementos();

       


    }
}
