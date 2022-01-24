using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(458, 5697535),
                    new ContaCorrente(952, 1369845),
                    new ContaCorrente(126, 9687423),
                    new ContaCorrente(753, 2369857),
                    new ContaCorrente(698, 8745396)

                };



            for (int indice = 0; indice < contas.Length; indice++)
            {
                Console.WriteLine($"Conta {indice} Agência {contas[indice].Agencia} Número {contas[indice].Numero}.");
            }

            Console.ReadKey();
        }

        static void TestaArrayInt()
        {
            //ARRAY de inteiros com 5 posições

            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 37;
            idades[4] = 52;
            idades[5] = 60;

            int acumulador = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}.");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}.");
                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"Média de idades = {media}.");

            Console.ReadKey();
        }
        static void TestaObjetos()
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);


            object conta = new ContaCorrente(456, 123456);
            object desenvolvedor = new Desenvolvedor("32405754851");

            string contaToString = conta.ToString();

            Console.WriteLine(contaToString);

            Cliente lucas_1 = new Cliente();
            lucas_1.Nome = "Lucas";
            lucas_1.CPF = "123.456.789-01";
            lucas_1.Profissao = "Guia de Turismo";


            Cliente lucas_2 = new Cliente();
            lucas_2.Nome = "Lucas";
            lucas_2.CPF = "123.456.789-01";
            lucas_2.Profissao = "Guia de Turismo";


            if (lucas_1.Equals(lucas_2))
            {

                Console.WriteLine("Iguais");
            }
            else
            {
                Console.WriteLine("Nope!");
            }

            Console.ReadKey();
        }

        static void TestaString()
        {
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Roger, me ligue em 981732740";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);

            Console.ReadKey();


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com/");


            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com/"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadKey();




            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valor2 = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valor2);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();



            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));



            /**DateTime dataFimPagamento = new DateTime(2022, 07, 11);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);**/

            Console.ReadKey();
        }
       
    }
}
