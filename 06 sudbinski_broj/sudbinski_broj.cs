using System;

class Program
{
    static void Main(string[] args)
    {
	int d,m,g,suma=0; //���� �� ����������� ���� ������ ������ ���� �� �� ������������� �� ������� �� ��������
        int d0, d1, m0, m1, g0, g1, g2, g3;
            
	    //��������� ������ ����
            d = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            g = int.Parse(Console.ReadLine());

		//������� ������ ���� ����
		d0 = (d / 1) % 10;
		d1 = (d / 10) % 10;

		//������� ������ ������ ����
		m0 = (m / 1) % 10;
		m1 = (m / 10) % 10;

		//������� ������ ������ ����
		g0 = (g / 1) % 10;
		g1 = (g / 10) % 10;
		g2 = (g / 100) % 10;
		g3 = (g / 1000) % 10;

		//�������� ���� �������� ������ ������ ����
		suma = d0 + d1 + m0 + m1 + g0 + g1 + g2 + g3;
	
	    //�������� ����� ���� ��� ��� �� ������� ����������� ���
	    while(suma>=10){
		int c0=suma%10;
		int c1=(suma/10)%10;
		
		suma=c0+c1;
	    }

                 Console.WriteLine(suma);

           
    }
}
