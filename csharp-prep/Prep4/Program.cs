using System;

using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Display instruction for the user to follow along
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        // Start a new list
        List<int> numbers = new List<int>();

        int userNumber = -1;
        //Keep asking the user for a number until they enter 0 to finish the list
        while(userNumber != 0)
        {
            Console.Write("Enter a number: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // only add the number to the list it is not 0
            if (userNumber != 0)
            {
                // add the number entered to list named numbers
                numbers.Add(userNumber);
            }
        }

        // core requirement 1- add the numbers in a list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // core 2 compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // core 3 find the max
        int max = numbers[0];
        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximmum number is: {max}");
    }
}