using System;

class Program
{
    static void Main(string[] args)
    {
	int O, P;
        double Plata; //����� ����� ��������
     
            //��������� ����� � ������� �����
            O=int.Parse(Console.ReadLine());
            P=int.Parse(Console.ReadLine());

            //��� �� ��������� ��������
            if (O == 10)
            {
		Plata = P + P*0.15;
                Console.WriteLine("��������");
                Console.WriteLine(Plata.ToString("0.000"));
            }

            //��� �� ��������� ���� ���
            else if (O <= 3)
            {
                Plata = P - P * 0.15;
                Console.WriteLine("���� ���");
                Console.WriteLine(Plata.ToString("0.000"));
            }

            //��� �� ��������� �������� ��� �������
            else
            {
                Plata = P + P*(double)O/100;

                //��� �� ��������� ��������
                if(O==4 || O == 5)
                {
                    Console.WriteLine("��������");
                    Console.WriteLine(Plata.ToString("0.000"));
                }

                //��� �� ��������� �������
                else
                {
                    Console.WriteLine("�������");
                    Console.WriteLine(Plata.ToString("0.000"));
                }
            }
           
    }
}
