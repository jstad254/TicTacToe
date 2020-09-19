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

        public GameBoard(string tL, string tC, string tR, string mL, string mC, string mR, string bL, string bC, string bR)
        {
            topLeft = tL;
            topCenter = tC;
            topRight = tR;
            midLeft = mL;
            midCenter = mC;
            midRight = mR;
            bottomLeft = bL;
            bottomCenter = bC;
            bottomRight = bR;
        }

        public void PositionCheck(int stringToInt)
        {
            if(stringToInt < 1 || stringToInt > 9)
            {
                Console.WriteLine("Please enter a valid number on the board!");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
        public int ThisExampleMethod()
        {
            int res = myVar + MyProperty;
            return res;

        }

    }
}
