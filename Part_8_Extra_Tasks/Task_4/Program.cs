namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            string unit = System.Console.ReadLine();
            double amount = double.Parse(System.Console.ReadLine());
            string converted_unit = "";
            double old_amount = amount;
            switch (unit)
            {
                case "miles":
                    amount *= 1.6;
                    converted_unit = "kilometers";
                    break;


                case "inches":
                    amount *= 2.54;
                    converted_unit = "centimetres";
                    break;


                case "feet":
                    amount *= 30;
                    converted_unit = "centimetres";
                    break;

                case "yards":
                    amount *= 0.91;
                    converted_unit = "meters";
                    break;
                case "gallons":
                    amount *= 3.8;
                    converted_unit = "liters";
                    break;
            }

            System.Console.WriteLine($"{old_amount:f2} {unit} = {amount:f2} {converted_unit}");
        }
    }
}