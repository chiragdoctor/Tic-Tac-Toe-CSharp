using NUnit.Framework;
using System;

namespace Tic_Tac_Toe_Tests.Player
{
    public abstract class Player_Specs : Spec
    {
        protected IPlayer Player;
        protected int Result;
        protected int MoveCount;

        protected override void Setup()
        {
            Player = new AI();
        }

        protected void AssertThatResultIsNotMoreThat9()
        {
            Assert.That(Result, Is.AtMost(9));      
        }

        protected void AssertThatResultIsNOtGreaterThan9()
        {
            Assert.IsFalse(Result > 9);
        }
    }
}
