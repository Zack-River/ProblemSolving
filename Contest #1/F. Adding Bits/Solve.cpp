#include<bits/stdc++.h>
using namespace std;
 
int main(){
  int x , y , a, b;
  int dec = 0;
  cin >> x >> y;
 
  for(int i = 0 ; i < 32 ; i++){
      a = x % 2;
      b = y % 2;
      x /= 2;
      y /= 2;
      if(a != b)
      dec += pow(2,i);
  }
  cout << dec;
}