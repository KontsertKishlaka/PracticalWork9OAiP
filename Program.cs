namespace PracticalWork9OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ЗАДАНИЕ 1: Калькулятор с обработкой исключений\n");

        try
        {
            Console.WriteLine("Введите первое число: ");
            float firstNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            float secondNumber = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Введите символ операции: ");
            char operation = Convert.ToChar(Console.ReadLine());

            float result = Calculate(firstNumber, secondNumber, operation);
            Console.WriteLine($"Результат вычисления: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка! Нельзя делить на ноль.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка! Введено некорректное значение. Пожалуйста, вводите только числа.");
        }
        catch (Exception)
        {
            Console.WriteLine("Произошла неизвестная ошибка!");   
        }
        finally
        {
            Console.WriteLine("\nЗавершение программы.");
        }


        Console.WriteLine("ЗАДАНИЕ 2: Конвертация строки в дату\n");

        try
        {
            Console.WriteLine("Введите строку с датой: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"\nВаша дата: {date}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка! Введено некорректное значение. Пожалуйста, корректную дату.");
        }
        finally
        {
            Console.WriteLine("\nЗавершение программы.");
        }
    }

    private static float Calculate(float firstNumber, float secondNumber, char operation)
    {
        switch (operation)
        {
            case '+':
                return firstNumber + secondNumber;
            case '-':
                return firstNumber - secondNumber;
            case '/':
                if (secondNumber == 0)
                {
                    throw new DivideByZeroException();
                }
                return firstNumber / secondNumber;
            case '*':
                return firstNumber % secondNumber;
            default:
                throw new Exception();
        }
    }
}