using System;

class Program
{
    static void Main(string[] args)
    {
	int m,n,br_polica;

	    //��������� ���������� ������ � ��� ������ ��� �����           
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
	    
		//������������ ���� ��������� ������
		br_polica=(m+n-1)/m;
               
	     //����� ���� ��������� ������ �� ����� n ������
             Console.WriteLine(br_polica);
           
    }
}
