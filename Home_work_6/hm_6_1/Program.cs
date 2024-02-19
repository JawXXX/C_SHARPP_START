char[,] charArray = new char[,] {
    {'H', 'e', 'l', 'l', 'o'},
    {'W', 'o', 'r', 'l', 'd'}
};

string result = string.Join(" ", charArray.Cast<char>());
Console.WriteLine(result);