class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {m} до {n}:");
        PrintNumbers(m, n);
    }
}