using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe_CSharp
{
    public static class Board
    {
        public static void Create(List<string> cell)
        {
            Console.WriteLine("Press any Key to start game: ");
            Console.ReadKey();

            Console.WriteLine("Computer1 : X & Computer2 : O");
            Console.WriteLine("\n");

            Console.WriteLine(" __________________ ");
            Console.WriteLine("|     |     |      |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}", cell[1], cell[2], cell[3]);
            Console.WriteLine("|_____|_____|_____ |");
            Console.WriteLine("|     |     |      |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}", cell[4], cell[5], cell[6]);
            Console.WriteLine("|_____|_____|_____ |");
            Console.WriteLine("|     |     |      |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}", cell[7], cell[8], cell[9]);
            Console.WriteLine("|     |     |      |");
            Console.WriteLine(" __________________ ");

            Console.ReadKey();
        }
    }
}
