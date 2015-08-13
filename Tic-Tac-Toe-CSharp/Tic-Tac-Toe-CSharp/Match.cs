using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe_CSharp
{
    public interface IMatch
    {
        State DetermineWinState(List<string> cells, IGamePlay gamePlay);
        void Result(State matchState, int player);
    }

    public class Match : IMatch
    {
        public State DetermineWinState(List<string> cells, IGamePlay gamePlay)
        {

            return gamePlay.GetState(cells);

        }

        public void Result(State matchState, int player)
        {
            if (matchState == State.Win)
            {
                Console.WriteLine("Computer {0} has won", (player % 2) + 1);
            }

            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
