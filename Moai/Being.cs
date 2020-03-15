using System.Collections.Generic;
using Moai.Components;

namespace Moai
{
  public class Being
  {
    private (int x, int y) position;
    public bool ShouldRedraw {get; set;}
    public char Sign {get; set;}
    public (int x, int y) LastPosition {get; set;}
    public (int x, int y) Position {
      get
      {
        return position;
      } 
      set 
      {
        LastPosition = position;
        position = value;
        ShouldRedraw = true;
      }
    }

    private List<IComponent> components = new List<IComponent>();

    public Being(char sign)
    {
      Sign = sign;
    }

    public void Update()
    {
      foreach(var c in components)
      {
        c.Update();
      }
    }

    public void AddComponent(IComponent component)
    {
      components.Add(component);
    }
  }
}