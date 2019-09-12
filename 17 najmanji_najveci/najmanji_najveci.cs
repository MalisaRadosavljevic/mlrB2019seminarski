using System;

class Program
{
	//������� ��� ������� ��� ����� ������ � ������� �������
        static void sortiraj_rastuce(int[] niz, int n)
        {
            int i, j;
            int min;
            int pom;         
	   /* � ����� �������� ��� ���� ��������� �� ������ �������
            ��� ���������� niz[i], niz[i+1],...,niz[n-1], � ������� �� ��
            ������� i, ��� �� ������� �� ������ i �������� �� �������
            min, �� ��� �� ������� ������ �� ��������� ���������*/
            for (i = 0; i < n - 1; i++)
            {
                /* ��������� ���� ��������� ������� min, �� ��� �� ������
                   ������ �� ��������� niz[i], niz[i+1],...,niz[n-1]. */
                min = i;
                for (j = i + 1; j < n; j++)
                    if (niz[j] < niz[min])
                        min = j;
                /* ������ ��������� �� ��������� i � min. ��� �� ���� ����
                   ��� �� i � min ���������, ����� �� ���������� */
                if (min != i)
                {
                    pom = niz[i];
                     niz[i] = niz[min];
                    niz[min] = pom;
                   
                }
            }
        }

	//������� ��� ������� ��� ����� ������ � �������� �������
        static void sortiraj_opadajuce(int[] niz, int n)
        {
            int i, j;
            int max;
            int pom;         
	   /* � ����� �������� ��� ���� ��������� �� ����� �������
            ��� ���������� niz[i], niz[i+1],...,niz[n-1], � ������� �� ��
            ������� i, ��� �� ������� �� ������ i �������� �� �������
            max, �� ��� �� ������� ����� �� ��������� ���������*/
            for (i = 0; i < n - 1; i++)
            {
                /* ��������� ���� ��������� ������� max, �� ��� �� ������
                  ����� �� ��������� niz[i], niz[i+1],...,niz[n-1]. */
                max = i;
                for (j = i + 1; j < n; j++)
                    if (niz[j] > niz[max])
                        max = j;
                /* ������ ��������� �� ��������� i � max. ��� �� ���� ����
                   ��� �� i � max ���������, ����� �� ���������� */
                if (max != i)
                {
                    pom = niz[i];
                    niz[i] = niz[max];
                    niz[max] = pom;

                }
            }
        }

    static void Main(string[] args)
    {

	int n,najveci=0,najmanji=0;
        int[] cifre = new int[10]; //��������� ��� � ���� ���� ������ �����

            n = int.Parse(Console.ReadLine());
            
            //������� ����� � ���
            for(int i=0;i<n;i++)
                cifre[i] = int.Parse(Console.ReadLine());

            //��������� ����� � �������� �������
            sortiraj_opadajuce(cifre, n);


            for (int i = 0; i < n - 1; i++)
                //��������� ����� ��� �� ����� n-1 �����
                najveci = (najveci + cifre[i]) * 10;

            //������� ����� ���� ������ � ����
            najveci = najveci + cifre[n - 1];

            Console.WriteLine(najveci);

            //��������� ����� � ������� �������
            sortiraj_rastuce(cifre,n);

            for (int i = 0; i < n-1; i++)
                //������� �� ������� ����� ���� ���� ������� �� �� ������
                if(cifre[i]!=0)
                    //��������� ������ ��� �� ����� n-1 �����
                    najmanji = (najmanji +cifre[i])*10;

            //������� ����� ���� ������ � ����
            najmanji = najmanji + cifre[n - 1];

                Console.WriteLine(najmanji);

           
    }
}
