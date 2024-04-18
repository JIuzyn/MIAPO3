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
    // Дальше функции идут
    static double Calculate(double num1, double num2, char operation)
    {
        double result = 0;
        // Через свитчи мы прописываем функции 
        switch (operation)
        {
            // Функция сложения
            case '+':
                result = num1 + num2;
                break;
            // Функция вычитания
            case '-':
                result = num1 - num2;
                break;
            // Функция умножения
            case '*':
                result = num1 * num2;
                break;
            // Функция деления
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
            // Обработка исключений
            default:
                Console.WriteLine("Некорректная операция!");
                Environment.Exit(0);
                break;
        }
        return result;
    }
}