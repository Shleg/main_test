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
