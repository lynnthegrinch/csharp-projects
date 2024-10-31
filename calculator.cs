using System.Numerics;
using System.Text.Json;

class Calculator
{
    static int Add(int value1, int value2)
    {return value1 + value2;}
    static int Sub(int value1, int value2)
    {return value1 - value2;}
    static int Mul(int value1, int value2)
    { return value1 * value2;}
    static int Div(int value1, int value2)
    {return (value1 / value2);}

    class Program
    {
        static void Main()
        {

            {
                Console.WriteLine("welcome to calculator");
                bool cal = true;
                while (cal)
                {
                Console.WriteLine("please pick an operation:");
                Console.WriteLine("1. Addition, 2. Subtraction, 3. Multiplication, 4. Division, 5. Exit");
                string reply = Console.ReadLine();
                int rep = Convert.ToInt32(reply);
                if (rep == 1)
                {
                    Console.WriteLine("please enter the first number");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("please enter the second number");
                    string num2 = Console.ReadLine();
                    Console.WriteLine(Add(Convert.ToInt32(num1), Convert.ToInt32(num2)));
                }
                else if (rep == 2)
                {
                    Console.WriteLine("please enter the first number");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("please enter the second number");
                    string num2 = Console.ReadLine();
                    Console.WriteLine(Sub(Convert.ToInt32(num1), Convert.ToInt32(num2)));
                }
                else if (rep == 3)
                {
                    Console.WriteLine("please enter the first number");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("please enter the second number");
                    string num2 = Console.ReadLine();
                    Console.WriteLine(Mul(Convert.ToInt32(num1), Convert.ToInt32(num2)));
                }
                else if (rep == 4)
                {
                    Console.WriteLine("please enter the first number");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("please enter the second number");
                    string num2 = Console.ReadLine();
                    Console.WriteLine(Div(Convert.ToInt32(num1), Convert.ToInt32(num2)));
                    }
                else if (rep == 5)
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                   else
                { Console.WriteLine("Sorry wrong option, try again");
                        continue;
            } }
                
            }

    }
} }
        
