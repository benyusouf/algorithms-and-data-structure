/*
You are given a read only array of n integers from 1 to n.

Each integer appears exactly once except A which appears twice and B which is missing.

Return A and B.

Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Note that in your output A should precede B.
*/
/// <summary>
/// https://www.interviewbit.com/problems/repeat-and-missing-number-array/
/// </summary>
class Solution {
    public List<int> repeatedNumber(List<int> A) {
        long sum = 0, squareSum = 0, temp = 0;

        for(int i = 0; i < A.Count; i++){
            temp = A[i];
            sum += temp;
            sum -= (i + 1);

            squareSum += temp * temp;

            squareSum -= (long)(i + 1) * (long)(i + 1);
        }

        long sumAB = squareSum/sum;
        List<int> result = new List<int> {Convert.ToInt32((sumAB + sum)/2)};

        result.Add(Convert.ToInt32(sumAB -result[0]));
        return result;
    }
}
