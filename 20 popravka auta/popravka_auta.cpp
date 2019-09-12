#include <iostream>

using namespace std;
//функција која сортира низ целих бројева у растућем поретку
void sortiraj_rastuce(int niz[],int n)
{
	int i,j;
	int min;
	int pom;
	
	for(i = 0; i < n-1; i++)
	{
		min = i;
		for(j = i + 1; j < n; j++)
		   if(niz[j] < niz[min])
			min = j;
		if(min != i)
		{
			pom = niz[i];
			niz[i] = niz[min];	
			niz[min] = pom;
		}
	}

}

int main(){

	int n,k,S,suma_k = 0;
	int cene[100];
	
	cin >> S;
	cin >> k;
	cin >> n;
//учитамо цене у низ
	for(int i = 0; i < n; i++)
		cin >> cene[i];
 //сортирамо низ цена у растућем поретку
	sortiraj_rastuce(cene,n);
//саберемо првих к најнижих цена
	for(int i = 0; i < k; i++)
		suma_k += cene[i];
//уколико је сума првих к мања од понуђене суме S
	if(suma_k < S)
		cout << "MOGUCE" << endl;
//уколико је сума првих к veћa од понуђене суме S
	else{
		cout << "NIJE MOGUCE" << endl;
		cout << suma_k << endl;
	}


	return 0;
}