using System;
using System.Collections.Generic;

namespace Moai.Components
{
  public class MovingComponent : IComponent
  {
    public Being Entity {get; set;}
    
    private Dictionary<ConsoleKey, string> controls =
      new Dictionary<ConsoleKey, string>
      {
        {ConsoleKey.A, "MoveLeft"},
        {ConsoleKey.D, "MoveRight"},
        {ConsoleKey.W, "MoveUp"},
        {ConsoleKey.S, "MoveDown"}
      };

    private Dictionary<string, (int x, int y)> directions =
      new Dictionary<string, (int x, int y)>
      {
        {"MoveLeft", (-1, 0)},
        {"MoveRight", (1, 0)},
        {"MoveUp", (0, -1)},
        {"MoveDown", (0, 1)},
      };

    public MovingComponent(Being entity)
    {
      Entity = entity;
    }

    public void Update()
    {
      var keyInfo = Console.ReadKey(true);
      var key = keyInfo.Key;
      if(controls.ContainsKey(key))
      {
        var direction = controls[key];
        var positionChange = directions[direction];
        var pos = Entity.Position;

        Entity.Position = 
          (pos.x + positionChange.x,
          pos.y + positionChange.y);
        
      }
    }
  }
}