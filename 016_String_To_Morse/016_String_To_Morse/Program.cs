using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_String_To_Morse {
    class Program {


        static public string Convert(string text) {
            string result = "";
            
            for(int i = 0; i < text.Length; i++) {
                switch (text[i]) {
                    case 'A':
                    case 'a':
                        result += ".- ";
                        break;
                    case 'B':
                    case 'b':
                        result += "-... ";
                        break;
                    case 'C':
                    case 'c':
                        if (text[i + 1] == 'h' || text[i + 1] == 'H') {
                            result += "---- ";
                            break;
                        }
                        result += "-.-. ";
                        break;
                    case 'D':
                    case 'd':
                        result += "-.. ";
                        break;
                    case 'E':
                    case 'e':
                        result += ". ";
                        break;
                    case 'F':
                    case 'f':
                        result += "..-. ";
                        break;
                    case 'G':
                    case 'g':
                        result += ".... ";
                        break;
                    case 'I':
                    case 'i':
                        result += ".. ";
                        break;
                    case 'J':
                    case 'j':
                        result += ".--- ";
                        break;
                    case 'K':
                    case 'k':
                        result += "-.-- ";
                        break;
                    case 'L':
                    case 'l':
                        result += ".-.. ";
                        break;
                    case 'M':
                    case 'm':
                        result += "-- ";
                        break;
                    case 'N':
                    case 'n':
                        result += "-. ";
                        break;
                    case 'O':
                    case 'o':
                        result += "--- ";
                        break;
                    case 'P':
                    case 'p':
                        result += ".--. ";
                        break;
                    case 'Q':
                    case 'q':
                        result += "--.- ";
                        break;
                    case 'R':
                    case 'r':
                        result += ".-. ";
                        break;
                    case 'S':
                    case 's':
                        result += "... ";
                        break;
                    case 'T':
                    case 't':
                        result += "- ";
                        break;
                    case 'U':
                    case 'u':
                        result += "..- ";
                        break;
                    case 'V':
                    case 'v':
                        result += "...- ";
                        break;
                    case 'W':
                    case 'w':
                        result += ".-- ";
                        break;
                    case 'X':
                    case 'x':
                        result += "-..- ";
                        break;
                    case 'Y':
                    case 'y':
                        result += " -.--";
                        break;
                    case 'Z':
                    case 'z':
                        result += "--.. ";
                        break;
                    case '1':
                        result += ".---- ";
                        break;
                    case '2':
                        result += "..--- ";
                        break;
                    case '3':
                        result += "...-- ";
                        break;
                    case '4':
                        result += "....- ";
                        break;
                    case '5':
                        result += "..... ";
                        break;
                    case '6':
                        result += "-.... ";
                        break;
                    case '7':
                        result += "--... ";
                        break;
                    case '8':
                        result += "---.. ";
                        break;
                    case '9':
                        result += "----. ";
                        break;
                    case '0':
                        result += "----- ";
                        break;
                    case '.':
                        result += ".-.-.- ";
                        break;
                    case ',':
                        result += "--..-- ";
                        break;
                    case '\'':
                        result += ".----. ";
                        break;
                    case ':':
                        result += "---...";
                        break;
                    case '(':
                        result += "-.--. ";
                        break;
                    case ')':
                        result += "-.--.- ";
                        break;
                    case '?':
                        result += "..--.. ";
                        break;
                    case '-':
                        result += "-....- ";
                        break;
                    case '_':
                        result += "..--.- ";
                        break;
                    case '/':
                        result += "-..-. ";
                        break;
                    case '=':
                        result += "-...- ";
                        break;
                    case '@':
                        result += ".--.-. ";
                        break;
                    case '+':
                        result += ".-.-. ";
                        break;

                    default:
                        result += "// ";
                        break;

                }
            }
            


            return result;
        }

        static void Main(string[] args) {
            Console.Write("Podaj tekst ktory chcesz zmienic na morsa: ");
            string text = Console.ReadLine();
            Console.WriteLine("{0} zapisane za pomoca morsa to: (\"//\" to spacja)\n{1}", text, Program.Convert(text));
            Console.ReadKey();

        }
    }
}
