class Solution {
public:
    bool canFinish(int numCourses, vector<vector<int>>& pre) {
        unordered_map<int, vector<int>> graph;
        vector<int> indegree(numCourses, 0);
        
        for(int i=0;i<pre.size();i++){
            int ai = pre[i][0];
            int bi = pre[i][1];
            graph[bi].push_back(ai);
            indegree[ai]++;
        }
        
        queue<int> q;
        for(int i=0;i<indegree.size();i++){
            if(indegree[i] == 0){
                q.push(i);
            }
        }
        
        int finished = 0;
        while(q.size() > 0){
            int node = q.front();
            q.pop();
            finished++;
            
            vector<int> children = graph[node];
            for(int i=0;i<children.size();i++){
                indegree[children[i]]--;
                if(indegree[children[i]] == 0){
                    q.push(children[i]);
                }
            }
        }
        
        return finished == numCourses;
    }
};