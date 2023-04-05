int InputUserData(string messageToUser)
{
    int result;
    Console.Write(messageToUser);
    while (!(int.TryParse(Console.ReadLine(), out result) & (result > 0)))
    {
        Console.WriteLine("You must enter a positive integer!!!");
        Console.WriteLine();
        Console.Write(messageToUser);
    }

    return result;
}


string[] CreateStringArray(int length)
{
    string[] stringArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter {i + 1} string: ");
        stringArray[i] = Console.ReadLine();
    }

    return stringArray;
}


