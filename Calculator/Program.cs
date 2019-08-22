using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator Press any key to continue");
            Console.ReadKey();
            int number1 = 0; //used as the first number
            int number2 = 0; //used as the second number
            int answer = 0;
            string operation = "";
            bool calculator = true; //states that calculator is on
            while (calculator == true)
            {
                Console.WriteLine("what operation do you want to do [add,subtract,multiply,division,quit]");
                operation = Console.ReadLine();
                if (operation == "add")
                {
                    addition();
                }
                else if (operation == "subtract")
                {
                    subtract();
                }
                else if (operation == "multiply")
                {
                    multiply();
                }
                else if (operation == "division")
                {
                    division();
                }
                else if (operation == "quit")
                {
                    calculator = false;
                }
                bool addition()
                {
                    Console.WriteLine("please input first number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please input second number");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    answer = number1 + number2;
                    Console.WriteLine(answer);
                    return true;
                }
                bool subtract()
                {
                    Console.WriteLine("please input first number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please input second number");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    answer = number1 - number2;
                    Console.WriteLine(answer);
                    return true;
                }
                bool multiply()
                {
                    Console.WriteLine("please input first number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please input second number");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    answer = number1 * number2;
                    Console.WriteLine(answer);
                    return true;
                }
                bool division()
                {
                    Console.WriteLine("please input first number");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please input second number");
                    number2 = Convert.ToInt32(Console.ReadLine());
                    answer = number1 / number2;
                    Console.WriteLine(answer);
                    return true;
                }
            }
        }
    }
}
