using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe3
{
    class Program
    {

        // ! change text (X/0) to different colors
        // ! create player 1 and player 2 class
        // ! change background color of board
        // ! have the system / save keep track of the players records PLAYER 1: 5 WINS / PLAYER 2: 3 WINS
        static void Main(string[] args)
        {
            string location;
            string playGame = "y";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       Welcome to TicTacToe!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Please enter the name of PLAYER 1:");
            Console.WriteLine();
            Player player1 = new Player();
            Console.Write("              "); player1.playerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" Please enter the name of PLAYER 2:");
            Console.WriteLine();
            Player player2 = new Player();
            Console.Write("              "); player2.playerName = Console.ReadLine();

            while(playGame.Contains("y"))
            {
                GameBoard gameBoard = new GameBoard();
                string win = "";
                int counter = 0;
                do
                {
                    

                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine($"      " + gameBoard.topLeft + " | " + gameBoard.topCenter + " | " + gameBoard.topRight + " ");
                    Console.WriteLine("     -----------");
                    Console.WriteLine($"      " + gameBoard.midLeft + " | " + gameBoard.midCenter + " | " + gameBoard.midRight + " ");
                    Console.WriteLine("     -----------");
                    Console.WriteLine($"      " + gameBoard.bottomLeft + " | " + gameBoard.bottomCenter + " | " + gameBoard.bottomRight + " ");
                    Console.WriteLine();
                    Console.WriteLine();


                    if (counter % 2 == 0)
                    {

                        Console.WriteLine($" {player1.playerName} Please enter the number of the location to place your X:");
                        location = Console.ReadLine();
                        
                        /*if (char.IsDigit(location[0]) && location.Length < 2)
                        {
                            int stringToInt = System.Convert.ToInt32(location);
                            gameBoard.PositionCheck(stringToInt);*/

                            switch (location)
                            {
                                case "1":
                                    if (gameBoard.topLeft == "1")
                                    {
                                        gameBoard.topLeft = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "2":
                                    if (gameBoard.topCenter == "2")
                                    {
                                        gameBoard.topCenter = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "3":
                                    if (gameBoard.topRight == "3")
                                    {
                                        gameBoard.topRight = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "4":
                                    if (gameBoard.midLeft == "4")
                                    {
                                        gameBoard.midLeft = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "5":
                                    if (gameBoard.midCenter == "5")
                                    {
                                        gameBoard.midCenter = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "6":
                                    if (gameBoard.midRight == "6")
                                    {
                                        gameBoard.midRight = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "7":
                                    if (gameBoard.bottomLeft == "7")
                                    {
                                        gameBoard.bottomLeft = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "8":
                                    if (gameBoard.bottomCenter == "8")
                                    {
                                        gameBoard.bottomCenter = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "9":
                                    if (gameBoard.bottomRight == "9")
                                    {
                                        gameBoard.bottomRight = "X";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid board number 1-9!");
                                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    break;
                            }

                        /*}
                        else if (location == "")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Please enter a valid number 1 - 9 please!");
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Only numbers 1 - 9 please!");
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                        }*/
                    }
                    else
                    {
                        Console.WriteLine($" {player2.playerName} please enter the number of the location to place your O:");
                        location = Console.ReadLine().ToString();

                        /*if (char.IsDigit(location[0]) && location.Length < 2)
                        {
                            int stringToInt = System.Convert.ToInt32(location);
                            gameBoard.PositionCheck(stringToInt);*/

                            switch (location)
                            {
                                case "1":
                                    if (gameBoard.topLeft == "1")
                                    {
                                        gameBoard.topLeft = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "2":
                                    if (gameBoard.topCenter == "2")
                                    {
                                        gameBoard.topCenter = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "3":
                                    if (gameBoard.topRight == "3")
                                    {
                                        gameBoard.topRight = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "4":
                                    if (gameBoard.midLeft == "4")
                                    {
                                        gameBoard.midLeft = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "5":
                                    if (gameBoard.midCenter == "5")
                                    {
                                        gameBoard.midCenter = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "6":
                                    if (gameBoard.midRight == "6")
                                    {
                                        gameBoard.midRight = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "7":
                                    if (gameBoard.bottomLeft == "7")
                                    {
                                        gameBoard.bottomLeft = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "8":
                                    if (gameBoard.bottomCenter == "8")
                                    {
                                        gameBoard.bottomCenter = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                case "9":
                                    if (gameBoard.bottomRight == "9")
                                    {
                                        gameBoard.bottomRight = "O";
                                        counter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine(" Please choose an unused space!");
                                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    }

                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid board number 1-9!");
                                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                                    break;
                            }
                        /*}
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Only numbers 1 - 9 please!");
                            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                        }*/
                    }

                    if (gameBoard.topLeft == gameBoard.topCenter && gameBoard.topCenter == gameBoard.topRight) // top row
                    {
                        win = gameBoard.topLeft;
                    }
                    else if (gameBoard.midLeft == gameBoard.midCenter && gameBoard.midCenter == gameBoard.midRight) //middle row
                    {
                        win = gameBoard.midLeft;
                    }
                    else if (gameBoard.bottomLeft == gameBoard.bottomCenter && gameBoard.bottomCenter == gameBoard.bottomRight) // bottom row
                    {
                        win = gameBoard.bottomLeft;
                    }
                    else if (gameBoard.topLeft == gameBoard.midLeft && gameBoard.midLeft == gameBoard.bottomLeft) // Left column
                    {
                        win = gameBoard.topLeft;
                    }
                    else if (gameBoard.topCenter == gameBoard.midCenter && gameBoard.midCenter == gameBoard.bottomCenter) // center column
                    {
                        win = gameBoard.topCenter;
                    }
                    else if (gameBoard.topRight == gameBoard.midRight && gameBoard.midRight == gameBoard.bottomRight) // right column
                    {
                        win = gameBoard.topRight;
                    }
                    else if (gameBoard.topLeft == gameBoard.midCenter && gameBoard.midCenter == gameBoard.bottomRight) // diagonal tl to br
                    {
                        win = gameBoard.topLeft;
                    }
                    else if (gameBoard.topRight == gameBoard.midCenter && gameBoard.midCenter == gameBoard.bottomLeft) // diagonal tr to bl
                    {
                        win = gameBoard.topRight;
                    }
                    else if (counter == 9)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("     Draw, nobody wins!");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Win Totals:   {player1.winCount} - {player1.playerName}");
                        Console.WriteLine($"               {player2.winCount} - {player2.playerName}");
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1.5));
                        win = "0";
                        //Environment.Exit(0);
                    }
                }
                while (win == "");
                Console.Clear();
                if (win == "X")
                {
                    player1.winCount++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"     {player1.playerName} wins!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($" Win Totals:   {player1.winCount} - {player1.playerName}");
                    Console.WriteLine($"               {player2.winCount} - {player2.playerName}");



                }
                else if (win == "O")
                {
                    player2.winCount++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"     {player2.playerName} wins!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($" Win Totals:   {player1.winCount} - {player1.playerName}");
                    Console.WriteLine($"               {player2.winCount} - {player2.playerName}");
                }
                playGame = "";
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                while (playGame.Contains(""))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" Would both of you like to play another round? (y/n)");
                    Console.WriteLine();
                    playGame = Console.ReadLine().ToLower();

                    if (playGame.Contains("y")) { break; }
                    else if (playGame.Contains("n")) { break; }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Please enter a y for yes or a n for no!");
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                        playGame = "";
                    }
                }

            }
        }
    }
}
