using System;

class Program
{
    static void Main(string[] args)
    {
	int m,n;
     
	    //��������� ���������� 
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
          
        //��� �� ������ �������� ���� ������ �� ���� 
	if(20*m>10*n)
            Console.WriteLine("������");
	//��� �� ���� �������� ���� ������ �� ������
	else if(20*m<10*n)
            Console.WriteLine("����");
	//��� �� �������� ������ ��� ������
	else
            Console.WriteLine("��������");
           
    }
}
