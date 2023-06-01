using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public class Treinador : Pessoa
    {
        public Treinador(string nome, int idade, string nacionalidade) : base(nome, idade, nacionalidade) { }

        public override void imprimeDadosGerais()
        {
            base.imprimeDadosGerais();
            Console.WriteLine("==============================");
        }
    }

}
