#include <iostream>

using namespace std;

//������� ��� �� ���� ���� � ������ ����� ������ �� ���� ������ �� �����
int u_minute(int sati,int minuti){
	return sati * 60 + minuti;
}

int main(){

	int h,m,hh,mm;
	int minuti_spavanja;

	//��������� ����������
	cin >> h;
	cin >> m;
	cin >> hh;
	cin >> mm;
	
	//��������� ������ ������� � ��������
	minuti_spavanja = u_minute(hh,mm) - u_minute(h,m);

	//������� �� �� �� ������ ������ � ����� ���������� ������
	if(minuti_spavanja >= u_minute(2,15))
		cout << "DOVOLJNO JE SPAVAO" << endl;
	else
		cout << "NIJE DOVOLJNO SPAVAO" << endl;
	
	return 0;
}