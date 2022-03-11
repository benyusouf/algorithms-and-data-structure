vector<int> Solution::flip(string A) {
    vector<int> ans(2, -1);
    int left = 0;
    int right = 0;
    int n = A.size();
    
    int maxSum = INT_MIN;
    int curSum = 0;
    for(int i=0;i<n;i++){
        if(A[i] == '0'){
            curSum += 1;
        }else{
            curSum -= 1;
        }
        if(curSum > maxSum){
            maxSum = curSum;
            right = i;
            ans[0] = left + 1;
            ans[1] = right + 1;
        }
        if(curSum<0){
            curSum = 0;
            left = i+1;
        }
    }
    if(maxSum == -1){
        ans.clear();
    }
    return ans;
}
