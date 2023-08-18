#include<bits/stdc++.h>
using namespace std;
#define ll  long long
 
int main(){
  ll n , m , k , out = 0;
  cin >> n >> m >> k;
  while(n != 0 || k != 0){
    
    if(m == 0){
      
      if(n/2 >= k){
        out += k;
        cout << out;
        return 0;
      }
 
      else{
        out += n/2;
        cout << out;
        return 0;
      }
  }
    else if(m > n && k > n){
      out += n;
      cout << n;
      return 0;
    }
 
    else if(m > k && n > k){
      out += k;
      cout << out;
      return 0;
    }
 
    else{
      n -= m;
      k -= m;
      out += m;
      m = 0;
    }
 
  }
 
  cout << out;
 
}