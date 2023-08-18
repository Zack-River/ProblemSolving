#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int x , z;
    char y;
    cin >> x >> y >> z;
 
    switch(y)
    {
        case '>':
            if(x > z)
                cout << "Right";
            else
                cout << "Wrong";
            break;
 
        case '<':
            if(x < z)
                cout << "Right";
            else
                cout << "Wrong";
            break;
 
        case '=':
            if(x == z)
                cout << "Right";
            else
                cout << "Wrong";
            break;
 
        default:
            break;
    }
    return 0; 
}