# NumberGuesser

2 methods
ShowGreeting
ComputeNewLowIfTooLow
ComputeNewHighIfTooHigh
BragWhenCorrect

Display a greeting to the player and explain the guessing game.
The player gets to pick a number (but not tell) between 0 and 1024.
Tell the player you'll be able to guess that number in 10 tries or less.
For the max value (1024), we have to divide that by 2 and get 512.
Ask the player if their number is higher or lower than 512.
If their number is higher, you know it's between 513 and 1024,
or if it's lower, it's between 1 and 511.
Create a loop depending on the response from player in line 5
Once you guessed the number, prompt a phrase saying you have guessed
their number in x amount of guesses.
Ask if they want to try again.
