#include<iomanip>
#include <cmath>
#include <iostream>

using namespace std;

int main()
{
    double r,H,V;

//учитавање полупречника и висине ваљка
cin >> r;
cin >> H;

//израчунавање запремине
V=r*r*H*M_PI;

 //испис запремине заокружен на три децимале
cout  << fixed << showpoint<<setprecision(3)<<V << endl;
    return 0;
}
