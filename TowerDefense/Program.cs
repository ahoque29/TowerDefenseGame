using System;

namespace TowerDefense
{
	class Program //Program that will hold main.
	{
		static void Main()
		{
			Map map = new Map(8, 5);
			// Making new instances of map. After the constructor has been made, fields to be instantiated in the brackets.

			Point point1 = new Point(4, 2);
			Point point2 = new Point(2, 3);

			bool isOnMap = map.OnMap(point1);
			// A Bool variable is made by using the OnMap() method on the variable map by with parameter point1.

			Console.WriteLine(point1.DistanceTo(5, 5));
			// Prints the distance from point to (5, 5) as an integer to the console.

			Console.WriteLine(point1.DistanceTo(point2));
			// Prints the distance from point to point2 as an integer to the console using the overloaded method.
		}
	}
}
