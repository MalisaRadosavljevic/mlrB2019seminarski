using System;

class Program
{
    static void Main(string[] args)
    {
	double k,h,BMI;

            //��������� ������ � ������
            k = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

                //������������ BMI
		BMI = k / (h * h);


            if (BMI < 18.5)
                Console.WriteLine("������������");

            else if(18.5 <= BMI && BMI<30)
                Console.WriteLine("������ ����");
            else
                Console.WriteLine("�Σ������");
           
    }
}
