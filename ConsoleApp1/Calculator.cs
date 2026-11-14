using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Calculator
    {




        public int[] algorithm(int Z)
        {

            if (Z < 27 || Z >= 100_000)
            {
                return [0, 0];
            }

            //First i find out what number cubed is roughly equal to Z
            int max = (int) Math.Cbrt(Z);
            //Now i have thee largest number X could be 

            int X;
            int Y;

            for(X = max; X >2; X--)
            {
                if (Z % X != 0) //If X doesnt go into Z then there can't be a solution
                {
                    continue;
                }
                   
                for (Y = 3; Math.Pow(X,Y) <= Z; Y++)
                {
                  
                    if(Math.Pow(X,Y) == Z)
                    {
                        return [X, Y];
                    }

                }
            }
            
            return [0, 0];
        }



    }
}
