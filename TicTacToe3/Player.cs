﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe3
{
    public class Player
    {
        public string playerName; // Class attribute
        public int winCount = 0;

        public Player()
        {

        }

        public Player(string aPlayer, int aWinCount) // ! Blueprint for data types in 
        {
            playerName = aPlayer;
            winCount = aWinCount;
        }

        
    }
}
