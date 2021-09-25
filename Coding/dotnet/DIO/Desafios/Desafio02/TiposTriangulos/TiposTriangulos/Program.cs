using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            Array.Reverse(s);
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            //double maior;
            //if(b > a)
            //{
            //    maior = b;
            //    b = a;
            //    a = maior;
            //} 
            //else if (c > a)
            //{
            //    maior = c;
            //    c = a;
            //    a = maior;
            //}
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(s[2]);

            if (!((a < b + c) && (b < a + c) && (c < a + b)))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (Math.Pow(a, 2) == (Math.Pow(b,2) + Math.Pow(c,2)))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if  (a > b + c)
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a < b + c)
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a == b && b == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if ((a == b && b != c) || (b == c && b != a) || (a == c && a != b))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
}
