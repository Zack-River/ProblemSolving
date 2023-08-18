#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int a , b ,c;
    cin >> a >> b >> c;
    cout << min(min(a,b), min(b,c))<< " " << max(max(a,b), max(b,c));
    return 0; 
}