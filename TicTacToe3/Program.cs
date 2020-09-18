using System;
using System.Collections.Generic;
using System.Linq;
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
            GameBoard gameBoard = new GameBoard();
            

            string location; 
            int counter = 0;
            string win = "";
            

            Console.WriteLine("Please enter the name of player 1:");
            Player player1 = new Player();
            player1.playerName = Console.ReadLine();
            player1.winCount = 0;
            Console.WriteLine("Please enter the name of player 2:");
            Player player2 = new Player();
            player2.playerName = Console.ReadLine();
            player2.winCount = 0;

            //Console.WriteLine(player1.playerName);
           // Console.WriteLine(player2.playerName);
            //Console.ReadLine();


            do
            {
               

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($" " + gameBoard.topLeft + " | " + gameBoard.topCenter + " | " + gameBoard.topRight + " ");
                Console.WriteLine("-----------");
                Console.WriteLine($" " + gameBoard.midLeft + " | " + gameBoard.midCenter + " | " + gameBoard.midRight + " ");
                Console.WriteLine("-----------");
                Console.WriteLine($" " + gameBoard.bottomLeft + " | " + gameBoard.bottomCenter + " | " + gameBoard.bottomRight + " ");

                if (counter % 2 == 0)
                {

                    Console.WriteLine($"{player1.playerName} please enter the number of the location you would like to place your X:");
                    location = Console.ReadLine();
                    int stringToInt = System.Convert.ToInt32(location);
                    gameBoard.PositionCheck(stringToInt);
                    
                    if (location == "1")
                    {
                        if (gameBoard.topLeft == "1")
                        {
                            gameBoard.topLeft = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "2")
                    {
                        if (gameBoard.topCenter == "2")
                        {
                            gameBoard.topCenter = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "3")
                    {
                        if (gameBoard.topRight == "3")
                        {
                            gameBoard.topRight = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "4")
                    {
                        if (gameBoard.midLeft == "4")
                        {
                            gameBoard.midLeft = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "5")
                    {
                        if (gameBoard.midCenter == "5")
                        {
                            gameBoard.midCenter = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "6")
                    {
                        if (gameBoard.midRight == "6")
                        {
                            gameBoard.midRight = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "7")
                    {
                        if (gameBoard.bottomLeft == "7")
                        {
                            gameBoard.bottomLeft = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "8")
                    {
                        if (gameBoard.bottomCenter == "8")
                        {
                            gameBoard.bottomCenter = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "9")
                    {
                        if (gameBoard.bottomRight == "9")
                        {
                            gameBoard.bottomRight = "X";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{player2.playerName} please enter the number of the location you would like to place your O:");
                    location = Console.ReadLine();

                    if (location == "1")
                    {
                        if (gameBoard.topLeft == "1")
                        {
                            gameBoard.topLeft = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "2")
                    {
                        if (gameBoard.topCenter == "2")
                        {
                            gameBoard.topCenter = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "3")
                    {
                        if (gameBoard.topRight == "3")
                        {
                            gameBoard.topRight = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "4")
                    {
                        if (gameBoard.midLeft == "4")
                        {
                            gameBoard.midLeft = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "5")
                    {
                        if (gameBoard.midCenter == "5")
                        {
                            gameBoard.midCenter = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "6")
                    {
                        if (gameBoard.midRight == "6")
                        {
                            gameBoard.midRight = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "7")
                    {
                        if (gameBoard.bottomLeft == "7")
                        {
                            gameBoard.bottomLeft = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "8")
                    {
                        if (gameBoard.bottomCenter == "8")
                        {
                            gameBoard.bottomCenter = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                    else if (location == "9")
                    {
                        if (gameBoard.bottomRight == "9")
                        {
                            gameBoard.bottomRight = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
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
                    Console.WriteLine("Draw, nobody wins!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            while (win == "");
            Console.Clear();
            if (win == "X")
            {
                Console.WriteLine($"{player1.playerName} wins!");
            }
            else if (win == "O")
            {
                Console.WriteLine($"{player2.playerName} wins!");
            }


            Console.ReadLine();
        }
    }
}
