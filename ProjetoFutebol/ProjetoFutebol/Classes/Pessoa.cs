using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public abstract class Pessoa
    {
        protected string nome;
        protected int idade;
        protected string nacionalidade;
        private Time time;

        public Pessoa(string nome, int idade, string nacionalidade)
        {
            this.nome = nome.ToUpper();
            this.idade = idade;
            this.nacionalidade = nacionalidade.ToUpper();
        }

        public Pessoa() { }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value.ToUpper();
            }
        }
        public int Idade
        {
            get
            {
                return this.idade;
            }
            set
            {
                this.idade = value;
            }
        }
        public string Nacionalidade
        {
            get
            {
                return this.nacionalidade;
            }
            set
            {
                this.nacionalidade = value.ToUpper();
            }
        }

        public Time Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public virtual void imprimeDadosGerais()
        {
            Console.WriteLine($"=== {this.Nome} ==\n=" +
                              $"TIME: {this.Time.Nome} \n" +
                              $"IDADE: {this.Idade}\n" +
                              $"NACIONALIDADE: {this.Nacionalidade}");
        }
    }
}
