using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку.");
            }
        }
    }

    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        number = Math.Abs(number);

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum % 2 == 0;
    }
}