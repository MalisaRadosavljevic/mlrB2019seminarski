#include <iostream>

using namespace std;

int main(){

	int m,n;
	
	//учитавање променљивих 
	cin >> m;
	cin >> n;
	
	 //ако је Јелена сакуписа више чепова од Нине 
	if(2*m>n)
	   cout << "Jelena" << endl;
	//ако је Нина сакупила више чепова од Јелене
	else if(2*m<n)
	   cout << "Nina" << endl;
        //ако су сакупиле једнак број чепова
	else
	   cout << "NERESENO" << endl;

	return 0;
}