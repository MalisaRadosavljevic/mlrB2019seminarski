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

int main(){

	int n,k,S,suma_k = 0;
	int cene[100];
	
	cin >> S;
	cin >> k;
	cin >> n;
//������� ���� � ���
	for(int i = 0; i < n; i++)
		cin >> cene[i];
 //��������� ��� ���� � ������� �������
	sortiraj_rastuce(cene,n);
//�������� ����� � ������� ����
	for(int i = 0; i < k; i++)
		suma_k += cene[i];
//������� �� ���� ����� � ���� �� ������� ���� S
	if(suma_k < S)
		cout << "MOGUCE" << endl;
//������� �� ���� ����� � ve�a �� ������� ���� S
	else{
		cout << "NIJE MOGUCE" << endl;
		cout << suma_k << endl;
	}


	return 0;
}