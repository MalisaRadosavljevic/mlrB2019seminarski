using System;

class Program
{
    static void Main(string[] args)
    {
 	int p,o;
     
            //������� �������� �������
            p = int.Parse(Console.ReadLine());

            //��� �� ������ ����� ������ ��������� "���������"
            if (p > 5)
		 Console.WriteLine("���������");

            //��� �� ������ ���� ������ ���� �� �������� ������� � ����� �� ���������� 
            else
            {
                //��������� ����� �� ����������
               o = int.Parse(Console.ReadLine());
                
               if(o<4)
                 Console.WriteLine("��������");
               else
                 Console.WriteLine("��������");
            }

           
    }
}
