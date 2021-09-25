using System;
using Series.Classes;

namespace Series
{
    class Program
    {

        static SerieRepositorio repositorioS = new SerieRepositorio();
        static JogoRepositorio repositorioJ = new JogoRepositorio();
        static void Main(string[] args)
        {
                string opcaoUsuario = ObterOpcaoPrincipal();

                while (opcaoUsuario.ToUpper() != "X")
                {

                    switch(opcaoUsuario)
                    {
                        case "1":
                        {
                            opcaoUsuario = ObterOpcaoUsuarioSerie();

                            while (opcaoUsuario.ToUpper() != "X")
                            {

                                switch(opcaoUsuario)
                                {
                                    case "1":
                                        ListarSerie();
                                        break;
                                    case "2":
                                        InserirSerie(-1);
                                        break;
                                    case "3":
                                        AtualizarSerie();
                                        break;
                                    case "4":
                                        ExcluirSerie();
                                        break;
                                    case "5":
                                        VisualisarSerie();
                                        break;
                                    case "C":
                                        Console.Clear();
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                                opcaoUsuario = ObterOpcaoUsuarioSerie();
                            }

                            break;                     
                        }
                        case "2":
                        {
                            opcaoUsuario = ObterOpcaoUsuarioJogo();
                            
                            while (opcaoUsuario.ToUpper() != "X")
                            {

                                switch(opcaoUsuario)
                                {
                                    case "1":
                                        ListarJogo();
                                        break;
                                    case "2":
                                        InserirJogo(-1);
                                        break;
                                    case "3":
                                        AtualizarJogo();
                                        break;
                                    case "4":
                                        ExcluirJogo();
                                        break;
                                    case "5":
                                        VisualisarJogo();
                                        break;
                                    case "C":
                                        Console.Clear();
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                                opcaoUsuario = ObterOpcaoUsuarioJogo();
                            }

                            break;
                        }
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }


                Console.WriteLine("Obrigado por utilizar os nossos serviços!");
                Console.ReadKey();  
        }

      

        private static void ListarSerie()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorioS.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(),serie.retornaTitulo(),(serie.retornaExcluido() ? "*Excluído*" : ""));
            }
        }

        private static void ListarJogo()
        {
            Console.WriteLine("Listar jogo");

            var lista = repositorioJ.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum jogo cadastrado.");
                return;
            }
            foreach (var jogo in lista)
            {
                Console.WriteLine("#ID {0}: - {1} {2}", jogo.retornaId(),jogo.retornaTitulo(),(jogo.retornaExcluido() ? "*Excluído*" : ""));
            }
        }


        private static void InserirSerie(int indice)
        {
            Console.WriteLine("Inserir nova série");

            var auxNovo = true;


            foreach (int i in Enum.GetValues(typeof(GeneroSeries)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroSeries), i));
            }
            Console.WriteLine();
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
 
            Console.WriteLine();
            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

             if(indice < 0)
            {
                indice = repositorioS.ProximoId();
            }
            else
            {
                auxNovo = false;
            }

            Serie novaSerie = new Serie(id: indice,
                                        genero: (GeneroSeries)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            if(!auxNovo)
            {
                repositorioS.Atualiza(indice,novaSerie);
                Console.WriteLine("Série atualizada com sucesso!");
                return;
            }
            repositorioS.Insere(novaSerie);
            Console.WriteLine("Série inserida com sucesso!");
            
        }

         private static void InserirJogo(int indice)
        {
            var auxNovo = true;

            Console.WriteLine("Inserir novo jogo");

            foreach (int i in Enum.GetValues(typeof(GeneroJogos)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroJogos), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o título do jogo: ");
            string entradaTitulo = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Plataformas)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Plataformas), i));
            }
            Console.WriteLine();
            Console.WriteLine("Digite a plataforma entre as opções acima: ");
            int entradaPlataforma = int.Parse(Console.ReadLine());
 
            Console.WriteLine();
            Console.WriteLine("Digite o ano de lançamento do jogo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite a descrição do jogo: ");
            string entradaDescricao = Console.ReadLine();

            if(indice < 0)
            {
                indice = repositorioJ.ProximoId();
            }
            else
            {
                auxNovo = false;
            }
            Jogo novoJogo = new Jogo(   id: indice,
                                        genero: (GeneroJogos)entradaGenero,
                                        titulo: entradaTitulo,
                                        plataforma: (Plataformas)entradaPlataforma,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            if(!auxNovo)
            {
                repositorioJ.Atualiza(indice,novoJogo);
                Console.WriteLine("Jogo atualizado com sucesso!");
                return;
            }
            repositorioJ.Insere(novoJogo);
            Console.WriteLine("Jogo inserido com sucesso!");
            
        }
        

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            InserirSerie(indiceSerie);
        }

         private static void AtualizarJogo()
        {
            Console.WriteLine("Digite o ID do jogo: ");
            int indiceJogo = int.Parse(Console.ReadLine());

            InserirJogo(indiceJogo);

        }
        private static void ExcluirSerie()
        {
            
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja excluir esta série?");
            Console.WriteLine("S/N");
            string resposta = Console.ReadLine();
            if(resposta.ToUpper() == "S")
            {
                repositorioS.Exclui(indiceSerie);
                Console.WriteLine("Série excluída com sucesso!");
            }
            
        }

        private static void ExcluirJogo()
        {
            
            Console.WriteLine("Digite o ID do Jogo: ");
            int indiceJogo = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja excluir esta série?");
            Console.WriteLine("S/N");
            string resposta = Console.ReadLine();
            if(resposta.ToUpper() == "S")
            {
                repositorioJ.Exclui(indiceJogo);
                Console.WriteLine("Jogo excluído com sucesso!");
            }
            
        }

        private static void VisualisarSerie()
        {

            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioS.RetornaPorID(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void VisualisarJogo()
        {

            Console.WriteLine("Digite o ID do Jogo: ");
            int indiceJogo = int.Parse(Console.ReadLine());

            var jogo = repositorioJ.RetornaPorID(indiceJogo);

            Console.WriteLine(jogo);
        }
        private static string ObterOpcaoUsuarioSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Portal Dwarf!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Visualisar serie");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }

        private static string ObterOpcaoUsuarioJogo()
        {
            Console.WriteLine();
            Console.WriteLine("Portal Dwarf!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Listar jogos");
            Console.WriteLine("2 - Inserir novo jogo");
            Console.WriteLine("3 - Atualizar jogo");
            Console.WriteLine("4 - Excluir jogo");
            Console.WriteLine("5 - Visualisar jogo");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }

        private static string ObterOpcaoPrincipal()
        {
            Console.WriteLine();
            Console.WriteLine("Portal Dwarf!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Menu series");
            Console.WriteLine("2 - Menu jogos");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.Clear();
            return opcaoUsuario;

        }
    }
}
