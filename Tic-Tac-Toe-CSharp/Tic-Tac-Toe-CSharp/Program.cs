using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_CSharp
{
    class Program
    {
        private static readonly List<string> cell = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {
            Console.WriteLine("Pres any key start the game ? ");
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
