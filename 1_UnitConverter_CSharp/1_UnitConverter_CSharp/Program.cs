using System;

namespace _1_UnitConverter_CSharp
{
    class UnitConverter
    {
        String option ="";
       
        public UnitConverter() {
            do {
                String value = "";
                Console.WriteLine("1. M/KM");
                Console.WriteLine("2. CM/M");
                Console.WriteLine("3. KG/G");
                Console.WriteLine("4. Exit");
                Console.Write("Wybierz opcje: ");
                option = Console.ReadLine();

                switch (int.Parse(option)) {
                    case 1:
                        Console.Write("Podaj wartosc w metrach: ");
                        value = Console.ReadLine();
                        Console.WriteLine(float.Parse(option) / 1000);
                        Console.WriteLine("Wcisnij przycisk");
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Podaj wartosc w centymetrach: ");
                        value = Console.ReadLine();
                        Console.WriteLine(float.Parse(option) / 100);
                        Console.WriteLine("Wcisnij przycisk");
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Podaj wartosc w kilogramach: ");
                        value = Console.ReadLine();
                        Console.WriteLine(float.Parse(option) * 1000);
                        Console.WriteLine("Wcisnij przycisk");
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                }

            }while (int.Parse(option) != 4);
        }


        static void Main(string[] args)
        {
            new UnitConverter();
        }
    }
}
