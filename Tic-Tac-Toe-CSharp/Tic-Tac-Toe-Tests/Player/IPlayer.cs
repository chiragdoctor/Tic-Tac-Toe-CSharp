using System.Collections.Generic;

namespace Tic_Tac_Toe_Tests.Player
{
    public interface IPlayer
    {
        int GetAvailableMoveFrom(List<string> usedCells);
        void Play(List<string> cells, int move, int player);
        List<string> SetMove(List<string> cells, int move, int player);
        bool PositionIsOccupied(IList<string> cells, int move);
    }
}