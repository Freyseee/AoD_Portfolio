using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Recursion
    {

        public bool additive(string s)
        {

            if (s.Length < 3) return false; //Nothing left to check

            int num = s[2] - '0'; //returns the value so we dont get the ASCII value :)
            int sum = (s[0] - '0') + (s[1] - '0'); //The sum it should equal to return true

            if(num == sum) return true; 

            string new_string = s.Substring(1); //Removes the first value because we dont need it

            return additive(new_string); //Try with the updated string

        }

    }
}
