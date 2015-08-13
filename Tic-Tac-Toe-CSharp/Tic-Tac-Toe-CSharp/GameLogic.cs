using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe_Tests.GameLogic
{
    public interface IGameLogic
    {
        State GetState(List<string> cells);
    }

    public class HorizontalWinState : IGameLogic
    {
        public State GetState(List<string> cells)
        {
            if (cells[1] == cells[2] && cells[2] == cells[3] || cells[4] == cells[5] && cells[5] == cells[6] || cells[7] == cells[8] && cells[8] == cells[9])
                return State.Win;
            return State.NoState;
        }
    }

    public class DiagonalWinState : IGameLogic
    {
        public State GetState(List<string> cells)
        {
            if (cells[1] == cells[5] && cells[5] == cells[9] || cells[3] == cells[5] && cells[5] == cells[7])
                return State.Win;
            return State.NoState;
        }
    }

    public class VerticalWinState : IGameLogic
    {
        public State GetState(List<string> cells)
        {
            if (cells[1] == cells[4] && cells[4] == cells[7] || cells[2] == cells[5] && cells[5] == cells[8] || cells[3] == cells[6] && cells[6] == cells[9])
                return State.Win;
            return State.NoState;
        }
    }

    public class DrawState : IGameLogic
    {
        public State GetState(List<string> cells)
        {
            if (cells[1] != "1" && cells[2] != "2" && cells[3] != "3" && cells[4] != "4" && cells[5] != "5" && cells[6] != "6" &&
                     cells[7] != "7" && cells[8] != "8" && cells[9] != "9")
                return State.Draw;
            return State.NoState;
        }
    }
}