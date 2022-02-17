/// https://www.hackerrank.com/challenges/manasa-and-factorials


#include <bits/stdc++.h>

using namespace std;

string ltrim(const string &);
string rtrim(const string &);

/*
 * Complete the 'solve' function below.
 *
 * The function is expected to return a LONG_INTEGER.
 * The function accepts LONG_INTEGER n as parameter.
 */

 long GetDifference(long n){
        long temp = n, count = 0;
        
        while(temp >= 5){
            temp = (temp/5);
            count += temp;
        }
        return count;
    }
    
    long solve(long n)
    {
        if(n > 5){
            long res = n*5-(n-(n%5));
            long deff = GetDifference(res);
            
            while(deff < n){
                res += 5;
                deff = GetDifference(res);
            }
            return res;
        }
        else{
            return n * 5;
        }
    }

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string t_temp;
    getline(cin, t_temp);

    int t = stoi(ltrim(rtrim(t_temp)));

    for (int t_itr = 0; t_itr < t; t_itr++) {
        string n_temp;
        getline(cin, n_temp);

        long n = stol(ltrim(rtrim(n_temp)));

        long result = solve(n);

        fout << result << "\n";
    }

    fout.close();

    return 0;
}

string ltrim(const string &str) {
    string s(str);

    s.erase(
        s.begin(),
        find_if(s.begin(), s.end(), not1(ptr_fun<int, int>(isspace)))
    );

    return s;
}

string rtrim(const string &str) {
    string s(str);

    s.erase(
        find_if(s.rbegin(), s.rend(), not1(ptr_fun<int, int>(isspace))).base(),
        s.end()
    );

    return s;
}
