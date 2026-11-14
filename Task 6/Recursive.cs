using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Recursive
    {




        public int sumDivisibleBy3(int N)
        {
            N = N - N % 3; //Get closest value divisible by 3

            if (N == 0) //equal to because it only takes positive numbers (can't be less than 0)
            {
                return 0;
            }

            if(N == 3) //We dont need to add the 0 its thee same result
            {
                return 3;
            }

            return N + sumDivisibleBy3(N - 3);

        }
    }
}
