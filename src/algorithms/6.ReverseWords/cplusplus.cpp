/// https://leetcode.com/problems/reverse-words-in-a-string/
class Solution {
public:
    
    void reverse(string &s,int begin,int end){
        while(begin<=end){
            swap(s[begin],s[end]);
            begin++;
            end--;
        }
    }
    
    string reverseWords(string A) {
        /// step 1
        int begin = 0;
        int end = 0;
        while(end<A.size()){
            if(A[end]==' '){
                reverse(A,begin,end-1);
                end++;
                begin = end;
            }else{
                end++;
            }
        }
        reverse(A,begin,end-1);   /// last word
        
        reverse(A,0,A.size()-1); /// reversing complete string
        
        string help;
        
        int i=0;
        while(A[i]==' ') i++;   /// leading spaces
        while(i<A.size()){
            if(A[i]==' '){
                help.push_back(' ');
                i++;                        //// multiplce space into single space
                while(A[i]==' ') i++;
            }else{
                help.push_back(A[i]);
                i++;
            }
        }
        
        /// trailing space
        if(help.back()==' ') help.pop_back();
        
        
        return help;
    }
};