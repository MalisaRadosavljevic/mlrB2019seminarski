#include <iostream>

using namespace std;

int main(){

	int m,n;
	
	//��������� ���������� 
	cin >> m;
	cin >> n;
	
	 //��� �� ������ �������� ���� ������ �� ���� 
	if(2*m>n)
	   cout << "Jelena" << endl;
	//��� �� ���� �������� ���� ������ �� ������
	else if(2*m<n)
	   cout << "Nina" << endl;
        //��� �� �������� ������ ��� ������
	else
	   cout << "NERESENO" << endl;

	return 0;
}