using System;

class Program
{
    static void Main(string[] args)
    {
	int broj,c0,c1,c2,c3;
        double aritmeticka_sredina;

	    //��������� ��������������� ����
            broj = int.Parse(Console.ReadLine());

		//������� ������ ��������������� ����
		c0 = (broj / 1) % 10;
		c1 = (broj / 10) % 10;
            	c2 = (broj / 100) % 10;
            	c3 = (broj / 1000) % 10;

		//�������� ����������� �������
           	aritmeticka_sredina = (double)(c0 + c1 + c2 + c3) / 4;

	    //����� ����������� ������� ��������� �� ��� ��������
            Console.WriteLine(aritmeticka_sredina.ToString("0.000"));
           
    }
}
