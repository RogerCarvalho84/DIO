using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            //declare as demais variaveis

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (!(Double.IsNaN(r1) || Double.IsNaN(r2)))
            {
                Console.WriteLine("O resultado do x linha é :" + Math.Round(r1, 5) );
                Console.WriteLine("O resultado do x duas linhas é :" + Math.Round(r2, 5));
            }
            else
            {
                Console.WriteLine("Impossível calcular");
            }

            Console.ReadKey();
        }

    } 
}
