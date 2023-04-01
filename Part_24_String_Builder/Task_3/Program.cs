using System.Text;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            String[] girlEmail = Console.ReadLine().Split("@");
            int dif = 0;
            StringBuilder sb = new StringBuilder();
            foreach (char c in girlEmail[0])
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            foreach (char c in sb.ToString())
            {
                dif += c;
            }

            sb = new StringBuilder();
            foreach (char c in girlEmail[1])
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            foreach (char c in sb.ToString())
            {
                dif -= c;
            }

            Console.WriteLine(dif >= 0 ? "Call her!" : "She is not the one.");


        }
    }
}