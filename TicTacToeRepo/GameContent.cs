using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeRepo
{
    public class GameContent
    {
        // POCO

        string Player1 { get; set; } // Property
        string Player2 { get; set; } // Property
        string Location { get; set; } // Property
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



    }
}
