using System;

namespace Tic_Tac_Toe_CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Console.Write("Do you wish to play: (y/n) ?  ");
            var play = Console.ReadLine();
            if (play.ToString() == "y")
            {
                // Could add Dependency injection here. 
                var game = new Game(new AI(), new Match(), new GamePlay());
                game.Execute();
                Console.Clear();
                Start();
            }
            else
            {
                Console.WriteLine("May be some other time!!");
                Console.Read();
            }
        }
    }
}
