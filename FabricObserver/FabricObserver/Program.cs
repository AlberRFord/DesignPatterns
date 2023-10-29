using System;

namespace FabricObserver
{
  class Program
  {
		public static int energy = 150;
		public class Hit
		{
			protected int damage;
			public Hit()
			{
				damage = 0;
			}
			public Hit(int dm)
			{
				damage = dm;
			}
			public void hitWithEnergyLeft() { }
		}

		public class SwordAttack : Hit {
			public int energyRequired = 25;
			public int damage = 25;
			public SwordAttack()
			{
				if (energy >= energyRequired)
				{
					Console.WriteLine("You have energy for sword attack");
				}
			}
			public void hitWithEnergyLeft()
			{
				if (energy >= energyRequired)
				{
					Console.WriteLine("Hit by sword");
					energy -= energyRequired;
				}
			}
	  }

		public class UltimateAttack : Hit {
			public int energyRequired = 100;
			public int damage = 100;
			public UltimateAttack()
			{
				if (energy >= energyRequired)
				{
					Console.WriteLine("You have energy for ultimate attack");
				}
			}
			public void hitWithEnergyLeft()
			{
				if (energy >= energyRequired)
				{
					Console.WriteLine("Hit by ultimate");
					energy -= energyRequired;
				}
			}
	  }


	static void Main(string[] args)
    {
			Hit hit1 = new SwordAttack();
			hit1.hitWithEnergyLeft();
			hit1.hitWithEnergyLeft();
			hit1 = new UltimateAttack();
			hit1.hitWithEnergyLeft();
			hit1 = new SwordAttack();
    }
  }
}
