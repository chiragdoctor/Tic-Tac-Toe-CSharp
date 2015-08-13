using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Tests.GameLogic
{
    public abstract class game_rules_specs : Spec
    {
        protected List<string> Column1;
        protected List<string> Column2;
        protected List<string> Column3;
        protected List<string> NotMatching;
        protected IGameLogic HorizontalCondition;
        protected IGameLogic DiognalCondition;
        protected IGameLogic VerticalWinCondition;
        

        protected State State;

        protected override void Setup()
        {
            HorizontalCondition = new HorizontalWinState();
            DiognalCondition = new DiagonalWinState();
            VerticalWinCondition = new VerticalWinState();
        }

        protected void AssertThatStateIsWin()
        {
            Assert.That(State, Is.EqualTo(State.Win));
        }

        protected void AssertThatStateIsNoState()
        {
            Assert.That(State, Is.EqualTo(State.NoState));
        }
    }
}
