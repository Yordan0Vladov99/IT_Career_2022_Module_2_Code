namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string res = "";
            int a_ind = a.Length - 1;
            int b_ind = b.Length - 1;
            int carry = 0;
            while (a_ind >= 0 && b_ind >= 0)
            {
                int a_c = (int)a[a_ind] - (int)'0';
                int b_c = (int)b[b_ind] - (int)'0';
                int sum = a_c + b_c + carry;
                carry = 0;
                if (sum >= 10)
                {
                    carry = 1;
                    sum %= 10;
                }
                res = sum + res;
                a_ind -= 1;
                b_ind -= 1;
            }

            while (a_ind >= 0)
            {
                int a_c = (int)a[a_ind] - (int)'0';
                int sum = a_c + carry;
                carry = 0;
                if (sum >= 10)
                {
                    carry = 1;
                    sum %= 10;
                }
                res = sum + res;
                a_ind -= 1;
            }

            while (b_ind >= 0)
            {
                int b_c = (int)b[b_ind] - (int)'0';
                int sum = b_c + carry;
                carry = 0;
                if (sum >= 10)
                {
                    carry = 1;
                    sum %= 10;
                }
                res = sum + res;
                b_ind -= 1;
            }
            if (carry == 1)
            {
                res = carry + res;
            }
            System.Console.WriteLine(res);
        }
    }
}