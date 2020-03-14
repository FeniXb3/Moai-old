using Moai.OutputHandlers;

namespace Moai
{
  public class Board
  {
    public void Display(IOutputHandler outputHandler)
    {
      outputHandler.WriteLine("#####");
      outputHandler.WriteLine("#   #");
      outputHandler.WriteLine("#   #");
      outputHandler.WriteLine("#   #");
      outputHandler.WriteLine("#####");
    }
  }
}