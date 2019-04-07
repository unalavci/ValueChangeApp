using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueChangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        public static void Process()
        {
            int number1 = 10;
            int number2 = 20;

            Console.WriteLine("Initial values");
            Console.WriteLine("Number 1={0}",number1);
            Console.WriteLine("Number 2={0}",number2);
            Console.WriteLine("______________________________");



            number1 = number1 + number2;
            number2 = number1 - number2;

            number1 = number1 - number2;

            Console.WriteLine("After changing the values");
            Console.WriteLine("Number 1={0}", number1);
            Console.WriteLine("Number 2={0}", number2);
            Console.ReadKey();
        }
    }
}
