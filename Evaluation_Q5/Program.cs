namespace Evaluation_Q5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Printing multiplication table");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (num * i));
            }
            Console.WriteLine("Factorial of " + num + "is:");
            int fact = 1;
            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);



        }
    }
}
