#include <iostream>
#include <iomanip>

using namespace std;

int main(){

	int O,P;	
	double Plata;
	
	//��������� ����� � ������� �����
	cin >> O;
	cin >> P;

	//��� �� ��������� ��������
	if(O == 10){
		Plata = P + P*0.15;
		cout << "Izuzetan" << endl;
		cout << setprecision(3) << fixed << Plata << endl;
	}

	 //��� �� ��������� ���� ���
	else if(O <= 3){
		Plata = P - P*0.15;
		cout << "Jako los" << endl;
		cout << setprecision(3) << fixed << Plata << endl;
	}
//��� �� ��������� �������� ��� �������
	else{
		Plata = P + P * ((double)O/100);
		//��� �� ��������� ��������
		if(O==4 || O == 5){
			cout << "Prosecan" << endl;
			cout << setprecision(3) << fixed << Plata << endl;
		}
		//��� �� ��������� �������
		else{
			cout << "Odlican" << endl;
			cout << setprecision(3) << fixed << Plata << endl;	
		}
	}
	return 0;
}