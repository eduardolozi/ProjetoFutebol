using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public class Time : Entidade
    {
        protected List<Jogador>? elenco = new List<Jogador>();
        protected Treinador treinador;

        public Time(string nome, string nacionalidade, int anoFundacao) : base(nome, nacionalidade, anoFundacao) { }

        public Time(string nome, string nacionalidade) : base(nome, nacionalidade) { }
        
        public Time(string nacionalidade) : base(nacionalidade) { }

        public Time() { }

        public Treinador Treinador
        {
            get
            {
                return this.treinador;
            }
            set
            {
                this.treinador = value;
            }
        }

        public void adicionarJogador(Jogador jogador)
        {
            if (this.elenco?.Count < 30) this.elenco.Add(jogador);
            else Console.WriteLine("O elenco possui capacidade máxima, não é possível adicionar mais jogadores.");
        }

        public void imprimeDadosGerais()
        {
            Console.WriteLine("====================================\n" +
                              $"NOME DO TIME: {this.Nome}\n" +
                              $"NACIONALIDADE: {this.Nacionalidade}\n" +
                              $"ANO DE FUNDAÇÃO: {this.AnoFundacao}");
            this.imprimeElenco();
            Console.WriteLine("====================================");
        }

        public void imprimeElenco()
        {
            if(this.elenco?.Count == 0)
            {
                Console.WriteLine("O elenco não possui jogadores.");
                return;
            }
            Console.WriteLine($"=== {this.Nome} ===");
            foreach(Jogador jogador in elenco)
            {
                Console.WriteLine($"{jogador.Nome}");
            }
            Console.WriteLine("====================");
        }
    }
}
