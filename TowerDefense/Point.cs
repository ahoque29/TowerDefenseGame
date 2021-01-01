using System;

namespace TowerDefense
{
	class Point //Point class will need fields for x and y coordinate.
	{
		public readonly int X;
		public readonly int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int DistanceTo(int x, int y)
		{
			// Method to determine distance between two points.
			// This is to be used on a point variable and parameters x and y coordinates need to be passed.
			
			return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
			// Math.Sqrt used to computer square root.
			// Math.Pow used to computer exponentiation.
			// Method requires to return an integer so the result is casted to (int). This truncates the double after the decimal point.
		}

		public int DistanceTo(Point point)
		{
			// Now we make another method with the same name that takes different parameters, this time a point.

			return DistanceTo(point.X, point.Y);
			// Reused the DistanceTo method but passed the x and y coordiate of the point instead. This is called Overloading a method.
		}
	}
}
