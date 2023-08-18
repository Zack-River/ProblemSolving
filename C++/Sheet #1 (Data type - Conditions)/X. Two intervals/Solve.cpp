#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int x1 ,x2 ,y1 , y2;
    cin >> x1 >> x2 >> y1 >> y2;
 
    if ( max(x1,y1) > min(x2,y2))
    cout << -1;
 
    else
    cout<< max(x1,y1) << " " << min(x2,y2);
    return 0; 
}