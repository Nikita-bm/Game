using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementalGame
{
    public class Player
    {
        public Player(string playerName)
        {
            this.Name = playerName;
        }

        private string Name;
        public bool IsPlayerTurn { get; set; }


    }
}
