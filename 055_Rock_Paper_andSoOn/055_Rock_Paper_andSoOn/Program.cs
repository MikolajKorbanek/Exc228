using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _055_Rock_Paper_andSoOn {



    class Program {
        static Random rand = new Random();
        static int AiWin = 0, UserWin = 0;
        static string[] moves = { "1. Rock", "2. Scissors", "3. Spock", "4. Lizard", "5. Paper" };
        static void game(int nrToWin) {
            AiWin = 0;
            UserWin = 0;
            while (AiWin < nrToWin && UserWin < nrToWin) {
                int userMove = NextMove(), aiMove = rand.Next(1, 5);
                CheckResult(userMove, aiMove);

            }
            
        }

        static void CheckResult(int userMove, int aiMove) {
            if (userMove == 1) {
                if (aiMove == 2 || aiMove == 4) {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    UserWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();

                } else if (aiMove == 1) {
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    AiWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                }
            } else if (userMove == 2) {
                if (aiMove == 4 || aiMove == 5) {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    UserWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else if (aiMove == 2) {
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    AiWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                }

            } else if(userMove == 3) {
                if (aiMove == 1 || aiMove == 2) {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    UserWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else if (aiMove == 3) {
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    AiWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                }
            } else if(userMove == 4) {
                if (aiMove == 3 || aiMove == 5) {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    UserWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else if (aiMove == 4) {
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    AiWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                }
            } else if(userMove == 5) {
                if (aiMove == 1 || aiMove == 3) {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    UserWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else if (aiMove == 4) {
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                } else {
                    Console.WriteLine("You won! Computer choose {0}", moves[aiMove - 1]);
                    AiWin++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n{0} : {1}\n", UserWin, AiWin);
                    Console.ResetColor();
                }
            }
        }

        static public int NextMove() {
            foreach(string s in moves) {
                Console.WriteLine(s);
            }
            Console.Write("Your choose: ");
            return Int32.Parse(Console.ReadLine());
        }

        static void Main(string[] args) {
            Console.Write("Hello!\nNumber of game to win: ");
            int win = Int32.Parse(Console.ReadLine());
            game(win);
            Console.ReadKey();
        }
    }
}
