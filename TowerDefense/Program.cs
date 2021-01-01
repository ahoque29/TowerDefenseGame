using System;

namespace TowerDefense
{
	class Program //Program that will hold main.
	{
		public void Main()
		{
			Map map = new Map(8, 5);
			// Making new instances of map. After the constructor has been made, fields to be instantiated in the brackets.

			Point point = new Point(4, 2);

			bool isOnMap = map.OnMap(point);
			// A Bool variable is made by using the OnMap() method on the variable map by with parameter point.
		}
	}
}
