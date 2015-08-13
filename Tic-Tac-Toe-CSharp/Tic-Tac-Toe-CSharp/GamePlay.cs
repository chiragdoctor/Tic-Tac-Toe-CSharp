using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_CSharp
{
    public class GamePlay : IGamePlay
    {
        private static readonly List<IGameLogic> Combinations =
            new List<IGameLogic>();

        public GamePlay()
        {
            Combinations.Add(new HorizontalWinState());
            Combinations.Add(new VerticalWinState());
            Combinations.Add(new DiagonalWinState());
            Combinations.Add(new DrawState());
        }

        public State GetState(List<string> cells)
        {
            if (Combinations.Any(s => s.GetState(cells) == State.Win))
                return State.Win;

            return Combinations.Any(s => s.GetState(cells) == State.Draw) ? State.Draw : State.NoState;
        }
    }

    public interface IGamePlay
    {
        State GetState(List<string> cells);
    }
}
