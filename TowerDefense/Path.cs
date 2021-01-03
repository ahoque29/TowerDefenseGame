namespace TowerDefense
{
	class Path 
	{
		// Path is an array of MapLocations
		// Will need a move method to move the invaders through the path

		private readonly MapLocation[] _path;
		// Private fields conventionally start with an underscore.
		// Made it readonly to prevent it being overwritten.
		// Readonly only prevents overwriting the field with a different value.
		// Does not prevent individual items in the array to get changed.
		// That is why it is made part of a separate class.
		
		public Path(MapLocation[] path)
		{
			_path = path;
		}

		public MapLocation GetLocationAt(int pathStep)
		{
			// This method returns the MapLocation of a step in the path.

			//if (pathStep < _path.Length)
			//{
			//	return _path[pathStep];			
			//}
			//else
			//{
			//	return null;
			//}

			// Using ternary if statement
			return (pathStep < _path.Length) ? _path[pathStep] : null;
		}
	}
}
