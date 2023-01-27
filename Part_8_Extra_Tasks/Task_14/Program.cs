namespace Task_14
{
    internal class Program
    {
        static void Main()
        {

            char first_boat = System.Console.ReadLine()[0];
            char second_boat = System.Console.ReadLine()[0];
            int first_sum = 0;
            int second_sum = 0;
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = System.Console.ReadLine();
                if (word == "UPGRADE")
                {
                    first_boat = (char)((int)first_boat + 3);
                    second_boat = (char)((int)second_boat + 3);
                }
                else if (i % 2 == 0)
                {
                    first_sum += word.Length;
                    if (first_sum >= 50)
                    {
                        break;
                    }
                }
                else
                {
                    second_sum += word.Length;
                    if (second_sum >= 50)
                    {
                        break;
                    }
                }

            }
            if (first_sum > second_sum)
            {
                System.Console.WriteLine(first_boat);
            }
            else
            {
                System.Console.WriteLine(second_boat);
            }

        }
    }
}