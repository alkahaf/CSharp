class Program {

    static void Main(String[] args)
    {
        Console.Write("Enter number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns:");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter special sign:");
        String sign = Console.ReadLine();

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Console.Write(sign);
            }
            Console.WriteLine();
        }
    }

}
