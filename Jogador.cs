using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Jogador
    {
        private string nome { get; set; }
        private string posicao { get; set; }
        private double salario { get; set; }


        public Jogador(string nome, string posicao, double salario)
        {
            this.nome = nome;
            this.posicao = posicao;
            this.salario = salario;
        }

        public override string ToString()
        {
            return nome;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetPosicao()
        {
            return posicao;
        }

        public void SetPosicao(string nome)
        {
            this.posicao = posicao;
        }

        public double GetSalario()
        {
            return salario;
        }

        public void SetSalario(double salario)
        {
            this.salario = salario;
        }
    }
}
