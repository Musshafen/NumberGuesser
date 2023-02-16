# NumberGuesser

## To push to github

If you selected `Y` during `dotnet new` you can add your changes and push to github with:

1. `git add .`
1. `git commit -m "Here I describe my changes"`
1. `git push`

Otherwise do the following _ONCE_ before using the steps above.

1. `git init`
1. `git add .`
1. `git commit -m "Initial Commit"`
1. `sdg hubCreate`
1. `git push -u origin HEAD`

## PROTIP:

When you are complete with the project and have turned it in to your instructor, update README.md with details about the assignment.

    {
        static void ShowGreeting()
        {
            Console.WriteLine("********************");
            Console.WriteLine("I want to play a game!");
            Console.WriteLine("********************");
            Console.WriteLine("Please think of a number, BUT DO NOT TELL ME between 1 - 1024");
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.WriteLine(prompt);
            var playerInput = Console.ReadLine();
            return playerInput;


        }
    }

    static void Main(string[] args)
    {
        ShowGreeting();

        var randomNumberGenerator = new Random();
