#include <iostream>

using namespace std;

//функција која за дате сате и минуте враћа колико је сати прошло од поноћи
int u_minute(int sati,int minuti){
	return sati * 60 + minuti;
}

int main(){

	int h,m,hh,mm;
	int minuti_spavanja;

	//учитавање променљивих
	cin >> h;
	cin >> m;
	cin >> hh;
	cin >> mm;
	
	//одређивање дужине спавања у минутима
	minuti_spavanja = u_minute(hh,mm) - u_minute(h,m);

	//провера да ли је довољно спавао и испис одговарајуће поруке
	if(minuti_spavanja >= u_minute(2,15))
		cout << "DOVOLJNO JE SPAVAO" << endl;
	else
		cout << "NIJE DOVOLJNO SPAVAO" << endl;
	
	return 0;
}