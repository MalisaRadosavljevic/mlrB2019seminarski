#include <iostream>

using namespace std;

int main(){

	int m,n,br_polica;

	//��������� ���������� ������ � ��� ������ ��� �����   
	cin >> m;
	cin >> n;

	//������������ ���� ��������� ������
	br_polica = (m+n-1)/m;

	//����� ���� ��������� ������ �� ����� n ������
	cout << br_polica << endl;


	return 0;
}