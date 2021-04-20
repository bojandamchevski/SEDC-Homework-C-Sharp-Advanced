using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTask1.Classes
{
    public class Player
    {
        public string NickName { get; set; }
        public int GamesWon { get; set; }
        public int NumberOfGames { get; set; }

        public Player(string nickName)
        {
            NickName = nickName;
        }
        public Player()
        {

        }
    }
}
