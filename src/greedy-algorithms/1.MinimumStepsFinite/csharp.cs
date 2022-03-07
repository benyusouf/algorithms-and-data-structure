

class Solution {
    public int coverPoints(List<int> A, List<int> B) {
        if(A == null || B == null) return 0;
        if(A.Count != B.Count) return 0;

        int ans = 0;

        for(int i = 0; i < A.Count -1; i++){
            ans += Math.Max(Math.Abs(B[i+1] - B[i]), Math.Abs(A[i+1] - A[i]));
        }

        return ans;
    }
}
