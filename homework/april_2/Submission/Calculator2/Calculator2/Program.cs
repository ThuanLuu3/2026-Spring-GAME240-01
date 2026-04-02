Console.WriteLine("This calculator can perform 5 operation: addition (+), subtraction (-), multiplication (*), division.");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Please type a mathematical expression, or type \"quit\" to shut down the calculator.");
    string input = Console.ReadLine();
    if (input.ToLower() == "quit")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    
    string[] parts = input.Split(' ');
    if (parts.Length == 3)
    {
        double num1;
        double num2;

        bool validNum1 = double.TryParse(parts[0], out num1);
        bool validNum2 = double.TryParse(parts[2], out num2);

        if (validNum1 && validNum2)
        {
            string operation = parts[1];

            if (operation == "+")
            {
                Console.WriteLine(num1 + " + " + num2 + " is " + (num1 + num2));
            }
            else if (operation == "-")
            {
                Console.WriteLine(num1 + " - " + num2 + " is " + (num1 - num2));
            }
            else if (operation == "*")
            {
                Console.WriteLine(num1 + " * " + num2 + " is " + (num1 * num2));
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("You cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine(num1 + " / " + num2 + " is " + (num1 / num2));
                }
            }
            else if (operation == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("You cannot use modulus by zero.");
                }
                else
                {
                    Console.WriteLine(num1 + " % " + num2 + " is " + (num1 % num2));
                }
            }
            else
            {
                Console.WriteLine("I do not know how to do that.");
            }
        }
        else
        {
            Console.WriteLine("I do not know how to do that.");
        }
    }
    else
    {
        Console.WriteLine("I do not know how to do that.");
    }
}
            

