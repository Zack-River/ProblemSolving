#include<bits/stdc++.h>
using namespace std;
 
int main(){
    int o , e;
    cin >> o >> e;
    if(e == 0 && o == 0 ){
        cout << "NO";
        return 0;
    }
   if(e == o || e-o == 1 || o-e == 1)
   cout << "YES";
   else
   cout << "NO";
}