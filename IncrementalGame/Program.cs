using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementalGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("1");
            player1.IsPlayerTurn = true;
            Player player2 = new Player("2");

            Game game = new Game();
            game.PlayGame(player1, player2);
        }
    }
}
