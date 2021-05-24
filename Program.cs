using System;

namespace calculator
{
    class Program
    {
        private static readonly string[] expression = Console.ReadLine().Split(' ');
        private static double currentValue = Double.Parse(expression[0]);

        static void Main(string[] args)
        {
            double temp;
            for(int i = 0; i < expression.Length; i++)
            {
                switch (expression[i])
                {
                    case "+":
                        if(i < expression.Length - 2 && expression[i + 2] == "/")
                        {
                            temp = Double.Parse(expression[i + 1]) / Double.Parse(expression[i + 3]);
                            currentValue += temp;
                            i += 3;
                        }
                        else if (i < expression.Length - 2 && expression[i + 2] == "*")
                        {
                            temp = Double.Parse(expression[i + 1]) * Double.Parse(expression[i + 3]);
                            currentValue += temp;
                            i += 3;
                        }
                        else
                        {
                            currentValue += Double.Parse(expression[i + 1]);
                        }
                        break;

                    case "-":
                        if (i < expression.Length - 2 && expression[i + 2] == "/")
                        {
                            temp = Double.Parse(expression[i + 1]) / Double.Parse(expression[i + 3]);
                            Console.WriteLine();
                            currentValue -= temp;
                            i += 3;
                        }
                        else if (i < expression.Length - 2 && expression[i + 2] == "*")
                        {
                            temp = Double.Parse(expression[i + 1]) * Double.Parse(expression[i + 3]);
                            currentValue -= temp;
                            i += 3;
                        }
                        else
                        {
                            currentValue -= Double.Parse(expression[i + 1]);
                        }
                        break;

                    case "*":
                        currentValue *= Double.Parse(expression[i + 1]);
                        break;

                    case "/":
                        currentValue /= Double.Parse(expression[i + 1]);
                        break;
                }
            }

            Console.WriteLine(currentValue);
            Console.ReadKey();
        }
    }
}
