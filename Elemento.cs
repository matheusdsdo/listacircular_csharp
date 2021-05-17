using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Elemento
    {
        private Jogador j;
        private Elemento proximo;

        public Elemento (Jogador j)
        {
            this.j = j;
        }

        public Jogador GetJogador()
        {
            return this.j;
        }

        public void SetJogador(Jogador j)
        {
            this.j = j;
        }

        public Elemento GetProximo()
        {
            return this.proximo;
        }

        public void SetProximo(Elemento e)
        {
            this.proximo = e;
        }

        public override string ToString()
        {
            return "Elemento: "+ j.ToString();
        }
    }
}
