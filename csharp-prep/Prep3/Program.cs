using System;
using System.ComponentModel.DataAnnotations;

// ask the user for the magic number
Console.Write("What is the magic number? ");
// convert the input from the user to and integer
int magicNumber = int.Parse(Console.ReadLine());
//Console.WriteLine(magicNumber);

// ask the user for a random number to guess the margic number
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 101);

int guess = -1;
while (guess != magicNumber)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (magicNumber > guess)
    {
        Console.WriteLine("Higher");
    }

    else if (magicNumber < guess)
    {
        Console.WriteLine("Lower");
    }

    else
    {
        Console.WriteLine("You have guessed it!");
    }
}
