#include <iostream>
#include<iomanip>
using namespace std;

int main(){
	
	int n,a,b;
	double x,proizvod = 1; // �������� ������������� �� ������� �� ������
	bool indikator = false; //��������� ��� ����� �� ��������� �� �� �� ���� ��� ������ � �������� ��������� 
                                 //  � �� ������� ������������� �� ������ ������ � �������� ���������

	cin >> n;
	cin >> a;
	cin >> b;

//��������� ���� �� ������� n ����
	for(int i = 1; i <= n; i++){

		 //� ����� �������� ���� ������� ����� ���
		cin >> x;

		//��� �� ������� ��� � �������� ��������� ���� �� ������ � ��������
		if(x >= a && x <= b){
			proizvod *= x;

			 //��������� �������� ����������
			if(indikator == false)
			  indikator = true;
		}
	}	
	
	 //��� ������ ������  ��� � �������� ���������
	if(indikator == false)
		cout << "NEMA BROJEVA U DATOM INTERVALU" << endl;
	else
		cout << fixed<< showpoint << setprecision(3)<< proizvod << endl;
	return 0;
}