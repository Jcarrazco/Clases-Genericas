using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesgenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 50,  x2 = 20;
            printer<string> prt = new printer<string>();

            Console.WriteLine("Escriba un string para enviar a la clase");
            string n = prt.Print(Console.ReadLine());
            Console.WriteLine(n);

            swper<int> sw = new swper<int>();
            sw.swap(x1,x2);
            Console.ReadKey();

            
        }
    }
}
