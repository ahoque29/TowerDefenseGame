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
				MapLocation[] path = {
					new MapLocation(0, 2, map),
					new MapLocation(1, 2, map),
					new MapLocation(2, 2, map),
					new MapLocation(3, 2, map),
					new MapLocation(4, 2, map),
					new MapLocation(5, 2, map),
					new MapLocation(6, 2, map),
					new MapLocation(7, 2, map),
				};
			}
			catch (OutOfBoundsException ex) 
			{
				Console.WriteLine(ex.Message);
			}
			catch (TowerDefenseException)
			{
				Console.WriteLine("Unhandled TowerDefenseException");
			}
			catch (Exception)
			{
				Console.WriteLine("Unhandled System.Exception");
			}



		}
	}
}
