using Moai.OutputHandlers;
using Moai.InputHandlers;

namespace Moai
{
  class Program
  {
    public static void Main (string[] args)
    {
      var outputHandler = new ConsoleOutputHandler();
      var inputHandler = new ConsoleInputHandler(outputHandler);

      var game = new Game(outputHandler, inputHandler);
      game.Run();
    }
  }
}