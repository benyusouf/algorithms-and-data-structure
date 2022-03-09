public class Solution {
    public bool CanFinish(int num, int[][] pre) {
        int finishedCount = 0;
        
        Dictionary<int, IList<int>> graph = new Dictionary<int, IList<int>>();
        int[] indegrees = new int[num];
        
        for(int i = 0; i < pre.Length; i++){
            int ai = pre[i][0], bi = pre[i][1];
            
            if(graph.ContainsKey(bi))
                graph[bi].Add(ai);
            else
                graph.Add(bi, new List<int>{ai});
            
            indegrees[ai] += 1;
        }
        
        Queue<int> q = new Queue<int>();
        
        for(int i = 0; i < indegrees.Length; i++){
            if(indegrees[i] == 0){
               q.Enqueue(i); 
            }
                
        }
        
        while(q.Count() > 0){
            int front = q.Dequeue();
            finishedCount++;
            
            if(graph.ContainsKey(front)){
                IList<int> children = graph[front];
            
            foreach(int child in children){
                indegrees[child]--;
                
                if(indegrees[child] == 0) q.Enqueue(child);
                }
            }
        }
        
        return finishedCount == num;
    }
}