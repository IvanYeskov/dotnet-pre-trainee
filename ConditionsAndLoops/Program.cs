Console.WriteLine("*** Welcome! ***");
Console.WriteLine("This application analyzes an integer for:\nValidity\t Sign\t Primality\n");

static bool ReadInteger(out int intAnswer)
{
    Console.Write("Enter an integer -> ");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out intAnswer))
    {
        Console.WriteLine($"Your number: {intAnswer}");

        string sign = (intAnswer > 0) ? "Positive" : (intAnswer < 0) ? "Negative" : "Zero";
        Console.WriteLine($"Sign: {sign}");
        return true;
    }
    else
    {
        Console.WriteLine("Error: The entered value is not a valid integer.");
        return false;
    }
}

static void IsPrime(int intAnswer)
{
    if (intAnswer <= 1)
    {
        Console.WriteLine($"{intAnswer} is not a prime number (prime numbers must be greater than 1).");
    }
    else
    {
        bool isPrime = true;
        for (int i = 2; i * i <= intAnswer; i++)
        {
            if (intAnswer % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{intAnswer} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{intAnswer} is a composite number.");
        }
    }
}

static bool ReadChar(out char charAnswer)
{
    Console.WriteLine("=== Enter an operation sign ===");
    Console.WriteLine("+\t-\t/\t*\t%");

    string? input = Console.ReadLine();
    if (char.TryParse(input, out charAnswer) && "+-*/%".Contains(charAnswer))
    {
        Console.WriteLine($"Selected operation: {charAnswer}");
        return true;
    }
    else
    {
        Console.WriteLine("Error: Invalid operation sign.");
        return false;
    }
}

static int CalculateTwoNumbers(int a, int b, char answerChar)
{
    switch (answerChar)
    {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a / b;
        case '%':
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return a % b;
        default:
            return 0;
    }
}

while (true)
{
    if (!ReadInteger(out int number1))
    {
        continue;
    }
    IsPrime(number1);

    if (!ReadInteger(out int number2))
    {
        continue;
    }
    IsPrime(number2);

    if (ReadChar(out char charAnswer))
    {
        int result = CalculateTwoNumbers(number1, number2, charAnswer);
        Console.WriteLine($"Result: {number1} {charAnswer} {number2} = {result}");
    }

    Console.Write("\nDo you want to continue? (y/n): ");
    string? answer = Console.ReadLine();

    if (answer?.ToLower() != "y")
    {
        break;
    }
    Console.WriteLine();
}