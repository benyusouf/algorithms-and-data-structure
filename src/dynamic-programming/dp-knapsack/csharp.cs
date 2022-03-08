class Solution {
    public int solve(List<int> values, List<int> weights, int C) {
        //return Knapsack(values, weights, C, 0);
        if(C == 0) return 0;
        int n = weights.Count;
        if(n == 0) return 0;

        int[,] matrix = new int[n+1, C+1];

        for(int i = 0; i <= n; i++){
            for(int j = 0; j <= C; j++){
                if(j == 0 || i == 0){
                    matrix[i, j] = 0;
                }
                else if(weights[i-1] > j){
                    matrix[i,j] = matrix[i-1,j];
                }
                else{
                    int include = values[i-1] + matrix[i-1, j - weights[i-1]];
                    int exclude = matrix[i-1,j];

                    matrix[i, j] = Math.Max(include, exclude);
                }
            }
        }

        return matrix[n,C];
    }
}
