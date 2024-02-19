class Program
{

    static void Main(string[] args)
    {
        int[] myArray = { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 };

        Console.WriteLine;

        for (int i = myArray.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(myArray[i]);
        }

        Console.ReadLine();
    }
}