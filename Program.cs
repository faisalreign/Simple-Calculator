using System;

namespace Calculator_by_Faisal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First value = ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter The Operator = ");
            string op = Console.ReadLine();

            Console.Write("Enter the Second value = ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if(op=="+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else if (op == ">")
            {
                Console.WriteLine(num1 > num2);
            }
            else if (op == "<")
            {
                Console.WriteLine(num1 < num2);
            }
            else
            {
                Console.WriteLine("You Enter Invalid Operator...");
            }

            Console.ReadKey();
        }
    }
}
