/// https://leetcode.com/problems/longest-common-prefix/
class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {        
         string ans = "";
        if(strs.size()==0) return "";
        
        string s = strs[0]; 
        
        for(int i=0;i<s.size();i++){
            for(int j=1;j<strs.size();j++){
                if(i>=strs[j].size() || s[i] != strs[j][i]){
                    return ans;
                }
            }
            ans.push_back(s[i]);
        }
        return ans;
        
    }
};