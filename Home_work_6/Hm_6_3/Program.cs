class Program
{
    static void Main()
    {
        string inputString = "оно";
        
        bool isPalindrome = IsPalindrome(inputString);

        if (isPalindrome)
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    static bool IsPalindrome(string str)
    {
        str = str.ToLower(); 
        int i = 0;
        int j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}