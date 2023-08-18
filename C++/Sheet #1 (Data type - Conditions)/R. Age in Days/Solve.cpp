#include <bits/stdc++.h>
 
using namespace std;
 
int main()
{
    int iday, day , month ,year;
    cin >> iday;
 
    year = iday / 365;
    month = (iday % 365) / 30;
    day = (iday % 365) % 30;
 
    cout
    << year << " years" << "\n"
    << month << " months" << "\n"
    << day << " days";
 
    return 0; 
}