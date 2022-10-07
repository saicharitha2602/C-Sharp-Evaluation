namespace Evaluation_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements in array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(arr);
            Console.WriteLine("The minimum value of array is :" + arr[0]);
            Console.WriteLine("The maximum value of array is :" + arr[n - 1]);

        }
    }
}