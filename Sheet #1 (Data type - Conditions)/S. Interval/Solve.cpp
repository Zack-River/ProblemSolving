#include <bits/stdc++.h>
 
using namespace std;
 /*
        Given a number X. Determine in which of the following intervals the number X belongs to:
 
        [0,25], (25,50], (50,75], (75,100]
 
        The symbol '(' represents greater than.
        The symbol ')' represents smaller than.
        The symbol '[' represents greater than or equal.
        The symbol ']' represents smaller than or equal.
*/
int main()
{
    float x;
    cin >> x;
 
    if (x > 0 && x <= 25)
                cout << "Interval [0,25]";
                
    else if (x > 25 && x <= 50)
                cout << "Interval (25,50]";
 
    else if (x > 50 && x <= 75)
                cout << "Interval (50,75]";
 
    else if (x > 75 && x <= 100)
                cout << "Interval (75,100]";
 
    else
        cout << "Out of Intervals";
    return 0; 
}