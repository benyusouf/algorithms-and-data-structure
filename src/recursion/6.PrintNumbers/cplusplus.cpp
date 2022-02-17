#include<bits/stdc++.h>
using namespace std;

void print(int n){
   /// Base case
   if(n==0){
      return;    /// mandatory
   }

   /// Recursive case
   print(n-1);     ///  1 2 3 4 ......n-1

   cout<<n<<endl;
    return;    /// optional
}

void print2(int n){
   /// Base case
   if(n==0){
      return;    /// mandatory
   }

   cout<<n<<endl;

   /// Recursive case
   print2(n-1);     ///n-1.....2 1
    /// return;    optional
}

int main(){
     print2(5);
    return 0;
}
