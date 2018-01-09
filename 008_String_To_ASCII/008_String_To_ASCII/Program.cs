using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_String_To_ASCII {
    class Program {

        static public string Convert(string text) {
            string result = "";

            foreach(char c in text) {
                result += (int)c;
                result += " ";
            }

            return result;
        }

        static void Main(string[] args) {
            Console.Write("Podaj text: ");
            string text = Console.ReadLine();
            Console.WriteLine(Program.Convert(text));
            Console.ReadKey();
        }
    }
}
