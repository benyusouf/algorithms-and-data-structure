int Solution::coverPoints(vector<int> &X, vector<int> &Y) {
   int count = 0;
   for(int i=1;i<X.size();i++){
       count += max(abs(X[i] - X[i-1]) , abs(Y[i] - Y[i-1]));
   }
   return count;
   
}
