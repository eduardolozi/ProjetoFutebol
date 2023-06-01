using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol.Classes
{
    public sealed class LaLiga : Liga
    {
        private static LaLiga instance = null;

        private LaLiga() { }

        public static LaLiga Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new LaLiga();
                    instance.CapacidadeMax = 20;
                }
                return instance;
            }
        }

        public override void listaTimes()
        {
            Console.WriteLine("======= LaLiga =======");
            base.listaTimes();
            Console.WriteLine("======================");
        }


    }
}
