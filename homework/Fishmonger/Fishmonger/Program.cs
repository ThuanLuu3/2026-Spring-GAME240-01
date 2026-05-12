using System;
using System.IO;

class Program
{
    static void Main()
    {
        string specialPath = "";
        string logPath = "";
        string outputPath = "";

        while (true)
        {
            Console.WriteLine("What is the file path for today's specials?");
            specialPath = Console.ReadLine();

            try
            {
                File.ReadAllText(specialPath);
                break;
            }
            catch 
            {
                Console.WriteLine("File not found");
            }
        }

        while (true)
        {
            Console.WriteLine("What is the file path for the fishmonger's log?");
            logPath = Console.ReadLine();
            try
            {
                File.ReadAllText(logPath);
                break;
            }
            catch
            {
                Console.WriteLine("File not found");
            }
        }
        
        Console.WriteLine("Where do you want to save the result?");
        outputPath = Console.ReadLine();
        
        string specialLine = File.ReadAllText(specialPath).Trim();
        string specialName = specialLine.Split(':')[1].Trim().ToLower();
        
        string[] lines = File.ReadAllLines(logPath);

        int totalFish = 0;
        int specialCount = 0;

        foreach (string line in lines)
        {
            string [] parts = line.Split(' ');
            
            int quantity = int.Parse(parts[0]);
            string fishName = parts[1].ToLower();
            
            totalFish += quantity;

            if (fishName == specialName)
            {
                specialCount +=  quantity;
            }
        }

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine($"Today's special is: {specialName}");
            writer.WriteLine($"Total {specialName} caught: {specialCount}");
            writer.WriteLine($"Total fish caught: {totalFish}");
        }
        
        Console.WriteLine("Created files successfully");
    }
}