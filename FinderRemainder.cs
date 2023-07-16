using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qaliqfinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are:");

            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (numbers[i]%2==0)
                {
                        Console.Write(numbers[i]+ " ");
                }
            }
           
        }
    }
}
