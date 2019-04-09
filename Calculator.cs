using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write operation: ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Write second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Answer");

            int answer = 0;
            switch (operation)
            {
                case '+':
                    answer = firstNum + secondNum;
                    break;
                case '-':
                    answer = firstNum - secondNum;
                    break;
                case '*':
                    answer = firstNum * secondNum;
                    break;
                case '/':
                    answer = firstNum / secondNum;
                    break;
                case '%':
                    answer = firstNum % secondNum;
                    break;
                case '^':
                    answer = 1;
                    for(int i = 0; i < secondNum; i++)
                    {
                        answer *= firstNum;
                    }
                    break;
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
