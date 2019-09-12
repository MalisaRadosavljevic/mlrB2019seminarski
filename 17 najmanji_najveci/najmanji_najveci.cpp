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
//функција која сортира низ целих бројева у опадајућем поретку
void sortiraj_opadajuce(int niz[],int n)
{
	int i,j;
	int max;
	int pom;
	
	for(i = 0; i < n-1; i++)
	{
		max = i;
		for(j = i + 1; j < n; j++)
		   if(niz[j] > niz[max])
			max = j;
		if(max != i)
		{
			pom = niz[i];
			niz[i] = niz[max];	
			niz[max] = pom;
		}
	}

}

int main(){
	
	int n,najveci = 0,najmanji = 0;
//направимо низ у коме ћемо чувати цифре
	int cifre[10];
	
	cin >> n;
//учитамо цифре у низ
	for(int i = 0; i < n; i++)
		cin >> cifre[i];
 //сортирамо цифре у опадајућем поретку
	sortiraj_opadajuce(cifre,n);
	for(int i = 0; i < n-1; i++)
//формирамо највећи број са првих n-1 цифра
		najveci = (najveci + cifre[i])*10;
 //последњу цифру само додамо у збир
	najveci = najveci + cifre[n-1];
	cout << najveci << endl;	
//сортирамо цифре у растућем поретку
	sortiraj_rastuce(cifre,n);
	for(int i = 0; i < n-1; i++)
//формирамо најмањи број са првих n-1 цифра
		najmanji = (najmanji + cifre[i])*10;
 //последњу цифру само додамо у збир
	najmanji = najmanji + cifre[n-1];
	cout << najmanji << endl;

	return 0;
}