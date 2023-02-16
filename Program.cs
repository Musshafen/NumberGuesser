
using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        //Displays greeting method and allows the player to type in when they are ready.
        static void DisplayGreeting()
        {
            Console.WriteLine("I want to play a game.");
            Console.Write("Please think of a number between 1-1024. DO NOT TELL ME YOUR NUMBER! Enter 'R' when you are ready to play: ");

            //Create a boolean statement that will be used for the while statement below    
            bool userCommand = false;

            //While statement that reads players input to start the guessing process when they are ready. Honestly might change this later to include please press ENTER to start so I can reuse this statement.
            while (userCommand == false)
            {
                var userInput = Console.ReadLine();
                var upperCaseUserInput = userInput.ToUpper();

                if (upperCaseUserInput == "R")
                {
                    Console.WriteLine("Let the game begin");
                    userCommand = true;
                }
                else
                {
                    var answer = UnknownCommand("I'm sorry, I do not understand. Please enter 'R' when you are ready.");
                }
            }
        }
        //Creates a method that calls back when the player attempts to enter unrecognized text and returns nothing.
        static string UnknownCommand(string prompt)
        {
            Console.WriteLine(prompt);

            return null;
        }

        static void Main(string[] args)
        {
            //Starts the program with a greeting to let the player know they've been chosen for a game
            DisplayGreeting();

            //Create two new lists: one to keep track of the minimum and maximum value and the second to count number of guesses.
            var minMaxValueNumbers = new List<int>() { 1, 1024 };
            var guessedNumbers = new List<int>();

            //Start of formula to guess players number
            bool nextUserCommand = false;
            while (nextUserCommand == false)
            {
                //Formula that calculates a new number to guess
                var newGuessNumber = (minMaxValueNumbers[0] + minMaxValueNumbers[1]) / 2;

                Console.WriteLine($"Is the number you're thinking of {newGuessNumber}?");
                Console.Write($"Please enter 'H', if the number you're thinking of is higher then {newGuessNumber}, 'L' if it is lower than {newGuessNumber}, or 'C' if I am Correct: ");
                //Reads the players input and turns it into all caps to be matched to if statements
                var otherUserInput = Console.ReadLine();
                var otherUpperCaseUserInput = otherUserInput.ToUpper();

                if (otherUpperCaseUserInput == "H")
                {
                    guessedNumbers.Add(newGuessNumber);
                    minMaxValueNumbers[0] = ((minMaxValueNumbers[0] + minMaxValueNumbers[1]) / 2) + 1;
                }
                else if (otherUpperCaseUserInput == "L")
                {
                    guessedNumbers.Add(newGuessNumber);
                    minMaxValueNumbers[1] = ((minMaxValueNumbers[0] + minMaxValueNumbers[1]) / 2) - 1;
                }
                else if (otherUpperCaseUserInput == "C")
                {
                    guessedNumbers.Add(newGuessNumber);

                    var amountOfNumbersGuessed = guessedNumbers.Count;
                    Console.WriteLine($"B-E-A-utiful! I WIN! That only took me {amountOfNumbersGuessed} tries!");
                    nextUserCommand = true;
                }
                else
                {
                    var answer = UnknownCommand("I am not sure what you are saying. Please enter if some number is HIGHER, LOWER, or CORRECT: ");
                }
            }


        }
    }
}