Console.WriteLine("This calculator can perform 4 operation: addition, subtraction, multiplication, division.");
Console.WriteLine();
////////
Console.WriteLine("What operation would you like to perform?");
string operation = Console.ReadLine().ToLower();

if (operation == "addition" || operation == "subtraction" || operation == "multiplication" || operation == "division")
{
    Console.WriteLine("What is your first number?");
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("What is your second number?");
    double num2 = Convert.ToDouble(Console.ReadLine());
    
    if (operation == "division" && num2 == 0)
    {
        Console.WriteLine("You cannot divide by zero.");
    }
    else if (operation == "addition")
    {
        Console.WriteLine(num1 + " + " + num2 + " is " + (num1 + num2));
    }
    else if (operation == "subtraction")
    {
        Console.WriteLine(num1 +  " - " + num2 + " is " + (num1 - num2));
    }
    else if (operation == "multiplication")
    {
        Console.WriteLine(num1 + " * " + num2 + " is " + (num1 * num2));
    }
    else if (operation == "division")
    {
        Console.WriteLine(num1 + " / " + num2 + " is " + (num1 / num2));
    }
}
else
{
    Console.WriteLine("I do not know how to do that ");
}