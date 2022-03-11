vector<int> Solution::repeatedNumber(const vector<int> &arr) {
    long long sum = 0;   /// A-B
    long long squareSum = 0;
    long long temp;
    for(int i=0;i<arr.size();i++){
        temp = arr[i];
        sum += temp;
        sum -= (i+1);
        
        squareSum += (temp*temp);
        squareSum -= (long long)(i+1)*(long long)(i+1);
    }
    long long sumAB = squareSum/sum;   /// A+B
    int A = (sum + sumAB)/2;
    int B = sumAB - A;
    
    vector<int> ans;
    ans.push_back(A);
    ans.push_back(B);
    return ans;
}
