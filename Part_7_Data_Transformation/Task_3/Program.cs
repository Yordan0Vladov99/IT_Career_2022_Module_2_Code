namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            bool s = Convert.ToBoolean(System.Console.ReadLine().ToLower());
            if (s == true)
            {
                System.Console.WriteLine("Yes");
            }
            else
            {
                System.Console.WriteLine("No");
            }
        }
    }
}