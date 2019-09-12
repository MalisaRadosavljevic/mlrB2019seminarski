#include <iostream>

using namespace std;

int main(){

	int m,n,br_polica;

	//учитавање капацитета полице и број пехара које ређамо   
	cin >> m;
	cin >> n;

	//израчунавање броја потребних полица
	br_polica = (m+n-1)/m;

	//испис броја потребних полица за ређање n пехара
	cout << br_polica << endl;


	return 0;
}