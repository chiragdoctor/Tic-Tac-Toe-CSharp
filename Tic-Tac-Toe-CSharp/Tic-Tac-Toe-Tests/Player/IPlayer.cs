﻿using System.Collections.Generic;

namespace Tic_Tac_Toe_Tests.Player
{
    public interface IPlayer
    {
        int GetAvailableMoveFrom(List<string> usedCells);

    }
}