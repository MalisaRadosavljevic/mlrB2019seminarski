#include <iostream>

using namespace std;

//������ ��� ��������� �� �� �� ��� �����
bool prost_broj(int x){

	 //�� ������� ������������� �� �� �� �����
	bool prost = true;
	
	for(int i=2; i < x; i++)

	     //����������� �� �� ������ ���� ������� ����� ����
	     if(x % i == 0){

		//��� ������� ������ ���� ��� ��� �����
		prost = false;
		break;
		}
	return prost;
}

int main(){
	
	int n,zbir = 0;// � ��������� zbir ������ ��� ��� � ����� �� ������� �����

	cin >> n;
	
	for(int i=2; i <= n; i++)

		//����������� �� �� �� ����� ��� ��� �����
		if(prost_broj(i))

			//��� �� ����� ��� ��� ����� ������ ����� �� ���� �� ���
			zbir++;
	
	cout << zbir << endl;

	return 0;
}