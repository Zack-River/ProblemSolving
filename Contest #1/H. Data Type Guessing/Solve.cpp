#include<bits/stdc++.h>
using namespace std;
#define ll  long long
 
int main(){
 ll n , k , a;
 cin >> n >> k >> a;
 if((n*k)% a != 0) cout << "double";
 else if((n*k)/a > INT_MAX) cout << "long long";
 else cout << "int";
}