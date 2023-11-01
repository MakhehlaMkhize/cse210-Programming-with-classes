using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new();

        Console.WriteLine("Enter a list  of numbers, type 0 when finished");

        int userInputNumber;

        int numberSum = 0;

        int largestNumber = 0;

        int smallestPositiveNumber=999999999;

        do
        {
            Console.Write("Enter a number: ");

            userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber != 0)
            {
                numbers.Add(userInputNumber);
                numberSum += userInputNumber;
                if (userInputNumber>largestNumber)
                {
                    largestNumber = userInputNumber;
                }
                if(userInputNumber>0 && userInputNumber<smallestPositiveNumber)
                {
                    smallestPositiveNumber = userInputNumber;
                }
            }   
            
        }while(userInputNumber != 0);

        double numberAverage = ((double)numberSum)/numbers.Count ;

        numbers.Sort();
        
        Console.WriteLine($"The sum is: {numberSum}");
        Console.WriteLine($"The average is: {numberAverage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    

    }
}