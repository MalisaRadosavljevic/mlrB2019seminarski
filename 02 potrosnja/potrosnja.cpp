#include <iostream>
#include <iomanip>

using namespace std;

int main(){
	
	
	int kapacitet,S;
	double potrosnja;

	//учитавање капацитета резервоара и пређеног пута са пуним резервоаром
	cin >> kapacitet;
	cin >> S;

	//израчунавање потрошње
	potrosnja = ((double)kapacitet/S)*100;

	//испис потрошње заокружен на три децимале
	cout << setprecision(3) << fixed << potrosnja << endl;


	return 0;
}