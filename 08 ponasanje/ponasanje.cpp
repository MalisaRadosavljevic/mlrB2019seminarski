#include <iostream>

using namespace std;

int main(){

	int p,o;

	//������� �������� �������
	cin >> p;
	
	//��� �� ������ ����� ������ ��������� "���������"
	if(p > 5)
	   cout << "POHVALITI" << endl;

	 //��� �� ������ ���� ������ ���� �� �������� ������� � ����� �� ���������� 
	else 
	{

	   //��������� ����� �� ����������
	   cin >> o;
	   if(o < 4)
	   	cout << "ISPITATI" << endl;
	   else
		cout << "IZBACITI" << endl;
	}
	 
	return 0;
}