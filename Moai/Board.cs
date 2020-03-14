using Moai.OutputHandlers;

namespace Moai
{
  public class Board
  {
    public void Display(IOutputHandler outputHandler)
    {
      var cells = new char[][]
      {
        "#####".ToCharArray(),
        "#   #".ToCharArray(),
        "#   #".ToCharArray(),
        "#   #".ToCharArray(),
        "#####".ToCharArray(),
      };

      for(var x = 0; x < cells.Length; x++)
      {
        for(var y = 0; y < cells[x].Length; y++)
        {
          var sign = cells[x][y];
          outputHandler.WriteAt(x, y, sign);
        }
      }
    }
  }
}