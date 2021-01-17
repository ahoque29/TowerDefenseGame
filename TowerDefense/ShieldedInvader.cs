namespace TowerDefense
{
	class ShieldedInvader : Invader // Subclass of invader
	{
		// ShieldedInvader is an instance of the invader class with some different properties
		// Whenever a tower successfully shoots a ShieldedInvader there is a chance the invader takes no damage.

		// Thus we'll need a static random instance
		private static System.Random _random = new System.Random();
		
		public ShieldedInvader(Path path) : base(path) // Passing the path of the base class
		{

		}

		public override void DecreaseInvaderHealth(int damage)
		{
			// half the time, a shielded invader will not take damage when it takes a hit from the tower.
			if (_random.NextDouble() < 0.5)
			{
				// call the base class' method.
				base.DecreaseInvaderHealth(damage);
			}
			else
			{
				// Console message for if the ShieldedInvader blocked the shot.
				System.Console.WriteLine("The Shielded Invader blocked the shot! No damage sustained!");
			}
		}
	}
}
