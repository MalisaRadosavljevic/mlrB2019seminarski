#include <iostream>

using namespace std;

int main(){

	double k,h,BMI;
	
	 //��������� ������ � ������
	cin >> k;
	cin >> h;

	 //������������ BMI
	BMI = k / (h * h);

	if(BMI < 18.5)
		cout << "NEUHRANJENOST" << endl;
	else if(18.5 <= BMI && BMI < 30)
		cout << "IDEALNA MASA" << endl;
	else
		cout << "GOJAZNOST" << endl;
	 
	return 0;
}