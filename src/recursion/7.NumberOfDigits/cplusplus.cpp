class Solution {
public:
    int findDigits(int n) {
        if(n < 10) return 1;

        return FindDigits(n/10) + 1;
    }
};