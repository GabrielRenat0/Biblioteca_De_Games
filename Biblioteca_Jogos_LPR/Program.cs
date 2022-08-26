using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_Jogos_LPR.Classes;

// FEITO POR FELIPE ADRYAN E GABRIEL RENATO , COM REFERENCIAS DO PROF.DANIEL
namespace Biblioteca_Jogos_LPR
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Jogo> listaJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.WriteLine("****** Biblioteca De Jogos Renatin ******");
                Console.WriteLine("1 - Adicionar um Jogo");
                Console.WriteLine("2 - Listar os Jogos");
                Console.WriteLine("3 - Atualizar um Jogo");
                Console.WriteLine("4 - Deletar um Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                string opcao = Console.ReadLine();
                bool resposta;
                switch (opcao)
                {

                   case "1":
                        resultado = AdicionarJogo(listaJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Cadastrado de cria feito :) ");
                        }
                        else
                        {
                            Console.WriteLine("Moio seu cadastro :( ");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado de cria :) ");
                        }
                        else
                        {
                            Console.WriteLine("Moio sua listagem :( ");
                        }
                        break;

                    case "3":
                        resultado = EditarJogo(listaJogos);
                        break;

                    case "4":
                        resultado = Deletar(listaJogos);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;



                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static bool AdicionarJogo(List<Jogo> listajogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genero do jogo: ");
            String genero = Console.ReadLine();
            Console.Write("Máximo de jogadores ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota no Meta Critic");
            int notaMetaCritic = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (ano < 1950) return false;
            if (genero == "") return false;
            if (notaMetaCritic <= 0 && notaMetaCritic >= 100) return false;

           Jogo novoJogo = new Jogo(titulo, ano, "teste", 1);

            listajogos.Add(novoJogo);
            Console.Beep();

            return true;
        }
        public static bool ListarJogos(List<Jogo> listaJogos)
        {
            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.Write("Genero:");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Máximo de jogadores:");
                Console.WriteLine(jogo.getMaxJogadores());
                Console.Write("Pontuação no MetaCritic:");
                Console.WriteLine(jogo.getNotaMetaCritic());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            Console.Write("Precione a tecla ENTER para voltar ao menu...");
            Console.ReadLine();
            return false;
        }

        public static bool EditarJogo(List<Jogo> listaJogos)
        {
            Console.Clear();
            Console.WriteLine("------ Edite o Jogo ------");
            Console.WriteLine("");

            Console.Write("Digite o nome do jogo existente quue queira editar:");
            string NomedoJogo = Console.ReadLine();
            foreach(Jogo jogo in listaJogos)
            {
                if (jogo.getTitulo() == NomedoJogo) 
                {
                    Console.Write("Novo título:");
                    string NovoTitulo = Console.ReadLine();

                    jogo.titulo = NovoTitulo;

                    Console.Write("Novo ano: ");
                    int NovoAno = Convert.ToInt32(Console.ReadLine());
                    jogo.ano = NovoAno;

                    Console.Write("Novo número max de jogadores:");
                    int NovoNumDeJogadores = Convert.ToInt32(Console.ReadLine());

                    jogo.maxJogadores = NovoNumDeJogadores;

                    Console.Write("Nova pontualção no MetaCritic: ");
                    int NovoMetaCritic = Convert.ToInt32(Console.ReadLine());

                    jogo.notaMetaCritic = NovoMetaCritic;

                    

                }
            }
            return true;

        }
        public static bool Deletar(List<Jogo> listaJogos)
        {
            Console.Clear();
            Console.WriteLine("---- Delar jogos ----");
            Console.WriteLine();

            Console.Write("Digite aqui o nome do jogo que você quer deletar:");
            string NomedoJogo = Console.ReadLine();
            foreach (Jogo jogo in listaJogos)
            {
                if (jogo.getTitulo() == NomedoJogo)
                {
                    listaJogos.Remove(jogo);
                    Console.WriteLine("Jogo selecionado foi deletado com exito!!!!!!!!!!");
                    break;
                }

            }

            Console.Write("Aperte ENTER para voltar");
            Console.ReadLine();
            
            return true;
        }
    }
}
//FEITO POR FELIPE ADRYAN E GABRIEL RENATO , COM REFERENCIAS DO PROF.DANIEL