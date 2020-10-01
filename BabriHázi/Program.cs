using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabriHázi
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = int.Parse(Console.ReadLine());   
            int összeg = 0;

            for (int i = 1; i <= szam; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        összeg += j;
                    }
                }
            }
            

            Console.WriteLine($"1-{szam}-ig a számok osztóinak összege: {összeg}");
            Console.ReadLine();


        }
    }
}
