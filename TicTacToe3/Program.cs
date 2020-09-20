using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe3
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard();
            string playGame = "y";
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("       Welcome to "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("Tic"); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Tac"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Toe!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Please enter the name of PLAYER 1:  ");
            Player player1 = new Player();
            Console.ForegroundColor = ConsoleColor.Yellow; player1.playerName = Console.ReadLine(); Console.ResetColor();
            Console.WriteLine();
            Console.Write(" Please enter the name of PLAYER 2:  ");
            Player player2 = new Player();
            Console.ForegroundColor = ConsoleColor.Yellow; player2.playerName = Console.ReadLine(); Console.ResetColor();
            while (playGame.Contains("y"))
            {
                string win = "";
                do
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.Write("             "); Console.BackgroundColor = ConsoleColor.White;Console.Write(" "); Console.ForegroundColor = ConsoleColor.Black; Console.Write(gameBoard.topLeft); Console.ResetColor(); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.Write(" | "); /*Console.ForegroundColor = ConsoleColor;*/ Console.Write(gameBoard.topCenter); Console.ResetColor(); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.Write(" | "); /*Console.ForegroundColor = ConsoleColor;*/ Console.Write(gameBoard.topRight); Console.ResetColor(); Console.BackgroundColor = ConsoleColor.White; Console.WriteLine(" ");
                    Console.ResetColor();
                    Console.Write("             "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("-----------");
                    Console.ResetColor();
                    Console.Write("             "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine($" " + gameBoard.midLeft + " | " + gameBoard.midCenter + " | " + gameBoard.midRight + " ");
                    Console.ResetColor();
                    Console.Write("             "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("-----------");
                    Console.ResetColor();
                    Console.Write("             "); Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine($" " + gameBoard.bottomLeft + " | " + gameBoard.bottomCenter + " | " + gameBoard.bottomRight + " ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    if (gameBoard.counter % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($" {player1.playerName}"); Console.ResetColor(); Console.WriteLine(", please enter the number of the");
                        Console.Write(" location to place your "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("X"); Console.ResetColor(); Console.Write(": ");
                        gameBoard.location = Console.ReadLine();
                        gameBoard.SwitchCaseX();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.Write($" {player2.playerName}"); Console.ResetColor(); Console.WriteLine(", please enter the number of the");
                        Console.Write(" location to place your "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("O"); Console.ResetColor(); Console.Write(": ");
                        gameBoard.location = Console.ReadLine();
                        gameBoard.SwitchCaseO();
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
                    else if (gameBoard.counter == 9)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("     Draw, nobody wins!"); Console.ResetColor();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Win Totals:   {player1.winCount} - {player1.playerName}");
                        Console.WriteLine($"               {player2.winCount} - {player2.playerName}");
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                        win = "0";
                    }
                }
                while (win == "");
                Console.Clear();
                if (win == "X")
                {
                    player1.winCount++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"     {player1.playerName} wins!"); Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Win Totals:   "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(player1.winCount); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($" - {player1.playerName}"); Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("               "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(player2.winCount); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($" - {player2.playerName}"); Console.ResetColor();
                }
                else if (win == "O")
                {
                    player2.winCount++;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"     {player2.playerName} wins!"); Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(" Win Totals:   "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(player1.winCount); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($" - {player1.playerName}"); Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("               "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(player2.winCount); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($" - {player2.playerName}"); Console.ResetColor();
                }
                playGame = "";
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2.5));
                while (playGame.Contains(""))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" Would both of you like to play another");
                    Console.Write(" round? (y/n):  "); playGame = Console.ReadLine().ToLower();
                    if (playGame.Contains("y")) { break; }
                    else if (playGame.Contains("n")) { break; }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(" Please enter:  y for YES");
                        Console.WriteLine();
                        Console.WriteLine("                n for NO"); Console.ResetColor();
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1.5));
                        playGame = "";
                    }
                }
                gameBoard.GameBoardReset();
            }
        }
    }
}
