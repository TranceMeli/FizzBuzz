namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz\n");

            for (int x = 1; x <= 100; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine(x + " FizzBuzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine(x + " Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine(x + " Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
            Console.Read();
        }
    }
}
