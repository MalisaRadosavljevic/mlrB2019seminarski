#include <iostream>
#include <cmath>
using namespace std;

int main() {
	const double PI = atan(1.0) * 4;
	int r, H;
	cin >> r >> H;
	double V = r * r * PI * H;
	cout << V << endl;
   
   return 0;
}