using NUnit.Framework;
using System.Collections.Generic;

namespace Tic_Tac_Toe_Tests.Player
{
    public class when_player_plays_his_turn : Player_Specs
    {
        protected List<string> Cells;
        protected int Move;
        protected List<string> ResultCells;

        public override void Given()
        {
            Cells = new List<string>() { "0", "1", "O", "3", "X", "5", "6", "7", "8", "9" };
            Move = 3;
            ResultCells = new List<string>();
        }

        public override void When()
        {
            IsPositionOccupied = Player.PositionIsOccupied(Cells, Move);
            ResultCells = Player.SetMove(Cells, Move, 2);
        }

        [Test]
        public void check_if_that_perticular_move_is_available()
        {
            AssertIf3IsOccupiedForPlay();
        }

        [Test]
        public void check_if_3_position_is_set_for_any_player()
        {
            Assert.That(ResultCells[3], Is.EqualTo("O"));
        }
    }
}
