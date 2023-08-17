#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    long long w , x , y , z , r;
    cin >> w >> x >> y >> z;
 
    w = w % 100;
    x = x % 100;
    y = y % 100;
    z = z % 100;
    r = w * x * y * z;
 
    r= r % 100;
 
    if (r < 10)
    cout << 0 << r;
    else
    cout << r;
    return 0; 
}