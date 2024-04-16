// See https://aka.ms/new-console-template for more information

Main();
return;

void Main()
{
    Console.WriteLine("Hello world!");
    
    Console.WriteLine("Please enter an integer:");
    String input = Console.ReadLine() ?? string.Empty;
    Int32 upper = Convert.ToInt32(input);
    Console.WriteLine("\n\n");
    for (int i = 0; i <= upper; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        } else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        } else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}