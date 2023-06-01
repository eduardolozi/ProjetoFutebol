using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    internal class Brasileirao : Liga
    {
        private static Brasileirao instance = null;

        private Brasileirao() { }

        public static Brasileirao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Brasileirao();
                    instance.capacidadeMax = 20;
                }
                return instance;
            }
        }

        public override void listaTimes()
        {
            Console.WriteLine("======= Brasileirão =======");
            base.listaTimes();
            Console.WriteLine("===========================");
        }
    }
}
