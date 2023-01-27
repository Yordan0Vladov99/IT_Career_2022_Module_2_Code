namespace Task_11
{
    internal class Program
    {
        static void Main()
        {
            string sep = System.Console.ReadLine();
            string type = System.Console.ReadLine();
            byte parity = Convert.ToByte(type == "even");
            int n = int.Parse(System.Console.ReadLine());
            string word = "";
            for (int i = 0; i < n; i++)
            {
                string str = System.Console.ReadLine();
                if (i % 2 == parity)
                {
                    word += str + sep;
                }
            }

            System.Console.WriteLine(word.Remove(word.Length - 1));
        }
    }
}