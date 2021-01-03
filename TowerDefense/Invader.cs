namespace TowerDefense 
{
	class Invader 
	{
		// Invader needs a MapLocation to see how close it is to a Tower if they are in range of each other.
		// It shouldn't be readonly because the Invader should be moving through the path.
		// The method should not be public because this divulges too much info.
		// Instead, make the field private and include public methods to access the field.		
		private MapLocation _location;

		// Need two methods. One that accesses the location and one that sets the location.
		// Make use of accessor methods.
		// Method to get the location:
		public MapLocation GetLocation()
		{
			return _location;
		}

		// And now to set the location:
		public void SetLocation(MapLocation value)
		{
			_location = value;
		}
	}
}
