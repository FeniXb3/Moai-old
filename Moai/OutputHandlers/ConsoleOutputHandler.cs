using System;


namespace Moai.OutputHandlers
{
  public class ConsoleOutputHandler : IOutputHandler
  {
    public void WriteLine(string text)
    {
      Console.WriteLine(text);
    }

    public void Clear()
    {
      Console.Clear();
    }
  }
}