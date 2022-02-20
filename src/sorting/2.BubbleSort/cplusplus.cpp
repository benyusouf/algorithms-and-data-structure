#include<iostream>
using namespace std;

 void bubbleSort(int a[]){
    int n = sizeof(a)/sizeof(a[0]);

    for(int i = 1; i < n; i++){
      for(int j = 0; j < n-1; j++)
        if(a[j] > a[j+1])
          swap(a[j], a[j+1]);
    }
  }

int main(){
    int a[10] = {7, 8,3,1,0,3,7,5,4,2};
    bubbleSort(a);

    for(int i=0; i < sizeof(a)/sizeof(a[0]); i++){
      cout<<a[i]<<endl;
    }

  return 0;
}