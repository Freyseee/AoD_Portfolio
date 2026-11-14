using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class VotingSystem
    {

        public int votingResult(int[] votes)
        {
            if (votes.Length == 0) return -1;

            //candidates
            int[] results = new int[votes.Max()];

            for (int i = 0; i < votes.Length; i++)
            {
                int candidate = votes[i];
                results[candidate - 1]++;

                if (results[candidate - 1] > votes.Length / 2)
                    return candidate;
            }


            return -1;
        }

    }
}
