using System;

class Program
{

	//������� ��� ������� ��� ����� ������ � ������� �������
        static void sortiraj_rastuce(int [] niz, int n)
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

    static void Main(string[] args)
    {
	int n,k,S,suma_k=0 ;
        int[] cene = new int[200];

            S = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

                //������� ���� � ���
            for (int i = 0; i < n; i++)
                cene[i]= int.Parse(Console.ReadLine());

            //��������� ��� ���� � ������� �������
            sortiraj_rastuce(cene,n);

            //�������� ����� � ������� ����
            for (int i = 0; i < k; i++)
                suma_k += cene[i];

            //������� �� ���� ����� � ���� �� ������� ���� S
            if (suma_k <= S)
                Console.WriteLine("���ӎ�");

            //������� �� ���� ����� � ve�a �� ������� ���� S
            else
            {
                Console.WriteLine("�ȣ� ���ӎ�");
                Console.WriteLine(suma_k);
            }
           
    }
}
