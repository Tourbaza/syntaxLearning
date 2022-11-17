using System;

double a, b;

Console.WriteLine("Введите первое число");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Введите операцию");
switch (Console.ReadLine())
{
    case "+":
        Console.WriteLine(a + b);
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    case "/":
        if (b == 0)
        {
            Console.WriteLine("Ты идиот?");
            break;
        }
        Console.WriteLine(a / b);
        break;
    case "^":
        Console.WriteLine(Math.Pow(a, b));
        break;
    default:
        Console.WriteLine("Ты по моему перепутал");
        break;
}

