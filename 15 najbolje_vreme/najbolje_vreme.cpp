#include <iostream>

using namespace std;

int main(){
	
	int n,min,indikator,t;
	//������� ������ ���� �� ���� �����
	cin >> n;
	//������� ����� ��� �� �������� �������� ����� ������
	cin >> t;
	//������������� �� �� � ����� ������ ��� ������
	min = t;
	indikator = 1;
	
	 //�������� �� ������� ��� n-1 ����� ��� �� ��������
	for(int i=2; i <= n; i++)
	{
		cin >> t;
		if(t <= min)
		{	//��� �� � i-��� ������ ��� ������ ���� ��������� ���������
			min = t;
			indikator = i;
		}
	}
	cout << indikator << endl;

	return 0;
}