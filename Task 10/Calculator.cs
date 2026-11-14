using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Calculator
    {


        public int logTo(int N)
        {
            if(N == 1) return 0;
            if (N == 2) return 1;
            return 1 + logTo(N / 2);
        }


    }
}
