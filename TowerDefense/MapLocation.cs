namespace TowerDefense
{
	class MapLocation : Point // This signifies that MapLocation is a subclass of Point.
	{
		public MapLocation(int x, int y, Map map) : base(x, y)
		{
			// We tell the MapLocation constructor to take the constructor of its base class: Point.
			// We also add an instance of the map object in order to check if MapLocations are inside the map.
			// MapLocation objects can use the methods from Point class because MapLocation is a subclass of Point.

			if (!(map.OnMap(this))) // ``this`` keyword refers to the object the method is called on.
			{
				throw new OutOfBoundsException($"({x}, {y}) is outside the boundaries of the map");
				// We throw an exception if the OnMap method returns false.
				// We can pass a message in the parentheses.
			}
		}
	}
}
