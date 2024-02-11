using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string digits = "";

        while (number > 0)
        {
            int digit = number % 10;
            digits = digit + "," + digits;
            number /= 10;
        }

        Console.WriteLine("Цифры числа через запятую: " + digits.TrimEnd(','));
    }
}