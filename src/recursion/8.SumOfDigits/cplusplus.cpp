class Solution {
public:
    int sumOfDigits(int n){
    if(n < 10) return n;

    return sumOfDigits(n/10) + n%10;
  }
};