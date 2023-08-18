#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int a, b , c;
 
    cin >> a >> b >> c;
    
    if (a >= b && a >= c)
    {
        if ( b >= c)
            cout << c << "\n" << b << "\n" << a;
        
        else
            cout << b << "\n" << c << "\n" << a;
    }
 
    else if (b > a && b >= c)
    {
        if ( a >= c)
            cout << c << "\n" << a << "\n" << b;
        
        else
            cout << a << "\n" << c << "\n" << b;
    }
 
    else
    {
        if ( a >= c)
            cout << b << "\n" << a << "\n" << c;
        
        else
            cout << a << "\n" << b << "\n" << c;
    }
 
    cout << "\n\n" << a << "\n" << b << "\n" << c;
 
    return 0; 
}