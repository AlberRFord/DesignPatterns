using System;

public interface IComponent
{
   string Operation();
}

public class HighKick : IComponent
{
  public string Operation()
  {
    return "HighKick";
  }
}

public abstract class Decorator : IComponent
{
  protected IComponent component;

  public Decorator(IComponent component)
  {
    this.component = component;
  }

  public virtual string Operation()
  {
    return component.Operation();
  }
}

public class Kick : Decorator
{
  public Kick(IComponent component) : base(component)
  {
  }

  public override string Operation()
  {
    return $"Kick({base.Operation()})";
  }
}

public class Hit : Decorator
{
  public Hit(IComponent component) : base(component)
  {
  }

  public override string Operation()
  {
    return $"Hit({base.Operation()})";
  }
}

class Program
{
  static void Main()
  {
    IComponent component = new HighKick();

    IComponent kick = new Kick(component);
    IComponent hit = new Hit(kick);

    string result = hit.Operation();
    Console.WriteLine(result);
    Console.ReadLine();
  }
}