// Name: Nathan Saccon (7989163)
// Prog Concepts Assignment 3 Part 1
// Fall 2017

using System;

namespace A3NathanSacconP1
{
	class MainClass
	{
		public static void Main (string[] args)
		{	// Declaring Variables.
			string menuOption;

			do // This Do Loop makes it so the main menu pops up multiple times.
			{	// This prints the main menu to the screen.
				Console.WriteLine ("Enter A Number From The List:\nEnter '1': To Display Even Numbers.");
				Console.WriteLine ("Enter '2' : To Display Perfect Squares.\nEnter '3' : To Exit Program.");
				// User Menu Option
				menuOption = Console.ReadLine ();

				// Option for The Even Number Display
				if (menuOption == "1")
				{
					EvenNumberDisplay();
				}
				// Option for Perfect Square Display
				else if (menuOption == "2")
				{
					PerfectSquareDisplay();
				}
			// Option For Ending Program
			// Any Invalid Input Relaunches Main Menu
			} while(menuOption != "3");



		}
		// This Method Displays Even Numbers Based On User Input
		public static void EvenNumberDisplay()
		{	// Declaring Variables
			int evensInt, currentEven;
			string evensStr;

			// Get The User Input And Set As A Variable
			Console.WriteLine ("Enter The Number Of Even Numbers You Want To Display: ");
			evensStr = Console.ReadLine ();

			try
			{
				evensInt = int.Parse (evensStr);
				// Decoration to make even numbers stand out.
				Console.WriteLine("-----------------");
				Console.WriteLine("-----------------");
			}
			catch 
			{
				Console.WriteLine ("Invalid Input");
				evensInt = 0;
				EvenNumberDisplay ();
			}

			// Variable For Keeping Track Of Current Even Number
			currentEven = 2;

			// Writes Even Numbers To Console Based On User Input
			for (int i = 1; i <= evensInt; i++) // REQUIRED FOR LOOP
			{
				Console.WriteLine (currentEven);
				currentEven += 2;

				// Case To Print The Decorative Lines
				if (i == evensInt) 
				{
					// Decoration to make even numbers stand out.
					Console.WriteLine ("-----------------");
					Console.WriteLine ("-----------------");
				}
			}
		}
		public static void PerfectSquareDisplay()
		{	// Initiate Variables
			int currentSquare;
			string continueStr;

			// Keep Track Of Which Number Is Currently Being Squared
			currentSquare = 1;
			// Keeps Track Of User Input
			continueStr = "";

			// Writes A Perfect Square To Console Until User Enters Info To End Program
			while (continueStr == "") { // REQUIRED WHILE LOOP
				Console.WriteLine (currentSquare * currentSquare);
				Console.WriteLine ("Press Enter To Continue, Enter Anything Else To Go To Main Menu.");
				continueStr = Console.ReadLine ();
				currentSquare += 1;
			} 
		}
	}

}
