using System;

class Program
{
    static void Main(string[] args)
    {
	int kapacitet,S;
        double potrosnja;
		
	    //��������� ���������� ���������� � ������� ���� �� ����� �����������
            kapacitet = int.Parse(Console.ReadLine());
            S = int.Parse(Console.ReadLine());

		//������������ ��������
                potrosnja= ((double)kapacitet/S)*100;

	    //����� �������� ��������� �� ��� ��������
            Console.WriteLine(potrosnja.ToString("0.000"));
           
    }
}
