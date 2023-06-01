using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFutebol.Classes;
using ProjetoFutebol.Views;

namespace ProjetoFutebol.Domain
{
    public class Class1
    {
        static void Main(String[] args)
        {
            Menus.Menu1();
        }
    }
}

/*
            String nomeTime;
            Console.Write("Insira o nome do time: ");
            nomeTime = Console.ReadLine();
            Time time = new Time();
            time.Nome = nomeTime;
            time.Nacionalidade = "Espanha";
            time.AnoFundacao = 1899;

            Jogador jogador = new Jogador();
            jogador.Nome = "Robert Lewandowski";
            jogador.Nacionalidade = "Polônia";
            jogador.Idade = 34;
            jogador.PernaDominante = PernaBoa.Direita.ToString();
            Console.WriteLine($"Perna boa do {jogador.Nome}: {jogador.PernaDominante}");
            time.adicionarJogador(jogador);

            time.imprimeElenco();
            */
