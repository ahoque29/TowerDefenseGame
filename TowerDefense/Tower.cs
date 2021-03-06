﻿using System;

namespace TowerDefense // This is the namespace that all classes are under.
{
	class Tower // Class declared called Tower. Classes are conventionally named starting with upper case.
	{
		// Field to initialize the range of the tower
		// Made into a constant so the value cannot be changed
		// private so only the class can access it
		private const int _range = 1;

		// Field to initialize the damage a tower deals to an invader
		private const int _damage = 1;

		// Field to initialise the accuracy of a tower (chance to hit target)
		private const double _accuracy = 0.75;

		// Adding a static class to generate random numbers
		// private because only the tower class requires to access it.
		// readonly because it does not need to be changed
		public static readonly Random _random = new Random();

		// Each tower will need a MapLocation
		// Towers do not move so, readonly
		private readonly MapLocation _location;

		// Constructor for tower
		public Tower(MapLocation location)
		{
			_location = location;
		}

		// Method that determines if the tower has successfully hit or missed the target
		// If the random returned is less that the accuracy previously set, bool is set to true and tower hits.
		public bool IsSuccessfulShot()
		{
			return _random.NextDouble() < _accuracy;
			// Will then need to update the FireOnInvader() method
		}

		// Will need a check to ensure the tower is not on the path

		// Method to shoot on invaders.
		// Will list through all the invaders in range and "shoot" each of them.
		// ie decrease their health by 1.
		// Takes an array of Invaders as parameter.
		public void FireOnInvader(Invader[] invaders)
		{
			//// Initialise the range of the tower in the method
			//const int range = 1;
			//// We chose to declare the constant in the class instead.
			
			//// Can use a while loop to do this.
			//int i = 0;
			//while (i < invaders.Length)
			//{
			//	Invader invader = invaders[i];
			//	// Makes an instance of an invader corresponding to the invader in the array at the given index.	
			//	i++;
			//	Increment the index.
			//	// This is followed by the code that checks if an invader is in range.
			//}

			//// Can use a for loop as well to be more concise.
			//// for loops take three arguments:
			//// Initialising the index.
			//// Boolean condition (loop will iterate while it is true).
			//// index increment.
			//for (int i = 0; i < invaders.Length; i++)
			//{
			//	Invader invader = invaders[i];
			//	// This is followed by the code that checks if an invader is in range.
			//}
			//// This can be further simplified using a foreach loop

			// Using a foreach loop
			foreach (Invader invader in invaders)
			{
				// Code that checks if an invader is active and is in range.
				if (invader.IsActive || _location.InRangeOf(invader.Location, _range))
				{
					// First check if the tower successfully hits or misses the target
					// Only decrease the health of the enemy if the tower hits
					if (IsSuccessfulShot())
					{
						// Decrease the health of the invader
						invader.DecreaseInvaderHealth(_damage);
						// We want the tower to only shoot at one invader at a time.
						// So once the above method is called, we increment the loop index by breaking out of the loop.

						//// Print to the console to indicate the successful shot
						//Console.WriteLine("Shot and hit an invader!");
						//// Later decided to move this to the DecreaseHeath() method.

						// Print to the console if invader is neutralised
						if (invader.IsNeutralized)
						{
							Console.WriteLine("Invader has been successfully neutralized!");
						}
					}
					else
					{
						Console.WriteLine("Shot and missed an invader!");
					}
					break;
				}
			}


		}
	}
}