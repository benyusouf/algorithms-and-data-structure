/// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
#include <vector>
class Solution {
public:
    int findMin(vector<int>& A) {
        int s=0;
        int n = A.size();
        int e = n-1;
        
        while(s<=e){
            int mid = (s+e)/2;
            int next = (mid+1)%n;
            int prev = (mid-1+n)%n;
            
            if(A[mid]<=A[prev] && A[mid]<=A[next]){
               /// how many times a sorted array is rotated
               ///return mid;
                
                return A[mid];
            }else if(A[mid]<=A[e]){
                e = mid - 1;
            }else if(A[mid] >= A[s]){
                s = mid + 1;
            }
        }
        return -1;  /// compilation purpose
    }
};