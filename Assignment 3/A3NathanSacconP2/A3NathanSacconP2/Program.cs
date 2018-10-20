// Name: Nathan Saccon (7989163)
// Prog Concepts Assignment 3 Part 2
// Fall 2017

using System;

namespace A3NathanSacconP2
{
	class MainClass
	{
		public static void Main (string[] args)
		{	// Setup For Variables
			bool exitProgram, actionValid, firstValid, secondValid;
			string actionStr, firstStr, secondStr, exitStr;
			double firstDou, secondDou;

			// Initalizing Some Of The Variables
			exitProgram = false;
			actionValid = true;
			firstValid = true;
			secondValid = true;
			actionStr = "";
			firstDou = 0;
			secondDou = 0;

			// The Do Loop That Keeps The Program Running
			do
			{	// Deals With Operator Input
				while (actionValid)
				{	// Console Interation With The User To Choose Operator
					Console.WriteLine("Enter Which Type of Mathematical Operation You Want To Perform:");
					Console.WriteLine("Enter '1' for Addition (+)\nEnter '2' for Subtraction (-)\nEnter '3' for Multiplication (x)\nEnter '4' for Division (/)");
					actionStr = Console.ReadLine();

					// Checks To Make Sure User Input Is Valid
					if ((actionStr != "1") && (actionStr != "2") && (actionStr != "3") && (actionStr != "4"))
					{	// Invalid Entry Catch, Allows User To Re-Enter Input
						actionValid = true;
						Console.WriteLine("ERROR 101: Entry Invalid! Press Any Key To Try Again");
						Console.ReadLine();
					} else {
						// Allows The While Loop To Break
						actionValid = false;
					}
				}
				// Deals With First Numeric Input
				while (firstValid)
				{	// Console Interation Asking User For Input
					Console.WriteLine("Enter The First Number:");
					firstStr = Console.ReadLine();

					// Try/Catch To Make Sure User Enters Numeric Value
					try
					{
						// Takes Console Input And Converts It To A Double
						firstDou = double.Parse(firstStr);
						firstValid = false;
					}
					catch
					{
						// Console Interaction Informing User Of Invalid Input, Lets Them Re-Try
						Console.WriteLine("ERROR 102: Entry Invalid! Press Any Key To Try Again");
						Console.ReadLine();
					}

				}
				// Deals With Second Numeric Input
				while (secondValid)
				{
					// Console Interaction Asking User For Input
					Console.WriteLine("Enter The Second Number:");
					secondStr = Console.ReadLine();

					// Try/Catch To Make Sure User Enters Numeric Value
					try
					{
						//Takes Console Input And Converts To Double
						secondDou = double.Parse(secondStr);

						// Catches Divide By Zero Error, and Allows A Second Chance At Input
						if ((secondDou == 0) && (actionStr == "4"))
						{
							Console.WriteLine("ERROR 104: Division By Zero. Press Any Key To Try Again");
							Console.ReadLine();
							continue;
						} else {
							// Input Is Valid And Allows Loop To Break
							secondValid = false;
						}
					}
					catch
					{
						// Console Interaction Informing User Of Invalid Input, Lets Them Re-Try
						Console.WriteLine("ERROR 103: Entry Invalid! Press Any Key To Try Again");
						Console.ReadLine();
					}
				}
				// Prints The Answer To The Equation The User Has Input
				Console.WriteLine("--------------------------"); // Lines For Decoration
				Console.WriteLine("--------------------------"); // Lines For Decoration
				if (actionStr == "1") // Case For Addition
				{
					Console.WriteLine("The Answer Is: " + (firstDou + secondDou));
				} else if (actionStr == "2") // Case For Subtraction
				{
					Console.WriteLine("The Answer Is: " + (firstDou - secondDou));
				} else if (actionStr == "3") // Case For Multiplication
				{
					Console.WriteLine("The Answer Is: " + (firstDou * secondDou));
				} else // Case For Division (Since We Checked Valid Input Before)
				{
					Console.WriteLine("The Answer Is: " + (firstDou / secondDou));
				}
				Console.WriteLine("--------------------------"); // Lines For Decoration
				Console.WriteLine("--------------------------"); // Lines For Decoration

				// Console Interation To Allow User To Either Restart The Program Or Exit The Program
				Console.WriteLine("Press 'Enter' To Do Another Mathematical Operation. Otherwise The Program Will Exit.");
				exitStr = Console.ReadLine();

				if (exitStr == "") // Case For User Wanting To Do Another Operation
				{
					// Re-Initializes The Program For Next Loops
					exitProgram = false;
					actionValid = true;
					firstValid = true;
					secondValid = true;
				} else // Case For Exiting The Program
				{
					exitProgram = true;
				}
			} while (!exitProgram);
				
		}
	}
}
