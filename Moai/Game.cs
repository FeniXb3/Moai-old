using Moai.OutputHandlers;

namespace Moai
{
  public class Game
  {
    private IOutputHandler outputHandler;

    public Game(IOutputHandler outputHandler)
    {
      this.outputHandler = outputHandler;
    }

    public void Run()
    {
      outputHandler.WriteLine("Welcome to Moai 🗿");
    }
  }
}