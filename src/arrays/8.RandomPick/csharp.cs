/*
You are given a 0-indexed array of positive integers w where w[i] describes the weight of the ith index.

You need to implement the function pickIndex(), which randomly picks an index in the range [0, w.length - 1] (inclusive) and returns it. The probability of picking an index i is w[i] / sum(w).

For example, if w = [1, 3], the probability of picking index 0 is 1 / (1 + 3) = 0.25 (i.e., 25%), and the probability of picking index 1 is 3 / (1 + 3) = 0.75 (i.e., 75%).
*/

/// <summary>
/// https://leetcode.com/problems/random-pick-with-weight/
/// </summary>
public class Solution {

        private int[] _bucket;
        private Random _random = new Random();

        public Solution(int[] w)
        {
            _bucket = new int[w.Length];
            int max = 0;
            for (int i = 0; i < w.Length; i++)
            {
                max += w[i];
                _bucket[i] = max;
            }
        }

        public int PickIndex()
        {
            int idx = _random.Next(0, _bucket.Last()) + 1;
            int res = Array.BinarySearch(_bucket, idx);
            return res >= 0 ? res : -res - 1;
        }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */