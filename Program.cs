using System.Numerics;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                if (float.TryParse(args[0], out float num1) && float.TryParse(args[2], out float num2))
                {
                    float res = 0;

                    string oper = args[1];
                    if (oper == "+")
                    {
                        res = num1 + num2;
                    }
                    if (oper == "-")
                    {
                        res = num1 - num2;
                    }
                    if (oper == "*")
                    {
                        res = num1 * num2;
                    }
                    if (oper == "/")
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("Деление на 0 невозможно");
                            return;
                        }
                        else
                        {
                            res = num1 / num2;
                        }

                    }
                    Console.WriteLine("Результат выполнения операции (" + oper + ") = " + res);
                }
                else
                    Console.WriteLine("Введите два числа и укажите необходиую операцию через пробел, например 2 * 2");
            }
            else
            {
                Console.WriteLine("Введите два числа и укажите необходиую операцию через пробел, например 2 * 2");
            }
        }
    }
}
