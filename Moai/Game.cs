using Moai.OutputHandlers;
using Moai.InputHandlers;

namespace Moai
{
  public class Game
  {
    private IOutputHandler outputHandler;
    private IInputHandler inputHandler;

    public Game(IOutputHandler outputHandler, IInputHandler inputHandler)
    {
      this.outputHandler = outputHandler;
      this.inputHandler = inputHandler;
    }

    public void Run()
    {
      outputHandler.WriteLine("Welcome to Moai 🗿");
      inputHandler.PressAnyKey();
      outputHandler.Clear();
      var board = new Board();

      board.Display(outputHandler);
    }
  }
}