using System;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 3, 8, 9, 7, 6 }; //Expected Output [7,6,3,8,9] with number 2
            int numberOfRightSteps = 2;
            MethodExcercise method = new MethodExcercise();
            method.RotateRight(inputArray, numberOfRightSteps, inputArray.Length);
            method.PrintNumbers(inputArray, inputArray.Length);
            Console.ReadLine();
        }
    }
}
