using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Tests.Player
{
    public class when_player_receive_random_move : Player_Specs
    {
        private List<string> Cells;
        private List<string> UsedCells;
        public override void Given()
        {
            Cells = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            UsedCells = new List<string>() { "X", "O", "X", "O", "X", "X", "O", "O", "O" };
        }

        public override void When()
        {
            Result = Player.GetAvailableMoveFrom(Cells);
            MoveCount = Player.GetAvailableMoveFrom(UsedCells);
        }

        [Test]
        public void should_get_a_random_number_from_1_to_9()
        {
            AssertThatResultIsNotMoreThat9();
        }

        [Test]
        public void should_get_a_random_number_is_not_greater_than_9()
        {
            AssertThatResultIsNotMoreThat9();
        }

        [Test]
        public void should_never_return_a_string()
        {
            AssertThatResultIsNotAString();
        }

        [Test]
        public void should_always_be_between_0_to_9()
        {
            AssertThatResultIsInRangeFrom0To9();
        }

    }
}
