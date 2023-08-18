#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int A,B,C,D;
    cin >> A >> B >> C >> D;
    long long X =(((long long)A * B))-((long long)C * D);
    cout << "Difference = " << X;
    return 0; 
}