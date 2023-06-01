using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFutebol.Classes;

namespace ProjetoFutebol.Views
{
    public class Menus
    {


        private static Time busca(string nomedotime)
        {
            LaLiga laLiga = LaLiga.Instance; // inicializamos a LaLiga usando o Singleton
            Premier premier = Premier.Instance;
            Brasileirao brasileirao = Brasileirao.Instance;
            Time timeachado = new Time();

            timeachado = laLiga.buscaTime(nomedotime);
            if (timeachado != null) return timeachado;

            timeachado = premier.buscaTime(nomedotime);
            if (timeachado != null) return timeachado;

            timeachado = brasileirao.buscaTime(nomedotime);
            if (timeachado != null) return timeachado;

            return null;
        }
        public static void Menu1()
        {
            
            int resp;
            LaLiga laLiga = LaLiga.Instance; // inicializamos a LaLiga usando o Singleton
            Premier premier = Premier.Instance;
            Brasileirao brasileirao = Brasileirao.Instance;

            do
            {
                Console.WriteLine("MENU:\n" +
                                  "0) LIMPAR O TERMINAL\n" +
                                  "1) SAIR DO MENU\n" +
                                  "2) ADICIONAR TIME\n" +
                                  "3) LISTAR TIMES DE UMA LIGA\n" +
                                  "4) BUSCAR TIME\n" +
                                  "5) ADICIONAR JOGADOR A UM TIME");
                resp = Convert.ToInt32(Console.ReadLine());
                switch (resp)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine("Menu Encerrado");
                        break;
                    case 2:
                        Console.Write("Insira o nome do time: ");
                        Time time = new Time();
                        time.Nome = Console.ReadLine();
                        Console.WriteLine("Insira a nacionalidade do time: \n" +
                                      "1) ESPANHA\n2) INGLATERRA\n3) BRASIL");
                        int numeroNac = Convert.ToInt32(Console.ReadLine());
                        if (numeroNac == 1)
                        {
                            time.Nacionalidade = "Espanha";
                            laLiga.adicionaTime(time);
                        }
                        else if (numeroNac == 2)
                        {
                            time.Nacionalidade = "Inglaterra";
                            premier.adicionaTime(time);
                        }
                        else if (numeroNac == 3)
                        { 
                            time.Nacionalidade = "Brasil";
                            brasileirao.adicionaTime(time);
                        }

                        break;
                    case 3:
                        int numLiga;
                        Console.WriteLine("Selecione de qual liga deseja ver os times:\n" +
                                          "1) LaLiga\n" +
                                          "2) Premier League\n" +
                                          "3) Brasileirão Serie A");
                        numLiga = Convert.ToInt32(Console.ReadLine());

                        if (numLiga == 1)
                        {
                            laLiga.listaTimes();
                        }
                        else if (numLiga == 2)
                        {
                            premier.listaTimes();
                        }
                        else if (numLiga == 3)
                        {
                            brasileirao.listaTimes();
                        }
                        else Console.WriteLine("Opção inválida");
                        
                        break;
                    case 4:
                        string nomedotime;
                        Console.Write("Informe o nome do time: ");
                        nomedotime = Console.ReadLine();
                        if (busca(nomedotime) == null) Console.WriteLine("Time não encontrado.");

                        break;
                    case 5:
                        Jogador jogador = new Jogador();
                        

                        Console.Write("Informe o time em que você deseja adicionar um jogador: ");
                        string nometemp = Console.ReadLine();
                        if (busca(nometemp) == null)
                        {
                            Console.WriteLine("Time não encontrado.");
                            break;
                        } else
                        {
                            jogador.Time = busca(nometemp);
                        }


                        string resposta;
                        int numperna;
                        do
                        {
                            Jogador jog = new Jogador();
                            jog.Time = jogador.Time;

                           
                            Console.Write("Nome do jogador: ");
                            jog.Nome = Console.ReadLine();
                            Console.Write("Idade do jogador: ");
                            jog.Idade = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Perna Dominante do jogador:\n" +
                                          "1) Direita\n" +
                                          "2) Esquerda\n" +
                                          "3) Ambidestro");
                            numperna = Convert.ToInt32(Console.ReadLine());
                            if (numperna == 1) jog.PernaDominante = PernaBoa.Direita.ToString();
                            if (numperna == 2) jog.PernaDominante = PernaBoa.Esquerda.ToString();
                            if (numperna == 3) jog.PernaDominante = PernaBoa.Ambidestro.ToString();
                            Console.Write("Nacionalidade do jogador: ");
                            jog.Nacionalidade = Console.ReadLine();
                            Console.Write("Número da camisa: ");
                            jog.NumeroDaCamisa = Convert.ToInt32(Console.ReadLine());
                            
                            jog.Time.adicionarJogador(jog);

                            Console.WriteLine("Adicionar mais um jogador? [S/N]");
                            resposta = Console.ReadLine();

                        } while (resposta.ToUpper() != "N");

                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                    
            } while (resp != 1);
        }
    }
}
