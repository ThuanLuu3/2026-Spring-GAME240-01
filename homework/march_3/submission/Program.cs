using System;

class Program
{
    static void Main()
    {
        Console.Write("1: ");
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i + " ");
            i++;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("2: ");
        int j = 100;
        while (j <= 150)
        {
            Console.WriteLine(j + " ");
            j++;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("3: ");
        int k = 0;
        while (k <= 100)
        {
            Console.WriteLine(k + " ");
            k += 2;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("4: ");
        int m = 20;
        while (m >= -20)
        {
            Console.WriteLine(m + " ");
            m--;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("5: ");
        int n = 1;
        while (n <= 100)
        {
            Console.WriteLine(n + " ");
            n += 3;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("6: ");
        int p = 1;
        while (p <= 1024)
        {
            Console.WriteLine(p + " ");
            p *= 2;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("7: ");
        string response;
        do
        {
            Console.WriteLine("Do you want the loop to stop: ");
            response = Console.ReadLine();
        } while (response.ToLower() != "yes");
        Console.WriteLine();
        
        Console.WriteLine("8: ");
        bool value = true;
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine(value + " ");
            value = !value;
            count++;
        }
        Console.WriteLine("\n");
        
        Console.WriteLine("9: ");
        int num = 1;
        bool isEven = false;
        while (num <= 20)
        {
            if (isEven)
                Console.WriteLine(num + " is even");
            else
                Console.WriteLine(num + " is odd");
            isEven = !isEven;
            num++;
        }
        Console.WriteLine();
        
        Console.WriteLine("10: ");
        string[] words = { "once", "upon", "a", "midnight", "dreary" };
        int index = 0;
        while (index < words.Length)
        {
            Console.WriteLine(words[index]);
            index++;
        }
    }
}