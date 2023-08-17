#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    short x;
    cin >> x;
    x=x/1000;
    if(x%2 == 0)
    cout << "EVEN";
    else
    cout << "ODD";
    return 0; 
}