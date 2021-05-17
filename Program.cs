using System;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCircular lista = new ListaCircular();

            lista.adicionar(new Jogador("Bruno", "Goleiro", 1057.10));
            lista.adicionar(new Jogador("Rodinei", "Lateral direito", 100000));
            lista.adicionar(new Jogador("Thiago Santos", "Volante", 50000));
            lista.adicionar(new Jogador("Diego Souza", "Atacante", 70000));
            lista.adicionar(new Jogador("Thiago Galhardo", "Atacante", 150000));

            lista.listar();

            lista.remover("Rodinei");

            lista.listar();

        }
    }
}
