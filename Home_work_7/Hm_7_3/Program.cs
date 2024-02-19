class Program
{
    static void Main()
    {
        int[] array = { 12, 89, 78, 56, 46 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index < 0)
            return;

        Console.WriteLine(array[index]);
        PrintArrayReversed(array, index - 1);
    }
}
