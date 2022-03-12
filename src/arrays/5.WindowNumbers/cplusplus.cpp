vector<int> Solution::dNums(vector<int> &A, int B) {
    unordered_map<int,int> mymap;
    vector<int> ans;
    if(B > A.size()){
        return ans;
    }
    for(int i=0;i<B;i++){
        mymap[A[i]]++;
    }
    ans.push_back(mymap.size());
    
    for(int i=B;i<A.size();i++){
        mymap[A[i]]++;
        mymap[A[i-B]]--;
        if(mymap[A[i-B]] == 0){
            mymap.erase(A[i-B]);
        }
        ans.push_back(mymap.size());
    }
    return ans;
    
    
}
