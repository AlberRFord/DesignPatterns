using System;

public interface IHitStrategy
{
  void Hit(float amount);
}

public class VertuhaKick : IHitStrategy
{
  public void Hit(float dmg)
  {
    Console.WriteLine($"Hitted {dmg} using Vertuha.");
  }
}

public class UppercutHit : IHitStrategy
{
  public void Hit(float dmg)
  {
    Console.WriteLine($"Hitted {dmg} using Uppercut.");
  }
}

public class Hitter
{
  private IHitStrategy _hitStrategy;

  public Hitter(IHitStrategy hitStrategy)
  {
    _hitStrategy = hitStrategy;
  }

  public void SetHitStrategy(IHitStrategy strategy)
  {
    _hitStrategy = strategy;
  }

  public void Hit(float amount)
  {
    _hitStrategy.Hit(amount);
  }
}

class Program
{
  static void Main(string[] args)
  {
    IHitStrategy strategy = new UppercutHit(); 
    Hitter hitter = new Hitter(strategy);

    hitter.Hit(100.14f);
  }
}








