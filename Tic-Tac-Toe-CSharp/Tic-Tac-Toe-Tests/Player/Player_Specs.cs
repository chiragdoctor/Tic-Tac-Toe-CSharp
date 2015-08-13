using NUnit.Framework;
using System;

namespace Tic_Tac_Toe_Tests.Player
{
    public abstract class Player_Specs : Spec
    {
        protected IPlayer Player;
        protected int Result;
        protected int MoveCount;
        protected bool IsPositionOccupied;

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

        protected void AssertThatResultIsNotAString()
        {
            Assert.That(Result, Is.Not.InstanceOf<string>());
        }

        protected void AssertThatResultIsInRangeFrom0To9()
        {
            Assert.That(Result, Is.InRange(0, 9));
        }

        protected void AssertThatWhenAllMovesAreFinishedItReturn0()
        {
            Assert.That(MoveCount, Is.EqualTo(0));
        }

        protected void AssertIf3IsOccupiedForPlay()
        {
            Assert.IsFalse(IsPositionOccupied);
        }
    }
}
