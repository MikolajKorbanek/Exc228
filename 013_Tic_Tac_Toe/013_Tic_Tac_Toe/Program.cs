using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Tic_Tac_Toe {
    static class Program {

        static string player1 = "", player2 = "";
        static int gamesToWin = 0, cirPoint = 0, exPoint = 0;
        static int whoStart = (int)Math.Round(new Random().NextDouble());
        static int nextMove = whoStart;
        static char[][] board =
                        {
                        new char[] {'1','|','2','|','3'},
                        new char[] {'-','-','-','-','-'},
                        new char[] {'4','|','5','|','6'},
                        new char[] {'-','-','-','-','-'},
                        new char[] {'7','|','8','|','9'}
                        };

        public static void game(string p1,string p2,int nmbOfGames) {
            player1 = p1;
            player2 = p2;
            gamesToWin = nmbOfGames;
                if (whoStart == 1) Console.WriteLine("Zaczyna {0} grajac \"0\"", p1);
                else Console.WriteLine("Zaczyna {0} grajac \"X\"", p2);
            while (cirPoint < gamesToWin && exPoint < gamesToWin){
                DrawBoard();
                MakeMove(nextMove);
                if (CheckResult())clearBorad();
                DrawScore();
            }
        }

        public static Boolean CheckResult() {
            Boolean result = false;
            int count = 0;
            for(int i = 0,circle=0,ex=0; i < board.Length; i += 2) {
                circle = 0;
                ex = 0;
                for (int j =0; j < board[0].Length; j+= 2) {
                    if (board[i][j] == 'O') {
                        circle++;
                        count++;
                    } else if (board[i][j] == 'X') {
                        ex++;
                        count++;
                    }
                }
                if(ex == 3 || circle == 3) {
                    if (circle > ex) cirPoint++;
                    else exPoint++;
                    return true;
                }  
            }
            for (int i = 0, circle = 0, ex = 0; i < board.Length; i += 2) {
                circle = 0;
                ex = 0;
                for (int j = 0; j < board[0].Length; j += 2) {
                    if (board[j][i] == 'O') {
                        circle++;
                        count++;
                    } else if (board[j][i] == 'X') {
                        count++;
                        ex++;
                    }
                }
                if (ex == 3 || circle == 3) {
                    if (circle > ex) cirPoint++;
                    else exPoint++;
                    return true;
                }
            }
            if(board[0][0] == 'X') {
                if(board[2][2] == 'X') {
                    if (board[4][4] == 'X') {
                        exPoint++;
                        return true;
                    }
                }
            }
            if (board[0][4] == 'X') {
                if (board[2][2] == 'X') {
                    if (board[4][0] == 'X') {
                        exPoint++;
                        return true;
                    }
                }
            }
            if (board[0][0] == 'O') {
                if (board[2][2] == 'O') {
                    if (board[4][4] == 'O') {
                        cirPoint++;
                        return true;
                    }
                }
            }
            if (board[0][4] == 'O') {
                if (board[2][2] == 'O') {
                    if (board[4][0] == 'O') {
                        cirPoint++;
                        return true;
                    }
                }
            }


           /* Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(count + "");
            Console.ResetColor();*/
            if (count == 18) return true;

            return result;
        }

        public static void MakeMove(int player) {
            int move = 0;
            Boolean status =false;
            Boolean moveDone = false;
            char value;
            if (player == 1) Console.WriteLine("\nGracz {0} ma ruch", player1);
            else Console.WriteLine("\nGracz {0} ma ruch", player2);
            while (!moveDone) {
                status = false;
                while (!status) {
                    Console.Write("Jakie pole: ");
                    status = Int32.TryParse(Console.ReadLine(), out move);
                }
                if (player == 1) value = 'O';
                else value = 'X';
                switch (move) {
                    case 1:
                        if (board[0][0] == ' ') {
                            board[0][0] = value;
                            moveDone = true;
                        }
                        break;
                    case 2:
                        if (board[0][2] == ' ') {
                            board[0][2] = value;
                            moveDone = true;
                        }
                        break;
                    case 3:
                        if(board[0][4] == ' ') {
                            board[0][4] = value;
                            moveDone = true;
                        }
                        break;
                    case 4:
                        if (board[2][0] == ' ') {
                            board[2][0] = value;
                            moveDone = true;
                        }
                        break;
                    case 5:
                        if(board[2][2] == ' ') {
                            board[2][2] = value;
                            moveDone = true;
                        }
                        
                        break;
                    case 6:
                        if(board[2][4]==' ') {
                            board[2][4] = value;
                            moveDone = true;
                        }
                        break;
                    case 7:
                        if (board[4][0] == ' ') {
                            board[4][0] = value;
                            moveDone = true;
                        }
                        break;
                    case 8:
                        if (board[4][2] == ' ') {
                            board[4][2] = value;
                            moveDone = true;
                        }
                        break;
                    case 9:
                        if (board[4][4] == ' ') {
                            board[4][4] = value;
                            moveDone = true;
                        }
                        break;
                }
            }
            if (nextMove == 1) nextMove = 0;
            else nextMove = 1;
        }

        public static void DrawBoard() {
            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[0].Length; j++)
                    Console.Write(board[i][j]);
                Console.WriteLine("");
            }
        }

        public static void DrawScore() {
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor.Magenta);
            Console.WriteLine("{0} {1}:{2} {3}\n",player1,cirPoint,exPoint,player2);
            Console.ResetColor();
        }
        public static void clearBorad() {
            board = new char[][]{
                     new char[] { ' ', '|', ' ', '|', ' ' },
                     new char[] { '-', '-', '-', '-', '-' },
                     new char[] { ' ', '|', ' ', '|', ' ' },
                     new char[] { '-', '-', '-', '-', '-' },
                     new char[] { ' ', '|', ' ', '|', ' ' }
                     };
        }

        static void Main(string[] args) {
            string p1, p2;
            int games;
            Boolean status;
            Console.WriteLine("Hej, kto dzis gra?");
            Console.Write("Nick/Imie pierwszego gracza: ");
            p1 = Console.ReadLine();
            Console.Write("Nick/Imie drugiego gracza: ");
            p2 = Console.ReadLine();
            Console.Write("A gramy do: ");
            status = Int32.TryParse(Console.ReadLine(),out games);

            if (status){
                Console.WriteLine("Kazde pole ma przypisana wartosc: ");
                DrawBoard();
                clearBorad();
                Console.WriteLine("Wybierasz pole wpisujac numerek");
                Console.WriteLine("Jesli mozemy zaczynac wcisnij enter");
                Console.ReadKey();
                Console.Clear();
                game(p1, p2, games);
            }
            else Console.WriteLine("peszek");
            Console.ReadKey();
        }
    }
}
