class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats wheather Outside");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (temp >= 30 && temp <= 50)
        {
            Console.WriteLine("It's a Warm day");
        }
        else if (temp <= -50 || temp > 100)
        {
            Console.WriteLine("DO NOT GO OUTSIDE");
        }
        Console.ReadKey();
    }
}