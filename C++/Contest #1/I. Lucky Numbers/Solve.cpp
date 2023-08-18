#include<bits/stdc++.h>
using namespace std;
#define ll  long long
 
int main(){
 short x;
 cin >> x;
 
 if((x%10) % (x/10) == 0 || (x/10) % (x % 10) == 0)
  cout << "YES";
  else
  cout << "NO";
}