#include <iostream>

using namespace std;
//������� ��� ������� ��� ����� ������ � ������� �������
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
//������� ��� ������� ��� ����� ������ � �������� �������
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
//��������� ��� � ���� ���� ������ �����
	int cifre[10];
	
	cin >> n;
//������� ����� � ���
	for(int i = 0; i < n; i++)
		cin >> cifre[i];
 //��������� ����� � �������� �������
	sortiraj_opadajuce(cifre,n);
	for(int i = 0; i < n-1; i++)
//��������� ����� ��� �� ����� n-1 �����
		najveci = (najveci + cifre[i])*10;
 //������� ����� ���� ������ � ����
	najveci = najveci + cifre[n-1];
	cout << najveci << endl;	
//��������� ����� � ������� �������
	sortiraj_rastuce(cifre,n);
	for(int i = 0; i < n-1; i++)
//��������� ������ ��� �� ����� n-1 �����
		najmanji = (najmanji + cifre[i])*10;
 //������� ����� ���� ������ � ����
	najmanji = najmanji + cifre[n-1];
	cout << najmanji << endl;

	return 0;
}