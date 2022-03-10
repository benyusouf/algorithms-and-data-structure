/*
There are A islands and there are M bridges connecting them. Each bridge has some cost attached to it.

We need to find bridges with minimal cost such that all islands are connected.

It is guaranteed that input data will contain at least one possible scenario in which all islands are connected with each other.

Input Format:

The first argument contains an integer, A, representing the number of islands.
The second argument contains an 2-d integer matrix, B, of size M x 3:
    => Island B[i][0] and B[i][1] are connected using a bridge of cost B[i][2].

*/
/// <summary>
/// https://www.interviewbit.com/problems/commutable-islands/
/// </summary>
class Solution {
    public int solve(int N, List<List<int>> edges) {
        edges.Sort( (a,b) => a[2].CompareTo(b[2]));

        int[] parents = new int[N+1];
        int cost = 0;
        MakeSet(N, parents);

        for(int i = 0; i < edges.Count; i++){
            int s = edges[i][0], d = edges[i][1];
            int rs = Find(s, parents), rd = Find(d, parents);

            if(rs != rd){
                cost += edges[i][2];

                parents[rs] = rd;
            }
        }
        return cost;
    }

    public void MakeSet(int N, int[] parents){
        for(int i = 1; i<=N; i++){
            parents[i] = i;
        }
    } 

    public int Find(int i, int[] parents){
        while(parents[i] != i){
            i = parents[i];
        }
        return i;
    }
}
