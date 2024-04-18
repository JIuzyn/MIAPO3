using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию: +, -, * или /");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = Calculate(num1, num2, operation);

        Console.WriteLine("Результат: " + result);
    }