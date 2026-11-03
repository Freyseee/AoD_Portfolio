using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Recursion
    {


        public int RecursiveAdd(int n)
        {
            //If the input value is not in range, return -1 
            if (n < 1) return -1; 

            //If the value is not odd, we skip it and call the function with the next odd number
            if (n%2 == 0)
            {
                return 0 + RecursiveAdd(n - 1);
            }

            //If the number is equal to 1, we have gone through all odd numbers
            if (n == 1)
            {
                return 1;
            }

            //Returns the odd number's squared value and calls the function with the next odd value
            return (n * n) + RecursiveAdd(n - 2);

        }

    }
}
