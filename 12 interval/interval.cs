using System;

class Program
{
    static void Main(string[] args)
    {
	int n, a, b;
        double x,proizvod = 1; // �������� ������������� �� ������� �� ������
        bool indikator = false; /* ��������� ��� ����� �� ��������� �� �� �� ���� ��� ������ � �������� ��������� 
                                   � �� ������� ������������� �� ������ ������ � �������� ���������*/
            
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            //��������� ���� �� ������� n ����
            for(int i = 1; i <= n; i++)
            {
                //� ����� �������� ���� ������� ����� ���
                x= double.Parse(Console.ReadLine());

                //��� �� ������� ��� � �������� ��������� ���� �� ������ � ��������
                if(x>=a && x <= b)
                {
                    proizvod *= x;

                    //��������� �������� ����������
                    if (indikator == false)
                        indikator = true;
                }
            }

            //��� ������ ������  ��� � �������� ���������
            if (indikator == false)
                Console.WriteLine("���� ��Σ��� � ����� ���������");
            
            else
                Console.WriteLine(proizvod.ToString("0.000"));
           
    }
}
