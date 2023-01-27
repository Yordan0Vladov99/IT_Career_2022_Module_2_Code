namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            string first = System.Console.ReadLine();
            string last = System.Console.ReadLine();
            object sum = first + " " + last;
            string str_sum = (string)sum;
            System.Console.WriteLine(str_sum);
        }
    }
}