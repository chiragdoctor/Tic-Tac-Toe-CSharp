using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_CSharp
{
    public class Game
    {
        private static readonly List<string> cells = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void Execute()
        {
            Board.Create(cells);
        }
    }
}
