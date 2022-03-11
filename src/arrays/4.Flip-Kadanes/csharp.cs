/*
You are given a binary string A(i.e. with characters 0 and 1) consisting of characters A1, A2, ..., AN. In a single operation, you can choose two indices L and R such that 1 ≤ L ≤ R ≤ N and flip the characters AL, AL+1, ..., AR. By flipping, we mean change character 0 to 1 and vice-versa.

Your aim is to perform ATMOST one operation such that in final string number of 1s is maximised.

If you don't want to perform the operation, return an empty array. Else, return an array consisting of two elements denoting L and R. If there are multiple solutions, return the lexicographically smallest pair of L and R.

NOTE: Pair (a, b) is lexicographically smaller than pair (c, d) if a < c or, if a == c and b < d.
*/
/// <summary>
/// https://www.interviewbit.com/problems/flip/
/// </summary>
class Solution {
    public List<int> flip(string A) {
        List<int> result = new List<int>();

        int maxSum = int.MinValue, curSum = 0, start = 0, end = 0, s = 0;

        for(int i = 0; i < A.Length; i++){
            if(A[i] == '0') curSum += 1;
            else curSum += -1;
            
            if(maxSum < curSum){
                start = s;
                end = i;
                maxSum = curSum;
            }

            if(curSum < 0){
                curSum = 0;
                s = i + 1;
            }
        }

        if(maxSum == -1) return result;

        result.Add(start + 1);
        result.Add(end + 1);

        return result;
    }
}
