using System;

class Program
{
    static void Main(string[] args)
    {
	int n,min,indikator,t;
        
	    //������� ������ ���� �� ���� �����
            n = int.Parse(Console.ReadLine());

            //������� ����� ��� �� �������� �������� ����� ������
            t = int.Parse(Console.ReadLine());

            //������������� �� �� � ����� ������ ��� ������
            min = t;
            indikator = 1;

            //�������� �� ������� ��� n-1 ����� ��� �� ��������
            for (int i = 2; i <= n; i++)
            {   
                t = int.Parse(Console.ReadLine());
               
                if (t <= min)
                {    //��� �� � i-��� ������ ��� ������ ���� ��������� ���������
                    min = t;
                    indikator = i;
                }

            }
            Console.WriteLine(indikator);
           
    }
}
