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

            string TopLeft = " ";
            string TopCenter = " ";
            string TopRight = " ";
            string MidLeft = " ";
            string MidCenter = " ";
            string MidRight = " ";
            string BottomLeft = " ";
            string BottomCenter = " ";
            string BottomRight = " ";

            Console.WriteLine("");
            Console.WriteLine($" " + TopLeft + " | " + TopCenter + " | " + TopRight + " ");
            Console.WriteLine("-----------");
            Console.WriteLine($" " + MidLeft + " | " + MidCenter + " | " + MidRight + " ");
            Console.WriteLine("-----------");
            Console.WriteLine($" " + BottomLeft + " | " + BottomCenter + " | " + BottomRight + " ");

            Console.ReadLine();
        }
    }
}
