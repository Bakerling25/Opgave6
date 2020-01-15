using System;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 6, 3, 8, 9, 7 };
            int numberOfRightSteps = 3;
            MethodExcercise method = new MethodExcercise();
            foreach (int num in method.RotateRight(inputArray,numberOfRightSteps))
            {
                Console.Write(num);
            }
            Console.ReadLine();
        }
    }
}
