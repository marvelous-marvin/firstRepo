using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("please enter number:");
            while (!int.TryParse(Console.ReadLine(), out x)) {
                Console.WriteLine("please enter a number:");
            }




            while (x > 0)
            {
                Console.WriteLine("People love/hate console apps!");
                x--;
               
            }
            Console.ReadLine();


        }
    }
}
