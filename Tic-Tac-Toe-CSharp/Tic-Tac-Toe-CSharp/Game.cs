using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_CSharp
{
    public class Game
    {
        private static readonly List<string> cells = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static int player = 1;
        private static State match = 0;
        private IPlayer _player;
        private IMatch _match;
        private IGamePlay _gamePlay;
        public Game(IPlayer player, IMatch match, IGamePlay gamePlay)
        {
            _player = player;
            _match = match;
            _gamePlay = gamePlay;
        }

        public void Execute()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n");
                Board.Create(cells);

                var move = _player.GetAvailableMoveFrom(cells);

                _player.Play(cells, move, player);

                match = _match.DetermineWinState(cells, _gamePlay);

                player++;

            } while (match != State.Win && match != State.Draw);

            Console.Clear();
            Board.Create(cells);
            Console.WriteLine("\n");

            _match.Result(match, player);
            Console.ReadLine();


            Console.Write("Wanna Rematch: (y/n)? ");
            var rematch = Console.ReadLine();

            if (rematch.ToString() == "y")
            {
                new Game(new AI(), new Match(), new GamePlay()).Execute();
            }

        }
    }
}
