using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Palindrome_Checker {
    class Program {

        static string reverse(string text) {
            string result = "";
            for(int i = 0; i < text.Length; i++) {
                result += text[text.Length - 1 - i];
            }

            return result;
        }


        static void Main(string[] args) {
            char odp = 'Y';
            while (odp == 'Y' || odp == 'y') {
                Console.Write("Podaj tekst: ");
                string text = Console.ReadLine();
                Console.WriteLine("Czy {0} jest Palindromem? \nOdpowiedz: {1}", text, text == reverse(text));
                Console.WriteLine("Chcesz jeszcze? [y/n]");
                odp = Console.ReadLine()[0];
            }
        }
    }
}
