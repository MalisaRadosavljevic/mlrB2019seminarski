using System;

class Program
{
    static void Main(string[] args)
    {
	double r,H,V;

	    //��������� ������������ � ������ �����
            r = double.Parse(Console.ReadLine());
            H = double.Parse(Console.ReadLine());

		//������������ ���������
                V = r * r * H*Math.PI;
	    
	    //����� ��������� ��������� �� ��� ��������
            Console.WriteLine(V.ToString("0.000"));
           
    }
}
