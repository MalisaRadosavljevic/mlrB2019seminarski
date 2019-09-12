using System;

class Program
{
    static void Main(string[] args)
    {
	double k,h,BMI;

            //учитавање тежине и висине
            k = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

                //израчунавање BMI
		BMI = k / (h * h);


            if (BMI < 18.5)
                Console.WriteLine("НЕУХРАЊЕНОСТ");

            else if(18.5 <= BMI && BMI<30)
                Console.WriteLine("ИДЕАЛА МАСА");
            else
                Console.WriteLine("ГОЈАЗНОСТ");
           
    }
}
