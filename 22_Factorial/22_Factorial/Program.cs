using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Factorial {
    class Program {

        static int Factorial(int value) {
            int result = 1;

            for(int i = value; i > 0; i--) {
                result *= i;
            }


            return result;
        }


        static void Main(string[] args) {
            Console.Write("Podaj liczbe z jakiej chcesz silnie: ");
            int value = Int32.Parse(Console.ReadLine());
            Console.Write("{0}! to {1}", value, Program.Factorial(value));
            Console.ReadKey();
        }
    }
}
