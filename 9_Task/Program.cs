// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    Console.WriteLine("Калькулятор в C#\r");
    Console.WriteLine("Введите число и нажмите Enter");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число и нажмите Enter");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Выберите вариант из списка:");
    Console.WriteLine("\ta - Сложить");
    Console.WriteLine("\ts - Вычесть");
    Console.WriteLine("\tm - Умножить");
    Console.WriteLine("\td - Разделить");
    switch (Console.ReadLine())
    {
        case "a":
            Console.WriteLine($"Результат: {0} + {1} = " + (number1 + number2));
            break;
        case "s":
            Console.WriteLine($"Результат: {0} - {1} = " + (number1 - number2));
            break;
        case "m":
            Console.WriteLine($"Результат: {0} * {1} = " + (number1 * number2));
            break;
        case "d":
            Console.WriteLine($"Результат: {0} / {1} = " + number1 / number2);
            break;
        default:
            Console.WriteLine("Нет операции с указанным номером");
            break;
    } 
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.Write("Нажмите любую клавишу, чтобы закрыть калькулятор...");