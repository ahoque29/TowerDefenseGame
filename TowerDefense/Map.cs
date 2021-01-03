namespace TowerDefense
{
	class Map
	{
		// Map class needs variable of width and height.
		// We need a constructor method for height and width to make sure those are filled when a map instance is created.

		public readonly int Width;
		public readonly int Height;
		// We declared these two fields to be used for the Map class.
		// Every map object that instantiated can store both width and height.
		// Keyword public/private/protected define the access level
		// public can be accessed anywhere. private cannot be accessed anywhere but here. protected can be accessed by subclasses.
		// readonly keyword used to ensure values are not changed after declaration.

		public Map(int width, int height) // Constuctors have the same name as the class they are in. Parameters added in the brackets.
		{
			// Parameters added must be provided by the user.
			// Body of the constructor used to initialise the fields.
			Width = width;
			Height = height;

			// Constructors do not have return types.
			// public keyword used so that other classes can use this constructor.
		}

		public bool OnMap(Point point)
		{
			//declare method using access level keyword then return type then ``MethodName(Parametertype parameter)``
			//if no return type then write ``void``

			return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;			
		}
	}
}
