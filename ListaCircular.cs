using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class ListaCircular
    {
        private Elemento inicio;
        int contagem;
        int limite = 10;

        public void adicionar(Jogador j)
        {
            if (verifica())
            {
                if (this.inicio == null)
                {
                    this.inicio = new Elemento(j);
                    contagem++;
                    this.inicio.SetProximo(this.inicio);
                }
                else
                {
                    Elemento elemento = this.inicio;
                    contagem++;
                    while (!elemento.GetProximo().GetJogador().Equals(this.inicio.GetJogador()))
                    {
                        elemento = elemento.GetProximo();
                    }
                    elemento.SetProximo(new Elemento(j));
                    elemento.GetProximo().SetProximo(this.inicio);
                }
            } else
            {
                Console.WriteLine("");
            }
        }

        public void listar()
        {
            contagem = 0;
            Elemento elemento = this.inicio;
            contagem++;
            Console.WriteLine(elemento.GetJogador());
            while (!elemento.GetProximo().GetJogador().Equals(this.inicio.GetJogador()))
            {
                elemento = elemento.GetProximo();
                contagem++;
                Console.WriteLine(elemento.GetJogador());
            }
            Console.WriteLine("Contagem: "+contagem);
        }

        public void remover(string nome)
        {
            Console.WriteLine("Nome enviado: "+nome);
            Elemento elemento = this.inicio;
            Console.WriteLine("Primeiro chamado: "+elemento.GetJogador().GetNome());
            if (elemento.GetJogador().GetNome().Equals(nome))
            {
                this.inicio = elemento.GetProximo();
                while (!elemento.GetProximo().GetJogador().GetNome().Equals(nome))
                {
                    elemento = elemento.GetProximo();
                    Console.WriteLine("Chamado: "+elemento.GetJogador().GetNome());
                }
                elemento.SetProximo(this.inicio);
            } else
            { 
                while (!elemento.GetProximo().GetJogador().GetNome().Equals(this.inicio.GetJogador().GetNome()))
                {
                    if (!elemento.GetProximo().GetJogador().GetNome().Equals(nome))
                    {
                        elemento = elemento.GetProximo();
                    } else
                    {
                        elemento.SetProximo(elemento.GetProximo().GetProximo());
                        break;
                    }
                }
            }
        }

        public bool verifica()
        {
            if (contagem > limite)
            {
                Console.WriteLine("Limite máximo atingido");
                return false;
            } else
            {
                Console.WriteLine("Autorizado.");
                return true;
            }
            return false;
        }
    }
}
