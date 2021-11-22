using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Recap_102
{
    public delegate int MyCalculation(int x, int y);
    class Program
    {
        
        static void Main(string[] args)
        {
            MyCalculation doOperation = null;
            //Console.WriteLine(doOperation(10,20));

            //doOperation = subtract;
            //Console.WriteLine(doOperation(10,20));

            int userX = Convert.ToInt32(Console.ReadLine());
            int userY = int.Parse(Console.ReadLine());

            char userOperation = (char)(Console.Read());
            Console.ReadLine();

            switch(userOperation)
            {
                case '-':
                    doOperation = subtract;
                    break;
                case '*':
                    doOperation = multiply;
                    break;
                case '/':
                    doOperation = divide;
                    break;
                case '+': 
                default:
                    doOperation = add;
                    break;
            }
            Console.WriteLine(doOperation(userX, userY));
            Console.ReadKey();
        }

        public static int add(int x, int y)
        {
            return (x + y);
        }

        public static int subtract(int x, int y)
        {
            return (x - y);
        }

        public static int multiply(int x, int y)
        {
            return (x * y);
        }

        public static int divide(int x, int y)
        {
            return (x / y);
        }
    }
}
