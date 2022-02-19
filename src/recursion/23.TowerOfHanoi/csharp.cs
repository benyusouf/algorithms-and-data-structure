using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.recursion
{
    public class Solution
    {
        static int Hanoi(int n){
            if(n == 0) return 0;

            return Hanoi(n-1) + 1 + Hanoi(n-1);
        }
    }
}