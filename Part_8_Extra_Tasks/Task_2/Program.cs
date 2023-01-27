namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            decimal num = decimal.Parse(System.Console.ReadLine());
            if ((int)num == num)
            {
                System.Console.WriteLine("integer");
            }
            else
            {
                System.Console.WriteLine("floating-point");
            }
        }
    }
}