

public class Program
{
    public static void Main()
    {
        //  string FirstName, MiddleName, LastName, FullName;

        // Console.WriteLine("Please enter your firstname");
        //  FirstName = Console.ReadLine();


        // Console.WriteLine("Please enter your MiddleNme");
        //  MiddleName = Console.ReadLine();


        // Console.WriteLine("Please enter your LastName");
        //  LastName = Console.ReadLine();

        // FullName = FirstName + " " + MiddleName + " " + LastName;

        // Console.WriteLine(FullName);


        //calculate length of the string

      //  Console.WriteLine("Please enter any string");
        //  var str = Console.ReadLine();  //Welcome
                                         //
                                         // int counter = 0;

        // foreach (var item in str)
        // {
        //    counter++;
        // }
        // Console.WriteLine("length of the string ="+counter);


        //calculate the vowels of the string

        Console.WriteLine("please enter any  string");
        var str = Console.ReadLine();  //welcome

        int VowelsCountr = 0;
        foreach (var item in str)
           {

            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u'||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
                {
                VowelsCountr++;
            }
           }

        Console.WriteLine("length of the string="+ VowelsCountr);
        

        
        

        
    }
}