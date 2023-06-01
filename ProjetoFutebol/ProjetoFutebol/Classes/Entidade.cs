using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public abstract class Entidade
    {
        protected string nome;
        protected string nacionalidade;
        protected int anoFundacao;

        public Entidade(string nome, string nacionalidade, int anoFundacao)
        {   
            this.nome = nome.ToUpper();  
            this.nacionalidade = nacionalidade.ToUpper();
            this.anoFundacao = anoFundacao;
        }
        public Entidade(string nome, string nacionalidade)
        {   
            this.nome = nome.ToUpper();  
            this.nacionalidade = nacionalidade.ToUpper();
        }
        public Entidade(string nacionalidade)
        {   
            this.nacionalidade = nacionalidade.ToUpper();
        }
        public Entidade() { }

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
        public int AnoFundacao
        {
            get
            {
                return this.anoFundacao;
            }
            set
            {
                this.anoFundacao = value;
            }
        }


        
    }
}
