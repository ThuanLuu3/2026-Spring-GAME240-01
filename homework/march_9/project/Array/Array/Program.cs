using System;

class Program
{
    static void Main()
    {
        int[] numbers = [256,20,68,53,11];
        
        int smallest = numbers[0];
        int biggest = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }

            if (numbers[i] > biggest)
            {
                biggest = numbers[i];
            }
        }
        
        Console.WriteLine("Smallest number is: " + smallest);
        Console.WriteLine("Biggest number is: " + biggest);
    }
}


