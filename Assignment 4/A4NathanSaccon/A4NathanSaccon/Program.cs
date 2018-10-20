// Nathan Saccon (7989163)
// PROG1781 F17 - Sec 4
// Jan. 3, 2017
// Assignment 4

using System;

namespace A4NathanSaccon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Setup of all variables that are used in the program.
			int numRows, numCols, strIndex, consoleInput, chosenRow, chosenCol, seatsTaken, chosenIndex, removeChoice, col, row, index;
			string[] seatList;
			string firstInit, lastName;
			int[] takenList;
			bool nameUsed;
			// Allows user to choose number of rows that the seating arrangement has.
			while (true) {
				// Prompts user for number of rows.
				Console.WriteLine ("Enter Number Of Rows (Min. 4)");
				// Try/Catch to catch any invalid input from user. (Input must be an int > 4)
				try {
					// Setup of variable that holds number of rows as int
					numRows = int.Parse (Console.ReadLine ());
					// Error check. Makes sure the integer entered is >= 4
					if (numRows < 4) {
						// Displays error message to screen and prompts user to return to menu.
						Console.WriteLine ("INPUT INVALID - Number Too Low - Press 'Enter' To Try Again");
						Console.ReadLine ();
						continue;
					// Else clause is if there is NO ERROR, input valid.
					} else {
						break;
					}
				// Catch Clause for any non-numeric input for number of rows.
				} catch {
					// Displays error message to screen and prompts user to return to menu.
					Console.WriteLine ("INPUT INVALID: Press 'Enter' To Try Again");
					Console.ReadLine ();
					continue;
				}
			}
			// Allows user to choose number of columns that the seating arrangement has.
			while (true) {
				// Prompts user for number of columns.
				Console.WriteLine ("Enter Number Of Columns (Min. 4)");
				// Try/Catch to catch any invalid input from user. (Input must be an int > 4)
				try {
					// Setup of variable that holds number of columns as int
					numCols = int.Parse (Console.ReadLine ());
					// Error check. Makes sure the integer entered is >= 4
					if (numCols < 4) {
						// Displays error message to screen and prompts user to try again.
						Console.WriteLine ("INPUT INVALID - Number Too Low - Press 'Enter' To Try Again");
						Console.ReadLine ();
						continue;
					// Else clause is if there is NO ERROR, input valid.
					} else {
						break;
					}
				// Catch Clause for any non-numeric input for number of columns.
				} catch {
					// Displays error message to screen and prompts user to try again.
					Console.WriteLine ("INPUT INVALID: Press 'Enter' To Try Again");
					Console.ReadLine ();
					continue;
				}
			}
			// Initializes list size with the same length as number of seats.
			seatList = new string[numCols * numRows];
			// Initializes variable value to aid in creation of list.
			strIndex = 0;
			// For loop that adds all seats to the list in the form "R-C" where R is number of the row and C is number of the Column.
				// Outer loop tracks row number.
			for (int i = 1; i <= numRows; i++) {
				// Nested loop tracks column numbers, and adds the string in form "R-C" to the list.
				for (int j = 1; j <= numCols; j++) {
					seatList [strIndex] = i + "-" + j;
					strIndex += 1;
				}
			}
			// Variable seatsTaken tracks the current number of seats that are reserved.
			seatsTaken = 0;
			// takenList tracks which seats have been taken. Mostly used so you can't reserve the same seat twice.
				// Initialized to the same size as the seatList
			takenList = new int[numCols * numRows];
			// While loop keeps program running until exit by user.
			while (true) {
				// Lines for decoration
				Console.WriteLine ("--------------------------------");
				Console.WriteLine ("--------------------------------");
				// Display of four options to user.
				Console.WriteLine ("To See Seating Chart: Press '1'");
				Console.WriteLine ("To Choose Seat: Press '2'");
				Console.WriteLine ("To Remove Seat: Press '3'");
				Console.WriteLine ("To Exit Program: Press '4'");
				// Try/Catch to catch any invalid input from user. User must enter an option from the menu.
				try{
					// Setup of variable that holds the choice of the user as an integer.
					consoleInput = int.Parse(Console.ReadLine ());
					// Error check. Makes sure the integer entered is a valid option.
					if ((consoleInput < 1) || (consoleInput > 4)){
						// Displays error message to screen and prompts user to try again.
						Console.WriteLine("INVALID INPUT - Number Not In Range - Press 'Enter' To Try Again");
						Console.ReadLine();
						continue;
					}
				// Catch Clause for any non-numeric input.
				} catch {
					// Displays error message to screen and prompts user to try again.
					Console.WriteLine("INVALID INPUT - Press 'Enter' To Try Again");
					Console.ReadLine();
					continue;
				}
				// Option to DISPLAY SEATING CHART
				if (consoleInput == 1) {
					// PrintSeats is the method that displays the chart.
					PrintSeats (seatList, numCols);
					// Prompt for user to go back to main menu.
					Console.WriteLine ("Press 'Enter' To Return To Main Menu");
					Console.ReadLine ();
					continue;
				//Option to CHOOSE A SEAT
				} else if (consoleInput == 2) {
					// Checks if all the seats are full.
					if (seatsTaken == (numCols * numRows)) {
						// Lets user know that all the seats are full, then prompts back to main menu.
						Console.WriteLine ("----------------------------------------------------");
						Console.WriteLine ("THERE ARE NO MORE AVAILABLE SEATS, Snooze you lose!\nPress 'ENTER' To Return To Main Menu");
						Console.WriteLine ("----------------------------------------------------");
						Console.ReadLine ();
						continue;
					}
					// User enters their name. (Numeric values allowed, incase R2D2 needs a seat.)
					try {
						// Prompts user for last name, then first initial.
						Console.Write ("Enter your LAST NAME: ");
						lastName = Console.ReadLine (); // Variable stores last name
						Console.Write ("\nEnter the FIRST LETTER of your FIRST NAME: ");
						firstInit = Console.ReadLine ()[0].ToString(); // Variable stores first inital even if full first name is entered.
						//Error for empty last name string.
						if (lastName == ""){
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("OOPS! Something went wrong. Press 'ENTER' To Return To Main Menu");
							Console.ReadLine ();
							continue;
						}
					//Catch Clause for empty first init string / other input error.
					} catch {
						// Displays error message to screen and prompts user to return to main menu.
						Console.WriteLine ("OOPS! Something went wrong. Press 'ENTER' To Return To Main Menu");
						Console.ReadLine ();
						continue;
					}
					// Variable that tracks if name entered has already been used.
					nameUsed = false;
					// Loops checks if name entered is already registered.
					for (int i = 0; i < seatList.Length; i++) {
						if ((firstInit + "." + lastName) == seatList [i]) {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("ERROR: NAME ALREADY USED. Press 'Enter' to return to main menu.");
							Console.ReadLine ();
							nameUsed = true;
						}
					}
					// If the name was already used, returns to main menu.
					if (nameUsed) {
						continue;
					}
					// Prints the table with all the seats for user to choose seat.
					PrintSeats (seatList, numCols);
					// Try/Catch to make sure the user input is valid integer.
					try {
						// Asks the user to enter the row number of the desired seat.
						Console.Write ("Look at the seating chart above.\nEnter The ROW NUMBER of desired seat: ");
						// Variable holds row of chosen seat as integer.
						chosenRow = int.Parse (Console.ReadLine ());
						// Makes sure row chosen is a valid row inside bounds of seating.
						if ((chosenRow < 0) || (chosenRow > numRows)) {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("Input not within range of seats. Press 'Enter' to return to main menu.");
							Console.ReadLine ();
							continue;
						}
					//Catch Clause for non-numeric input.
					} catch {
						// Displays error message to screen and prompts user to return to main menu.
						Console.WriteLine ("Input not within range of seats. Press 'Enter' to return to main menu.");
						Console.ReadLine ();
						continue;
					}
					try {
						// Asks the user to enter the column number of the desired seat.
						Console.Write ("Enter The COLUMN NUMBER of desired seat: ");
						// Variable holds column of chosen seat as integer.
						chosenCol = int.Parse (Console.ReadLine ());
						// Makes sure column chosen is a valid column inside bounds of seating.
						if ((chosenCol < 0) || (chosenCol > numCols)) {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("Input not within range of seats. Press 'Enter' to return to main menu.");
							Console.ReadLine ();
							continue;
						}
					//Catch Clause for non-numeric input.
					} catch {
						// Displays error message to screen and prompts user to return to main menu.
						Console.WriteLine ("Input not within range of seats. Press 'Enter' to return to main menu.");
						Console.ReadLine ();
						continue;
					}
					// Variable to hold the index of the chosen seat in seatList
					chosenIndex = (((chosenRow - 1) * numCols) + (chosenCol - 1));
					// Checks to make sure seat has not already been taken.
					if (takenList [chosenIndex] == 0) {
						// Assigns the seat to be the first initial and last name in form "F.Last"
						seatList [chosenIndex] = firstInit + "." + lastName;
						// Changes the same index in takenList to indicate that the seat is now reserved.
						takenList [chosenIndex] = 1;
						// Adds one to the variable keeping track of how many seats are taken.
						seatsTaken += 1;

						Console.WriteLine ("You have sucessfully reserved your seat. Press 'ENTER' to return to main menu.");
						Console.ReadLine ();

					// Else Clause for if the seat was already taken.
					} else {
						// Error message saying that the seat was already reserved.
						Console.WriteLine ("This seat has ALREADY BEEN TAKEN. Press 'ENTER' to return to main menu");
						Console.ReadLine ();
						continue;
					}
				//Option to REMOVE RESERVED SEAT
				} else if (consoleInput == 3) {
					// Menu option to ask if they will remove their reservation by NAME or SEAT
					Console.WriteLine("You have requested to remove your seat.\nTo remove by NAME: Press '1'\nTo remove by SEAT: Press '2'");
					try {
						// Variable that stores the menu choice
						removeChoice = int.Parse(Console.ReadLine());
						// Makes sure input is one of the two choices
						if ((removeChoice != 1) && (removeChoice != 2)){
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("Input not within range. Press 'ENTER' To Return To Main Menu");
							Console.ReadLine ();
							continue;
						}
					// Catch Clause if input is non-numeric
					} catch {
						// Displays error message to screen and prompts user to return to main menu.
						Console.WriteLine ("OOPS! Something went wrong. Press 'ENTER' To Return To Main Menu");
						Console.ReadLine ();
						continue;
					}
					// Print the seating chart so user can see where they are seated.
					PrintSeats (seatList, numCols);
					Console.WriteLine("Look At Chart Above To Help You Remove Seat");
					// Option to REMOVE BY NAME
					if (removeChoice == 1) {
						// User try to enter their name.
						try {
							// Prompts user for last name, then first initial.
							Console.Write ("Enter your LAST NAME: "); // Variable stores last name.
							lastName = Console.ReadLine ();
							Console.Write ("\nEnter the FIRST LETTER of your FIRST NAME: ");
							firstInit = Console.ReadLine ()[0].ToString(); // Variable stores first inital even if full first name is entered.
							// Checks if last name was left empty.
							if (lastName == ""){
								// Displays error message to screen and prompts user to return to main menu.
								Console.WriteLine ("OOPS! Something went wrong. Press 'ENTER' To Return To Main Menu");
								Console.ReadLine ();
								continue;
							}
						//Catch Clause for empty first init string / other input error.
						} catch {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("OOPS! Something went wrong. Press 'ENTER' To Return To Main Menu");
							Console.ReadLine ();
							continue;
						}
						// Checks if the name was already registered.
						if (!InList (seatList, firstInit + "." + lastName)) {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("Name not registered, press 'ENTER' to return to menu.");
							Console.ReadLine ();
							continue;
						// If the name was registered, this removes it.
						} else {
							// For loop to find the name in the list.
							for (int i = 0; i < seatList.Length; i++) {
								// If statement finds the name (keep in mind we know the name is in there somewhere from previous if statement)
								if (seatList [i] == firstInit + "." + lastName) {
									// Figures out which column the reservation was in based on index
									col = i % numCols + 1;
									// Checks if the reservation is in the first row
									if (i < numCols) {
										// First row formula error correction.
										row = 1;
									// Else statement if reservation is not in first row
									} else {
										// Figures out which row the reservation was in based on index
										row = (i - col) / numRows + 2;
									}
									// Changes the string of that seat back to the row and column "R-C"
									seatList [i] = row + "-" + col;
									// Marks the seat as not on reserve
									takenList [i] = 0;
									// Reduces the number of taken seats by one
									seatsTaken -= 1;
									// Alerts the user that they have been removed from the seating and prompts back to main menu.
									Console.WriteLine ("You have been removed from the seating. Press 'ENTER' to return to menu.");
									Console.ReadLine ();
									continue;
								}
							}
						}
					// Option to REMOVE BY SEAT
					} else {
						// User will try and enter the row and column of their reservation.
						try {
							// Asks user to input row and column of reservation
							Console.Write ("Enter ROW of seat to be removed: ");
							row = int.Parse(Console.ReadLine()); // Variable holds row of reservation to be removed
							Console.Write ("Enter COLUMN of seat to be removed: ");
							col = int.Parse(Console.ReadLine()); // Variable holds column of reservation to be removed
							// Checks if the rows and columns are within bounds of the number of seats.
							if ((col < 0) || (row < 0) || (col > numCols) || (row > numRows)){
								// Displays error message to screen and prompts user to return to main menu.
								Console.WriteLine ("ERROR - Number Out Of Range - Press 'ENTER' to return to menu.");
								Console.ReadLine ();
								continue;
							}
						// Catch clause will catch if input in non-numeric
						} catch {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("ERROR: Invalid Input - Press 'ENTER' to return to menu.");
							Console.ReadLine ();
							continue;
						}
						// Converts the row and column to the index in seatList/takenList
						index = ((row-1) * numCols) + col-1;
						// Checks if the seat is already on reserve
						if (takenList [index] == 0) {
							// Displays error message to screen and prompts user to return to main menu.
							Console.WriteLine ("ERROR: Cannot remove empty customer. Press 'ENTER' to return to menu.");
							Console.ReadLine ();
							continue;
						}
						// Changes the string of that seat back to the row and column "R-C"
						seatList [index] = row + "-" + col;
						// Marks the seat as not on reserve
						takenList [index] = 0;
						// Reduces the number of taken seats by one
						seatsTaken -= 1;
						// Alerts the user that they have been removed from the seating and prompts back to main menu.
						Console.WriteLine ("You have been removed from the seating. Press 'ENTER' to return to menu.");
						Console.ReadLine ();
						continue;
					}
				// Option to EXIT PROGRAM
				} else {
					// Program Exits
					break;
				}
			}
		}
		// PrintSeats prints the chart showing all the seats with both empty and reserved seats
		// Contract: listOf(str), int -> void
		static void PrintSeats (string[] strList, int numCols){
			// Initializes the variables for the function.
			int curCol;
			string seat;/*
			// Loop creates "decorative" whitespace
			for (int a = 0; a < 10; a++) {
				Console.Write("\n");
			}*/
			// Loop creates dynamic "decorative" border, accurate for up to 9x9 grid
			for (int a = 0; a < numCols; a++) {
				Console.Write("*******");
			} Console.Write ("\n");
			// Variable keeps track of the current column total
			curCol = 0;
			// Each iteration prints one seat of the seating chart
			for (int n = 0; n < strList.Length; n++) {
				// The seat in form "R-C" is stored as the variable 'seat'
				seat = strList [n];
				// Writes the seat with some decoration to the console.
				Console.Write ("* " + seat + " *");
				// Adds one to the current column
				curCol += 1;
				// Checks if you are in the last column, if so print newline
				if ((curCol % numCols) == 0) {
					// Prints newline to start new row
					Console.Write ("\n");
				}
			}
			// Loop creates dynamic "decorative" border, accurate for up to 9x9 grid
			for (int a = 0; a < numCols; a++) {
				Console.Write("*******");
			} Console.Write ("\n");
		}
		// InList checks if a string appears as an element inside a list
		// Contract: listof(str), str -> bool
		static bool InList (string[] strList, string str){
			// Initializes variable answer
			bool answer;
			// Default answer is no
			answer = false;
			// Checks if the string appears inside the list.
			for (int i = 0; i < strList.Length; i++) {
				// If the string is in the list changes the answer to true
				if (strList [i] == str) {
					answer = true;
				}
			}
			// returns true if the string is in the list and false otherwise.
			return answer;
		}
	}
}