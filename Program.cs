namespace Assigment
{
    internal class Program
    {
        #region Q1
        /*static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }*/
        #endregion

        #region Q2
        /*static void CalculateCircle(
          double radius,
          out double area,
          out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }
        */
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result = " + Add(num1, num2));
                    break;

                case "-":
                    Console.WriteLine("Result = " + Subtract(num1, num2));
                    break;

                case "*":
                    Console.WriteLine("Result = " + Multiply(num1, num2));
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("Result = " + Divide(num1, num2));
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            */
            #endregion

            #region Q2
            /*
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area;
            double circumference;

            CalculateCircle(radius, out area, out circumference);

            Console.WriteLine("Area = " + area);
            Console.WriteLine("Circumference = " + circumference);*/
            #endregion
        }
    }
}
