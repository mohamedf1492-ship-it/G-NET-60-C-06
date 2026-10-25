namespace Assigment
{
    #region Q3
    /*enum Grade
    {
        A, B, C, D, F
    }
    */
    #endregion
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

        #region Q3

        /*
           static Grade GetGrade(int score)
        {
            if (score >= 90)
                return Grade.A;
            else if (score >= 80)
                return Grade.B;
            else if (score >= 70)
                return Grade.C;
            else if (score >= 60)
                return Grade.D;
            else
                return Grade.F;
        }

        static double CalculateAverage(int[] scores)
        {
            int sum = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            return (double)sum / scores.Length;
        }

        static void GetMinMax(
            int[] scores,
            out int min,
            out int max)
        {
            min = scores[0];
            max = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                    min = scores[i];

                if (scores[i] > max)
                    max = scores[i];
            }
        }*/
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

            #region Q3
            /*
            int[] scores = new int[5];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(
                    "Enter score for Student " + (i + 1) + ": ");

                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n--- Report ---");

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(
                    "Student " + (i + 1) + ": " +
                    scores[i] + " -> Grade: " +
                    GetGrade(scores[i]));
            }

            double average = CalculateAverage(scores);

            int min;
            int max;

            GetMinMax(scores, out min, out max);

            Console.WriteLine("\nAverage: " + average);
            Console.WriteLine("Highest Score: " + max);
            Console.WriteLine("Lowest Score: " + min);*/
            #endregion
        }
    }
}
