using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            n = Console.ReadLine();
            string[] prime = n.Split();
            foreach(string x in prime)
            {
                int sum = 0;
                for (int i=1; i < int.Parse(x); i++)
                {
                    if (int.Parse(x) % i == 0){
                        sum++;
                    }
                
                }
                if (sum <=1)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
    }
    }
}
