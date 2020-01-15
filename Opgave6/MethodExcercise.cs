using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave6
{
    class MethodExcercise
    {
        public void RotateRight(int[] inputArr,int numberOfSteps, int length)
        {

            ReverseArr(inputArr, 0, length - 1);
            ReverseArr(inputArr, 0, numberOfSteps - 1);
            ReverseArr(inputArr, numberOfSteps, length - 1);

        }
        static void ReverseArr(int[] input, int start, int end)
        {
            while (start < end)
            {
                int temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }
        }
        public void PrintNumbers(int[] inputarr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(inputarr[i]);
            }
        }
    }
}
