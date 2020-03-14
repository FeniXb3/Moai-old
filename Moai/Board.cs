using Moai.OutputHandlers;
using System.Collections.Generic;

namespace Moai
{
  public class Board
  {
    private List<Being> beings = new List<Being>();

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

      foreach(var b in beings)
      {
          outputHandler.WriteAt(b.X, b.Y, b.Sign);
      }

      outputHandler.WriteAt(0, cells.Length, '\n');
    }

    public void AddBeing(Being being)
    {
      beings.Add(being);
    }
  }
}