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

		// Need an instance of the path object in the invader class in order for it to move.
		// Readonly because this will not change.
		private readonly Path _path;

		// Need a field to keep track of the where the invader is on the path
		// Needs to be private because this should not be accessible to other classes.
		// This will change over time so we do not make it readonly.
		// Initial value of 0 as the invader start at the beginning of the path.
		private int _pathStep = 0;

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

		//// Further simplification of above code when the getter just returns the location and the setter assigns it.
		//// In this case, not even the field is required.
		//public MapLocation Location { get; private set; }

		//// We can further add to the code to ensure Location always gets updated
		//// This will prevent code repetition when setting the location in the constructors and methods when an Invader is initialised or moved.
		//public MapLocation Location
		//{
		//	get
		//	{
		//		return _path.GetLocationAt(_pathStep);
		//		// The getter now computes the Location everytime it's requested.
		//		// We no longer need a setter.
		//	}
		//}
		//// This can be simplified even further as shown below

		public MapLocation Location => _path.GetLocationAt(_pathStep);
		// This reads the same as the above code and tells us the property returns the the location of the invader.

		// Since the setter is private, the location of the invader can only be set from within the class
		// Or else it will have a null value.
		// Thus we need a constructor.
		// Here we set the location of the invader at the first step of the path using the GetLocationAt() method.
		// We can use the _pathStep field to initialise this, since it starts at 0.
		// Also need to initialise the path.
		// We can also assign a value for the Invader's Health in the constructor.
		// In this case we will assign it in the property.

		// Invader need to have a base health value. Start with 2.
		// The setter is set to private so that the other classes have to use the method to change the health.
		public int InvaderHealth { get; private set; } = 2;
		// Will need a method to decrease the health of the invader.

		public Invader(Path path)
		{
			_path = path;
			//InvaderHealth = 2;
			//// Code to use when assigning InvaderHealth in the property.
		}

		//// Method to move the invader down the path.
		//// Returns void as it is solely used to move.
		//// Is public as it needs to be used elsewhere to move the invader.
		//// Increment _pathStep and then update the location of the invader using the new _pathStep.
		//public void Move()
		//{
		//	_pathStep += 1;		
		//}
		//// This can be simplified further using syntax similar to shortening of the property.

		public void Move() => _pathStep += 1;
		// This is differentiated by the other by the parenthesis in the name of the method, telling us that is is a method not a property.
		// This shortening is not necessary to use but must be familiarised with.

		// Method to decrease the health of the invader.
		// Health of the invader is decreased by the damage the tower deals.
		public void DecreaseInvaderHealth(int damage)
		{
			InvaderHealth -= damage;
		}
	}
}
