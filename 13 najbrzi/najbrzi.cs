using System;

class Program
{
    static void Main(string[] args)
    {
	int t_1,t_2,t_3;
        int indikator,min; /*� ��������� indikator ������ ����� ��� ���������,
                             � � ��������� min ����� �����*/

            t_1 = int.Parse(Console.ReadLine());
            t_2 = int.Parse(Console.ReadLine());
            t_3 = int.Parse(Console.ReadLine());

            //������������� �� �� ��� ������
            min = t_1;
            indikator = 1;

            //������� �� ���� ���� �� ���
            if (t_2 < min)
            {
                min = t_2;
                indikator = 2;
            }
            //������� �� ���� ���� �� ��� � ����
            else if (t_3 < min)
            {
                min = t_3;
                indikator = 3;

            }

            if (indikator == 1)
                Console.WriteLine("A��");
            else if(indikator==2)
                Console.WriteLine("����");
            else
                Console.WriteLine("����");
           
    }
}
