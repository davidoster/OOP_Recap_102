using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Recap_103
{
    class Program
    {
        Func<int, float> doSomething = x => x / 1.0f;

        static void Main(string[] args)
        {

            int[] a = new int[2];
            a[0] = 10;
            a[1] = 20;

            int[,] myA = new int[1,1];
            myA[0, 0] = 0;

            int[,] myB = new int[2, 1]; // new int[[]]
            myB[0, 0] = 50;
            myB[1, 0] = 60;

            int[,] myC = new int[2,2];
            myC[1, 1] = 80;


            int[][] myD = new int[1][];
            myD[0] = new int[2];
            myD[0][0] = 10;
            myD[0][1] = 20;

            int[][][] myE = new int[2][][];
            myE[0] = new int[1][];

            int[,,] myF = new int[5,5,5];
            myF[0, 0, 0] = 10;


            Console.WriteLine(doCalc(a[0],10));
            Func<int, int> myFunc = x => x + 2;
            Console.WriteLine(myFunc(2));

            Func<int, int, int> doCalcLambda = (x, y) => x + y;
           
            Console.WriteLine(doCalcLambda(2,3));
            doCalcLambda = (x, y) => x - y;
            Console.WriteLine(doCalcLambda(1,2));
        }

        static int doCalc(int x, int y)
        {
            return (x + y);
        }
    }
}
