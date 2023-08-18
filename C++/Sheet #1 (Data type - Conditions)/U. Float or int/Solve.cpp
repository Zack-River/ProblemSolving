#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    float x;
    cin >> x;
    float y = x - int(x);
 
    if( y == 0)
    {
        cout << "int "<< (int)x;
    }
 
    else
    cout << "float "<< (int)x << " " << y;
    return 0; 
}