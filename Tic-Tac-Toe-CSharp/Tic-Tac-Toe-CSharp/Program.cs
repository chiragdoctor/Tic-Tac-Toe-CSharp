using System;

namespace Tic_Tac_Toe_CSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Do you wish to play: (y/n) ?  ");
            var input = Console.ReadLine();
            if(input.ToString() == "y")
            {
                // Could add Dependency injection here. 
                new Game(new AI(), new Match(), new GamePlay()).Execute();
            }
            else
            {
                Console.WriteLine("May be some other time!!");
                Console.Read();
            }
            
        }
    }
}
