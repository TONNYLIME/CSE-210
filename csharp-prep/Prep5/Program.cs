using System;

class Program
{
    static void Main(string[] args)
    {
        {
            // define the variable 
            DisplayWelcome();

            string userName = PromptUserName();

            int userNumber = PromptUserNumber();

            int squareNumber = SquareNumber(userNumber);

            DisplayResult(userName, squareNumber);
        }
        // Display the message,"Welcome to the program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        // Ask for and returns the user's name(as a string)
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        // Ask for and returns the user's favorite number(as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        // Accepts an integer as a parameter  and returns that number squared (as an integer)
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        // Accepts the user's name and the Square number and displays them
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        
    }
}