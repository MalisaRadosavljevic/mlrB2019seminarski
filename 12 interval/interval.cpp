#include <iostream>
#include<iomanip>
using namespace std;

int main(){
	
	int n,a,b;
	double x,proizvod = 1; // производ иницијализујемо на неутрал за множење
	bool indikator = false; //индикатор нам служи да проверимо да ли се неки број налази у траженом интервалу 
                                 //  и на почетку претпоставимо да немамо бројева у траженом интервалу

	cin >> n;
	cin >> a;
	cin >> b;

//користимо петљу да учитамо n броја
	for(int i = 1; i <= n; i++){

		 //у свакој итерацији петље учитамо један број
		cin >> x;

		//ако је учитани број у траженом интервалу онда га додамо у производ
		if(x >= a && x <= b){
			proizvod *= x;

			 //променимо вредност индикатора
			if(indikator == false)
			  indikator = true;
		}
	}	
	
	 //ако немамо ниједан  број у траженом интервалу
	if(indikator == false)
		cout << "NEMA BROJEVA U DATOM INTERVALU" << endl;
	else
		cout << fixed<< showpoint << setprecision(3)<< proizvod << endl;
	return 0;
}