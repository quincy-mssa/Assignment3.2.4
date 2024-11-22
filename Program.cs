namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input data
            Console.Write("Enter the First number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            //Call the method to pass all numbers as a params array
            CalculateTotalAndAverage(out double total, out double average, num1, num2, num3, num4);

            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
            Console.WriteLine($"The total is {total}");
        }

        static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
        {
            total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }

            //Avoid division by zero
            average = numbers.Length > 0 ? total / numbers.Length : 0;
        }
    }
}
