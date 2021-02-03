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

            //I might add a variable

            Console.WriteLine("please enter number:");
            while (!int.TryParse(Console.ReadLine(), out x)) {
                Console.WriteLine("please enter a number:");
            }




            while (x > 0)
            {
                Console.WriteLine("From GitHub loves console apps!");
                x--;
               
            }
            Console.ReadLine();


        }
    }
}
