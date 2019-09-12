#include <iostream>

using namespace std;

int main(){
	
	int n,min,indikator,t;
	//учитамо колико пута је Јоца трчао
	cin >> n;
	//учитамо време које је постигао приликом првог трчања
	cin >> t;
	//претпоставимо да је у првом трчању био најбржи
	min = t;
	indikator = 1;
	
	 //потребно је учитати још n-1 време које је постигао
	for(int i=2; i <= n; i++)
	{
		cin >> t;
		if(t <= min)
		{	//ако је и i-том трчању био најбржи онда ажурирамо променљиве
			min = t;
			indikator = i;
		}
	}
	cout << indikator << endl;

	return 0;
}