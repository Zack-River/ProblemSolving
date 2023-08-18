#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    /*
    floor 10 / 3 = 3
    ceil 10 / 3 = 4
    round 10 / 3 = 3
    */
    float x , y;
    cin >> x >> y;
        cout << "floor "<< x << " / " << y << " = " << floor(x/y)<<endl;
        cout << "ceil "<< x << " / " << y << " = " << ceil(x/y)<<endl;
        cout << "round "<< x << " / " << y << " = " << round(x/y);
    return 0; 
}