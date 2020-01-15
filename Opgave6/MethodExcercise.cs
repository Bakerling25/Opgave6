using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave6
{
    class MethodExcercise
    {
        public int[] RotateRight(int[] inputArr,int numberOfSteps)
        {
            int rotateNum = numberOfSteps;
            int[] outputArr = new int[inputArr.Length];
            for (int i = 0; i < inputArr.Length -1; i++)
            {
                if (i + (inputArr.Length -1) <= inputArr.Length)
                {
                    outputArr[i + numberOfSteps] = inputArr[i];
                }
                else
                {
                    outputArr[]
                }
            }
            return outputArr;
        }
    }
}
