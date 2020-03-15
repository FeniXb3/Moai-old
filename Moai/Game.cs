using Moai.OutputHandlers;
using Moai.InputHandlers;
using Moai.Components;

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
      var board = new Board(outputHandler);
      var player = CreatePlayer();
      board.AddBeing(player);

      board.Display();

      while(true)
      {
        board.PerformFrame();
      }
    }

    public Being CreatePlayer()
    {
      var player = new Being('@');
      player.Position = (2, 2);
      player.AddComponent(new MovingComponent(player));
      return player;
    } 
  }
}