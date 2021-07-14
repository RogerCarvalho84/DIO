using System;

namespace DividindoXPorY
{
    class Program
    {
        static void Main() {
        Console.WriteLine("Digite a quantidade de vezes.");
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
                Console.ReadKey();
            } else {
                double divisao = X / Y; // Digite aqui o calculo da divisao
                Console.WriteLine(divisao.ToString("N1"));
            }
            
        }
        
        Console.ReadKey();
    }
    }
}
