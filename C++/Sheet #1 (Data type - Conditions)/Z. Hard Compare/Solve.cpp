#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    long long x , y , a, b;
    cin >> x >> a >> y >> b;
 
    if (a*log(x) >  b*log(y))
        cout << "YES";
 
    else
        cout << "NO";
    return 0; 
}