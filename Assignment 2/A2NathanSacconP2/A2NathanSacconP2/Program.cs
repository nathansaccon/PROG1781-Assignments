// Nathan Saccon 7989163
// Assignment 2 Part 2
// PROG1781 - Fall 2017

using System;

namespace A2NathanSacconP2
{
	class MainClass
	{
		public static void Main (string[] args)
		{// Set up variables and constant to be used
			double pi, radDbl, heightDbl, lengthDbl, widthDbl;
			string shapeType, radStr, heightStr, lengthStr, widthStr;
			pi = 3.14159;

			// Create the console interaction with the user, asking which shape they want the volume for.
			Console.WriteLine("What Type Of Shape Do You Want To Make?\n Enter '1' for Sphere\nEnter '2' for Cylinder\nEnter '3' for Rectangular Prism");
			shapeType = Console.ReadLine ();

			// Console interaction for SPHERE
			if (shapeType == "1")
			{	// Create the console interaction with user, asking for radius of sphere.
				Console.WriteLine ("Enter the radius of your sphere:");
				radStr = Console.ReadLine ();
				// Convert radius as a string to a double value.
				radDbl = Convert.ToDouble (radStr);
				// Write to console the total volume of the sphere given by CalcVolume.
				Console.WriteLine("The volume of your sphere is: " + CalcVolume (pi, radDbl) + " units.");

			}

			// Console interaction for CYLINDER
			if (shapeType == "2") {
				// Create the console interaction with user, asking radius of the cylinder.
				Console.WriteLine ("Enter the radius of the end of your cylinder:");
				radStr = Console.ReadLine ();
				// Convert radius as a string to a double value.
				radDbl = Convert.ToDouble (radStr);
				// Create the console interaction with user, asking height of cylinder.
				Console.WriteLine ("Enter the height of your cylinder:");
				heightStr = Console.ReadLine ();
				// Convert the height as a string to a double.
				heightDbl = Convert.ToDouble (heightStr);
				// Write to console with total volume of the cylinder given by CalcVolume.
				Console.WriteLine ("The volume of your cylinder is: " + CalcVolume (pi, radDbl, heightDbl) + " units.");
			} 
			// Console interaction for REC PRISM
			else 
			{	// Create the console interaction with user, asking for length of prism.
				Console.WriteLine ("Enter the length of your prism:");
				lengthStr = Console.ReadLine();
				// Convert the length as a string to a double value.
				lengthDbl = Convert.ToDouble(lengthStr);
				// Create the console interaction with user, asking for the width of the prism.
				Console.WriteLine ("Enter the width of your prism:");
				widthStr = Console.ReadLine ();
				// Convert the width as a string to a double value. 
				widthDbl = Convert.ToDouble (widthStr);
				// Create the console interaction with user, asking for height of prism.
				Console.WriteLine ("Enter the height of your prism:");
				heightStr = Console.ReadLine ();
				// Convert the height as a string to a double value.
				heightDbl = Convert.ToDouble (heightStr);
				// Write to console the total volume of the prism given by CalcVolume.
				Console.WriteLine ("The volume of your rectangular prism is: " + CalcVolume (pi, lengthDbl, widthDbl, heightDbl) + " units.");
			}
		}

		// Method that calulates volume of SPHERE
		static double CalcVolume (double pi, double rad)
		{	// Use C# code to calculate the volume of a sphere
			return (4 / 3) * pi * rad * rad * rad;
		}
		// Method that calulates volume of CYLINDER
		static double CalcVolume (double pi, double rad, double height)
		{	// Use C# code to calculate the volume of a cylinder
			return pi * rad * rad * height;
		}
		// Method that calulates volume of REC PRISM
		static double CalcVolume (double pi, double length, double width, double height)
		{	// Use C# code to calculate the volume of a rec prism.
			return length * width * height;
		}
	}
}
