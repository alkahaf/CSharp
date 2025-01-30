// See https://aka.ms/new-console-template for more information
Console.WriteLine("Random Numbers :");

Random random = new Random();

int num1 = random.Next();// if i not define range it generate 10 digit number.
int num2 = random.Next(0,6);// if i not define range it generate 10 digit number.

double num3 = random.NextDouble();


Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);
Console.ReadLine();