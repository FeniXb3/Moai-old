using System;
using Moai.OutputHandlers;

namespace Moai.InputHandlers
{
  public class ConsoleInputHandler : IInputHandler
  {
    private IOutputHandler outputHandler;
    
    public ConsoleInputHandler(IOutputHandler outputHandler)
    {
      this.outputHandler = outputHandler;
    }

    public void PressAnyKey()
    {
      outputHandler.WriteLine("Press any key...");
      Console.ReadKey(true);
    }
  }
}