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
      var player = CreatePlayer();
      board.AddBeing(player);

      board.Display(outputHandler);
    }

    public Being CreatePlayer()
    {
      var player = new Being('@');
      player.X = 2;
      player.Y = 2;
//      player.AddComponent<MovingComponent>(new )
      return player;
    } 
  }
}