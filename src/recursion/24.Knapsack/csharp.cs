class Solution {
    public int solve(List<int> values, List<int> weights, int C) {
        return Knapsack(values, weights, C, 0);
    }

    public int Knapsack(List<int> values, List<int> weights, int C, int s){
        if(C == 0) return 0;
        if(weights.Count - s == 0) return 0;

        if(weights[s] > C)
            return Knapsack(values, weights, C, s+1);
        else {
            int include = values[s] + Knapsack(values, weights, C-weights[s], s+1);
            int exclude = Knapsack(values, weights, C, s+1);

            return Math.Max(include, exclude);
        }
    }
}
