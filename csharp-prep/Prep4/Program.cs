using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userNumber = Console.ReadLine();
            userInput = int.Parse(userNumber);
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        //sum
        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum += number;
        }

        Console.WriteLine($"The sum is: {totalSum}");

        //average
        float average = ((float)totalSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}