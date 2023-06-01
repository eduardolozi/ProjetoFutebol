using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public class Jogador : Pessoa
    {

        private string pernaDominante;
        private int numeroDaCamisa;

        public Jogador(string nome, int idade, string nacionalidade, int numeroDaCamisa, string perna) : base(nome, idade, nacionalidade)
        {
            this.numeroDaCamisa = numeroDaCamisa;
            this.pernaDominante = perna.ToUpper();
        }

        public Jogador() { }

        public string PernaDominante
        {
            get
            {
                return this.pernaDominante;
            }
            set
            {
                this.pernaDominante = value.ToUpper();
            }
        }

        public int NumeroDaCamisa
        {
            get
            {
                return this.numeroDaCamisa;
            }
            set
            {
                this.numeroDaCamisa = value;
            }
        }

        public override void imprimeDadosGerais()
        {
            base.imprimeDadosGerais();
            Console.WriteLine($"PERNA BOA: {this.pernaDominante}\n" +
                              $"NUMERO DA CAMISA: {this.numeroDaCamisa}" +
                              "==============================");
        }
    }
}
