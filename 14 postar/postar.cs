using System;

class Program
{
	//������ ��� ��������� �� �� �� ��� �����
        static bool prost_broj(int x)
        {
            //�� ������� ������������� �� �� �� �����
            bool prost = true;

            
            for(int i = 2; i < x; i++)
                //����������� �� �� ������ ���� ������� ����� ����
                if (x % i == 0)
                {
                    //��� ������� ������ ���� ��� ��� �����
                    prost = false;
                    break;
                }

            return prost;
        }

    static void Main(string[] args)
    {
	int n,zbir=0; // � ��������� zbir ������ ��� ��� � ����� �� ������� �����

            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
                //����������� �� �� �� ����� ��� ��� �����
                if (prost_broj(i))
                    //��� �� ����� ��� ��� ����� ������ ����� �� ���� �� ���
                    zbir ++;

            Console.WriteLine(zbir);
           
    }
}
