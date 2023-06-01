using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public abstract class Liga : Entidade
    {
        protected List<Time> liga = new List<Time>();
        protected int capacidadeMax;

        public int CapacidadeMax
        {
            get { return capacidadeMax; }
            protected set { capacidadeMax = value; }
        }

        public void adicionaTime(Time time)
        {
            if(this.liga.Count > capacidadeMax)
            {
                Console.WriteLine("Impossível adicionar mais times à liga.");
                return;
            }
            if(this.buscaTime(time.Nome) != null)
            {
                Console.WriteLine("O time já existe.");
                return;
            }
            this.liga.Add(time);
        }

        public Time buscaTime(string time)
        {
            if(this.liga.Count == 0)
            {
                return null;
            }
            foreach(Time nomeTimes in liga) 
            { 
                if(nomeTimes.Nome.ToLower().Equals(time.ToLower()))
                {
                    nomeTimes.imprimeDadosGerais();
                    return nomeTimes;
                }    
            }
            return null;
        }

        public virtual void listaTimes()
        {
            if(this.liga.Count == 0)
            {
                Console.WriteLine("Não existem times na liga");
                return;
            }
            foreach(Time time in liga)
            {
                Console.WriteLine($"{time.Nome}");
            }
        }

    }
}
