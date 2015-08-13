using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Tests.GameLogic
{
    public class when_player_plays_determine_horizontal_win_condition : game_rules_specs
    {
        public override void Given()
        {
            Column1 = new List<string>() { "0", "X", "X", "X", "4", "5", "6", "7", "8", "9" }; ;
            Column2 = new List<string>() { "0", "1", "2", "3", "X", "X", "X", "7", "8", "9" }; ;
            Column3 = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "X", "X", "X" }; ;
            NotMatching = new List<string>() { "0", "1", "2", "X", "4", "5", "6", "7", "X", "X" }; ;
        }

        public override void When()
        {
            State = HorizontalCondition.GetState(Column1);
        }

        [Test]
        public void check_when_input_doesnot_match_condition()
        {
            State = HorizontalCondition.GetState(NotMatching);
            AssertThatStateIsNoState();
        }

        [Test]
        public void check_if_it_matches_for_condition1_as_winner()
        {
            AssertThatStateIsWin();
        }

        [Test]
        public void check_if_it_matches_for_condition2_as_winner()
        {
            State = HorizontalCondition.GetState(Column2);
            AssertThatStateIsWin();
        }

        [Test]
        public void check_if_it_matches_for_condition3_as_winner()
        {
            State = HorizontalCondition.GetState(Column3);
            AssertThatStateIsWin();
        }
    }
}
