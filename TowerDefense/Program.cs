using System;

namespace TowerDefense
{
	class Program //Program that will hold main.
	{
		static void Main()
		{
			//Map map = new Map(8, 5);
			//// Making new instances of map. After the constructor has been made, fields to be instantiated in the brackets.

			//Point point1 = new Point(4, 2);
			//Point point2 = new Point(2, 3);
			//MapLocation mapLocation1 = new MapLocation(4, 2); // Made a MapLocation variable.

			//bool isOnMap = map.OnMap(point1);
			//// A Bool variable is made by using the OnMap() method on the variable map by with parameter point1.

			//Console.WriteLine(point1.DistanceTo(5, 5));
			//// Prints the distance from point1 to (5, 5) as an integer to the console.

			//Console.WriteLine(point1.DistanceTo(point2));
			//// Prints the distance from point1 to point2 as an integer to the console using the overloaded method.

			//Console.WriteLine(mapLocation1.DistanceTo(5, 5));
			//// Prints the distance from mapLocation1 to (5, 5) as an integer to the console.
			//// MapLocation objects can use the methods from Point class because MapLocation is a subclass of Point.

			//Map map = new Map(8, 5);
			//try
			//{
			//	MapLocation mapLocation = new MapLocation(20, 20, map);
			//	// Making a MapLocation object that is obviously not in the map.
			//	// To handle the exception, wrap the code in try catch.
			//	// Add more catch clauses to handle more types of exceptions.
			//	// More general exceptions should be at the bottom (order matters).
			//}
			//catch (OutOfBoundsException ex) // Format ``catch(type of exception)``. Can make an instance of exception and access it's Message field later.
			//{
			//	Console.WriteLine(ex.Message);
			//	// Printing out the Message field of the exception class that we defined in MapLocation.
			//}
			//catch (TowerDefenseException)
			//{
			//	Console.WriteLine("Unhandled TowerDefenseException");
			//}
			//catch (Exception)
			//{
			//	// Block of code that processes if any other exception is caught.
			//	Console.WriteLine("Unhandled System.Exception");
			//}

			Map map = new Map(8, 5);
			try
			{
				// Creating the path the invaders will take
				// Path is an array of MapLocations.
				// Steps: 1) Creating a new Path object named path.
				// 2) Creating a new array ``new[] {}``
				// 3) Creating entries into that array as new MapLocations
				Path path = new Path
					(
						new[]
						{
							new MapLocation(0, 2, map),
							new MapLocation(1, 2, map),
							new MapLocation(2, 2, map),
							new MapLocation(3, 2, map),
							new MapLocation(4, 2, map),
							new MapLocation(5, 2, map),
							new MapLocation(6, 2, map),
							new MapLocation(7, 2, map),
						}
					);

				// Creating an array of invaders to run the level
				Invader[] invaders =
					{
						new Invader(path),
						new Invader(path),
						new Invader(path),
						new Invader(path),
					};


				// For now, will assign the towers in the code
				// In the future, user should be able to choose where to input the towers.
				// Creating array of towers
				Tower[] towers =
					{
						new Tower(new MapLocation(1, 3, map)),
						new Tower(new MapLocation(3, 3, map)),
						new Tower(new MapLocation(5, 3, map)),
					};

				// Then we create the level and pass in the invader's array to it.
				Level level = new Level(invaders)
				{
					// Setting the tower property inside Level to the towers we have designated above.
					Towers = towers
				};

				// Now we call the Play() method to run the the level and store the return value.
				bool playerWon = level.Play();

				// Finally, print the outcome of the game to the screen.
				Console.WriteLine("Player has " + (playerWon ? "won" : "lost") + ".");

				//// Set the tower property inside Level to the towers we have designated here.
				//// This is obsolete because this can be done during the object creation.
				//level.Towers = towers;

				//// Creating a  new Invader and a MapLocation
				//Invader invader = new Invader();
				//MapLocation location = new MapLocation(0, 0, map);

				//// Using the SetLocation() method to set the location of the invader ie set
				//invader.SetLocation(location);

				//// Using the property to set the location of the invader ie set
				//invader.Location = location;

				//// Using the GetLocation() method to set location to the invader's location ie get
				//location = invader.GetLocation();

				//// Calling the property getter to set location to invader's location ie get
				//location = invader.Location;

				//// Calling the GetLocationAt to get the MapLocation of a step in the path
				//MapLocation location = path.GetLocationAt(8);
				//if (location != null)
				//{
				//	// Printing the coordinates of location if the location is on the path.
				//	// This is called a null check.
				//	Console.WriteLine($"({location.X}, {location.Y})");
				//}
			}
			catch (OutOfBoundsException ex) 
			{
				Console.WriteLine(ex.Message);
			}
			catch (TowerDefenseException)
			{
				Console.WriteLine("Unhandled TowerDefenseException");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unhandled System.Exception " + ex);
			}



		}
	}
}
