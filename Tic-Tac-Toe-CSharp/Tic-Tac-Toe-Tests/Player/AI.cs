﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Tic_Tac_Toe_Tests.Player
{
    public class AI : IPlayer
    {
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
    }
}