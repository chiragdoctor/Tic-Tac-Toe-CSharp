using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe_Tests.Player
{
    public class AI : IPlayer
    {
        private readonly string X = "X";
        private readonly string O = "O";

        public int GetAvailableMoveFrom(List<string> cells)
        {
            var random = new Random();
            var moves = RemainingMoves(cells);
            return moves.OrderBy(m => random.Next()).FirstOrDefault();
        }

        private static IEnumerable<int> RemainingMoves(IEnumerable<string> cells)
        {
            int move;
            return cells.Where(c => int.TryParse(c, out move)).Select(int.Parse).ToList();
        }

        public void Play(List<string> cells, int move, int player)
        {
            if (PositionIsOccupied(cells, move)) return;
            SetMove(cells, move, player);
        }

        public List<string> SetMove(List<string> cells, int move, int player)
        {
            if (player % 2 == 0) // Computer 2
            {
                cells[move] = O;
            }
            else
            {
                cells[move] = X;
            }
            return cells;
        }

        public bool PositionIsOccupied(IList<string> cells, int move)
        {
            return cells[move] == X || cells[move] == O;
        }

    }
}