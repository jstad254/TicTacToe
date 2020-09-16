using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {

            string player1, player2, location;
            int counter = 0;
            string win = "";
            string topLeft = "1";
            string topCenter = "2";
            string topRight = "3";
            string midLeft = "4";
            string midCenter = "5";
            string midRight = "6";
            string bottomLeft = "7";
            string bottomCenter = "8";
            string bottomRight = "9";






            Console.WriteLine("Please enter the name of player 1:");
            player1 = Console.ReadLine();
            Console.WriteLine("Please enter the name of player 2:");
            player2 = Console.ReadLine();



            do
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($" " + topLeft + " | " + topCenter + " | " + topRight + " ");
                Console.WriteLine("-----------");
                Console.WriteLine($" " + midLeft + " | " + midCenter + " | " + midRight + " ");
                Console.WriteLine("-----------");
                Console.WriteLine($" " + bottomLeft + " | " + bottomCenter + " | " + bottomRight + " ");

                if (counter % 2 == 0)
                {

                    Console.WriteLine($"{player1} please enter the number of the location you would like to place your X:");
                    location = Console.ReadLine();

                    if (location == "1")
                    {
                        if (topLeft == "1")
                        {
                            topLeft = "X";
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
                        if (topCenter == "2")
                        {
                            topCenter = "X";
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
                        if (topRight == "3")
                        {
                            topRight = "X";
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
                        if (midLeft == "4")
                        {
                            midLeft = "X";
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
                        if (midCenter == "5")
                        {
                            midCenter = "X";
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
                        if (midRight == "6")
                        {
                            midRight = "X";
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
                        if (bottomLeft == "7")
                        {
                            bottomLeft = "X";
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
                        if (bottomCenter == "8")
                        {
                            bottomCenter = "X";
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
                        if (bottomRight == "9")
                        {
                            bottomRight = "X";
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
                    Console.WriteLine($"{player2} please enter the number of the location you would like to place your O:");
                    location = Console.ReadLine();

                    if (location == "1")
                    {
                        if (topLeft == "1")
                        {
                            topLeft = "O";
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
                        if (topCenter == "2")
                        {
                            topCenter = "O";
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
                        if (topRight == "3")
                        {
                            topRight = "O";
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
                        if (midLeft == "4")
                        {
                            midLeft = "O";
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
                        if (midCenter == "5")
                        {
                            midCenter = "O";
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
                        if (midRight == "6")
                        {
                            midRight = "O";
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
                        if (bottomLeft == "7")
                        {
                            bottomLeft = "O";
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
                        if (bottomCenter == "8")
                        {
                            bottomCenter = "O";
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
                        if (bottomRight == "9")
                        {
                            bottomRight = "O";
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Please choose an unused space!");
                            Console.ReadLine();
                        }
                    }
                }
                if(topLeft == topCenter && topCenter == topRight) // top row
                {
                    win = topLeft;
                }
                else if (midLeft == midCenter && midCenter == midRight) //middle row
                {
                    win = midLeft;
                }
                else if (bottomLeft == bottomCenter && midCenter == bottomRight) // bottom row
                {
                    win = bottomLeft;
                }
                else if (topLeft == midLeft && midLeft == bottomLeft) // Left column
                {
                    win = topLeft;
                }
                else if (topCenter == midCenter && midCenter == bottomCenter) // center column
                {
                    win = topCenter;
                }
                else if (topRight == midRight && midRight == bottomRight) // right column
                {
                    win = topRight;
                }
                else if (topLeft == midCenter && midCenter == bottomRight) // diagonal tl to br
                {
                    win = topLeft;
                }
                else if (topRight == midCenter && midCenter == bottomLeft) // diagonal tr to bl
                {
                    win = topRight;
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
           if(win == "X")
            {
                Console.WriteLine($"{player1} wins!");
            }
            else if (win == "O")
            {
                Console.WriteLine($"{player2} wins!");
            }
           

            Console.ReadLine();
        }
    }
}
