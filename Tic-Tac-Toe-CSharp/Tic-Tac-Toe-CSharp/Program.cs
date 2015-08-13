namespace Tic_Tac_Toe_CSharp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Could add Dependency injection here. 
            new Game(new AI(), new Match(), new GamePlay()).Execute();
        }
    }
}
