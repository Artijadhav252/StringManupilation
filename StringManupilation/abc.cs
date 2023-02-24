

public class Program
{
    public static void Main()
    {
        string FirstName, MiddleName, LastName, FullName;

        Console.WriteLine("Please enter your firstname");
        FirstName = Console.ReadLine();


        Console.WriteLine("Please enter your MiddleNme");
        MiddleName = Console.ReadLine();


        Console.WriteLine("Please enter your LastName");
        LastName = Console.ReadLine();

        FullName = FirstName + " " + MiddleName + " " + LastName;

        Console.WriteLine(FullName);

    }
}