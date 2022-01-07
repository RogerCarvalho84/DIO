using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta = new ContaCorrente(847, 123456);

            FuncionarioAutenticavel roger = null;
            roger.Autenticar("ggdfgsf");

            Console.WriteLine(Conta.Numero);

            Console.ReadKey();
        }
    }
}
