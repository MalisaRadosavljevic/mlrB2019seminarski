#include <iostream>

using namespace std;

int main(){
	
	int t_1,t_2,t_3;
	int indikator,min; //у променљивој indikator чувамо редни број такмичара, а у променљивој min најбоље време

	cin >> t_1;
	cin >> t_2;
	cin >> t_3;

 //претпоставимо да је Аца најбржи
	min = t_1;
	indikator = 1;

//уколико је Јова бржи од Аце
	if(t_2 < min){
	   min = t_2;
	   indikator = 2;
	}	

 //уколико је Мики бржи од Аце и Јове
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