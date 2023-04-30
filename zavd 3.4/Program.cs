using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd_3._4
{
    internal class Program
    {
        static void rozk(int n)
        {
            Console.Write("Розклад на простi множники: ");
            List<int> perevirka = new List<int>();
            for (int i=2; i<=n; i++)
            {
                while (n%i==0)
                {

                    if (!perevirka.Contains(i))
                    {
                        perevirka.Add(i);
                        Console.Write(i + " ");
                    }
                    n = n / i;
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть натуральне число");
            int x = int.Parse(Console.ReadLine());
           rozk(x);
            Console.ReadLine();
        }
    }
}
