namespace TowerDefense
{
	class Level // Class inititialised to run a level of the game.
	{
		// The Level class (for now) needs an array of invaders.
		private readonly Invader[] _invaders;

		// Towers aren't required to construct the level
		// However the level will eventually need to know about them
		public Tower[] Towers { get; set;}

		public Level(Invader[] invaders) // Constructor for the Level class
		{
			// Towers aren't required to construct the level
			// However the level will eventually need to know about them
			_invaders = invaders;
		}

		// Play() method that returns true if player has won and false if player has lost.
		public bool Play()
		{
			// Run until all ivaders are neutralized or an invader reaches the end of the path.
			int remainingInvaders = _invaders.Length; // sets the initial number of invaders (length of the array)

			// Loop will then run as long as there are invaders left.
			while (remainingInvaders > 0)
			{
				// Each tower has an opportunity to fire on invaders.
				foreach (Tower tower in Towers)
				{
					tower.FireOnInvader(_invaders);
				}

				// Count and move the invaders that are still active.
				// First reset the invader count to 0.
				remainingInvaders = 0;
				// And then increment remainingInvaders by 1 for each active invader in the array.
				// Also take this opportunity to move the invader up the path.
				// Then check if the invader has reached the end of the path.
				foreach (Invader invader in _invaders)
				{
					if (invader.IsActive)
					{
						invader.Move();
						if (invader.HasReachEnd)
						{
							return false;
						}
						remainingInvaders++;
					}
				}
			}

			return true; // Return true if we exit the loop, because the player has won if the remaining invaders have reached 0.
		}
	}
}
