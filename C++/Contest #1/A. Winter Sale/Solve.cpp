#include<bits/stdc++.h>
using namespace std;
 
int main(){
    double per , pra;
    double prb;
    cin >> per;
    cin >> pra;
 
    per = 100 - per; 
    per = 100 / per;
    prb = pra * per;
    cout << fixed << setprecision(2) << prb;
}
