class Program
{
    static int A(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return A(m - 1, 1);
        }
        else
        {
            return A(m - 1, A(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 1;
        int n = 3;
        int result = A(m, n);
        Console.WriteLine($"Аккерман({m}, {n}) = {result}");
    }
}