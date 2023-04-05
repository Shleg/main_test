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


string[] TruncateArray(string[] array, int maxStrLength = 3, int minStrLength = 0)
{
    string[] truncatedArray = Array.FindAll(array, s => s.Length <= maxStrLength && s.Length > minStrLength);
    return truncatedArray;
}


void PrintArray(string[] array, string message)
{
    Console.WriteLine($"{message}: [{string.Join(",", array)}]");
}


void Main()
{
    int numStrings = InputUserData("How many strings are in the array?: ");
    string[] myArray = CreateStringArray(numStrings);
    Console.WriteLine();
    PrintArray(myArray, "Original array");
    string[] myTruncatedArray = TruncateArray(myArray);
    Console.WriteLine();
    PrintArray(myTruncatedArray, "Truncated array");
}


Main();
