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

    public void WriteAt(int x, int y, char sign)
    {
      Console.SetCursorPosition(x, y);
      Console.Write(sign);
    }
  }
}