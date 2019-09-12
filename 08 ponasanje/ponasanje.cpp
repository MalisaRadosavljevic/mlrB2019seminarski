#include <iostream>

using namespace std;

int main(){

	int p,o;

	//уносимо понашање ученика
	cin >> p;
	
	//ако се ученик добро понаша исписујемо "ПОХВАЛИТИ"
	if(p > 5)
	   cout << "POHVALITI" << endl;

	 //ако се ученик лоше понаша онда је потребно учитати и оцену са контролног 
	else 
	{

	   //учитавање оцене са контролног
	   cin >> o;
	   if(o < 4)
	   	cout << "ISPITATI" << endl;
	   else
		cout << "IZBACITI" << endl;
	}
	 
	return 0;
}