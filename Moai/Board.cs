using Moai.OutputHandlers;
using System.Collections.Generic;

namespace Moai
{
  public class Board
  {
    private List<Being> beings = new List<Being>();
    private char[][] cells;
    private IOutputHandler outputHandler;

    public Board(IOutputHandler outputHandler)
    {
      this.outputHandler = outputHandler;
    }

    public void Display()
    {
      cells = new []
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
          outputHandler.WriteAt(b.Position.x, b.Position.y, b.Sign);
      }

      outputHandler.WriteAt(0, cells.Length, '\n');
    }

    public void AddBeing(Being being)
    {
      beings.Add(being);
    }

    public void PerformFrame()
    {
      foreach(var b in beings)
      {
        b.Update();
      }
      Redraw();
    }

    private void Redraw()
    {
      foreach(var b in beings)
      {
        if(b.ShouldRedraw)
        {
          var lastPos = b.LastPosition;
          var pos = b.Position;
          var mapSign = cells[lastPos.x][lastPos.y];
          outputHandler.WriteAt(lastPos.x, lastPos.y, mapSign);
          outputHandler.WriteAt(pos.x, pos.y, b.Sign);
     
          b.ShouldRedraw = false;
        }
      }

      outputHandler.WriteAt(0, cells.Length, '\n');
    }
  }
}