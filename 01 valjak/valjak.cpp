#include<iomanip>
#include <cmath>
#include <iostream>

using namespace std;

int main()
{
    double r,H,V;

//��������� ������������ � ������ �����
cin >> r;
cin >> H;

//������������ ���������
V=r*r*H*M_PI;

 //����� ��������� ��������� �� ��� ��������
cout  << fixed << showpoint<<setprecision(3)<<V << endl;
    return 0;
}
