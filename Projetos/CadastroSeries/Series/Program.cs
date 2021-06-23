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
                                        InserirSerie();
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
                                        InserirJogo();
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


        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(GeneroSeries)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroSeries), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
 
            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioS.ProximoId(),
                                        genero: (GeneroSeries)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioS.Insere(novaSerie);
            
        }

         private static void InserirJogo()
        {
            Console.WriteLine("Inserir novo jogo");

            foreach (int i in Enum.GetValues(typeof(GeneroJogos)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroJogos), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título do jogo: ");
            string entradaTitulo = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Plataformas)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Plataformas), i));
            }
            Console.WriteLine("Digite a plataforma entre as opções acima: ");
            int entradaPlataforma = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Digite o ano de lançamento do jogo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do jogo: ");
            string entradaDescricao = Console.ReadLine();

            Jogo novoJogo = new Jogo(id: repositorioJ.ProximoId(),
                                        genero: (GeneroJogos)entradaGenero,
                                        titulo: entradaTitulo,
                                        plataforma: (Plataformas)entradaPlataforma,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioJ.Insere(novoJogo);
            
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(GeneroSeries)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroSeries), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
 
            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (GeneroSeries)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioS.Atualiza(indiceSerie, atualizaSerie);

        }

         private static void AtualizarJogo()
        {
            Console.WriteLine("Digite o ID do jogo: ");
            int indiceJogo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(GeneroJogos)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroJogos), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título do jogo: ");
            string entradaTitulo = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Plataformas)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Plataformas), i));
            }
            Console.WriteLine("Digite a plataforma entre as opções acima: ");
            int entradaPlataforma = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Digite o ano de lançamento do jogo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do jogo: ");
            string entradaDescricao = Console.ReadLine();

            Jogo atualizaJogo = new Jogo(id: indiceJogo,
                                        genero: (GeneroJogos)entradaGenero,
                                        plataforma: (Plataformas)entradaPlataforma,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioJ.Atualiza(indiceJogo, atualizaJogo);

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
            Console.WriteLine();
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
            Console.WriteLine();
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
            return opcaoUsuario;

        }
    }
}
