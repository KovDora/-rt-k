using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace érték
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = a;
            Console.WriteLine($"a={a}, b={b}");
            a = 13;
            Console.WriteLine("És most listákkal ugyanez");
            List<int> lista = new List<int>();
            lista.Add(3);
            lista.Add(5);
            lista.Add(7);
            List<int> listb = lista;
            Console.WriteLine("Lista elemei");
            foreach (int elem in lista)
            {
                Console.WriteLine(elem);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Listb elemei");
            foreach (int elem in listb)
            {
                Console.WriteLine(elem);
                Console.Write(" ");
            }
            Console.WriteLine();


        }
    }
}
