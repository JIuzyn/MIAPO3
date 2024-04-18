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

    static double Calculate(double num1, double num2, char operation)
    {
        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Деление на ноль невозможно!");
                    Environment.Exit(0);
                }
                break;

            default:
                Console.WriteLine("Некорректная операция!");
                Environment.Exit(0);
                break;
        }

        return result;
    }
}