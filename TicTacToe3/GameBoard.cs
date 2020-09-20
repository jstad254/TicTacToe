using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe3
{
    class GameBoard
    {
        public string topLeft { get; set; } = "1";
        public string topCenter { get; set; } = "2";
        public string topRight { get; set; } = "3";
        public string midLeft { get; set; } = "4";
        public string midCenter { get; set; } = "5";
        public string midRight { get; set; } = "6";
        public string bottomLeft { get; set; } = "7";
        public string bottomCenter { get; set; } = "8";
        public string bottomRight { get; set; } = "9";

        public string location { get; set; }
        public int counter { get; set; } = 0;

        private int myVar;

        public int MyProperty
        {
            get { if (myVar > 9)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return myVar;
            }


        }
        
        public GameBoard()
        {

        }
        
        public void GameBoardReset()
        {
            topLeft = "1";
            topCenter = "2";
            topRight = "3";
            midLeft = "4";
            midCenter = "5";
            midRight = "6";
            bottomLeft = "7";
            bottomCenter = "8";
            bottomRight = "9";
            counter = 0;
        }
        public void SwitchCaseX()
        {
            switch (location)
            {
                case "1":
                    if (topLeft == "1")
                    {
                        topLeft = "X";

                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "2":
                    if (topCenter == "2")
                    {
                        topCenter = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "3":
                    if (topRight == "3")
                    {
                        topRight = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "4":
                    if (midLeft == "4")
                    {
                        midLeft = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "5":
                    if (midCenter == "5")
                    {
                        midCenter = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "6":
                    if (midRight == "6")
                    {
                        midRight = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "7":
                    if (bottomLeft == "7")
                    {
                        bottomLeft = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "8":
                    if (bottomCenter == "8")
                    {
                        bottomCenter = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "9":
                    if (bottomRight == "9")
                    {
                        bottomRight = "X";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Please enter a valid board number 1-9!"); Console.ResetColor();
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    break;
            }
        }
        public void SwitchCaseO()
        {
            switch (location)
            {
                case "1":
                    if (topLeft == "1")
                    {
                        topLeft = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "2":
                    if (topCenter == "2")
                    {
                        topCenter = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "3":
                    if (topRight == "3")
                    {
                        topRight = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "4":
                    if (midLeft == "4")
                    {
                        midLeft = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "5":
                    if (midCenter == "5")
                    {
                        midCenter = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "6":
                    if (midRight == "6")
                    {
                        midRight = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "7":
                    if (bottomLeft == "7")
                    {
                        bottomLeft = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "8":
                    if (bottomCenter == "8")
                    {
                        bottomCenter = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                case "9":
                    if (bottomRight == "9")
                    {
                        bottomRight = "O";
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break;
                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Please enter a valid board number 1-9!"); Console.ResetColor();
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    break;
            }
        }


        /*Future game color updates
        bColor = ConsoleColor.Black;
        xColor = ConsoleColor.Green;
        oColor = ConsoleColor.Red;
        normColor = ConsoleColor.Yellow;
        warnColor = ConsoleColor.Magenta;*/

        /*Start to consolidate switches for X and O
        public void gameBoardPlay(playerXorO(gb.counter%2, location)
        {
            switch location
                case "1":
                if
                    {
                    topLeft == "1"{
                        topLeft = playerXorO;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("   Please choose an unused space!"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    }

                    break; */

    }
}