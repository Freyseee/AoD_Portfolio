using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Calculator
    {

        public int[] CloseToSquare(int[] arr)
        {

            int sum;
            int p; //potens

            int upper;
            int lower;

            int best = int.MaxValue; //highest valyue possible for int
            int[] result = new int[4]; //Saves the current best result

            for (int i = 0; i < arr.Length; i++)
            { // N


                for (int j = i + 1; j < arr.Length; j++) // N
                {


                    for (int k = j + 1; k < arr.Length; k++) // N                    Iterates through all possible outcomes
                    {

                        sum = arr[i] + arr[j] + arr[k];

                        for (p = 1; sum > Math.Pow(2, p); p++) { } // N            Find the first result where the power to 2 is above the sum

                        upper = (int)Math.Pow(2, p);
                        lower = (int)Math.Pow(2, p - 1);

                        if (upper - sum < sum - lower)                             // Compares the distances to find the current best result
                        {
                            if (upper - sum < best)
                            {
                                best = upper - sum;
                                result = [arr[i], arr[j], arr[k], upper];        //Updates values
                            }
                        }

                        else
                        {
                            if (sum - lower < best)
                            {
                                best = sum - lower;
                                result = [arr[i], arr[j], arr[k], lower];       //Updates values
                            }
                        }

                    }
                }
            }
            return result;
        }

    }
}