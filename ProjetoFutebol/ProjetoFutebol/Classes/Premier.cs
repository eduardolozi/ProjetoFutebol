using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public sealed class Premier : Liga
    {
        private static Premier instance = null;

        private Premier() { }

        public static Premier Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Premier();
                    instance.capacidadeMax = 20;
                }
                return instance;
            }
        }

        public override void listaTimes()
        {
            Console.WriteLine("======= Premier League =======");
            base.listaTimes();
            Console.WriteLine("==============================");
        }
    }
}
