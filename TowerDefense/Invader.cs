namespace TowerDefense 
{
	class Invader 
	{
		//// Invader needs a MapLocation to see how close it is to a Tower if they are in range of each other.
		//// It shouldn't be readonly because the Invader should be moving through the path.
		//// The method should not be public because this divulges too much info.
		//// Instead, make the field private and include public methods to access the field.
		//// Field has been deleted because it is not necessary when a property is used.
		//// The property, in essence, sets the field.
		//private MapLocation _location;

		// Need two methods. One that accesses the location and one that sets the location.
		// Make use of accessor methods.
		// Method to get the location:
		//public MapLocation GetLocation()
		//{
		//	return _location;
		//}

		//// And now to set the location:
		//public void SetLocation(MapLocation value)
		//{
		//	_location = value;
		//}

		// We will make a property that will do the job of the above two methods.
		//public MapLocation Location
		//{
		//	// If we were to remove the getter, other classes could set the value but not read it.
		//	// Methods and other properties within the class could still read the location using the private field directly.
		//	// If we were to remove the setter, other classes could read the location but could not set it.
		//	// Location field isn't readonly:  other methods and properties within the invader could still set the location on the private field directly.
		//	// Once a property gets and sets a field, it's bad practice to access them directly.
		//	// Can put access levels on getters and setters.
		//	// Can further simplify the code.
		//	get
		//	{
		//		return _location;
		//	}
		//	private set
		//	{
		//		_location = value;
		//		// Can write additional code here to process when setting the location.
		//		//System.Console.WriteLine("Location changed.");
		//	}
		//}

		// Further simplification of above code when the getter just returns the location and the setter assigns it.
		// In this case, not even the field is required.
		public MapLocation Location { get; private set; }
	}
}
