class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();
        while(name =="")
        {
            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();
        }
        Console.WriteLine("hello " + name);
        Console.ReadKey();
    }
}
