#include <iostream>
#include <iomanip>

using namespace std;

int main(){
	
	
	int kapacitet,S;
	double potrosnja;

	//��������� ���������� ���������� � ������� ���� �� ����� �����������
	cin >> kapacitet;
	cin >> S;

	//������������ ��������
	potrosnja = ((double)kapacitet/S)*100;

	//����� �������� ��������� �� ��� ��������
	cout << setprecision(3) << fixed << potrosnja << endl;


	return 0;
}