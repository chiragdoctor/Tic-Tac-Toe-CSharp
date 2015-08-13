using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Tests.GameLogic
{
    public class when_player_plays_determine_diognal_win_conditions : game_rules_specs
    {
        public override void Given()
        {
            Column1 = new List<string>() { "0", "X", "2", "3", "4", "X", "6", "7", "8", "X" };
            Column2 = new List<string>() { "0", "1", "2", "O", "4", "O", "6", "O", "8", "9" };
            NotMatching = new List<string>() { "0", "1", "2", "X", "4", "5", "6", "7", "X", "X" };
        }

        public override void When()
        {

        }

        [Test]
        public void check_when_input_doesnot_match_condition()
        {
            State = DiognalCondition.GetState(NotMatching);
            AssertThatStateIsNoState();
        }

        [Test]
        public void check_if_it_matches_for_condition1_as_winner()
        {
            State = DiognalCondition.GetState(Column1);
            AssertThatStateIsWin();
        }

        [Test]
        public void check_if_it_matches_for_condition2_as_winner()
        {
            State = DiognalCondition.GetState(Column2);
            AssertThatStateIsWin();
        }
    }
}
