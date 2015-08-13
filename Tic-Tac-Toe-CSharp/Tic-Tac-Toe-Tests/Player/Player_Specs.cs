using System;

namespace Tic_Tac_Toe_Tests.Player
{
    public class Player_Specs : Spec
    {
        protected IPlayer Player;

        protected override void Setup()
        {
            Player = new AI();
        }

        public override void Given()
        {
            throw new NotImplementedException();
        }

        public override void When()
        {
            throw new NotImplementedException();
        }

        


    }
}
