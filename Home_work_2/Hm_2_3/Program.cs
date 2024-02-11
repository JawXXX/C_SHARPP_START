using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 0;

        if (number >= 10 && number <= 99)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                number /= 10;
            }

            Console.WriteLine("Наибольшая цифра числа: " + maxDigit);
        }
        else
        {
            Console.WriteLine("Число не входит в диапазон [10, 99]");
        }
    }
}