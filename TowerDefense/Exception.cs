namespace TowerDefense
{
	class TowerDefenseException : System.Exception
	{
		// Class made to hold our exception types
		// Conventionally, exception classes end with -Exception.
		// All exception classes must inherit from System.Exception.

		public TowerDefenseException()
		{
			// This constructor is to allow exception without needing to pass messages.
		}

		public TowerDefenseException(string message) : base(message)
		{
			// Made a constructor in this exception class to pass a message. Inherited from System.Exception.
		}
	}

	class OutOfBoundsException : TowerDefenseException
	{
		// Can inherit from subclass as well.

		public OutOfBoundsException()
		{
			// Does not need to use semi colon to refer to the base class as this is the default constructor.
			// Default constructor automatically use the default constructor of the base class.
			// This constructor is to allow exception without needing to pass messages.
		}
		public OutOfBoundsException(string message) : base(message)
		{

		}
	}
}
