using System;

class Program
{
    //������� ��� �� ���� ���� � ������ ����� ������ �� ���� ������ �� �����
    static int u_minute(int sati, int minuti)
        {
            return sati * 60 + minuti;
        }


    static void Main(string[] args)
    {
	int h, m, hh, mm;
        int minuti_spavanja;
	
	    //��������� ����������
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            hh = int.Parse(Console.ReadLine());
            mm = int.Parse(Console.ReadLine());
            
 		//��������� ������ ������� � ��������
		minuti_spavanja = u_minute(hh, mm) - u_minute(h, m);

	    //������� �� �� �� ������ ������ � ����� ���������� ������
            if (minuti_spavanja >= 135)
                Console.WriteLine("���Ί�� �� ������");
            else
                Console.WriteLine("�ȣ� ���Ί�� ������");
           
    }
}
