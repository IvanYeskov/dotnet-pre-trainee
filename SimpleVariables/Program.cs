//This project is a simple order calculator for discount that outputs a receipt to the console.


Console.Write("Hello! Can you enter your name please?-> ");
string name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine($"Welcome, {name}!");

Console.Write("Enter your age, please-> ");
string ageInput = Console.ReadLine();
if (int.TryParse(ageInput, out int age))
{
    Console.WriteLine($"\nYour age is {age}");
}
else
{
    Console.WriteLine("\nError: Invalid age format. Please enter numbers only.");
    age = 0;
    return;
}

Console.Write("Are you studying in the university? (0/1)-> ");
string studyInput = Console.ReadLine();
bool isStudying = false;
if (int.TryParse(studyInput, out int studyInt) && (studyInt == 0 || studyInt == 1))
{
    isStudying = studyInt == 1;
    Console.WriteLine($"Your status: {(isStudying ? "Student" : "Isn't a student")}");
}
else
{
    Console.WriteLine("Error: Please enter only 0 or 1.");
    return;
}

Console.Write("\nYour amount of order-> ");
string orderInput = Console.ReadLine();
decimal order;
if (decimal.TryParse(orderInput, out decimal decimalOrder) && (decimalOrder >= 0))
{
    order = decimalOrder;
    Console.WriteLine($"\nYour order: {order}");
}
else
{
    Console.WriteLine("\nError. Please enter a valid invoice amount");
    return;
}

decimal discount = isStudying ? order * 0.10m : 0m;
decimal finalAmount = order - discount;

Console.WriteLine();
Console.WriteLine("==============================");
Console.WriteLine("           RECEIPT            ");
Console.WriteLine("==============================");
Console.WriteLine($"Customer:  {name}");
Console.WriteLine($"Age:       {age}");
Console.WriteLine($"Status:    {(isStudying ? "Student" : "Regular")}");
Console.WriteLine("------------------------------");
Console.WriteLine($"Order:     {order}");
Console.WriteLine($"Discount:  -{discount} {(isStudying ? "(10% student)" : "")}");
Console.WriteLine("------------------------------");
Console.WriteLine($"TOTAL:     {finalAmount}");
Console.WriteLine("==============================");
Console.WriteLine("   Thank you for your order!  ");
Console.WriteLine("==============================");