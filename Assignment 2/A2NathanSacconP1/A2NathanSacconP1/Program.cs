// Nathan Saccon 7989163
// Assignment 1, Part 1
// PROG1781 - Fall 2017

using System;

namespace A2NathanSacconP1
{
	class MainClass
	{
		public static void Main (string[] args)
		{ 	// Declare vaiables and constants for use in main
			string nationStr, ageStr, termStr, sem;
			double total, tax, hst;
			int ageInt, baseFee, regFee, nationFee;
			bool nationBool;
			// Give a default value to all the variables
			tax = 0.13;
			total = 0;
			nationBool = false;
			hst = 0;
			baseFee = 0;
			regFee = 0;
			nationFee = 0;
			sem = "";

			// Create the console interaction with the student user asking if they are an international student.
			Console.WriteLine ("Welcome to tuition checker.\nIf you are an international student please enter '1' otherwise, enter '2'.");
			nationStr = Console.ReadLine ();
			// Create the console interaction with the student user asking their age.
			Console.WriteLine ("Please Enter Your Age:");
			ageStr = Console.ReadLine();
			// Convert the input string into an integer.
			ageInt = Convert.ToInt32 (ageStr);

			// Based on the age of the student, add the appropriate amount to the fee and the hst
			if (ageInt <= 18) 
			{
				baseFee += 300;
				hst += 300 * tax;
			}
			else if ((19 <= ageInt) && (ageInt <= 49))
			{
				baseFee += 500;
				hst += 500 * tax;
			}
			else if (50 <= ageInt)
			{
				baseFee += 400;
				hst += 400 * tax;
			}
			// If the student is an international student, add appropriate fees and taxes.
			if (nationStr == "1")
			{
				hst += 100 * tax;
				nationBool = true;
				nationFee += 100;
			}
			// Create the console interaction with the user, asking which term they will be enrolled in.
			Console.WriteLine("Enter the number that corresponds to your school term:\nFall Term enter '1'\nWinter Term enter '2'\nSummer Term enter '3'");
			termStr = Console.ReadLine ();

			// Using a switch statement, add the appropriate fees and taxes, based on which term the student is enrolled in.
			switch (termStr) 
			{
			case "1":
				regFee += 250;
				hst += 250 * tax;
				sem = "Fall Term";
				break;
			case "2":
				regFee += 220;
				hst += 220 * tax;
				sem = "Winter Term";
				break;
			case "3":
				regFee += 150;
				hst += 150 * tax;
				sem = "Summer Term";
				break;
			}
			// Calculate the total based on all fees and taxes.
			total += baseFee + nationFee + regFee + hst;

			// White the information out to the console in a logical easy to read manner.
			Console.WriteLine ("\n\nThe Student's Age is: " + ageStr);
			Console.WriteLine ("International Student: " + nationBool);
			Console.WriteLine ("Registration Semester: " + sem + "\n");
			Console.WriteLine ("Base Tuition: $" + baseFee);
			Console.WriteLine ("International Fee: $" + nationFee);
			Console.WriteLine ("Registration Fee: $" + regFee);
			Console.WriteLine ("HST: $" + hst);
			Console.WriteLine ("Your Total: $" + total);
			// Useless readline so the console doens't close for demonstration.
			Console.ReadLine ();
		}
	}
}

