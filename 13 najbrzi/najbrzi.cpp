#include <iostream>

using namespace std;

int main(){
	
	int t_1,t_2,t_3;
	int indikator,min; //� ��������� indikator ������ ����� ��� ���������, � � ��������� min ����� �����

	cin >> t_1;
	cin >> t_2;
	cin >> t_3;

 //������������� �� �� ��� ������
	min = t_1;
	indikator = 1;

//������� �� ���� ���� �� ���
	if(t_2 < min){
	   min = t_2;
	   indikator = 2;
	}	

 //������� �� ���� ���� �� ��� � ����
	else if(t_3 < min){
	   min = t_3;
	   indikator = 3;
	}	

	if(indikator == 1)
		cout << "Aca" << endl;
	else if(indikator == 2)
		cout << "Jova" << endl;
	else
		cout << "Miki" << endl;

	return 0;
}