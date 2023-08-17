#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int x , z , r;
    char y , s;
    cin >> x >> y >> z >> s >> r;
 
    switch(y)
    {
        case '+':
            if(x+z == r)
                cout << "Yes";
            else
                cout << x+z;
            break;
 
        case '-':
            if(x-z == r)
                cout << "Yes";
            else
                cout << x-z;
            break;
 
        case '*':
            if(x*z == r)
                cout << "Yes";
            else
                cout << x*z;
            break;
 
        default:
            break;
    }
    return 0; 
}