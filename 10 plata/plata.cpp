#include <iostream>
#include <iomanip>

using namespace std;

int main(){

	int O,P;	
	double Plata;
	
	//учитавање оцене и основне плате
	cin >> O;
	cin >> P;

	//ако је наставник изузетан
	if(O == 10){
		Plata = P + P*0.15;
		cout << "Izuzetan" << endl;
		cout << setprecision(3) << fixed << Plata << endl;
	}

	 //ако је наставник јако лош
	else if(O <= 3){
		Plata = P - P*0.15;
		cout << "Jako los" << endl;
		cout << setprecision(3) << fixed << Plata << endl;
	}
//ако је наставник просечан или одличан
	else{
		Plata = P + P * ((double)O/100);
		//ако је наставник просечан
		if(O==4 || O == 5){
			cout << "Prosecan" << endl;
			cout << setprecision(3) << fixed << Plata << endl;
		}
		//ако је наставник одличан
		else{
			cout << "Odlican" << endl;
			cout << setprecision(3) << fixed << Plata << endl;	
		}
	}
	return 0;
}