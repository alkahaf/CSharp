class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What day is it today?");
        String day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("Its Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Its Tuesday");
                break;
            default:
                Console.WriteLine(day + "Not found!!");
                break;
        }
        Console.ReadKey();
    }
}