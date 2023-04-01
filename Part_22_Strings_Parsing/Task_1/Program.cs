using System.Linq;
namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            char[] arr = Enumerable.Repeat((char)0, 256).ToArray();
            string[] input = Console.ReadLine().Split(' ');
            string first = input[0];
            string second = input[1];
            bool isExchangeable = true;
            if (first.Length < second.Length)
            {
                isExchangeable = false;
            }
            else
            {

                for (int i = 0; i < first.Length; i++)
                {
                    char f = first[i];
                    char c = second[i];
                    if (arr[(int)f] == (char)0)
                    {
                        arr[(int)f] = c;
                    }
                    else if (arr[(int)f] != c)
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            System.Console.WriteLine(isExchangeable);
        }
    }
}