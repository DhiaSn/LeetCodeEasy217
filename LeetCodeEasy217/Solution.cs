using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy217
{
    public static class Solution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seenNumbers = [];

            foreach (int num in nums)
                if (!seenNumbers.Add(num))
                    return true;
                
            return false; 
        }
    }
}
