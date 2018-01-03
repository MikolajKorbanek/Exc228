using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_BMICalculator_CSharp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Witaj w kalkulatorze BMI!");
            for ( ; ; ) {
                int wzrost = 0;
                double waga = 0;
                Console.Write("Podaj swoj wzrost (w cm): ");
                try {
                    wzrost = Int32.Parse(Console.ReadLine());
                    if (wzrost < 50) throw new Exception();
                } catch (Exception e) {
                    Console.WriteLine("\n\nKogo probujesz oszukac?\n");
                    Console.WriteLine("========================");
                    Console.WriteLine("===No to jeszcze raz!===");
                    Console.WriteLine("========================\n\n");
                    continue;
                }
                Console.Write("Podaj swoja wage (w kg): ");
                try {
                    waga = Double.Parse(Console.ReadLine());
                } catch (Exception e) {
                    Console.WriteLine("\n\nKogo probujesz oszukac?\n");
                    Console.WriteLine("========================");
                    Console.WriteLine("===No to jeszcze raz!===");
                    Console.WriteLine("========================\n\n");
                    continue;
                }

                Console.WriteLine(BMI_RESULT(wzrost, waga));

                Console.Write("Jesli chcesz wyjsc wpisz tutaj 0: ");
                try {
                    int koniec = Int32.Parse(Console.ReadLine());
                    if (koniec == 0) {
                        break;
                    }
                } catch(Exception e) {
                    Console.WriteLine("\n\nNawet teraz?\n");
                }
                Console.WriteLine("\n\n\n========================");
                Console.WriteLine("===No to jeszcze raz!===");
                Console.WriteLine("========================\n\n");

            }
        }

        static public string BMI_RESULT(double wzrost, double waga) {
            wzrost /= 100;
            double BMI = (waga / (wzrost * wzrost));
            string status;

            

            if(BMI <= 18) {
                status = "Niedowaga";
            } else if (BMI <= 24) {
                status = "Norma";
            } else if(BMI <= 29) {
                status = "Nadwaga";
            } else if(BMI <= 39) {
                status = "Otylosc";
            } else {
                status = "Powazna otylosc";
            }

            return String.Format("Twoje BMI to: {0}. Wedlug statystyki status twojej wagi to: {1}.", BMI, status);
        }
        
        


    }
}
