char[,] charArray = new char[,] {
    {'S', 'N', 'O', 'O', 'P'},
    {'D', 'O', 'O', 'O', 'G'}
};

string result = string.Join(" ", charArray.Cast<char>());
Console.WriteLine(result);