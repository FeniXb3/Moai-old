using Moai.OutputHandlers;

namespace Moai
{
  class Program
  {
    public static void Main (string[] args)
    {
      var outputHandler = new ConsoleOutputHandler();

      var game = new Game(outputHandler);
      game.Run();
    }
  }
}