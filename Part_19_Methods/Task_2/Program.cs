namespace Task_2
{
    internal class Program
    {
        static void printSign(int number)
        {
            if (number < 0)
            {
                System.Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                System.Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                System.Console.WriteLine("The number 0 is zero.");
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            printSign(n);
        }
    }
}